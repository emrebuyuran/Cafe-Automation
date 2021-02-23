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
    public partial class frmSettings : Form
    {
        public frmSettings()
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

        private void frmSettings_Load(object sender, EventArgs e)
        {
            Personnel personnel = new Personnel();
            PersonnelTask personnelTask = new PersonnelTask();
            string task = personnelTask.PersonnelTaskStatements(General._taskId);
            if (task=="Müdür")
            {
                personnel.personnelGetInfo(cbxPersonnel);
                personnelTask.GetPersonnelTasks(cbxPersonnelTask);
                personnel.personnelGetInfoByLv(lvPersonnels);
                btnNew.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = false;
                gbxChangePasswordL.Visible = true;
                gbxPersonnelAdd.Visible = true;
                gbxPersonnelList.Visible = true;
                gbxChangePasswordR.Visible = false;
                tbxPasswordM.ReadOnly = true;
                tbxNewPasswordM.ReadOnly = true;
                lblSignInfo.Text = "Mevki : Müdür / Yetki Sınırsız / Kullanıcı :"
                                   + personnel.personnelGetName(General._personnelId);

            }
            else
            {
                gbxChangePasswordR.Visible = true;
                gbxPersonnelAdd.Visible = false;
                gbxPersonnelList.Visible = false;
                gbxChangePasswordL.Visible = false;
                lblSignInfo.Text = "Mevki : Müdür / Yetki Sınırlı / Kullanıcı :"
                                   + personnel.personnelGetName(General._personnelId);
            }
        }

        private void btnChangePasswordL_Click(object sender, EventArgs e)
        {
            if (tbxNewPasswordL.Text.Trim() != "" || tbxPasswordL.Text.Trim() != "")
            {
                if (tbxNewPasswordL.Text == tbxPasswordL.Text)
                {
                    if (tbxPersonnelIdL.Text != "")
                    {
                        Personnel personnel = new Personnel();
                        bool result = personnel.personnelChangePassword(Convert.ToInt32(tbxPersonnelIdL.Text),
                            tbxNewPasswordL.Text);
                        if (result==true)
                        {
                            MessageBox.Show("Şifre değiştirme işlemi başarılı ! ", "Uyarı");

                        }

                    }
                    else
                    {
                        MessageBox.Show("Personel Seçiniz !", "HATA");
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz şifreler aynı değil !", "HATA");

                }
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayanız !", "HATA");

            }
        }

        private void cbxPersonnelTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonnelTask personnelTask = (PersonnelTask) cbxPersonnelTask.SelectedItem;
            tbxPersonnelTask.Text = Convert.ToString(personnelTask.PersonnelTaskId);
        }

        private void cbxPersonnel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personnel personnel = (Personnel) cbxPersonnel.SelectedItem;
            tbxPersonnelIdL.Text = Convert.ToString(personnel.PersonnelId);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            tbxPasswordM.ReadOnly = false;
            tbxNewPasswordM.ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvPersonnels.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Personnel personnel = new Personnel();
                    bool result = personnel.personnelDelete(Convert.ToInt32(lvPersonnels.SelectedItems[0].Text));
                    if (result)
                    {
                        MessageBox.Show("Silme işlemi başarılı !");
                        personnel.personnelGetInfoByLv(lvPersonnels);
                        
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinemedi !", "HATA");

                    }
                }
                else
                {
                    MessageBox.Show("Kayıt seçiniz !", "HATA");
                }
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxName.Text.Trim() != "" || tbxSurname.Text.Trim() != "" || tbxPasswordM.Text.Trim() != "" || tbxNewPasswordM.Text.Trim() != "" || tbxPersonnelTask.Text.Trim() != "")
            {
                if ((tbxPasswordM.Text.Trim()==tbxNewPasswordM.Text.Trim())&&(tbxPasswordM.Text.Length>5)|| tbxNewPasswordM.Text.Length>5)
                {
                    Personnel personnel = new Personnel();
                    personnel.PersonnelName = tbxName.Text.Trim();
                    personnel.PersonnelSurname = tbxSurname.Text.Trim();
                    personnel.PersonnelPassword = tbxPasswordM.Text.Trim();
                    personnel.PersonnelTaskId = Convert.ToInt32(tbxPersonnelTask.Text.Trim());
                    bool result = personnel.personnelAdd(personnel);

                    if (result)
                    {
                        MessageBox.Show("Kayıt başarıyla eklenmiştir !");
                        personnel.personnelGetInfoByLv(lvPersonnels);
                    }

                    else
                    {
                        MessageBox.Show("Kayıt eklenirken bir hata oluştu !");
                    }
                }

                else
                {
                    MessageBox.Show("Girdiğiniz şifreler aynı değil !", "HATA");
                }
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız !", "HATA");
            }
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvPersonnels.SelectedItems.Count > 0)
            {


                if (tbxName.Text != "" || tbxSurname.Text != "" || tbxPasswordM.Text != "" ||
                    tbxNewPasswordM.Text != "" || tbxPersonnelTask.Text != "")
                {
                    if ((tbxPasswordM.Text.Trim() == tbxNewPasswordM.Text.Trim()) && (tbxPasswordM.Text.Length > 5) ||
                        tbxNewPasswordM.Text.Length > 5)
                    {
                        Personnel personnel = new Personnel();
                        personnel.PersonnelName = tbxName.Text.Trim();
                        personnel.PersonnelSurname = tbxSurname.Text.Trim();
                        personnel.PersonnelPassword = tbxPasswordM.Text.Trim();
                        personnel.PersonnelTaskId = Convert.ToInt32(tbxPersonnelTask.Text.Trim());
                        bool result = personnel.personnelUpdate(personnel,Convert.ToInt32(tbxPersonnelIdM.Text));

                        if (result)
                        {
                            MessageBox.Show("Kayıt başarıyla eklenmiştir !");
                            personnel.personnelGetInfoByLv(lvPersonnels);
                        }

                        else
                        {
                            MessageBox.Show("Kayıt eklenirken bir hata oluştu !");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Girdiğiniz şifreler aynı değil !", "HATA");
                    }
                }
                else
                {
                    MessageBox.Show("Boş alan bırakmayınız !", "HATA");
                }
            }
            else
            {
                MessageBox.Show("Kayıt seçiniz !", "HATA");
            }
        }

        private void btnChangePasswordR_Click(object sender, EventArgs e)
        {
            if (tbxNewPasswordR.Text.Trim() != "" || tbxPasswordR.Text.Trim() != "")
            {
                if (tbxNewPasswordR.Text == tbxPasswordR.Text)
                {
                    if (Convert.ToString(General._personnelId) != "")
                    {
                        Personnel personnel = new Personnel();
                        bool result = personnel.personnelChangePassword(Convert.ToInt32(General._personnelId),
                            tbxNewPasswordR.Text);
                        if (result==true)
                        {
                            MessageBox.Show("Şifre değiştirme işlemi başarılı ! ", "Uyarı");

                        }

                    }
                    else
                    {
                        MessageBox.Show("Personel Seçiniz !", "HATA");
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz şifreler aynı değil !", "HATA");

                }
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız !", "HATA");

            }
        }

        private void lvPersonnels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPersonnels.SelectedItems.Count>0)
            {
                btnDelete.Enabled = true;
                tbxPersonnelIdM.Text = lvPersonnels.SelectedItems[0].SubItems[0].Text;
                cbxPersonnelTask.SelectedIndex = Convert.ToInt32(lvPersonnels.SelectedItems[0].SubItems[1].Text) - 1;
                tbxName.Text = lvPersonnels.SelectedItems[0].SubItems[3].Text;
                tbxSurname.Text = lvPersonnels.SelectedItems[0].SubItems[4].Text;
            }
            else
            {
                btnDelete.Enabled = false;
            }
            
        }
    }
    }

