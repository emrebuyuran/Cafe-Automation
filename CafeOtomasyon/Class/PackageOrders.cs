using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Class
{
    class PackageOrders
    {
        #region Fields

        private int _ID;
        private int _additionID;
        private int _customerID;
        private string _statement;
        private int _state;
        private int _paymentTypeId;
        private int _control;

        #endregion

        #region Properties

        public int ID
        {
            get => _ID;
            set => _ID = value;
        }

        public int AdditionID
        {
            get => _additionID;
            set => _additionID = value;
        }

        public int CustomerID
        {
            get => _customerID;
            set => _customerID = value;
        }

        public string Statement
        {
            get => _statement;
            set => _statement = value;
        }

        public int State
        {
            get => _state;
            set => _state = value;
        }

        public int PaymentTypeId
        {
            get => _paymentTypeId;
            set => _paymentTypeId = value;
        }
        public int Control { get => _control; set => _control = value; }

        #endregion

        General general = new General();
        //PAKET SERVİSİ EKLEME
        public bool PackageOrderAdd(PackageOrders packageOrders)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd =
                new SqlCommand(
                    "Insert Into packOrders (CUSTOMERID, BILLID, STATEMENT) values (@CUSTOMERID, @BILLID, @STATEMENT)",
                    con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@CUSTOMERID", SqlDbType.Int).Value = packageOrders._customerID;
                cmd.Parameters.Add("@BILLID", SqlDbType.Int).Value = packageOrders._additionID;
                cmd.Parameters.Add("@STATEMENT", SqlDbType.VarChar).Value = packageOrders._statement;

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

        //PAKET SİPARİŞ HESAP KAPATMA
        public void PackageOrderPay(int BillId)
        {

            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd =
                new SqlCommand(
                    "Update packOrders set packOrders.STATUS=1 where packOrders.BILLID=@BillId",
                    con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@BillId", SqlDbType.Int).Value = BillId;
                Convert.ToBoolean(cmd.ExecuteNonQuery());


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
        //ödeme türü getir
        public int getByPaymentTypeId(int billId)
        {
            int paymentTypeId = 0;

            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd =
                new SqlCommand(
                    "Select packOrders.PAYMENTTYPEID from packOrders Inner Join bills on packOrders.BILLID=bills.ID Where bills.ID=@billId",
                    con);

            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@billId", SqlDbType.Int).Value = billId;
                paymentTypeId = Convert.ToInt32(cmd.ExecuteScalar());



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

            return paymentTypeId;
        }
        
        public int getByCustomerBillId(int customerId)
        {
            int id = 0;

            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd =
                new SqlCommand(
                    "Select bills.ID from bills Inner Join packOrders on packOrders.BILLID=bills.ID where (bills.STATUS=0) and (packOrders.STATUS=0) and (packorders.CUSTOMERID=@customerId)",
                    con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                id = Convert.ToInt32(cmd.ExecuteScalar());



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
            return id;
        }

        public bool getBillId(int billID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd =
                new SqlCommand(
                    "Select * from bills where (STATUS=0) and (ID=@billID)",con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@billID", SqlDbType.Int).Value = billID;
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

        //hesap kapatmak için müşteri id getir
        public int getCustomerIdForBillClose()
        {
            int customerId = 0;

            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 CUSTOMERID from packOrders Where STATUS = 0 order by CUSTOMERID Desc", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }



                customerId = Convert.ToInt32(cmd.ExecuteScalar());

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
            return customerId;
        }
    }
    }

        
    


    

