using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalLabo.Data;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace DentalLabo.DataAccess
{
    class DABangGiaSP
    {
        public void AddDanhMuc(BangGiaSP danhmuc)
        {
            try
            {
                SqlConnection con;
                SqlCommand com = new SqlCommand();
                con = DataConnection.Connect();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "Insert into BangGia values(@MaSP, @MaVL, @DonGia, @TinhThem)";
                com.Parameters.Add("@MaSP", danhmuc.MaSP);
                com.Parameters.Add("@MaVL", danhmuc.MaVL);
                com.Parameters.Add("@DonGia", danhmuc.DonGia);
                com.Parameters.Add("@TinhThem", danhmuc.TinhThem);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không đúng hoặc đã tồn tại trong CSDL!", "Lỗi");
            }
        }

        public void UpdateDanhMuc(BangGiaSP banggia, string id, string idUpdate, string id1, string idUpdate1)
        {
            try
            {
                SqlConnection con;
                SqlCommand com = new SqlCommand();
                con = DataConnection.Connect();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                string str = "Update BangGia Set ";
                str += "DonGia=N'" + banggia.DonGia + "',";
                str += "GiaTinhThem='" + banggia.TinhThem + "' where ";
                str += id + "='" + idUpdate + "' and ";
                str += id1 + "='" + idUpdate1 + "'";
                com.CommandText = str;
                MessageBox.Show(str);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không đúng hoặc đã tồn tại trong CSDL!", "Lỗi");
            }
        }
    }
}
