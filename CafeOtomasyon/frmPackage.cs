using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class frmPackage : Form
    {
        public frmPackage()
        {
            InitializeComponent();
        }

        private void frmPackage_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmPackageOrders frm = new frmPackageOrders();
            this.Close();
            frm.Show();
        }

        private void btnShowPackOrders_Click(object sender, EventArgs e)
        {
            frmOrderControl frm = new frmOrderControl();
            this.Hide();
            frm.Show();
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
    }
}
