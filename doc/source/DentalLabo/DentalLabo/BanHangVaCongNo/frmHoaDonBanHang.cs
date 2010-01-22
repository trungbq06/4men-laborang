using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DentalLabo.BanHangVaCongNo;
using PrintDataGrid;

namespace DentalLabo.Nhap_kho_va_ban_hang
{
    public partial class frmHoaDonBanHang : Form
    {
        HoaDonBanHang_Model model;

        public frmHoaDonBanHang()
        {
            InitializeComponent();
            model = new HoaDonBanHang_Model(this);
            model.InitLoadTenKH();
        }

        
        public frmHoaDonBanHang(string maHD)
        {
            InitializeComponent();

            model = new HoaDonBanHang_Model(this);
            model.InitLoadTenKH();


            model.UpdateGroupBox(maHD);
            model.UpdateDataGridView(maHD);
            txtSoPhieu.Text = maHD;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!Validation.ChuaNhap(cmbMaKH.Text, "Chưa nhập mã KH"))
                if (!Validation.ChuaNhap(txtSoTienTT.Text, "Chưa nhập số Tiền TT")) {                    
                    long soTien = Int64.Parse(txtSoTienTT.Text);
                    model.ThanhToanTien(cmbMaKH.Text, txtSoTienTT.Text);
                }
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGiamTru form = new frmGiamTru();
            form.MdiParent = this.MdiParent;
            form.Show();

            form.txtSoHoaDon.Text = txtSoPhieu.Text;
            form.model.LietKeTatCaGiamTru(txtSoPhieu.Text);            
        }

        private void cmbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateMaKH();
        }

        private void cmbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateTheoMaKH(cmbMaKH.Text);
        }

        private void btnInPhieuXuat_Click(object sender, EventArgs e)
        {
            ArrayList array = new ArrayList();
            array.Add("Ngày: " + dateNgayXuat.Text);
            array.Add("Số phiếu: " + txtSoPhieu.Text);
            
            array.Add("Tên khách hàng:  " + cmbTenKH.Text);
            array.Add("Mã khách hàng: " + cmbMaKH.Text);
            
            array.Add("Địa chỉ: " + txtDiaChi.Text);
            array.Add("");

            array.Add("Mã số thuế: " + txtMaSoThue.Text);
            array.Add("Người đại diện: " + txtNguoiDaiDien.Text);
            
            

            PrintDGV.Print_DataGridView(dtgHoaDonBanHang, array);
        }
       
    }
}
