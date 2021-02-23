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
    public partial class frmReservationControl : Form
    {
        public frmReservationControl()
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
            frmReservations frm = new frmReservations();
            this.Close();
            frm.Show();
        }

        private void ReservationControl_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvReservations.SelectedItems.Count>0)
            {
                int resId = Convert.ToInt32(lvReservations.SelectedItems[0].SubItems[0].Text);
                int tableId = Convert.ToInt32(lvReservations.SelectedItems[0].SubItems[3].Text);
                string statement = "Rezervasyon İptal Edilmiş.";
                Reservation reservation = new Reservation();
                reservation.ReservationDelete(resId, statement);
                reservation.SetTableState(tableId);
                MessageBox.Show("Rezervasyon başarıyla iptal edilmiştir.");
                Refresh();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz rezervasyonu seçiniz!", "HATA", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Refresh();
            }
        }

        private void Refresh()
        {
            Reservation reservation = new Reservation();
            reservation.getReservations(lvReservations);
            reservation.getOlderReservation(lvOlderReservations);
        }
    }
}
