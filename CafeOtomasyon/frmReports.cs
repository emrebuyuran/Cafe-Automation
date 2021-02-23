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
using System.Windows.Forms.DataVisualization.Charting;
using CafeOtomasyon.Class;

namespace CafeOtomasyon
{
    public partial class frmReports : Form
    {
        public frmReports()
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
            ShowCategories();
        }

        Category category = new Category();

        private void ShowCategories()
        {
            General general = new General();
            ArrayList categoriesArrayList = new ArrayList();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select CATEGORYNAME from categories where STATUS=0", con);
            SqlDataReader dr = null;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            dr = cmd.ExecuteReader();

            int j = 0;
            while (dr.Read())
            {
                categoriesArrayList.Add(dr["CATEGORYNAME"]);

                for (int i = 1; i < 2; i++)
                {


                    while (j < categoriesArrayList.Count)
                    {
                        if (categoriesArrayList.Count < 3)
                        {
                            Button btn = new Button();
                            btn.Name = "btnCategory" + categoriesArrayList.Count.ToString();
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
                            btn.Name = "btnCategory" + categoriesArrayList.Count.ToString();
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
                            btn.Name = "btnCategory" + categoriesArrayList.Count.ToString();
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
                            btn.Name = "btnCategory" + categoriesArrayList.Count.ToString();
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
                            btn.Name = "btnCategory" + categoriesArrayList.Count.ToString();
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
        private void btnCategory_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            chReport.Palette = ChartColorPalette.None;
            chReport.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chReport.Series[0].Color = Color.Red;
            Product product = new Product();
            lvStatistics.Items.Clear();
            string x = btn.Name;
            int length = x.Length;
            int catid = 0;
            if (length == 12)
            {
                catid = Convert.ToInt32(x.Substring(length - 1, 1));
            }
            else
            {
                catid = Convert.ToInt32(x.Substring(length - 2, 2));
            }

            product.SortProductsByStatisticsByProductId(lvStatistics, dtpStart, dtpEnd, catid);


            gbxStatistics.Text = btn.Text + " istatistiği";
            if (lvStatistics.Items.Count > 0)
            {
                chReport.Series["Satışlar"].Points.Clear();
                for (int i = 0; i < lvStatistics.Items.Count; i++)
                {
                    chReport.Series["Satışlar"].Points.AddXY(lvStatistics.Items[i].SubItems[0].Text, lvStatistics.Items[i].SubItems[1].Text);
                }
            }
            else
            {
                MessageBox.Show("Seçili zaman aralığında istatistik bulunamadı !", "HATA");
            }

        }

        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            chReport.Palette = ChartColorPalette.None;
            chReport.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chReport.Series[0].Color = Color.DarkGoldenrod;
            Product product = new Product();
            lvStatistics.Items.Clear();
            product.SortProductsByStatistics(lvStatistics, dtpStart, dtpEnd);


            gbxStatistics.Text = "TÜM ÜRÜNLER" + " istatistiği";
            if (lvStatistics.Items.Count > 0)
            {
                chReport.Series["Satışlar"].Points.Clear();
                for (int i = 0; i < lvStatistics.Items.Count; i++)
                {
                    chReport.Series["Satışlar"].Points.AddXY(lvStatistics.Items[i].SubItems[0].Text, lvStatistics.Items[i].SubItems[1].Text);
                }
            }
            else
            {
                MessageBox.Show("Seçili zaman aralığında istatistik bulunamadı !", "HATA");
            }
        }

        private void chReport_Click(object sender, EventArgs e)
        {

        }
    }
}
