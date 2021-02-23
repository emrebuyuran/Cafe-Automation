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
    public partial class frmCashTransactions : Form
    {
        public frmCashTransactions()
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

        private void frmReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.DataSet1.DataTable2);
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);

            this.rpvReport.RefreshReport();
            this.rpvZReport.RefreshReport();
            rpvZReport.Visible = false;
            lblMonthlyReport.Text = "AYLIK RAPOR";

        }

        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            lblMonthlyReport.Text = "AYLIK RAPOR";
            rpvReport.Visible = true;
            rpvZReport.Visible = false;
        }

        private void btnZReport_Click(object sender, EventArgs e)
        {
            lblMonthlyReport.Text = "GÜNLÜK RAPOR";
            rpvReport.Visible = false;
            rpvZReport.Visible = true;
        }

        private void rpvReport_Load(object sender, EventArgs e)
        {

        }
    }
}
