using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Class;

namespace CafeOtomasyon
{
    public partial class frmReservations : Form
    {
        public frmReservations()
        {
            InitializeComponent();
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

        private void frmReservations_Load(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.GetCustomer(lvCustomers);

            Table table = new Table();
            table.GetTableState(cbTable);

            dtpDate.MinDate = DateTime.Today;
            dtpDate.Format = DateTimePickerFormat.Time;


        }

        private void tbxCustomerName_TextChanged(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerGetByName(lvCustomers, tbxCustomerName.Text);
        }

        private void tbxGSM_TextChanged(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerGetByGSM(lvCustomers, tbxGSM.Text);
        }

        private void tbxAddress_TextChanged(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerGetByName(lvCustomers, tbxAddress.Text);
        }

        public void Clear()
        {
            tbxAddress.Clear();
            tbxCustomerName.Clear();
            tbxGSM.Clear();
            tbxTable.Clear();
            tbxDate.Clear();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();

            if (lvCustomers.SelectedItems.Count > 0)
            {
                bool result =
                    reservation.ReservationControl(Convert.ToInt32(lvCustomers.SelectedItems[0].SubItems[0].Text));
                if (!result)
                {
                    if (tbxDate.Text != "")
                    {
                        Table table = new Table();  

                        if (table.TableGetByState(Convert.ToInt32(tbxTableId.Text), 1))
                        {
                            Bill bill = new Bill();
                            bill.Date = Convert.ToDateTime(tbxDate.Text);
                            bill.ServiceTypeId = 1;
                            bill.TableId = Convert.ToInt32(tbxTableId.Text);
                            bill.PersonnelId = General._personnelId;

                            reservation.CustomerId =
                                Convert.ToInt32(Convert.ToInt32(lvCustomers.SelectedItems[0].SubItems[0].Text));
                            reservation.TableId = Convert.ToInt32(tbxTableId.Text);
                            reservation.Date = Convert.ToDateTime(tbxDate.Text);
                            reservation.Description = tbxStatement.Text;

                            reservation.BillId = bill.OpenReservaionBill(bill);
                            result = reservation.ReservationOpen(reservation);
                            table.SetTableState(tbxTableId.Text, 3);
                            if (result)
                            {
                                MessageBox.Show("Rezervasyon başarıyla açılmıştır !");
                                Clear();
                            }
                            else
                            {
                                MessageBox.Show("Rezervasyon kaydı gerçekleştirilemedi!", "HATA", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Rezervasyon yapmak istediğiniz masa şu an dolu!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir tarih seçiniz !", "HATA", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Bu müşteri üzerine açık bir rezervasyon bulunmaktadır !", "HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void dtpDate_MouseEnter(object sender, EventArgs e)
        {
            dtpDate.Width = 200;
        }

        private void dtpDate_Enter(object sender, EventArgs e)
        {
            dtpDate.Width = 200;
        }

        private void dtpDate_MouseLeave(object sender, EventArgs e)
        {
            dtpDate.Width = 23;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            tbxDate.Text = dtpDate.Value.ToString();
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxTable.Text = cbTable.SelectedItem.ToString();

            Table table = (Table)cbTable.SelectedItem;
            tbxTableId.Text = Convert.ToString(table.ID);
            

        }

        private void cbTable_MouseEnter(object sender, EventArgs e)
        {
            cbTable.Width = 200;
        }

        private void cbTable_MouseLeave(object sender, EventArgs e)
        {
            cbTable.Width = 23;
        }

        private void btnShowReservations_Click(object sender, EventArgs e)
        {
            frmOrderControl frm = new frmOrderControl();
            this.Close();
            frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCustomerAdd frm = new frmCustomerAdd();
            General._customerAdd = 0;
            frm.btnUpdateCustomer.Visible = false;
            frm.btnAddNewCustomer.Visible = true;
            this.Close();
            frm.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvCustomers.Items.Count>0)
            {
                frmCustomerAdd frm = new frmCustomerAdd();
                General._customerAdd = 0;
                General._customerId = Convert.ToInt32(lvCustomers.SelectedItems[0].SubItems[0].Text);
                frm.btnUpdateCustomer.Visible = true;
                frm.btnAddNewCustomer.Visible = false;
                this.Close();
                frm.Show();
            }
        }

        private void btnShowReservations_Click_1(object sender, EventArgs e)
        {
            frmReservationControl frm = new frmReservationControl();
            this.Close();
            frm.Show();
        }

        private void tbxDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
