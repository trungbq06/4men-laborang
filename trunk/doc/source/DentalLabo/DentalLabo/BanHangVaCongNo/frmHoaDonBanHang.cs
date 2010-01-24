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
                if (!Validation.ChuaNhap(txtNoiDungGT.Text, "Chưa nhập số Tiền TT")) {
                    model.ThanhToanTien(cmbMaKH.Text, model.TongTien.ToString());
                }
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validation.ChuaNhap(txtNoiDungGT.Text, "Chưa nhập tên nội dung giảm trừ"))
            {
                if (!Validation.ChuaNhap(txtSoTienGT.Text, "Chưa nhập số tiền giảm trừ"))
                {                    
                    try
                    {
                        long soTien = Int64.Parse(txtSoTienGT.Text);

                        if (soTien > model.TongTien)
                        {
                            Database.Warning("Bạn không thể cho thêm giảm trừ có số tiền lớn hơn hóa đơn");
                        }
                        else
                        {
                            BHCNModel.ThemNoiDungGiamTru(txtSoPhieu.Text, txtNoiDungGT.Text, txtSoTienGT.Text);
                            dtgHoaDonBanHang.Rows.Clear();
                            model.UpdateDataGridView(txtSoPhieu.Text);
                        }
                    }
                    catch (FormatException fe)
                    {
                        Database.Warning("Số tiền giảm trừ không đúng định dạng");
                    }
                }
            }
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
