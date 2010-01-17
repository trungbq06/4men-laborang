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
    public partial class frmThemNoiDungYeuCau : Form
    {
        private string masomau;
        public frmThemNoiDungYeuCau(string _masomau)
        {
            InitializeComponent();
            masomau = _masomau;
        }

        private void frmThemNoiDungYeuCau_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(masomau);
            DataTable ListSP = Database.query("select masp, tensp from sanpham");
            DataTable ListVLC = Database.query("select mavl, tenvl from vatlieuchinh");
            DataTable ListVLP = Database.query("select mavl, tenvl from vatlieuphu");

            cbSanPham.DataSource = ListSP;
            cbSanPham.DisplayMember = "tensp";
            cbSanPham.ValueMember = "masp";

            cbVLC.DataSource = ListVLC;
            cbVLC.DisplayMember = "tenvl";
            cbVLC.ValueMember = "mavl";

            cbVLP.DataSource = ListVLP;
            cbVLP.DisplayMember = "tenvl";
            cbVLP.ValueMember = "mavl";
        }

        private void btnAddToDB_Click(object sender, EventArgs e)
        {
            if (masomau == "")
            {
                MessageBox.Show("Không tồn tại mẫu hàng này!");
                return;
            }

            int vitri=0;
            if (txtViTri.Text != ""){
                vitri = Convert.ToInt32(txtViTri.Text);
            }
                
            DataTable countSPDH = Database.query("select count(*)from sanphamdathang");
            String MaSPDatHang = "SPDH" + (Convert.ToInt32(countSPDH.Rows[0].ItemArray[0]) +1).ToString();
            
            //MessageBox.Show(cbSanPham.SelectedValue.ToString());
            String insertQuery = "insert into Sanphamdathang(maspdathang, masp, vitrirang, mavlc, mavlp, mausp, luuy, yeucauchitiet) values( ";
            insertQuery += "'" + MaSPDatHang + "',";
            insertQuery += "'" + cbSanPham.SelectedValue.ToString() + "',";
            insertQuery += vitri.ToString() + ",";
            insertQuery += "'" + cbVLC.SelectedValue.ToString() + "',";
            insertQuery += "'" + cbVLP.SelectedValue.ToString() + "',";
            insertQuery += "'" + txtMauSanPham.Text + "',";
            insertQuery += "'" + txtLuuy.Text + "',";
            insertQuery += "'" + txtYeuCauChiTiet.Text + "' )";
            //MessageBox.Show(insertQuery);
            //System.Console.WriteLine(insertQuery);
            Database.query(insertQuery);

            String insertQuery2 = "insert into mauhang_sanphamdathang(mamau, maspdathang) values ('"+masomau+"','"+MaSPDatHang+"')";
            Database.query(insertQuery2);
            this.Close();
        }


    }
}
