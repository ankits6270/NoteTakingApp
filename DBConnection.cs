using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace NoteTakingApp
{
    internal class DBConnection
    {
        private static SqlConnection con = new SqlConnection(@"Your_Sql_Connection");

        public static void close_con()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public static SqlConnection get_con()
        {
            return con;
        }
        public static void open_con()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
    }
}
