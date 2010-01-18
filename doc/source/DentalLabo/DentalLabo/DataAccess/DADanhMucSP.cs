using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using DentalLabo.Data;

namespace DentalLabo.DataAccess
{
    class DADanhMucSP
    {
        public void AddDanhMuc(DanhMucSP danhmuc)
        {
            try
            {
                SqlConnection con;
                SqlCommand com = new SqlCommand();
                con = DataConnection.Connect();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "Insert into SanPham values(@MaSP, @TenSP, @PhamChat, @DVT, @NhomHangHoa, @GhiChu)";
                com.Parameters.Add("@MaSP", danhmuc.MaSP);
                com.Parameters.Add("@TenSP", danhmuc.TenSP);
                com.Parameters.Add("@PhamChat", danhmuc.PhamChat);
                com.Parameters.Add("@DVT", danhmuc.DVT);
                com.Parameters.Add("@NhomHangHoa", danhmuc.NhomHangHoa);
                com.Parameters.Add("@GhiChu", danhmuc.GhiChu);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
        }

        public DataTable GetDanhMuc(string table)
        {
            SqlConnection con;            
            string str = "Select * from " + table + "";
            con = DataConnection.Connect();
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand(str, con);
            com.CommandText = str;
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);
            DataColumn dtColumn = new DataColumn();
            dtColumn.ColumnName = "Xác nhận";
            dtColumn.DataType = typeof(bool);
            dt.Columns.Add(dtColumn);
            return dt;
        }

        public void DeleteFromDanhMuc(ArrayList array, string table, string id)
        {
            SqlConnection con;
            con = DataConnection.Connect();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            string str = "Delete from " + table + " where " + id + "=";
            try
            {
                foreach (string i in array)
                {
                    string tmp = str;
                    tmp = tmp + "'" + i + "'";
                    //MessageBox.Show(tmp);
                    com.CommandText = tmp;
                    com.ExecuteNonQuery();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Không thể xóa! Dữ liệu này có ở ở các bảng khác!\nXóa dữ liệu trong các bảng khác sau đó thực hiện lại tác vụ này!");
            }
        }

        public void DeleteFromDanhMucs(ArrayList array, ArrayList array1, string table, string id, string id1)
        {
            SqlConnection con;
            con = DataConnection.Connect();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            string str = "Delete from " + table + " where ";
            int j = 0;
            try
            {
                foreach (string i in array)
                {
                    string tmp = str;
                    tmp += id + "='" + i + "' and " + id1 + "='" + array1[j] + "'";
                    com.CommandText = tmp;
                    com.ExecuteNonQuery();
                    j++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa! Dữ liệu này có ở ở các bảng khác!\nXóa dữ liệu trong các bảng khác sau đó thực hiện lại tác vụ này!" + ex.ToString());
            }
        }
    }
}
