using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CafeOtomasyon.Class
{
    class PersonnelAction
    {
        General general = new General();
        #region Fields
        private int _PersonnelId;
        private int _PersonnelTaskId;
        private string _Action;
        private DateTime _Date;
        private bool _Status;
        #endregion

        #region Properties
        public int PersonnelId { get => _PersonnelId; set => _PersonnelId = value; }
        public int PersonnelTaskId { get => _PersonnelTaskId; set => _PersonnelTaskId = value; }
        public string Action { get => _Action; set => _Action = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public bool Status { get => _Status; set => _Status = value; }
        #endregion

        public bool PersonnelActionSave(PersonnelAction personnelAction)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(general.conString);
            SqlCommand cmd = new SqlCommand("Insert into personnelActions(PERSONNELID, ACTION, DATE)Values(@personnelId,@action,@date)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@personnelId", SqlDbType.Int).Value = personnelAction._PersonnelId;
                cmd.Parameters.Add("@action", SqlDbType.VarChar).Value = personnelAction._Action;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = personnelAction._Date;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            return result;
        }
    }



}
