using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.Class
{
    class Order
    {
        General general = new General();

        #region Fields

        private int _Id;
        private int _billID;
        private int _productId;
        private int _quantity;
        private int _tableId;


        #endregion

        #region Properties

        public int Id { get => _Id; set => _Id = value; }
        public int BillID { get => _billID; set => _billID = value; }
        public int ProductId { get => _productId; set => _productId = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public int TableId { get => _tableId; set => _tableId = value; }


        #endregion

        public void GetByOrder(ListView listView, int BillId)
        {
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("select PRODUCTNAME, PRICE, sales.ID, sales.PRODUCTID, sales.QUANTITY from sales Inner Join products on sales.PRODUCTID=products.ID where BILLID=@BillId ",con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@BillId", SqlDbType.Int).Value = BillId;
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
                    listView.Items.Add(dr["PRODUCTNAME"].ToString());
                    listView.Items[count].SubItems.Add(dr["QUANTITY"].ToString());
                    listView.Items[count].SubItems.Add(dr["PRODUCTID"].ToString());
                    listView.Items[count].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["PRICE"]) * Convert.ToDecimal(dr["QUANTITY"])));
                    listView.Items[count].SubItems.Add(dr["ID"].ToString());
                    count++;
                }

            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }

        }
        public bool setSaveOrder(Order order)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Insert Into sales(BILLID,PRODUCTID,QUANTITY,TABLEID) values(@BillId,@ProductId,@Quantity,@tableId)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@BillId", SqlDbType.Int).Value = order._billID;
                cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = order._productId;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = order._quantity;
                cmd.Parameters.Add("@tableId", SqlDbType.Int).Value = order._tableId;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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

        public void setDeleteOrder(int sellId)
        {
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Delete From sales Where ID=@SellID", con);

            cmd.Parameters.Add("@SellID", SqlDbType.Int).Value = sellId;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }

            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();

        }

        //public decimal TotalAmount(int customerId)
        //{ 
        //    decimal totalAmount = 0;
        //    SqlConnection con = new SqlConnection(general.conString);
        //    //SqlCommand cmd = new SqlCommand("SELECT SUM(dbo.sales.QUANTITY * dbo.products.PRICE) AS price From customers Inner Join packOrders on customers.ID=packOrders.CUSTOMERID Inner Join bills on bills.ID=packOrders.BILLID Inner Join sales ON bills.ID = sales.BILLID Inner Join products ON sales.PRODUCTID=products.ID Where(packOrders.CUSTOMERID=@customerId) AND(packOrders.STATUS=0)", con);
        //   SqlCommand cmd = new SqlCommand("Select SUM(TOTALAMOUNT) from billPayments where CUSTOMERID=@customerId",con);
        //    cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
        //    try
        //    {
        //        if (con.State == ConnectionState.Closed)
        //        {
        //            con.Open();
        //        }

        //        totalAmount = Convert.ToDecimal(cmd.ExecuteNonQuery());
        //    }
        //    catch (SqlException ex)
        //    {
        //        string error = ex.Message;
        //        throw;
        //    }
        //    finally
        //    {
        //        con.Dispose();
        //        con.Close();
        //    }

        //    return totalAmount;


        //}
        //adisyon paket sipariş detayları
        public void packOrderDetails(ListView lv, int billId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("SELECT sales.ID as sellId,products.PRODUCTNAME,products.PRICE,sales.QUANTITY from sales Inner Join bills on bills.ID=sales.BILLID Inner Join products on products.ID=sales.PRODUCTID where sales.BILLID=@billId", con);
            cmd.Parameters.Add("@billId", SqlDbType.Int).Value = billId;
            SqlDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                int i = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lv.Items.Add(dr["sellId"].ToString());
                    lv.Items[i].SubItems.Add(dr["PRODUCTNAME"].ToString());
                    lv.Items[i].SubItems.Add(dr["QUANTITY"].ToString());
                    lv.Items[i].SubItems.Add(dr["PRICE"].ToString());

                    i++;
                }
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

        }
        //paket ürünler satışlara kayıt
        public bool setSaveOrderPack(Order order)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Insert Into sales(BILLID,PRODUCTID,QUANTITY) values(@BillId,@ProductId,@Quantity)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@BillId", SqlDbType.Int).Value = order._billID;
                cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = order._productId;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = order._quantity;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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
    }
}
