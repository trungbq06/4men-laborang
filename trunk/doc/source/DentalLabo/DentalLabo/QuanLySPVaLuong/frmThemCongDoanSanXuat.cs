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
    public partial class frmThemCongDoanSanXuat : Form
    {
        private String masomau;
        public frmThemCongDoanSanXuat(String _masomau)
        {
            masomau = _masomau;
            if (masomau == "")
            {
                MessageBox.Show("Mẫu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            InitializeComponent();
        }

        private void frmThemCongDoanSanXuat_Load(object sender, EventArgs e)
        {
            lblThemCongDoanSanXuat.Text = "THÊM CÔNG ĐOẠN SẢN XUẤT CHO MẪU '" + masomau + "'";
            txtSoLan.Text = "0";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            String insertQuery = "insert into chamcongdoan(macd, manv, mamau, solan) values";
            insertQuery += "('" + txtMaCongDoan.Text + "','" + txtMaNhanVien.Text + "','" + masomau + "','" + txtSoLan.Text + "')";

            Database.query(insertQuery);
   
            this.Close();
        }

        private void txtMaCongDoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaCongDoan_Enter(object sender, EventArgs e)
        {

        }


        private void txtMaCongDoan_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyValue.ToString());
            if ((e.KeyCode != Keys.Enter)&&(e.KeyCode!=Keys.Tab))
                return;
            DataTable tb = Database.query("select tencd from congdoansx where macd='" + txtMaCongDoan.Text + "'");
            if (tb.Rows.Count > 0)
            {
                txtTenCongDoan.Text = tb.Rows[0].ItemArray[0].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy công đoạn này", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMaNhanVien_KeyDown(object sender, KeyEventArgs e)
        {

            //MessageBox.Show(e.KeyCode.ToString());
            if ((e.KeyCode != Keys.Enter) && (e.KeyCode != Keys.Tab))
                return;

            DataTable tb = Database.query("select tennv from nhanvien where manv='" + txtMaNhanVien.Text + "'");
            if (tb.Rows.Count > 0)
            {
                txtTenNhanVien.Text = tb.Rows[0].ItemArray[0].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên này", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMaNhanVien_TabIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Tab");
        }

        private void txtMaNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtTenCongDoan_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
