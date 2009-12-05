using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            Form banggiasp = new frmDanhMucSP();
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
    }
}
