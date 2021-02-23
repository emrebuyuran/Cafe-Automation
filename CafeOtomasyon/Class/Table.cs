using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.Class
{
    public class Table
    {
        #region Fields



        private int _ID;
        private int _SERVICETYPE;
        private int _STATUS;
        private int _CONFIRMATION;
        private string _TABLEINFO;

        #endregion

        #region Properties

        public int ID
        {
            get => _ID;
            set => _ID = value;
        }

        public int SERVICETYPE
        {
            get => _SERVICETYPE;
            set => _SERVICETYPE = value;
        }

        public int STATUS
        {
            get => _STATUS;
            set => _STATUS = value;
        }

        public int CONFIRMATION
        {
            get => _CONFIRMATION;
            set => _CONFIRMATION = value;
        }
        public string TABLEINFO { get => _TABLEINFO; set => _TABLEINFO = value; }

        #endregion

        private General general = new General();

        public string SessionSum(int state)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd =
                new SqlCommand(
                    "Select Date,TableId From bills Right Join Tables on bills.TableId=Tables.ID Where Tables.STATUS=@status and bills.Status=0",
                    con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@status", SqlDbType.Int).Value = state;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["DATE"]).ToString();
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

            return dt;
        }

        public int TableGetByNumber(string TableValue)
        {
            string x = TableValue;
            int length = x.Length;

            if (length > 9)
            {
                return Convert.ToInt32(x.Substring(length - 2, 2));

            }
            else
            {
                return Convert.ToInt32(x.Substring(length - 1, 1));
            }


        }

        public bool TableGetByState(int ButtonName, int state)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select STATUS from tables Where ID=@TableId and STATUS=@state", con);
            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

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

        public void SetTableState(string ButtonName, int state)
        {
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Update tables Set STATUS=@Status Where ID=@TableId", con);
            string tableId = "";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }

            string x = ButtonName;
            int length = x.Length;
            cmd.Parameters.Add("@Status", SqlDbType.Int).Value = state;

            if (11 > length && length > 9 || length == 2)

            {
                tableId = x.Substring(length - 2, 2);
                cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = x.Substring(length - 2, 2);

            }
            else
            {
                tableId = x.Substring(length - 1, 1);
                cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = x.Substring(length - 1, 1);
            }



            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();

        }

        public void GetTableState(ComboBox cbx)
        {
            cbx.Items.Clear();
            string stat = "";
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select * from tables", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Table table = new Table();
                if (table._STATUS == 2)
                {
                    stat = "DOLU";

                }
                else if (table._STATUS == 3)
                {
                    stat = "REZERVE";
                }

                table._TABLEINFO = "Masa No: " + dr["ID"].ToString();
                table._ID = Convert.ToInt32(dr["ID"]);
                cbx.Items.Add(table);
            }
            dr.Close();
            con.Dispose();
            con.Close();

        }

        public override string ToString()
        {
            return TABLEINFO;
        }
    }
}


