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
    class PersonnelTask
    {
        General general = new General();

        private int _personnelTaskId;
        private string _task;

        public int PersonnelTaskId { get => _personnelTaskId; set => _personnelTaskId = value; }
        public string Task { get => Task; set => Task = value; }


        public void GetPersonnelTasks(ComboBox cbx)
        {
            cbx.Items.Clear();
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select * from personnelTasks", con);
            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    PersonnelTask personnelTask = new PersonnelTask();
                    personnelTask._personnelTaskId = Convert.ToInt32(dr["ID"].ToString());
                    personnelTask._task = dr["TASK"].ToString();
                    cbx.Items.Add(personnelTask);


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
        public string PersonnelTaskStatements(int personnel)
        {

            string result = "";
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select TASK from personnelTasks where ID=@personnel", con);

            cmd.Parameters.Add("@personnel", SqlDbType.Int).Value = personnel;

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

            finally
            {
                con.Dispose();
                con.Close();

            }

            return result;
        }
        public int PersonnelTasks(int personnel)
        {

            int result = 0;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Select ID from personnelTasks where ID=@personnel", con);

            cmd.Parameters.Add("@personnel", SqlDbType.Int).Value = personnel;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

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
        public override string ToString()
        {
            return _task;
        }
    }
}
