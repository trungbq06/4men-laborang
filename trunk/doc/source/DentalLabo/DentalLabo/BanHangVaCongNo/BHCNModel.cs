using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DentalLabo.BanHangVaCongNo
{
    class BHCNModel
    {
        /**
         * Update combo box theo query va ten truong
         */
        public static void UpdateComboBoxByQuery(ComboBox cmb, String query, String field){
            DataTable result = Database.query(query);
            cmb.Items.Clear();
            foreach (DataRow row in result.Rows) {
                cmb.Items.Add(row[field]);
            }
            if (result.Rows.Count > 0)
                cmb.SelectedIndex = 0;
            else {                
                cmb.Text = "";
            }
        }

        /*
         * Lay Ten VLC tu maVLC
         */
        public static string LayTenVLC(String maVLC)
        {
            String query = "SELECT TenVL FROM VatLieuChinh WHERE MaVL = '" + maVLC + "'";
            return Database.query(query).Rows[0]["TenVL"].ToString();
        }

        /*
         * Lay Ten VLP tu maVLP
         */
        public static DataRow LayThongTinVLP(String maVLP)
        {
            String query = "SELECT TenVL, DVT FROM VatLieuPhu WHERE MaVL = '" + maVLP + "'";
            return Database.query(query).Rows[0];
        }


        /*
         * Tinh tien so vat lieu chinh
         */
        public static string TinhTienVLC(string maSP, string maVLC, string soLuong)
        {
            //Database.debug = true;

            string query = "SELECT DonGia FROM BangGia WHERE MaSP = '" + maSP + "' AND MaVL = '" + maVLC + "' ";
            DataTable result = Database.query(query);

            string retval = "";
            if (result.Rows.Count > 0)
            {
                long gia = Int64.Parse(result.Rows[0]["DonGia"].ToString()) * Int64.Parse(soLuong);
                retval = gia.ToString();
            }

            //Database.debug = false;

            return retval;
        }

        /*
         * Tinh tien so vat lieu phu
         */
        public static string TinhTienVLP(string maVLP, string soLuong)
        {
            //Database.debug = true;

            string retval = "";
            string query = "SELECT DonGia FROM VatLieuPhu WHERE MaVL = '" + maVLP + "'";
            DataTable result = Database.query(query);
            if (result.Rows.Count > 0)
            {
                long gia = Int64.Parse(result.Rows[0]["DonGia"].ToString()) * Int64.Parse(soLuong);
                retval = gia.ToString();
            }

            //Database.debug = false;

            return retval;
        }

        /*
         * Tinh tong tien mot mau hang
         */
        public static string TongTienHoaDon(string maHD)
        {            
            string query = "SELECT MaMau FROM HoaDonBanHang_MauHang WHERE MaHD = '" + maHD + "'";
            DataTable MaMaus = Database.query(query);

            long TongTien = 0;
            for (int i = 0; i < MaMaus.Rows.Count; i++)
            {
                string tienMau = BHCNModel.TinhTongTien(MaMaus.Rows[i]["MaMau"].ToString());
                if (tienMau != "")
                    TongTien += Int64.Parse(tienMau);
            }

            return TongTien.ToString();
        }

        /*
         * Kiem tra MaHoaDon da co trong CSDL hay chua
         * Neu HD da co trong CSDL tra ve false
         * Neu khong tra ve true
         */
        public static bool KiemTraMaHD(string maHD)
        {
            string query = "SELECT * FROM HoaDonBanHang WHERE MaHD = '" + maHD + "'";
            DataTable result = Database.query(query);
            if (result.Rows.Count > 0)
                return false;
            else
                return true;
        }

        /*
         * Lay Noi dung cong viec cua mau hang
         */
        public static string LayNoiDungCongViec(string maMau)
        {
            string query = "SELECT TenSP FROM SanPham " +
                        "WHERE MaSP in (" +
                        "   SELECT MaSP FROM SanPhamDatHang " +
                        "   WHERE MaSPDatHang in (" +
                        "       SELECT MaSPDatHang FROM MauHang_SanPhamDatHang WHERE maMau = '" + maMau + "'" +
                        "   )" +
                        ")";
            DataTable result = Database.query(query);
            string retval = "";
            int countSP = 0;
            foreach (DataRow row in result.Rows)
            {
                if (countSP > 0)
                    retval += ", ";
                retval += row["TenSP"];
                countSP++;
            }

            return retval;
        }


        /**
         * Tinh Tien cho mot mau Hang
         */
        public static string TinhTongTien(string maMau)
        {
            string query = "SELECT MaSPDatHang FROM MauHang_SanPhamDatHang WHERE MaMau = '" + maMau + "'";
            DataTable spDatHangs = Database.query(query);

            long TongTien = 0;
            foreach (DataRow row in spDatHangs.Rows)
            {
                query = "SELECT MaSP, MaVLC, MaVLP, SoLuongVLC, SoLuongVLP FROM SanPhamDatHang WHERE MaSPDatHang = '" + row["MaSPDatHang"] + "'";
                DataRow spDatHang = Database.query(query).Rows[0];
                string TienVLC = BHCNModel.TinhTienVLC(spDatHang["MaSP"].ToString(), spDatHang["MaVLC"].ToString(), spDatHang["SoLuongVLC"].ToString());
                string TienVLP = BHCNModel.TinhTienVLP(spDatHang["MaVLP"].ToString(), spDatHang["SoLuongVLP"].ToString());

                if (TienVLP == "")
                    TienVLP = "0";
                if (TienVLC == "")
                    TienVLC = "0";

                TongTien += Int64.Parse(TienVLC) + Int64.Parse(TienVLP);
            }

            return TongTien.ToString();
        }

        /*
         * Tim cac HD cua KH co maKH trong thoi gian tu beginDate -> endDate
         */
        public static DataTable TimCacHDCuaKH(string maKH, string beginDate, string endDate)
        {            
            string query = "SELECT MaHD, NgayXuat FROM HoaDonBanHang " +
                           "WHERE MaKH = '" + maKH + "' " +
                           "      AND datediff(day, getdate(), '" + beginDate + "') <= 0 " +
                           "      AND datediff(day, getdate(), '" + endDate + "') >= 0";
            DataTable MaHDs = Database.query(query);
            return MaHDs;
        }

        /*
         * Tim cac ma Thanh Toan cua KH co maKH trong thoi gian tu beginDate -> endDate
         */
        public static DataTable TimCacTTCuaKH(string maKH, string beginDate, string endDate)
        {
            string query = "SELECT NgayTT, SoTien FROM KhoanThanhToan " +
                           "WHERE MaKH = '" + maKH + "' " +
                           "      AND datediff(day, getdate(), '" + beginDate + "') <= 0 " +
                           "      AND datediff(day, getdate(), '" + endDate + "') >= 0";
            DataTable MaTTs = Database.query(query);
            return MaTTs;
        }

        /*
         * Lay du no trong thang cua khach hang
         */
        public static string LayDuNoThang(string maKH, string thang, string nam)
        { 
            string query = "SELECT SoTienNo FROM DuNoKhachHang WHERE MaKH = '" + maKH + "' AND Thang = " + thang + " AND Nam = " + nam;
            
            DataTable result = Database.query(query);

            // Neu da co du no trong CSDL
            if (result.Rows.Count > 0)
                return result.Rows[0]["SoTienNo"].ToString();
            else
            {
                int thangTruoc = Int32.Parse(thang) - 1;
                int namTruoc = Int32.Parse(nam);
                if (thangTruoc <= 0)
                {
                    thangTruoc = 12;
                    namTruoc = Int32.Parse(nam) - 1;
                }

                // No Thang Truoc
                string noThangTruoc = LayDuNoThang(maKH, thangTruoc.ToString(), namTruoc.ToString());

                string ngayDauThang = "1/" + thang + "/" + nam;
                string ngayCuoiThang = NgayCuoiThang(thang, nam);
                
                // No Trong Thang
                string noTrongThang = LayTongTienTrongKhoang(maKH, ngayDauThang, ngayCuoiThang);

                long duNo = Int64.Parse(noThangTruoc) + Int64.Parse(noTrongThang);

                // Insert vao bang luon du no thang nay de lan sau khong phai tinh lai
                query = "INSERT DuNoKhachHang VALUES(" +
                        "'" + maKH + "', " + 
                        thang + ", " + nam + ", " +
                        "'" + duNo.ToString() + "'" + 
                        ")";
                Database.query(query);

                return duNo.ToString();
            }            
        }

        public static string DuNoDenNgay(string maKH, string beginDate)
        {
            long TongNo = 0;

            string[] date = beginDate.Split('/');

            int thangTruoc = Int32.Parse(date[0]) - 1;
            int namTruoc = Int32.Parse(date[2]);
            int ngayTruoc = Int32.Parse(date[1]) - 1;
            if (thangTruoc <= 0)
            {
                thangTruoc = 12;
                namTruoc = namTruoc - 1;
            }
            
            string DuNoThangTruoc = LayDuNoThang(maKH, thangTruoc.ToString(), namTruoc.ToString());

            TongNo += Int64.Parse(DuNoThangTruoc);

            // Neu khong phai ngay dau tien trong thang
            if (ngayTruoc > 0)
            { 
                string ngayDauThangNay = date[0] + "/" + "1" + "/" + date[2];
                string ngayTruocNgayBegin = date[0] + "/" + ngayTruoc + "/" + date[2];
                string DuNoTrongThang = LayTongTienTrongKhoang(maKH, ngayDauThangNay, ngayTruocNgayBegin);

                TongNo += Int64.Parse(DuNoTrongThang);                
            }

            return TongNo.ToString();
        }

        public static string NgayCuoiThang(string thang, string nam)
        {
            int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (DateTime.IsLeapYear(Int32.Parse(nam)))
                days[2] = 29;

            string retval = days[Int32.Parse(thang)] + "/" + thang + "/" + nam;
            return retval;
        }

        /*
         * Tinh Tong Tien No cua KH  trong khoang tu ngay den ngay
         */
        public static string LayTongTienTrongKhoang(string maKH, string beginDate, string endDate)
        {
            string tongTienHD = TongTienHDTrongKhoang(maKH, beginDate, endDate);
            string tongTienTT = TongTienTTTrongKhoang(maKH, beginDate, endDate);
            string tongTienGT = TongTienGTTRongKhoang(maKH, beginDate, endDate);

            long TongTien = 0;

            TongTien += Int64.Parse(tongTienHD) - Int64.Parse(tongTienTT) - Int64.Parse(tongTienGT);
            return TongTien.ToString();
        }

        /*
         * Tinh tong tien HD cua KH trong khoang tu ngay den ngay
         */
        public static string TongTienHDTrongKhoang(string maKH, string beginDate, string endDate)
        {
            DataTable MaHDs = TimCacHDCuaKH(maKH, beginDate, endDate);

            long TongTien = 0;
            foreach (DataRow row in MaHDs.Rows)
            {
                // Tinh tong tien mot HD
                long TienHD = 0;

                string maHD = row["MaHD"].ToString();
                string query = "SELECT MaMau FROM HoaDonBanHang_MauHang WHERE MaHD = '" + maHD + "'";
                DataTable MaMaus = Database.query(query);
                foreach (DataRow mau in MaMaus.Rows)
                {
                    TienHD += Int64.Parse(TinhTongTien(mau["MaMau"].ToString()));
                }

                TongTien += TienHD;
            }

            return TongTien.ToString();
        }

        /*
         * Tinh Tong Tien KH da thanh toan trong khoang tu ngay den ngay
         */
        public static string TongTienTTTrongKhoang(string maKH, string beginDate, string endDate)
        {
            long TongTien = 0;
            DataTable MaTTs = TimCacTTCuaKH(maKH, beginDate, endDate);

            foreach (DataRow row in MaTTs.Rows)
            {
                string TienTT = row["SoTien"].ToString();

                if (TienTT != "")
                    TongTien += Int64.Parse(TienTT);
            }

            return TongTien.ToString();
        }


        /*
         * Tinh tong tien Giam tru cho khach hang trong khoang tu ngay den ngay
         */
        public static string TongTienGTTRongKhoang(string maKH, string beginDate, string endDate)
        {
            long TongTien = 0;
            DataTable MaHDs = TimCacHDCuaKH(maKH, beginDate, endDate);

            foreach (DataRow row in MaHDs.Rows)
            {
                string maHD = row["MaHD"].ToString();

                long TienGTHD = 0;

                string query = "SELECT ThanhTien FROM HoaDonBanHang_NoiDungGiamTru WHERE MaHD = '" + maHD + "'";
                DataTable ThanhTiens = Database.query(query);
                foreach (DataRow thanhTien in ThanhTiens.Rows)
                {
                    if (thanhTien["ThanhTien"].ToString() != "")
                        TienGTHD += Int64.Parse(thanhTien["ThanhTien"].ToString());
                }

                TongTien += TienGTHD;
            }

            return TongTien.ToString();
        }
    }
}
