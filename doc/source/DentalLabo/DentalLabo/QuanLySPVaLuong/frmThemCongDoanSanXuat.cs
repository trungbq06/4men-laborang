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
    public partial class frmThemCongDoanSanXuat : Form
    {
        private String masomau;
        public frmThemCongDoanSanXuat(String _masomau)
        {
            masomau = _masomau;
            InitializeComponent();
        }

        private void frmThemCongDoanSanXuat_Load(object sender, EventArgs e)
        {
            lblThemCongDoanSanXuat.Text = "THÊM CÔNG ĐOẠN SẢN XUẤT CHO MẪU '" + masomau + "'";

        }
    }
}
