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
    public partial class frmBoPhanMoi : Form
    {
        public frmBoPhanMoi()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if ((txtMaBoPhan.Text == "") || (txtTenBoPhan.Text == ""))
                return;

            DataTable tmp = Database.query("select * from bophan where mabp='"+txtTenBoPhan.Text+"'");
            if (tmp.Rows.Count > 0)
            {
                MessageBox.Show("Đã tồn tại mã bộ phận này!");
            }
            else
            {
                Database.query("insert into bophan(mabp, tenbp) values('"+txtMaBoPhan.Text+"','"+txtTenBoPhan.Text+"')");
                this.Close();
            }
        }
    }
}
