using System;
using System.Collections;
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
        public bool isUpdate = false;

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
       

        private void btnMauMoi_Click(object sender, EventArgs e)
        {
            if (!Validation.ChuaNhap(txtSoPhieu.Text, "Chưa nhập trường mã phiếu"))
                if (!Validation.ChuaNhap(txtMaSoMau.Text, "Chưa nhập mã số mẫu"))
                    if (!Validation.ChuaNhap(dateGioNhap.Text, "Chưa nhập giờ nhập"))
                        if (!Validation.ChuaNhap(dateNgayNhap.Text, "Chưa nhập ngày nhập"))
                        {                            
                            isUpdate = false;
                            FinishUpdateRow();
                            model.ThemMauVaoPhieu();
                            EnableHangDuoi();
                        }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (btnTimKiem.Text == "Tìm kiếm")
            {
                isUpdate = false;
                dtgNoiDungNhapKho.Rows.Clear();
                model.LoadThongTinPhieuNK(true);
                selectedRow = -1;                
            }
            else
            {
                btnTimKiem.Text = "Tìm kiếm";
                txtSoPhieu.Enabled = true;
                txtMaSoMau.Enabled = false;
                DisableHangDuoi();                
            }
        }

        private void btnPhieuNhapMoi_Click(object sender, EventArgs e)
        {
            // Reset Groupbox trên
            txtMaSoMau.Text = "";
            txtDienGiai.Text = "";
            dateGioNhap.Text = "";
            dateNgayNhap.Text = "";
            selectedRow = -1;

            // Sinh mã số phiếu
            isUpdate = false;
            model.SinhMaSoPhieu();

            // Xoa bang
            dtgNoiDungNhapKho.Rows.Clear();

            // không cho nhập mã số phiếu
            txtSoPhieu.Enabled = false;

            // cho nhập mã số mẫu
            txtMaSoMau.Enabled = true;

            // khoa nut tim kiem
            btnTimKiem.Text = "Mở chức năng Tìm kiếm";

            EnableHangDuoi();
                                    
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgNoiDungNhapKho.SelectedRows.Count == 0)
            {
                Database.Warning("Hãy chọn sản phẩm để xóa");
            }
            else
            {
                DataGridViewRow row = dtgNoiDungNhapKho.SelectedRows[0];
                // neu la hang moi them
                if (row.Cells[model.maSPDatHangIndex].Value.ToString() == "")
                {
                    dtgNoiDungNhapKho.Rows.Remove(row);
                    isUpdate = false;
                    selectedRow = -1;
                }
                else
                {
                    Database.Warning("Bạn không thể xóa sản phẩm do khách yêu cầu");
                }                    
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {            
            if (dtgNoiDungNhapKho.SelectedRows.Count == 0)
            {
                Database.Warning("Hãy chọn dòng để sửa");
            }
            else
            {
                isUpdate = true;

                // chi cho sua mot hang, hang dang sua thi chuyen ve trang thai sua xong
                FinishUpdateRow();

                // lay hang dau tien duoc chon
                selectedRow = dtgNoiDungNhapKho.SelectedRows[0].Index;

                DataGridViewRow row = dtgNoiDungNhapKho.SelectedRows[0];                
                model.LoadTenSanPham(row, true);
                model.LoadTenVLC(row, true);                
                model.LoadTenVLP(row, true);
                if (row.Cells[model.maSPDatHangIndex].Value.ToString() != "1")
                    row.Cells[model.trangThaiIndex].Value = "2";

                row.Cells[model.soluongIndex].ReadOnly = false;
                row.Cells[model.soluongVLPIndex].ReadOnly = false;
            }
        }

        public void FinishUpdateRow() {
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
                    //model.UpdateVLC(dtgNoiDungNhapKho.Rows[selectedRow], false);
                }
                if (dtgNoiDungNhapKho.SelectedCells[0].RowIndex == selectedRow &&
                    dtgNoiDungNhapKho.SelectedCells[0].ColumnIndex == model.msMauIndex)
                {
                    model.UpdateLoaiPhucHinh(dtgNoiDungNhapKho.Rows[selectedRow]);
                }
                if (dtgNoiDungNhapKho.SelectedCells[0].RowIndex == selectedRow &&
                    dtgNoiDungNhapKho.SelectedCells[0].ColumnIndex == model.tenVLPIndex)
                {
                    model.UpdateDVTVLP(dtgNoiDungNhapKho.Rows[selectedRow]);
                }
            }  
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {            
            if (dtgNoiDungNhapKho.Rows.Count > 0)
            {
                // Neu co hang dang sua, hoac them, thi bo sua hang do
                if (selectedRow != -1)
                    FinishUpdateRow();

                isUpdate = false;

                // Tao hang moi
                DataGridViewRow row = new DataGridViewRow();
                dtgNoiDungNhapKho.Rows.Add(row);

                // xac dinh selectedRow la hang vua them
                selectedRow = dtgNoiDungNhapKho.Rows.Count - 1;

                row = dtgNoiDungNhapKho.Rows[selectedRow];
                row.ReadOnly = true;

                
                model.LayMasoMauTrongBang(row, false);

                model.LoadTenSanPham(row, false);

                model.LoadTenVLC(row, false);
                //model.UpdateVLC(row, false);
                model.LoadTenVLP(row, false);

                

                // Them cac truong can thiet                    
                row.Cells[model.trangThaiIndex].Value = "1";                    

                row.Cells[model.thutuIndex].Value = (dtgNoiDungNhapKho.Rows.Count - 1).ToString();
                row.Cells[model.gioNhapIndex].Value = dateGioNhap.Text;

                row.Cells[model.soluongVLPIndex] = new DataGridViewTextBoxCell();
                row.Cells[model.soluongVLPIndex].Value = "";
                row.Cells[model.soluongVLPIndex].ReadOnly = false;
                row.Cells[9].ReadOnly = false;

                row.Cells[model.soluongIndex] = new DataGridViewTextBoxCell();
                row.Cells[model.soluongIndex].Value = "";
                row.Cells[model.soluongIndex].ReadOnly = false;


                row.Cells[model.gioNhapIndex].Value = dateGioNhap.Text;
                row.Cells[model.ngayNhapIndex].Value = dateNgayNhap.Text;
                row.Cells[model.maSPDatHangIndex].Value = "";

                model.UpdateDVT(row);
                model.UpdateLoaiPhucHinh(row);
                model.UpdateDVTVLP(row);
            }
            else
            {
                Database.Warning("Chưa có mẫu nào trong phiếu để thêm sản phẩm");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ArrayList list = KiemTraCacHangChuaNhapSoLuong();
            if (list.Count > 0)
            {
                string HangLoi = "";
                for (int i = 0; i < list.Count; i++)
                {
                    if (i > 0)
                        HangLoi += ", ";
                    HangLoi += list[i].ToString();
                }

                if (list.Count > 1)
                    Database.Warning("Các hàng " + HangLoi + " chưa nhập số lượng sản phẩm");
                else
                    Database.Warning("Hàng " + HangLoi + " chưa nhập số lượng sản phẩm");
            }
            else
            {
                ThemVaSuaCacHang();

                if (!Validation.ChuaNhap(cmbMaKho.Text, "Chưa nhập mã kho"))
                    if (!Validation.ChuaNhap(cmbMasoNV.Text, "Chưa nhập mã nhân viên"))
                    {
                        model.QueryThemPhieuNhapKho();
                        ThemCacMauVaoPhieu();

                        dateGioNhap.Text = "";
                        dateNgayNhap.Text = "";
                        txtMaSoMau.Text = "";
                        dtgNoiDungNhapKho.Rows.Clear();
                        Database.Warning("Nhập kho thành công");
                        model.SinhMaSoPhieu();
                    }
            }
        }

        public void ThemVaSuaCacHang()
        {
            foreach (DataGridViewRow Row in dtgNoiDungNhapKho.Rows)
            {
                if (Row.Cells[model.trangThaiIndex].Value.ToString() == "1")
                    model.ThemSPVaoMau(Row);
                else if (Row.Cells[model.trangThaiIndex].Value.ToString() == "2")
                    model.UpdateSPTrongMau(Row);
            }
        }

        public void ThemCacMauVaoPhieu()
        {
            ArrayList listCacMau = new ArrayList();
            foreach (DataGridViewRow Row in dtgNoiDungNhapKho.Rows)
            {
                string maMau = Row.Cells[model.msMauIndex].Value.ToString();
                if (listCacMau.IndexOf(maMau) < 0) 
                {
                    listCacMau.Add(maMau);
                    model.QueryThemVaoBangPhieNK_Mau(txtSoPhieu.Text, maMau, dateNgayNhap.Text, dateGioNhap.Text);
                    model.QueryCapNhatTrangThaiMauNhapKho(maMau);
                }
            }
        }

        public ArrayList KiemTraCacHangChuaNhapSoLuong()
        {
            ArrayList list = new ArrayList();
            foreach (DataGridViewRow Row in dtgNoiDungNhapKho.Rows)
            {
                if ((Row.Cells[model.tenVLCIndex].Value.ToString() != "none" &&
                     Row.Cells[model.soluongIndex].Value.ToString() == "") ||
                    (Row.Cells[model.tenVLPIndex].Value.ToString() != "none" &&
                     Row.Cells[model.soluongVLPIndex].Value.ToString() == ""))
                    list.Add(Row.Index);                   
            }
            return list;
        }

        public void DisableHangDuoi()
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThemSanPham.Enabled = false;
            btnLuu.Enabled = false;
            btnMauMoi.Enabled = false;
        }

        public void EnableHangDuoi()
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThemSanPham.Enabled = true;
            btnLuu.Enabled = true;
            btnMauMoi.Enabled = true;
        }

                
    }
}
