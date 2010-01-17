using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DentalLabo.Quan_ly_san_pham_va_tinh_luong;
using DentalLabo.QuanLySPVaLuong;

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

        }


        private void btnQLSPTimKiem_Click(object sender, EventArgs e)
        {
            String MaMau = txtQuanLyDonViSanPhamMaSoMau.Text;
            String selectQ = "select * from mauhang where mamau='"+MaMau+"'";

            dtgQLDonViSanPhamCongDoanPhucHinh.Rows.Clear();
            dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows.Clear();
            
            //dtgQLDonViSanPhamNoiDungYeuCauPhucVu.DataSource = null;
            //System.Console.WriteLine(selectQ);
            DataTable dt = Database.query(selectQ);

            DataTableReader dtr = dt.CreateDataReader();
            int count = 0;
            while (dtr.Read())
            {
                count++;
                //dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows.Add();
                dateTimePickerNgayNhanMau.Value = Convert.ToDateTime(dtr.GetValue(2).ToString());
                break;
            }
            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy mẫu hàng có mã là " + txtQuanLyDonViSanPhamMaSoMau.Text, "Không tìm thấy!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dtr.Close();

            
            DataTable dtSPDH = Database.query("Select MaSPDatHang from MauHang_SanPhamDatHang where MaMau='" + MaMau + "'");           

            DataTable ListSP = Database.query("select masp,tensp,dvt,soluongquychuan from sanpham");

            DataTable ListVLC = Database.query("select  mavl, tenvl from vatlieuchinh");

            if (dtSPDH.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm đặt hàng!");
            }

            for (int i = 0; i < dtSPDH.Rows.Count; i++)
            {
                //MessageBox.Show(dtSPDH.Rows[i].ItemArray[0].ToString());
                DataTable SPDHInfo = Database.query("select * from sanphamdathang where maspdathang='" + dtSPDH.Rows[i].ItemArray[0] + "'");
                int n = dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows.Add();
                dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[0].Value = (i + 1).ToString();
                //MessageBox.Show(SPDHInfo.Rows[0].ItemArray[1].ToString());
                for (int j=0; j<ListSP.Rows.Count; j++)
                    if (ListSP.Rows[j].ItemArray[0].ToString() == SPDHInfo.Rows[0].ItemArray[1].ToString())
                    {
                        //System.Console.WriteLine(ListSP.Rows[j].ItemArray[0]);
                        dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[1].Value = ListSP.Rows[j].ItemArray[1].ToString();
                        dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[5].Value = ListSP.Rows[j].ItemArray[2].ToString();
                        dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[6].Value = ListSP.Rows[j].ItemArray[3].ToString();
                        dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[7].Value = ListSP.Rows[j].ItemArray[3].ToString();
                        break;
                    }

                for (int j = 0; j < ListVLC.Rows.Count; j++)
                    if (ListVLC.Rows[j].ItemArray[0].ToString() == SPDHInfo.Rows[0].ItemArray[3].ToString())
                    {
                        dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[3].Value = ListVLC.Rows[j].ItemArray[1].ToString();
                        break;
                    }
                dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[2].Value = SPDHInfo.Rows[0].ItemArray[2].ToString();
                dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[4].Value = SPDHInfo.Rows[0].ItemArray[1].ToString();
            }


            DataTable ChamCongDoan = Database.query("Select macd, manv, solan from chamcongdoan where mamau='" + MaMau + "'");

            for (int i = 0; i < ChamCongDoan.Rows.Count; i++)
            {
                DataTable CDSXInfo = Database.query("select tencd, donvitinh, soluongquychieu from congdoansx where macd='" + ChamCongDoan.Rows[i].ItemArray[0].ToString() + "'");
                int n = dtgQLDonViSanPhamCongDoanPhucHinh.Rows.Add();
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[0].Value = (i + 1).ToString();
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[1].Value = CDSXInfo.Rows[0].ItemArray[0].ToString();
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[2].Value = ChamCongDoan.Rows[i].ItemArray[0].ToString();
                DataTable NVInfo = Database.query("select tennv from nhanvien where manv='"+ChamCongDoan.Rows[i].ItemArray[1].ToString()+"'");
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[3].Value = NVInfo.Rows[0].ItemArray[0].ToString() ;
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[4].Value = ChamCongDoan.Rows[i].ItemArray[1].ToString();
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[5].Value = CDSXInfo.Rows[0].ItemArray[1].ToString();
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[6].Value = CDSXInfo.Rows[0].ItemArray[2].ToString();
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[7].Value = ChamCongDoan.Rows[i].ItemArray[2].ToString();

            }
            
        }

        private void dgtTinhLuongCacKhoanPhaiTru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMauMoi_Click(object sender, EventArgs e)
        {
            Form f = new MauMoi();
            f.Show();
        }

        private void btnQuanLyDonViSanPhamThemYeuCau_Click(object sender, EventArgs e)
        {
            Form f = new frmThemNoiDungYeuCau(txtQuanLyDonViSanPhamMaSoMau.Text);
            f.Show();
        }

        private void btnQuanLyDonViSanPhamXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows.Count; i++)
            if (dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[i].Selected == true)
            {
                MessageBox.Show(i.ToString());
            }
        }
    }
}
