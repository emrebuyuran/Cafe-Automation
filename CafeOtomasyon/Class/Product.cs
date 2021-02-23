using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.Class
{
    class Product
    {
        General general = new General();
        
        #region Fields

        private int _productId;
        private int _productTypeId;
        private string _productName;
        private decimal _price;
        private string _statement;


        #endregion

        #region Properties

        public int ProductId { get => _productId; set => _productId = value; }
        public int ProductTypeId { get => _productTypeId; set => _productTypeId = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public decimal Price { get => _price; set => _price = value; }
        public string Statement { get => _statement; set => _statement = value; }



        #endregion

        //ürün adına göre listview doldurma
        public void SortProductsByName(ListView lv, string productName)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select products.* ,CATEGORYNAME from products Inner Join categories on categories.ID=products.CATEGORYID Where products.STATUS=0 and PRODUCTNAME like '%' + @productName +'%'", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@productName", SqlDbType.VarChar).Value = productName;
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
                    lv.Items.Add((dr["ID"]).ToString());
                    lv.Items[count].SubItems.Add(dr["CATEGORYID"].ToString());
                    lv.Items[count].SubItems.Add(dr["CATEGORYNAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["PRODUCTNAME"].ToString());
                    lv.Items[count].SubItems.Add(string.Format("{0:0#00.0}",dr["PRICE"].ToString()));
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

        public int AddProduct(Product product)
        {
            int result = 0;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Insert Into products(PRODUCTNAME,CATEGORYID,STATEMENT,PRICE) values(@productName,@categoryId,@statement,@price)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@productName", SqlDbType.VarChar).Value = product._productName;
                cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = product._productTypeId;
                cmd.Parameters.Add("@statement", SqlDbType.VarChar).Value = product._statement;
                cmd.Parameters.Add("@price", SqlDbType.Money).Value = product._price;
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

        //ÜRÜNLERİ VE KATEGORİLERİ LİSTELEME
        public void SortProducts(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select products.*, CATEGORYNAME from products Inner Join categories on categories.ID=products.CATEGORYID where products.STATUS=0", con);
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
                    lv.Items[count].SubItems.Add(dr["CATEGORYID"].ToString());
                    lv.Items[count].SubItems.Add(dr["CATEGORYNAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["PRODUCTNAME"].ToString());
                    lv.Items[count].SubItems.Add(string.Format("{0:0#00.0}", dr["PRICE"].ToString()));
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

        public int UpdateProduct(Product product)
        {
            int result = 0;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Update products set PRODUCTNAME=@productName,CATEGORYID=@categoryId,STATEMENT=@statement, PRICE=@price where ID=@productId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@productName", SqlDbType.VarChar).Value = product._productName;
                cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = product._productTypeId;
                cmd.Parameters.Add("@statement", SqlDbType.VarChar).Value = product._statement;
                cmd.Parameters.Add("@price", SqlDbType.Money).Value = product._price;
                cmd.Parameters.Add("@productId", SqlDbType.Int).Value = product._productId;
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

        public int DeleteProduct(Product product, int categoryId)
        {
            int result = 0;
            SqlConnection con = new SqlConnection(general.conString);
            string sql = "Update products set STATUS=1 where ";
            if (categoryId == 0)
            {
                sql += "CATEGORYID=@productId";
            }
            else
            {
                sql += "ID=@productId";
            }
            SqlCommand cmd = new SqlCommand(sql,con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@productId", SqlDbType.VarChar).Value = product._productId;
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

        //ÜRÜNLERİ ÜRÜNID'YE GÖRE LİSTELEME
        public void SortProductsById(ListView lv, int productId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select products.*, CATEGORYNAME from products Inner Join categories on categories.ID=products.CATEGORYID Where products.STATUS=0 and products.CATEGORYID=@productId ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("productId", SqlDbType.Int).Value = productId;
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
                    lv.Items[count].SubItems.Add(dr["CATEGORYID"].ToString());
                    lv.Items[count].SubItems.Add(dr["CATEGORYNAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["PRODUCTNAME"].ToString());
                    lv.Items[count].SubItems.Add(string.Format("{0:0#00.0}", dr["PRICE"].ToString()));
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
        //2 tarih arası ürünleri getiriyor
        public void SortProductsByStatistics(ListView lv, DateTimePicker start, DateTimePicker finish)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("SELECT top 10 products.PRODUCTNAME, sum(sales.QUANTITY) as Adet From categories Inner Join products on categories.ID = products.CATEGORYID Inner Join sales on products.ID = sales.PRODUCTID Inner Join bills on sales.BILLID = bills.ID where (CONVERT(datetime,DATE,104) BETWEEN CONVERT(datetime,@start,104) AND CONVERT(datetime,@finish,104)) group by products.PRODUCTNAME order by Adet desc", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@start", SqlDbType.VarChar).Value = start.Value.ToShortDateString();
            cmd.Parameters.Add("@finish", SqlDbType.VarChar).Value = finish.Value.ToShortDateString();
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
                 
                    lv.Items.Add(dr["PRODUCTNAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["Adet"].ToString());
                   
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
        //2 tarih arası belirli kategoriye ait ürünleri getiriyor
        public void SortProductsByStatisticsByProductId(ListView lv, DateTimePicker start, DateTimePicker finish, int productCatId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("SELECT top 10 products.PRODUCTNAME, sum(sales.QUANTITY) as Adet From categories Inner Join products on categories.ID = products.CATEGORYID Inner Join sales on products.ID = sales.PRODUCTID Inner Join bills on sales.BILLID = bills.ID where (CONVERT(datetime,DATE,104) BETWEEN CONVERT(datetime,@start,104) AND CONVERT(datetime,@finish,104)) and (products.CATEGORYID=@catId) group by products.PRODUCTNAME order by Adet desc", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@start", SqlDbType.VarChar).Value = start.Value.ToShortDateString();
            cmd.Parameters.Add("@finish", SqlDbType.VarChar).Value = finish.Value.ToShortDateString();
            cmd.Parameters.Add("@catId", SqlDbType.Int).Value = productCatId;
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

                    lv.Items.Add(dr["PRODUCTNAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["Adet"].ToString());

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
    }
}
