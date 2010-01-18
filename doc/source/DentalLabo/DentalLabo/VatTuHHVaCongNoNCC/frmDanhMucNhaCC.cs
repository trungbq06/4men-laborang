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
    public partial class frmDanhMucNhaCC : Form
    {
        private bool add;
        private bool mouse;
        private int count = 0;

        private DataSet dataSet;
        private DataTable dt;
        private SqlCommand sqlCom;
        private SqlCommandBuilder builder;
        private SqlDataAdapter adapter;
        private SqlConnection con;

        public frmDanhMucNhaCC()
        {
            InitializeComponent();
            add = false;
            mouse = false;
        }

        private void frmDanhMucNhaCC_Load(object sender, EventArgs e)
        {
            BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
            dt = bsDanhMuc.GetDanhMuc("NhaCungCap");

            con = DataConnection.Connect();
            sqlCom = new SqlCommand("Select * from NhaCungCap", con);

            // Create a SqlDataAdapter object 
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCom;

            // Create a SqlCommandBuilder object 
            builder = new SqlCommandBuilder(adapter);

            // Fill DataSet with data from Employees table
            //adapter.Fill(dataSet, "VatLieuPhu");

            // Bind the DataGrid at run time
            //adapter.TableMappings.Add("Table", dt.TableName);
            //dtgDanhMucNCC.SetDataBinding(dataSet, "VatLieuPhu");
            LoadDataToGrid(dt);
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            btnLuu.Enabled = true;

            dtgDanhMucNCC.AllowUserToAddRows = true;
            dtgDanhMucNCC.ReadOnly = false;
            dtgDanhMucNCC.Columns[6].ReadOnly = true;
        }

        private void LoadDataToGrid(DataTable dt)
        {
            dt.Columns[0].ColumnName = "Mã NCC";
            dt.Columns[1].ColumnName = "Tên NCC";
            dt.Columns[2].ColumnName = "Mã Số Thuế";
            dt.Columns[3].ColumnName = "Người đại diện";
            dt.Columns[4].ColumnName = "Địa chỉ";
            dt.Columns[5].ColumnName = "Điện thoại";
            dt.Columns[0].Unique = true;
            dt.Columns[1].Unique = true;
            dtgDanhMucNCC.DataSource = dt;
            StyleDatagrid();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = true;
                dt.Columns[0].ColumnName = "MaNCC";
                dt.Columns[1].ColumnName = "TenNCC";
                dt.Columns[2].ColumnName = "MaSoThue";
                dt.Columns[3].ColumnName = "NguoiDaiDien";
                dt.Columns[4].ColumnName = "DiaChi";
                dt.Columns[5].ColumnName = "DienThoai";
                adapter.Update(dt);
                dt.Columns[0].ColumnName = "Mã NCC";
                dt.Columns[1].ColumnName = "Tên NCC";
                dt.Columns[2].ColumnName = "Mã Số Thuế";
                dt.Columns[3].ColumnName = "Người đại diện";
                dt.Columns[4].ColumnName = "Địa chỉ";
                dt.Columns[5].ColumnName = "Điện thoại";
                //dt.Columns[0].Unique = true;
                //dt.Columns[1].Unique = true;

                BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
                add = false;
                if (ok) MessageBox.Show("Cập nhật thành công!", "Thông báo");
                dtgDanhMucNCC.AllowUserToAddRows = false;
                dtgDanhMucNCC.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật dữ liệu\nLỗi được thông báo là: " + ex.Message.ToString(), "Lỗi");
            }
        }

        private void dtgDanhMucNCC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Dữ liệu nhập chưa đúng! Có thể đã trùng mã SP hoặc tên SP hoặc dữ liệu chưa đúng định dạng!", "Lỗi");
        }

        private void StyleDatagrid()
        {
            try
            {
                for (int i = 0; i < dtgDanhMucNCC.Rows.Count; ++i)
                {
                    if (dtgDanhMucNCC.Rows[i].Cells[6].Value.ToString() != "True")
                    {
                        if (i % 2 == 0) dtgDanhMucNCC.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucNCC.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                    }
                    else
                        dtgDanhMucNCC.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                }
            }
            catch (Exception ex) { }
        }

        private void dtgDanhMucNCC_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!add)
            {
                try
                {
                    int row = e.RowIndex;
                    for (int i = 0; i < dtgDanhMucNCC.Rows.Count; ++i)
                    {
                        if (dtgDanhMucNCC.Rows[i].Cells[6].Value.ToString() != "True")
                        {
                            if (i % 2 == 0) dtgDanhMucNCC.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                            else dtgDanhMucNCC.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                        }
                        //Màu cho hàng được chọn
                        else
                            dtgDanhMucNCC.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    //Màu cho Mouse Hover
                    if (dtgDanhMucNCC.Rows[row].Cells[6].Value.ToString() != "True")
                        dtgDanhMucNCC.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(181, 218, 174);
                }
                catch (Exception ex) { }
            }
        }

        private void dtgDanhMucNCC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (!add)
                {
                    string ok = dtgDanhMucNCC.Rows[e.RowIndex].Cells[6].Value.ToString();
                    bool check = (ok == "True") ? true : false;
                    int j = e.RowIndex;
                    //MessageBox.Show(i.ToString());
                    if (ok == "True")
                    {
                        count--;
                        if (j % 2 == 0) dtgDanhMucNCC.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucNCC.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(196, 195, 193);
                    }
                    else
                    {
                        count++;
                        dtgDanhMucNCC.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    dtgDanhMucNCC.Rows[e.RowIndex].Cells[6].Value = !check;
                    if (count > 0) btnXoa.Enabled = true;
                    else btnXoa.Enabled = false;
                }
            }
            catch (Exception ex) { }
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
                        for (int i = 0; i < dtgDanhMucNCC.Rows.Count; ++i)
                        {
                            if (dtgDanhMucNCC.Rows[i].Cells[6].Value.ToString() == "True")
                            {
                                array.Add(dtgDanhMucNCC.Rows[i].Cells[0].Value.ToString());
                            }
                        }
                        bsDanhMuc.DeleteFromDanhMuc(array, "NhaCungCap", "MaNCC");
                        dt = bsDanhMuc.GetDanhMuc("NhaCungCap");
                        LoadDataToGrid(dt);
                        dtgDanhMucNCC.ReadOnly = true;
                    }
            }
            catch (Exception ex) { }
        }

        private void dtgDanhMucNCC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnLuu.Enabled = true;
        }

        //Sự kiện khi form đã load xong
        private void frmDanhMucNhaCC_Shown(object sender, EventArgs e)
        {
            StyleDatagrid();
        }

        private void dtgDanhMucNCC_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StyleDatagrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dtgDanhMucNCC);
        }

    }
}
