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
        int selectedRow = -1;

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
            model.FindMaSPDatHang();
            selectedRow = -1;
            model.ThemPhieuNhapKho();
        }

        private void btnMauMoi_Click(object sender, EventArgs e)
        {
            FinishUpdateRow();
            model.ThemMauVaoPhieu();            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgNoiDungNhapKho.Rows.Clear();
            model.LoadThongTinPhieuNK(true);
            selectedRow = -1;
        }

        private void btnPhieuNhapMoi_Click(object sender, EventArgs e)
        {
            model.SinhMaSoPhieu();
            dtgNoiDungNhapKho.Rows.Clear();
            txtMaSoMau.Text = "";
            txtDienGiai.Text = "";
            selectedRow = -1;
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtSoPhieu.Text == "") 
            {
                MessageBox.Show(null, "Chưa nhập mã số phiếu", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtgNoiDungNhapKho.SelectedRows.Count == 0)
            {
                MessageBox.Show(null, "Hãy chọn dòng để xóa", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
            else
            {
                FinishUpdateRow();
                selectedRow = -1;
                String filter = "(";
                for (int i = 0; i < dtgNoiDungNhapKho.SelectedRows.Count; i++)
                {
                    if (i > 0)
                        filter += ", ";
                    filter += "'" + dtgNoiDungNhapKho.SelectedRows[i].Cells[1].Value + "'";
                }
                filter += " )";

                String query = "DELETE FROM PhieuNhapKhoSP_MauHang where MaPhieu = '" + txtSoPhieu.Text + "' and MaMau in " + filter;
                Database.query(query);
                dtgNoiDungNhapKho.Rows.Clear();
                model.LoadThongTinPhieuNK(false);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedRow != -1)
            {
                MessageBox.Show(null, "Bạn đang sửa một sản phẩm rồi, hãy lưu sản phẩm đó trước khi sửa sản phẩm tiếp theo", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtSoPhieu.Text == "")
            {
                MessageBox.Show(null, "Chưa nhập mã số phiếu", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtgNoiDungNhapKho.SelectedRows.Count == 0)
            {
                MessageBox.Show(null, "Hãy chọn dòng để sửa", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {                
                selectedRow = dtgNoiDungNhapKho.SelectedRows[0].Index;
                DataGridViewRow row = dtgNoiDungNhapKho.SelectedRows[0];                
                model.LoadTenSanPham(row, true);
                model.LoadTenVLC(row, true);
                model.LoadTenVLP(row, true);

                row.Cells[model.soluongIndex].ReadOnly = false;
            }
        }

        private void FinishUpdateRow() {
            if (selectedRow != -1)
            {
                DataGridViewRow row = dtgNoiDungNhapKho.Rows[selectedRow];
                string masoMau = row.Cells[model.msMauIndex].Value.ToString();
                row.Cells[model.msMauIndex] = new DataGridViewTextBoxCell();
                row.Cells[model.msMauIndex].Value = masoMau;

                string tenSP = row.Cells[model.tenSPIndex].Value.ToString();
                row.Cells[model.tenSPIndex] = new DataGridViewTextBoxCell();
                row.Cells[model.tenSPIndex].Value = tenSP;

                string tenVLC = row.Cells[model.tenVLCIndex].Value.ToString();
                row.Cells[model.tenVLCIndex] = new DataGridViewTextBoxCell();
                row.Cells[model.tenVLCIndex].Value = tenVLC;

                string tenVLP = row.Cells[model.tenVLPIndex].Value.ToString();
                row.Cells[model.tenVLPIndex] = new DataGridViewTextBoxCell();
                row.Cells[model.tenVLPIndex].Value = tenVLP;

                selectedRow = -1;
            }
        }

        private void dtgNoiDungNhapKho_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedRow != -1)
            {
                if (dtgNoiDungNhapKho.SelectedCells[0].RowIndex == selectedRow &&
                    dtgNoiDungNhapKho.SelectedCells[0].ColumnIndex == model.tenSPIndex)
                {
                    model.UpdateDVT(dtgNoiDungNhapKho.Rows[selectedRow]);
                }
                if (dtgNoiDungNhapKho.SelectedCells[0].RowIndex == selectedRow &&
                    dtgNoiDungNhapKho.SelectedCells[0].ColumnIndex == model.msMauIndex)
                {
                    model.UpdateLoaiPhucHinh(dtgNoiDungNhapKho.Rows[selectedRow]);
                }
            }  
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (dtgNoiDungNhapKho.Rows.Count > 0)
            {
                // Ket thuc sua hang
                FinishUpdateRow();

                // Tao hang moi
                DataGridViewRow row = new DataGridViewRow();
                dtgNoiDungNhapKho.Rows.Add(row);                
                row = dtgNoiDungNhapKho.Rows[dtgNoiDungNhapKho.Rows.Count - 1];
                row.ReadOnly = true;
                model.LayMasoMauTrongBang(row, false);
                model.LoadTenSanPham(row, false);
                model.LoadTenVLC(row, false);
                model.LoadTenVLP(row, false);

                // Them cac truong can thiet
                row.Cells[model.soluongIndex].ReadOnly = false;
                row.Cells[0].Value = (dtgNoiDungNhapKho.Rows.Count - 1).ToString();                
                row.Cells[8].Value = dateGioNhap.Text;

                row.Cells[5] = new DataGridViewTextBoxCell();
                row.Cells[5].Value = "";

                row.Cells[9].Value = dateNgayNhap.Text;
                row.Cells[10].Value = model.FindMaSPDatHang();
                selectedRow = dtgNoiDungNhapKho.Rows.Count - 1;
                
                model.UpdateDVT(row);
                model.UpdateLoaiPhucHinh(row);
            }
            else 
            {
                MessageBox.Show(null, "Chưa có mẫu nào trong phiếu để thêm sản phẩm", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgNoiDungNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (selectedRow == -1)
            {
                MessageBox.Show(null, "Không có hàng nào để lưu", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                model.SaveSeletedRow(dtgNoiDungNhapKho.Rows[selectedRow], false);
                FinishUpdateRow();
            }
        }
                
    }
}
