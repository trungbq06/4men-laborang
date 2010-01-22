using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalLabo.QuanLySPVaLuong
{
    public partial class MauMoi : Form
    {
        public MauMoi()
        {
            InitializeComponent();
        }

        private void MauMoi_Load(object sender, EventArgs e)
        {
            txtGioTra.Text = "0";
            DataTable MH = Database.query("select count(*) from mauhang");
            int c = Convert.ToInt32(MH.Rows[0].ItemArray[0].ToString());
            while (true)
            {
                DataTable tmp = Database.query("Select * from mauhang where mamau='MH"+(c+1).ToString()+"'");
                if (tmp.Rows.Count == 0)
                    break;
            }
            txtMaMau.Text = "MH" + (c + 1).ToString();
        }

        private void btnThemNoiDungYeuCau_Click(object sender, EventArgs e)
        {
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            
            if ((txtMaMau.Text == "") || (txtMaKhachHang.Text == ""))
            {
                MessageBox.Show("Cần nhập vào Mã Khách Hàng và Mã Mấu");
                return;
            }

            
            DataTable tmp = Database.query("Select  * from khachhang where makh='"+txtMaKhachHang.Text+"'");
            if (tmp.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có khách hàng này!");
                return;
            }

            tmp = Database.query("select * from mauhang where mamau='"+txtMaMau.Text+"'");
            if (tmp.Rows.Count > 0)
            {
                MessageBox.Show("Mã mẫu này đã tồn tại! Xin nhập lại!");
                return;
            }
            try
            {
                String insertQuery = "insert into mauhang(mamau, makh, ngaynhan, ngaytra, giotra, userid, trangthai, loaiphuchinh) values(";
                insertQuery += "'" + txtMaMau.Text + "',";
                insertQuery += "'" + txtMaKhachHang.Text + "',";
                insertQuery += "'" + dtpNgayNhan.Value.ToString() + "',";
                insertQuery += "'" + dtpNgayTra.Value.ToString() + "',";
                insertQuery += "'" + txtGioTra.Text + "',";
                insertQuery += "'1','1','" + txtLoaiPhucHinh.Text + "')";
                System.Console.WriteLine(insertQuery);
                Database.query(insertQuery);
                this.Close();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
