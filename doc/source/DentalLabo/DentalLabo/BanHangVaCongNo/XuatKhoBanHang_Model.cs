using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DentalLabo.Nhap_kho_va_ban_hang;
namespace DentalLabo.BanHangVaCongNo
{
    class XuatKhoBanHang_Model
    {
        frmXuatKhoBanHang form;
        public string prefixHDBH = "";
        public  static int ttIndex = 0;
        public static int msMauIndex = 1;
        public static int loaiPhucHinhIndex = 2;
        public static int tenSPIndex = 3;
        public static int vlcIndex = 4;
        public static int dvtIndex = 5;
        public static int soLuongIndex = 6;
        public static int tienVLCIndex = 7;
        public static int vlpIndex = 8;
        public static int dvtVLPIndex = 9;
        public static int soLuongVLPIndex = 10;
        public static int tienVLPIndex = 11;
        public static int maSPDatHangIndex = 12;

        public static int TrangThaiMauLamXongChuaTra = 1;
        public static int TrangThaiMauDaTra = 2;

        /*
         * Ham khoi tao
         */
        public XuatKhoBanHang_Model(frmXuatKhoBanHang form)         
        {
            this.form = form;
        }

        /*
         * Ham Load Ten KH khi moi chay
         */
        public void InitLoadTenKH()         
        {
            BHCNModel.UpdateComboBoxByQuery(form.cmbTenKH, "SELECT TenKH FROM KhachHang", "TenKH");
        }

        /*
         * Ham cap nhat ma KH theo ten KH
         */
        public void UpdateMaKH() 
        { 
            BHCNModel.UpdateComboBoxByQuery(form.cmbMaKH, "SELECT MaKH FROM KhachHang WHERE TenKH = '" + form.cmbTenKH.Text + "'", "MaKH");
        }

        /*
         * Ham cap nhat cac truong dia chi, so dien thoai, nguoi dai dien theo MaKH
         */
        public void UpdateTheoMaKH(bool isUpdateTenKH) {           
            string filter = "DiaChi, MaSoThue, NguoiDaiDien";
            if (isUpdateTenKH)
                filter += ", TenKH";
            string query = "SELECT " + filter + " FROM KhachHang WHERE MaKH = '" + form.cmbMaKH.Text + "'";
            DataTable KhachHang = Database.query(query);
            if (KhachHang.Rows.Count > 0)
            {
                form.txtDiaChi.Text = KhachHang.Rows[0]["DiaChi"].ToString();
                form.txtMaSoThue.Text = KhachHang.Rows[0]["MaSoThue"].ToString();
                form.txtNguoiDaiDien.Text = KhachHang.Rows[0]["NguoiDaiDien"].ToString();
                if (isUpdateTenKH)
                {
                    form.cmbTenKH.Text = KhachHang.Rows[0]["TenKH"].ToString();
                }
            }                       
        }

        /*
         * Ham sinh so phieu 
         */
        public void SinhMaHoaDonBH() 
        {
            try
            {
                string query = "SELECT top 1 MaHD FROM HoaDonBanHang ORDER BY len(MaHD) desc, MaHD desc";
                DataTable HoaDon = Database.query(query);
                string MaHD = prefixHDBH;
                if (HoaDon.Rows.Count > 0)
                {
                    MaHD += (Int64.Parse(HoaDon.Rows[0]["MaHD"].ToString().Substring(prefixHDBH.Length)) + 1).ToString();
                }
                else
                    MaHD += "0";
                form.txtSoPhieu.Text = MaHD;
            }
            catch (Exception e) 
            { 
            
            }
        }

        /*
         * Kiem tra xem SoHoaDon nhap o form So Phieu co trong CSDL hay khong
         */
        public DataTable KiemTraHoaDonTrongCSDL()         
        {            
            // Lay MaKH, MaNV, NgayXuat 
            string query = "SELECT MaKH, MaNV, NgayXuat FROM HoaDonBanHang WHERE MaHD = '" + form.txtSoPhieu.Text + "'";
            DataTable HoaDon = Database.query(query);

            return HoaDon;
        }

        /*
         * Cap nhat cac group box theo HoaDon
         */
        public void UpdateGroupBox(DataTable HoaDon)
        {
            string MaKH = HoaDon.Rows[0]["MaKH"].ToString();
            string MaNV = HoaDon.Rows[0]["MaNV"].ToString();
            string NgayXuat = HoaDon.Rows[0]["NgayXuat"].ToString();

            // Set MaKH
            form.cmbMaKH.Items.Clear();
            form.cmbMaKH.Items.Add(MaKH);
            form.cmbMaKH.Text = form.cmbMaKH.Items[0].ToString();
            UpdateTheoMaKH(true);

            // Set MaNV
            form.txtMaNhanVien.Text = MaNV;

            // Set NgayXuat
            form.dateNgayXuat.Text = NgayXuat;
        }

        /*
         * Them mot mau hang vao Data Grid View 
         */
        public static void ThemMauHangVaoDataGridView(string maMau, DataGridView dtg)
        {            
            // Lay DS cac SanPham Trong Mau
            String query = "SELECT MaSPDatHang FROM MauHang_SanPhamDatHang WHERE MaMau = '" + maMau + "'";
            DataTable result = Database.query(query);
            if (result.Rows.Count > 0)             
            {
                // Lay LoaiPhucHinh
                query = "SELECT LoaiPhucHinh FROM MauHang WHERE MaMau = '" + maMau + "'";
                DataTable LoaiPhucHinh = Database.query(query);
                string loaiPhucHinh = LoaiPhucHinh.Rows[0]["LoaiPhucHinh"].ToString();
                
                // Ma Mau va Loai Phuc Hinh la nhu nhau cho moi o
                object[] cells = new object[13];
                cells[msMauIndex] = maMau;
                cells[loaiPhucHinhIndex] = loaiPhucHinh;

                int countSPInMau = 0;  // so hang trong mot mau
                foreach (DataRow tmpRow in result.Rows)
                {
                    // Chi co san pham dau tien trong mau moi co maMau, loaiPhucHinh
                    if (countSPInMau > 0)
                    {
                        for (int i = 0; i < 13; i++)
                            cells[i] = "";
                    }

                    // Xac dinh o thu tu
                    cells[ttIndex] = dtg.Rows.Count;

                    // Them o maSPDatHang
                    string maSPDatHang = tmpRow["MaSPDatHang"].ToString();
                    cells[maSPDatHangIndex] = maSPDatHang;
                    
                    // Lay MaSP, MaVLC, MaVLP, SoLuongVLC, SoLuongVLP
                    query = "SELECT ThaoTac, MaSP, MaVLC, MaVLP, SoLuongVLC, SoLuongVLP FROM SanPhamDatHang WHERE MaSPDatHang = '" + maSPDatHang + "'";
                    DataRow spDatHang = Database.query(query).Rows[0];                                        
                    
                    // Lay thao tac SP
                    string thaoTac = spDatHang["ThaoTac"].ToString();
                    
                    bool isTinhTien = false;
                    if (thaoTac != null && thaoTac != "")
                    {
                        string loaiThaoTac = thaoTac.Substring(0, 1);
                        if (loaiThaoTac == "1")
                            isTinhTien = true;
                        else
                            isTinhTien = false;
                    }

                    // Lay Ten San Pham va DVT VLC
                    query = "SELECT TenSP, DVT FROM SanPham WHERE MaSP = '" + spDatHang["MaSP"] + "'";
                    DataRow sanPham = Database.query(query).Rows[0];
                    cells[tenSPIndex] = sanPham["TenSP"];
                    cells[dvtIndex] = sanPham["DVT"];

                    // Thong so VLC
                    cells[vlcIndex] = BHCNModel.LayTenVLC(spDatHang["MaVLC"].ToString());   
                    cells[soLuongIndex] = spDatHang["SoLuongVLC"];
                    cells[tienVLCIndex] = "";
                    if (isTinhTien && cells[vlcIndex] != "")
                    {
                        cells[tienVLCIndex] = BHCNModel.TinhTienVLC(spDatHang["MaSP"].ToString(), spDatHang["MaVLC"].ToString(), cells[soLuongIndex].ToString());
                    }
                    

                    // Thong so VLP                    
                    DataTable vlp = BHCNModel.LayThongTinVLP(spDatHang["MaVLP"].ToString());
                    cells[vlpIndex] = "";
                    cells[dvtVLPIndex] = "";
                    if (vlp.Rows.Count > 0)
                    {
                        cells[vlpIndex] = vlp.Rows[0]["TenVL"];
                        cells[dvtVLPIndex] = vlp.Rows[0]["DVT"];
                    }
                    cells[soLuongVLPIndex] = spDatHang["SoLuongVLP"];
                    cells[tienVLPIndex] = "";
                    if (isTinhTien && cells[vlpIndex] != "")
                    {
                        cells[tienVLPIndex] = BHCNModel.TinhTienVLP(spDatHang["MaVLP"].ToString(), cells[soLuongVLPIndex].ToString());
                    }


                    // Them cot vao data grid view
                    dtg.Rows.Add(cells);
                    
                    // Tang so hang trong mau len mot
                    countSPInMau++;
                }
            }
        }


        /*
         * Cap nhat cac DataGridView theo Ma Hoa Don
         */
        public void UpdateDataGridView(string MaHD)
        {
            // Lay danh sach cac mau hang trong hoa don
            string query = "SELECT MaMau FROM HoaDonBanHang_MauHang WHERE MaHD = '" + MaHD + "'";
            DataTable MaMau = Database.query(query);

            // Neu khong co mau hang nao
            if (MaMau.Rows.Count ==  0)
            {
                Database.Warning("Không có mẫu hàng nào trong hóa đơn số " + MaHD);
            }
            // Cap nhat cac mau hang vao hoa don
            else
            {
                foreach (DataRow row in MaMau.Rows) 
                {
                    string maMau = row["MaMau"].ToString();
                    ThemMauHangVaoDataGridView(maMau, form.dtgNoiDungXuatKho);
                }
            }
        }


        /*
         * Ham Tim Theo So Phieu
         */
        public void TimTheoSoPhieu()         
        {
            
            DataTable HoaDon = KiemTraHoaDonTrongCSDL();
            // Khong tim thay hoa don trong CSDL                    
            if (HoaDon.Rows.Count == 0)
            {
                Database.Warning("Không có hóa đơn số " + form.txtSoPhieu.Text + " trong CSDL");
            }
            // Tim thay hoa don
            else 
            {
                // Cap nhat cac group box o tren theo HoaDon
                UpdateGroupBox(HoaDon);

                // Cap nhat DataGridView theo maHoaDon
                UpdateDataGridView(form.txtSoPhieu.Text);

                // Sinh dong tinh tong tien
                SinhDongTinhTongTien();
            }                            
        }

        /*
         * Tim cac mau cua tra, nhung da luu kho cua khach hang co ma maKH
         */
        public DataTable TimMauChuaTraCuaKhach(string maKH)
        {
            string query = "SELECT MaMau FROM MauHang WHERE TrangThai = " + TrangThaiMauLamXongChuaTra +  " and MaKH = '" + maKH + "'";
            return Database.query(query);            
        }

        /*
         * Ham Tim Theo MaKH
         */
        public void TimTheoMaKH(string maKH)
        {
            // Tim tat ca cac mau da nhap kho nhung chua tra cua khach
            DataTable MaMau = TimMauChuaTraCuaKhach(maKH);
            
            // Neu khong co
            if (MaMau.Rows.Count == 0)
            {
                Database.Warning("Khách hàng mã " + maKH + " không có bất cứ mẫu hàng nào chưa trả có trong kho");
            }
            else
            {
                // Duyet lan luot tung mau hang, cho vao trong dataGridView
                foreach (DataRow row in MaMau.Rows)
                {
                    string maMau = row["MaMau"].ToString();
                    ThemMauHangVaoDataGridView(maMau, form.dtgNoiDungXuatKho);
                }
            }    
        }


        /*
         * Kiem tra xem maNV co trong CSDL hay khong
         */
        public bool KiemTraNhanVien(string maNV)
        {
            string query = "SELECT * FROM NhanVien WHERE MaNV = '" + maNV + "'";
            DataTable result = Database.query(query);
            if (result.Rows.Count > 0)
                return true;
            else
                return false;
        }
        

        /*
         * Them Mau maMau vao HoaDon maHD
         */
        public void ThemMauVaoHoaDon(string maMau, string maHD)
        {
            // cap nhat trang thai cua Mau la da tra roi
            string query = "UPDATE MauHang SET TrangThai = " + TrangThaiMauDaTra + " WHERE MaMau = '" + maMau + "'";
            Database.query(query);


            // Them Mau vao Hoa Don
            query = "INSERT HoaDonBanHang_MauHang VALUES(" + 
                           "'" + maHD + "', " +
                           "'" + maMau +"'" +  
                           ")";
            Database.query(query);
        }

        /*
         * Ham Kiem tra tat ca cac hang duoc chon va them mau vao hoa don
         */
        public void XuatHoaDon(string maHD)
        {    
            // Tao HoaDon moi trong CSDL

            string maKH = form.cmbMaKH.Text;
            string maNV = form.txtMaNhanVien.Text;
            string ngayXuat = form.dateNgayXuat.Text;
            string query = "INSERT HoaDonBanHang VALUES(" + 
                           "'" + maHD + "', " + 
                           "'" + maKH + "', " + 
                           "'" + maNV + "', " + 
                           "'" + ngayXuat + "'" + 
                           ")";
            Database.query(query);


            foreach (DataGridViewRow row in form.dtgNoiDungXuatKho.SelectedRows)
            {
                string maMau = row.Cells[msMauIndex].Value.ToString();
                if (maMau != "")
                    ThemMauVaoHoaDon(maMau, maHD);
            }
        }


        /*
         *  Sinh dong tinh tong tien
         */
        public void SinhDongTinhTongTien()
        {
            // Tinh TongTien, TienVLC, TienVLP cua hoa don            
            long TongTienVLC = 0;
            long TongTienVLP = 0;

            foreach (DataGridViewRow row in form.dtgNoiDungXuatKho.Rows)
            {
                if (row.Cells[tienVLCIndex].Value.ToString() != "")
                {
                    TongTienVLC += Int64.Parse(row.Cells[tienVLCIndex].Value.ToString());
                }
                if (row.Cells[tienVLPIndex].Value.ToString() != "")
                {
                    TongTienVLP += Int64.Parse(row.Cells[tienVLPIndex].Value.ToString());
                }
            }
            


            // Them 3 hang vao phieu
            object[] cells = new object[13];
            for (int i = 0; i < 13; i++)
                cells[i] = "";

            form.dtgNoiDungXuatKho.Rows.Add(cells);            
            
            // Them Truong tong tien vao hang cuoi                        
            cells[loaiPhucHinhIndex] = "Tổng Tiền";
            
            // Them truong TongTienVLC            
            cells[tienVLCIndex] = TongTienVLC.ToString();

            // Them truong TongTienVLP            
            cells[tienVLPIndex] = TongTienVLP.ToString();
            form.dtgNoiDungXuatKho.Rows.Add(cells);

            DataGridViewRow lastRow = form.dtgNoiDungXuatKho.Rows[form.dtgNoiDungXuatKho.Rows.Count - 1];
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("Microsoft San Serif", 8, FontStyle.Bold);
            
            lastRow.Cells[loaiPhucHinhIndex].Style = style;
            lastRow.Cells[tienVLCIndex].Style = style;
            lastRow.Cells[tienVLPIndex].Style = style;

        }
    }
}
