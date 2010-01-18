using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using DentalLabo.Nhap_kho_va_ban_hang;

namespace DentalLabo.BanHangVaCongNo
{
    class NhapKhoThanhPham_Model
    {
        private DentalLabo.Nhap_kho_va_ban_hang.frmNhapKhoThanhPham form;
        public NhapKhoThanhPham_Model(DentalLabo.Nhap_kho_va_ban_hang.frmNhapKhoThanhPham form)
        {
            this.form = form;
        }
        
        #region SinhMaPhieu
        /**
         * Sinh ma so phieu mot cach tu dong, bang cach tang dan
         */
        public void SinhMaSoPhieu()
        {
            String query = "SELECT TOP 1 MaPhieu FROM PhieuNhapKhoSP ORDER BY len(MaPhieu) desc, MaPhieu desc";
            DataTable result = Database.query(query);
            long maPhieu = 0;
            if (result.Rows.Count == 0)
                maPhieu = 1;
            else
                maPhieu = Int64.Parse(result.Rows[0]["MaPhieu"].ToString()) + 1;
            form.txtSoPhieu.Text = maPhieu.ToString();
        }
        #endregion 

        #region TenBoPhan
        /**
         * Load danh sach ten cac bo phan vao cmbTenBoPhan
         */
        public void LoadTenBoPhan()
        {
            BHCNModel.UpdateComboBoxByQuery(form.cmbTenBoPhan, "SELECT TenBP FROM BoPhan", "TenBP");
        }
        
        /**
         * Cap nhat ma so bo phan theo ten bo phan
         */
        public void UpdateMaSoBP(String tenBP)
        {
            String query = "SELECT MaBP FROM BoPhan WHERE TenBP = '" + tenBP + "'";
            BHCNModel.UpdateComboBoxByQuery(form.cmbMasoBP, query, "MaBP");
        }
        #endregion

        #region TenNhanVien
        /**
         * Cap nhat ten nhan vien theo ten bo phan
         */
        public void LoadTenNV(String maBP)
        {
            String query = "SELECT TenNV FROM NhanVien WHERE MaBP = '" + maBP + "'";
            BHCNModel.UpdateComboBoxByQuery(form.cmbTenNhanVien, query, "TenNV");
        }

        /**
         * Cap nhat ma so nhan vien theo ten nhan vien
         */
        public void UpdateMaSoNV(String tenNV)
        {
            String query = "SELECT MaNV FROM NhanVien WHERE TenNV = '" + tenNV + "'";
            BHCNModel.UpdateComboBoxByQuery(form.cmbMasoNV, query, "MaNV");
        }
        #endregion

        #region TenKho
        /**
         * Load Ten Kho
         */
        public void LoadTenKho()
        {
            String query = "SELECT TenKho FROM KhoHang";
            BHCNModel.UpdateComboBoxByQuery(form.cmbTenKho, query, "TenKho");
        }

        /**
         * Cap nhat ma so kho theo ten kho
         */
        public void UpdateMaKho(String tenKho)
        {
            String query = "SELECT MaKho FROM KhoHang WHERE TenKho = '" + tenKho + "'";
            BHCNModel.UpdateComboBoxByQuery(form.cmbMaKho, query, "MaKho");
        }
        #endregion

        #region Them Phieu Nhap Kho
        public void ThemPhieuNhapKho() {
            bool isValidate = true;
            if (form.txtSoPhieu.Text == "") 
            {
                MessageBox.Show(null, "Chưa nhập trường số phiếu", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValidate = false;
            }
            else if (form.dateNgayNhap.Text == "") 
            {
                MessageBox.Show(null, "Chưa nhập trường ngày nhập", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValidate = false;
            }
            else if (form.dateGioNhap.Text == "")
            {
                MessageBox.Show(null, "Chưa nhập trường giờ nhập", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValidate = false;
            }
            else if (form.cmbMaKho.Text == "")
            {
                MessageBox.Show(null, "Chưa nhập trường mã kho", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValidate = false;
            }
            else if (form.cmbMasoNV.Text == "")
            {
                MessageBox.Show(null, "Chưa nhập trường mã nhân viên", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValidate = false;
            }
            else
            {
                String query = "INSERT PhieuNhapKhoSP VALUES(" +
                                "'" + form.txtSoPhieu.Text + "', " +
                                "'" + form.dateNgayNhap.Text + "', " +
                                "'" + form.dateGioNhap.Text + "', " +
                                "'" + form.cmbMaKho.Text + "', " +
                                "'" + form.cmbMasoNV.Text + "', " +
                                "'" + form.txtDienGiai.Text + "'" +
                                ")";
                try
                {
                    Database.query(query);
                }
                catch (DataException e)
                {
                    MessageBox.Show(null, "Mã số phiếu bị trùng, hãy tăng mã số phiếu lên một", "Loi trung ma so phieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion


        #region Them Mau Vao Phieu
        public void ThemMauVaoPhieu() {
            if (form.txtSoPhieu.Text == "") 
            {
                MessageBox.Show(null, "Chưa nhập trường mã phiếu", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (form.txtMaSoMau.Text == "") 
            {
                MessageBox.Show(null, "Chưa nhập trường mã số mẫu", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                String query = "INSERT PhieuNhapKhoSP_MauHang VALUES(" +
                                "'" + form.txtSoPhieu.Text + "', " +
                                "'" + form.txtMaSoMau.Text + "' " + 
                                ")";
                try 
                {
                    Database.query(query);
                }
                catch (DataException e) {
                    MessageBox.Show(null, "Mẫu đã có trong phiếu rồi", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);                        
                }
            }
        }        
        #endregion

        #region Load thong tin ve phieu nhap kho thanh pham
        public void LoadThongTinPhieuNK(String maPhieu){
            
        }

        public void LayThongTinMau(String maMau, bool isUpdate, int beginRow, string NgayNhap, string GioNhap) {            
            String query = "SELECT LoaiPhucHinh FROM MauHang WHERE MaMau = '" + maMau + "'";
            DataTable result = Database.query(query);
            if (result.Rows.Count == 0)
            {
                MessageBox.Show(null, "Không có mẫu " + maMau + " trong cơ sở dữ liệu", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String loaiPhucHinh = result.Rows[0]["LoaiPhucHinh"].ToString();
                query = "SELECT MauSPDatHang FROM MauHang_SanPhamDatHang WHERE MaMau = '" + maMau + "'";
                result = Database.query(query);
                int count = 0;
                if (result.Rows.Count > 0)
                {
                    object[] a = new object[11];
                    a[0] = false;
                    a[1] = count.ToString();
                    a[2] = maMau;
                    a[3] = loaiPhucHinh;

                    int countRows = 0;
                    foreach (DataRow row in result.Rows)
                    {
                        if (countRows > 0) {
                            a[0] = false;
                            a[1] = count.ToString();
                            a[2] = "";
                            a[3] = "";
                        }
                        String maSPDatHang = row["MaSPDatHang"].ToString();
                        query = "SELECT MaSP, MaVLC, MaVLP, SoLuong FROM SanPhamDatHang WHERE MaSPDatHang = '" + maSPDatHang+ " '";
                        DataTable spDatHang = Database.query(query);

                        // Lay Ten SP, DVT
                        string maSP = spDatHang.Rows[0]["MaSP"].ToString();
                        query = "SELECT TenSP, DVT FROM SanPham WHERE MaSP = '" + maSP + "'";
                        DataTable sanpham = Database.query(query);
                        string tenSP = sanpham.Rows[0]["TenSP"].ToString();
                        string dvt = sanpham.Rows[0]["DVT"].ToString();

                        // Lay so luong
                        string soluong = spDatHang.Rows[0]["SoLuong"].ToString();

                        // Lay vat lieu chinh
                        string maVLC = spDatHang.Rows[0]["MaVLC"].ToString();
                        query = "SELECT TenVL FROM VatLieuChinh WHERE MaVL = '" + maVLC + "'";
                        DataTable vlc = Database.query(query);
                        string tenVLC = vlc.Rows[0]["TenVL"].ToString();

                        // Lay vat lieu phu
                        string maVLP = spDatHang.Rows[0]["MaVLP"].ToString();
                        query = "SELECT TenVL FROM VatLieuPhu WHERE MaVL = '" + maVLC + "'";
                        DataTable vlp = Database.query(query);
                        string tenVLP = vlc.Rows[0]["TenVL"].ToString();

                        // Gan cac truong tenSP, dvt, soluong, vlc, vlp
                        a[4] = tenSP;
                        a[5] = dvt;
                        a[6] = soluong;
                        a[7] = vlc;
                        a[8] = vlp;

                        if (isUpdate)
                        {
                            a[9] = form.dateGioNhap.Text;
                            a[10] = form.dateNgayNhap.Text;
                        }
                        else {
                            a[9] = NgayNhap;
                            a[10] = GioNhap;
                        }

                        form.dtgNoiDungNhapKho.Rows.Add(a);                        
                    }
                }
            }

        }
        #endregion
    }
}
