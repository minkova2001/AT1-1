using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT1
{
    class sqlconnect
    {
        public static SqlConnection sql_con = new SqlConnection(@"Data Source=LAPTOP-B23Q79Q1\SQLEXPRESS;Initial Catalog=Atelie;Integrated Security=True");
        public static bool connect_open()
        {
            bool temp = false;
            try
            {
                sql_con.Open();
                temp = true;
            }
            catch
            {
                temp = false;
            }
            return temp;
        }
        public static void sqlconnect_close()
        {
            try
            {
                sql_con.Close();
            }
            catch { }
        }
    }
}

