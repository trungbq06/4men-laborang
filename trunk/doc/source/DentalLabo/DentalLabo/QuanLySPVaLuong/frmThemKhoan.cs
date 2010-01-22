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
    public partial class frmThemKhoan : Form
    {
        private String manv;
        private frmQLSP parentForm ;
        public frmThemKhoan(String _manv, frmQLSP parent)
        {
            InitializeComponent();
            manv = _manv;
            parentForm = parent;
            DataTable NVInfo = Database.query("Select manv, tennv from nhanvien where manv='"+manv+"'");
            if (NVInfo.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên này");
                this.Close();
            }
            txtTenNhanVien.Text = NVInfo.Rows[0].ItemArray[1].ToString();
            txtMaNhanVien.Text = manv;
            DataTable loaikl = new DataTable();

            loaikl.Columns.Add("Loai");
            loaikl.Columns.Add("GiaTri");
            DataRow dr = loaikl.NewRow();
            dr["Loai"] = "Lương chính";
            dr["GiaTri"] = "LuongChinh";
            loaikl.Rows.Add(dr);

            DataRow dr1 = loaikl.NewRow();
            dr1["Loai"] = "Lương tính thêm";
            dr1["GiaTri"] = "LuongTinhThem";
            loaikl.Rows.Add(dr1);

            DataRow dr2 = loaikl.NewRow();
            dr2["Loai"] = "Các khoản phải trừ";
            dr2["GiaTri"] = "LuongTru";
            loaikl.Rows.Add(dr2);

            cbLoaiKhoanLuong.DataSource = loaikl;
            cbLoaiKhoanLuong.ValueMember = "GiaTri";
            cbLoaiKhoanLuong.DisplayMember = "Loai";

            DataTable ListLuongTru = Database.query("select makhoan, tenkhoan from khoanluong");
            cbKhoanLuong.DataSource = ListLuongTru;
            cbKhoanLuong.DisplayMember = "tenkhoan";
            cbKhoanLuong.ValueMember = "makhoan";

            txtSoLuong.Text = "0";
            txtGhiChu.Text = "";
        }

        

        

        private void frmThemKhoan_Load(object sender, EventArgs e)
        {

        }

        private void cbLoaiKhoanLuong_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbLoaiKhoanLuong.SelectedValue.ToString() == "LuongTru")
            {
                DataTable ListLuongTru = Database.query("select makhoan, tenkhoan from khoantru");
                cbKhoanLuong.DataSource = ListLuongTru;
                cbKhoanLuong.DisplayMember = "tenkhoan";
                cbKhoanLuong.ValueMember = "makhoan";
            }
            else
            {
                DataTable ListLuongTru = Database.query("select makhoan, tenkhoan from khoanluong");
                cbKhoanLuong.DataSource = ListLuongTru;
                cbKhoanLuong.DisplayMember = "tenkhoan";
                cbKhoanLuong.ValueMember = "makhoan";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //System.Console.WriteLine("insert into " + cbLoaiKhoanLuong.SelectedValue.ToString() + " (manv, makhoan, soluong, ghichu, ngay) values('" + txtMaNhanVien.Text + "', '" + cbKhoanLuong.SelectedValue.ToString() + "', " + txtSoLuong.Text + ", '" + txtGhiChu.Text + "', '" + dtpNgay.Value.ToString("yyyy-MM-dd") + "')");
                Database.query("insert into " + cbLoaiKhoanLuong.SelectedValue.ToString() + " (manv, makhoan, soluong, ghichu, ngay) values('"+txtMaNhanVien.Text+"', '"+cbKhoanLuong.SelectedValue.ToString()+"', "+txtSoLuong.Text+", '"+txtGhiChu.Text+"', '"+dtpNgay.Value.ToString("yyyy-MM-dd")+"')");
                parentForm.btnTinhLuongTimKiem_Click(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không chèn được vào cơ sở dữ liệu");
            }
        }

        private void txtMaNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable NVInfo = Database.query("Select manv, tennv from nhanvien where manv='" + txtMaNhanVien.Text + "'");
                if (NVInfo.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên này");
                    return;
                }
                txtTenNhanVien.Text = NVInfo.Rows[0].ItemArray[1].ToString();
            }
        }
    }
}
