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
    public partial class frmKitchen : Form
    {
        public frmKitchen()
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

        private void frmKitchen_Load(object sender, EventArgs e)
        {
            Category category = new Category();
            category.SortCategories(cbxCategories);
            cbxCategories.Items.Insert(0, "Tüm Kategoriler");
            cbxCategories.SelectedIndex = 0;
            lblSearch.Visible = false;
            tbxSearch.Visible = false;
            Product product = new Product();
            product.SortProducts(lvFoodList);
            panelCategory.Visible = false;
            panelProduct.Visible = false;


        }

        private void Clear()
        {
            tbxProductName.Clear();
            tbxPrice.Clear();
            tbxPrice.Text = string.Format("{0:##0.00}", 0);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbtnProduct.Checked == true)
            {


                if (tbxProductName.Text.Trim() == "" || tbxPrice.Text.Trim() == "" || cbxCategories.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Ürün eklenemedi! Lütfen tüm alanları doldurduğunuzdan emin olunuz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Product product = new Product();
                    product.Price = Convert.ToDecimal(tbxPrice.Text);
                    product.ProductName = tbxProductName.Text;
                    product.Statement = "Ürün eklenmiş.";
                    product.ProductTypeId = categoryId;
                    int result = product.AddProduct(product);
                    if (result != 0)
                    {
                        MessageBox.Show("Ürün eklendi !");
                        Reload();
                        Clear();
                    }

                }
            }
            else
            {
               
                if (tbxCategoryName.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori adı giriniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Category c = new Category();
                    c.CategoryName = tbxCategoryName.Text;
                    c.Statement = tbxStatement.Text;
                    int result = c.AddCategory(c);
                    if (result != 0)
                    {
                        MessageBox.Show("Kategori eklendi !");
                        Reload();
                        Clear();
                    }
                }
            }
        }
        int categoryId = 0;
        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = new Product();
            if (cbxCategories.SelectedItem.ToString() == "Tüm Kategoriler")
            {
                product.SortProducts(lvFoodList);
            }
            else
            {
                Category category = (Category)cbxCategories.SelectedItem;
                categoryId = category.ProductTypeId;
                product.SortProductsById(lvFoodList, categoryId);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbtnProduct.Checked)
            {
                if (tbxProductName.Text.Trim() == "" || tbxPrice.Text.Trim() == "" || cbxCategories.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Ürün eklenemedi! Lütfen tüm alanları doldurduğunuzdan emin olunuz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Product product = new Product();
                    product.Price = Convert.ToDecimal(tbxPrice.Text);
                    product.ProductName = tbxProductName.Text;
                    product.ProductId = Convert.ToInt32(tbxProductId.Text);
                    product.ProductTypeId = categoryId;
                    product.Statement = "Ürün güncellenmiş.";
                    int result = product.UpdateProduct(product);
                    if (result != 0)
                    {
                        MessageBox.Show("Ürün güncellendi!");
                        Reload();
                        //cbxCategories_SelectedIndexChanged(sender, e);
                        Clear();
                    }

                }
            }
            else
            {
                if (tbxCategoryId.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Category category = new Category();
                    category.CategoryName = tbxCategoryName.Text;
                    category.Statement = tbxStatement.Text;
                    category.ProductTypeId = Convert.ToInt32(tbxCategoryId.Text);
                    int result = category.UpdateCategory(category);
                    if (result != 0)
                    {
                        MessageBox.Show("Kategori güncellendi !");
                        category.SortCategoriesByLv(lvCategories);
                        Clear();
                    }
                }
            }
        }

        private void lvFoodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFoodList.SelectedItems.Count > 0)
            {
                tbxProductName.Text = lvFoodList.SelectedItems[0].SubItems[3].Text;
                tbxPrice.Text = lvFoodList.SelectedItems[0].SubItems[4].Text;
                tbxProductId.Text = lvFoodList.SelectedItems[0].SubItems[0].Text;

            }
        }

        private void lvCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvCategories.SelectedItems.Count > 0)
            {
                {
                    tbxCategoryName.Text = lvCategories.SelectedItems[0].SubItems[1].Text;
                    tbxCategoryId.Text = lvCategories.SelectedItems[0].SubItems[0].Text;
                    tbxStatement.Text = lvCategories.SelectedItems[0].SubItems[2].Text;

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
            {
                if (rbtnProduct.Checked)
                {
                    if (lvFoodList.SelectedItems.Count > 0)
                    {


                        if (MessageBox.Show("Seçtiğiniz ürün silinecektir. Emin misiniz ?", "UYARI", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Product product = new Product();
                            product.ProductId = Convert.ToInt32(tbxProductId.Text);
                            int result = product.DeleteProduct(product, 1);
                            if (result != 0)
                            {
                                MessageBox.Show("Ürün silindi!");
                                cbxCategories_SelectedIndexChanged(sender, e);
                                Reload();
                                Clear();
                            }
                        }
                    }
                    else
                    {

                        MessageBox.Show("Ürün silmek için bir ürün seçiniz ! ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (lvCategories.SelectedItems.Count > 0)
                    {



                        if (MessageBox.Show("Seçtiğiniz kategori silinecektir. Emin misiniz ?", "UYARI", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                        {

                            Category category = new Category();
                            int result = category.DeleteCategory(Convert.ToInt32(tbxCategoryId.Text));
                            if (result != 0)
                            {
                                MessageBox.Show("Kategori silindi!");
                                Product product = new Product();
                                product.ProductId = Convert.ToInt32(tbxCategoryId.Text);
                                product.DeleteProduct(product, 0);
                                Reload();
                                Clear();
                            }
                        }
                    }
                }
            }

            private void btnSearch_Click(object sender, EventArgs e)
            {
                lblSearch.Visible = true;
                tbxSearch.Visible = true;
            }

            private void tbxSearch_TextChanged(object sender, EventArgs e)
            {
                if (rbtnProduct.Checked)
                {
                    Product product = new Product();
                    product.SortProductsByName(lvFoodList, tbxSearch.Text);
                }
                else
                {
                    Category category = new Category();
                    category.SearchCategoriesByLv(lvCategories, tbxSearch.Text);
                }
            }

            private void rbtnProduct_CheckedChanged(object sender, EventArgs e)
            {
                panelProduct.Visible = true;
                panelCategory.Visible = false;
                lvCategories.Visible = false;
                lvFoodList.Visible = true;
                Reload();
            }

            private void rbtnCategory_CheckedChanged(object sender, EventArgs e)
            {
                panelProduct.Visible = false;
                panelCategory.Visible = true;
                lvCategories.Visible = true;
                lvFoodList.Visible = false;
                Reload();
            }

            private void Reload()
            {
                Category category = new Category();
                category.SortCategories(cbxCategories);
                cbxCategories.Items.Insert(0, "Tüm Kategoriler");
                cbxCategories.SelectedIndex = 0;
                category.SortCategoriesByLv(lvCategories);
                Product product = new Product();
                product.SortProducts(lvFoodList);
            }
        }
    }
