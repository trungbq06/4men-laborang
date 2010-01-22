using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrintDataGrid;
using System.Collections;
namespace DentalLabo.QuanLySPVaLuong
{
   
    public partial class FrmXemPhieuThanhToan : Form
    {
        private String manv;
        private String mabp;
        private DataGridView luongchinh;
        private DataGridView luongtinhthem;
        private DataGridView luongtru;
        private DateTimePicker tungay;
        private DateTimePicker denngay;

        public static int ThemHangRong(DataGridView dtg)
        {
            int n = dtg.Rows.Add();
            for (int i = 0; i < dtg.ColumnCount; i++)
                dtg.Rows[n].Cells[i].Value = "";
            return n;
        }
        public FrmXemPhieuThanhToan(String _manv, String _mabp, DataGridView _luongchinh, DataGridView _luongtinhthem, DataGridView _luongtru, DateTimePicker _tungay, DateTimePicker _denngay)
        {
            InitializeComponent();
            manv = _manv;
            mabp = _mabp;
            luongchinh = _luongchinh;
            luongtinhthem = _luongtinhthem;
            luongtru = _luongtru;
            tungay = _tungay;
            denngay = _denngay;

            int count = 0;
            DataTable NVInfo = Database.query("select manv, tennv from nhanvien where manv='"+manv+"'");
            DataTable BPInfo = Database.query("select mabp, tenbp from bophan where mabp='" + mabp + "'");
            
            
            txtMaBoPhan.Text = mabp;
            txtMaNhanVien.Text = manv;
            txtTenBoPhan.Text = BPInfo.Rows[0].ItemArray[1].ToString();
            txtTenNhanVien.Text = NVInfo.Rows[0].ItemArray[1].ToString();
            dtpTuNgay.Value = tungay.Value;
            dtpDenNgay.Value = denngay.Value;

            DataGridViewCellStyle dam = new DataGridViewCellStyle();
            dam.Font = new Font(dtgThanhToan.Font, FontStyle.Bold);

            int n = ThemHangRong(dtgThanhToan);
            dtgThanhToan.Rows[n].Cells[0].Value = "I";
            dtgThanhToan.Rows[n].Cells[1].Value = "Lương Chính";
            dtgThanhToan.Rows[n].Cells[3].Value = "Đồng";
            dtgThanhToan.Rows[n].DefaultCellStyle = dam;

            int tong = 0;
            for (int i = 0; i < luongchinh.Rows.Count; i++)
            {
                try
                {
                    if ((luongchinh.Rows[i].Cells[0].Value.ToString() != "") && (luongchinh.Rows[i].Cells[0].Value.ToString() != ""))
                    {
                        int t = ThemHangRong(dtgThanhToan);
                        for (int j = 0; j <= 6; j++)
                            dtgThanhToan.Rows[t].Cells[j].Value = luongchinh.Rows[i].Cells[j].Value.ToString();
                        //MessageBox.Show(dtgThanhToan.Rows[t].Cells[6].Value.ToString());
                        tong += Convert.ToInt32(dtgThanhToan.Rows[t].Cells[6].Value.ToString());
                    }
                }
                catch (Exception ex)
                {
                }
            }
            dtgThanhToan.Rows[n].Cells[6].Value = tong.ToString();
            count += tong;
            tong = 0;

            n = ThemHangRong(dtgThanhToan);
            dtgThanhToan.Rows[n].Cells[0].Value = "II";
            dtgThanhToan.Rows[n].Cells[1].Value = "Các khoản tính thêm";
            dtgThanhToan.Rows[n].Cells[3].Value = "Đồng";
            dtgThanhToan.Rows[n].DefaultCellStyle = dam;
            for (int i = 0; i < luongtinhthem.Rows.Count; i++)
            {
                try
                {
                    if ((luongtinhthem.Rows[i].Cells[0].Value.ToString() != "") && (luongtinhthem.Rows[i].Cells[0].Value.ToString() != ""))
                    {
                        int t = ThemHangRong(dtgThanhToan);
                        for (int j = 0; j <= 6; j++)
                            dtgThanhToan.Rows[t].Cells[j].Value = luongtinhthem.Rows[i].Cells[j].Value.ToString();
                        tong += Convert.ToInt32(dtgThanhToan.Rows[t].Cells[6].Value);
                    }
                }
                catch (Exception ex)
                {
                }

            }

            dtgThanhToan.Rows[n].Cells[6].Value = tong.ToString();
            count += tong;
            tong = 0;

            n = ThemHangRong(dtgThanhToan); 
            dtgThanhToan.Rows[n].Cells[0].Value = "III";
            dtgThanhToan.Rows[n].Cells[1].Value = "Các khoản phải trừ";
            dtgThanhToan.Rows[n].Cells[3].Value = "Đồng";
            dtgThanhToan.Rows[n].DefaultCellStyle = dam;
            for (int i = 0; i < luongtru.Rows.Count; i++)
            {
                try
                {
                    if ((luongtru.Rows[i].Cells[0].Value.ToString() != "") && (luongtru.Rows[i].Cells[0].Value.ToString() != ""))
                    {
                        int t = ThemHangRong(dtgThanhToan); 
                        for (int j = 0; j <= 6; j++)
                            dtgThanhToan.Rows[t].Cells[j].Value = luongtru.Rows[i].Cells[j].Value.ToString();
                        tong += Convert.ToInt32(dtgThanhToan.Rows[t].Cells[6].Value);
                    }
                }
                catch (Exception ex)
                {
                }

            }
            dtgThanhToan.Rows[n].Cells[6].Value = tong.ToString();
            count -= tong;

            //dtgThanhToan.Rows.Add();
            n = ThemHangRong(dtgThanhToan);
            dtgThanhToan.Rows[n].Cells[0].Value = "IV";
            dtgThanhToan.Rows[n].Cells[1].Value = "Giá trị được thanh toán";
            dtgThanhToan.Rows[n].Cells[3].Value = "Đồng";
            dtgThanhToan.Rows[n].DefaultCellStyle = dam;
            dtgThanhToan.Rows[n].Cells[6].Value = count.ToString();
        }

        private void FrmXemPhieuThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxTinhLuongNoiDungTinhLuong_Enter(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            
            ArrayList head = new ArrayList();
            DataTable NVInfo = Database.query("select tennv from nhanvien where manv='"+manv+"'");
            DataTable BPInfo = Database.query("select tenbp from bophan where mabp='"+mabp+"'");
            head.Add("Tên nhân viên: " + NVInfo.Rows[0].ItemArray[0].ToString());
            head.Add("Mã nhân viên: " + manv);
            head.Add("Tên bộ phận: " + BPInfo.Rows[0].ItemArray[0].ToString());
            head.Add("Mã bộ phận: " + mabp);
            PrintDGV.Print_DataGridView(dtgThanhToan, head);
        }

        private void dtgThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
