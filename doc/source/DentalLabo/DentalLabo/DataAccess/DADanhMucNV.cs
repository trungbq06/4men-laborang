using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalLabo.Data;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace DentalLabo.DataAccess
{
    class DADanhMucNV
    {
        public void AddDanhMuc(DanhMucNV danhmuc)
        {
            try
            {
                SqlConnection con;
                SqlCommand com = new SqlCommand();
                con = DataConnection.Connect();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "Insert into NhanVien values(@MaNV, @MaBP, @TenNV, @GioiTinh, @NamSinh, @SoCMT, @DiaChi, @DienThoai)";
                com.Parameters.Add("@MaNV", danhmuc.MaNV);
                com.Parameters.Add("@MaBP", danhmuc.MaBP);
                com.Parameters.Add("@TenNV", danhmuc.TenNV);
                com.Parameters.Add("@GioiTinh", danhmuc.GioiTinh);
                com.Parameters.Add("@NamSinh", danhmuc.NamSinh);
                com.Parameters.Add("@SoCMT", danhmuc.SoCMT);
                com.Parameters.Add("@DiaChi", danhmuc.DiaChi);
                com.Parameters.Add("@DienThoai", danhmuc.DienThoai);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
        }

        public DataTable FindNV(string maBP)
        {
            string str = "Select * from NhanVien where MaBP='" + maBP + "'";
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

        public void UpdateDanhMuc(DanhMucNV nhanvien, string id, string idUpdate)
        {
            try
            {
                SqlConnection con;
                SqlCommand com = new SqlCommand();
                con = DataConnection.Connect();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                string str = "Update NhanVien Set ";
                str += "MaBP='"+nhanvien.MaBP+"',";
                str += "TenNV=N'" + nhanvien.TenNV + "',";
                str += "GioiTinh=N'" + nhanvien.GioiTinh + "',";
                str += "NamSinh='" + nhanvien.NamSinh + "',";
                str += "SoCMT='" + nhanvien.SoCMT + "',";
                str += "DiaChi=N'" + nhanvien.DiaChi + "',";
                str += "DienThoai='" + nhanvien.DienThoai + "' where ";
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
