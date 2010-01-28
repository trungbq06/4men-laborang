using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bạn thực hiện quá nhiều kết nối!", "Thông báo");
            }

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
            con.Close();
            return dt;
        }

        public static string GetMa(string table, string ma, string start)
        {
            DataTable dt = new DataTable();
            //MessageBox.Show("Select Top 1 " + ma + " from " + table + " where " + ma + " like '" + start + "%' order by len(" + ma + ") desc, " + ma + " desc");
            dt = Query("Select Top 1 " + ma + " from " + table + " where " + ma + " like '" + start + "%' order by len(" + ma + ") desc, " + ma + " desc");
            
            int maSo = 1;
            string returnStr = start + "1";
            if (dt.Rows.Count != 0)
            {
                string maSo1 = dt.Rows[0][0].ToString();
                //MessageBox.Show(maSo1);
                maSo = Int32.Parse(maSo1.Substring(2, maSo1.Length - 2));
                maSo += 1;
                returnStr = start + maSo.ToString();
                if (returnStr.Length < maSo1.Length) returnStr = start + "0" + maSo.ToString();
                //MessageBox.Show(returnStr);
            }
            return returnStr;
        }
    }
}
