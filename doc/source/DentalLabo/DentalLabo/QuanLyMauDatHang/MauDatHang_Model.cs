using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using DentalLabo.Mau_dat_hang;
using DentalLabo.BanHangVaCongNo;

namespace DentalLabo.MauDatHang
{
    class MauDatHang_Model
    {
        public string viTriRangString;
        private DentalLabo.Mau_dat_hang.frmMauDatHang form;
        public MauDatHang_Model(DentalLabo.Mau_dat_hang.frmMauDatHang form)
        {
            this.form = form;
        }
        
        #region SinhMaMau
        /**
         * Sinh ma so phieu mot cach tu dong, bang cach tang dan
         */
        public void SinhMaSoMau()
        {
            String query = "SELECT TOP 1 MaMau FROM MauHang ORDER BY len(MaMau) desc, MaMau desc";
            DataTable result = Database.query(query);
            long maMau = 0;
            if (result.Rows.Count == 0)
                maMau = 1;
            else
                maMau = Int64.Parse(result.Rows[0]["MaMau"].ToString().Substring(2)) + 1;

            String maMauStr = "MH" + maMau.ToString();

            form.txtSoMau.Text = maMauStr;
        }
        #endregion 

        #region NhomKhachHang
        /*
         * load ten bo phan
         */
        public void LoadTenNhom()
        {
            BHCNModel.UpdateComboBoxByQuery(form.cmbNhomKH, "SELECT TenNhom FROM NhomKH", "TenNhom");
        }
        /*
         * cap nhat ma nhom theo ten nhom
         */
        public void UpdateMaNhom(string tenNhomKH)
        {
            String query = "SELECT MaNhom FROM NhomKH WHERE TenNhom = '" + tenNhomKH + "'";
            BHCNModel.UpdateComboBoxByQuery(form.cmbMaNhomKH, query, "MaNhom");
        }
        /*
         * cap nhat 
         */
        #endregion

        #region TenKhachHang
        /**
         * Cap nhat ten khach hang theo ten nhom khach hang
         */
        public void LoadTenKH(String maNhomKH)
        {
            String query = "SELECT TenKH FROM KhachHang WHERE MaNhomKH = '" + maNhomKH + "'";
            BHCNModel.UpdateComboBoxByQuery(form.cmbTenKH, query, "TenKH");
        }

        /**
         * Cap nhat ma so khach hang theo ten khach hang
         */
        public void UpdateMaSoKH(String tenKH)
        {
            String query = "SELECT MaKH FROM KhachHang WHERE TenKH = '" + tenKH + "'";
            BHCNModel.UpdateComboBoxByQuery(form.cmbMaKH, query, "MaKH");
        }
        #endregion

        #region PlusInfo
        /*
         * Cap nhat dia chi va dien thoai theo ma khach hang
         */
        public void UpdatePhoneNumKH(String maKH)
        {
            String query = "SELECT SDT FROM KhachHang WHERE MaKH = '" + maKH + "'";
            BHCNModel.UpdateComboBoxByQuery(form.cmbDienThoaiKH, query, "SDT");
        }
        /*
         * Cap nhat dia chi va dien thoai theo ma khach hang
         */
        public void UpdateAddKH(String maKH)
        {
            String query = "SELECT DiaChi FROM KhachHang WHERE MaKH = '" + maKH + "'";
            BHCNModel.UpdateComboBoxByQuery(form.cmbDiaChiKH, query, "DiaChi");
        }
        #endregion

        #region LoadThongTinSP
        /*
         * Load thong tin ve san pham
         */
        public void LoadTenSanPham()
        {
            BHCNModel.UpdateComboBoxByQuery(form.cmbTenSP, "SELECT TenSP FROM SanPham", "TenSP");
            BHCNModel.UpdateComboBoxByQuery(form.cmbTenSP2, "SELECT TenSP FROM SanPham", "TenSP");
        }

        public void UpdateMaSanPham(String TenSP)
        {
            String query = "SELECT MaSP FROM SanPham WHERE TenSP = '" + TenSP + "'";
            BHCNModel.UpdateComboBoxByQuery(form.cmbMaSP, query, "MaSP");
        }

        public void UpdateMaSanPham2(String TenSP)
        {
            String query = "SELECT MaSP FROM SanPham WHERE TenSP = '" + TenSP + "'";
            BHCNModel.UpdateComboBoxByQuery(form.cmbMaSP2, query, "MaSP");
        }

        public void LoadTenVLC()
        {
            BHCNModel.UpdateComboBoxByQuery(form.cmbLoaiVatLieu, "SELECT TenVL FROM VatLieuChinh", "TenVL");
            BHCNModel.UpdateComboBoxByQuery(form.cmbVLChinh, "SELECT TenVL FROM VatLieuChinh", "TenVL");
        }

        public void UpdateMaVatLieu(String TenVLC)
        {
            String query = "SELECT MaVL FROM VatLieuChinh WHERE TenVL = '" + TenVLC + "'";
            BHCNModel.UpdateComboBoxByQuery(form.cmbMaVatLieu, query, "MaVL");
        }

        public void UpdateMaVLC(String TenVLC)
        {
            String query = "SELECT MaVL FROM VatLieuChinh WHERE TenVL = '" + TenVLC + "'";
            BHCNModel.UpdateComboBoxByQuery(form.cmbMaVLChinh, query, "MaVL");
        }

        public void LoadTenVLP()
        {
            BHCNModel.UpdateComboBoxByQuery(form.cmbVLPhu, "SELECT TenVL FROM VatLieuPhu", "TenVL");
        }

        public void UpdateMaVLP(String TenVLP)
        {
            String query = "SELECT MaVL FROM VatLieuPhu WHERE TenVL = '" + TenVLP + "'";
            BHCNModel.UpdateComboBoxByQuery(form.cmbMaVLPhu, query, "MaVL");
        }
        #endregion

        #region TimKiemMau
        /*
         * Tim kiem Thong tin mot mau theo ma mau nhap vao
         */
        public void TimKiemMau(bool isSearch)
        {
            if (form.txtSoMau.Text == "")
            {
                MessageBox.Show(null, "Chưa nhập mã số mẫu để tìm kiếm", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String maMau = form.txtSoMau.Text;
                // kiem tra mau co trong co so du lieu chua?
                String query = "SELECT * FROM MauHang WHERE MaMau = '" + maMau + "'";
                DataTable result = Database.query(query);
                if (result.Rows.Count == 0)
                {
                    MessageBox.Show(null, "Không tồn tại mẫu có mã số đã nhập!", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                query = "SELECT TOP 1 * FROM MauHang WHERE MaMau = '" + maMau + "'";
                result = Database.query(query);
                
                String tenBN = result.Rows[0]["TenBN"].ToString();
                String tuoiBN = result.Rows[0]["TuoiBN"].ToString();
                String gioiTinhBN = result.Rows[0]["GioiTinhBN"].ToString();
                String maKH = result.Rows[0]["MaKH"].ToString();
                String loaiPH = result.Rows[0]["LoaiPhucHinh"].ToString();
                String ngayNhan = result.Rows[0]["NgayNhan"].ToString();
                String ngayTra = result.Rows[0]["NgayTra"].ToString();
                String gioTra = result.Rows[0]["gioTra"].ToString() + "h";

                // dien thong tin khach hang va nhom khach hang
                form.cmbMaKH.Text = maKH;
                query = "select top 1 * from KhachHang where MaKH = '" + maKH + "'";
                result = Database.query(query);
                form.cmbTenKH.Text = result.Rows[0]["TenKH"].ToString();
                form.cmbDiaChiKH.Text = result.Rows[0]["DiaChi"].ToString();
                form.cmbDienThoaiKH.Text = result.Rows[0]["SDT"].ToString();
                String maNhom = result.Rows[0]["MaNhomKH"].ToString();
                form.cmbMaNhomKH.Text = maNhom;
                query = "select top 1 TenNhom from NhomKH where MaNhom = '" + maNhom + "'";
                result = Database.query(query);
                form.cmbNhomKH.Text = result.Rows[0]["TenNhom"].ToString();

                form.dateNgayNhan.Text = ngayNhan;
                
                // load thong tin cac san pham cua mau
                

                // kiem tra xem la loai phuc hinh nao
                if (loaiPH == "1")
                {
                    form.tabControl1.SelectedTab = form.tabControl1.TabPages[0]; // loai phuc hinh co dinh
                    form.txtTenBN.Text = tenBN;
                    form.txtTuoiBN.Text = tuoiBN;
                    form.cmbGioiTinhBN.Text = gioiTinhBN;
                    form.dateGioTra.Text = gioTra;
                    form.dateNgayTra.Text = ngayTra;
                    LayThongTinMau(maMau, "1", ngayTra, gioTra, tuoiBN, gioiTinhBN);
                }
                else
                {
                    form.tabControl1.SelectedTab = form.tabControl1.TabPages[1];
                    form.txtTenBN2.Text = tenBN;
                    form.txtTuoiBN2.Text = tuoiBN;
                    form.cmbGioiTinhBN2.Text = gioiTinhBN;
                    form.dateGioTra2.Text = gioTra;
                    form.dateNgayTra2.Text = ngayTra;
                    LayThongTinMau(maMau, "2", ngayTra, gioTra, tuoiBN, gioiTinhBN);
                }
            } // of else
        }

        // lay thong tin mau phuc vu tim kiem
        public void LayThongTinMau(String maMau, String loaiPhucHinh, String ngayTra, String gioTra, String tuoiBN, String gioiTinhBN)
        {
            if (loaiPhucHinh == "1") form.dtgNoiDungMau.Rows.Clear();
            else form.dtgNoiDungMau2.Rows.Clear();
            String query = "SELECT MaSPDatHang FROM MauHang_SanPhamDatHang WHERE MaMau = '" + maMau + "'";
            DataTable result = Database.query(query);
            if (result.Rows.Count > 0)
            {
                
                object[] a = new object[20];
                if(loaiPhucHinh == "1") a[0] = form.dtgNoiDungMau.Rows.Count;
                else a[0] = form.dtgNoiDungMau2.Rows.Count;
                
                int countRows = 0;
                foreach (DataRow row in result.Rows)
                {
                    String maSPDatHang = row["MaSPDatHang"].ToString();
                    //a[10] = maSPDatHang;

                    if (countRows > 0)
                    {
                        if (loaiPhucHinh == "1") a[0] = form.dtgNoiDungMau.Rows.Count;
                        else a[0] = form.dtgNoiDungMau2.Rows.Count;
                    }
                    else
                        countRows += 1;


                    query = "SELECT * FROM SanPhamDatHang WHERE MaSPDatHang = '" + maSPDatHang + " '";
                    DataTable spDatHang = Database.query(query);

                    // Lay ten san pham
                    string maSP = spDatHang.Rows[0]["MaSP"].ToString();
                    query = "SELECT TenSP, DVT FROM SanPham WHERE MaSP = '" + maSP + "'";
                    DataTable sanpham = Database.query(query);
                    string tenSP = sanpham.Rows[0]["TenSP"].ToString();
                    string dvt = sanpham.Rows[0]["DVT"].ToString();

                    // Vi tri rang
                    string viTriRang = spDatHang.Rows[0]["ViTriRang"].ToString();

                    // Lay vat lieu chinh                        
                    string maVLC = spDatHang.Rows[0]["MaVLC"].ToString();
                    query = "SELECT TenVL FROM VatLieuChinh WHERE MaVL = '" + maVLC + "'";
                    DataTable vlc = Database.query(query);
                    string tenVLC = vlc.Rows[0]["TenVL"].ToString();

                    // Lay vat lieu phu
                    string maVLP = spDatHang.Rows[0]["MaVLP"].ToString();
                    query = "SELECT TenVL FROM VatLieuPhu WHERE MaVL = '" + maVLP + "'";
                    DataTable vlp = Database.query(query);
                    string tenVLP = "";
                    if (vlp.Rows.Count > 0)
                        tenVLP = vlp.Rows[0]["TenVL"].ToString();

                    //mau rang, ly do, trang thai thao tac, luu y, yeu cau chi tiet
                    string mauSP = spDatHang.Rows[0]["MauSP"].ToString();
                    string luuY = spDatHang.Rows[0]["LuuY"].ToString();
                    string thaoTac = spDatHang.Rows[0]["ThaoTac"].ToString();
                    string lyDo = spDatHang.Rows[0]["LyDo"].ToString();
                    string yeuCauChiTiet = spDatHang.Rows[0]["YeuCauChiTiet"].ToString();
                    string tayMoc = spDatHang.Rows[0]["ViTriTayMoc"].ToString();
                    string soLuong = spDatHang.Rows[0]["SoLuongVLC"].ToString();
                    // Gan cac truong tenSP, dvt, soluong, vlc, vlp
                    a[1] = tenSP;
                    a[2] = viTriRang;
                    a[3] = tenVLC;
                    a[4] = maVLC;
                    a[5] = mauSP;
                    
                    if (loaiPhucHinh == "1")
                    {
                        a[6] = ""; // loai gam
                        a[7] = dvt;
                        a[8] = luuY;
                        a[9] = ngayTra;
                        a[10] = gioTra;
                        a[11] = tuoiBN;
                        a[12] = gioiTinhBN;
                        a[13] = thaoTac;
                        a[14] = lyDo;
                        a[15] = yeuCauChiTiet;
                        a[16] = maSPDatHang;

                        form.dtgNoiDungMau.Rows.Add(a);
                        int currentIndex = form.dtgNoiDungMau.Rows.Count - 1;
                        DataGridViewRow currentRow = form.dtgNoiDungMau.Rows[currentIndex];
                        for (int i = 0; i < 16; i++)
                            currentRow.Cells[i].ReadOnly = true;
                    }
                    else
                    {
                        a[6] = tenVLP;
                        a[7] = maVLP;
                        a[8] = tayMoc;
                        a[9] = dvt;
                        a[10] = soLuong;//soluong
                        a[11] = ngayTra;
                        a[12] = gioTra;
                        a[13] = tuoiBN;
                        a[14] = gioiTinhBN;
                        a[15] = thaoTac;
                        a[16] = lyDo;
                        a[17] = yeuCauChiTiet;
                        a[18] = maSPDatHang;

                        form.dtgNoiDungMau2.Rows.Add(a);
                        int currentIndex = form.dtgNoiDungMau2.Rows.Count - 1;
                        DataGridViewRow currentRow = form.dtgNoiDungMau2.Rows[currentIndex];
                        for (int i = 0; i < 16; i++)
                            currentRow.Cells[i].ReadOnly = true;
                    }
                } // of foreach
            } // of if
        } // of function
        #endregion

        #region LuuAction
        /*
         * Them mot mau moi
         */
        public void LuuAction(String action, String loaiPhucHinh, String maSPDH)
        {
            String query;
            
            #region TaoMauMoi
            if (action == "Mau moi")
            {
                string maKH = form.cmbMaKH.Text;
                string maMau = form.txtSoMau.Text;
                string ngayNhan = form.dateNgayNhan.Text;
                string tenBN;
                string tuoiBN;
                string gioitinhBN;
                string ngayTra;
                string gioTra;
                if (loaiPhucHinh == "1")
                {
                    ngayTra = form.dateNgayTra.Text;
                    gioTra = form.dateGioTra.Text;
                    tenBN = form.txtTenBN.Text;
                    tuoiBN = form.txtTuoiBN.Text;
                    gioitinhBN = form.cmbGioiTinhBN.Text;
                }
                else
                {
                    ngayTra = form.dateNgayTra2.Text;
                    gioTra = form.dateGioTra2.Text;
                    tenBN = form.txtTenBN2.Text;
                    tuoiBN = form.txtTuoiBN2.Text;
                    gioitinhBN = form.cmbGioiTinhBN2.Text;
                }

                int gioTraInt = Int16.Parse(gioTra.Substring(0, 2));
                int tuoiBNInt = Int16.Parse(tuoiBN);

                if (maMau == "") MessageBox.Show(null, "Mã mẫu không được để trống!", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (maKH == "") MessageBox.Show(null, "Mã khách hàng không được để trống!", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                query = "INSERT MauHang VALUES(" +
                                            "'" + maMau + "'," +
                                            "'" + maKH + "'," +
                                            "'" + loaiPhucHinh + "'," +
                                            "'" + ngayNhan + "'," +
                                            "'" + ngayTra + "'," +
                                            "'" + gioTraInt + "'," +
                                            " '', 0, N'" + tenBN + "'," +
                                            "'" + tuoiBNInt + "'," +
                                            "N'" + gioitinhBN + "'" +
                                            ")";
                //Database.Debug(query);
                if (MessageBox.Show(null, "Bạn có chắc muốn thêm mẫu với mã '" + maMau + "' không?", "Insert data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Database.query(query);
                    MessageBox.Show(null, "Đã thêm mẫu vào cơ sở dữ liêu", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            #endregion

            #region TaoSanPhamMoi
            if (action == "San Pham Moi")
            {
                string maMau = form.txtSoMau.Text;
                if (maMau == "") MessageBox.Show(null, "Mã mẫu không được để trống!", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string maKH;
                string tenBN;
                string tuoiBN;
                string gioitinhBN;
                string ngayTra;
                string gioTra;
                string ngayNhan;

                // kiem tra mau da ton tai chua neu chua ton tai thi them moi vao
                query = "SELECT TOP 1 *  FROM MauHang WHERE MaMau = '" + maMau + "'";
                DataTable result = Database.query(query);
                if (result.Rows.Count == 0)
                {
                    if (loaiPhucHinh == "1")
                    {
                        ngayTra = form.dateNgayTra.Text;
                        gioTra = form.dateGioTra.Text;
                        tenBN = form.txtTenBN.Text;
                        tuoiBN = form.txtTuoiBN.Text;
                        gioitinhBN = form.cmbGioiTinhBN.Text;
                    }
                    else
                    {
                        ngayTra = form.dateNgayTra2.Text;
                        gioTra = form.dateGioTra2.Text;
                        tenBN = form.txtTenBN2.Text;
                        tuoiBN = form.txtTuoiBN2.Text;
                        gioitinhBN = form.cmbGioiTinhBN2.Text;
                    }
                    maKH = form.cmbMaKH.Text;
                    if (maKH == "") MessageBox.Show(null, "Mã khách hàng không được để trống!", "Loi nhap du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ngayNhan = form.dateNgayNhan.Text;
                    // chuyen xau nhan duoc tu form ve dang int voi gio tra va tuoi benh nhan
                    int gioTraInt = Int16.Parse(gioTra.Substring(0, 2));
                    int tuoiBNInt;
                    if (tuoiBN != "") tuoiBNInt = Int16.Parse(tuoiBN);
                    else tuoiBNInt = 0;

                    query = "INSERT MauHang VALUES(" +
                            "'" + maMau + "'," +
                            "'" + maKH + "'," +
                            loaiPhucHinh + "," +
                            "'" + ngayNhan + "'," +
                            "'" + ngayTra + "'," +
                            gioTraInt + "," +
                            " '', 0, N'" + tenBN + "'," +
                            tuoiBNInt + "," +
                            "N'" + gioitinhBN + "'" +
                            ")";

                    if (MessageBox.Show(null, "Mẫu chưa tồn tại! Bạn có muốn thêm với mã số '" + maMau + "' vào hay không", "Insert data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Database.query(query);
                        MessageBox.Show(null, "Đã thêm mẫu vào cơ sở dữ liêu", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    maKH = result.Rows[0]["MaKH"].ToString();
                    tenBN = result.Rows[0]["TenBN"].ToString();
                    tuoiBN = result.Rows[0]["TuoiBN"].ToString();
                    gioitinhBN = result.Rows[0]["GioiTinhBN"].ToString();
                    ngayNhan = result.Rows[0]["NgayNhan"].ToString();
                    ngayTra = result.Rows[0]["NgayTra"].ToString();
                    gioTra = result.Rows[0]["GioTra"].ToString() + "h";
                    
                    // cap nhat lai cho chinh xac cac gia tri trong form
                    form.dateNgayNhan.Text = ngayNhan;
                    if (loaiPhucHinh == "1")
                    {
                        form.txtTenBN.Text = tenBN;
                        form.txtTuoiBN.Text = tuoiBN;
                        form.cmbGioiTinhBN.Text = gioitinhBN;
                        form.dateNgayTra.Text = ngayTra;
                        form.dateGioTra.Text = gioTra;
                    }
                    else
                    {
                        form.txtTenBN2.Text = tenBN;
                        form.txtTuoiBN2.Text = tuoiBN;
                        form.cmbGioiTinhBN2.Text = gioitinhBN;
                        form.dateNgayTra2.Text = ngayTra;
                        form.dateGioTra2.Text = gioTra;
                    }
                }

                // lay cac thong tin tu form nhap vao
                string thaoTac1 = form.cmbThaoTac.Text;
                string thaoTac2 = form.cmbThaoTac2.Text;
                string lyDo1 = form.txtLyDo.Text;
                string lyDo2 = form.txtLyDo2.Text;
                string tenSP1 = form.cmbTenSP.Text;
                string tenSP2 = form.cmbTenSP2.Text;
                string maSP1 = form.cmbMaSP.Text;
                string maSP2 = form.cmbMaSP2.Text;
                string loaiVL = form.cmbLoaiVatLieu.Text;
                string maVL = form.cmbMaVatLieu.Text;
                string tenVLC = form.cmbVLChinh.Text;
                string maVLC = form.cmbMaVLChinh.Text;
                string tenVLP = form.cmbVLPhu.Text;
                string maVLP = form.cmbMaVLPhu.Text;
                string mauSP1 = form.txtMauSP.Text;
                string mauSP2 = form.txtMauSP2.Text;
                string luuY = form.txtLuuY.Text;
                string tayMoc = form.txtTayMoc.Text;
                string yeuCau1 = form.txtYeuCauChiTiet.Text;
                string yeuCau2 = form.txtYeuCauChiTiet2.Text;
                string viTriRang1 = form.txtViTriRang.Text;
                string viTriRang2 = form.txtViTriRang2.Text;

                string[] array = new string[32];
                array = viTriRang1.Split(',');
                int sorang = array.Count();
                string soLuongVLC = sorang.ToString();

                // sinh ma san pham dat hang tu dong
                query = "SELECT TOP 1 MaSPDatHang FROM SanPhamDatHang ORDER BY len(MaSPDatHang) desc, MaSPDatHang desc";
                result = Database.query(query);
                string maSPDHStr = result.Rows[0]["MaSPDatHang"].ToString().Substring(4);
                int maSpdh = Int16.Parse(maSPDHStr);
                maSpdh = maSpdh + 1;
                maSPDHStr = "SPDH" + maSpdh.ToString();

                string query3 = "INSERT MauHang_SanPhamDatHang VALUES('" + maMau + "'," + "'" + maSPDHStr + "')";

                // query trong truong hop phuc hinh co dinh
                string query1 = "INSERT SanPhamDatHang VALUES(" +
                        "'" + maSPDHStr + "'," +
                        "'" + maSP1 + "'," +
                        "'" + viTriRang1 + "'," +
                        "'" + maVL + "'," +
                        " null," +
                        "'" + soLuongVLC + "'," +
                        "0," +
                        "'" + mauSP1 + "'," +
                        "'" + luuY + "'," +
                        " null,N'" + yeuCau1 + "'," +
                        "N'" + thaoTac1 + "'," +
                        "N'" + lyDo1 + "'" + 
                        ")";

                // query trong truong hop phuc hinh thao lap
                string query2 = "INSERT SanPhamDatHang VALUES(" +
                        "'" + maSPDHStr + "'," +
                        "'" + maSP2 + "'," +
                        "'" + viTriRang2 + "'," +
                        "'" + maVLC + "'," +
                        "'" + maVLP + "'," +
                        "'" + soLuongVLC + "'," +
                        "1," +
                        "'" + mauSP2 + "'," +
                        " null," +
                        "N'" + tayMoc + "'," +
                        "N'" + yeuCau2 + "'," +
                        "N'" + thaoTac2 + "'," +
                        "N'" + lyDo2 + "'" + 
                        ")";

                if (loaiPhucHinh == "1")
                {
                    Database.query(query1);
                    //MessageBox.Show(query1);
                    MessageBox.Show(null, "Đã lưu thông tin", "Luu Thong Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Database.query(query3);
                    LayThongTinMau(maMau, "1", ngayTra, gioTra, tuoiBN, gioitinhBN);
                }
                else
                {
                    Database.query(query2);
                    //MessageBox.Show(query2);
                    MessageBox.Show(null, "Đã lưu thông tin", "Luu Thong Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Database.query(query3);
                    LayThongTinMau(maMau, "2", ngayTra, gioTra, tuoiBN, gioitinhBN);
                }
            }
            #endregion

            #region Capnhattubang
            if (action == "Cap nhat tu bang")
            {
                // lay cac du lieu tu form
                string thaoTac1 = form.cmbThaoTac.Text;
                string thaoTac2 = form.cmbThaoTac2.Text;
                string lyDo1 = form.txtLyDo.Text;
                string lyDo2 = form.txtLyDo2.Text;
                string tenSP1 = form.cmbTenSP.Text;
                string tenSP2 = form.cmbTenSP2.Text;
                string maSP1 = form.cmbMaSP.Text;
                string maSP2 = form.cmbMaSP2.Text;
                string loaiVL = form.cmbLoaiVatLieu.Text;
                string maVL = form.cmbMaVatLieu.Text;
                string tenVLC = form.cmbVLChinh.Text;
                string maVLC = form.cmbMaVLChinh.Text;
                string tenVLP = form.cmbVLPhu.Text;
                string maVLP = form.cmbMaVLPhu.Text;
                string mauSP1 = form.txtMauSP.Text;
                string mauSP2 = form.txtMauSP2.Text;
                string luuY = form.txtLuuY.Text;
                string tayMoc = form.txtTayMoc.Text;
                string yeuCau1 = form.txtYeuCauChiTiet.Text;
                string yeuCau2 = form.txtYeuCauChiTiet2.Text;
                string viTriRang1 = form.txtViTriRang.Text;
                string viTriRang2 = form.txtViTriRang2.Text;

                // query trong truong hop phuc hinh co dinh
                string query1 = "UPDATE SanPhamDatHang SET " +
                        "MaSP = '" + maSP1 + "'," +
                        "ViTriRang = '" + viTriRang1 + "'," +
                        "MaVLC = '" + maVL + "'," +
                        "MauSP = '" + mauSP1 + "'," +
                        "LuuY = '" + luuY + "'," +
                        "YeuCauChiTiet = N'" + yeuCau1 + "'," +
                        "ThaoTac = N'" + thaoTac1 + "'," +
                        "LyDo = N'" + lyDo1 + "' where MaSPDatHang = '" + maSPDH + "'";

                // query trong truong hop phuc hinh thao lap
                string query2 = "UPDATE SanPhamDatHang SET " +
                        "MaSP = '" + maSP2 + "'," +
                        "ViTriRang = '" + viTriRang2 + "'," +
                        "MaVLC = '" + maVLC + "'," +
                        "MaVLP = '" + maVLP + "'," +
                        "MauSP = '" + mauSP2 + "'," +
                        "ViTriTayMoc = N'" + tayMoc + "'," +
                        "YeuCauChiTiet = N'" + yeuCau2 + "'," +
                        "ThaoTac = N'" + thaoTac2 + "'," +
                        "LyDo = N'" + lyDo2 + "' where MaSPDatHang = '" + maSPDH + "'";
                string maMau = form.txtSoMau.Text;
                if (loaiPhucHinh == "1")
                {
                    //MessageBox.Show(query1);
                    Database.query(query1);
                    string ngayTra = form.dateNgayTra.Text;
                    string gioTra = form.dateGioTra.Text;
                    string tuoiBN = form.txtTuoiBN.Text;
                    string gioitinhBN = form.cmbGioiTinhBN.Text;
                    MessageBox.Show(null, "Đã lưu thông tin sửa đổi", "Luu Thong Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LayThongTinMau(maMau, "1", ngayTra, gioTra, tuoiBN, gioitinhBN);
                }
                else
                {
                    //MessageBox.Show(query2);
                    Database.query(query2);
                    string ngayTra = form.dateNgayTra2.Text;
                    string gioTra = form.dateGioTra2.Text;
                    string tuoiBN = form.txtTuoiBN2.Text;
                    string gioitinhBN = form.cmbGioiTinhBN2.Text;
                    MessageBox.Show(null, "Đã lưu thông tin sửa đổi", "Luu Thong Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LayThongTinMau(maMau, "2", ngayTra, gioTra, tuoiBN, gioitinhBN);
                }
            }
            #endregion

            #region CapNhatMau
            if (action == "Sua Mau")
            {
                string maKH = form.cmbMaKH.Text;
                string ngayNhan = form.dateNgayNhan.Text;
                string tenBN;
                string tuoiBN;
                string gioitinhBN;
                string ngayTra;
                string gioTra;
                if (loaiPhucHinh == "1")
                {
                    ngayTra = form.dateNgayTra.Text;
                    gioTra = form.dateGioTra.Text;
                    tenBN = form.txtTenBN.Text;
                    tuoiBN = form.txtTuoiBN.Text;
                    gioitinhBN = form.cmbGioiTinhBN.Text;
                }
                else
                {
                    ngayTra = form.dateNgayTra2.Text;
                    gioTra = form.dateGioTra2.Text;
                    tenBN = form.txtTenBN2.Text;
                    tuoiBN = form.txtTuoiBN2.Text;
                    gioitinhBN = form.cmbGioiTinhBN2.Text;
                }

                int gioTraInt = Int16.Parse(gioTra.Substring(0, 2));
                int tuoiBNInt = Int16.Parse(tuoiBN);

                query = "UPDATE MauHang SET " +
                    "MaKH = '" + maKH + "'," +
                    "LoaiPhucHinh = '" + loaiPhucHinh + "'," +
                    "NgayNhan = '" + ngayNhan + "'," +
                    "NgayTra = '" + ngayTra + "'," +
                    "GioTra = '" + gioTraInt + "'," +
                    "TenBN = N'" + tenBN + "'," +
                    "TuoiBN = '" + tuoiBNInt + "'," +
                    "GioiTinhBN = N'" + gioitinhBN + "'" +
                    " WHERE MaMau = '" + maSPDH +"'";
                
                //MessageBox.Show(query);

                Database.query(query);
                MessageBox.Show(null, "Đã sửa thông tin mẫu!", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion
        }
        #endregion

        #region CapNhatTuBang
        /*
             * Cap nhat lai gia tri cua san pham trong mau sau khi da thay doi
             */
        public String CapNhatSanPham(String loaiPhucHinh)
        {
            string maSPDH;
            string tenSP;
            string maSP;
            string viTriRang;
            string tenVLC;
            string maVLC;
            string tenVLP;
            string maVLP;
            string soLuongVLC;
            string soLuongVLP;
            string mauSP;
            string luuY;
            string tayMoc;
            string yeuCau;
            string thaoTac;
            string lyDo;
            
            DataGridViewRow selectedRow = new DataGridViewRow();
            string action = "";
            if (loaiPhucHinh == "1")
                if (form.dtgNoiDungMau.SelectedRows.Count == 0)
                {
                    action = "Sua Mau";
                }
                else
                {
                    selectedRow = form.dtgNoiDungMau.SelectedRows[0];
                    action = "Sua San Pham";
                }
            else
            {
                if (form.dtgNoiDungMau2.SelectedRows.Count == 0)
                {
                    action = "Sua Mau";
                }
                else
                {
                    selectedRow = form.dtgNoiDungMau2.SelectedRows[0];
                    action = "Sua San Pham";
                }
            }

            if (action == "Sua Mau")
            {
                string maMau = form.txtSoMau.Text;
                if (MessageBox.Show(null, "Bạn muốn cập nhật mẫu '" + maMau + "' phải không?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "SELECT * FROM MauHang WHERE MaMau = '" + maMau + "'";
                    DataTable result = Database.query(query);
                    if (result.Rows.Count == 0)
                    {
                        MessageBox.Show(null, "Không có mẫu '" + maMau + "' trong cơ sở dữ liệu! xem lại thông tin mã mẫu", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        form.cmbMaKH.Text = result.Rows[0]["MaKH"].ToString();
                        
                        query = "SELECT * FROM KhachHang WHERE MaKH = '" + result.Rows[0]["MaKH"] + "'";
                        DataTable result1 = Database.query(query);
                        form.cmbTenKH.Text = result1.Rows[0]["TenKH"].ToString();
                        form.cmbDiaChiKH.Text = result1.Rows[0]["DiaChi"].ToString();
                        form.cmbDienThoaiKH.Text = result1.Rows[0]["SDT"].ToString();
                        
                        form.dateNgayNhan.Text = result.Rows[0]["NgayNhan"].ToString();

                        if (loaiPhucHinh == "1")
                        {
                            form.txtTenBN.Text = result.Rows[0]["TenBN"].ToString();
                            form.txtTuoiBN.Text = result.Rows[0]["TuoiBN"].ToString();
                            form.cmbGioiTinhBN.Text = result.Rows[0]["GioiTinhBN"].ToString();
                            form.dateNgayTra.Text = result.Rows[0]["NgayTra"].ToString();
                            form.dateGioTra.Text = result.Rows[0]["GioTra"].ToString() + "h";
                        }
                        else
                        {
                            form.txtTenBN2.Text = result.Rows[0]["TenBN"].ToString();
                            form.txtTuoiBN2.Text = result.Rows[0]["TuoiBN"].ToString();
                            form.cmbGioiTinhBN2.Text = result.Rows[0]["GioiTinhBN"].ToString();
                            form.dateNgayTra2.Text = result.Rows[0]["NgayTra"].ToString();
                            form.dateGioTra2.Text = result.Rows[0]["GioTra"].ToString() + "h";
                        }
                    }
                }
                return maMau;
            }
            else
            {
                tenSP = selectedRow.Cells[1].Value.ToString();
                UpdateMaSanPham(tenSP);
                viTriRang = selectedRow.Cells[2].Value.ToString();
                tenVLC = selectedRow.Cells[3].Value.ToString();
                maVLC = selectedRow.Cells[4].Value.ToString();
                mauSP = selectedRow.Cells[5].Value.ToString();

                if (loaiPhucHinh == "1")
                {
                    maSPDH = selectedRow.Cells[16].Value.ToString();
                    luuY = selectedRow.Cells[8].Value.ToString();
                    thaoTac = selectedRow.Cells[13].Value.ToString();
                    lyDo = selectedRow.Cells[14].Value.ToString();
                    yeuCau = selectedRow.Cells[15].Value.ToString();

                    form.cmbThaoTac.Text = thaoTac;
                    form.txtLyDo.Text = lyDo;
                    form.cmbTenSP.Text = tenSP;
                    UpdateMaSanPham(tenSP);
                    form.cmbLoaiVatLieu.Text = tenVLC;
                    UpdateMaVatLieu(tenVLC);
                    form.txtMauSP.Text = mauSP;
                    form.txtLuuY.Text = luuY;
                    form.txtYeuCauChiTiet.Text = yeuCau;
                    form.txtViTriRang.Text = viTriRang;
                }
                else
                {
                    maSPDH = selectedRow.Cells[18].Value.ToString();
                    tenVLP = selectedRow.Cells[6].Value.ToString();
                    maVLP = selectedRow.Cells[7].Value.ToString();
                    tayMoc = selectedRow.Cells[8].Value.ToString();
                    thaoTac = selectedRow.Cells[15].Value.ToString();
                    lyDo = selectedRow.Cells[16].Value.ToString();
                    yeuCau = selectedRow.Cells[17].Value.ToString();

                    form.cmbThaoTac2.Text = thaoTac;
                    form.txtLyDo2.Text = lyDo;
                    form.cmbTenSP2.Text = tenSP;
                    UpdateMaSanPham2(tenSP);
                    form.cmbVLChinh.Text = tenVLC;
                    UpdateMaVLC(tenVLC);
                    form.cmbVLPhu.Text = tenVLP;
                    UpdateMaVLP(tenVLP);
                    form.txtMauSP2.Text = mauSP;
                    form.txtTayMoc.Text = tayMoc;
                    form.txtYeuCauChiTiet2.Text = yeuCau;
                    form.txtViTriRang2.Text = viTriRang;
                }
                return maSPDH;
            }

        }
        #endregion

        #region XoaSPTrongBang
        public void XoaSanPhamTuMau(String loaiPhucHinh)
        {
            string maSPDH = "";
            string maMau;
            DataGridViewRow selectedRow;
            if (loaiPhucHinh == "1")
            {
                if (form.dtgNoiDungMau.SelectedRows.Count != 0)
                {
                    selectedRow = form.dtgNoiDungMau.SelectedRows[0];
                    maSPDH = selectedRow.Cells[16].Value.ToString();
                }
                else
                {
                    maMau = form.txtSoMau.Text;
                    if (MessageBox.Show(null, "Có phải bạn muốn xóa mẫu có mã = '" + maMau + "' không?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string queryDelRef = "DELETE FROM MauHang_SanPhamDatHang WHERE MaMau = '" + maMau + "'";
                        string queryDelMau = "DELETE FROM MauHang WHERE MaMau = '" + maMau + "'";
                        Database.query(queryDelRef); 
                        Database.query(queryDelMau);
                        MessageBox.Show(null, "Đã xóa mẫu '" + maMau + "' khỏi cơ sở dũ liệu!", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    maSPDH = "";
                }
            }
            else
            {
                if (form.dtgNoiDungMau2.SelectedRows.Count != 0)
                {
                    selectedRow = form.dtgNoiDungMau2.SelectedRows[0];
                    maSPDH = selectedRow.Cells[18].Value.ToString();
                }
                else
                {
                    maMau = form.txtSoMau.Text;
                    if (MessageBox.Show(null, "Có phải bạn muốn xóa mẫu có mã = '" + maMau + "' không?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string queryDelRef = "DELETE FROM MauHang_SanPhamDatHang WHERE MaMau = '" + maMau + "'";
                        string queryDelMau = "DELETE FROM MauHang WHERE MaMau = '" + maMau + "'";
                        Database.query(queryDelRef);
                        Database.query(queryDelMau);
                        MessageBox.Show(null, "Đã xóa mẫu '" + maMau + "' khỏi cơ sở dũ liệu!", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    maSPDH = "";
                }
            }

            if (maSPDH != "")
            {
                string select = "SELECT TOP 1 MaMau FROM MauHang_SanPhamDatHang WHERE MaSPDatHang = '" + maSPDH + "'";
                DataTable result = Database.query(select);
                maMau = result.Rows[0]["MaMau"].ToString();

                select = "SELECT TOP 1 *  FROM MauHang WHERE MaMau = '" + maMau + "'";
                result = Database.query(select);
                string tuoiBN = result.Rows[0]["TuoiBN"].ToString();
                string gioitinhBN = result.Rows[0]["GioiTinhBN"].ToString();
                string ngayNhan = result.Rows[0]["NgayNhan"].ToString();
                string ngayTra = result.Rows[0]["NgayTra"].ToString();
                string gioTra = result.Rows[0]["GioTra"].ToString() + "h";

                string query = "DELETE FROM SanPhamDatHang WHERE MaSPDatHang = '" + maSPDH + "'";
                string query2 = "DELETE FROM MauHang_SanPhamDatHang WHERE MaSPDatHang = '" + maSPDH + "'";


                if (MessageBox.Show(null, "Bạn có chắc muốn xóa sản phẩm này ra khỏi mẫu hiện tại không?'", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Database.query(query2);
                    Database.query(query);
                    MessageBox.Show(null, "Đã xóa sản phẩm khỏi mẫu", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (loaiPhucHinh == "1") LayThongTinMau(maMau, "1", ngayTra, gioTra, tuoiBN, gioitinhBN);
                    else LayThongTinMau(maMau, "2", ngayTra, gioTra, tuoiBN, gioitinhBN);
                }
            }
        }
        #endregion
    }
}