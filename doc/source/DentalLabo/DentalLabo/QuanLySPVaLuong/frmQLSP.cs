using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DentalLabo
{
    public partial class frmQLSP : Form
    {
        public frmQLSP()
        {
            InitializeComponent();
        }

        private void frmQLSP_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgayNhanMau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgChamCongTongHopKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblTinhLuongMaNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void lblNoiDungYeuCauPhucVu_Click(object sender, EventArgs e)
        {

        }

        private void subTabChamCongVaLamThem_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongTenNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongMaBoPhan_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongMaNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnChamCongTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongNgayCongChinh_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongNgayCongNghi_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongLamThemGio_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongTrucCN_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongMaNVCC_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongTenBoPhan_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongNgayChamCong_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxBoPhanNhanVien_Enter(object sender, EventArgs e)
        {

        }

        private void btnXemPhieuThanhToanLuong_Click(object sender, EventArgs e)
        {

        }

        private void dtgTamUngLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNgayNhanMau_Click(object sender, EventArgs e)
        {

        }

        private void txtQuanLyDonViSanPhamMaSoMau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuanLyDonViSanPhamMaSoMau_Enter(object sender, EventArgs e)
        {

        }

        private void txtQuanLyDonViSanPhamMaSoMau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Dentallabo;Integrated Security=SSPI");
                SqlDataReader rdr = null;
                try
                {
                    conn.Open();
                    String SelectQuery = "select * from mauhang where mamau='" + txtQuanLyDonViSanPhamMaSoMau.Text + "'";
                    //MessageBox.Show(SelectQuery);
                    SqlCommand cmd = new SqlCommand(SelectQuery, conn);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {                        
                        dateTimePickerNgayNhanMau.Value = Convert.ToDateTime(rdr[2]);
                    }
                }
                finally
                {
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnQLSPTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Dentallabo;Integrated Security=SSPI");
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                String SelectQuery = "select * from mauhang where mamau='" + txtQuanLyDonViSanPhamMaSoMau.Text + "'";
                //MessageBox.Show(SelectQuery);
                SqlCommand cmd = new SqlCommand(SelectQuery, conn);
                rdr = cmd.ExecuteReader();
                int count = 0;
                while (rdr.Read())
                {
                    count++;
                    dateTimePickerNgayNhanMau.Value = Convert.ToDateTime(rdr[2]);
                }
                if (count == 0)
                {
                    MessageBox.Show("Không tìm thấy mẫu hàng có mã là " + txtQuanLyDonViSanPhamMaSoMau.Text,"Không tìm thấy!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }



            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void dgtTinhLuongCacKhoanPhaiTru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
