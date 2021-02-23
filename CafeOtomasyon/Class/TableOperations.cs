using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CafeOtomasyon.Class
{

    class TableOperations
    {
        private int _serviceType;
        private int _status;
        private string _tableId;

        public int ServiceType
        {
            get => _serviceType;
            set => _serviceType = value;
        }

        public int Status
        {
            get => _status;
            set => _status = value;
        }

        public string TableId
        {
            get => _tableId;
            set => _tableId = value;
        }
        ArrayList tablesList = new ArrayList();

        public void Listele()
        {
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd1 = new SqlCommand("Select ID from tables", con);
            SqlDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    tablesList.Add(Convert.ToInt32(dr["ID"].ToString()));


                }

                dr.Close();
                con.Close();

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

        public void AddTable(TableOperations table)
        { 
            Listele();
            ServiceType = 1;
            Status = 1;
            int count = tablesList.Count + 1;
            General general = new General();
            
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Insert Into tables(ID, SERVICETYPE, STATUS) values(@id,@serviceType,@status)",
                con);


            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (tablesList.Count>= 15)
                {
                    MessageBox.Show("15 MASADAN FAZLA EKLEYEMEZSİNİZ!!!");
                }
                else
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = count;
                    cmd.Parameters.Add("@serviceType", SqlDbType.VarChar).Value = table.ServiceType;
                    cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = table.Status;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Masa Eklendi!");
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

            Listele();

        }

        General general = new General();

        public void DeleteTable()
        {
            ServiceType = 1;
            Status = 1;
            Listele();
            int id = tablesList.Count;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Delete from tables Where ID='" + Convert.ToInt32(tablesList.Count.ToString()) + "'", con);
            SqlCommand cmd1 = new SqlCommand("Update tables Set SERVICETYPE='"+ServiceType+"', STATUS= '"+Status+ "' where ID= '" + id + "'", con);
            cmd1.Parameters.Add("@id", SqlDbType.Int).Value = id+1;
            cmd1.Parameters.Add("@stypeid", SqlDbType.Int).Value = ServiceType;
            cmd1.Parameters.Add("@state", SqlDbType.Int).Value = Status;
            


            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Masa Silindi !!");

            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }

            con.Dispose();
            con.Close();
            Listele();


        }

       
    }
}

