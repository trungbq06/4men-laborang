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
        public int thutuIndex = 0;
        public int msMauIndex = 1;
        public int loaiPhucHinhIndex = 2;
        public int tenSPIndex = 3;
        public int tenVLCIndex = 4;
        public int dvtIndex = 5;
        public int soluongIndex = 6;
        public int tenVLPIndex = 7;
        public int dvtVLPIndex = 8;
        public int soluongVLPIndex = 9;
        public int gioNhapIndex = 10;
        public int ngayNhapIndex = 11;
        public int maSPDatHangIndex = 12;



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
            if (form.cmbTenNhanVien.Items.Count == 0)
            {
                form.cmbMasoNV.Items.Clear();
                form.cmbMasoNV.Text = "";
            }
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
                                "N'" + form.txtDienGiai.Text + "'" +
                                ")";
                try
                {
                    Database.query(query);
                    MessageBox.Show(null, "Thêm phiếu thành công", "Them phieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception e)
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
            else if (form.dateNgayNhap.Text == "")
            {
                MessageBox.Show(null, "Chưa nhập trường ngày nhập", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
            else if (form.dateGioNhap.Text == "")
            {
                MessageBox.Show(null, "Chưa nhập trường giờ nhập", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
            else 
            {
                // Cap nhat trang thai mau la da hoan thanh
                String query = "UPDATE MauHang SET TrangThai = 1 WHERE MaMau = '" + form.txtMaSoMau.Text + "'";
                Database.query(query);

                // Them Mau vao Phieu
                query = "INSERT PhieuNhapKhoSP_MauHang VALUES(" +
                                "'" + form.txtSoPhieu.Text + "', " +
                                "'" + form.txtMaSoMau.Text + "', " +
                                "'" + form.dateNgayNhap.Text + "', " +
                                "'" + form.dateGioNhap.Text + "' " + 
                                ")";
                try 
                {
                    Database.query(query);
                    LayThongTinMau(form.txtMaSoMau.Text, true, "", "");
                }
                catch (Exception e) {
                    MessageBox.Show(null, "Mẫu đã có trong phiếu rồi hoặc là mẫu không tồn tại", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);                        
                }
            }
        }        
        #endregion

        #region Load thong tin ve phieu nhap kho thanh pham
        public void LoadThongTinPhieuNK(bool isSearch){
            if (form.txtSoPhieu.Text == "")
            {
                MessageBox.Show(null, "Chưa nhập số phiếu", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                // kiem tra xem da co Phieu trong CSDL chua?
                String query = "SELECT * FROM PhieuNhapKhoSP WHERE MaPhieu = '" + form.txtSoPhieu.Text + "'";
                DataTable result = Database.query(query);
                if (result.Rows.Count == 0)
                {
                    MessageBox.Show(null, "Không có phiếu " + form.txtSoPhieu.Text + " trong CSDL", "Thong Tin Phieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                // Lay ma kho
                string maKho = result.Rows[0]["MaKho"].ToString();
                form.cmbMaKho.Text = maKho;

                // Lay ten kho
                query = "SELECT TenKho FROM KhoHang WHERE MaKho = '" + maKho +"'";
                DataTable result1 = Database.query(query);
                form.cmbTenKho.Text = result1.Rows[0]["TenKho"].ToString();

                // Lay ma nhan vien 
                string maNV = result.Rows[0]["MaNV"].ToString();
                form.cmbMasoNV.Text = maNV;

                // Lay ten nhan vien
                query = "SELECT TenNV, MaBP FROM NhanVien WHERE MaNV = '" + maNV + "'";
                DataTable result2 = Database.query(query);
                form.cmbTenNhanVien.Text = result2.Rows[0]["TenNV"].ToString();

                // Lay ma bo phan
                string maBP = result2.Rows[0]["MaBP"].ToString();
                form.cmbMasoBP.Text = maBP;

                // Lay Ten BP
                query = "SELECT TenBP FROM BoPhan WHERE MaBP = '" + maBP + "'";
                DataTable result3 = Database.query(query);
                form.cmbTenBoPhan.Text = result3.Rows[0]["TenBP"].ToString();


                query = "SELECT MaMau, NgayNhap, GioNhap FROM PhieuNhapKhoSP_MauHang WHERE MaPhieu = '" + form.txtSoPhieu.Text + "'";
                DataTable phieu = Database.query(query);
                if (phieu.Rows.Count > 0)
                {
                    foreach (DataRow row in phieu.Rows)
                    {
                        string maMau = row["MaMau"].ToString();
                        string ngayNhap = row["NgayNhap"].ToString();
                        string gioNhap = row["GioNhap"].ToString();
                        LayThongTinMau(maMau, false, ngayNhap, gioNhap);
                    }
                }
                else if (isSearch) {
                    MessageBox.Show(null, "Phiếu chưa có bất cứ mẫu nào", "Thong Tin Phieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);                                    
                }
            }
        }
        #endregion

        #region LayThongTin mot mau
        public void LayThongTinMau(String maMau, bool isUpdate, string NgayNhap, string GioNhap) {            
            String query = "SELECT LoaiPhucHinh FROM MauHang WHERE MaMau = '" + maMau + "'";
            DataTable result = Database.query(query);
            if (result.Rows.Count == 0)
            {
                MessageBox.Show(null, "Không có mẫu " + maMau + " trong cơ sở dữ liệu", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String loaiPhucHinh = result.Rows[0]["LoaiPhucHinh"].ToString();
                query = "SELECT MaSPDatHang FROM MauHang_SanPhamDatHang WHERE MaMau = '" + maMau + "'";
                result = Database.query(query);
                if (result.Rows.Count > 0)
                {
                    object[] a = new object[13];
                    a[thutuIndex] = form.dtgNoiDungNhapKho.Rows.Count;

                    // Nhung text co dinh
                    a[msMauIndex] = maMau;
                    a[loaiPhucHinhIndex] = loaiPhucHinh;


                    int countRows = 0;
                    foreach (DataRow row in result.Rows)
                    {
                        String maSPDatHang = row["MaSPDatHang"].ToString();
                        a[maSPDatHangIndex] = maSPDatHang;

                        if (countRows > 0)
                        {
                            a[thutuIndex] = form.dtgNoiDungNhapKho.Rows.Count;
                            //a[1] = maMau;
                            //a[2] = loaiPhucHinh;
                        }
                        else
                            countRows += 1;


                        query = "SELECT MaSP, MaVLC, MaVLP, SoLuongVLC, SoLuongVLP FROM SanPhamDatHang WHERE MaSPDatHang = '" + maSPDatHang + " '";
                        DataTable spDatHang = Database.query(query);

                        // Lay Ten SP, DVT
                        string maSP = spDatHang.Rows[0]["MaSP"].ToString();
                        query = "SELECT TenSP, DVT FROM SanPham WHERE MaSP = '" + maSP + "'";
                        DataTable sanpham = Database.query(query);
                        string tenSP = sanpham.Rows[0]["TenSP"].ToString();
                        string dvt = sanpham.Rows[0]["DVT"].ToString();

                        // Lay so luong
                        string soLuongVLC = spDatHang.Rows[0]["SoLuongVLC"].ToString();
                        string soLuongVLP = spDatHang.Rows[0]["SoLuongVLP"].ToString();


                        // Lay vat lieu chinh                        
                        string maVLC = spDatHang.Rows[0]["MaVLC"].ToString();
                        query = "SELECT TenVL FROM VatLieuChinh WHERE MaVL = '" + maVLC + "'";
                        DataTable vlc = Database.query(query);
                        string tenVLC = vlc.Rows[0]["TenVL"].ToString();

                        // Lay vat lieu phu
                        string maVLP = spDatHang.Rows[0]["MaVLP"].ToString();
                        query = "SELECT TenVL, DVT FROM VatLieuPhu WHERE MaVL = '" + maVLP + "'";
                        DataTable vlp = Database.query(query);
                        string tenVLP = "";
                        string dvtVLP = "";
                        if (vlp.Rows.Count > 0)
                        {
                            tenVLP = vlp.Rows[0]["TenVL"].ToString();
                            dvtVLP = vlp.Rows[0]["DVT"].ToString();
                        }

                        // Gan cac truong tenSP, dvt, soluong, vlc, vlp
                        a[tenSPIndex] = tenSP;
                        a[dvtIndex] = dvt;
                        a[soluongIndex] = soLuongVLC;
                        a[tenVLCIndex] = tenVLC;

                        a[tenVLPIndex] = tenVLP;
                        a[soluongVLPIndex] = soLuongVLP;
                        a[dvtVLPIndex] = dvtVLP;

                        if (isUpdate)
                        {
                            a[gioNhapIndex] = form.dateGioNhap.Text;
                            string[] ngay = form.dateNgayNhap.Text.Split('/');
                            a[ngayNhapIndex] = ngay[1] + "/" + ngay[0] + "/" + ngay[2];
                        }
                        else
                        {
                            a[gioNhapIndex] = GioNhap;
                            int pos = NgayNhap.IndexOf(' ');
                            if (pos > 0)
                                NgayNhap = NgayNhap.Substring(0, pos);
                            string[] ngay = NgayNhap.Split('/');
                            a[ngayNhapIndex] = ngay[1] + "/" + ngay[0] + "/" + ngay[2];
                        }

                        form.dtgNoiDungNhapKho.Rows.Add(a);
                        int currentIndex = form.dtgNoiDungNhapKho.Rows.Count - 1;
                        DataGridViewRow currentRow = form.dtgNoiDungNhapKho.Rows[currentIndex];
                        for (int i = 0; i < 11; i++)
                            currentRow.Cells[i].ReadOnly = true;
                    }
                }
                else 
                {
                    MessageBox.Show(null, "Mẫu " + maMau + " không bao gồm bất cứ sản phẩm nào", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region Sua va Edit        

        public void LayMasoMauTrongBang(DataGridViewRow row, bool isUpdate) {
            
            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
            
            for (int i = 0; i < form.dtgNoiDungNhapKho.Rows.Count - 1; i++) {
                string msMau = form.dtgNoiDungNhapKho.Rows[i].Cells[1].Value.ToString();
                if (cell.Items.IndexOf(msMau) < 0)
                {
                    cell.Items.Add(msMau);
                }
            }
            if (isUpdate)
                cell.Value = row.Cells[msMauIndex].Value;
            else
                cell.Value = cell.Items[0];

            row.Cells[msMauIndex] = cell;
            row.Cells[msMauIndex].ReadOnly = false;
        }


        public void LoadTenSanPham(DataGridViewRow row, bool isUpdate) {
            
            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();

            String query = "SELECT TenSP FROM SanPham";
            DataTable table = Database.query(query);
            for (int i = 0; i < table.Rows.Count; i++) { 
                cell.Items.Add(table.Rows[i]["TenSP"]);
            }
            if (isUpdate)
                cell.Value = row.Cells[tenSPIndex].Value;
            else
                cell.Value = cell.Items[0];

            row.Cells[tenSPIndex] = cell;
            row.Cells[tenSPIndex].ReadOnly = false;
        }

        public void LoadTenVLC(DataGridViewRow row, bool isUpdate)
        {
            
            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();

            String query = "SELECT TenVL FROM VatLieuChinh";
            DataTable table = Database.query(query);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cell.Items.Add(table.Rows[i]["TenVL"]);
            }
            if (isUpdate)
                cell.Value = row.Cells[tenVLCIndex].Value;
            else
                cell.Value = cell.Items[0];

            row.Cells[tenVLCIndex] = cell;
            row.Cells[tenVLCIndex].ReadOnly = false;
        }

        public void LoadTenVLP(DataGridViewRow row, bool isUpdate)
        {
            
            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();

            String query = "SELECT TenVL FROM VatLieuPhu";
            DataTable table = Database.query(query);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cell.Items.Add(table.Rows[i]["TenVL"]);
            }
            if (isUpdate)
                cell.Value = row.Cells[tenVLPIndex].Value;
            else
                cell.Value = cell.Items[0];

            cell.Items.Add("none");
            row.Cells[tenVLPIndex] = cell;
            row.Cells[tenVLPIndex].ReadOnly = false;
        }

        public void UpdateDVT(DataGridViewRow row) 
        {            
            String query = "SELECT DVT FROM SanPham where TenSP = '" + row.Cells[tenSPIndex].Value + "'";
            DataTable table = Database.query(query);
            row.Cells[dvtIndex].Value = table.Rows[0]["DVT"];
        }


        public void UpdateDVTVLP(DataGridViewRow row)
        {
            String query = "SELECT DVT FROM VatLieuPhu where TenVL = '" + row.Cells[tenVLPIndex].Value + "'";
            DataTable table = Database.query(query);
            if (table.Rows.Count > 0)
                row.Cells[dvtVLPIndex].Value = table.Rows[0]["DVT"];
            else
                row.Cells[dvtVLPIndex].Value = "";
        }


        public void UpdateLoaiPhucHinh(DataGridViewRow row)
        {
            String query = "SELECT LoaiPhucHinh FROM MauHang where MaMau = '" + row.Cells[msMauIndex].Value + "'";
            DataTable table = Database.query(query);
            row.Cells[loaiPhucHinhIndex].Value = table.Rows[0]["LoaiPhucHinh"];
        }

        public String FindMaSPDatHang() {
            string prefix = "SPDH";
            String query = "SELECT top 1 MaSPDatHang FROM SanPhamDatHang order by len(MaSPDatHang) desc, MaSPDatHang desc";
            DataTable result = Database.query(query);
            long MaSPDatHang = 0;
            if (result.Rows.Count > 0)
            {                
                MaSPDatHang = Int64.Parse(result.Rows[0]["MaSPDatHang"].ToString().Substring(prefix.Length)) + 1;
            }            
            return prefix + MaSPDatHang.ToString();           
        }


        public void SaveSeletedRow(DataGridViewRow row, bool isUpdate)         
        {            
            //----------------------------------------------------------------------
            // Validate
            if (row.Cells[msMauIndex].Value.ToString() == "" ) {
                MessageBox.Show(null, "Chưa nhập mã số mẫu", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (row.Cells[tenSPIndex].Value.ToString() == "")
            {
                MessageBox.Show(null, "Chưa nhập tên sản phẩm", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
            }            
            else if (row.Cells[soluongIndex].Value.ToString() == "")
            {
                MessageBox.Show(null, "Chưa nhập số lượng sản phẩm", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (row.Cells[soluongVLPIndex].Value.ToString() == "" && row.Cells[tenVLPIndex].Value.ToString() != "none")
            {
                MessageBox.Show(null, "Chưa nhập số lượng vật liệu phụ", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //----------------------------------------------------------------------
            // Query
            else 
            {    
                // Lay ma san pham
                String query = "SELECT top 1 MaSP FROM SanPham WHERE TenSP = '" + row.Cells[tenSPIndex].Value.ToString() + "'";                
                DataTable result = Database.query(query);
                string maSP = result.Rows[0]["MaSP"].ToString();

                // Lay ma VLC
                query = "SELECT top 1 MaVL FROM VatLieuChinh WHERE TenVL = '" + row.Cells[tenVLCIndex].Value.ToString() + "'";                
                result = Database.query(query);
                string maVLC = result.Rows[0]["MaVL"].ToString();


                // Lay Ma VLP
                string maVLP = "";
                //Database.Debug(row.Cells[tenVLPIndex].Value.ToString());
                if (row.Cells[tenVLPIndex].Value.ToString() != "")
                {
                    query = "SELECT top 1 MaVL FROM VatLieuPhu WHERE TenVL = '" + row.Cells[tenVLPIndex].Value.ToString() + "'";                    
                    result = Database.query(query);
                    if (result.Rows.Count > 0)
                        maVLP = result.Rows[0]["MaVL"].ToString();
                }

                // Neu la insert them san pham
                if (!isUpdate)
                {
                    bool isOK = false;
                    while (!isOK)
                    {
                        try
                        {
                            int soluongVLP = 0;
                            if (row.Cells[soluongVLPIndex].Value.ToString() != "")
                                soluongVLP = Int32.Parse(row.Cells[soluongVLPIndex].Value.ToString());
                            // Them SanPhamDatHang
                            row.Cells[maSPDatHangIndex].Value = FindMaSPDatHang();
                            query = "INSERT SanPhamDatHang VALUES(" +
                                            "'" + row.Cells[maSPDatHangIndex].Value.ToString() + "'," +
                                            "'" + maSP + "'," +
                                            "'" + maVLC + "'," +
                                            "'" + maVLP + "'," +      
                                            row.Cells[soluongIndex].Value.ToString() + "," +
                                            soluongVLP.ToString() + "," +
                                            "'', '', ''" +
                                            ")";
                            //Database.Debug(query);
                            Database.query(query);

                            // Them MauHang_SanPhamDatHang
                            query = "INSERT MauHang_SanPhamDatHang VALUES(" +
                                            " '" + row.Cells[msMauIndex].Value.ToString() + "'," + 
                                            " '" + row.Cells[maSPDatHangIndex].Value.ToString() + "'" + 
                                    ")";
                            Database.query(query);


                            isOK = true;
                            MessageBox.Show(null, "Thêm sản phẩm thành công", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (Exception exception)
                        {
                            isOK = false;
                        }
                    }
                }

                // Neu la update dong 
                else 
                {
                    bool isOK = false;
                    while (!isOK)
                    {
                        try
                        {
                            // Them SanPhamDatHang
                            //row.Cells[10].Value = FindMaSPDatHang();
                            query = "UPDATE SanPhamDatHang SET " +
                                            " MaSP = '" + maSP + "'," +
                                            " MaVLC = '" + maVLC + "'," +
                                            " MaVLP = '" + maVLP + "'," +
                                            " SoLuongVLC = " + row.Cells[soluongIndex].Value.ToString() + ", " + 
                                            " SoLuongVLP = " + row.Cells[soluongVLPIndex].Value.ToString() + 
                                            " WHERE MaSPDatHang = '" + row.Cells[maSPDatHangIndex].Value + "'";                                            
                            //Database.Debug(query);
                            Database.query(query);

                            isOK = true;
                            MessageBox.Show(null, "Sửa sản phẩm thành công", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (Exception exception)
                        {
                            isOK = false;
                        }
                    }
                }

            }
        }
        #endregion
    }
}
