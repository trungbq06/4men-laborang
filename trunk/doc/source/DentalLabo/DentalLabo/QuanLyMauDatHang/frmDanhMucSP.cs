using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DentalLabo.Data;
using DentalLabo.Bussiness;

namespace DentalLabo
{
    public partial class frmDanhMucSP : Form
    {
        public frmDanhMucSP()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmDanhMucSP_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DanhMucSP danhmuc = new DanhMucSP();
                MessageBox.Show(dtgDanhMucSP.Rows.Count.ToString());
                //MessageBox.Show(dtgDanhMucSP.CurrentRow.Cells[0].Value.ToString());
                danhmuc.MaSP = dtgDanhMucSP.CurrentRow.Cells[0].Value.ToString();
                danhmuc.TenSP = dtgDanhMucSP.CurrentRow.Cells[1].Value.ToString();
                danhmuc.PhamChat = dtgDanhMucSP.CurrentRow.Cells[2].Value.ToString();
                danhmuc.DVT = dtgDanhMucSP.CurrentRow.Cells[3].Value.ToString();
                danhmuc.NhomHangHoa = dtgDanhMucSP.CurrentRow.Cells[4].Value.ToString();
                danhmuc.GhiChu = dtgDanhMucSP.CurrentRow.Cells[5].Value.ToString();

                BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
                bsDanhMuc.AddDanhMuc(danhmuc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
