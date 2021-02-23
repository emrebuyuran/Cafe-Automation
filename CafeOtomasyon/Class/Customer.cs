using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.Class
{
    class Customer
    {
        General general = new General();

        #region Fields

        private int _customerId;
        private string _customerName;
        private string _customerSurname;
        private string _GSM;
        private string _address;


        #endregion

        #region Properties

        public int CustomerId { get => _customerId; set => _customerId = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public string CustomerSurname { get => _customerSurname; set => _customerSurname = value; }
        public string GSM { get => _GSM; set => _GSM = value; }
        public string Address { get => _address; set => _address = value; }



        #endregion


        public bool MusteriVarMi(string gsm)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "MusteriVarMi";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = gsm;
            cmd.Parameters.Add("@result", SqlDbType.Int);
            cmd.Parameters["@result"].Direction = ParameterDirection.Output;

            if (con.State == ConnectionState.Closed)
            {
               con.Open();

            }
            try
            {
                cmd.ExecuteNonQuery();
                result = Convert.ToBoolean(cmd.Parameters["@result"].Value);
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

            return result;



        }

        public int AddCustomer(Customer customer)
        {
            int result = 0;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Insert Into customers(NAME,SURNAME,ADDRESS,GSM) values(@name,@surname,@address,@gsm); select SCOPE_IDENTITY()", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = customer._customerName;
                cmd.Parameters.Add("@surname", SqlDbType.VarChar).Value = customer._customerSurname;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = customer._address;
                cmd.Parameters.Add("@gsm", SqlDbType.VarChar).Value = customer._GSM;
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

        public bool UpdateCustomer(Customer customer)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Update customers set NAME=@name,SURNAME=@surname,ADDRESS=@address,GSM=@gsm where ID=@customerId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = customer._customerName;
                cmd.Parameters.Add("@surname", SqlDbType.VarChar).Value = customer._customerSurname;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = customer._address;
                cmd.Parameters.Add("@gsm", SqlDbType.VarChar).Value = customer._GSM;
                cmd.Parameters.Add("@customerId", SqlDbType.VarChar).Value = customer._customerId;
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

        public void GetCustomer(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select * from customers",con);
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
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[count].SubItems.Add(dr["NAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["SURNAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["GSM"].ToString());
                    lv.Items[count].SubItems.Add(dr["ADDRESS"].ToString());
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

        public void CustomerGetById(int customerId, TextBox name, TextBox surname, TextBox gsm, TextBox address)
        

        {
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select * from customers Where ID=@customerId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("customerId", SqlDbType.Int).Value = customerId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    name.Text = dr["NAME"].ToString();
                    surname.Text = dr["SURNAME"].ToString();
                    gsm.Text = dr["GSM"].ToString();
                    address.Text = dr["ADDRESS"].ToString();
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
        public void CustomerGetByName(ListView lv, string customerName)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select * from customers Where NAME like @customerName + '%' ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("customerName", SqlDbType.VarChar).Value = customerName;
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
                    lv.Items[count].SubItems.Add(dr["NAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["SURNAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["GSM"].ToString());
                    lv.Items[count].SubItems.Add(dr["ADDRESS"].ToString());
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
        public void CustomerGetBySurname(ListView lv, string customerSurname)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select * from customers Where SURNAME like @customerSurname + '%' ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("customerSurname", SqlDbType.VarChar).Value = customerSurname;
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
                    lv.Items[count].SubItems.Add(dr["NAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["SURNAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["GSM"].ToString());
                    lv.Items[count].SubItems.Add(dr["ADDRESS"].ToString());
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
        public void CustomerGetByGSM(ListView lv, string gsm)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select * from customers Where GSM like @gsm + '%' ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("gsm", SqlDbType.VarChar).Value = gsm;
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
                    lv.Items[count].SubItems.Add(dr["NAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["SURNAME"].ToString());
                    lv.Items[count].SubItems.Add(dr["GSM"].ToString());
                    lv.Items[count].SubItems.Add(dr["ADDRESS"].ToString());
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
