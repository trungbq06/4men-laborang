using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalLabo.QuanLySPVaLuong
{
    public partial class frmChiTietKetQuaCongViec : Form
    {
        private String manv;
        private String startDate;
        private String endDate;
        public frmChiTietKetQuaCongViec(String _manv, String _startDate, String _endDate)
        {
            InitializeComponent();
            manv = _manv;
            startDate = _startDate;
            endDate = _endDate;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenBoPhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaBoPhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmChiTietKetQuaCongViec_Load(object sender, EventArgs e)
        {
            dtgChiTiet.Rows.Clear();
            if (manv == "")
                return;
            DataTable NVInfo = Database.query("select manv, tennv, mabp from nhanvien where manv= '"+manv+"'");

            DataTable BPInfo = Database.query("select mabp, tenbp from bophan where mabp='"+NVInfo.Rows[0].ItemArray[2].ToString()+"'");

            txtMaBoPhan.Text = BPInfo.Rows[0].ItemArray[0].ToString();
            txtTenBoPhan.Text = BPInfo.Rows[0].ItemArray[1].ToString();
            txtMaNhanVien.Text = NVInfo.Rows[0].ItemArray[0].ToString();
            txtTenNhanVien.Text = NVInfo.Rows[0].ItemArray[1].ToString();

            txtTuNgay.Text = startDate;
            txtDenNgay.Text = endDate;


            String selectQuery = "select mamau from phieunhapkhosp_mauhang where (ngaynhap>= '" + startDate + "') and (ngaynhap<='" + endDate + "')";
            //System.Console.WriteLine(selectQuery);
            DataTable ListMau = Database.query(selectQuery);

            DataTable ListCDSX = Database.query("SELECT macd, tencd, soluongquychieu from congdoansx");
            int tong = 0;
            
            for (int i = 0; i < ListMau.Rows.Count; i++)
            {
                DataTable ChamCongDoan = Database.query("select macd, solan from chamcongdoan where mamau='"+ListMau.Rows[i].ItemArray[0].ToString()+"' and manv='"+manv+"'");
                for (int j = 0; j < ChamCongDoan.Rows.Count; j++)
                {
                    int n = dtgChiTiet.Rows.Add();
                    
                    dtgChiTiet.Rows[n].Cells[0].Value = (n +1).ToString();
                    dtgChiTiet.Rows[n].Cells[1].Value = ListMau.Rows[i].ItemArray[0].ToString();
                    for (int k=0; k<ListCDSX.Rows.Count; k++)
                        if (ListCDSX.Rows[k].ItemArray[0].ToString() == ChamCongDoan.Rows[j].ItemArray[0].ToString())
                        {
                            dtgChiTiet.Rows[n].Cells[2].Value = ListCDSX.Rows[k].ItemArray[1].ToString();
                            dtgChiTiet.Rows[n].Cells[3].Value = ListCDSX.Rows[k].ItemArray[2].ToString();
                        }
                    dtgChiTiet.Rows[n].Cells[4].Value = ChamCongDoan.Rows[j].ItemArray[1].ToString();
                    tong += Convert.ToInt32(dtgChiTiet.Rows[n].Cells[4].Value) + Convert.ToInt32(dtgChiTiet.Rows[n].Cells[3].Value);
                }
            }

            dtgChiTiet.Rows.Add();

            int tmp = dtgChiTiet.Rows.Add();

            dtgChiTiet.Rows[tmp].Cells[2].Value = "Tổng";
            dtgChiTiet.Rows[tmp].Cells[3].Value = tong.ToString();



        }
    } 
}
