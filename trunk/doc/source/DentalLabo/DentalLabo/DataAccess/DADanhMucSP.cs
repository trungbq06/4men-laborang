using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DentalLabo.Data
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
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
