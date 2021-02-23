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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnTableOrder_Click(object sender, EventArgs e)
        {
            frmTables frm = new frmTables();
            this.Close();
            frm.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            frmReservations frm = new frmReservations();
            this.Close();
            frm.Show();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            frmKitchen frm = new frmKitchen();
            this.Close();
            frm.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            {
                PersonnelTask personnelTask = new PersonnelTask();
                int taskid = personnelTask.PersonnelTasks(General._personnelId);
                if (taskid != 1)
                {
                    MessageBox.Show("Bu sayfaya erişim izniniz yok !", "HATA", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    frmCashTransactions frm = new frmCashTransactions();
                    this.Close();
                    frm.Show();
                }

            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerSearch frm = new frmCustomerSearch();
            this.Close();
            frm.Show();
        }

        private void btnPackageOrder_Click(object sender, EventArgs e)
        {
            frmPackage frm = new frmPackage();
            this.Close();
            frm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            {
                PersonnelTask personnelTask = new PersonnelTask();
                int taskid = personnelTask.PersonnelTasks(General._personnelId);
                if (taskid != 1)
                {
                    MessageBox.Show("Bu sayfaya erişim izniniz yok !", "HATA", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    frmReports frm = new frmReports();
                    this.Close();
                    frm.Show();
                }

            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
         
                frmSettings frm = new frmSettings();
                this.Close();
                frm.Show();
            
            
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            frmSignIn frm = new frmSignIn();
            this.Close();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
