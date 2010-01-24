using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DentalLabo.Nhap_kho_va_ban_hang;

namespace DentalLabo.BanHangVaCongNo
{
    public class HoaDonBanHang_Model
    {
        frmHoaDonBanHang form;
        public long TongTien = 0;

        public static int ttIndex = 0;
        public static int msMauIndex = 1;
        public static int ngayNhanMauIndex = 2;
        public static int noiDungCongViecIndex = 3;
        public static int thanhTienIndex = 4;
        public static int loaiIndex = 5;

        public HoaDonBanHang_Model(frmHoaDonBanHang form)
        {
            this.form = form;
        }
        
        /*
         * Ham cap nhat cac truong dia chi, so dien thoai, nguoi dai dien theo MaKH
         */
        public void UpdateTheoMaKH(string maKH)
        {
            string filter = "DiaChi, MaSoThue, NguoiDaiDien, TenKH";            
            string query = "SELECT " + filter + " FROM KhachHang WHERE MaKH = '" + maKH + "'";
            DataTable KhachHang = Database.query(query);
            if (KhachHang.Rows.Count > 0)
            {
                form.txtDiaChi.Text = KhachHang.Rows[0]["DiaChi"].ToString();
                form.txtMaSoThue.Text = KhachHang.Rows[0]["MaSoThue"].ToString();
                form.txtNguoiDaiDien.Text = KhachHang.Rows[0]["NguoiDaiDien"].ToString();                

                //form.cmbTenKH.Items.Clear();
                //form.cmbTenKH.Items.Add(KhachHang.Rows[0]["TenKH"].ToString());
                form.cmbTenKH.Text = KhachHang.Rows[0]["TenKH"].ToString();

                //form.cmbMaKH.Items.Clear();
                //form.cmbMaKH.Items.Add(maKH);
                form.cmbMaKH.Text = maKH;
            }
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
         * Update groupbox
         */
        public void UpdateGroupBox(string maHD)
        {
            string query = "SELECT MaNV, MaKH, NgayXuat FROM HoaDonBanHang WHERE MaHD = '" + maHD + "'";
            DataTable result = Database.query(query);

            if (result.Rows.Count > 0)
            {                
                form.txtMaNhanVien.Text = result.Rows[0]["MaNV"].ToString();
                string ngayXuat = result.Rows[0]["NgayXuat"].ToString();
                form.dateNgayXuat.Text = ngayXuat.Substring(0, ngayXuat.IndexOf(' '));
                UpdateTheoMaKH(result.Rows[0]["MaKH"].ToString());
            }            
        }

        /*
         * Cap nhat datagridview
         */
        public void UpdateDataGridView(string MaHD)
        {
            ThemCacMauHang(MaHD);
            string TongTien = TongTienCacMau();

            ThemCacGiamTru(MaHD);
            string TongGiamTru = TongTienGiamTru();


            // Them dong tong ket
            long TienThanhToan = Int64.Parse(TongTien) - Int64.Parse(TongGiamTru);
            
            object[] cells = new object[6];
            for (int i = 0; i < 6; i++)
                cells[i] = "";
            form.dtgHoaDonBanHang.Rows.Add(cells);

            cells[noiDungCongViecIndex] = "Tổng giá trị thanh toán";
            cells[thanhTienIndex] = TienThanhToan.ToString();
            form.dtgHoaDonBanHang.Rows.Add(cells);

            this.TongTien = TienThanhToan;
        }

        /*
         * Sinh Them dong tinh tong tien mau
         */
        public string TongTienCacMau()
        {
            long TongTien = 0;
            int countMau = 0;
            foreach (DataGridViewRow row in form.dtgHoaDonBanHang.Rows)
            {
                // Neu la MauHang
                if (row.Cells[loaiIndex].Value.ToString() == "0")
                {
                    countMau++;
                    if (row.Cells[thanhTienIndex].Value.ToString() != "")
                        TongTien += Int64.Parse(row.Cells[thanhTienIndex].Value.ToString());
                }
            }

            if (countMau > 0)
            {
                object[] cells = new object[6];
                for (int i = 0; i < 6; i++)
                    cells[i] = "";
                form.dtgHoaDonBanHang.Rows.Add(cells);

                cells[noiDungCongViecIndex] = "Tổng số";
                cells[thanhTienIndex] = TongTien.ToString();
                form.dtgHoaDonBanHang.Rows.Add(cells);
            }

            return TongTien.ToString();
        }

        /*
         * Sinh Them dong tinh tong tien mau
         */
        public string TongTienGiamTru()
        {
            long TongTien = 0;
            int countGiamTru = 0;
            foreach (DataGridViewRow row in form.dtgHoaDonBanHang.Rows)
            {
                // Neu la Giam Tru
                if (row.Cells[loaiIndex].Value.ToString() == "1")
                {
                    countGiamTru++;
                    if (row.Cells[thanhTienIndex].Value.ToString() != "")
                    {
                        TongTien += Int64.Parse(row.Cells[thanhTienIndex].Value.ToString());
                    }
                }
            }

            if (countGiamTru > 0)
            {
                object[] cells = new object[6];
                for (int i = 0; i < 6; i++)
                    cells[i] = "";
                form.dtgHoaDonBanHang.Rows.Add(cells);

                cells[noiDungCongViecIndex] = "Tổng số";
                cells[thanhTienIndex] = TongTien.ToString();
                form.dtgHoaDonBanHang.Rows.Add(cells);
            }

            return TongTien.ToString();
        }

        /*
         * Them cac giam tru
         */
        public void ThemCacGiamTru(string MaHD)
        {
            string query = "SELECT NoiDung, ThanhTien FROM NoiDungGiamTru WHERE MaHD = '" + MaHD + "'";
            DataTable result = Database.query(query);
            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    object[] cells = new object[6];
                    for (int i=0; i < 6; i++)
                        cells[i] = "";

                    cells[loaiIndex] = "1";

                    cells[thanhTienIndex] = row["ThanhTien"].ToString();                    
                    cells[noiDungCongViecIndex] = row["NoiDung"].ToString();

                    form.dtgHoaDonBanHang.Rows.Add(cells);
                }
            }
        }

        /*
         * Them cac mau hang vao dtg
         */
        public void ThemCacMauHang(string MaHD)
        {
            // Lay danh sach cac mau hang trong hoa don
            string query = "SELECT MaMau FROM HoaDonBanHang_MauHang WHERE MaHD = '" + MaHD + "'";
            DataTable MaMau = Database.query(query);

            // Neu khong co mau hang nao
            if (MaMau.Rows.Count == 0)
            {
                Database.Warning("Không có mẫu hàng nào trong hóa đơn số " + MaHD);
            }
            // Cap nhat cac mau hang vao hoa don
            else
            {
                foreach (DataRow row in MaMau.Rows)
                {
                    string maMau = row["MaMau"].ToString();
                    ThemMauHangVaoDataGridView(maMau, form.dtgHoaDonBanHang);
                }
            }
        }
        
        


        /*
         * Them Mau Hang vao Data Grid View
         */
        public void ThemMauHangVaoDataGridView(string maMau, DataGridView dtg)
        {
            // Tao ra cells de them vao dtg
            object[] cells = new object[6];

            cells[msMauIndex] = maMau;

            // Lay ra NgayNhanMau
            string query = "SELECT NgayNhan FROM MauHang WHERE MaMau = '" + maMau + "'";    
            DataTable MauHang = Database.query(query);

            string ngayNhanMau = MauHang.Rows[0]["NgayNhan"].ToString();
            cells[ngayNhanMauIndex] = ngayNhanMau.Substring(0, ngayNhanMau.IndexOf(' '));
            
            // Xac dinh loai index
            cells[loaiIndex] = "0";

            // Lay Noi dung cong viec
            cells[noiDungCongViecIndex] = BHCNModel.LayNoiDungCongViec(maMau);

            // Tinh tong tien
            cells[thanhTienIndex] = BHCNModel.TinhTongTien(maMau);

            // Lay so thu tu
            cells[ttIndex] = dtg.Rows.Count;

            // Them vao bang dtg
            dtg.Rows.Add(cells);       
        }        


        /*
         * Thanh toan tien
         */
        public void ThanhToanTien(string maKH, string soTien)
        {
            string query = "INSERT KhoanThanhToan VALUES(" + 
                           "'" + maKH + "', " +
                           "'" + form.dateNgayXuat.Text + "', " +
                           soTien +
                           ")";            
            Database.query(query);
            Database.Warning("Khách hàng " + maKH + " đã thanh toán " + soTien + " vao ngay " + form.dateNgayXuat.Text);                        
        }

        public void ThanhToanTien(string maHD)
        {
            string query = "UPDATE HoaDonBanHang SET TrangThai = '1' WHERE MaHD = '" + maHD + "'";
            Database.query(query);
        }
    }
}
