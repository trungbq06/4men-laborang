using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DentalLabo.Data;
using DentalLabo.Bussiness;
using System.Data.SqlClient;
using PrintDataGrid;

namespace DentalLabo
{
    public partial class frmDanhMucKH : Form
    {
        private bool add;
        private bool mouse;
        private int count = 0;
        private bool edit;

        private DataSet dataSet;
        private DataTable dt;
        private SqlCommand sqlCom;
        private SqlCommandBuilder builder;
        private SqlDataAdapter adapter;
        private SqlConnection con;
        private DataTable dtNhomKH;

        public frmDanhMucKH()
        {
            InitializeComponent();
            add = true;
            mouse = false;
            dtNhomKH = DataConnection.Query("Select * from NhomKH");
            cbNhomKH.DataSource = dtNhomKH;
            cbNhomKH.DisplayMember = "TenNhom";
            cbNhomKH.ValueMember = "MaNhom";

            cbNhomKH1.DataSource = dtNhomKH;
            cbNhomKH1.DisplayMember = "TenNhom";
            cbNhomKH1.ValueMember = "MaNhom";
            //cbNhomKH1.Items.Insert(0, "Tất cả");
        }

        private void frmDanhMucKH_Load(object sender, EventArgs e)
        {
            BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
            dt = bsDanhMuc.GetDanhMuc("KhachHang");

            con = DataConnection.Connect();
            sqlCom = new SqlCommand("Select * from KhachHang", con);

            // Create a SqlDataAdapter object 
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCom;

            // Create a SqlCommandBuilder object 
            builder = new SqlCommandBuilder(adapter);

            // Fill DataSet with data from Employees table
            //adapter.Fill(dataSet, "VatLieuPhu");

            // Bind the DataGrid at run time
            //adapter.TableMappings.Add("Table", dt.TableName);
            //dtgDanhMucKH.SetDataBinding(dataSet, "VatLieuPhu");
            LoadDataToGrid(dt);
            btnXoa.Enabled = false;
            //MessageBox.Show(cbNhomKH.SelectedValue.ToString());
            txtMaKH.Text = DataConnection.GetMa("KhachHang", "MaKH", cbNhomKH.SelectedValue.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            btnLuu.Enabled = true;
            dtgDanhMucKH.ReadOnly = false;
            dtgDanhMucKH.Columns[9].ReadOnly = true;
            Reset();
            txtMaKH.Text = DataConnection.GetMa("KhachHang", "MaKH", cbNhomKH.SelectedValue.ToString());
        }

        private void LoadDataToGrid(DataTable dt)
        {
            dt.Columns[0].ColumnName = "Mã KH";
            dt.Columns[1].ColumnName = "Tên Khách Hàng";
            dt.Columns[3].ColumnName = "Giới tính";
            dt.Columns[2].ColumnName = "Số ĐT";
            dt.Columns[4].ColumnName = "Email";
            dt.Columns[5].ColumnName = "Mã Số Thuế";
            dt.Columns[6].ColumnName = "Người đại diện";
            dt.Columns[7].ColumnName = "Nhóm KH";
            dt.Columns[8].ColumnName = "Địa chỉ";
            dt.Columns[0].Unique = true;
            if (dt.Columns.Count < 10)
            {
                DataColumn dtColumn = new DataColumn();
                dtColumn.ColumnName = "Xác nhận";
                dtColumn.DataType = typeof(bool);
                dt.Columns.Add(dtColumn);
            }
            dtgDanhMucKH.DataSource = dt;
            StyleDatagrid();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                BussinessKhachHang bsKhachHang = new BussinessKhachHang();
                if (txtTenKH.Text == "")
                    MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo");
                else if (cbNhomKH.Text == "")
                    MessageBox.Show("Bạn chưa chọn nhóm khách hàng", "Thông báo");
                else
                {
                    KhachHang khachhang = new KhachHang();

                    khachhang.MaKH = txtMaKH.Text;
                    //MessageBox.Show(cbNhomKH.SelectedValue.ToString());
                    khachhang.MaNhomKH = cbNhomKH.SelectedValue.ToString();
                    khachhang.TenKH = txtTenKH.Text;
                    khachhang.MaSoThue = txtMaSoThue.Text;
                    khachhang.NguoiDaiDien = txtNguoiDaiDien.Text;
                    khachhang.DienThoai = txtDienThoai.Text;
                    khachhang.DiaChi = txtDiaChi.Text;
                    khachhang.Email = txtEmail.Text;
                    if (rdbNam.Checked) khachhang.GioiTinh = "Nam";
                    else khachhang.GioiTinh = "Nữ";

                    if (add)
                    {
                        bsKhachHang.AddKhachHang(khachhang);
                    }
                    else if (edit) bsKhachHang.UpdateDanhMuc(khachhang, "MaKH", khachhang.MaKH);

                    BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
                    dt = bsDanhMuc.GetDanhMuc("KhachHang");
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

        private void Reset()
        {
            txtTenKH.Text = "";
            txtMaKH.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtMaSoThue.Text = "";
            txtNguoiDaiDien.Text = "";
            txtEmail.Text = "";
            txtMaKH.Text = DataConnection.GetMa("KhachHang", "MaKH", cbNhomKH.SelectedValue.ToString());
        }

        private void dtgDanhMucKH_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Dữ liệu nhập chưa đúng! Có thể đã trùng mã SP hoặc tên SP hoặc dữ liệu chưa đúng định dạng!", "Lỗi");
        }

        private void StyleDatagrid()
        {
            try
            {
                for (int i = 0; i < dtgDanhMucKH.Rows.Count; ++i)
                {
                    if (dtgDanhMucKH.Rows[i].Cells[9].Value.ToString() != "True")
                    {
                        if (i % 2 == 0) dtgDanhMucKH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucKH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                    }
                    else
                        dtgDanhMucKH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                }
            }
            catch (Exception ex) { }
        }

        private void dtgDanhMucKH_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!add)
            {
                try
                {
                    int row = e.RowIndex;
                    for (int i = 0; i < dtgDanhMucKH.Rows.Count; ++i)
                    {
                        if (dtgDanhMucKH.Rows[i].Cells[9].Value.ToString() != "True")
                        {
                            if (i % 2 == 0) dtgDanhMucKH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                            else dtgDanhMucKH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                        }
                        //Màu cho hàng được chọn
                        else
                            dtgDanhMucKH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    //Màu cho Mouse Hover
                    if (dtgDanhMucKH.Rows[row].Cells[9].Value.ToString() != "True")
                        dtgDanhMucKH.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(181, 218, 174);
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
                if (count > 0)
                    if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu không?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        for (int i = 0; i < dtgDanhMucKH.Rows.Count; ++i)
                        {
                            if (dtgDanhMucKH.Rows[i].Cells[9].Value.ToString() == "True")
                            {
                                array.Add(dtgDanhMucKH.Rows[i].Cells[0].Value.ToString());
                            }
                        }
                        bsDanhMuc.DeleteFromDanhMuc(array, "KhachHang", "MaKH");
                        dt = bsDanhMuc.GetDanhMuc("KhachHang");
                        LoadDataToGrid(dt);
                        dtgDanhMucKH.ReadOnly = true;
                    }
                Reset();
            }
            catch (Exception ex) { }
        }

        private void dtgDanhMucKH_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnLuu.Enabled = true;
        }

        //Sự kiện khi form đã load xong
        private void frmDanhMucKH_Shown(object sender, EventArgs e)
        {
            StyleDatagrid();
        }

        private void dtgDanhMucKH_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StyleDatagrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dtgDanhMucKH);
        }

        private void dtgDanhMucKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edit = true;
            add = false;
            try
            {
                if (!add)
                {
                    string ok = dtgDanhMucKH.Rows[e.RowIndex].Cells[9].Value.ToString();
                    bool check = (ok == "True") ? true : false;
                    int j = e.RowIndex;
                    //MessageBox.Show(i.ToString());
                    if (ok == "True")
                    {
                        count--;
                        if (j % 2 == 0) dtgDanhMucKH.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucKH.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(196, 195, 193);
                    }
                    else
                    {
                        count++;
                        dtgDanhMucKH.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    dtgDanhMucKH.Rows[e.RowIndex].Cells[9].Value = !check;
                    if (count > 0) btnXoa.Enabled = true;
                    else btnXoa.Enabled = false;
                }
            }
            catch (Exception ex) { }

            btnXoa.Enabled = true;
            try
            {
                txtMaKH.Text = dtgDanhMucKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                //cbMaBP.SelectedText = dtgDanhMucKH.Rows[e.RowIndex].Cells[1].Value.ToString();    
                txtTenKH.Text = dtgDanhMucKH.Rows[e.RowIndex].Cells[1].Value.ToString();                
                //txtTenBP.Text = DateTime.Parse(dtgDanhMucKH.Rows[e.RowIndex].Cells[3].Value.ToString());
                //txtGioiTinh = dtgDanhMucKH.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (dtgDanhMucKH.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam")
                    rdbNam.Checked = true;
                else rdbNu.Checked = true;
                txtDienThoai.Text = dtgDanhMucKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMaSoThue.Text = dtgDanhMucKH.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtNguoiDaiDien.Text = dtgDanhMucKH.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbNhomKH1.SelectedValue = dtgDanhMucKH.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbNhomKH.SelectedValue = dtgDanhMucKH.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtDiaChi.Text = dtgDanhMucKH.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtEmail.Text = dtgDanhMucKH.Rows[e.RowIndex].Cells[4].Value.ToString(); ;
            }
            catch (Exception ex) { }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dtTimkiem = new DataTable();
            string str;
            if (cbNhomKH1.SelectedValue != null) str = "Select * from KhachHang where MaNhomKH = '" + cbNhomKH1.SelectedValue.ToString() + "'";
            else str = "Select * from KhachHang";
            dtTimkiem = DataConnection.Query(str);
            LoadDataToGrid(dtTimkiem);
        }

        private void cbNhomKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaKH.Text = DataConnection.GetMa("KhachHang", "MaKH", cbNhomKH.SelectedValue.ToString());
        }

    }
}
