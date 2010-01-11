using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

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

    }
}
