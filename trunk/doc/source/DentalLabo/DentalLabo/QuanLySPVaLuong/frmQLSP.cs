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

        private void setDatagridView(String masomau)
        {
            //MessageBox.Show(masomau);
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Dentallabo;Integrated Security=SSPI");
            SqlDataReader rdr = null;
            String MaSanPhamDatHang = "";
          
            try
            {
                conn.Open();
                String SelectQuery = "select MaSPDatHang from mauhang_sanphamdathang where mamau='" + masomau + "'";
                //MessageBox.Show(SelectQuery);
                SqlCommand cmd = new SqlCommand(SelectQuery, conn);
                rdr = cmd.ExecuteReader();
                int count = 0;
                while (rdr.Read())
                {
                    count++;
                    //System.Console.WriteLine(rdr[0]);
                    MaSanPhamDatHang = Convert.ToString(rdr[0]);
                    break;
                    //dateTimePickerNgayNhanMau.Value = Convert.ToDateTime(rdr[2]);
                }
                if (count == 0)
                {
                    //MessageBox.Show("Không tìm thấy mẫu hàng có mã là " + txtQuanLyDonViSanPhamMaSoMau.Text, "Không tìm thấy!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                SelectQuery = "select * from sanphamdathang where maspdathang='" + MaSanPhamDatHang + "'";
                rdr.Close();
                cmd = new SqlCommand(SelectQuery, conn);
                rdr = cmd.ExecuteReader();
                String [,] content =  new String [100,8];
                count = 0;

                //DataTable content = new DataTa    ble();
                while (rdr.Read())
                {
                    count++;
                    //dtgQLDonViSanPhamNoiDungYeuCauPhucVu.DataSource[count] = 
                    //content[count][0] = count;
                    content[count,0] = Convert.ToString(count);
                    for (int i = 0; i < 7; i++)
                        content[count, i + 1] = Convert.ToString(rdr[i]);
                    //System.Console.WriteLine(Convert.ToString(rdr[i]));
                    //System.Console.WriteLine(Convert.ToString(rdr[0]));
                    //System.Console.WriteLine(Convert.ToString(rdr[0]));
                }

                rdr.Close();
                int numRowOfDtg = count;
                SelectQuery = "select masp,tensp,dvt,soluongquychuan from sanpham";
                String[,] ListSanPham = new String[1000 , 4];
                cmd = new SqlCommand(SelectQuery, conn);
                rdr = cmd.ExecuteReader();
                count = 0;
                while (rdr.Read())
                {
                    count++;
                    ListSanPham[count, 1] = Convert.ToString(rdr[1]);
                    ListSanPham[count, 0] = Convert.ToString(rdr[0]);
                    ListSanPham[count, 2] = Convert.ToString(rdr[2]);
                    ListSanPham[count, 3] = Convert.ToString(rdr[3]);
                  }
                rdr.Close();
                int numOfSanPham = count;

                SelectQuery = "select  mavl, tenvl from vatlieuchinh";
                String[,] ListVatLieuChinh = new String[1000 , 2];
                cmd = new SqlCommand(SelectQuery, conn);
                rdr = cmd.ExecuteReader();
                count = 0;
                while (rdr.Read())
                {
                    count++;
                    ListVatLieuChinh[count, 1] = Convert.ToString(rdr[1]);
                    ListVatLieuChinh[count, 0] = Convert.ToString(rdr[0]);
                    //ListVatLieuChinh[count, 2] = Convert.ToString(rdr[2]);

                  }
                rdr.Close();

                int numOfVatLieu = count;

                


                for (int i = 1; i <= numRowOfDtg; i++)
                {
                    int n = dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows.Add();
                    //for (int j = 0; j <= 7; j++)
                      //  
                    dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[0].Value = content[i, 0];
                    for (int j = 1; j<= numOfSanPham; j++)
                        if (ListSanPham[j, 0] == content[i, 2])
                        {
                            dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[1].Value = ListSanPham[j, 1];
                            dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[5].Value = ListSanPham[j, 2];
                            dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[6].Value = ListSanPham[j, 3];
                            dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[7].Value = ListSanPham[j, 3];
                            break;
                        }
                    //MessageBox.Show(content[i, 4]);
                    for (int j = 1; j <= numOfVatLieu; j++)
                        if (ListVatLieuChinh[j, 0] == content[i, 4])
                        {
                            dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[3].Value = ListVatLieuChinh[j, 1];
                            break;
                        }
                    dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[2].Value = content[i, 3];
                    //dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[3].Value = content[i, 4];
                    dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[4].Value = content[i, 2];
                    //dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[5].Value = content[i, 5];
                    //dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[6].Value = content[i, 6];
                    //dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[7].Value = content[i, 7];


                }
                //dtgQLDonViSanPhamNoiDungYeuCauPhucVu.DataSource = content;

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
            setDatagridView(txtQuanLyDonViSanPhamMaSoMau.Text);

        }

        private void dgtTinhLuongCacKhoanPhaiTru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
