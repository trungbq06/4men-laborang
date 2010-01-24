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
        public static string server;
        public static string user;
        public static string pass;
        public static string db;

        public static SqlConnection Connect()
        {
            string ConnectionString = "Network Library=dbmssocn;Address=" + server + ";";
            ConnectionString += "User ID=" + user + ";";
            ConnectionString += "Password=" + pass + ";";
            ConnectionString += "Initial Catalog=" + db;
            SqlConnection con = new SqlConnection(ConnectionString);
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
