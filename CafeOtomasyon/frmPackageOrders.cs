using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Class;

namespace CafeOtomasyon
{
    public partial class frmPackageOrders : Form
    {
        public frmPackageOrders()
        {
            InitializeComponent();
        }

        private void frmPackageOrders_Load(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.GetCustomer(lvCustomers);
            ShowCategories();
            btn1.Click += new EventHandler(Calculate);
            btn2.Click += new EventHandler(Calculate);
            btn3.Click += new EventHandler(Calculate);
            btn4.Click += new EventHandler(Calculate);
            btn5.Click += new EventHandler(Calculate);
            btn6.Click += new EventHandler(Calculate);
            btn7.Click += new EventHandler(Calculate);
            btn8.Click += new EventHandler(Calculate);
            btn9.Click += new EventHandler(Calculate);
            btn0.Click += new EventHandler(Calculate);
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
        int packOrderId = 0;
        int AdditionId = 0;
        int count = 0;
        int count1 = 0;
        private void lvMenu_DoubleClick(object sender, EventArgs e)
        {

            if (tbxQuantity.Text == "")
            {
                tbxQuantity.Text = "1";
            }

            if (lvMenu.Items.Count > 0)
            {
                count = lvOrders.Items.Count;
                lvOrders.Items.Add(lvMenu.SelectedItems[0].Text);
                lvOrders.Items[count].SubItems.Add(tbxQuantity.Text);
                lvOrders.Items[count].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvOrders.Items[count].SubItems.Add((Convert.ToDecimal(lvMenu.SelectedItems[0].SubItems[1].Text)
                                                    * Convert.ToDecimal(tbxQuantity.Text)).ToString());
                lvOrders.Items[count].SubItems.Add("0");
                count1 = lvNewAdded.Items.Count;
                lvOrders.Items[count].SubItems.Add(count1.ToString());

                lvNewAdded.Items.Add(AdditionId.ToString());
                lvNewAdded.Items[count1].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvNewAdded.Items[count1].SubItems.Add(tbxQuantity.Text);
                lvNewAdded.Items[count1].SubItems.Add(packOrderId.ToString());
                lvNewAdded.Items[count1].SubItems.Add(count1.ToString());
                count1++;
                tbxQuantity.Text = "";

            }
        }

        private void lvOrders_DoubleClick(object sender, EventArgs e)
        {
            if (lvOrders.Items.Count > 0)
            {
                if (lvOrders.SelectedItems[0].SubItems[4].Text != "0")
                {
                    Order order = new Order();
                    order.setDeleteOrder(Convert.ToInt32(lvOrders.SelectedItems[0].SubItems[4].Text));

                }
                else
                {
                    for (int i = 0; i < lvNewAdded.Items.Count; i++)
                    {
                        if (lvNewAdded.Items[i].SubItems[4].Text == lvOrders.SelectedItems[0].SubItems[5].Text)
                        {
                            lvNewAdded.Items.RemoveAt(i);
                        }
                    }
                }

                lvOrders.Items.RemoveAt(lvOrders.SelectedItems[0].Index);
            }
        }

        //private void btnPayment_Click(object sender, EventArgs e)
        //{
        //    Bill bill = new Bill();
        //    General._serviceTypeId = 5;
        //    General._additionId = bill.getByAdditionPack(5).ToString();
        //    frmPayment frm = new frmPayment();
        //    this.Close();
        //    frm.Show();

        //}
        void Calculate(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btn1":
                    tbxQuantity.Text += (1).ToString();
                    break;
                case "btn2":
                    tbxQuantity.Text += (2).ToString();
                    break;
                case "btn3":
                    tbxQuantity.Text += (3).ToString();
                    break;
                case "btn4":
                    tbxQuantity.Text += (4).ToString();
                    break;
                case "btn5":
                    tbxQuantity.Text += (5).ToString();
                    break;
                case "btn6":
                    tbxQuantity.Text += (6).ToString();
                    break;
                case "btn7":
                    tbxQuantity.Text += (7).ToString();
                    break;
                case "btn8":
                    tbxQuantity.Text += (8).ToString();
                    break;
                case "btn9":
                    tbxQuantity.Text += (9).ToString();
                    break;
                case "btn0":
                    tbxQuantity.Text += (0).ToString();
                    break;

                default:
                    MessageBox.Show("Sayı Girin!");
                    break;
            }
        }
        General general = new General();
        Category category = new Category();
        private void btnCategory_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            category.getByProductType(lvMenu, btn);



        }
        private void ShowCategories()
        {
            ArrayList categoriesArrayList = new ArrayList();
            ArrayList catIdArrayList = new ArrayList();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select ID, CATEGORYNAME from categories where STATUS=0", con);
            SqlDataReader dr = null;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            dr = cmd.ExecuteReader();

            int j = 0;
            while (dr.Read())
            {
                catIdArrayList.Add(dr["ID"]);
                categoriesArrayList.Add(dr["CATEGORYNAME"]);

                for (int i = 1; i < 2; i++)
                {


                    while (j < categoriesArrayList.Count)
                    {
                        if (categoriesArrayList.Count < 3)
                        {
                            Button btn = new Button();
                            btn.Name = "btnCategory" + catIdArrayList[j].ToString();
                            btn.Text = dr["CATEGORYNAME"].ToString();
                            btn.Size = new Size(176, 60);
                            btn.Location = new Point(25 + 182 * (j), 90 * i);
                            btn.Click += new EventHandler(this.btnCategory_Click);
                            btn.ForeColor = Color.White;
                            btn.BackColor = Color.DarkGreen;
                            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                            this.Controls.Add(btn);

                            j++;

                        }
                        else if (5 > categoriesArrayList.Count && categoriesArrayList.Count > 2)
                        {
                            Button btn = new Button();
                            btn.Name = "btnCategory" + catIdArrayList[j].ToString();
                            btn.Text = dr["CATEGORYNAME"].ToString();
                            btn.Size = new Size(176, 60);
                            btn.Location = new Point(25 + 182 * (j - 2), 155 * i);
                            btn.Click += new EventHandler(this.btnCategory_Click);
                            btn.ForeColor = Color.White;
                            btn.BackColor = Color.DarkRed;
                            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                            this.Controls.Add(btn);
                            j++;

                        }
                        else if (7 > categoriesArrayList.Count && categoriesArrayList.Count > 4)
                        {
                            Button btn = new Button();
                            btn.Name = "btnCategory" + catIdArrayList[j].ToString();
                            btn.Text = dr["CATEGORYNAME"].ToString();
                            btn.Size = new Size(176, 60);
                            btn.Location = new Point(25 + 182 * (j - 4), 220 * i);
                            btn.Click += new EventHandler(this.btnCategory_Click);
                            btn.ForeColor = Color.White;
                            btn.BackColor = Color.DarkSlateBlue;
                            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                            this.Controls.Add(btn);
                            j++;

                        }
                        else if (9 > categoriesArrayList.Count && categoriesArrayList.Count > 6)
                        {
                            Button btn = new Button();
                            btn.Name = "btnCategory" + catIdArrayList[j].ToString();
                            btn.Text = dr["CATEGORYNAME"].ToString();
                            btn.Size = new Size(176, 60);
                            btn.Location = new Point(25 + 182 * (j - 6), 285 * i);
                            btn.Click += new EventHandler(this.btnCategory_Click);
                            btn.ForeColor = Color.White;
                            btn.BackColor = Color.DarkMagenta;
                            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                            this.Controls.Add(btn);
                            j++;

                        }
                        else if (10 >= categoriesArrayList.Count && categoriesArrayList.Count > 8)
                        {
                            Button btn = new Button();
                            btn.Name = "btnCategory" + catIdArrayList[j].ToString();
                            btn.Text = dr["CATEGORYNAME"].ToString();
                            btn.Size = new Size(176, 60);
                            btn.Location = new Point(25 + 182 * (j - 8), 350 * i);
                            btn.Click += new EventHandler(this.btnCategory_Click);
                            btn.ForeColor = Color.White;
                            btn.BackColor = Color.DarkGoldenrod;
                            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                            this.Controls.Add(btn);
                            j++;

                        }

                    }


                }

            }
            categoriesArrayList.Clear();
            dr.Close();
            con.Dispose();
            con.Close();
        }
        ArrayList removed = new ArrayList();
        private void btnOrder_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            Order order = new Order();
            frmPackage frm = new frmPackage();
            PackageOrders packageOrders = new PackageOrders();
            int customerId = 0;
            customerId = Convert.ToInt32(lvCustomers.SelectedItems[0].SubItems[0].Text);
            bool result = false;

            bill.ServiceTypeId = 5;
            bill.PersonnelId = General._personnelId;
            bill.Date = DateTime.Now;
            result = bill.setByPackId(bill);

            packageOrders.CustomerID = customerId;
            packageOrders.AdditionID = bill.getByPackageBillbyCustomerId(customerId);
            packageOrders.Statement = "Paket";
            packageOrders.PackageOrderAdd(packageOrders);

            if (lvOrders.Items.Count > 0)
            {
                for (int i = 0; i < lvOrders.Items.Count; i++)
                {
                    order.ProductId = Convert.ToInt32(lvOrders.Items[i].SubItems[2].Text);
                    order.BillID = bill.getByAdditionPack(5);
                    order.Quantity = Convert.ToInt32(lvOrders.Items[i].SubItems[1].Text);
                    order.setSaveOrderPack(order);
                }

                this.Close();
                frm.Show();
            }
            else
            {
                if (lvNewAdded.Items.Count > 0)
                {
                    for (int i = 0; i < lvNewAdded.Items.Count; i++)
                    {
                        order.ProductId = Convert.ToInt32(lvNewAdded.Items[i].SubItems[1].Text);
                        order.BillID = bill.getByAdditionPack(5);
                        order.Quantity = Convert.ToInt32(lvNewAdded.Items[i].SubItems[2].Text);
                        order.setSaveOrderPack(order);
                    }

                }

                if (removed.Count > 0)
                {
                    foreach (string item in removed)
                    {
                        order.setDeleteOrder(Convert.ToInt32(item));
                    }
                }

                this.Close();
                frm.Show();
            }





        }
    }
}
