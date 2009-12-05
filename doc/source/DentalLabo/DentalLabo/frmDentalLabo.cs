using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DentalLabo.Nhap_kho_va_ban_hang;
using DentalLabo.Vat_tu_hang_hoa_va_Cong_no_NCC;
using DentalLabo.VatTuHangHoa;
using DentalLabo.PMKTTienMat;
using DentalLabo.Quan_ly_san_pham_va_tinh_luong;

namespace DentalLabo
{
    public partial class frmDentalLabo : Form
    {
        public frmDentalLabo()
        {
            InitializeComponent();
        }

        private void ttNhanMauDatHang_Click(object sender, EventArgs e)
        {
            Form f = new frmMauDatHang();
            f.MdiParent = this;
            f.Show();
        }

        private void ttDanhMucSP_Click(object sender, EventArgs e)
        {
            Form f = new frmDanhMucSP();
            f.MdiParent = this;
            f.Show();
        }

        private void ttDanhMucVLChinh_Click(object sender, EventArgs e)
        {
            Form f = new frmDanhMucVLChinh();
            f.MdiParent = this;
            f.Show();
        }

        private void ttDanhMucVLPhu_Click(object sender, EventArgs e)
        {
            Form f = new frmDanhMucVLPhu();
            f.MdiParent = this;
            f.Show();
        }

        private void ttBangGiaSP_Click(object sender, EventArgs e)
        {
            Form f = new frmBangGiaSP();
            f.MdiParent = this;
            f.Show();
        }

        private void ttNhapKhoThanhPham_Click(object sender, EventArgs e)
        {
            Form f = new frmNhapKhoThanhPham();
            f.MdiParent = this;
            f.Show();
        }

        private void ttXuatKhoBanHang_Click(object sender, EventArgs e)
        {
            Form f = new frmXuatKhoBanHang();
            f.MdiParent = this;
            f.Show();
        }

        private void ttHoaDonBanHang_Click(object sender, EventArgs e)
        {
            Form f = new frmHoaDonBanHang();
            f.MdiParent = this;
            f.Show();
        }

        private void ttPhieuTT_Click(object sender, EventArgs e)
        {
            Form f = new frmPhieuTT();
            f.MdiParent = this;
            f.Show();
        }

        private void ttDanhMucNhomKH_Click(object sender, EventArgs e)
        {
            Form f = new frmDanhMucNhomKH();
            f.MdiParent = this;
            f.Show();
        }

        private void ttDanhMucKH_Click(object sender, EventArgs e)
        {
            Form f = new frmDanhMucKH();
            f.MdiParent = this;
            f.Show();
        }

        private void ttNhapKhoVatTu_Click(object sender, EventArgs e)
        {
            Form f = new frmNhapKho();
            f.MdiParent = this;
            f.Show();
        }

        private void ttNhapKhoThietBi_Click(object sender, EventArgs e)
        {
            Form f = new frmNhapKho();
            f.MdiParent = this;
            f.Show();
        }

        private void ttDieuChinhTyGiaTT_Click(object sender, EventArgs e)
        {
            Form f = new frmDieuChinhTyGiaTT();
            f.MdiParent = this;
            f.Show();
        }

        private void ttXuatKhoNVL_Click(object sender, EventArgs e)
        {
            Form f = new frmXuatKho();
            f.MdiParent = this;
            f.Show();
        }

        private void ttXuatKhoThietBi_Click(object sender, EventArgs e)
        {
            Form f = new frmXuatKho();
            f.MdiParent = this;
            f.Show();
        }

        private void ttSoKho_Click(object sender, EventArgs e)
        {
            Form f = new frmSoChiTietHH();
            f.MdiParent = this;
            f.Show();
        }

        private void ttNoNCC_Click(object sender, EventArgs e)
        {
            Form f = new frmNoNCC();
            f.MdiParent = this;
            f.Show();
        }

        private void ttDanhMucKhoHang_Click(object sender, EventArgs e)
        {
            Form f = new frmDanhMucKhoVatTuHH();
            f.MdiParent = this;
            f.Show();
        }

        private void ttDanhMucVatTuHH_Click(object sender, EventArgs e)
        {
            Form f = new frmDanhMucVatTuHH();
            f.MdiParent = this;
            f.Show();
        }

        private void ttDanhMucNCC_Click(object sender, EventArgs e)
        {
            Form f = new frmDanhMucNhaCC();
            f.MdiParent = this;
            f.Show();
        }

        private void ttQLDonViSP_Click(object sender, EventArgs e)
        {
            Form f = new frmQLSP();
            f.MdiParent = this;
            f.Show();
        }

        private void ttTongHopKQCongViec_Click(object sender, EventArgs e)
        {
            Form f = new frmQLSP();
            f.MdiParent = this;
            f.Show();
        }

        private void ttChamCongVaLamThem_Click(object sender, EventArgs e)
        {
            Form f = new frmQLSP();
            f.MdiParent = this;
            f.Show();
        }

        private void ttPhieuThu_Click(object sender, EventArgs e)
        {
            Form f = new frmPhieuThu();
            f.MdiParent = this;
            f.Show();
        }
        

        private void ttTinhLuong_Click(object sender, EventArgs e)
        {
            Form f = new frmQLSP();
            f.MdiParent = this;
            f.Show();
        }

        private void ttTamUngLuong_Click(object sender, EventArgs e)
        {
            Form f = new frmQLSP();
            f.MdiParent = this;
            f.Show();
        }

        private void ttDanhMucBoPhan_Click(object sender, EventArgs e)
        {
            Form f = new frmDanhMucBoPhan();
            f.MdiParent = this;
            f.Show();
        }

        private void ttDanhMucNV_Click(object sender, EventArgs e)
        {
            Form f = new frmDanhMucNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void ttDanhMucCongDoanSX_Click(object sender, EventArgs e)
        {
            Form f = new frmDMCongDoanSX();
            f.MdiParent = this;
            f.Show();
        }

        private void ttGiamTru_Click(object sender, EventArgs e)
        {
            Form f = new frmGiamTru();
            f.MdiParent = this;
            f.Show();
        }

        private void ttPhieuChi_Click(object sender, EventArgs e)
        {
            Form f = new frmPhieuChi();
            f.MdiParent = this;
            f.Show();
        }

        private void ttSoQuy_Click(object sender, EventArgs e)
        {
            Form f = new frmSoQuyTienMat();
            f.MdiParent = this;
            f.Show();
        }



    }
}
