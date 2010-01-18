using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DentalLabo.BanHangVaCongNo;

namespace DentalLabo.Nhap_kho_va_ban_hang
{
    public partial class frmNhapKhoThanhPham : Form
    {
        NhapKhoThanhPham_Model model;
        public frmNhapKhoThanhPham()
        {            
            InitializeComponent();
            model = new NhapKhoThanhPham_Model(this);
            model.LoadTenBoPhan();
            model.SinhMaSoPhieu();
            model.LoadTenKho();
        }

        private void cmbTenBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateMaSoBP(cmbTenBoPhan.Items[cmbTenBoPhan.SelectedIndex].ToString());
            String maBP = cmbMasoBP.Text;
            model.LoadTenNV(maBP);
        }

        private void cmbTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tenNV = cmbTenNhanVien.Text;
            model.UpdateMaSoNV(tenNV);
        }

        private void cmbTenKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tenKho = cmbTenKho.Text;
            model.UpdateMaKho(tenKho);
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            model.ThemPhieuNhapKho();
        }

        private void btnMauMoi_Click(object sender, EventArgs e)
        {
            object[] a = new object[12];
            a[0] = false;
            a[1] = "kiennt";
            dtgNoiDungNhapKho.Rows.Add(a);
            dtgNoiDungNhapKho.Rows.Add(a);
        }
        

        
    }
}
