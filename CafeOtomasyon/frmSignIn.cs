using CafeOtomasyon.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }
        
        private void btnSignIn_Click(object sender, EventArgs e)
        {
           
            General general = new General();
            Personnel personnel = new Personnel();
            string pass;
            pass = personnel.md5crypto(tbxPassword.Text);
            if (lblCaptcha.Text!=tbxCaptcha.Text)
            {
                MessageBox.Show("Captcha yanlış !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool result = personnel.personnelSignInControl(pass, General._personnelId);
                if (result)
                {
                    PersonnelAction personnelAction = new PersonnelAction();
                    personnelAction.PersonnelId = General._personnelId;
                    personnelAction.Action = "Giriş Yapıldı";
                    personnelAction.Date = DateTime.Now;
                    personnelAction.PersonnelActionSave(personnelAction);
                    frmMenu menu = new frmMenu();
                    menu.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya Şifreniz yanlış !", "Hata", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                    lblCaptcha.Text = "";
                    Captcha();
                    tbxPassword.Text = "";
                    tbxCaptcha.Text = "";
                }
            }
           
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            General general = new General();
            general.ConnectionFunc();
            Personnel personel = new Personnel();
            personel.personnelGetInfo(cbxUser);
            Captcha();
        }

        private void cbxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personnel personnel = (Personnel)cbxUser.SelectedItem;
            General._personnelId = personnel.PersonnelId;
            General._taskId = personnel.PersonnelTaskId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Captcha()
        {

            Random rastgele = new Random();
            string harfler = "qwertyuopasdfghjklizxcvbnm.,123456789QWERTYUOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 4; i++)
            {
                lblCaptcha.Text += harfler[rastgele.Next(harfler.Length)];
            }
        }

        private void lblCaptcha_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshCaptcha_Click(object sender, EventArgs e)
        {
            lblCaptcha.Text = "";
            Captcha();
        }
    }
}
