using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

class Database {
    private static SqlConnection SQLConnection = new SqlConnection();
    public static bool hasConnect = false;

    public static void connectDatabase(string server, string user, string pass, string db) {
        string ConnectionString = "Network Library=dbmssocn;Address=127.0.0.1\\SQLEXPRESS;";
        ConnectionString += "User ID=sa;";
        ConnectionString += "Password=abc123;";
        ConnectionString += "Initial Catalog=" + db;  

        try
        {
            SQLConnection.ConnectionString = ConnectionString;
            SQLConnection.Open();
            hasConnect = true;
            // You can get the server version 
            // SQLConnection.ServerVersion
        }
        catch (Exception Ex)
        {
            // Try to close the connection
            if (SQLConnection != null)
                SQLConnection.Dispose();

            // Create a (useful) error message
            string ErrorMessage = "A error occurred while trying to connect to the server.";
            ErrorMessage += Environment.NewLine;
            ErrorMessage += Environment.NewLine;
            ErrorMessage += Ex.Message;

            // Show error message (this = the parent Form object)            
            MessageBox.Show(null, ErrorMessage, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }
    }

    public DataTable query(String SQLQuery) {
        SqlDataAdapter SQLDataAdapter = new SqlDataAdapter(SQLQuery, SQLConnection);

        // Create a new DataTable
        DataTable dtResult = new DataTable();

        // Fill the DataTable with the result of the SQL statement
        SQLDataAdapter.Fill(dtResult);

        // We don't need the data adapter any more
        SQLDataAdapter.Dispose();        
        return dtResult;
    }

}