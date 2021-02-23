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
    public partial class frmOrderControl : Form
    {
        public frmOrderControl()
        {
            InitializeComponent();
        }

        private void frmOrderControl_Load(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            int buttoncount = bill.getByPackageId();
            bill.getByPackageBill(lvControl);
            int down = 5;
            int left = 50;
            int division = Convert.ToInt32(Math.Ceiling(Math.Sqrt(buttoncount)));

            for (int i = 1; i <= buttoncount; i++)
            {
                Button btn = new Button();
                btn.AutoSize = false;
                btn.Size = new Size(179, 80);

                btn.FlatStyle = FlatStyle.Flat;
                btn.Name = lvControl.Items[i - 1].SubItems[0].Text;
                btn.Text = lvControl.Items[i - 1].SubItems[1].Text;
                btn.Font = new Font(btn.Font.FontFamily.Name,10);
                btn.Location = new Point(left,down);
                btn.ForeColor = Color.White;
                btn.BackColor = Color.DarkRed;
                this.Controls.Add(btn);

                left += btn.Width + 5;
                if (i==4)
                {
                    left = 50;
                    down +=85;
                }
                btn.Click+= new EventHandler(dynamicMethod);
                btn.MouseEnter+= new EventHandler(dynamicMethod2);
            }

        }
        
        private void dynamicMethod(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            Button dynamicButton = (sender as Button);
            frmPayment frm = new frmPayment();
            General._serviceTypeId = 5;
            General._additionId =Convert.ToString(bill.CustomerLastBillId(Convert.ToInt32(dynamicButton.Name)));
            this.Close();
            frm.Show();
        }
        private void dynamicMethod2(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            Order order = new Order();
            Button dynamicButton = (sender as Button);
            bill.CustomerDetails(lvCustomerDetails, Convert.ToInt32(dynamicButton.Name));
            LastOrderDate();
            lvOrderDetails.Items.Clear();
            General._serviceTypeId = 5;




        }

        void LastOrderDate()
        {
            if (lvCustomerDetails.Items.Count>0)
            {
                int count = lvCustomerDetails.Items.Count;
                lblLastOrderDate.Text = lvCustomerDetails.Items[count-1].SubItems[3].Text;
                tbxTotalPrice.Text = count + " Adet";

            }
        }

        void Sum()
        {
            int savingsCount = lvOrderDetails.Items.Count;
            decimal Sum = 0;
            for (int i = 0; i < savingsCount; i++)
            {
                Sum+=Convert.ToDecimal(lvOrderDetails.Items[i].SubItems[2].Text)* Convert.ToDecimal(lvOrderDetails.Items[i].SubItems[3].Text);
            }

            lblTotalOrder.Text = Sum.ToString()+" TL";
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

        private void lvCustomerDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order order = new Order();
            if (lvCustomerDetails.SelectedItems.Count>0)
            {
                order.packOrderDetails(lvOrderDetails,Convert.ToInt32(lvCustomerDetails.SelectedItems[0].SubItems[4].Text));
                Sum();
           
            }
        }

    }
}
