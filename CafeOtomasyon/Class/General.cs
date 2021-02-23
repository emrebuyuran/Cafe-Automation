using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CafeOtomasyon.Class
{
    class General
    {
        
        public static string source, database, security;
        public static int _personnelId;
        public static int _taskId;
        public static string _buttonValue;
        public static string _buttonName;
        public static int _serviceTypeId;
        public static string _additionId;
        public static int _customerAdd;
        public static int _customerId;
        public static string temp;
        public void ConnectionFunc()
        {
           
            string address = @"C:\Users\asus\source\repos\CafeOtomasyon\CafeOtomasyon\bin\Debug\Settings.txt";
            using (StreamReader reader = new StreamReader(address))
            {
                while (reader.Peek()>=0)
                {
                    string str = reader.ReadLine();
                    string [] info=str.Split(';');
                    source = info[0].ToString();
                    database = info[1].ToString();
                    security = info[2].ToString();
                    temp = ("Server=" + source + ";Database =" + database + ";Trusted_Connection="+security +"");
                }
                reader.Close();
            
            }
        }
        public string conString = temp;
    }
}
