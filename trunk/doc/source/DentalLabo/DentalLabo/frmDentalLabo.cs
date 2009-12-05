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

namespace DentalLabo
{
    public partial class frmDentalLabo : Form
    {
        public frmDentalLabo()
        {
            InitializeComponent();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhậnMẫuĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form maudathang = new frmMauDatHang();
            maudathang.MdiParent = this;
            maudathang.Show();
        }

        private void xuấtKhoBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form danhmucsp = new frmDanhMucSP();
            danhmucsp.MdiParent = this;
            danhmucsp.Show();
        }

        private void danhMụcVLChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form danhmucvlchinh = new frmDanhMucVLChinh();
            danhmucvlchinh.MdiParent = this;
            danhmucvlchinh.Show();
        }

        private void bảngGiáSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form banggiasp = new frmBangGiaSP();
            banggiasp.MdiParent = this;
            banggiasp.Show();
        }

        private void danhMụcVLPhụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form danhmucvlphu = new frmDanhMucVLPhu();
            danhmucvlphu.MdiParent = this;
            danhmucvlphu.Show();
        }

        private void danhMụcNhómKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form danhmucnhomkh = new frmDanhMucNhomKH();
            danhmucnhomkh.MdiParent = this;
            danhmucnhomkh.Show();
        }

        private void danhMụcKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form danhmuckh = new frmDanhMucKH();
            danhmuckh.MdiParent = this;
            danhmuckh.Show();
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

        private void ttGiamTru_Click(object sender, EventArgs e)
        {
            Form f = new frmGiamTru();
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
        





    }
}
