using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Class;

namespace CafeOtomasyon
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        Order order = new Order();

        int paymentType = 0;

        private void frmPayment_Load(object sender, EventArgs e)
        {
            if (General._serviceTypeId == 1)
            {
                lblAdditionId.Text = General._additionId;
                tbxDiscount.TextChanged += new EventHandler(tbxDiscount_TextChanged);
                order.GetByOrder(lvProducts, Convert.ToInt32(lblAdditionId.Text));

                if (lvProducts.Items.Count > 0)
                {
                    decimal total = 0;
                    for (int i = 0; i < lvProducts.Items.Count; i++)
                    {
                        total += Convert.ToDecimal(lvProducts.Items[i].SubItems[3].Text);

                    }

                    lblTotalAmount.Text = string.Format("{0:0.000}", total);
                    lblSubtotalAmount.Text = string.Format("{0:0.000}", total);

                    decimal tax = Convert.ToDecimal(lblSubtotalAmount.Text) * 18 / 100;
                    lblTaxPrice.Text = string.Format("{0:0.000}", tax);
                }

                gbxDiscountAmount.Visible = true;
                tbxDiscount.Clear();
            }
            else if (General._serviceTypeId == 5)
            {
                lblAdditionId.Text = General._additionId;
                PackageOrders packageOrders = new PackageOrders();
                tbxDiscount.TextChanged += new EventHandler(tbxDiscount_TextChanged);
                order.GetByOrder(lvProducts, Convert.ToInt32(lblAdditionId.Text));

                if (paymentType == 1)
                {
                    rbtnCash.Checked = true;

                }

                else if (paymentType == 2)
                {
                    rbtnCreditCard.Checked = true;
                }

                else if (paymentType == 3)
                {
                    rbtnTicket.Checked = true;
                }

                if (lvProducts.Items.Count > 0)
                {
                    decimal total = 0;
                    for (int i = 0; i < lvProducts.Items.Count; i++)
                    {
                        total += Convert.ToDecimal(lvProducts.Items[i].SubItems[3].Text);

                    }

                    lblTotalAmount.Text = string.Format("{0:0.000}", total);
                    lblSubtotalAmount.Text = string.Format("{0:0.000}", total);

                    decimal tax = Convert.ToDecimal(lblSubtotalAmount.Text) * 18 / 100;
                    lblTaxPrice.Text = string.Format("{0:0.000}", tax);
                }

                gbxDiscountAmount.Visible = true;
                tbxDiscount.Clear();
            }

        }

        decimal result = 0;

        private void tbxDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbxDiscount.Text == "")
                {
                    tbxDiscount.Text = "";
                }
                else
                {
                    if (Convert.ToDecimal(0) <= Convert.ToDecimal(tbxDiscount.Text) &&
                        Convert.ToDecimal(tbxDiscount.Text) <= Convert.ToDecimal(100))
                    {
                        try
                        {
                            result = Convert.ToDecimal(lblTotalAmount.Text);
                            if (chbxDiscount.Checked)
                            {
                                lblDiscountPrice.Text = (result * Convert.ToDecimal(tbxDiscount.Text) / 100).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Hatalı değer girdiniz !", "Uyarı", MessageBoxButtons.OK);
                            }

                        }
                        catch (Exception)
                        {
                            lblDiscountPrice.Text = string.Format("{0:0.000}", 0);
                        }


                    }
                }
            }


            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public void chbxDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxDiscount.Checked)
            {
                gbxDiscountAmount.Enabled = true;
                tbxDiscount.Clear();

            }
            else
            {
                gbxDiscountAmount.Enabled = false;
                tbxDiscount.Clear();
            }
        }

        Table table = new Table();
        Reservation reservation = new Reservation();

     
        private void btnPayment_Click(object sender, EventArgs e)
        {
            int customerId = 0;
            if (General._serviceTypeId == 1)
            {
                int tableId = table.TableGetByNumber(General._buttonName);
              

                if (table.TableGetByState(tableId, 4) == true)
                {
                    customerId = reservation.getByCustomerId(tableId);
                }
                else
                {
                    customerId = 1;
                }

                int paymentTypeId = 0;

                if (rbtnCash.Checked == true)
                {
                    paymentTypeId = 1;
                }

                if (rbtnCreditCard.Checked == true)
                {
                    paymentTypeId = 2;
                }

                if (rbtnTicket.Checked == true)
                {
                    paymentTypeId = 3;
                }


                Payment payment = new Payment();

                payment.BillId = Convert.ToInt32(lblAdditionId.Text);
                payment.PaymentTypeId = paymentTypeId;
                payment.CustomerId = customerId;
                payment.SubTotal = Convert.ToDecimal(lblSubtotalAmount.Text);
                payment.Discount = Convert.ToDecimal(lblDiscountPrice.Text);
                payment.Tax = Convert.ToDecimal(lblTaxPrice.Text);
                payment.TotalAmount = Convert.ToDecimal(lblTotalAmount.Text);

                bool result = payment.closeBill(payment);

                if (result == true)
                {
                    MessageBox.Show("Hesap Ödemesi Başarılı !", "Hesap Kapatıldı");
                    
                    table.SetTableState(tableId.ToString(), 1);

                    Reservation reservation = new Reservation();

                    reservation.ReservationClose(Convert.ToInt32(lblAdditionId.Text));

                    Bill bill = new Bill();
                    bill.BillClose(Convert.ToInt32(lblAdditionId.Text), 0);

                    this.Close();
                    frmTables frm = new frmTables();
                    frm.Show();

                }

                else
                {
                    MessageBox.Show("Hesap Ödemesi yapılırken bir hata oluştu !", "HATA");
                }

            }

            else if (General._serviceTypeId == 5)
            {
              PackageOrders po = new PackageOrders();
              int customerID = po.getCustomerIdForBillClose();


                int paymentTypeId = 0;

                if (rbtnCash.Checked == true)
                {
                    paymentTypeId = 1;
                }

                if (rbtnCreditCard.Checked == true)
                {
                    paymentTypeId = 2;
                }

                if (rbtnTicket.Checked == true)
                {
                    paymentTypeId = 3;
                }
                Payment payment = new Payment();
                payment.BillId = Convert.ToInt32(lblAdditionId.Text);
                payment.PaymentTypeId = paymentTypeId;
                payment.CustomerId = customerID; //Paket sipariş id'si gelecek.
                payment.SubTotal = Convert.ToDecimal(lblSubtotalAmount.Text);
                payment.Discount = Convert.ToDecimal(lblDiscountPrice.Text);
                payment.Tax = Convert.ToDecimal(lblTaxPrice.Text);
                payment.TotalAmount = Convert.ToDecimal(lblTotalAmount.Text);

                bool result = payment.closeBill(payment);

                if (result == true)
                {
                    


                    Bill bill = new Bill();
                    bill.BillClose(Convert.ToInt32(lblAdditionId.Text), 1);

                    PackageOrders packageOrders = new PackageOrders();
                    packageOrders.PackageOrderPay(Convert.ToInt32(lblAdditionId.Text));
                    
                    MessageBox.Show("Hesap Ödemesi Başarılı !", "Hesap Kapatıldı");
                    this.Close();
                    frmMenu frm = new frmMenu();
                    frm.Show();

                }

                else
                {
                    MessageBox.Show("Hesap Ödemesi yapılırken bir hata oluştu !", "HATA");
                }

            }

        }

        private void lblDiscountPrice_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblDiscountPrice.Text) > 0)
            {
                decimal payment = 0;
                lblSubtotalAmount.Text = lblTotalAmount.Text;
                payment = Convert.ToDecimal(lblTotalAmount.Text) - Convert.ToDecimal(lblDiscountPrice.Text);
                lblSubtotalAmount.Text = string.Format("{0:0.000}", payment);

            }

            decimal tax = Convert.ToDecimal(lblSubtotalAmount.Text) * 18 / 100;
            lblTaxPrice.Text = string.Format("{0:0.000}", tax);
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

      

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font Header = new Font("Verdana", 15, FontStyle.Bold);
            Font subHeader = new Font("Verdana", 12, FontStyle.Regular);
            Font Text = new Font("Verdana", 10);
            SolidBrush solidBrush = new SolidBrush(Color.Black);

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("BUYURAN RESTAURANT", Header, solidBrush, 250, 100, stringFormat);
       
            e.Graphics.DrawString("Ürün Adı                 Adet                    Fiyat", subHeader, solidBrush, 150, 250,
                stringFormat);
        
            for (int i = 0; i < lvProducts.Items.Count; i++)
            {
                e.Graphics.DrawString(lvProducts.Items[i].SubItems[0].Text, Text, solidBrush, 150, 350 + i * 30,
                    stringFormat);
                e.Graphics.DrawString(lvProducts.Items[i].SubItems[1].Text, Text, solidBrush, 350, 350 + i * 30,
                    stringFormat);
                e.Graphics.DrawString(lvProducts.Items[i].SubItems[3].Text, Text, solidBrush, 420, 350 + i * 30,
                    stringFormat);
            }

          
            e.Graphics.DrawString("İndirim Tutarı  :          " + lblDiscountPrice.Text + "TL", subHeader, solidBrush,
                250, 350 + 30 * (lvProducts.Items.Count + 1), stringFormat);
            e.Graphics.DrawString("KDV Tutarı      :          " + lblTaxPrice.Text + "TL", subHeader, solidBrush, 250,
                350 + 30* (lvProducts.Items.Count + 2), stringFormat);
            e.Graphics.DrawString("Toplam Tutar    :          " + lblTotalAmount.Text + "TL", subHeader, solidBrush,
                250, 350 + 30 * (lvProducts.Items.Count + 3), stringFormat);
            e.Graphics.DrawString("Ödediğiniz Tutar:          " + lblSubtotalAmount.Text + "TL", subHeader,
                solidBrush, 250, 350 + 30 * (lvProducts.Items.Count + 4), stringFormat);
        }

        private void lblAdditionId_Click(object sender, EventArgs e)
        {

        }

        private void rbtnCash_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
