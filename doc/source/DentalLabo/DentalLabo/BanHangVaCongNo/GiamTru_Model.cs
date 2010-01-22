using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DentalLabo.Nhap_kho_va_ban_hang;


namespace DentalLabo.BanHangVaCongNo
{
    public class GiamTru_Model
    {
        frmGiamTru form;
        public static int ttIndex = 0;
        public static int msIndex = 1;
        public static int noiDungGiamTruIndex = 2;
        public static int dvtIndex = 3;
        public static int soLuongIndex = 4;
        public static int donGiaIndex = 5;
        public static int thanhTienIndex = 6;
        public static int ghiChuIndex = 7;
        public static int trangThaiIndex = 8;

        public GiamTru_Model(frmGiamTru form)
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

        /*
         * Tim kiem cac ma giam tru theo ma khach hang
         */
        public void TimTheoMaKhachHang(string maKH, string beginDate, string endDate)
        {
            DataTable MaHDs = BHCNModel.TimCacHDCuaKH(maKH, beginDate, endDate);

            if (MaHDs.Rows.Count == 0)
            {
                Database.Warning("Không có hóa đơn nào được xuất cho khách hàng trong thời gian tìm kiếm");
            }
            else
            {
                string filter = "(";
                for(int i=0; i < MaHDs.Rows.Count; i++)
                {
                    if (i > 0)
                        filter += ", ";
                    filter += MaHDs.Rows[i]["MaHD"];
                }
                filter += ")";

                // Tim cac ma giam tru da duoc ap dung
                string query = "SELECT distinct(MaGiamTru) FROM HoaDonBanHang_NoiDungGiamTru WHERE MaHD in " + filter;
                DataTable MaGiamTrus = Database.query(query);
                if (MaGiamTrus.Rows.Count == 0)
                {
                    Database.Warning("Không có loại giảm trừ nào được áp dụng cho khách hàng trong thời gian tìm kiếm");
                }
                else
                {
                    foreach (DataRow MaGiamTru in MaGiamTrus.Rows)
                    {
                        ThemGiamTruVaoBang(MaGiamTru["MaGiamTru"].ToString(), filter);
                    }
                }
            }            
        }

        /*
         * Them Giam Tru vao Bang khi tim kiem theo ma KH
         */
        public void ThemGiamTruVaoBang(string maGiamTru, string filter)
        {
            object[] cells = new object[9];
            for (int i = 0; i < 9; i++)
                cells[i] = "";

            string query = "SELECT NoiDung FROM NoiDungGiamTru WHERE MaGiamTru = '" + maGiamTru + "'";
            string noiDungGiamTru = Database.query(query).Rows[0]["NoiDung"].ToString();

            cells[ttIndex] = form.dtgChiTietCongNoKH.Rows.Count;
            cells[noiDungGiamTruIndex] = noiDungGiamTru;
            cells[msIndex] = maGiamTru;


            // Tinh tong tien duoc ap dung
            query = "SELECT ThanhTien FROM HoaDonBanHang_NoiDungGiamTru WHERE MaGiamTru = '" + maGiamTru + "' AND MaHD in " + filter;
            DataTable thanhTiens = Database.query(query);
            long tongTien = 0;
            for (int i = 0; i < thanhTiens.Rows.Count; i++)
            {
                if (thanhTiens.Rows[i]["ThanhTien"].ToString() != "")
                    tongTien += Int64.Parse(thanhTiens.Rows[i]["ThanhTien"].ToString());
            }
            cells[thanhTienIndex] = tongTien.ToString();

            form.dtgChiTietCongNoKH.Rows.Add(cells);
        }
        
        /*
         * Liet ke tat ca giam tru va cho vao bang
         */
        public void LietKeTatCaGiamTru(string maHD)
        {
            // Cap nhat theo ma KH
            string query = "SELECT MaKH FROM HoaDonBanHang WHERE MaHD = '" + maHD + "'";
            DataTable result = Database.query(query);
            form.cmbMaKH.Text = result.Rows[0]["MaKH"].ToString();
            UpdateTheoMaKH(true);

            
            // Them cac noi dung giam tru trong phieu thanh toan vao bang
            object[] cells = new object[9];
            for (int i = 0; i < 9; i++)
                cells[i] = "  ";

            /**/
            // Them hang dau
            cells[ttIndex] = form.dtgChiTietCongNoKH.Rows.Count;
            cells[msIndex] = "0";
            cells[noiDungGiamTruIndex] = "Giảm trừ % doanh số đặt hàng";
            cells[donGiaIndex] = BHCNModel.TongTienHoaDon(maHD);
            cells[dvtIndex] = "%";
            form.dtgChiTietCongNoKH.Rows.Add(cells);
            
            // Fix loi null value o cac cell
            DataGridViewRow addedRow = form.dtgChiTietCongNoKH.Rows[form.dtgChiTietCongNoKH.Rows.Count - 1];
            for (int ii = 0; ii < 9; ii++)
                if (addedRow.Cells[ii].Value == null)
                {
                    addedRow.Cells[ii] = new DataGridViewTextBoxCell();
                    addedRow.Cells[ii].Value = "";
                }
            addedRow.Cells[soLuongIndex].ReadOnly = false;   


            // Kiem tra xem hang dau da duoc ap dung chua
            query = "SELECT SoLuong, ThanhTien, GhiChu FROM HoaDonBanHang_NoiDungGiamTru WHERE MaHD = '" + maHD + "' AND MaGiamTru = '0'";
            DataTable checkHangDau = Database.query(query);
            if (checkHangDau.Rows.Count > 0)
            {
                addedRow.Cells[trangThaiIndex].Value = "Đã áp dụng";
                addedRow.Cells[soLuongIndex].Value = checkHangDau.Rows[0]["SoLuong"];
                addedRow.Cells[thanhTienIndex].Value = checkHangDau.Rows[0]["ThanhTien"];
                addedRow.Cells[ghiChuIndex].Value = checkHangDau.Rows[0]["GhiChu"];
                addedRow.ReadOnly = true;
            }

                                  
            query = "SELECT MaGiamTru, NoiDung, DVT FROM NoiDungGiamTru";
            DataTable GiamTrus = Database.query(query);
            for (int i = 0; i < GiamTrus.Rows.Count; i++)
            {
                if (GiamTrus.Rows[i]["MaGiamTru"].ToString() != "0")
                {
                    cells[ttIndex] = form.dtgChiTietCongNoKH.Rows.Count;
                    cells[msIndex] = GiamTrus.Rows[i]["MaGiamTru"];
                    cells[noiDungGiamTruIndex] = GiamTrus.Rows[i]["NoiDung"];
                    cells[dvtIndex] = GiamTrus.Rows[i]["DVT"];

                    form.dtgChiTietCongNoKH.Rows.Add(cells);

                    addedRow = form.dtgChiTietCongNoKH.Rows[form.dtgChiTietCongNoKH.Rows.Count - 1];
                    addedRow.Cells[dvtIndex].ReadOnly = false;
                    addedRow.Cells[soLuongIndex].ReadOnly = false;
                    addedRow.Cells[donGiaIndex].ReadOnly = false;

                    for (int ii = 0; ii < 9; ii++)
                        if (addedRow.Cells[ii].Value == null)
                        {
                            addedRow.Cells[ii] = new DataGridViewTextBoxCell();
                            addedRow.Cells[ii].Value = "";                            
                        }

                    // kiem tra xem noi dung giam tru nay da duoc ap dung chua
                    query = "SELECT SoLuong ,ThanhTien, GhiChu, DonGia FROM HoaDonBanHang_NoiDungGiamTru WHERE MaHD = '" + maHD + "' AND MaGiamTru = '" + GiamTrus.Rows[i]["MaGiamTru"] + "'";
                    DataTable check = Database.query(query);
                    if (check.Rows.Count > 0)
                    {
                        addedRow.Cells[trangThaiIndex].Value = "Đã áp dụng";
                        addedRow.Cells[donGiaIndex].Value = check.Rows[0]["DonGia"];
                        addedRow.Cells[soLuongIndex].Value = check.Rows[0]["SoLuong"];
                        addedRow.Cells[thanhTienIndex].Value = check.Rows[0]["ThanhTien"];
                        addedRow.Cells[ghiChuIndex].Value = check.Rows[0]["GhiChu"];
                        addedRow.ReadOnly = true;
                    }
                }
            }
            
        }

        /*
         * Sinh Ma GT
         */
        public string SinhMaGT()
        {
            string query = "SELECT top 1 MaGiamTru FROM NoiDungGiamTru ORDER BY len(MaGiamTru) desc, MaGiamTru desc";
            DataTable result = Database.query(query);
            string prefixMGT = "";

            if (result.Rows.Count > 0)
            {
                string maGT = result.Rows[0]["MaGiamTru"].ToString();
                return prefixMGT + (Int64.Parse(maGT.Substring(prefixMGT.Length)) + 1).ToString();
            }
            else
            {
                return prefixMGT + "1";
            }
        }

        /*
         * Them noi dung giam tru
         */
        public void ThemNoiDungGiamTru(string maHD)
        {            
            foreach (DataGridViewRow row in form.dtgChiTietCongNoKH.SelectedRows)
            {                
                
                string query = "";
                if (row.Index > 0 && row.Cells[msIndex].Value.ToString() == "")
                {
                    row.Cells[msIndex].Value = SinhMaGT();

                    // Them vao bang NoiDungGiamTru
                    query = "INSERT NoiDungGiamTru VALUES(" +
                                    "'" + row.Cells[msIndex].Value.ToString() + "', " +
                                    "N'" + row.Cells[noiDungGiamTruIndex].Value.ToString() + "'," + 
                                    "N'" + row.Cells[dvtIndex].Value.ToString() + "')";
                    Database.query(query);
                }

                try
                {
                    long tienGiamTru = Int64.Parse(row.Cells[thanhTienIndex].Value.ToString());
                }
                catch
                {
                    Database.Warning("Số tiền giảm trừ ở hàng " + row.Index + " không hợp lệ");
                    return;
                }
                // Them vao bang HoaDonBanHang_NoiDungGiamTru
                query = "INSERT HoaDonBanHang_NoiDungGiamTru VALUES(" + 
                        "'" + maHD + "', " +
                        "'" + row.Cells[msIndex].Value.ToString() + "', " +
                        "'" + row.Cells[donGiaIndex].Value.ToString() + "', " +
                        "'" + row.Cells[soLuongIndex].Value.ToString() + "', " +
                        "'" + row.Cells[thanhTienIndex].Value.ToString() + "', " +
                        "N'" + row.Cells[ghiChuIndex].Value.ToString() + "'" +
                        ")";                
                Database.query(query);
                Database.Warning("Áp dụng nội dung giảm trừ thành công");
                row.Cells[trangThaiIndex].Value = "Đã áp dụng";
            }
        }
    }
}
