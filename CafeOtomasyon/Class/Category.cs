using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.Class
{
    class Category
    {
        General general = new General();

        #region Fields

        private int _ProductTypeId;
        private string _CategoryName;
        private string _Statement;
        #endregion
        #region Properties
        public int ProductTypeId { get => _ProductTypeId; set => _ProductTypeId = value; }
        public string CategoryName { get => _CategoryName; set => _CategoryName = value; }
        public string Statement { get => _Statement; set => _Statement = value; }

        #endregion

        public void getByProductType(ListView lsVariaties, Button btn)
        {
         
            lsVariaties.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select PRODUCTNAME, PRICE, products.ID from categories Inner Join products on categories.ID=products.CATEGORYID Where products.CATEGORYID=@CATEGORYID and products.STATUS=0 and categories.STATUS=0", con);
            string x = btn.Name;
            int length = x.Length;
            if (length == 12)
            {
                cmd.Parameters.Add("@CATEGORYID", SqlDbType.Int).Value = x.Substring(length - 1, 1);
            }
            else
            {
                cmd.Parameters.Add("@CATEGORYID", SqlDbType.Int).Value = x.Substring(length - 2, 2);
            }




            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lsVariaties.Items.Add(dr["PRODUCTNAME"].ToString());
                lsVariaties.Items[i].SubItems.Add(dr["PRICE"].ToString());
                lsVariaties.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }

        public void getByProductSearch(ListView lsVariaties, string text)
        {
            lsVariaties.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select * from products where ID=@ID and STATUS=0", con);


            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = text;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lsVariaties.Items.Add(dr["PRODUCTNAME"].ToString());
                lsVariaties.Items[i].SubItems.Add(dr["PRICE"].ToString());
                lsVariaties.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        public void SortCategories(ComboBox cbx)
        {
            cbx.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select * from categories where STATUS=0", con);
            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Category categories = new Category();
                    categories._ProductTypeId = Convert.ToInt32(dr["ID"]);
                    categories._CategoryName = dr["CATEGORYNAME"].ToString();
                    categories._Statement = dr["STATEMENT"].ToString();
                    cbx.Items.Add(categories);



                }

            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }

            dr.Close();
            con.Dispose();
            con.Close();
        }
        public void SortCategoriesByLv(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select * from categories where STATUS=0", con);
            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[count].SubItems.Add(dr["CATEGORYNAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["STATEMENT"].ToString());
                    count++;

                }

            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }

            dr.Close();
            con.Dispose();
            con.Close();
        }

        //arama metodu
        public void SearchCategoriesByLv(ListView lv, string search)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select * from categories where STATUS=0 and CATEGORYNAME like '%' + @search+ '%'", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@search", SqlDbType.VarChar).Value = search;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[count].SubItems.Add(dr["CATEGORYNAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["STATEMENT"].ToString());
                    count++;

                }

            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }

            dr.Close();
            con.Dispose();
            con.Close();
        }
        //kategori ekle
        public int AddCategory(Category category)
        {
            int result = 0;
            ArrayList cArrayList = new ArrayList();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Insert Into categories(CATEGORYNAME,STATEMENT) values(@categoryName,@statement)", con);
            SqlCommand cmd2 = new SqlCommand("Select ID from categories where STATUS=0",con);
            SqlDataReader dr = null;


                try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                
                dr = cmd2.ExecuteReader();

                while (dr.Read())
                {
                    cArrayList.Add(Convert.ToInt32(dr["ID"]));
                }
                dr.Close();

                if (cArrayList.Count>=10)
                {
                    MessageBox.Show("10 Kategoriden fazla ekleme yapamazsınız !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //cmd.Parameters.Add("@id", SqlDbType.Int).Value = cArrayList.Count + 1;
                    cmd.Parameters.Add("@categoryName", SqlDbType.VarChar).Value = category._CategoryName;
                    cmd.Parameters.Add("@statement", SqlDbType.VarChar).Value = category._Statement;
                    result = Convert.ToInt32(cmd.ExecuteNonQuery());
                }
                  
                
                
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            finally
            {
                cArrayList.Clear();
                dr.Close();
                con.Dispose();
                con.Close();
            }


            return result;
        }
        public int UpdateCategory(Category category)
        {
            int result = 0;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Update categories set CATEGORYNAME=@categoryName,STATEMENT=@statement where ID=@categoryId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@categoryName", SqlDbType.VarChar).Value = category._CategoryName;
                cmd.Parameters.Add("@statement", SqlDbType.VarChar).Value = category._Statement;
                cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = category._ProductTypeId;
                result = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }
        public int DeleteCategory(int Id)
        {
            int result = 0;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Update categories set STATUS=1 where ID=@categoryId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = Id;
                result = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }

        public override string ToString()
        {
            return _CategoryName;
        }
    }
}
