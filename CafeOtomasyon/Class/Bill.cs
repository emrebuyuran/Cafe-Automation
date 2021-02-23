using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace CafeOtomasyon.Class
{
    class Bill
    {
        General general = new General();

        #region Fields

        private int _ID;
        private int _ServiceTypeId;
        private decimal _TotalAmount;
        private DateTime _Date;
        private int _PersonnelId;
        private int _Status;
        private int _TableId;


        #endregion


        #region Properties

        public int ID
        {
            get => _ID;
            set => _ID = value;
        }

        public int ServiceTypeId
        {
            get => _ServiceTypeId;
            set => _ServiceTypeId = value;
        }

        public decimal TotalAmount
        {
            get => _TotalAmount;
            set => _TotalAmount = value;
        }

        public DateTime Date
        {
            get => _Date;
            set => _Date = value;
        }

        public int PersonnelId
        {
            get => _PersonnelId;
            set => _PersonnelId = value;
        }

        public int Status
        {
            get => _Status;
            set => _Status = value;
        }

        public int TableId
        {
            get => _TableId;
            set => _TableId = value;
        }

        #endregion


        public int getByAddition(int TableId)
        {
           
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 ID from bills Where TABLEID=@TableId Order by ID Desc", con);

            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = TableId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                TableId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            finally
            {
                con.Close();
            }

            return TableId;
        }

        public bool setByAddition(Bill bill)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Insert Into bills (SERVICETYPEID, DATE, PERSONNELID, TABLEID, STATUS) values (@ServiceTypeId,@Date,@PersonnelId,@TableId,@Status)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@ServiceTypeId", SqlDbType.Int).Value = bill.ServiceTypeId;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = bill.Date;
                cmd.Parameters.Add("@PersonnelId", SqlDbType.Int).Value = bill.PersonnelId;
                cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = bill.TableId;
                cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = 0;
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

        public void BillClose(int billId, int status)
        {

            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Update bills set STATUS = @status Where ID=@billId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@billId", SqlDbType.Int).Value = billId;
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = status;
                cmd.ExecuteNonQuery();
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

        public int getByPackageId()
        {
            int quantity = 0;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select count(*) as Result from bills Where (STATUS=0) and (SERVICETYPEID=5)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                
                quantity = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            finally
            {
                con.Close();
            }

            return quantity;
        }
        public void getByPackageBill(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select packOrders.CUSTOMERID, customers.NAME + ' ' + customers.SURNAME as Customer, bills.ID as billID from packOrders Inner Join customers on customers.ID=packOrders.CUSTOMERID Inner Join bills on bills.ID=packOrders.BILLID where bills.STATUS=0", con);
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
                    lv.Items.Add(dr["CUSTOMERID"].ToString());
                    lv.Items[count].SubItems.Add(dr["Customer"].ToString());
                    lv.Items[count].SubItems.Add(dr["billID"].ToString());
                    count++;
                }
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }



        }
        //Müşterinin son adisyon id'sini getiren metod
        public int CustomerLastBillId(int customerId)
        {
            int result = 0;

            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select bills.ID from bills Inner Join packOrders on packOrders.BILLID=bills.ID where packOrders.STATUS=0 and bills.STATUS=0 and packOrders.CUSTOMERID=@customerId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
              
                result = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void CustomerDetails(ListView lv, int customerId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select packOrders.CUSTOMERID, packOrders.BILLID, customers.NAME, customers.SURNAME,CONVERT(varchar(10), bills.DATE,104) as DATE from bills Inner Join packOrders on packOrders.BILLID=bills.ID Inner Join customers on customers.ID=packOrders.CUSTOMERID where bills.SERVICETYPEID=5 and packOrders.CUSTOMERID=@customerId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                int count = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lv.Items.Add(dr["CUSTOMERID"].ToString());
                    lv.Items[count].SubItems.Add(dr["NAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["SURNAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["DATE"].ToString());
                    lv.Items[count].SubItems.Add(dr["BILLID"].ToString());
                    count++;
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

        public int OpenReservaionBill(Bill bill)
        {
            int result =0 ;

            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Insert Into bills (SERVICETYPEID, DATE, PERSONNELID, TABLEID, STATUS) values (@ServiceTypeId,@Date,@PersonnelId,@TableId,1)select scope_IDENTITY()", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@ServiceTypeId", SqlDbType.Int).Value = bill.ServiceTypeId;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = bill.Date;
                cmd.Parameters.Add("@PersonnelId", SqlDbType.Int).Value = bill.PersonnelId;
                cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = bill.TableId;
                result = Convert.ToInt32(cmd.ExecuteScalar());
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

        //paket sipariş adisyon ekleme
        public bool setByPackId(Bill bill)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Insert Into bills (SERVICETYPEID, DATE, PERSONNELID,STATUS) values (@ServiceTypeId,@Date,@PersonnelId,@Status)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@ServiceTypeId", SqlDbType.Int).Value = bill.ServiceTypeId;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = bill.Date;
                cmd.Parameters.Add("@PersonnelId", SqlDbType.Int).Value = bill.PersonnelId;
                cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = 0;
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
        //paket sipariş adisyon id'si
        public int getByAdditionPack(int TableId)
        {
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 ID from bills Where SERVICETYPEID=@TableId and STATUS = 0 Order by ID Desc", con);

            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = TableId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                TableId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            finally
            {
                con.Close();
            }

            return TableId;
        }
        //paket sipariş durum güncelleme
        public bool PackageOrderState(int BillId)
        {
            bool result = false;
            General general = new General();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select STATUS from packOrders where packOrders.BILLID=@billId and STATUS = 0", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@BillId", SqlDbType.Int).Value = BillId;
                Convert.ToBoolean(cmd.ExecuteNonQuery());

                result = Convert.ToBoolean(cmd.ExecuteScalar());
           
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
        public int getByPackageBillbyCustomerId(int customerId)
        {
            int result = 0;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 ID from bills Where SERVICETYPEID=5 Order by ID Desc", con);


            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;

                result = Convert.ToInt32(cmd.ExecuteScalar());
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

    

