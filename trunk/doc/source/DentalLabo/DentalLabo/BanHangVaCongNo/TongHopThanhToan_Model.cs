using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DentalLabo.Nhap_kho_va_ban_hang;

namespace DentalLabo.BanHangVaCongNo
{
    public class TongHopThanhToan_Model
    {
        frmPhieuTT form;
        public static int ttIndex = 0;
        public static int ngayNhanIndex = 1;
        public static int ngayXuatIndex = 2;
        public static int soHDIndex = 3;
        public static int msMauIndex = 4;
        public static int noiDungIndex = 5;
        public static int thanhTienIndex = 6;
        public static int loaiIndex = 7;

        public static string loaiMauHang = "0";
        public static string loaiThanhToan = "1";
        public static string loaiGiamTru = "2";

        public TongHopThanhToan_Model(frmPhieuTT form)
        {
            this.form = form;
        }

        #region GroupBox Tren
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
        public void UpdateTheoMaKH(bool isUpdateTenKH)
        {
            string filter = "DiaChi";
            if (isUpdateTenKH)
                filter += ", TenKH";
            string query = "SELECT " + filter + " FROM KhachHang WHERE MaKH = '" + form.cmbMaKH.Text + "'";
            DataTable KhachHang = Database.query(query);
            if (KhachHang.Rows.Count > 0)
            {
                form.txtDiaChi.Text = KhachHang.Rows[0]["DiaChi"].ToString();

                if (isUpdateTenKH)
                {
                    form.cmbTenKH.Text = KhachHang.Rows[0]["TenKH"].ToString();
                }
            }
        }
        #endregion

        public void ThemCacHoaDon(string maKH, string beginDate, string endDate)
        {
            DataTable MaHDs = BHCNModel.TimCacHDCuaKH(maKH, beginDate, endDate);
            for (int i = 0; i < MaHDs.Rows.Count; i++)
            {
                string maHD = MaHDs.Rows[i]["MaHD"].ToString();

                // Lay NgayXuat HD
                string query = "SELECT NgayXuat FROM HoaDonBanHang WHERE MaHD = '" + maHD + "'";
                string ngayXuat = Database.query(query).Rows[0]["NgayXuat"].ToString();
                ngayXuat = ngayXuat.Substring(0, ngayXuat.IndexOf(' '));

                // Lay cau mau trong HD
                query = "SELECT MaMau FROM HoaDonBanHang_MauHang WHERE MaHD = '" + maHD + "'";
                DataTable MaMaus = Database.query(query);
                for (int ii = 0; ii < MaMaus.Rows.Count; ii++)
                {
                    string maMau = MaMaus.Rows[ii]["MaMau"].ToString();
                    if (ii == 0)
                        ThemMauVaoBang(maMau, ngayXuat, maHD);
                    else
                        ThemMauVaoBang(maMau, "", "");
                }
            }
        }

        private void ThemMauVaoBang(string maMau, string ngayXuat, string maHD)
        {
            object[] cells = new object[8];
            for (int i = 0; i < 8; i++) 
                cells[i] = "";
            cells[loaiIndex] = loaiMauHang;

            // Lay NgayNhanMau
            string query = "SELECT NgayNhan FROM MauHang WHERE MaMau = '" + maMau + "'";
            string ngayNhan = Database.query(query).Rows[0]["NgayNhan"].ToString();
            ngayNhan = ngayNhan.Substring(0, ngayNhan.IndexOf(' '));

            // Lay Noi dung cong viec
            string noiDung = BHCNModel.LayNoiDungCongViec(maMau);

            // Lay Tien cua mau
            string thanhTien = BHCNModel.TinhTongTien(maMau);

            // Gan cho cac cells
            cells[ttIndex] = form.dtgChiTietCongNoKH.Rows.Count;
            cells[msMauIndex] = maMau;
            cells[ngayNhanIndex] = ngayNhan;
            cells[ngayXuatIndex] = ngayXuat;
            cells[soHDIndex] = maHD;
            cells[noiDungIndex] = noiDung;
            cells[thanhTienIndex] = thanhTien;

            form.dtgChiTietCongNoKH.Rows.Add(cells);
        }


        public void ThemDongColor(string message)
        {
            object[] cells = new object[8];
            for (int i = 0; i < 8; i++)
                cells[i] = "";

            form.dtgChiTietCongNoKH.Rows.Add(cells);

            DataGridViewRow addedRow = form.dtgChiTietCongNoKH.Rows[form.dtgChiTietCongNoKH.Rows.Count - 1];
            
            /**
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = System.Drawing.Color.Yellow;

            for (int i = 0; i < 8; i++)
            {
                addedRow.Cells[i].Style = style;    
            }
            /**/

            addedRow.Cells[msMauIndex].Value = message;
        }

        public string SinhDongTinhTongTien(string loai)
        {
            long TongTien = 0;
            foreach (DataGridViewRow row in form.dtgChiTietCongNoKH.Rows)
            {
                if (row.Cells[loaiIndex].Value.ToString() == loai && row.Cells[thanhTienIndex].Value.ToString() != "")
                {
                    TongTien += Int64.Parse(row.Cells[thanhTienIndex].Value.ToString());
                }
            }

            ThemDong("Tống số", TongTien.ToString());

            return TongTien.ToString();
        }

        public void ThemDong(string truong, string value)
        {
            object[] cells = new object[8];
            for (int i = 0; i < 8; i++)
                cells[i] = "";
            cells[loaiIndex] = "-1";
            cells[noiDungIndex] = truong;
            cells[thanhTienIndex] = value;

            form.dtgChiTietCongNoKH.Rows.Add(cells);
        }


        public void ThemCacThanhToan(string maKH, string beginDate, string endDate)
        {
            object[] cells = new object[8];
            for (int i = 0; i < 8; i++)
                cells[i] = "";
            cells[loaiIndex] = loaiThanhToan;

            int countTT = 0;
            DataTable MaTTs = BHCNModel.TimCacTTCuaKH(maKH, beginDate, endDate);
            foreach (DataRow row in MaTTs.Rows)
            {
                cells[ttIndex] = countTT.ToString();
                cells[ngayXuatIndex] = row["NgayTT"].ToString();
                cells[thanhTienIndex] = row["SoTien"].ToString();

                form.dtgChiTietCongNoKH.Rows.Add(cells);

                countTT++;
            }
        }

        public int countGT = 0;
        public void ThemCacGiamTru(string maKH, string beginDate, string endDate)
        {
            DataTable MaHDs = BHCNModel.TimCacHDCuaKH(maKH, beginDate, endDate);
            for (int i = 0; i < MaHDs.Rows.Count; i++)
            {
                string MaHD = MaHDs.Rows[i]["MaHD"].ToString();
                string ngayXuat = MaHDs.Rows[i]["NgayXuat"].ToString();
                ThemGiamTru(MaHD, ngayXuat);
            }
        }

        private void ThemGiamTru(string maHD, string ngayXuat)
        {
            object[] cells = new object[8];
            for (int i = 0; i < 8; i++)
                cells[i] = "";
            cells[loaiIndex] = loaiGiamTru;

            // Lay cac noi dung giam tru trong Hoa don
            string query = "SELECT MaGiamTru, ThanhTien FROM HoaDonBanHang_NoiDungGiamTru WHERE MaHD = '" + maHD + "'";
            DataTable GiamTrus = Database.query(query);

            for (int i = 0; i < GiamTrus.Rows.Count; i++)
            { 
                string maGiamTru = GiamTrus.Rows[i]["MaGiamTru"].ToString();
                query = "SELECT NoiDung FROM NoiDungGiamTru WHERE MaGiamTru = '" + maGiamTru + "'";
                string noiDung = Database.query(query).Rows[0]["NoiDung"].ToString();

                cells[ttIndex] = countGT.ToString();
                cells[noiDungIndex] = noiDung;
                cells[msMauIndex] = maGiamTru;
                cells[soHDIndex] = maHD;
                cells[ngayXuatIndex] = ngayXuatIndex;
                cells[thanhTienIndex] = GiamTrus.Rows[i]["ThanhTien"];

                form.dtgChiTietCongNoKH.Rows.Add(cells);

                countGT++;
            }
        }

    }
}
