using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeOtomasyon.Class
{
    class Reservation
    {
        #region Fields

        private int _ID;
        private int _tableId;
        private int _billId;
        private int _customerId;
        private string _description;
        private DateTime _date;





        #endregion

        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int TableId { get => _tableId; set => _tableId = value; }
        public int BillId { get => _billId; set => _billId = value; }
        public int CustomerId { get => _customerId; set => _customerId = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime Date { get => _date; set => _date = value; }

        #endregion

        General general = new General();

        //Müşteri idsini masa numarasına göre getir
        public int getByCustomerId(int tableId)
        {
            int customerId = 0;

            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 CUSTOMERID from reservations Where TABLEID=@tableId order by CUSTOMERID Desc", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@tableId", SqlDbType.Int).Value = tableId;


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

        //Rezerve masa kapamak
        public bool ReservationClose(int billId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Update reservations set STATUS = 1 Where BILLID=@billId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@billId", SqlDbType.Int).Value = billId;
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
        //Rezervasyonları listview'a getir
        public void getReservations(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("SELECT dbo.customers.NAME, dbo.customers.SURNAME,dbo.reservations.ID, dbo.reservations.TABLEID, dbo.reservations.DATE, dbo.reservations.STATEMENT FROM dbo.customers INNER JOIN dbo.reservations ON dbo.customers.ID = dbo.reservations.CUSTOMERID where reservations.STATUS=0", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["ID"].ToString());
                lv.Items[i].SubItems.Add(dr["NAME"].ToString());
                lv.Items[i].SubItems.Add(dr["SURNAME"].ToString());
                lv.Items[i].SubItems.Add(dr["TABLEID"].ToString());
                lv.Items[i].SubItems.Add(dr["DATE"].ToString());
                lv.Items[i].SubItems.Add(dr["STATEMENT"].ToString());
                i++;


            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        //Eski rezervasyonları getir
        public void getOlderReservation(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("SELECT dbo.customers.NAME, dbo.customers.SURNAME,dbo.reservations.ID, dbo.reservations.TABLEID, dbo.reservations.DATE, dbo.reservations.STATEMENT FROM dbo.customers INNER JOIN dbo.reservations ON dbo.customers.ID = dbo.reservations.CUSTOMERID where reservations.STATUS=1", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["ID"].ToString());
                lv.Items[i].SubItems.Add(dr["NAME"].ToString());
                lv.Items[i].SubItems.Add(dr["SURNAME"].ToString());
                lv.Items[i].SubItems.Add(dr["TABLEID"].ToString());
                lv.Items[i].SubItems.Add(dr["DATE"].ToString());
                lv.Items[i].SubItems.Add(dr["STATEMENT"].ToString());
                i++;


            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        //EN SON REZERVASYON TARIHINI GETIR
        //public DateTime LastReservationDate(int customerId)
        //{
        //    DateTime tar = new DateTime();
        //    tar = DateTime.Now;
        //    SqlConnection con = new SqlConnection(general.conString);
        //    SqlCommand cmd = new SqlCommand("Select DATE from reservations where reservations.CUSTOMERID=@customerId and reservations.STATUS=1 order by reservations.ID desc", con);
        //    cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
        //    if (con.State == ConnectionState.Closed)
        //    {
        //        con.Open();
        //    }

        //    tar = Convert.ToDateTime(cmd.ExecuteScalar());

        //    con.Dispose();
        //    con.Close();
        //    return tar;
        //}

        //public int NumberOfOpenReserve(int customerId)
        //{
        //    int result = 0;
        //    SqlConnection con = new SqlConnection(general.conString);
        //    SqlCommand cmd = new SqlCommand("Select count(*) from reservations where reservations.STATUS=0", con);
        //    if (con.State == ConnectionState.Closed)
        //    {
        //        con.Open();
        //    }

        //    try
        //    {
        //        result = Convert.ToInt32(cmd.ExecuteNonQuery());
        //    }
        //    catch (SqlException ex)
        //    {
        //        string error = ex.Message;
        //        throw;
        //    }
        //    con.Dispose();
        //    con.Close();
        //    return result;

        //}
        //Rezervasyon açık mı kontrol yapıyor
        public bool ReservationControl(int customerId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 reservations.ID from reservations where CUSTOMERID=@customerId and STATUS=0 order by ID desc", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
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
        //Rezervasyon aç
        public bool ReservationOpen(Reservation reservation)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Insert Into reservations (CUSTOMERID,TABLEID,BILLID,DATE,STATEMENT,STATUS) values (@CUSTOMERID,@TABLEID,@BILLID,@DATE,@STATEMENT,0)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@CUSTOMERID", SqlDbType.Int).Value = reservation._customerId;
                cmd.Parameters.Add("@TABLEID", SqlDbType.Int).Value = reservation._tableId;
                cmd.Parameters.Add("@BILLID", SqlDbType.Int).Value = reservation._billId;
                cmd.Parameters.Add("@DATE", SqlDbType.DateTime).Value = reservation._date;
                cmd.Parameters.Add("@STATEMENT", SqlDbType.VarChar).Value = reservation._description;

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

        public int ReservationDelete(int reservationId,string statement)
        {
            int result = 0;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Update reservations set STATUS=1, STATEMENT=@statement where reservations.ID=@reservationId and STATUS=0",con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@reservationId", SqlDbType.Int).Value = reservationId;
                cmd.Parameters.Add("@statement", SqlDbType.VarChar).Value = statement;
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
        //rezervasyon kapatıldığında masa durumunu boş yapacak
        public int SetTableState(int tableId)
        {
            int result = 0;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Update tables set STATUS=1 where ID=@tableId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@tableId", SqlDbType.Int).Value = tableId;
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

        //Rezerve masanın id'sini getir
        //public int GetReservedTableId(int customerId)
        //{
        //    int result = 0;
        //    SqlConnection con = new SqlConnection(general.conString);
        //    SqlCommand cmd = new SqlCommand("Select reservations.TABLEID from reservations Inner Join bills on reservations.BILLID=bills.ID where (reservations.STATUS=1) and bills.STATUS=0 and reservations.CUSTOMERID=@customerId", con);
        //    if (con.State == ConnectionState.Closed)
        //    {
        //        con.Open();
        //    }

        //    try
        //    {
        //        cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
        //        result = Convert.ToInt32(cmd.ExecuteNonQuery());
        //    }
        //    catch (SqlException ex)
        //    {
        //        string error = ex.Message;
        //        throw;
        //    }
        //    con.Dispose();
        //    con.Close();
        //    return result;

        //}

    }
}


