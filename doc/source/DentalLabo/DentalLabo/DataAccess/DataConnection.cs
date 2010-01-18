using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DentalLabo.Data
{
    class DataConnection
    {
        public static SqlConnection Connect()
        {
            string strCon = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DentalLabo;User Id=sa;Password=trungbq";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            return con;
        }

        public static DataTable Query(string str)
        {
            SqlConnection con = Connect();
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand(str, con);
            com.CommandText = str;
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);
            return dt;
        }
    }
}
