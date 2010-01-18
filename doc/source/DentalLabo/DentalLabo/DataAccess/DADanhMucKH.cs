using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalLabo.Data;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace DentalLabo.Data
{
    class DAKhachHang
    {
        public void AddKhachHang(KhachHang khachhang)
        {
            try
            {
                SqlConnection con;
                SqlCommand com = new SqlCommand();
                con = DataConnection.Connect();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "Insert into KhachHang values(@MaKH, @TenKH, @DienThoai, @GioiTinh, @MaSoThue, @NguoiDaiDien, @MaNhomKH, @DiaChi)";
                com.Parameters.Add("@MaKH", khachhang.MaKH);
                com.Parameters.Add("@TenKH", khachhang.TenKH);
                com.Parameters.Add("@DienThoai", khachhang.DienThoai);
                com.Parameters.Add("@GioiTinh", khachhang.GioiTinh);
                com.Parameters.Add("@MaSoThue", khachhang.MaSoThue);
                com.Parameters.Add("@NguoiDaiDien", khachhang.NguoiDaiDien);
                com.Parameters.Add("@MaNhomKH", khachhang.MaNhomKH);
                com.Parameters.Add("@DiaChi", khachhang.DiaChi);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi");
            }
        }

        public DataTable FindNV(string maBP)
        {
            string str = "Select * from KhachHang where MaKH='" + maBP + "'";
            SqlConnection con = DataConnection.Connect();
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

        public void UpdateKhachHang(KhachHang khachhang, string id, string idUpdate)
        {
            try
            {
                SqlConnection con;
                SqlCommand com = new SqlCommand();
                con = DataConnection.Connect();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                string str = "Update KhachHang Set ";
                str += "MaKH='" + khachhang.MaKH + "',";
                str += "TenKH=N'" + khachhang.TenKH + "',";
                str += "DienThoai=N'" + khachhang.DienThoai + "',";
                str += "GioiTinh='" + khachhang.GioiTinh + "',";
                str += "MaSoThue='" + khachhang.MaSoThue + "',";
                str += "NguoiDaiDien=N'" + khachhang.NguoiDaiDien + "',";
                str += "DiaChi=N'" + khachhang.DiaChi + "',";
                str += "MaNhomKH='" + khachhang.MaNhomKH + "' where ";
                str += id + "='" + idUpdate + "'";
                com.CommandText = str;
                //MessageBox.Show(str);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
        }
    }
}
