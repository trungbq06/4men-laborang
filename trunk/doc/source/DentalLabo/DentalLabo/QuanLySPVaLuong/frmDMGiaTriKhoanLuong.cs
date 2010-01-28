using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using DentalLabo.Data;
using DentalLabo.Bussiness;
using System.Data.SqlClient;
using PrintDataGrid;

namespace DentalLabo.QuanLySPVaLuong
{
    public partial class frmDMGiaTriKhoanLuong : Form
    {
        private bool add;
        private bool edit;
        private bool mouse;
        private int count = 0;

        private DataSet dataSet;
        private DataTable dt;
        private SqlCommand sqlCom;
        private SqlCommandBuilder builder;
        private SqlDataAdapter adapter;
        private SqlConnection con;

        public frmDMGiaTriKhoanLuong()
        {
            InitializeComponent();
            add = true;
            mouse = false;
            DataTable dtBoPhan = new DataTable();
            dtBoPhan = DataConnection.Query("Select * from BoPhan");
            cbTenBP.DataSource = dtBoPhan;
            cbTenBP.DisplayMember = "TenBP";
            cbTenBP.ValueMember = "TenBP";
            cbTenBP1.DataSource = dtBoPhan;
            cbTenBP1.DisplayMember = "TenBP";
            cbTenBP1.ValueMember = "TenBP";

            cbMaBP.DataSource = dtBoPhan;
            cbMaBP.DisplayMember = "MaBP";
            cbMaBP.ValueMember = "MaBP";
            cbMaBP1.DataSource = dtBoPhan;
            cbMaBP1.DisplayMember = "MaBP";
            cbMaBP1.ValueMember = "MaBP";

            dtBoPhan = DataConnection.Query("Select * from KhoanLuong");
            cbTenKhoan.DataSource = dtBoPhan;
            cbTenKhoan.DisplayMember = "TenKhoan";
            cbTenKhoan.ValueMember = "TenKhoan";

            cbMaKhoan.DataSource = dtBoPhan;
            cbMaKhoan.DisplayMember = "MaKhoan";
            cbMaKhoan.ValueMember = "MaKHoan";

            edit = false;
        }

        private void frmDMGiaTriKhoanLuong_Load(object sender, EventArgs e)
        {
            BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
            dt = bsDanhMuc.GetDanhMuc("GiaTriKhoanLuong");
                        
            LoadDataToGrid(dt);
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            btnLuu.Enabled = true;
            Reset();            
        }

        private void Reset()
        {
            txtDonGia.Text = "";
        }

        private void LoadDataToGrid(DataTable dt)
        {
            dt.Columns[0].ColumnName = "Mã Khoản";
            dt.Columns[1].ColumnName = "Mã BP";
            dt.Columns[2].ColumnName = "Đơn Giá";
            if (dt.Columns.Count < 4)
            {
                DataColumn dtColumn = new DataColumn();
                dtColumn.ColumnName = "Xác nhận";
                dtColumn.DataType = typeof(bool);
                dt.Columns.Add(dtColumn);
            }
            dtgDMGiaTriKhoanLuong.DataSource = dt;
            StyleDatagrid();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = true;
                con = DataConnection.Connect();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                BussinessDanhMucNV bsNhanvien = new BussinessDanhMucNV();
                if (add)
                {
                    com.CommandText = "Insert into GiaTriKhoanLuong values(@MaKhoan, @MaBP, @DonGia)";
                    com.Parameters.Add("@MaBP", cbMaBP.Text);
                    com.Parameters.Add("@MaKhoan", cbMaKhoan.Text);
                    com.Parameters.Add("@DonGia", txtDonGia.Text);
                    com.ExecuteNonQuery();
                }
                else if (edit) 
                {
                    string str;
                    str = "Update GiaTriKhoanLuong set ";
                    str += "DonGia=N'" + cbMaBP.Text + "'";
                    str += " where MaKhoan='" + cbMaKhoan.Text + "' and MaBP = '" + cbMaBP.Text + "'";
                    MessageBox.Show(str);
                    com.CommandText = str;
                    com.ExecuteNonQuery();
                }

                add = true;
                edit = false;
                if (ok) MessageBox.Show("Cập nhật thành công!", "Thông báo");
                BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
                dt = bsDanhMuc.GetDanhMuc("GiaTriKhoanLuong");
                LoadDataToGrid(dt);
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật dữ liệu\nLỗi được thông báo là: " + ex.Message.ToString(), "Lỗi");
            }
        }

        private void dtgDMGiaTriKhoanLuong_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Dữ liệu nhập chưa đúng! Có thể đã trùng mã SP hoặc tên SP hoặc dữ liệu chưa đúng định dạng!", "Lỗi");
        }

        private void StyleDatagrid()
        {
            try
            {
                for (int i = 0; i < dtgDMGiaTriKhoanLuong.Rows.Count; ++i)
                {
                    if (dtgDMGiaTriKhoanLuong.Rows[i].Cells[3].Value.ToString() != "True")
                    {
                        if (i % 2 == 0) dtgDMGiaTriKhoanLuong.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDMGiaTriKhoanLuong.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                    }
                    else
                        dtgDMGiaTriKhoanLuong.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                }
            }
            catch (Exception ex) { }
        }

        private void dtgDMGiaTriKhoanLuong_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!add || !edit)
            {
                try
                {
                    int row = e.RowIndex;
                    for (int i = 0; i < dtgDMGiaTriKhoanLuong.Rows.Count; ++i)
                    {
                        if (dtgDMGiaTriKhoanLuong.Rows[i].Cells[3].Value.ToString() != "True")
                        {
                            if (i % 2 == 0) dtgDMGiaTriKhoanLuong.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                            else dtgDMGiaTriKhoanLuong.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                        }
                        //Màu cho hàng được chọn
                        else
                            dtgDMGiaTriKhoanLuong.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    //Màu cho Mouse Hover
                    if (dtgDMGiaTriKhoanLuong.Rows[row].Cells[3].Value.ToString() != "True")
                        dtgDMGiaTriKhoanLuong.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(181, 218, 174);
                }
                catch (Exception ex) { }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
                ArrayList array = new ArrayList();
                ArrayList array1 = new ArrayList();
                if (count > 0)
                    if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu không?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        for (int i = 0; i < dtgDMGiaTriKhoanLuong.Rows.Count; ++i)
                        {
                            if (dtgDMGiaTriKhoanLuong.Rows[i].Cells[3].Value.ToString() == "True")
                            {
                                array.Add(dtgDMGiaTriKhoanLuong.Rows[i].Cells[0].Value.ToString());
                                array1.Add(dtgDMGiaTriKhoanLuong.Rows[i].Cells[1].Value.ToString());
                            }
                        }
                        bsDanhMuc.DeleteFromDanhMucs(array, array1, "GiaTriKhoanLuong", "MaKhoan", "MaBP");
                        dt = bsDanhMuc.GetDanhMuc("GiaTriKhoanLuong");
                        LoadDataToGrid(dt);
                        Reset();
                    }
            }
            catch (Exception ex) { }
        }

        private void dtgDMGiaTriKhoanLuong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnLuu.Enabled = true;
        }

        //Sự kiện khi form đã load xong
        private void frmDMGiaTriKhoanLuong_Shown(object sender, EventArgs e)
        {
            StyleDatagrid();
        }

        private void dtgDMGiaTriKhoanLuong_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StyleDatagrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dtgDMGiaTriKhoanLuong);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string str = "Select * from GiaTriKhoanLuong where MaBP = '" + cbMaBP1.Text + "'";
            if (cbMaBP1.Text == "") str = "Select * from GiaTriKhoanLuong";
            DataTable dt = DataConnection.Query(str);
            LoadDataToGrid(dt);
        }

        private void dtgDMGiaTriKhoanLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            add = false;
            edit = true;
            try
            {
                if (!add)
                {
                    string ok = dtgDMGiaTriKhoanLuong.Rows[e.RowIndex].Cells[3].Value.ToString();
                    bool check = (ok == "True") ? true : false;
                    int j = e.RowIndex;
                    //MessageBox.Show(i.ToString());
                    if (ok == "True")
                    {
                        count--;
                        if (j % 2 == 0) dtgDMGiaTriKhoanLuong.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDMGiaTriKhoanLuong.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(196, 195, 193);
                    }
                    else
                    {
                        count++;
                        dtgDMGiaTriKhoanLuong.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    dtgDMGiaTriKhoanLuong.Rows[e.RowIndex].Cells[3].Value = !check;
                    if (count > 0) btnXoa.Enabled = true;
                    else btnXoa.Enabled = false;
                }
            }
            catch (Exception ex) { }

            btnXoa.Enabled = true;
            try
            {
                cbMaBP.Text = dtgDMGiaTriKhoanLuong.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbMaKhoan.Text = dtgDMGiaTriKhoanLuong.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonGia.Text = dtgDMGiaTriKhoanLuong.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void dtgDMGiaTriKhoanLuong_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            add = false;
            edit = true;
            try
            {
                if (!add)
                {
                    string ok = dtgDMGiaTriKhoanLuong.Rows[e.RowIndex].Cells[3].Value.ToString();
                    bool check = (ok == "True") ? true : false;
                    int j = e.RowIndex;
                    //MessageBox.Show(i.ToString());
                    if (ok == "True")
                    {
                        count--;
                        if (j % 2 == 0) dtgDMGiaTriKhoanLuong.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDMGiaTriKhoanLuong.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(196, 195, 193);
                    }
                    else
                    {
                        count++;
                        dtgDMGiaTriKhoanLuong.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    dtgDMGiaTriKhoanLuong.Rows[e.RowIndex].Cells[3].Value = !check;
                    if (count > 0) btnXoa.Enabled = true;
                    else btnXoa.Enabled = false;
                }
            }
            catch (Exception ex) { }

            btnXoa.Enabled = true;
            try
            {
                cbMaBP.Text = dtgDMGiaTriKhoanLuong.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbMaKhoan.Text = dtgDMGiaTriKhoanLuong.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDonGia.Text = dtgDMGiaTriKhoanLuong.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Select * from GiaTriKhoanLuong where MaBP = '" + cbMaBP1.Text + "'";
            if (cbMaBP1.Text == "") str = "Select * from GiaTriKhoanLuong";
            DataTable dt = DataConnection.Query(str);
            LoadDataToGrid(dt);
        }
    }
}
