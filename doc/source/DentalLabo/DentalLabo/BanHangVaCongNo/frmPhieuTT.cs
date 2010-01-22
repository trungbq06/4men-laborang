using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DentalLabo.BanHangVaCongNo;

namespace DentalLabo.Nhap_kho_va_ban_hang
{
    public partial class frmPhieuTT : Form
    {
        TongHopThanhToan_Model model;

        public frmPhieuTT()
        {
            InitializeComponent();
            model = new TongHopThanhToan_Model(this);
            model.InitLoadTenKH();
        }        


        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            if (!Validation.ChuaNhap(cmbMaKH.Text, "Chưa nhập mã khách hàng"))
                if (!Validation.ChuaNhap(dateNgayBatDau.Text, "Chưa nhập ngày bắt đầu"))
                    if (!Validation.ChuaNhap(dateNgayKetThuc.Text, "Chưa nhập ngày kết thúc"))
                    {
                        dtgChiTietCongNoKH.Rows.Clear();

                        if (BHCNModel.TimCacHDCuaKH(cmbMaKH.Text, dateNgayBatDau.Text, dateNgayKetThuc.Text).Rows.Count > 0)
                        {
                            model.countGT = 0;
                            model.ThemDongColor("Phát sinh nợ trong kỳ");
                            model.ThemCacHoaDon(cmbMaKH.Text, dateNgayBatDau.Text, dateNgayKetThuc.Text);
                            string TongHD = model.SinhDongTinhTongTien(TongHopThanhToan_Model.loaiMauHang);
                            model.ThemDong("", "");

                            model.ThemDongColor("Thanh toán trong ky");
                            model.ThemCacThanhToan(cmbMaKH.Text, dateNgayBatDau.Text, dateNgayKetThuc.Text);
                            string TongTT = model.SinhDongTinhTongTien(TongHopThanhToan_Model.loaiThanhToan);
                            model.ThemDong("", "");

                            model.ThemDongColor("Giảm trừ trong kỳ");
                            model.ThemCacGiamTru(cmbMaKH.Text, dateNgayBatDau.Text, dateNgayKetThuc.Text);
                            string TongGT = model.SinhDongTinhTongTien(TongHopThanhToan_Model.loaiGiamTru);
                            model.ThemDong("", "");

                            long TongSo = Int64.Parse(TongHD) - Int64.Parse(TongTT) - Int64.Parse(TongGT);
                            model.ThemDong("Tống số", TongSo.ToString());

                            //Database.debug = true;
                            txtDuDauKy.Text = BHCNModel.DuNoDenNgay(cmbMaKH.Text, dateNgayBatDau.Text);

                            long DuCuoiKy = Int64.Parse(txtDuDauKy.Text) + TongSo;
                            txtDuCuoiKy.Text = DuCuoiKy.ToString();

                            //Database.debug = false;
                        }
                        else
                        {
                            Database.Warning("Khách hàng " + cmbTenKH.Text + " không có giao dịch nào trong khoảng thời gian tìm kiếm");
                        }
                    }
        }

        private void cmbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateMaKH();
        }

        private void cmbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateTheoMaKH(true);
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            ArrayList array = new ArrayList();            

            array.Add("Tên khách hàng:  " + cmbTenKH.Text);
            array.Add("Mã khách hàng: " + cmbMaKH.Text);

            array.Add("Địa chỉ: " + txtDiaChi.Text);
            array.Add("");

            array.Add("Từ ngày: " + dateNgayBatDau.Text);
            array.Add("Đến ngày: " + dateNgayKetThuc.Text);

            PrintDataGrid.PrintDGV.Print_DataGridView(dtgChiTietCongNoKH, array);
        }
    }
}
