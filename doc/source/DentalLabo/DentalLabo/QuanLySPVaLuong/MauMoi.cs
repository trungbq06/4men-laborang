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
            String insertQuery = "insert into mauhang(mamau, makh, ngaynhan, ngaytra, giotra, userid, trangthai) values(";
            insertQuery += "'"+txtMaMau.Text+"',";
            insertQuery += "'" + txtMaKhachHang.Text + "',";
            insertQuery += "'" + dtpNgayNhan.Value.ToString() + "',";
            insertQuery += "'" + dtpNgayTra.Value.ToString() + "',";
            insertQuery += "'" + txtGioTra.Text + "',";
            insertQuery += "'1','1')";
            System.Console.WriteLine(insertQuery);
            Database.query(insertQuery);
            this.Close();
        }
    }
}
