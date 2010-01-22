using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DentalLabo.MauDatHang;

namespace DentalLabo.Mau_dat_hang
{
    public partial class frmMauDatHang : Form
    {
        MauDatHang_Model model;
        String acctionString = "San Pham Moi";
        String loaiPH;
        String maSPDH;
        public frmMauDatHang()
        {
            InitializeComponent();
            model = new MauDatHang_Model(this);
            model.LoadTenNhom();
            model.SinhMaSoMau();
            model.LoadTenSanPham();
            model.LoadTenVLC();
            model.LoadTenVLP();
        }

        // ham nhan  xau tu form chon rang
        public void GetValue1(String str1)
        {
            txtViTriRang.Text = str1;
        }
        public void GetValue2(String str1)
        {
            txtViTriRang2.Text = str1;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            model.LuuAction(acctionString, loaiPH, maSPDH);
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form f = new frmDanhMucKH();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            model.SinhMaSoMau();
            cmbNhomKH.SelectedIndex = 0;
            model.UpdateMaNhom(cmbNhomKH.Items[cmbNhomKH.SelectedIndex].ToString());
            cmbTenKH.SelectedIndex = 0;
            model.UpdateMaSoKH(cmbTenKH.Items[cmbTenKH.SelectedIndex].ToString());
            String maKH = cmbMaKH.Text;
            model.UpdateAddKH(maKH);
            model.UpdatePhoneNumKH(maKH);
            dtgNoiDungMau2.Rows.Clear();
            dateNgayNhan.ResetText();
            dateGioTra2.Text = "12h";
            dateNgayTra2.ResetText();
            txtTenBN2.ResetText();
            txtTuoiBN2.ResetText();
            cmbGioiTinhBN2.Text = "Nam";
            acctionString = "Mau moi";
            loaiPH = "2";
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtMauSP2.ResetText();
            txtTayMoc.ResetText();
            txtLyDo2.ResetText();
            txtViTriRang2.ResetText();
            txtYeuCauChiTiet2.ResetText();
            cmbThaoTac2.SelectedIndex = 0;
            cmbTenSP2.SelectedIndex = 0;
            cmbVLChinh.SelectedIndex = 0;
            cmbVLPhu.SelectedIndex = 0;
            model.UpdateMaVLC(cmbVLChinh.Items[cmbVLChinh.SelectedIndex].ToString());
            model.UpdateMaSanPham2(cmbTenSP.Items[cmbTenSP.SelectedIndex].ToString());
            model.UpdateMaVLP(cmbVLPhu.Items[cmbVLPhu.SelectedIndex].ToString());
            acctionString = "San Pham Moi";
            loaiPH = "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            maSPDH = model.CapNhatSanPham("2");
            if (maSPDH.Length >= 4)
            {
                if (maSPDH.Substring(0, 4).ToString() != "SPDH")
                {
                    acctionString = "Sua Mau";
                }
                else
                {
                    acctionString = "Cap nhat tu bang";
                }
            }
            else
            {
                acctionString = "Sua Mau";
            }
            loaiPH = "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            model.XoaSanPhamTuMau("2");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            model.LuuAction(acctionString, loaiPH, maSPDH);
        }

        private void frmMauDatHang_Load(object sender, EventArgs e)
        {

        }

        private void cmbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tenKH = cmbTenKH.Text;
            model.UpdateMaSoKH(tenKH);
            String maKH = cmbMaKH.Text;
            model.UpdateAddKH(maKH);
            model.UpdatePhoneNumKH(maKH);
        }

        private void cmbMaNhomKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNhomKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateMaNhom(cmbNhomKH.Items[cmbNhomKH.SelectedIndex].ToString());
            String maNhom = cmbMaNhomKH.Text;
            model.LoadTenKH(maNhom);
        }

        private void cmbDiaChiKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new frmDanhMucKH();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dtgNoiDungMau.Rows.Clear();
            //dtgNoiDungMau2.Rows.Clear();
            model.TimKiemMau(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //isUpdate = false;
            model.SinhMaSoMau();
            cmbNhomKH.SelectedIndex = 0;
            model.UpdateMaNhom(cmbNhomKH.Items[cmbNhomKH.SelectedIndex].ToString());
            cmbTenKH.SelectedIndex = 0;
            model.UpdateMaSoKH(cmbTenKH.Items[cmbTenKH.SelectedIndex].ToString());
            String maKH = cmbMaKH.Text;
            model.UpdateAddKH(maKH);
            model.UpdatePhoneNumKH(maKH);
            dtgNoiDungMau.Rows.Clear();
            dateNgayNhan.ResetText();
            dateGioTra.Text = "12h";
            dateNgayTra.ResetText();
            txtTenBN.ResetText();
            txtTuoiBN.ResetText();
            cmbGioiTinhBN.Text = "Nam";
            acctionString = "Mau moi";
            loaiPH = "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtMauSP.ResetText();
            txtLyDo.ResetText();
            txtLuuY.ResetText();
            txtViTriRang.ResetText();
            txtYeuCauChiTiet.ResetText();
            cmbThaoTac.SelectedIndex = 0;
            cmbTenSP.SelectedIndex = 0;
            cmbLoaiVatLieu.SelectedIndex = 0;
            model.UpdateMaVatLieu(cmbLoaiVatLieu.Items[cmbLoaiVatLieu.SelectedIndex].ToString());
            model.UpdateMaSanPham(cmbTenSP.Items[cmbTenSP.SelectedIndex].ToString());
            acctionString = "San Pham Moi";
            loaiPH = "1";
        }

        private void cmbThaoTac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateMaSanPham(cmbTenSP.Items[cmbTenSP.SelectedIndex].ToString());
        }

        private void cmbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbMaVatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLoaiVatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateMaVatLieu(cmbLoaiVatLieu.Items[cmbLoaiVatLieu.SelectedIndex].ToString());
        }

        private void cmbTenSP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateMaSanPham2(cmbTenSP2.Items[cmbTenSP2.SelectedIndex].ToString());
        }

        private void cmbVLPhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateMaVLP(cmbVLPhu.Items[cmbVLPhu.SelectedIndex].ToString());
        }

        private void cmbVLChinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateMaVLC(cmbVLChinh.Items[cmbVLChinh.SelectedIndex].ToString());
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void dtgNoiDungMau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            maSPDH = model.CapNhatSanPham("1");
            if (maSPDH.Length >= 4)
            {
                if (maSPDH.Substring(0, 4).ToString() != "SPDH")
                {
                    acctionString = "Sua Mau";
                }
                else
                {
                    acctionString = "Cap nhat tu bang";
                }
            }
            else
            {
                acctionString = "Sua Mau";   
            }
            loaiPH = "1";
        }

        private void cmbThaoTac2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmChonRang f = new frmChonRang();
            f.MdiParent = this.MdiParent;
            f.getString = new frmChonRang.GetString(GetValue2);
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmChonRang f = new frmChonRang();
            f.MdiParent = this.MdiParent;
            f.getString = new frmChonRang.GetString(GetValue1);
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            model.XoaSanPhamTuMau("1");
        }
    }
}
