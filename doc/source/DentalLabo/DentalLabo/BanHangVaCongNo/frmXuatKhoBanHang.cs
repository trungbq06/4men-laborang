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
    public partial class frmXuatKhoBanHang : Form
    {
        XuatKhoBanHang_Model model;        
        public frmXuatKhoBanHang()
        {
            InitializeComponent();
            model = new XuatKhoBanHang_Model(this);            
            model.InitLoadTenKH();
            model.SinhMaHoaDonBH();
        }

        private void cmbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateMaKH();
        }

        private void cmbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateTheoMaKH(false);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!Validation.ChuaNhap(txtSoPhieu.Text, "Chưa nhập số phiếu"))
            {
                dtgNoiDungXuatKho.Rows.Clear();
                model.TimTheoSoPhieu();                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validation.ChuaNhap(cmbMaKH.Text, "Chưa nhập mã khách hàng"))
            {
                dtgNoiDungXuatKho.Rows.Clear();
                model.TimTheoMaKH(cmbMaKH.Text);
            }
        }

        private void dtgNoiDungXuatKho_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.Row.Cells[XuatKhoBanHang_Model.msMauIndex].Value.ToString() == "")
                e.Row.Selected = false;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            model.SinhMaHoaDonBH();
            model.InitLoadTenKH();            
            dtgNoiDungXuatKho.Rows.Clear();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (!Validation.ChuaNhap(txtSoPhieu.Text, "Chưa nhập số phiếu"))
                if (!Validation.ChuaNhap(cmbMaKH.Text, "Chưa nhập mã khách hàng"))
                    if (!Validation.ChuaNhap(txtMaNhanVien.Text, "Chưa nhập mã nhân viên"))
                    {
                        if (dtgNoiDungXuatKho.SelectedRows.Count <= 0)
                            Database.Warning("Bạn hãy chọn mẫu hóa đơn để thêm vào phiếu");
                        else if (!model.KiemTraNhanVien(txtMaNhanVien.Text))
                        {
                            Database.Warning("Mã nhân viên không hợp lệ");
                        }
                        else if (!BHCNModel.KiemTraMaHD(txtSoPhieu.Text))
                        {
                            Database.Warning("Số phiếu đã có trong CSDL, hãy thay số phiếu khác, hoặc ấn váo nút Phiếu mới để tự sinh mã phiếu.");
                        }
                        else
                        {
                            model.XuatHoaDon(txtSoPhieu.Text);
                            Database.Warning("Xuất hóa đơn thành công. Ấn vào 'Xem Phiếu Xuất - hóa đơn' để xem hóa đơn.");
                        }
                    }
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (!Validation.ChuaNhap(txtSoPhieu.Text, "Chưa nhập số phiếu"))
            {
                if (!BHCNModel.KiemTraMaHD(txtSoPhieu.Text))
                {
                    frmHoaDonBanHang form = new frmHoaDonBanHang(txtSoPhieu.Text);
                    form.MdiParent = this.MdiParent;
                    form.Show();
                }
                else
                {
                    Database.Warning("Không có hóa đơn số " + txtSoPhieu.Text + " trong CSDL");
                }
            }

        }
        
    }
}
