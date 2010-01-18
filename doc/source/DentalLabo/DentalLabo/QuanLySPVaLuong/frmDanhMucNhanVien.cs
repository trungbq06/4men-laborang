using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DentalLabo.DataAccess;
using DentalLabo.Data;
using DentalLabo.Bussiness;
using System.Collections;

namespace DentalLabo
{
    public partial class frmDanhMucNV : Form
    {
        private DataTable dt;
        private int count;
        private bool add;
        private bool edit;
        private bool entering;
        private DataTable dtBoPhan;

        public frmDanhMucNV()
        {
            InitializeComponent();
            count = 0;
            add = true;
            edit = false;
            entering = false;
            dtBoPhan = DataConnection.Query("Select * from BoPhan");
            cbTenBP.DataSource = dtBoPhan;            
            cbTenBP.DisplayMember = "TenBP";
            cbTenBP.ValueMember = "TenBP";
            cbMaBP.DataSource = dtBoPhan;
            cbMaBP.DisplayMember = "MaBP";
            cbMaBP.ValueMember = "MaBP";

            cbTenBoPhan.DataSource = dtBoPhan;
            cbTenBoPhan.DisplayMember = "TenBP";
            cbTenBoPhan.ValueMember = "TenBP";
            cbMaBoPhan.DataSource = dtBoPhan;
            cbMaBoPhan.DisplayMember = "MaBP";
            cbMaBoPhan.ValueMember = "MaBP";
        }

        private void dtgDanhMucNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edit = true;
            add = false;
            try
            {
                if (!add)
                {
                    string ok = dtgDanhMucNV.Rows[e.RowIndex].Cells[8].Value.ToString();
                    bool check = (ok == "True") ? true : false;
                    int j = e.RowIndex;
                    //MessageBox.Show(i.ToString());
                    if (ok == "True")
                    {
                        count--;
                        if (j % 2 == 0) dtgDanhMucNV.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucNV.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(196, 195, 193);
                    }
                    else
                    {
                        count++;
                        dtgDanhMucNV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    dtgDanhMucNV.Rows[e.RowIndex].Cells[8].Value = !check;
                    if (count > 0) btnXoa.Enabled = true;
                    else btnXoa.Enabled = false;
                }
            }
            catch (Exception ex) { }

            btnXoa.Enabled = true;
            try
            {
                txtMaNV.Text = dtgDanhMucNV.Rows[e.RowIndex].Cells[0].Value.ToString();
                //cbMaBP.SelectedText = dtgDanhMucNV.Rows[e.RowIndex].Cells[1].Value.ToString();    
                cbMaBP.Text = dtgDanhMucNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenNV.Text = dtgDanhMucNV.Rows[e.RowIndex].Cells[2].Value.ToString();                
                //txtTenBP.Text = DateTime.Parse(dtgDanhMucNV.Rows[e.RowIndex].Cells[3].Value.ToString());
                //txtGioiTinh = dtgDanhMucNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (dtgDanhMucNV.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam")
                    rdbNam.Checked = true;
                else rdbNu.Checked = true;
                txtNamSinh.Text = dtgDanhMucNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSoCMT.Text = dtgDanhMucNV.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiaChi.Text = dtgDanhMucNV.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDienThoai.Text = dtgDanhMucNV.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception ex) {}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
                ArrayList array = new ArrayList();
                if (count > 0)
                    if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu không?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        for (int i = 0; i < dtgDanhMucNV.Rows.Count; ++i)
                        {
                            if (dtgDanhMucNV.Rows[i].Cells[8].Value.ToString() == "True")
                            {
                                array.Add(dtgDanhMucNV.Rows[i].Cells[0].Value.ToString());
                            }
                        }                        
                        bsDanhMuc.DeleteFromDanhMuc(array, "NhanVien", "MaNV");
                        dt = bsDanhMuc.GetDanhMuc("NhanVien");
                        LoadDataToGrid(dt);
                        dtgDanhMucNV.ReadOnly = true;
                        Reset();
                    }
            }
            catch (Exception ex) { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                BussinessDanhMucNV bsNhanvien = new BussinessDanhMucNV();
                if (txtTenNV.Text == "")
                    MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo");
                else if (cbTenBP.Text == "")
                    MessageBox.Show("Bạn chưa nhập bộ phận", "Thông báo");
                else
                {
                    DanhMucNV nhanvien = new DanhMucNV();

                    nhanvien.MaNV = txtMaNV.Text;                    
                    nhanvien.MaBP = (string) cbMaBP.SelectedValue;
                    nhanvien.TenNV = txtTenNV.Text;
                    if (rdbNam.Checked) nhanvien.GioiTinh = "Nam";
                    else nhanvien.GioiTinh = "Nữ";
                    nhanvien.NamSinh = Int32.Parse(txtNamSinh.Text.ToString());
                    nhanvien.SoCMT = txtSoCMT.Text;
                    nhanvien.DiaChi = txtDiaChi.Text;
                    nhanvien.DienThoai = txtDienThoai.Text;

                    if (add)
                    {
                        bsNhanvien.AddDanhMuc(nhanvien);
                    }
                    else if (edit) bsNhanvien.UpdateDanhMuc(nhanvien, "MaNV", nhanvien.MaNV);

                    BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
                    dt = bsDanhMuc.GetDanhMuc("NhanVien");
                    LoadDataToGrid(dt);
                    add = true;
                    edit = false;
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình lưu\n" + ex.ToString(), "Lỗi");
            }
        }

        private void frmDanhMucNV_Load(object sender, EventArgs e)
        {
            BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
            dt = bsDanhMuc.GetDanhMuc("NhanVien");
            LoadDataToGrid(dt);
        }

        private void LoadDataToGrid(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; ++i)
            { 
                
            }
            dt.Columns[0].ColumnName = "Mã NV";
            dt.Columns[1].ColumnName = "Mã BP";
            dt.Columns[2].ColumnName = "Tên Nhân Viên";
            dt.Columns[3].ColumnName = "Giới Tính";            
            dt.Columns[4].ColumnName = "Năm Sinh";
            dt.Columns[5].ColumnName = "Số CMT";
            dt.Columns[6].ColumnName = "Địa Chỉ";
            dt.Columns[7].ColumnName = "Điện Thoại";
            dt.Columns[0].Unique = true;
            dtgDanhMucNV.DataSource = dt;
            dtgDanhMucNV.Columns[3].ValueType = typeof(bool);
            //DataGridViewCell cell = new DataGridViewComboBoxCell();
            //dtgDanhMucNV.Columns[4].CellTemplate = cell;
            //StyleDatagrid();
        }

        private void StyleDatagrid()
        {
            try
            {
                for (int i = 0; i < dtgDanhMucNV.Rows.Count; ++i)
                {
                    if (dtgDanhMucNV.Rows[i].Cells[8].Value.ToString() != "True")
                    {
                        if (i % 2 == 0) dtgDanhMucNV.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucNV.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                    }
                    else
                        dtgDanhMucNV.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                }
            }
            catch (Exception ex) { }
        }

        private void frmDanhMucNV_Shown(object sender, EventArgs e)
        {
            StyleDatagrid();
        }

        private void dtgDanhMucNV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StyleDatagrid();
        }

        private void dtgDanhMucNV_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!add || !edit)
            {
                try
                {
                    int row = e.RowIndex;
                    for (int i = 0; i < dtgDanhMucNV.Rows.Count; ++i)
                    {
                        if (dtgDanhMucNV.Rows[i].Cells[8].Value.ToString() != "True")
                        {
                            if (i % 2 == 0) dtgDanhMucNV.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                            else dtgDanhMucNV.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                        }
                        //Màu cho hàng được chọn
                        else
                            dtgDanhMucNV.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    //Màu cho Mouse Hover
                    if (dtgDanhMucNV.Rows[row].Cells[8].Value.ToString() != "True")
                        dtgDanhMucNV.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(181, 218, 174);
                }
                catch (Exception ex) { }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDataGrid.PrintDGV.Print_DataGridView(dtgDanhMucNV);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            edit = false;
            Reset();
        }

        private void Reset()
        {
            txtTenNV.Text = "";
            cbTenBP.Text = "";
            txtNamSinh.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtSoCMT.Text = "";
            cbMaBP.Text = "";
            txtMaNV.Text = "";
        }

        private void cbMaBP_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt = DataConnection.Query("Select * from BoPhan where MaBP = '" + cbTenBP.Text + "'");
            //if (dt.Rows.Count > 0) cbTenBP.Text = dt.Rows[0][1].ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string str = "Select * from NhanVien where MaBP = '" + cbMaBoPhan.Text + "'";
            DataTable dt = DataConnection.Query(str);
            dtgDanhMucNV.DataSource = dt;
        }

    }
}
