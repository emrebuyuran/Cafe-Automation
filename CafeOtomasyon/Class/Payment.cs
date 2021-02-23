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
    class Payment
    {
        #region Fields

        private int _billId;
        private int _paymentTypeId;
        private decimal _subTotal;
        private decimal _discount;
        private decimal _tax;
        private decimal _totalAmount;
        private DateTime _date;
        private int _customerId;


        #endregion

        #region Properties

     
        public int BillId { get => _billId; set => _billId = value; }
        public int PaymentTypeId { get => _paymentTypeId; set => _paymentTypeId = value; }
        public decimal SubTotal { get => _subTotal; set => _subTotal = value; }
        public decimal Discount { get => _discount; set => _discount = value; }
        public decimal Tax { get => _tax; set => _tax = value; }
        public decimal TotalAmount { get => _totalAmount; set => _totalAmount = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public int CustomerId { get => _customerId; set => _customerId = value; }


        #endregion

        General general = new General();

        //müşterinin masa hesabını kapatma
        public bool closeBill(Payment bill)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Insert Into billPayments(BILLID,PAYMENTTYPEID,CUSTOMERID,SUBTOTAL,TAXAMOUNT,DISCOUNT,TOTALAMOUNT) values(@BILLID, @PAYMENTTYPEID, @CUSTOMERID, @SUBTOTAL, @TAXAMOUNT, @DISCOUNT, @TOTALAMOUNT)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@BILLID", SqlDbType.Int).Value = bill._billId;
                cmd.Parameters.Add("@PAYMENTTYPEID", SqlDbType.Int).Value = bill._paymentTypeId;
                cmd.Parameters.Add("@CUSTOMERID", SqlDbType.Int).Value = bill._customerId;
                cmd.Parameters.Add("@SUBTOTAL", SqlDbType.Money).Value = bill._subTotal;
                cmd.Parameters.Add("@TAXAMOUNT", SqlDbType.Money).Value = bill._tax;
                cmd.Parameters.Add("@DISCOUNT", SqlDbType.Money).Value = bill._discount;
                cmd.Parameters.Add("@TOTALAMOUNT", SqlDbType.Money).Value = bill._totalAmount;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());

            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                MessageBox.Show("Ödeme Türü Seçilmemiş !");
            }

            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }

        //müşterinin toplam harcaması
        public decimal sumTotalByCustomerId(int customerId)
        {
            decimal total = 0;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select sum(TOTALAMOUNT) as total from billPayments Where CUSTOMERID=@customerId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("customerId", SqlDbType.Int).Value = customerId;
                total = Convert.ToDecimal(cmd.ExecuteScalar());
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
          
            return total;
        }


    }

}
