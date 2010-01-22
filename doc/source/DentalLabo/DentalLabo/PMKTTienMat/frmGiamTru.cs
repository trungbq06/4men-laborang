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
    public partial class frmGiamTru : Form
    {
        public GiamTru_Model model;
        
        public frmGiamTru()
        {
            InitializeComponent();
            model = new GiamTru_Model(this);
            model.InitLoadTenKH();            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgChiTietCongNoKH.Rows.Clear();
            model.TimTheoMaKhachHang(cmbMaKH.Text, dateNgayBatDau.Text, dateNgayKetThuc.Text);                
        }

        private void cmbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateMaKH();
        }

        private void cmbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateTheoMaKH(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validation.ChuaNhap(txtSoHoaDon.Text, "Chưa nhập số hóa đơn"))
            {
                if (!BHCNModel.KiemTraMaHD(txtSoHoaDon.Text))
                {
                    dtgChiTietCongNoKH.Rows.Clear();
                    model.LietKeTatCaGiamTru(txtSoHoaDon.Text);
                }
                else
                {
                    Database.Warning("Hóa đơn không có trong CSDL");
                }
            }
        }
       
        private void btnLuuHeThong_Click(object sender, EventArgs e)
        {
            object[] cells = new object[9];
            for (int i = 0; i < 9; i++)
                cells[i] = "";            

            cells[GiamTru_Model.ttIndex] = dtgChiTietCongNoKH.Rows.Count;            

            dtgChiTietCongNoKH.Rows.Add(cells);

            DataGridViewRow addedRow = dtgChiTietCongNoKH.Rows[dtgChiTietCongNoKH.Rows.Count - 1];
            for (int i = 0; i < 9; i++)
                addedRow.Cells[i].ReadOnly = false;
            addedRow.Cells[GiamTru_Model.msIndex].ReadOnly = true;
            addedRow.Cells[GiamTru_Model.trangThaiIndex].ReadOnly = true;                
        }

        private void dtgChiTietCongNoKH_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {            
            if ( (e.ColumnIndex == GiamTru_Model.donGiaIndex ||
                  e.ColumnIndex == GiamTru_Model.soLuongIndex) &&
                  e.RowIndex >= 0)  
            {
                try
                {                    
                    DataGridViewRow row = dtgChiTietCongNoKH.Rows[e.RowIndex];
                    if (row != null)
                    {
                        string dvt = row.Cells[GiamTru_Model.dvtIndex].Value.ToString();
                        string dongia = row.Cells[GiamTru_Model.donGiaIndex].Value.ToString();
                        string soluong = row.Cells[GiamTru_Model.soLuongIndex].Value.ToString();

                        long dg, sl;
                        dg = Int64.Parse(dongia);
                        sl = Int64.Parse(soluong);
                        if (dvt != "%")
                            row.Cells[GiamTru_Model.thanhTienIndex].Value = (dg * sl).ToString();
                        else
                            row.Cells[GiamTru_Model.thanhTienIndex].Value = ((int)(dg * (double)sl / 100)).ToString();
                    }
                }
                catch
                {

                }
            }
        }

        private void btnVaoPhieu_Click(object sender, EventArgs e)
        {
            if (dtgChiTietCongNoKH.SelectedRows.Count > 0)
            {
                if (!Validation.ChuaNhap(txtSoHoaDon.Text, "Chưa nhập số hóa đơn"))
                    model.ThemNoiDungGiamTru(txtSoHoaDon.Text);
            }
            else
            {
                Database.Warning("Hãy chọn hàng để thêm nội dung giảm trừ");
            }

        }

        private void dtgChiTietCongNoKH_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.Row.Cells[GiamTru_Model.trangThaiIndex].Value.ToString() == "Đã áp dụng")
            {
                e.Row.Selected = false;
            }
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            if (!Validation.ChuaNhap(txtSoHoaDon.Text, "Chưa nhập số hóa đơn"))
            {
                frmHoaDonBanHang form = new frmHoaDonBanHang(txtSoHoaDon.Text);
                form.MdiParent = this.MdiParent;
                form.Show();
            }
        }


        
    }
}
