using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Class;

namespace CafeOtomasyon
{
    public partial class frmCustomerAdd : Form
    {
        public frmCustomerAdd()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCustomerSearch frm = new frmCustomerSearch();
            this.Close();
            frm.Show();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            if (tbxGSM.Text.Length>6)
            {
                if (tbxName.Text=="" || tbxSurname.Text=="")
                {
                    MessageBox.Show("Ad - Soyad Kısımları Boş Bırakılamaz!", "Hata");
                }
                else
                {
                    Customer customer = new Customer();
                    bool result = customer.MusteriVarMi(tbxGSM.Text);
                    if (!result)
                    {
                        customer.CustomerName = tbxName.Text;
                        customer.CustomerSurname = tbxSurname.Text;
                        customer.GSM = tbxGSM.Text;
                        customer.Address = tbxAdress.Text;
                        tbxCustomerId.Text = customer.AddCustomer(customer).ToString();
                        if (tbxCustomerId.Text !="")
                        {
                            MessageBox.Show("Müşteri Başarıyla Eklendi !", "İşlem Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Müşteri Eklenemedi !!!", "HATA");

                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Bu telefon numarasına ait kayıt zaten var !!", "HATA");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen doğru bir telefon numarası giriniz !", "Hata");
            }
        }
        
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (tbxGSM.Text.Length > 6)
            {
                if (tbxName.Text == "" || tbxSurname.Text == "")
                {
                    MessageBox.Show("Ad - Soyad Kısımları Boş Bırakılamaz!", "Hata");
                }
                else
                {
                    Customer customer = new Customer();

                    customer.CustomerName = tbxName.Text;
                    customer.CustomerSurname = tbxSurname.Text;
                    customer.GSM = tbxGSM.Text;
                    customer.Address = tbxAdress.Text;
                    customer.CustomerId = Convert.ToInt32(tbxCustomerId.Text);
                    
                    bool result = customer.UpdateCustomer(customer);
                    


                    if (result)
                    {
                       
                        if (tbxCustomerId.Text != "")
                        {
                            MessageBox.Show("Müşteri Başarıyla Güncellendi !", "İşlem Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Müşteri Bilgileri Güncellenemedi !!!", "HATA");

                        }

                    }
                    else
                    {
                        MessageBox.Show("Bu isme ait kayıt zaten var !!", "HATA");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen doğru bir telefon numarası giriniz !", "Hata");
            }
        }

        private void frmCustomerAdd_Load(object sender, EventArgs e)
        {
            if (General._customerId>0)
            {
                Customer customer = new Customer();
                tbxCustomerId.Text = General._customerId.ToString();
                customer.CustomerGetById(Convert.ToInt32(tbxCustomerId.Text), tbxName, tbxSurname,
                    tbxGSM, tbxAdress);
            }
        }
    }
}
