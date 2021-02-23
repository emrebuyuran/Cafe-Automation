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
    public partial class frmCustomerSearch : Form
    {
        public frmCustomerSearch()
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

        private void frmCustomerSearch_Load(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.GetCustomer(lvCustomers);

        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerAdd frm = new frmCustomerAdd();
            General._customerAdd = 1;
            frm.btnAddNewCustomer.Visible = true;
            frm.btnUpdateCustomer.Visible = false;
            frm.Show();
            this.Close();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (lvCustomers.SelectedItems.Count>0)
            {
                frmCustomerAdd frm = new frmCustomerAdd();
                General._customerAdd = 1;
                General._customerId = Convert.ToInt32(lvCustomers.SelectedItems[0].SubItems[0].Text);
                frm.btnAddNewCustomer.Visible = false;
                frm.btnUpdateCustomer.Visible = true;
                this.Close();
                frm.Show();
            }
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerGetByName(lvCustomers, tbxName.Text);
        }

        private void tbxSurname_TextChanged(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerGetBySurname(lvCustomers, tbxSurname.Text);
        }

        private void tbxGSM_TextChanged(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerGetByGSM(lvCustomers, tbxGSM.Text);
        }

        private void tbxBillId_TextChanged(object sender, EventArgs e)
        {
            if (tbxBillId.Text!="")
            {
                PackageOrders packageOrders = new PackageOrders();
                General._additionId = (tbxBillId.Text);
                bool result = packageOrders.getBillId(Convert.ToInt32(tbxBillId.Text));
                if (result)
                {
                    frmPayment frm = new frmPayment();
                    General._serviceTypeId = 5;
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(tbxBillId.Text +"Nolu adisyon bulunamadı!", "Hata");
                }

            }
            else
            {
                MessageBox.Show("Aramak istediğiniz adisyon no'yu yazınız !", "Hata");
            }
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrderControl frm = new frmOrderControl();
            frm.Show();
            this.Hide();
        }
    }
}
