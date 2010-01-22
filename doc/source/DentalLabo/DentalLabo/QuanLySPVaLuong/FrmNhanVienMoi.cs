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
    public partial class FrmNhanVienMoi : Form
    {
        public FrmNhanVienMoi()
        {
            InitializeComponent();
        }

        private void FrmNhanVienMoi_Load(object sender, EventArgs e)
        {
            DataTable ListBP = Database.query("select mabp, tenbp from bophan");
            cbBoPhan.DataSource = ListBP;
            cbBoPhan.DisplayMember = "tenbp";
            cbBoPhan.ValueMember = "mabp";

            DataTable ListGioiTinh = new DataTable();
            ListGioiTinh.Columns.Add("GioiTinh", typeof(string));
            ListGioiTinh.Columns.Add("GiaTri", typeof(string));

            DataRow dr = ListGioiTinh.NewRow();
            dr["GioiTinh"] = "Nam";
            dr["GiaTri"] = "Nam";

            ListGioiTinh.Rows.Add(dr);
            DataRow dr1 = ListGioiTinh.NewRow();
            dr1["GioiTinh"] = "Nữ";
            dr1["GiaTri"] = "Nữ";
            ListGioiTinh.Rows.Add(dr1);

            cbGioiTinh.DataSource = ListGioiTinh;
            cbGioiTinh.DisplayMember = "GioiTinh";
            cbGioiTinh.ValueMember = "GiaTri";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((txtMaNhanVien.Text == "") || (txtTenNhanVien.Text == "") || (txtNamSinh.Text == "") || (txtSoCMT.Text == "")||(txtDiaChi.Text == ""))
            {
                MessageBox.Show("Chưa đủ thông tin");
            }
            DataTable tmp = Database.query("select * from nhanvien where manv='"+txtMaNhanVien.Text +"'");
            
            if (tmp.Rows.Count > 0)
            {
                MessageBox.Show("Đã tồn tại nhân viên có mã '" + txtMaNhanVien.Text + "'");
                return;
            }
            try
            {
                String insertQuery = "insert into nhanvien(manv, mabp, tennv, gioitinh, namsinh, socmt, diachi, dienthoai) values('" + txtMaNhanVien.Text + "','" + cbBoPhan.SelectedValue.ToString() + "','" + txtTenNhanVien.Text + "','" + cbGioiTinh.SelectedValue.ToString() + "','" + txtNamSinh.Text + "','" + txtSoCMT.Text + "','" + txtDiaChi.Text + "','" + txtSDT.Text + "')";
                Database.query(insertQuery);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm vào CSDL do dữ liệu nhập vào chưa đúng!");
                return;
            }
        }
    }
}
