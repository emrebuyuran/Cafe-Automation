using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Class;

namespace CafeOtomasyon
{
    public partial class frmTableOperations : Form
    {
        public frmTableOperations()
        {
            InitializeComponent();
        }

        private void frmTableOperations_Load(object sender, EventArgs e)
        {
            TableOperations tbl = new TableOperations();
            tbl.Listele();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmTables frm = new frmTables();
            this.Close();
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

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            TableOperations table = new TableOperations();
            try
            {
                
                table.AddTable(table);
                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }


        General general = new General();
        public void btnDeleteTable_Click(object sender, EventArgs e)
        {
            TableOperations tbl = new TableOperations();
           tbl.DeleteTable();

        }

        private void tbxTableId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
    }


