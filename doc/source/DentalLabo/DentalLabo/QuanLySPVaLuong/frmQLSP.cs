using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using DentalLabo.Quan_ly_san_pham_va_tinh_luong;
using DentalLabo.QuanLySPVaLuong;
using DentalLabo.Mau_dat_hang;
using DentalLabo.BanHangVaCongNo;
namespace DentalLabo
{
    public partial class frmQLSP : Form
    {
        private DataTable ListNoiDungYeuCau = new DataTable();
        private DataTable ListCongDoanSanXuat = new DataTable();
        private DataTable ListNVChamCong = new DataTable();
        private String tmpMonth;
        private String tmpYear;
        private String tmpDay;
        private DataTable ListLuongChinh = new DataTable();
        private DataTable ListLuongThem= new DataTable();
        private DataTable ListLuongTru = new DataTable();
        public frmQLSP()
        {
            InitializeComponent();
            BHCNModel.UpdateComboBoxByQuery(cbTongHopKetQuaLamViecTenNhanVien,"select tennv from nhanvien","tennv");
            BHCNModel.UpdateComboBoxByQuery(cbTongHopKetQuaLamViecMaNhanVien, "select manv from nhanvien","manv");
            BHCNModel.UpdateComboBoxByQuery(cbTongHopKetQuaLamViecMaBoPhan, "select mabp from bophan","mabp");
            BHCNModel.UpdateComboBoxByQuery(cbTongHopKetQuaLamViecTenBoPhan, "select tenbp from bophan", "tenbp");


            BHCNModel.UpdateComboBoxByQuery(txtTinhLuongTenNhanVien, "select tennv from nhanvien", "tennv");
            BHCNModel.UpdateComboBoxByQuery(txtTinhLuongMaNhanVien, "select manv from nhanvien", "manv");
            BHCNModel.UpdateComboBoxByQuery(txtTinhLuongMaBoPhan, "select mabp from bophan", "mabp");
            BHCNModel.UpdateComboBoxByQuery(txtTinhLuongTenBoPhan, "select tenbp from bophan", "tenbp");

            BHCNModel.UpdateComboBoxByQuery(txtTamUngLuongTenBoPhan, "select tenbp from bophan", "tenbp");
            BHCNModel.UpdateComboBoxByQuery(txtTamUngLuongMaBoPhan, "select  mabp from bophan", "mabp");
            
            BHCNModel.UpdateComboBoxByQuery(txtChamCongTenNhanVien, "select tennv from nhanvien", "tennv");
            BHCNModel.UpdateComboBoxByQuery(txtChamCongMaNhanVien, "select manv from nhanvien", "manv");
            BHCNModel.UpdateComboBoxByQuery(txtChamCongMaBoPhan, "select mabp from bophan", "mabp");
            BHCNModel.UpdateComboBoxByQuery(txtChamCongTenBoPhan, "select tenbp from bophan", "tenbp");



        }

        private void frmQLSP_Load(object sender, EventArgs e)
        {
            //String selectQuery;
            String month = dtpNgayChamCong.Value.ToString("MM");
            String year = dtpNgayChamCong.Value.ToString("yyyy");
            //lblChamCongTapHopKetQua.Text = "TỔNG HỢP KẾT QUẢ NGÀY CÔNG ĐI LÀM THÁNG " + month + "/" + year;

            //DataTable
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgayNhanMau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgChamCongTongHopKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new frmDanhMucBoPhan();
            f.Show();
        }

        private void lblTinhLuongMaNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void lblNoiDungYeuCauPhucVu_Click(object sender, EventArgs e)
        {

        }

        private void subTabChamCongVaLamThem_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongTenNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongMaBoPhan_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongMaNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void showDtgChamCongTongHopKetQua()
        {
            //String selectQuery;
            String month = dtpNgayChamCong.Value.ToString("MM");
            String year = dtpNgayChamCong.Value.ToString("yyyy");
            String day = dtpNgayChamCong.Value.ToString("dd");
            tmpMonth = month;
            tmpYear = year;
            tmpDay = day;
            //lblChamCongTapHopKetQua.Text = "TỔNG HỢP KẾT QUẢ NGÀY CÔNG ĐI LÀM THÁNG " + month + "/" + year;

            DataTable ListNV;
            if (txtChamCongMaNhanVien.Text == "")
                ListNV = Database.query("Select manv, tennv from nhanvien where mabp ='"+txtChamCongMaBoPhan.Text+"'");
            else 
                ListNV = Database.query("Select manv, tennv from nhanvien where manv ='"+txtChamCongMaNhanVien.Text+"'");
            dtgChamCongTongHopKetQua.Rows.Clear();
            ListNVChamCong = ListNV;

            for (int i = 0; i < ListNV.Rows.Count; i++)
            {
                //System.Console.WriteLine("select sum(congchinh), sum(congnghi), sum(lamthemgio), sum(trucchunhat) from chamcong_history where manv='" + txtChamCongMaNhanVien.Text + "' and month(ngay) = '" + month + "' and year(ngay)='" + year + "'");
                DataTable ChamCongInfo = Database.query("select sum(congchinh), sum(congnghi), sum(lamthemgio), sum(trucchunhat) from chamcong_history where manv='" + ListNV.Rows[i].ItemArray[0].ToString() + "' and ngay = '" + dtpNgayChamCong.Value.ToString("yyyy-MM-dd") + "'");
                
                int n = dtgChamCongTongHopKetQua.Rows.Add();
                dtgChamCongTongHopKetQua.Rows[n].Cells[0].Value = (i + 1).ToString();
                dtgChamCongTongHopKetQua.Rows[n].Cells[1].Value = ListNV.Rows[i].ItemArray[0].ToString();
                dtgChamCongTongHopKetQua.Rows[n].Cells[2].Value = ListNV.Rows[i].ItemArray[1].ToString();
                dtgChamCongTongHopKetQua.Rows[n].Cells[3].Value = ChamCongInfo.Rows[0].ItemArray[0].ToString();
                dtgChamCongTongHopKetQua.Rows[n].Cells[4].Value = ChamCongInfo.Rows[0].ItemArray[2].ToString();
                dtgChamCongTongHopKetQua.Rows[n].Cells[5].Value = ChamCongInfo.Rows[0].ItemArray[3].ToString();
                dtgChamCongTongHopKetQua.Rows[n].Cells[6].Value = ChamCongInfo.Rows[0].ItemArray[1].ToString();

                DataTable GhiChuInfo = Database.query("select ghichu from chamcong_ghichu where manv='"+ListNV.Rows[i].ItemArray[0].ToString()+"' and thang="+month+" and nam="+year+ " and ngay=" + day );
                if (GhiChuInfo.Rows.Count > 0)
                {
                    dtgChamCongTongHopKetQua.Rows[n].Cells[7].Value = GhiChuInfo.Rows[0].ItemArray[0].ToString();
                }
                else
                {
                    dtgChamCongTongHopKetQua.Rows[n].Cells[7].Value = "";
                }



            }
        }
        private void btnChamCongTimKiem_Click(object sender, EventArgs e)
        {

            txtChamCongLamThemGio.Text = "0";
            txtChamCongTrucCN.Text = "0";
            txtChamCongNgayCongChinh.Text = "0";
            txtChamCongNgayCongNghi.Text = "0";

            if (txtChamCongMaNhanVien.Text != "")
            {
                DataTable NVInfo = Database.query("select manv, tennv, mabp from nhanvien where manv='" + txtChamCongMaNhanVien.Text + "'");
                if (NVInfo.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên có mã là '" + txtChamCongMaNhanVien.Text + "'", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChamCongTenNhanVien.Text = "";
                    return;
                }

                txtChamCongTenNhanVien.Text = NVInfo.Rows[0].ItemArray[1].ToString();
                txtChamCongMaBoPhan.Text = NVInfo.Rows[0].ItemArray[2].ToString();
            }

            DataTable BPInfo = Database.query("select mabp, tenbp from bophan where mabp='" + txtChamCongMaBoPhan.Text + "'");
            if (BPInfo.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy bộ phận có mã bộ phận là '" + txtChamCongMaBoPhan.Text + "'", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupboxBoPhanNhanVien.Text = "";
                return;
            }
            groupboxBoPhanNhanVien.Text = BPInfo.Rows[0].ItemArray[1].ToString();

            DataTable ChamCongInfo = Database.query("select congchinh, congnghi, lamthemgio, trucchunhat,manvcc from chamcong_history where ngay = '"+dtpNgayChamCong.Value.ToString("yyyy-MM-dd")+"' and manv='"+txtChamCongMaNhanVien.Text+"'");
            if (ChamCongInfo.Rows.Count == 0)
            {
                txtChamCongNgayCongChinh.Text = "0";
                txtChamCongNgayCongNghi.Text = "0";
                txtChamCongLamThemGio.Text = "0";
                txtChamCongTrucCN.Text = "0";
            }
            else
            {
                txtChamCongNgayCongChinh.Text = ChamCongInfo.Rows[0].ItemArray[0].ToString();
                txtChamCongNgayCongNghi.Text = ChamCongInfo.Rows[0].ItemArray[1].ToString();
                txtChamCongLamThemGio.Text = ChamCongInfo.Rows[0].ItemArray[2].ToString();
                txtChamCongTrucCN.Text = ChamCongInfo.Rows[0].ItemArray[3].ToString() ;
                txtChamCongMaNVCC.Text = ChamCongInfo.Rows[0].ItemArray[4].ToString();
            }
            showDtgChamCongTongHopKetQua();

        }

        private void lblChamCongNgayCongChinh_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongNgayCongNghi_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongLamThemGio_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongTrucCN_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongMaNVCC_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongTenBoPhan_Click(object sender, EventArgs e)
        {

        }

        private void lblChamCongNgayChamCong_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxBoPhanNhanVien_Enter(object sender, EventArgs e)
        {

        }

        private void btnXemPhieuThanhToanLuong_Click(object sender, EventArgs e)
        {

        }

        private void dtgTamUngLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNgayNhanMau_Click(object sender, EventArgs e)
        {

        }

        private void txtQuanLyDonViSanPhamMaSoMau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuanLyDonViSanPhamMaSoMau_Enter(object sender, EventArgs e)
        {

        }

        private void txtQuanLyDonViSanPhamMaSoMau_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void btnQLSPTimKiem_Click(object sender, EventArgs e)
        {
            String MaMau = txtQuanLyDonViSanPhamMaSoMau.Text;
            String selectQ = "select mamau, makh, loaiphuchinh, ngaynhan from mauhang where mamau='"+MaMau+"'";

            dtgQLDonViSanPhamCongDoanPhucHinh.Rows.Clear();
            dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows.Clear();
            
            //dtgQLDonViSanPhamNoiDungYeuCauPhucVu.DataSource = null;
            //System.Console.WriteLine(selectQ);
            DataTable dt = Database.query(selectQ);
            /*
            DataTableReader dtr = dt.CreateDataReader();
            int count = 0;
            while (dtr.Read())
            {
                count++;
                //dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows.Add();
                dateTimePickerNgayNhanMau.Value = Convert.ToDateTime(dtr.GetValue(2).ToString());
                break;
            }*/

            
            int count = dt.Rows.Count;

            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy mẫu hàng có mã là " + txtQuanLyDonViSanPhamMaSoMau.Text, "Không tìm thấy!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            dateTimePickerNgayNhanMau.Value = Convert.ToDateTime(dt.Rows[0].ItemArray[3].ToString());

            DataTable dtSPDH = Database.query("Select MaSPDatHang from MauHang_SanPhamDatHang where MaMau='" + MaMau + "'");           

            DataTable ListSP = Database.query("select masp,tensp,dvt,soluongquychuan from sanpham");

            DataTable ListVLC = Database.query("select  mavl, tenvl from vatlieuchinh");
            DataTable ListVLP = Database.query("select  mavl, tenvl from vatlieuphu");

            if (dtSPDH.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm đặt hàng!");
            }

            ListNoiDungYeuCau = dtSPDH;
            for (int i = 0; i < dtSPDH.Rows.Count; i++)
            {
                //MessageBox.Show(dtSPDH.Rows[i].ItemArray[0].ToString());
                DataTable SPDHInfo = Database.query("select maspdathang, masp, vitrirang, mavlc, mavlp, soluongvlc, soluongvlp, soluong, mausp, luuy, yeucauchitiet from sanphamdathang where maspdathang='" + dtSPDH.Rows[i].ItemArray[0] + "'");
                //MessageBox.Show(SPDHInfo.Rows[0].ItemArray[1].ToString());
                int n = dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows.Add();
                dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[0].Value = (i + 1).ToString();
                for (int j=0; j< ListSP.Rows.Count; j++)
                    if (ListSP.Rows[j].ItemArray[0].ToString() == SPDHInfo.Rows[0].ItemArray[1].ToString())
                    {
                        dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[1].Value = ListSP.Rows[j].ItemArray[1].ToString();
                        dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[7].Value = ListSP.Rows[j].ItemArray[2].ToString();
                        dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[9].Value = ListSP.Rows[j].ItemArray[3].ToString();
                    }
                dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[2].Value = SPDHInfo.Rows[0].ItemArray[2].ToString();
                for (int j = 0; j < ListVLC.Rows.Count; j++)
                    if (ListVLC.Rows[j].ItemArray[0].ToString() == SPDHInfo.Rows[0].ItemArray[3].ToString())
                {
                    dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[3].Value = ListVLC.Rows[j].ItemArray[1].ToString();
                }

                dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[4].Value = SPDHInfo.Rows[0].ItemArray[5].ToString();
                for (int j=0; j<ListVLP.Rows.Count; j++)
                    if (ListVLP.Rows[j].ItemArray[0].ToString() == SPDHInfo.Rows[0].ItemArray[4].ToString()){
                        dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[5].Value = ListVLP.Rows[j].ItemArray[1].ToString();
                    }
                dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[6].Value = SPDHInfo.Rows[0].ItemArray[6].ToString();
                dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[n].Cells[8].Value = SPDHInfo.Rows[0].ItemArray[7].ToString();
            }


            DataTable ChamCongDoan = Database.query("Select macd, manv, solan from chamcongdoan where mamau='" + MaMau + "'");
            ListCongDoanSanXuat = ChamCongDoan;
            for (int i = 0; i < ChamCongDoan.Rows.Count; i++)
            {
                DataTable CDSXInfo = Database.query("select tencd, donvitinh, soluongquychieu from congdoansx where macd='" + ChamCongDoan.Rows[i].ItemArray[0].ToString() + "'");
                int n = dtgQLDonViSanPhamCongDoanPhucHinh.Rows.Add();
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[0].Value = (i + 1).ToString();
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[1].Value = CDSXInfo.Rows[0].ItemArray[0].ToString();
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[2].Value = ChamCongDoan.Rows[i].ItemArray[0].ToString();
                DataTable NVInfo = Database.query("select tennv from nhanvien where manv='"+ChamCongDoan.Rows[i].ItemArray[1].ToString()+"'");
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[3].Value = NVInfo.Rows[0].ItemArray[0].ToString() ;
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[4].Value = ChamCongDoan.Rows[i].ItemArray[1].ToString();
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[5].Value = CDSXInfo.Rows[0].ItemArray[1].ToString();
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[6].Value = CDSXInfo.Rows[0].ItemArray[2].ToString();
                dtgQLDonViSanPhamCongDoanPhucHinh.Rows[n].Cells[7].Value = ChamCongDoan.Rows[i].ItemArray[2].ToString();

            }
            
        }

        private void dgtTinhLuongCacKhoanPhaiTru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMauMoi_Click(object sender, EventArgs e)
        {
            Form f = new frmMauDatHang();
            f.Show();
        }

        private void btnQuanLyDonViSanPhamThemYeuCau_Click(object sender, EventArgs e)
        {
            //txtQuanLyDonViSanPhamMaSoMau.Text
            Form f = new frmMauDatHang();
            f.Show();
        }

        private void btnQuanLyDonViSanPhamXoa_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows.Count; i++)
            if (dtgQLDonViSanPhamNoiDungYeuCauPhucVu.Rows[i].Selected == true)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa nội dung yêu cầu thứ " + (i + 1).ToString() + " này không?", "Xác nhận xóa?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.No)
                    return;
                String deleteQuery = "delete from mauhang_sanphamdathang where maspdathang='"+ListNoiDungYeuCau.Rows[i].ItemArray[0]+"' and mamau='"+txtQuanLyDonViSanPhamMaSoMau.Text+"'";
                Database.query(deleteQuery);

                deleteQuery = "delete from sanphamdathang where maspdathang='" + ListNoiDungYeuCau.Rows[i].ItemArray[0] + "'";
                Database.query(deleteQuery);
            }
            btnQLSPTimKiem_Click(sender,e);
        }

        private void btnThemMoiCongDoan_Click(object sender, EventArgs e)
        {
            if (txtQuanLyDonViSanPhamMaSoMau.Text == "")
                return;
            Form f = new frmThemCongDoanSanXuat(txtQuanLyDonViSanPhamMaSoMau.Text);
            f.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnQuanLyDonViSanPhamLuu_Click(object sender, EventArgs e)
        {
            for (int i=0; i<dtgQLDonViSanPhamCongDoanPhucHinh.Rows.Count; i++)
                if (dtgQLDonViSanPhamCongDoanPhucHinh.Rows[i].Selected == true)
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa công đoạn thứ " + (i + 1).ToString() + " này không?", "Xác nhận xóa?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.No)
                        return;

                    String deleteQuery = "delete from chamcongdoan where mamau='"+txtQuanLyDonViSanPhamMaSoMau.Text+"' and macd='"+ListCongDoanSanXuat.Rows[i].ItemArray[0]+"' and manv='"+ListCongDoanSanXuat.Rows[i].ItemArray[1]+"'";
                    Database.query(deleteQuery);
                    btnQLSPTimKiem_Click(sender, e);
                }
        }

        private void txtMaBoPhan_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("aa");
            /*if (e.KeyCode != Keys.Enter)
                return;
            if (txtMaBoPhan.Text == "")
            {
                txtTenBoPhan.Text = "";
                return;
            }
            DataTable dt = Database.query("select tenbp from bophan where mabp='"+txtMaBoPhan.Text+"'");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy bộ phận này!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBoPhan.Text = "";
                return;
            }
            txtTenBoPhan.Text = dt.Rows[0].ItemArray[0].ToString();*/

        }

        private void txtMaNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
           /* if ((e.KeyCode != Keys.Enter))
                return;
            if (txtMaNhanVien.Text == "")
            {
                txtTenNhanVien.Text = "";
                return;
            }
            DataTable dt = Database.query("select tennv from nhanvien where manv='"+txtMaNhanVien.Text+"'");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên phận này!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Text = "";
                return;
            }
            txtTenNhanVien.Text = dt.Rows[0].ItemArray[0].ToString();*/
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if ((cbTongHopKetQuaLamViecMaBoPhan.Text == "") && (cbTongHopKetQuaLamViecMaNhanVien.Text == ""))
                return;
            String selectQuery;
            if (cbTongHopKetQuaLamViecMaBoPhan.Text != "")
            {
                selectQuery = "select manv, tennv from nhanvien where mabp='"+cbTongHopKetQuaLamViecMaBoPhan.Text+"'";
            }
            else
            {
                selectQuery = "select manv, tennv from nhanvien where manv='"+cbTongHopKetQuaLamViecMaNhanVien.Text+"'";
            }

            DataTable ListNV = Database.query(selectQuery);
            dtgTongHopKetQuaCongViec.Rows.Clear();
            
            
            //MessageBox.Show(dtpTongHopKetQuaTuNgay.Value.ToString("yyyy-MM-dd"));

            selectQuery = "select mamau from phieunhapkhosp_mauhang where (ngaynhap>= '"+dtpTongHopKetQuaTuNgay.Value.ToString("yyyy-MM-dd")+"') and (ngaynhap<='"+dtpTongHopKetQuaDenNgay.Value.ToString("yyyy-MM-dd")+"')";
            //System.Console.WriteLine(selectQuery);
            DataTable ListMau = Database.query(selectQuery);

            DataTable ListCDSX = Database.query("SELECT macd, soluongquychieu from congdoansx");

            if (ListMau.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả công việc nào từ ngày "+dtpTongHopKetQuaTuNgay.Value.ToString("dd/MM/yyyy")+" đến ngày "+dtpTongHopKetQuaDenNgay.Value.ToString("dd/MM/yyyy")+"!");
                return;
            }
            String idin = "(";
            //MessageBox.Show(ListMau.Rows.Count.ToString());
            for (int i = 0; i < ListMau.Rows.Count; i++)
            {
                if (i != 0)
                    idin += ",'" + ListMau.Rows[i].ItemArray[0].ToString() + "'";
                else
                    idin += "'" + ListMau.Rows[i].ItemArray[0].ToString() + "'";
            }
            idin += ")";
            //MessageBox.Show(idin);

            int tong = 0;
            for (int i = 0; i < ListNV.Rows.Count; i++)
            {
                int n = dtgTongHopKetQuaCongViec.Rows.Add();
                dtgTongHopKetQuaCongViec.Rows[n].Cells[0].Value = (i + 1).ToString();
                dtgTongHopKetQuaCongViec.Rows[n].Cells[1].Value = ListNV.Rows[i].ItemArray[0].ToString();
                dtgTongHopKetQuaCongViec.Rows[n].Cells[2].Value = ListNV.Rows[i].ItemArray[1].ToString();
                dtgTongHopKetQuaCongViec.Rows[n].Cells[3].Value = "Răng";

                int soluong = 0;
                //System.Console.WriteLine("select macd,solan from chamcongdoan where mamau in " + idin);
                DataTable ListCD = Database.query("select macd,solan from chamcongdoan where mamau in " + idin + " and manv='"+ListNV.Rows[i].ItemArray[0].ToString()+"'");
                for (int j = 0; j < ListCD.Rows.Count; j++)
                    for (int k = 0; k < ListCDSX.Rows.Count; k++)
                        if (ListCDSX.Rows[k].ItemArray[0].ToString() == ListCD.Rows[j].ItemArray[0].ToString()) 
                    {
                        soluong += Convert.ToInt32(ListCD.Rows[j].ItemArray[1]) + Convert.ToInt32(ListCDSX.Rows[k].ItemArray[1]);
                    }
                dtgTongHopKetQuaCongViec.Rows[n].Cells[4].Value = soluong.ToString();
                tong += soluong;
            }

            if (cbTongHopKetQuaLamViecMaBoPhan.Text != "")
            {
                dtgTongHopKetQuaCongViec.Rows.Add();
                int t = dtgTongHopKetQuaCongViec.Rows.Add();
                dtgTongHopKetQuaCongViec.Rows[t].Cells[2].Value = "Tổng số";
                dtgTongHopKetQuaCongViec.Rows[t].Cells[3].Value = "Răng";
                dtgTongHopKetQuaCongViec.Rows[t].Cells[4].Value = tong.ToString();
            }
            
        }

        private void btnTongHopKetQuaLamViecXemChiTiet_Click(object sender, EventArgs e)
        {
            for (int i=0; i<dtgTongHopKetQuaCongViec.Rows.Count; i++)
                if (dtgTongHopKetQuaCongViec.Rows[i].Selected == true)
                {
                    Form f = new frmChiTietKetQuaCongViec(dtgTongHopKetQuaCongViec.Rows[i].Cells[1].Value.ToString(), dtpTongHopKetQuaTuNgay.Value.ToString("yyyy-MM-dd"), dtpTongHopKetQuaDenNgay.Value.ToString("yyyy-MM-dd"));
                    f.Show();
                }
        }

        private void txtChamCongMaBoPhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (txtChamCongMaBoPhan.Text == "")
                return;

            DataTable BPInfo = Database.query("select mabp, tenbp from bophan where mabp='"+txtChamCongMaBoPhan.Text+"'");
            if (BPInfo.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy bộ phận có mã bộ phận là '" + txtChamCongMaBoPhan.Text + "'", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupboxBoPhanNhanVien.Text = "";
                return;
            }
            groupboxBoPhanNhanVien.Text = BPInfo.Rows[0].ItemArray[1].ToString();

        }

        private void txtChamCongMaNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (txtChamCongMaNhanVien.Text == "")
                return;

            DataTable NVInfo = Database.query("select manv, tennv, mabp from nhanvien where manv='"+txtChamCongMaNhanVien.Text+"'");
            if (NVInfo.Rows.Count == 0){
                MessageBox.Show("Không tìm thấy nhân viên có mã là '" + txtChamCongMaNhanVien.Text + "'", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChamCongTenNhanVien.Text = "";
                return;
            }

            txtChamCongTenNhanVien.Text = NVInfo.Rows[0].ItemArray[1].ToString();
            txtChamCongMaBoPhan.Text = NVInfo.Rows[0].ItemArray[2].ToString();
            txtChamCongMaBoPhan_KeyDown(sender, e);

        }

        private void btnChamCongNhanVienMoi_Click(object sender, EventArgs e)
        {
            Form f = new frmDanhMucNV();
            f.Show();
        }

        private void btnChamCongLuu_Click(object sender, EventArgs e)
        {
            try{
            for (int i = 0; i < ListNVChamCong.Rows.Count; i++)
            {
                DataTable dt = Database.query("select ghichu from chamcong_ghichu where thang = "+tmpMonth.ToString()+" and nam="+tmpYear.ToString()+" and manv='"+ListNVChamCong.Rows[i].ItemArray[0].ToString()+"' and ngay='"+tmpDay.ToString()+"'");
                if (dt.Rows.Count > 0)
                {
                    //System.Console.WriteLine("update chamcong_ghichu set ghichu ='" + dtgChamCongTongHopKetQua.Rows[i].Cells[7].Value.ToString() + "' where thang= " + tmpMonth.ToString() + " and nam = " + tmpYear.ToString() + " and manv='" + ListNVChamCong.Rows[i].ItemArray[0].ToString() + "' and ngay="+tmpDay+"");
                    Database.query("update chamcong_ghichu set ghichu =N'" + dtgChamCongTongHopKetQua.Rows[i].Cells[7].Value.ToString() + "' where thang= " + tmpMonth.ToString() + " and nam = " + tmpYear.ToString() + " and manv='" + ListNVChamCong.Rows[i].ItemArray[0].ToString() + "' and ngay=" + tmpDay + "");
                }
                else
                {
                    Database.query("insert into chamcong_ghichu(manv,thang,nam,ghichu,ngay) values(N'" + ListNVChamCong.Rows[i].ItemArray[0].ToString() + "'," + tmpMonth.ToString() + "," + tmpYear.ToString() + ",N'" + dtgChamCongTongHopKetQua.Rows[i].Cells[7].Value.ToString() + "'," + tmpDay.ToString() + ")");
                }
            }

            if (txtChamCongMaNVCC.Text == "")
            {
                MessageBox.Show("Cần nhập mã nhân viên chấm công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable tmp = Database.query("select * from chamcong_history where manv='" + txtChamCongMaNhanVien.Text + "' and ngay='" + dtpNgayChamCong.Value.ToString("yyyy-MM-dd")+ "'");
            if (tmp.Rows.Count > 0)
            {
                Database.query("update chamcong_history set manvcc=N'" + txtChamCongMaNVCC.Text + "', congchinh=" + txtChamCongNgayCongChinh.Text + ", congnghi=" + txtChamCongNgayCongNghi.Text + ", lamthemgio=" + txtChamCongLamThemGio.Text + ", trucchunhat=" + txtChamCongTrucCN.Text + " where manv='" + txtChamCongMaNhanVien.Text + "' and ngay='" + dtpNgayChamCong.Value.ToString("yyyy-MM-dd") + "'");
            }
            else
            {
                System.Console.WriteLine("insert into chamcong_history(manv, manvcc, ngay, congchinh, congnghi, lamthemgio, trucchunhat) values(N'" + txtChamCongMaNhanVien.Text + "',N'" + txtChamCongMaNVCC.Text + "','" + dtpNgayChamCong.Value.ToString("yyyy-MM-dd") + "', " + txtChamCongNgayCongChinh.Text + "," + txtChamCongNgayCongNghi.Text + ", " + txtChamCongLamThemGio.Text + ", " + txtChamCongTrucCN.Text + ")");
                Database.query("insert into chamcong_history(manv, manvcc, ngay, congchinh, congnghi, lamthemgio, trucchunhat) values(N'" + txtChamCongMaNhanVien.Text + "',N'" + txtChamCongMaNVCC.Text + "','" + dtpNgayChamCong.Value.ToString("yyyy-MM-dd") + "', " + txtChamCongNgayCongChinh.Text + "," + txtChamCongNgayCongNghi.Text + ", " + txtChamCongLamThemGio.Text + ", " + txtChamCongTrucCN.Text + ")");
            }
            
                MessageBox.Show("Đã lưu!", "Ok!");
            }
            catch (Exception ex){
            }
        }

        private void btnTamUngLuongXemBang_Click(object sender, EventArgs e)
        {
            DataTable ListNV = Database.query("select manv, tennv from nhanvien where mabp='" + txtTamUngLuongMaBoPhan.Text + "'");
            for (int i = 0; i < ListNV.Rows.Count; i++)
            {
                DataTable TULInfo = Database.query("select * from tamung where manv='" + dtgTamUngLuong.Rows[i].Cells[2].Value.ToString() + "' and month(ngaytamung)=" + dtpKiTamUng.Value.ToString("MM") + " and year(ngaytamung) = " + dtpKiTamUng.Value.ToString("yyyy"));
                if (TULInfo.Rows.Count == 0)
                {
                    Database.query("insert into tamung(manv, dvt, muctamung, thanhtien, ghichu, ngaytamung) values('" + dtgTamUngLuong.Rows[i].Cells[2].Value.ToString() + "','" + dtgTamUngLuong.Rows[i].Cells[3].Value.ToString() + "','" + dtgTamUngLuong.Rows[i].Cells[4].Value.ToString() + "','" + dtgTamUngLuong.Rows[i].Cells[5].Value.ToString() + "','" + dtgTamUngLuong.Rows[i].Cells[6].Value.ToString() + "','"+dtpKiTamUng.Value.ToString("yyyy-MM")+"-01')");
                }
                else
                {
                    Database.query("update tamung set dvt = N'" + dtgTamUngLuong.Rows[i].Cells[3].Value.ToString() + "', muctamung='" + dtgTamUngLuong.Rows[i].Cells[4].Value.ToString() + "', thanhtien='" + dtgTamUngLuong.Rows[i].Cells[5].Value.ToString() + "', ghichu=N'" + dtgTamUngLuong.Rows[i].Cells[6].Value.ToString() + "' where manv='" + dtgTamUngLuong.Rows[i].Cells[2].Value.ToString() + "' and month(ngaytamung)=" + dtpKiTamUng.Value.ToString("MM") + " and year(ngaytamung) = " + dtpKiTamUng.Value.ToString("yyyy"));
                }
            }
            MessageBox.Show("Đã lưu thành công!");
        }

        private void txtTamUngLuongMaBoPhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            dtgTamUngLuong.Rows.Clear();
            DataTable ListBP = Database.query("select mabp, tenbp from bophan where mabp ='" + txtTamUngLuongMaBoPhan.Text + "'");
            if (ListBP.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy bộ phận này!");
                //dtgTamUngLuong.Rows.Clear();
                return;
            }

            txtTamUngLuongTenBoPhan.Text = ListBP.Rows[0].ItemArray[1].ToString();
        }

        private void groupBoxNoiDungTamUng_Enter(object sender, EventArgs e)
        {

        }

        private void subtabTamUngLuong_Click(object sender, EventArgs e)
        {

        }

        private void btnTamUngLuongTimKiem_Click(object sender, EventArgs e)
        {
            dtgTamUngLuong.Rows.Clear();
            if (txtTamUngLuongMaBoPhan.Text == "")
            {
                MessageBox.Show("Chưa nhập mã bộ phận!");
            }

            DataTable ListBP = Database.query("select mabp, tenbp from bophan where mabp ='" + txtTamUngLuongMaBoPhan.Text + "'");
            if (ListBP.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy bộ phận này!");
                //dtgTamUngLuong.Rows.Clear();
                return;
            }

            txtTamUngLuongTenBoPhan.Text = ListBP.Rows[0].ItemArray[1].ToString();

            DataTable ListNV = Database.query("select manv, tennv from nhanvien where mabp='"+txtTamUngLuongMaBoPhan.Text+"'");
            if (ListNV.Rows.Count == 0)
            {
                MessageBox.Show(" Không tìm thấy nhân viên nào thuộc bộ phận này");
                return;
            }

            int tong = 0;
            for (int i = 0; i < ListNV.Rows.Count; i++)
            {
                int n = dtgTamUngLuong.Rows.Add();
                dtgTamUngLuong.Rows[n].Cells[0].Value = (i + 1).ToString();
                dtgTamUngLuong.Rows[n].Cells[1].Value = ListNV.Rows[i].ItemArray[1].ToString();
                dtgTamUngLuong.Rows[n].Cells[2].Value = ListNV.Rows[i].ItemArray[0].ToString();

                DataTable TULInfo = Database.query("select dvt, muctamung, thanhtien, ghichu from tamung where manv='" + ListNV.Rows[i].ItemArray[0].ToString() + "' and month(ngaytamung)=" + dtpKiTamUng.Value.ToString("MM") + " and year(ngaytamung) = " + dtpKiTamUng.Value.ToString("yyyy"));
                if (TULInfo.Rows.Count == 0)
                {
                    dtgTamUngLuong.Rows[n].Cells[3].Value = "VNĐ";
                    dtgTamUngLuong.Rows[n].Cells[4].Value = "0";
                    dtgTamUngLuong.Rows[n].Cells[5].Value = "0";
                    dtgTamUngLuong.Rows[n].Cells[6].Value = "";
                }
                else
                {
                    dtgTamUngLuong.Rows[n].Cells[3].Value = TULInfo.Rows[0].ItemArray[0].ToString();
                    dtgTamUngLuong.Rows[n].Cells[4].Value = TULInfo.Rows[0].ItemArray[1].ToString();
                    dtgTamUngLuong.Rows[n].Cells[5].Value = TULInfo.Rows[0].ItemArray[2].ToString();
                    dtgTamUngLuong.Rows[n].Cells[6].Value = TULInfo.Rows[0].ItemArray[3].ToString();
                    tong += Convert.ToInt32(dtgTamUngLuong.Rows[n].Cells[5].Value.ToString());
                }
            }
            dtgTamUngLuong.Rows.Add();
            int t = dtgTamUngLuong.Rows.Add();
            dtgTamUngLuong.Rows[t].Cells[1].Value = "Tổng";
            dtgTamUngLuong.Rows[t].Cells[3].Value = "VNĐ";
            dtgTamUngLuong.Rows[t].Cells[5].Value = tong.ToString();

        }

        private void dtpKiTamUng_ValueChanged(object sender, EventArgs e)
        {
            dtgTamUngLuong.Rows.Clear();
        }

        private void subtabTinhLuongCacKhoanTinhThem_Click(object sender, EventArgs e)
        {

        }

        private void txtTinhLuongMaBoPhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTinhLuongMaBoPhan.Text == "")
                    return;
                DataTable BPInfo = Database.query("select mabp, tenbp from bophan where mabp='"+txtTinhLuongMaBoPhan.Text+"'");
                if (BPInfo.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy bộ phận có mã bộ phận này!");
                    txtTinhLuongTenBoPhan.Text = "";
                    return;
                }
                txtTinhLuongTenBoPhan.Text = BPInfo.Rows[0].ItemArray[1].ToString();
            }
        }

        private void txtTinhLuongMaNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
           /* if (e.KeyCode == Keys.Enter)
            {
                if (txtMaNhanVien.Text == "")
                    return;

                DataTable NVInfo = Database.query("select manv, tennv from nhanvien where manv='"+txtTinhLuongMaNhanVien.Text+"'");
                if (NVInfo.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên có mã nhân viên trên!");
                    txtTinhLuongTenNhanVien.Text = "";
                    return;
                }
                txtTinhLuongTenNhanVien.Text = NVInfo.Rows[0].ItemArray[1].ToString();
            }*/
        }

        public void btnTinhLuongTimKiem_Click(object sender, EventArgs e)
        {
            //frmThemKhoan frm = new frmThemKhoan();

            dtgTinhLuongCacKhoanPhaiTru.Rows.Clear();
            dtgTinhLuongLuongChinh.Rows.Clear();
            dtgTinhLuongCacKhoanTinhThem.Rows.Clear();

            if (txtTinhLuongMaNhanVien.Text == "")
                return;

            DataTable NVInfo = Database.query("select manv, tennv, mabp from nhanvien where manv='"+txtTinhLuongMaNhanVien.Text+"'");

            txtTinhLuongTenBoPhan.Text = "";
            txtTinhLuongMaBoPhan.Text = "";
            txtTinhLuongTenNhanVien.Text = "";

            if (NVInfo.Rows.Count == 0)
            {
                MessageBox.Show(" Không tìm thấy nhân viên này!");
                return;
            }

            txtTinhLuongTenNhanVien.Text = NVInfo.Rows[0].ItemArray[1].ToString();
            txtTinhLuongMaBoPhan.Text = NVInfo.Rows[0].ItemArray[2].ToString();

            DataTable BPInfo = Database.query("select mabp, tenbp from bophan where mabp='"+NVInfo.Rows[0].ItemArray[2].ToString()+"'");
            txtTinhLuongTenBoPhan.Text = BPInfo.Rows[0].ItemArray[1].ToString();

            DataTable ChamCongInfo = Database.query("select sum(congchinh), sum(congnghi), sum(lamthemgio), sum(trucchunhat) from chamcong_history where manv='" + txtTinhLuongMaNhanVien.Text + "' and ngay >= '" + dtpTuNgay.Value.ToString("yyyy-MM-dd") + "' and ngay<='" + dtpDenNgay.Value.ToString("yyyy-MM-dd") + "'");

            DataTable LuongChinhInfo = Database.query("select makhoan, soluong, ghichu, ngay,manv from luongchinh where ngay<='" + dtpDenNgay.Value.ToString("yyyy-MM-dd") + "' and ngay>='" +dtpTuNgay.Value.ToString("yyyy-MM-dd") + "' and manv='"+txtTinhLuongMaNhanVien.Text+"'");

            ListLuongChinh = LuongChinhInfo;
            DataTable ListKhoanLuong = Database.query("select khoanluong.makhoan, tenkhoan, donvitinh, dongia from khoanluong, giatrikhoanluong where khoanluong.makhoan = giatrikhoanluong.makhoan and giatrikhoanluong.mabp='" + BPInfo.Rows[0].ItemArray[0].ToString() + "'");
            DataTable ListKhoanTru = Database.query("select makhoan, tenkhoan, donvitinh, dongia from khoantru");

            int tong = 0;
            int n = dtgTinhLuongLuongChinh.Rows.Add();
            dtgTinhLuongLuongChinh.Rows[n].Cells[0].Value = "1";
            dtgTinhLuongLuongChinh.Rows[n].Cells[1].Value = ListKhoanLuong.Rows[0].ItemArray[1].ToString();
            dtgTinhLuongLuongChinh.Rows[n].Cells[2].Value = ListKhoanLuong.Rows[0].ItemArray[0].ToString();
            dtgTinhLuongLuongChinh.Rows[n].Cells[3].Value = ListKhoanLuong.Rows[0].ItemArray[2].ToString();
            dtgTinhLuongLuongChinh.Rows[n].Cells[4].Value = ChamCongInfo.Rows[0].ItemArray[0].ToString();
            
            if (dtgTinhLuongLuongChinh.Rows[n].Cells[4].Value == "")
                dtgTinhLuongLuongChinh.Rows[n].Cells[4].Value = "0";

            dtgTinhLuongLuongChinh.Rows[n].Cells[5].Value = ListKhoanLuong.Rows[0].ItemArray[3].ToString();
            dtgTinhLuongLuongChinh.Rows[n].Cells[6].Value = (Convert.ToInt32(dtgTinhLuongLuongChinh.Rows[n].Cells[5].Value) * Convert.ToInt32(dtgTinhLuongLuongChinh.Rows[n].Cells[4].Value)).ToString();
            tong += Convert.ToInt32(dtgTinhLuongLuongChinh.Rows[n].Cells[6].Value);
            for (int i = 0; i < LuongChinhInfo.Rows.Count; i++)
                for (int j=0; j< ListKhoanLuong.Rows.Count; j++)
                    if (ListKhoanLuong.Rows[j].ItemArray[0].ToString() == LuongChinhInfo.Rows[i].ItemArray[0].ToString())
            {
                n = dtgTinhLuongLuongChinh.Rows.Add();
                dtgTinhLuongLuongChinh.Rows[n].Cells[0].Value = (i + 2).ToString();
                dtgTinhLuongLuongChinh.Rows[n].Cells[1].Value = ListKhoanLuong.Rows[j].ItemArray[1].ToString();
                dtgTinhLuongLuongChinh.Rows[n].Cells[2].Value = ListKhoanLuong.Rows[j].ItemArray[0].ToString();
                dtgTinhLuongLuongChinh.Rows[n].Cells[3].Value = ListKhoanLuong.Rows[j].ItemArray[2].ToString();
                dtgTinhLuongLuongChinh.Rows[n].Cells[4].Value = LuongChinhInfo.Rows[i].ItemArray[1].ToString();

                if (dtgTinhLuongLuongChinh.Rows[n].Cells[4].Value.ToString() == "")
                    dtgTinhLuongLuongChinh.Rows[n].Cells[4].Value = "0";

                dtgTinhLuongLuongChinh.Rows[n].Cells[5].Value = ListKhoanLuong.Rows[0].ItemArray[3].ToString();
                dtgTinhLuongLuongChinh.Rows[n].Cells[6].Value = (Convert.ToInt32(dtgTinhLuongLuongChinh.Rows[n].Cells[5].Value) * Convert.ToInt32(dtgTinhLuongLuongChinh.Rows[n].Cells[4].Value)).ToString();

                dtgTinhLuongLuongChinh.Rows[n].Cells[7].Value = LuongChinhInfo.Rows[i].ItemArray[2].ToString();
                tong += Convert.ToInt32(dtgTinhLuongLuongChinh.Rows[n].Cells[6].Value);
             }

            int t = dtgTinhLuongLuongChinh.Rows.Add();
            t = dtgTinhLuongLuongChinh.Rows.Add();
            dtgTinhLuongLuongChinh.Rows[t].Cells[4].Value = "Tổng";
            dtgTinhLuongLuongChinh.Rows[t].Cells[6].Value = tong.ToString();

            tong = 0;
            n = dtgTinhLuongCacKhoanTinhThem.Rows.Add();
            dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[0].Value = "1";
            dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[1].Value = ListKhoanLuong.Rows[2].ItemArray[1].ToString();
            dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[2].Value = ListKhoanLuong.Rows[2].ItemArray[0].ToString();
            dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[3].Value = ListKhoanLuong.Rows[2].ItemArray[2].ToString();
            try
            {
                dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[4].Value = ChamCongInfo.Rows[0].ItemArray[2].ToString();

                if (dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[4].Value == "")
                    dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[4].Value = "0";
            }
            catch (Exception ex)
            {
                dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[4].Value = "0";
            }
            dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[5].Value = ListKhoanLuong.Rows[2].ItemArray[3].ToString();
            dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[6].Value = (Convert.ToInt32(dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[5].Value) * Convert.ToInt32(dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[4].Value)).ToString();
            tong += Convert.ToInt32(dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[6].Value);
            n = dtgTinhLuongCacKhoanTinhThem.Rows.Add();
            dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[0].Value = "2";
            dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[1].Value = ListKhoanLuong.Rows[3].ItemArray[1].ToString();
            dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[2].Value = ListKhoanLuong.Rows[3].ItemArray[0].ToString();
            dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[3].Value = ListKhoanLuong.Rows[3].ItemArray[2].ToString();
            dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[4].Value = ChamCongInfo.Rows[0].ItemArray[3].ToString();

            if (dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[4].Value == "")
                dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[4].Value = "0";

            dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[5].Value = ListKhoanLuong.Rows[3].ItemArray[3].ToString();
            dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[6].Value = (Convert.ToInt32(dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[5].Value) * Convert.ToInt32(dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[4].Value)).ToString();
            tong += Convert.ToInt32(dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[6].Value);
            DataTable LuongTinhThemInfo = Database.query("select makhoan, soluong, ghichu, ngay, manv from luongtinhthem where ngay<='" + dtpDenNgay.Value.ToString("yyyy-MM-dd") + "' and ngay>='" +dtpTuNgay.Value.ToString("yyyy-MM-dd") + "' and manv='"+txtTinhLuongMaNhanVien.Text+"'");
            ListLuongThem = LuongTinhThemInfo;
            //MessageBox.Show(LuongTinhThemInfo.Rows.Count.ToString());
            for (int i = 0; i < LuongTinhThemInfo.Rows.Count; i++)
                for (int j=0; j<  ListKhoanLuong.Rows.Count; j++)
                    if (ListKhoanLuong.Rows[j].ItemArray[0].ToString() == LuongTinhThemInfo.Rows[i].ItemArray[0].ToString())

            {
                n = dtgTinhLuongCacKhoanTinhThem.Rows.Add();
                dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[0].Value = (i + 3).ToString();
                dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[1].Value = ListKhoanLuong.Rows[j].ItemArray[1].ToString();
                dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[2].Value = ListKhoanLuong.Rows[j].ItemArray[0].ToString();
                dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[3].Value = ListKhoanLuong.Rows[j].ItemArray[2].ToString();
                dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[4].Value = LuongTinhThemInfo.Rows[i].ItemArray[1].ToString();

                if (dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[4].Value.ToString() == "")
                    dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[4].Value = "0";

                dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[5].Value = ListKhoanLuong.Rows[0].ItemArray[3].ToString();
                dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[6].Value = (Convert.ToInt32(dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[5].Value) * Convert.ToInt32(dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[4].Value)).ToString();

                dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[7].Value = LuongTinhThemInfo.Rows[i].ItemArray[2].ToString();
                tong += Convert.ToInt32(dtgTinhLuongCacKhoanTinhThem.Rows[n].Cells[6].Value);
            }

            t = dtgTinhLuongCacKhoanTinhThem.Rows.Add();
            t = dtgTinhLuongCacKhoanTinhThem.Rows.Add();
            dtgTinhLuongCacKhoanTinhThem.Rows[t].Cells[4].Value = "Tổng";
            dtgTinhLuongCacKhoanTinhThem.Rows[t].Cells[6].Value = tong.ToString();

            tong = 0;
            DataTable LuongTruInfo = Database.query("select makhoan, soluong, ghichu,ngay, manv from luongtru where ngay<='" + dtpDenNgay.Value.ToString("yyyy-MM-dd") + "' and ngay>='" + dtpTuNgay.Value.ToString("yyyy-MM-dd") + "' and manv='" + txtTinhLuongMaNhanVien.Text + "'");
            //MessageBox.Show(ListKhoanTru.Rows.Count.ToString());
            ListLuongTru = LuongTruInfo;
            for (int i = 0; i < LuongTruInfo.Rows.Count; i++)
                for (int j = 0; j < ListKhoanTru.Rows.Count; j++)
                    if (ListKhoanTru.Rows[j].ItemArray[0].ToString() == LuongTruInfo.Rows[i].ItemArray[0].ToString())
                    {
                        n = dtgTinhLuongCacKhoanPhaiTru.Rows.Add();
                        dtgTinhLuongCacKhoanPhaiTru.Rows[n].Cells[0].Value = (i + 1).ToString();
                        dtgTinhLuongCacKhoanPhaiTru.Rows[n].Cells[1].Value = ListKhoanTru.Rows[j].ItemArray[1].ToString();
                        dtgTinhLuongCacKhoanPhaiTru.Rows[n].Cells[2].Value = ListKhoanTru.Rows[j].ItemArray[0].ToString();
                        dtgTinhLuongCacKhoanPhaiTru.Rows[n].Cells[3].Value = ListKhoanTru.Rows[j].ItemArray[2].ToString();
                        dtgTinhLuongCacKhoanPhaiTru.Rows[n].Cells[4].Value = LuongTruInfo.Rows[i].ItemArray[1].ToString();

                        if (dtgTinhLuongCacKhoanPhaiTru.Rows[n].Cells[4].Value.ToString() == "")
                            dtgTinhLuongCacKhoanPhaiTru.Rows[n].Cells[4].Value = "0";

                        dtgTinhLuongCacKhoanPhaiTru.Rows[n].Cells[5].Value = ListKhoanTru.Rows[0].ItemArray[3].ToString();
                        dtgTinhLuongCacKhoanPhaiTru.Rows[n].Cells[6].Value = (Convert.ToInt32(dtgTinhLuongCacKhoanPhaiTru.Rows[n].Cells[5].Value) * Convert.ToInt32(dtgTinhLuongCacKhoanPhaiTru.Rows[n].Cells[4].Value)).ToString();

                        dtgTinhLuongCacKhoanPhaiTru.Rows[n].Cells[7].Value = LuongTruInfo.Rows[i].ItemArray[2].ToString();
                        tong += Convert.ToInt32(dtgTinhLuongCacKhoanPhaiTru.Rows[n].Cells[6].Value);
                    }
            dtgTinhLuongCacKhoanPhaiTru.Rows.Add();
            t = dtgTinhLuongCacKhoanPhaiTru.Rows.Add();
            dtgTinhLuongCacKhoanPhaiTru.Rows[t].Cells[4].Value = "Tổng";
            dtgTinhLuongCacKhoanPhaiTru.Rows[t].Cells[6].Value = tong.ToString();
            //dtgTin
        }

        private void btThemKhoan_Click(object sender, EventArgs e)
        {
            Form f = new frmThemKhoan(txtTinhLuongMaNhanVien.Text,this);
            //f.MdiParent = this;
            f.Show();
        }

        private void btnXoaKhoan_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tabTinhLuong.SelectedTab.Text);
            try
            {
                if (tabTinhLuong.SelectedTab.Text == "Lương chính")
                {
                    for (int i = 0; i <= ListLuongChinh.Rows.Count; i++)
                        if (dtgTinhLuongLuongChinh.Rows[i + 1].Selected == true)
                        {
                            Database.query("delete from luongchinh where ngay='" + ListLuongChinh.Rows[i].ItemArray[3].ToString() + "' and manv='" + ListLuongChinh.Rows[i].ItemArray[4].ToString() + "' and makhoan='" + ListLuongChinh.Rows[i].ItemArray[0].ToString() + "'");
                            btnTinhLuongTimKiem_Click(sender, e);
                        }
                }

                if (tabTinhLuong.SelectedTab.Text == "Các khoản tính thêm")
                {
                    for (int i = 0; i <= ListLuongThem.Rows.Count; i++)
                        if (dtgTinhLuongCacKhoanTinhThem.Rows[i + 2].Selected == true)
                        {
                            Database.query("delete from luongtinhthem where ngay='" + ListLuongThem.Rows[i].ItemArray[3].ToString() + "' and manv='" + ListLuongThem.Rows[i].ItemArray[4].ToString() + "' and makhoan='" + ListLuongThem.Rows[i].ItemArray[0].ToString() + "'");
                            btnTinhLuongTimKiem_Click(sender, e);
                        }
                }
                //MessageBox.Show("'"+tabTinhLuong.SelectedTab.Text+"'");
                if (tabTinhLuong.SelectedTab.Text == "Các khoản phải trừ")
                {
                    //MessageBox.Show(ListLuongTru.Rows.Count.ToString());
                    for (int i = 0; i <= ListLuongTru.Rows.Count; i++)
                        if (dtgTinhLuongCacKhoanPhaiTru.Rows[i].Selected == true)
                        {
                            System.Console.WriteLine("delete from luongtru where ngay='" + ListLuongTru.Rows[i].ItemArray[3].ToString() + "' and manv='" + ListLuongTru.Rows[i].ItemArray[4].ToString() + "' and makhoan='" + ListLuongTru.Rows[i].ItemArray[0].ToString() + "'");
                            Database.query("delete from luongtru where ngay='" + ListLuongTru.Rows[i].ItemArray[3].ToString() + "' and manv='" + ListLuongTru.Rows[i].ItemArray[4].ToString() + "' and makhoan='" + ListLuongTru.Rows[i].ItemArray[0].ToString() + "'");
                            btnTinhLuongTimKiem_Click(sender, e);
                        }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnXemPhieuThanhToanLuong_Click_1(object sender, EventArgs e)
        {
            Form f = new FrmXemPhieuThanhToan(txtTinhLuongMaNhanVien.Text, txtTinhLuongMaBoPhan.Text, dtgTinhLuongLuongChinh , dtgTinhLuongCacKhoanTinhThem, dtgTinhLuongCacKhoanPhaiTru,dtpTuNgay,dtpDenNgay);
            f.Show();
        }

        private void subtabTongHopKetQuaLamViec_Click(object sender, EventArgs e)
        {

        }

        private void cbTongHopKetQuaLamViecTenBoPhan_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                 //MessageBox.Show(cbTongHopKetQuaLamViecTenBoPhan.SelectedValue.ToString());
                 BHCNModel.UpdateComboBoxByQuery(cbTongHopKetQuaLamViecMaBoPhan, "select mabp from bophan where tenbp='" + cbTongHopKetQuaLamViecTenBoPhan.Text + "'", "mabp");
                 BHCNModel.UpdateComboBoxByQuery(cbTongHopKetQuaLamViecTenNhanVien, "select tennv from nhanvien where mabp='"+cbTongHopKetQuaLamViecMaBoPhan.Text+"'", "tennv");
                 BHCNModel.UpdateComboBoxByQuery(cbTongHopKetQuaLamViecMaNhanVien, "select manv from nhanvien where mabp='"+cbTongHopKetQuaLamViecMaBoPhan.Text+"'", "manv");
            }
            catch (Exception ex)
            {
            }
        }

        private void cbTongHopKetQuaLamViecMaBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTongHopKetQuaLamViecTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            BHCNModel.UpdateComboBoxByQuery(cbTongHopKetQuaLamViecMaNhanVien, "select manv from nhanvien where tennv='"+cbTongHopKetQuaLamViecTenNhanVien.Text+"'", "manv");
        }

        private void txtTinhLuongTenBoPhan_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                //MessageBox.Show(cbTongHopKetQuaLLuoamViecTenBoPhan.SelectedValue.ToString());
                BHCNModel.UpdateComboBoxByQuery(txtTinhLuongMaBoPhan, "select mabp from bophan where tenbp='" + txtTinhLuongTenBoPhan.Text + "'", "mabp");
                BHCNModel.UpdateComboBoxByQuery(txtTinhLuongTenNhanVien, "select tennv from nhanvien where mabp='" + txtTinhLuongMaBoPhan.Text + "'", "tennv");
                BHCNModel.UpdateComboBoxByQuery(txtTinhLuongMaNhanVien, "select manv from nhanvien where mabp='" + txtTinhLuongMaBoPhan.Text + "'", "manv");
            }
            catch (Exception ex)
            {
            }
        }

        private void txtTinhLuongTenNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            BHCNModel.UpdateComboBoxByQuery(cbTongHopKetQuaLamViecMaNhanVien, "select manv from nhanvien where tennv='" + txtTinhLuongTenNhanVien.Text + "'", "manv");
        }

        private void cbTongHopKetQuaLamViecTenBoPhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbTongHopKetQuaLamViecTenBoPhan_SelectedValueChanged(sender, e);
            }
        }

        private void txtTinhLuongTenBoPhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTinhLuongTenBoPhan_SelectedValueChanged(sender, e);
            }
        }

        private void txtTinhLuongTenNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTinhLuongTenNhanVien_SelectedValueChanged(sender, e);
            }
        }

        private void txtTamUngLuongTenBoPhan_SelectedValueChanged(object sender, EventArgs e)
        {

            BHCNModel.UpdateComboBoxByQuery(txtTamUngLuongMaBoPhan,"select mabp from bophan where tenbp='"+txtTamUngLuongTenBoPhan.Text+"'","mabp");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtChamCongTenBoPhan_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {

                //MessageBox.Show(cbTongHopKetQuaLLuoamViecTenBoPhan.SelectedValue.ToString());
                BHCNModel.UpdateComboBoxByQuery(txtChamCongMaBoPhan, "select mabp from bophan where tenbp='" + txtChamCongTenBoPhan.Text + "'", "mabp");
                BHCNModel.UpdateComboBoxByQuery(txtChamCongTenNhanVien, "select tennv from nhanvien where mabp='" + txtChamCongMaBoPhan.Text + "'", "tennv");
                BHCNModel.UpdateComboBoxByQuery(txtChamCongMaNhanVien, "select manv from nhanvien where mabp='" + txtChamCongMaBoPhan.Text + "'", "manv");
            }
            catch (Exception ex)
            {
            }
        }

        private void txtChamCongTenNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            BHCNModel.UpdateComboBoxByQuery(txtChamCongMaNhanVien, "select manv from nhanvien where tennv='" + txtChamCongTenNhanVien.Text + "'", "manv");

        }
        

    }
}

