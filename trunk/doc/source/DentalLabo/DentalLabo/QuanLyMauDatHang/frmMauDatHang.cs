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
        bool isSearch = false;
        bool[] rangChoosed1 = new bool[32];
        bool[] rangChoosed2 = new bool[32];
        MauDatHang_Model model;
        String acctionString = "San Pham Moi";
        String loaiPH;
        String maSPDH;
        CheckBox[] arrRangCB1 = new CheckBox[32];
        CheckBox[] arrRangCB2 = new CheckBox[32];

        public frmMauDatHang()
        {
            InitializeComponent();
            model = new MauDatHang_Model(this);
            model.LoadTenNhom();
            model.SinhMaSoMau();
            model.LoadTenSanPham();
            model.LoadTenVLC();
            model.LoadTenVLP();
            for (int i = 0; i < 32; i++)
            {
                rangChoosed1[i] = false;
                rangChoosed2[i] = false;
            }
        }

        #region ChuyenRangVeText
        public string VTRangToXau(int giatri)
        {   
            int nhomRang = giatri / 8 + 1;
            int vtTrongNhom = -1;
            
            if (nhomRang == 3) nhomRang = 4;
            else if (nhomRang == 4) nhomRang = 3;

            if (nhomRang == 1 || nhomRang == 4) vtTrongNhom = 8 - giatri % 8;
            else if(nhomRang == 2 || nhomRang == 3) vtTrongNhom = giatri % 8 + 1;

            string xauthem = nhomRang.ToString() + vtTrongNhom.ToString();
            return xauthem;
        }
        
        private void StringViTri(bool[] array, String ph)
        {
            string vitrirang = "";
            int i = 0;
            int j = 0;
            int soluong1 = 0;
            int soluong2 = 0;
            int soluong = 0;
            int[] luu1 = new int[16];
            int[] luu2 = new int[16];
            int[] daycon = new int[16];
            for (i = 0; i < 16; i++) 
            {
                if (array[i] == true) luu1[j++] = i;
            }

            soluong1 = j;
            j = 0;

            for (i = 16; i < 32; i++)
            {
                if (array[i] == true) luu2[j++] = i;
            }
            soluong2 = j;
            soluong = soluong1 + soluong2;
            
            j = 0;
            i = 0;
            int start = i;
            int k = start + 1;

            #region hamrangtren
            if (soluong1 == 1)
            {
                vitrirang = vitrirang + VTRangToXau(luu1[0]) + ", ";
            }
            else
            {
                while (k < soluong1)
                {
                    i++;
                    if (luu1[k] != (luu1[start] + i))
                    {
                        if (k == start + 1)
                        {
                            vitrirang = vitrirang + VTRangToXau(luu1[start]) + ", ";
                            start = k;
                            k++;
                        }
                        else
                        {
                            if (k != start + 2)
                            {
                                vitrirang = vitrirang + VTRangToXau(luu1[start]) + "-";
                                vitrirang = vitrirang + VTRangToXau(luu1[k-1]) + ", ";
                            }
                            else
                            {
                                vitrirang = vitrirang + VTRangToXau(luu1[start]) + ", ";
                                vitrirang = vitrirang + VTRangToXau(luu1[k - 1]) + ", ";
                            }
                            start = k;
                            k++;
                            i = 0;
                        }
                    }
                    else
                    {
                        k++;
                    }
                    if (k == soluong1)
                    {
                        if (k != start + 1)
                        {
                            if (k != start + 2)
                            {
                                vitrirang = vitrirang + VTRangToXau(luu1[start]) + "-";
                                vitrirang = vitrirang + VTRangToXau(luu1[k - 1]) + ", ";
                            }
                            else
                            {
                                vitrirang = vitrirang + VTRangToXau(luu1[start]) + ", ";
                                vitrirang = vitrirang + VTRangToXau(luu1[k - 1]) + ", ";
                            }
                        }
                        else
                        {
                            vitrirang = vitrirang + VTRangToXau(luu1[start]) + ", ";
                        }
                    }
                }
            }
            #endregion

            j = 0;
            i = 0;
            start = 0;
            k = start + 1;

            #region hamrangduoi
            if (soluong2 == 1)
            {
                vitrirang = vitrirang + VTRangToXau(luu2[0]) + ", ";
            }
            else
            {
                while (k < soluong2)
                {
                    i++;
                    if (luu2[k] != (luu2[start] + i))
                    {
                        if (k == start + 1)
                        {
                            vitrirang = vitrirang + VTRangToXau(luu2[start]) + ", ";
                            start = k;
                            k++;
                        }
                        else
                        {
                            if (k != start + 2)
                            {
                                vitrirang = vitrirang + VTRangToXau(luu2[start]) + "-";
                                vitrirang = vitrirang + VTRangToXau(luu2[k - 1]) + ", ";
                            }
                            else
                            {
                                vitrirang = vitrirang + VTRangToXau(luu2[start]) + ", ";
                                vitrirang = vitrirang + VTRangToXau(luu2[k - 1]) + ", ";
                            }
                            start = k;
                            k++;
                            i = 0;
                        }
                    }
                    else
                    {
                        k++;
                    }
                    if (k == soluong2)
                    {
                        if (k != start + 1)
                        {
                            if (k != start + 2)
                            {
                                vitrirang = vitrirang + VTRangToXau(luu2[start]) + "-";
                                vitrirang = vitrirang + VTRangToXau(luu2[k - 1]) + ", ";
                            }
                            else
                            {
                                vitrirang = vitrirang + VTRangToXau(luu2[start]) + ", ";
                                vitrirang = vitrirang + VTRangToXau(luu2[k - 1]) + ", ";
                            }
                        }
                        else
                        {
                            vitrirang = vitrirang + VTRangToXau(luu2[start]) + ", ";
                        }
                    }
                }
            }
            #endregion

            if (vitrirang.Length > 2) vitrirang = vitrirang.Substring(0, vitrirang.Length - 2).ToString();
            if (ph == "1")
            {
                txtViTriRang.Text = vitrirang;
                txtSoLuongRang.Text = soluong.ToString();
            }
            else
            {
                txtViTriRang2.Text = vitrirang;
                txtSoLuongRang2.Text = soluong.ToString();
            }
            
        }
        #endregion

        #region resetChonRang
        public void resetRangBut(String LoaiPhucHinh)
        {
            if (LoaiPhucHinh == "1")
            {
                #region
                btRang18_1.BackColor = Color.Transparent;
                btRang17_1.BackColor = Color.Transparent;
                btRang16_1.BackColor = Color.Transparent;
                btRang15_1.BackColor = Color.Transparent;
                btRang14_1.BackColor = Color.Transparent;
                btRang13_1.BackColor = Color.Transparent;
                btRang12_1.BackColor = Color.Transparent;
                btRang11_1.BackColor = Color.Transparent;
                btRang21_1.BackColor = Color.Transparent;
                btRang22_1.BackColor = Color.Transparent;
                btRang23_1.BackColor = Color.Transparent;
                btRang24_1.BackColor = Color.Transparent;
                btRang25_1.BackColor = Color.Transparent;
                btRang26_1.BackColor = Color.Transparent;
                btRang27_1.BackColor = Color.Transparent;
                btRang28_1.BackColor = Color.Transparent;
                btRang48_1.BackColor = Color.Transparent;
                btRang47_1.BackColor = Color.Transparent;
                btRang46_1.BackColor = Color.Transparent;
                btRang45_1.BackColor = Color.Transparent;
                btRang44_1.BackColor = Color.Transparent;
                btRang43_1.BackColor = Color.Transparent;
                btRang42_1.BackColor = Color.Transparent;
                btRang41_1.BackColor = Color.Transparent;
                btRang31_1.BackColor = Color.Transparent;
                btRang32_1.BackColor = Color.Transparent;
                btRang33_1.BackColor = Color.Transparent;
                btRang34_1.BackColor = Color.Transparent;
                btRang35_1.BackColor = Color.Transparent;
                btRang36_1.BackColor = Color.Transparent;
                btRang37_1.BackColor = Color.Transparent;
                btRang38_1.BackColor = Color.Transparent;

                #endregion
            }
            else
            {
                #region
                btRang18_2.BackColor = Color.Transparent;
                btRang17_2.BackColor = Color.Transparent;
                btRang16_2.BackColor = Color.Transparent;
                btRang15_2.BackColor = Color.Transparent;
                btRang14_2.BackColor = Color.Transparent;
                btRang13_2.BackColor = Color.Transparent;
                btRang12_2.BackColor = Color.Transparent;
                btRang11_2.BackColor = Color.Transparent;
                btRang21_2.BackColor = Color.Transparent;
                btRang22_2.BackColor = Color.Transparent;
                btRang23_2.BackColor = Color.Transparent;
                btRang24_2.BackColor = Color.Transparent;
                btRang25_2.BackColor = Color.Transparent;
                btRang26_2.BackColor = Color.Transparent;
                btRang27_2.BackColor = Color.Transparent;
                btRang28_2.BackColor = Color.Transparent;
                btRang48_2.BackColor = Color.Transparent;
                btRang47_2.BackColor = Color.Transparent;
                btRang46_2.BackColor = Color.Transparent;
                btRang45_2.BackColor = Color.Transparent;
                btRang44_2.BackColor = Color.Transparent;
                btRang43_2.BackColor = Color.Transparent;
                btRang42_2.BackColor = Color.Transparent;
                btRang41_2.BackColor = Color.Transparent;
                btRang31_2.BackColor = Color.Transparent;
                btRang32_2.BackColor = Color.Transparent;
                btRang33_2.BackColor = Color.Transparent;
                btRang34_2.BackColor = Color.Transparent;
                btRang35_2.BackColor = Color.Transparent;
                btRang36_2.BackColor = Color.Transparent;
                btRang37_2.BackColor = Color.Transparent;
                btRang38_2.BackColor = Color.Transparent;

                #endregion
            }
        }
        #endregion

        #region chuadung
        // ham nhan  xau tu form chon rang
        public void GetValue1(String str1)
        {
            txtViTriRang.Text = str1;
        }
        public void GetValue2(String str1)
        {
            txtViTriRang2.Text = str1;
        }
        #endregion

        #region Actions
        // Luu button
        private void button7_Click(object sender, EventArgs e)
        {
            model.LuuAction(acctionString, loaiPH, maSPDH);
        }

        // khach hang moi form 1
        private void button2_Click(object sender, EventArgs e)
        {
            // reset thong tin lien quan mau
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

            // luu action va loai phuc hinh dang thao tac
            acctionString = "Mau moi";
            loaiPH = "1";

            // reset thong tin lien quan den san pham
            txtMauSP.ResetText();
            txtLyDo.ResetText();
            txtLuuY.ResetText();
            txtViTriRang.ResetText();
            txtYeuCauChiTiet.ResetText();
            cmbThaoTac.SelectedIndex = 0;
            cmbTenSP.SelectedIndex = 0;
            cmbLoaiVatLieu.SelectedIndex = 0;
            resetRangBut("1");
            model.UpdateMaVatLieu(cmbLoaiVatLieu.Items[cmbLoaiVatLieu.SelectedIndex].ToString());
            model.UpdateMaSanPham(cmbTenSP.Items[cmbTenSP.SelectedIndex].ToString());
        }

        // Maumoi form 1
        private void button3_Click(object sender, EventArgs e)
        {
            model.SinhMaSoMau();
            dtgNoiDungMau.Rows.Clear();
            dateNgayNhan.ResetText();
            dateGioTra.Text = "12h";
            dateNgayTra.ResetText();
            txtTenBN.ResetText();
            txtTuoiBN.ResetText();
            cmbGioiTinhBN.Text = "Nam";
            acctionString = "Mau moi";
            loaiPH = "1";

            // reset thong tin lien quan den san pham
            txtMauSP.ResetText();
            txtLyDo.ResetText();
            txtLuuY.ResetText();
            txtViTriRang.ResetText();
            txtYeuCauChiTiet.ResetText();
            cmbThaoTac.SelectedIndex = 0;
            cmbTenSP.SelectedIndex = 0;
            cmbLoaiVatLieu.SelectedIndex = 0;
            resetRangBut("1");
            model.UpdateMaVatLieu(cmbLoaiVatLieu.Items[cmbLoaiVatLieu.SelectedIndex].ToString());
            model.UpdateMaSanPham(cmbTenSP.Items[cmbTenSP.SelectedIndex].ToString());
        }

        // san pham moi form 1
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
            resetRangBut("1");
            model.UpdateMaVatLieu(cmbLoaiVatLieu.Items[cmbLoaiVatLieu.SelectedIndex].ToString());
            model.UpdateMaSanPham(cmbTenSP.Items[cmbTenSP.SelectedIndex].ToString());
            acctionString = "San Pham Moi";
            loaiPH = "1";
        }

        //  Them KH form 2
        private void button8_Click(object sender, EventArgs e)
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

            // reset thong tin san pham
            txtMauSP2.ResetText();
            txtTayMoc.ResetText();
            txtLyDo2.ResetText();
            txtViTriRang2.ResetText();
            txtYeuCauChiTiet2.ResetText();
            cmbThaoTac2.SelectedIndex = 0;
            cmbTenSP2.SelectedIndex = 0;
            cmbVLChinh.SelectedIndex = 0;
            cmbVLPhu.SelectedIndex = 0;
            resetRangBut("2");
            model.UpdateMaVLC(cmbVLChinh.Items[cmbVLChinh.SelectedIndex].ToString());
            model.UpdateMaSanPham2(cmbTenSP.Items[cmbTenSP.SelectedIndex].ToString());
            model.UpdateMaVLP(cmbVLPhu.Items[cmbVLPhu.SelectedIndex].ToString());
        }

        // mau moi form 2
        private void button9_Click(object sender, EventArgs e)
        {
            model.SinhMaSoMau();
            dtgNoiDungMau2.Rows.Clear();
            dateGioTra2.Text = "12h";
            dateNgayNhan.ResetText();
            dateNgayTra2.ResetText();
            txtTenBN2.ResetText();
            txtTuoiBN2.ResetText();
            cmbGioiTinhBN2.Text = "Nam";
            acctionString = "Mau moi";
            loaiPH = "2";

            // reset thong tin san pham
            txtMauSP2.ResetText();
            txtTayMoc.ResetText();
            txtLyDo2.ResetText();
            txtViTriRang2.ResetText();
            txtYeuCauChiTiet2.ResetText();
            cmbThaoTac2.SelectedIndex = 0;
            cmbTenSP2.SelectedIndex = 0;
            cmbVLChinh.SelectedIndex = 0;
            cmbVLPhu.SelectedIndex = 0;
            resetRangBut("2");
            model.UpdateMaVLC(cmbVLChinh.Items[cmbVLChinh.SelectedIndex].ToString());
            model.UpdateMaSanPham2(cmbTenSP.Items[cmbTenSP.SelectedIndex].ToString());
            model.UpdateMaVLP(cmbVLPhu.Items[cmbVLPhu.SelectedIndex].ToString());
        }

        // san pham moi form 2
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
            resetRangBut("2");
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

        private void cmbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tenKH = cmbTenKH.Text;
            model.UpdateMaSoKH(tenKH);
            String maKH = cmbMaKH.Text;
            model.UpdateAddKH(maKH);
            model.UpdatePhoneNumKH(maKH);
        }

        private void cmbNhomKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateMaNhom(cmbNhomKH.Items[cmbNhomKH.SelectedIndex].ToString());
            String maNhom = cmbMaNhomKH.Text;
            model.LoadTenKH(maNhom);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isSearch == false)
            {
                isSearch = true;
                button1.Text = "Tìm";
                txtSoMau.Enabled = true;
            }
            else
            {
                isSearch = false;
                button1.Text = "Tìm kiếm";
                txtSoMau.Enabled = false;
                model.TimKiemMau(true);
            }
        }

        private void cmbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.UpdateMaSanPham(cmbTenSP.Items[cmbTenSP.SelectedIndex].ToString());
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

        private void button14_Click(object sender, EventArgs e)
        {
            btRang38_2.BackColor = Color.Red;
        }
        #endregion

        #region ClickChonRang
        private void btRang17_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[1] == false)
            {
                btRang17_1.BackColor = Color.Violet;
                rangChoosed1[1] = true;
            }
            else
            {
                btRang17_1.BackColor = Color.Transparent;
                rangChoosed1[1] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang18_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[0] == false)
            {
                btRang18_1.BackColor = Color.Violet;
                rangChoosed1[0] = true;
            }
            else
            {
                btRang18_1.BackColor = Color.Transparent;
                rangChoosed1[0] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang16_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[2] == false)
            {
                btRang16_1.BackColor = Color.Violet;
                rangChoosed1[2] = true;
            }
            else
            {
                btRang16_1.BackColor = Color.Transparent;
                rangChoosed1[2] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang15_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[3] == false)
            {
                btRang15_1.BackColor = Color.Violet;
                rangChoosed1[3] = true;
            }
            else
            {
                btRang15_1.BackColor = Color.Transparent;
                rangChoosed1[3] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang14_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[4] == false)
            {
                btRang14_1.BackColor = Color.Violet;
                rangChoosed1[4] = true;
            }
            else
            {
                btRang14_1.BackColor = Color.Transparent;
                rangChoosed1[4] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang13_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[5] == false)
            {
                btRang13_1.BackColor = Color.Violet;
                rangChoosed1[5] = true;
            }
            else
            {
                btRang13_1.BackColor = Color.Transparent;
                rangChoosed1[5] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang12_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[6] == false)
            {
                btRang12_1.BackColor = Color.Violet;
                rangChoosed1[6] = true;
            }
            else
            {
                btRang12_1.BackColor = Color.Transparent;
                rangChoosed1[6] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang11_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[7] == false)
            {
                btRang11_1.BackColor = Color.Violet;
                rangChoosed1[7] = true;
            }
            else
            {
                btRang11_1.BackColor = Color.Transparent;
                rangChoosed1[7] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang21_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[8] == false)
            {
                btRang21_1.BackColor = Color.Violet;
                rangChoosed1[8] = true;
            }
            else
            {
                btRang21_1.BackColor = Color.Transparent;
                rangChoosed1[8] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang22_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[9] == false)
            {
                btRang22_1.BackColor = Color.Violet;
                rangChoosed1[9] = true;
            }
            else
            {
                btRang22_1.BackColor = Color.Transparent;
                rangChoosed1[9] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang23_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[10] == false)
            {
                btRang23_1.BackColor = Color.Violet;
                rangChoosed1[10] = true;
            }
            else
            {
                btRang23_1.BackColor = Color.Transparent;
                rangChoosed1[10] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang24_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[11] == false)
            {
                btRang24_1.BackColor = Color.Violet;
                rangChoosed1[11] = true;
            }
            else
            {
                btRang24_1.BackColor = Color.Transparent;
                rangChoosed1[11] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang25_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[12] == false)
            {
                btRang25_1.BackColor = Color.Violet;
                rangChoosed1[12] = true;
            }
            else
            {
                btRang25_1.BackColor = Color.Transparent;
                rangChoosed1[12] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang26_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[13] == false)
            {
                btRang26_1.BackColor = Color.Violet;
                rangChoosed1[13] = true;
            }
            else
            {
                btRang26_1.BackColor = Color.Transparent;
                rangChoosed1[13] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang27_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[14] == false)
            {
                btRang27_1.BackColor = Color.Violet;
                rangChoosed1[14] = true;
            }
            else
            {
                btRang27_1.BackColor = Color.Transparent;
                rangChoosed1[14] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang28_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[15] == false)
            {
                btRang28_1.BackColor = Color.Violet;
                rangChoosed1[15] = true;
            }
            else
            {
                btRang28_1.BackColor = Color.Transparent;
                rangChoosed1[15] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang48_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[16] == false)
            {
                btRang48_1.BackColor = Color.Violet;
                rangChoosed1[16] = true;
            }
            else
            {
                btRang48_1.BackColor = Color.Transparent;
                rangChoosed1[16] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang47_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[17] == false)
            {
                btRang47_1.BackColor = Color.Violet;
                rangChoosed1[17] = true;
            }
            else
            {
                btRang47_1.BackColor = Color.Transparent;
                rangChoosed1[17] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang46_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[18] == false)
            {
                btRang46_1.BackColor = Color.Violet;
                rangChoosed1[18] = true;
            }
            else
            {
                btRang46_1.BackColor = Color.Transparent;
                rangChoosed1[18] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang45_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[19] == false)
            {
                btRang45_1.BackColor = Color.Violet;
                rangChoosed1[19] = true;
            }
            else
            {
                btRang45_1.BackColor = Color.Transparent;
                rangChoosed1[19] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang44_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[20] == false)
            {
                btRang44_1.BackColor = Color.Violet;
                rangChoosed1[20] = true;
            }
            else
            {
                btRang44_1.BackColor = Color.Transparent;
                rangChoosed1[20] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang43_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[21] == false)
            {
                btRang43_1.BackColor = Color.Violet;
                rangChoosed1[21] = true;
            }
            else
            {
                btRang43_1.BackColor = Color.Transparent;
                rangChoosed1[21] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang42_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[22] == false)
            {
                btRang42_1.BackColor = Color.Violet;
                rangChoosed1[22] = true;
            }
            else
            {
                btRang42_1.BackColor = Color.Transparent;
                rangChoosed1[22] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang41_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[23] == false)
            {
                btRang41_1.BackColor = Color.Violet;
                rangChoosed1[23] = true;
            }
            else
            {
                btRang41_1.BackColor = Color.Transparent;
                rangChoosed1[23] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang31_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[24] == false)
            {
                btRang31_1.BackColor = Color.Violet;
                rangChoosed1[24] = true;
            }
            else
            {
                btRang31_1.BackColor = Color.Transparent;
                rangChoosed1[24] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang32_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[25] == false)
            {
                btRang32_1.BackColor = Color.Violet;
                rangChoosed1[25] = true;
            }
            else
            {
                btRang32_1.BackColor = Color.Transparent;
                rangChoosed1[25] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang33_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[26] == false)
            {
                btRang33_1.BackColor = Color.Violet;
                rangChoosed1[26] = true;
            }
            else
            {
                btRang33_1.BackColor = Color.Transparent;
                rangChoosed1[26] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang34_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[27] == false)
            {
                btRang34_1.BackColor = Color.Violet;
                rangChoosed1[27] = true;
            }
            else
            {
                btRang34_1.BackColor = Color.Transparent;
                rangChoosed1[27] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang35_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[28] == false)
            {
                btRang35_1.BackColor = Color.Violet;
                rangChoosed1[28] = true;
            }
            else
            {
                btRang35_1.BackColor = Color.Transparent;
                rangChoosed1[28] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang36_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[29] == false)
            {
                btRang36_1.BackColor = Color.Violet;
                rangChoosed1[29] = true;
            }
            else
            {
                btRang36_1.BackColor = Color.Transparent;
                rangChoosed1[29] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang37_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[30] == false)
            {
                btRang37_1.BackColor = Color.Violet;
                rangChoosed1[30] = true;
            }
            else
            {
                btRang37_1.BackColor = Color.Transparent;
                rangChoosed1[30] = false;
            }
            StringViTri(rangChoosed1, "1");
        }

        private void btRang38_1_Click(object sender, EventArgs e)
        {
            if (rangChoosed1[31] == false)
            {
                btRang38_1.BackColor = Color.Violet;
                rangChoosed1[31] = true;
            }
            else
            {
                btRang38_1.BackColor = Color.Transparent;
                rangChoosed1[31] = false;
            }
            StringViTri(rangChoosed1, "1");
        }
        #endregion

        #region ClickChonRang
        private void btRang17_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[1] == false)
            {
                btRang17_2.BackColor = Color.Violet;
                rangChoosed2[1] = true;
            }
            else
            {
                btRang17_2.BackColor = Color.Transparent;
                rangChoosed2[1] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang18_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[0] == false)
            {
                btRang18_2.BackColor = Color.Violet;
                rangChoosed2[0] = true;
            }
            else
            {
                btRang18_2.BackColor = Color.Transparent;
                rangChoosed2[0] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang16_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[2] == false)
            {
                btRang16_2.BackColor = Color.Violet;
                rangChoosed2[2] = true;
            }
            else
            {
                btRang16_2.BackColor = Color.Transparent;
                rangChoosed2[2] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang15_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[3] == false)
            {
                btRang15_2.BackColor = Color.Violet;
                rangChoosed2[3] = true;
            }
            else
            {
                btRang15_2.BackColor = Color.Transparent;
                rangChoosed2[3] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang14_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[4] == false)
            {
                btRang14_2.BackColor = Color.Violet;
                rangChoosed2[4] = true;
            }
            else
            {
                btRang14_2.BackColor = Color.Transparent;
                rangChoosed2[4] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang13_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[5] == false)
            {
                btRang13_2.BackColor = Color.Violet;
                rangChoosed2[5] = true;
            }
            else
            {
                btRang13_2.BackColor = Color.Transparent;
                rangChoosed2[5] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang12_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[6] == false)
            {
                btRang12_2.BackColor = Color.Violet;
                rangChoosed2[6] = true;
            }
            else
            {
                btRang12_2.BackColor = Color.Transparent;
                rangChoosed2[6] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang11_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[7] == false)
            {
                btRang11_2.BackColor = Color.Violet;
                rangChoosed2[7] = true;
            }
            else
            {
                btRang11_2.BackColor = Color.Transparent;
                rangChoosed2[7] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang21_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[8] == false)
            {
                btRang21_2.BackColor = Color.Violet;
                rangChoosed2[8] = true;
            }
            else
            {
                btRang21_2.BackColor = Color.Transparent;
                rangChoosed2[8] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang22_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[9] == false)
            {
                btRang22_2.BackColor = Color.Violet;
                rangChoosed2[9] = true;
            }
            else
            {
                btRang22_2.BackColor = Color.Transparent;
                rangChoosed2[9] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang23_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[10] == false)
            {
                btRang23_2.BackColor = Color.Violet;
                rangChoosed2[10] = true;
            }
            else
            {
                btRang23_2.BackColor = Color.Transparent;
                rangChoosed2[10] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang24_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[11] == false)
            {
                btRang24_2.BackColor = Color.Violet;
                rangChoosed2[11] = true;
            }
            else
            {
                btRang24_2.BackColor = Color.Transparent;
                rangChoosed2[11] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang25_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[12] == false)
            {
                btRang25_2.BackColor = Color.Violet;
                rangChoosed2[12] = true;
            }
            else
            {
                btRang25_2.BackColor = Color.Transparent;
                rangChoosed2[12] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang26_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[13] == false)
            {
                btRang26_2.BackColor = Color.Violet;
                rangChoosed2[13] = true;
            }
            else
            {
                btRang26_2.BackColor = Color.Transparent;
                rangChoosed2[13] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang27_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[14] == false)
            {
                btRang27_2.BackColor = Color.Violet;
                rangChoosed2[14] = true;
            }
            else
            {
                btRang27_2.BackColor = Color.Transparent;
                rangChoosed2[14] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang28_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[15] == false)
            {
                btRang28_2.BackColor = Color.Violet;
                rangChoosed2[15] = true;
            }
            else
            {
                btRang28_2.BackColor = Color.Transparent;
                rangChoosed2[15] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang48_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[16] == false)
            {
                btRang48_2.BackColor = Color.Violet;
                rangChoosed2[16] = true;
            }
            else
            {
                btRang48_2.BackColor = Color.Transparent;
                rangChoosed2[16] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang47_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[17] == false)
            {
                btRang47_2.BackColor = Color.Violet;
                rangChoosed2[17] = true;
            }
            else
            {
                btRang47_2.BackColor = Color.Transparent;
                rangChoosed2[17] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang46_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[18] == false)
            {
                btRang46_2.BackColor = Color.Violet;
                rangChoosed2[18] = true;
            }
            else
            {
                btRang46_2.BackColor = Color.Transparent;
                rangChoosed2[18] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang45_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[19] == false)
            {
                btRang45_2.BackColor = Color.Violet;
                rangChoosed2[19] = true;
            }
            else
            {
                btRang45_2.BackColor = Color.Transparent;
                rangChoosed2[19] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang44_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[20] == false)
            {
                btRang44_2.BackColor = Color.Violet;
                rangChoosed2[20] = true;
            }
            else
            {
                btRang44_2.BackColor = Color.Transparent;
                rangChoosed2[20] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang43_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[21] == false)
            {
                btRang43_2.BackColor = Color.Violet;
                rangChoosed2[21] = true;
            }
            else
            {
                btRang43_2.BackColor = Color.Transparent;
                rangChoosed2[21] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang42_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[22] == false)
            {
                btRang42_2.BackColor = Color.Violet;
                rangChoosed2[22] = true;
            }
            else
            {
                btRang42_2.BackColor = Color.Transparent;
                rangChoosed2[22] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang41_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[23] == false)
            {
                btRang41_2.BackColor = Color.Violet;
                rangChoosed2[23] = true;
            }
            else
            {
                btRang41_2.BackColor = Color.Transparent;
                rangChoosed2[23] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang31_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[24] == false)
            {
                btRang31_2.BackColor = Color.Violet;
                rangChoosed2[24] = true;
            }
            else
            {
                btRang31_2.BackColor = Color.Transparent;
                rangChoosed2[24] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang32_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[25] == false)
            {
                btRang32_2.BackColor = Color.Violet;
                rangChoosed2[25] = true;
            }
            else
            {
                btRang32_2.BackColor = Color.Transparent;
                rangChoosed2[25] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang33_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[26] == false)
            {
                btRang33_2.BackColor = Color.Violet;
                rangChoosed2[26] = true;
            }
            else
            {
                btRang33_2.BackColor = Color.Transparent;
                rangChoosed2[26] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang34_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[27] == false)
            {
                btRang34_2.BackColor = Color.Violet;
                rangChoosed2[27] = true;
            }
            else
            {
                btRang34_2.BackColor = Color.Transparent;
                rangChoosed2[27] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang35_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[28] == false)
            {
                btRang35_2.BackColor = Color.Violet;
                rangChoosed2[28] = true;
            }
            else
            {
                btRang35_2.BackColor = Color.Transparent;
                rangChoosed2[28] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang36_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[29] == false)
            {
                btRang36_2.BackColor = Color.Violet;
                rangChoosed2[29] = true;
            }
            else
            {
                btRang36_2.BackColor = Color.Transparent;
                rangChoosed2[29] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang37_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[30] == false)
            {
                btRang37_2.BackColor = Color.Violet;
                rangChoosed2[30] = true;
            }
            else
            {
                btRang37_2.BackColor = Color.Transparent;
                rangChoosed2[30] = false;
            }
            StringViTri(rangChoosed2, "2");
        }

        private void btRang38_2_Click(object sender, EventArgs e)
        {
            if (rangChoosed2[31] == false)
            {
                btRang38_2.BackColor = Color.Violet;
                rangChoosed2[31] = true;
            }
            else
            {
                btRang38_2.BackColor = Color.Transparent;
                rangChoosed2[31] = false;
            }
            StringViTri(rangChoosed2, "2");
        }
        #endregion
    }
}