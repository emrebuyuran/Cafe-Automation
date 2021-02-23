using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Class;

namespace CafeOtomasyon
{
    public partial class frmTables : Form
    {
        public frmTables()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
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


        private void btnTable_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            frmOrders frm = new frmOrders();
            int length = btn.Text.Length;
            General._buttonValue = btn.Text.Substring(length - 6, 6);
            General._buttonName = btn.Name;

            this.Close();
            frm.ShowDialog();

        }

       

        General general = new General();

        private void frmTables_Load(object sender, EventArgs e)
        {
            ShowTables();
          
        }

  
        private void ShowTables()
        {
            ArrayList tablesArrayList = new ArrayList();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select ID,STATUS from tables", con);
            SqlDataReader dr = null;
            
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            dr = cmd.ExecuteReader();

            int j = 0;
            while (dr.Read())
            {
                tablesArrayList.Add(Convert.ToInt32(dr["ID"]));
               
                for (int i = 1; i < 2; i++)
                {
                    

                    while (j<tablesArrayList.Count)
                    {
                        if (tablesArrayList.Count < 6)
                        {
                            Button btn = new Button();
                            btn.Name = "btnTable" + tablesArrayList.Count.ToString();
                            btn.Text = "Masa " + tablesArrayList.Count.ToString();
                            btn.Size = new Size(142, 96);
                            btn.Location = new Point(88+149*j,65*i);
                            btn.BackgroundImageLayout= System.Windows.Forms.ImageLayout.Stretch;
                            btn.Click+=new EventHandler(this.btnTable_Click);
                            this.Controls.Add(btn);
                            
                            j++;

                        }
                        else if (10> tablesArrayList.Count && tablesArrayList.Count > 5)
                        {
                            Button btn = new Button();
                            btn.Name = "btnTable" + tablesArrayList.Count.ToString();
                            btn.Text = "Masa " + tablesArrayList.Count.ToString();
                            btn.Size = new Size(142, 96);
                            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            btn.Location = new Point(88+149 * (j-5), 167 * i);
                            btn.Click += new EventHandler(this.btnTable_Click);
                            this.Controls.Add(btn);
                            j++;
                            
                        }

                        else if (tablesArrayList.Count == 10)
                        {
                            Button btn = new Button();
                            btn.Name = "btnTable" + tablesArrayList.Count.ToString();
                            btn.Text = "Masa" + tablesArrayList.Count.ToString();
                            btn.Size = new Size(142, 96);
                            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            btn.Location = new Point(88 + 149 * (j - 5), 167 * i);
                            btn.Click += new EventHandler(this.btnTable_Click);
                            this.Controls.Add(btn);
                            j++;
                        }
                        else if (15>= tablesArrayList.Count && tablesArrayList.Count > 10)
                        {
                            Button btn = new Button();
                            btn.Name = "btnTable" + tablesArrayList.Count.ToString();
                            btn.Text = "Masa" + tablesArrayList.Count.ToString();
                            btn.Size = new Size(142, 96);
                            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            btn.Location = new Point(88 + 149 * (j - 10), 269 * i);
                            btn.Click += new EventHandler(this.btnTable_Click);
                            this.Controls.Add(btn);
                            j++;

                        }

                    }

                }

                foreach (Control item in this.Controls)

                {
                    if (item is Button)
                    {
                        if (item.Name == "btnTable" + dr["ID"].ToString() && dr["STATUS"].ToString() == "1")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.tableisempty);

                        }
                        else if (item.Name == "btnTable" + dr["ID"].ToString() && dr["STATUS"].ToString() == "2")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.tableisnotempty);
                        }
                        else if (item.Name == "btnTable" + dr["ID"].ToString() && dr["STATUS"].ToString() == "3")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.tablereserve);
                        }
                        else if (item.Name == "btnTable" + dr["ID"].ToString() && dr["STATUS"].ToString() == "4")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.tableopenreserve);
                        }
                    }
                }


            }
            tablesArrayList.Clear();
            dr.Close();
            con.Dispose();
            con.Close();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnTableOperations_Click(object sender, EventArgs e)
        {
            frmTableOperations frm = new frmTableOperations();
            this.Close();
            frm.Show();
        }
    }

}
