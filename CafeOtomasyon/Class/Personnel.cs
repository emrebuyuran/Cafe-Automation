using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.Class
{
    class Personnel
    {
        General general = new General();
        #region Fields
        private int _PersonnelId;
        private int _PersonnelTaskId;
        private string _PersonnelName;
        private string _PersonnelSurname;
        private string _PersonnelPassword;
        private string _PersonnelUsername;
        private bool _Status;
        #endregion
        #region Properties
        public int PersonnelId { get => _PersonnelId; set => _PersonnelId = value; }
        public int PersonnelTaskId { get => _PersonnelTaskId; set => _PersonnelTaskId = value; }
        public string PersonnelName { get => _PersonnelName; set => _PersonnelName = value; }
        public string PersonnelSurname { get => _PersonnelSurname; set => _PersonnelSurname = value; }
        public string PersonnelPassword { get => _PersonnelPassword; set => _PersonnelPassword = value; }
        public string PersonnelUsername { get => _PersonnelUsername; set => _PersonnelUsername = value; }
        public bool Status { get => _Status; set => _Status = value; }
        #endregion

        public bool personnelSignInControl(string password, int UserId)
        {
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select * from Personnels where ID=@Id and PASSWORD=@password", con);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = UserId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            {
                bool result = false;
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
                return result;
            }
        }

   
        public void personnelGetInfo(ComboBox cbx)
        {
          
            cbx.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select * from Personnels", con);

            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Personnel personnel = new Personnel();
                personnel._PersonnelId = Convert.ToInt32(dr["ID"]);
                personnel._PersonnelTaskId = Convert.ToInt32(dr["TASKID"]);
                personnel._PersonnelName = Convert.ToString(dr["NAME"]);
                personnel._PersonnelSurname = Convert.ToString(dr["SURNAME"]);
                personnel._PersonnelPassword= Convert.ToString(dr["PASSWORD"]);
                personnel._PersonnelUsername = Convert.ToString(dr["USERNAME"]);
                personnel._Status = Convert.ToBoolean(dr["STATUS"]);
                cbx.Items.Add(personnel);

            }
            dr.Close();
            con.Close();
        }
        public override string ToString()
        {
            return PersonnelName +" " + PersonnelSurname;
        }
        //Listviewe ekleme yapıyoruz
        public void personnelGetInfoByLv(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select personnels.*, personnelTasks.TASK from Personnels Inner Join personnelTasks on personnelTasks.ID=personnels.TASKID where personnels.STATUS=0 ", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            int i = 0;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lv.Items.Add(Convert.ToString(dr["ID"]));
                lv.Items[i].SubItems.Add(Convert.ToString(dr["TASKID"]));
                lv.Items[i].SubItems.Add(Convert.ToString(dr["TASK"]));
                lv.Items[i].SubItems.Add(Convert.ToString(dr["NAME"]));
                lv.Items[i].SubItems.Add(Convert.ToString(dr["SURNAME"]));
                lv.Items[i].SubItems.Add(Convert.ToString(dr["USERNAME"]));
                i++;
            }
            dr.Close();
            con.Close();
        }
        //Listviewe ekleme yapıyoruz id ile
        public void personnelGetInfoById(ListView lv, int personnelId)
        {
         
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select personnels.*, personnelTasks.TASK from Personnels Inner Join personnelTasks on personnelTasks.ID=personnels.TASKID where personnels.STATUS=0 and personnels.ID=@personnelId", con);
            cmd.Parameters.Add("personnelId", SqlDbType.Int).Value = personnelId;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            int i = 0;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lv.Items.Add(Convert.ToString(dr["ID"]));
                lv.Items[i].SubItems.Add(Convert.ToString(dr["TASKID"]));
                lv.Items[i].SubItems.Add(Convert.ToString(dr["TASK"]));
                lv.Items[i].SubItems.Add(Convert.ToString(dr["NAME"]));
                lv.Items[i].SubItems.Add(Convert.ToString(dr["SURNAME"]));
                lv.Items[i].SubItems.Add(Convert.ToString(dr["USERNAME"]));
                i++;
            }
            dr.Close();
            con.Close();
        }
        
        //tek personelin isim bilgisini alıyoruz
        public string personnelGetName(int personnelId)
        {
            string result = "";
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select NAME+SURNAME  from Personnels where personnels.STATUS=0 and personnels.ID=@personnelId", con);
            cmd.Parameters.Add("personnelId", SqlDbType.Int).Value = personnelId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                result = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            con.Close();
            return result;
        }

        public bool personnelChangePassword(int personnelId, string password)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Update personnels set PASSWORD=@password where ID=@personnelId", con);
            cmd.Parameters.Add("@personnelId", SqlDbType.Int).Value = personnelId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = md5crypto(password);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            con.Close();


            return result;
        }

        public bool personnelAdd(Personnel personnel)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Insert Into personnels(NAME, SURNAME, PASSWORD, TASKID) values (@NAME, @SURNAME, @PASSWORD, @TASKID)", con);
            cmd.Parameters.Add("NAME", SqlDbType.VarChar).Value = personnel._PersonnelName;
            cmd.Parameters.Add("SURNAME", SqlDbType.VarChar).Value = personnel._PersonnelSurname;
            cmd.Parameters.Add("PASSWORD", SqlDbType.VarChar).Value = personnel.md5crypto(_PersonnelPassword);
            cmd.Parameters.Add("TASKID", SqlDbType.Int).Value = personnel._PersonnelTaskId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            con.Close();

           

            return result;
        }

        public string md5crypto(string tbxpass)
        {
            MD5CryptoServiceProvider obj = new MD5CryptoServiceProvider();
            byte[] pass = Encoding.UTF8.GetBytes(tbxpass);
            byte[] pass2 = obj.ComputeHash(pass);
            return Convert.ToBase64String(pass2);
        }
        public bool personnelUpdate(Personnel personnel, int perID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Update personnels set NAME=@NAME, SURNAME=@SURNAME, PASSWORD=@PASSWORD, TASKID=@TASKID where ID=@perID", con);
            cmd.Parameters.Add("perID", SqlDbType.Int).Value = perID;
            cmd.Parameters.Add("NAME", SqlDbType.VarChar).Value = personnel._PersonnelName;
            cmd.Parameters.Add("SURNAME", SqlDbType.VarChar).Value = personnel._PersonnelSurname;
            cmd.Parameters.Add("USERNAME", SqlDbType.VarChar).Value = personnel._PersonnelUsername;
            cmd.Parameters.Add("PASSWORD", SqlDbType.VarChar).Value = personnel.md5crypto(_PersonnelPassword);
            cmd.Parameters.Add("TASKID", SqlDbType.Int).Value = personnel._PersonnelTaskId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                result = Convert.ToBoolean(cmd.ExecuteNonQuery().ToString());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            con.Close();


            return result;
        }

        public bool personnelDelete(int perID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Update personnels set STATUS=1 where ID=@perID", con);
            cmd.Parameters.Add("perID", SqlDbType.Int).Value = perID;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            con.Close();


            return result;
        }
    }
}
   
     
