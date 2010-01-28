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

namespace DentalLabo.QuanLySPVaLuong
{
    public partial class frmDMKhoanLuong : Form
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

        public frmDMKhoanLuong()
        {
            InitializeComponent();
            add = false;
            mouse = false;
        }

        private void frmDMKhoanLuong_Load(object sender, EventArgs e)
        {
            BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
            dt = bsDanhMuc.GetDanhMuc("KhoanLuong");

            con = DataConnection.Connect();
            sqlCom = new SqlCommand("Select * from KhoanLuong", con);

            // Create a SqlDataAdapter object 
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCom;

            // Create a SqlCommandBuilder object 
            builder = new SqlCommandBuilder(adapter);

            // Fill DataSet with data from Employees table
            //adapter.Fill(dataSet, "VatLieuPhu");

            // Bind the DataGrid at run time
            //adapter.TableMappings.Add("Table", dt.TableName);
            //dtgDMKhoanLuong.SetDataBinding(dataSet, "VatLieuPhu");
            LoadDataToGrid(dt);
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            btnLuu.Enabled = true;

            dtgDMKhoanLuong.AllowUserToAddRows = true;
            dtgDMKhoanLuong.ReadOnly = false;
            dtgDMKhoanLuong.Columns[3].ReadOnly = true;
        }

        private void LoadDataToGrid(DataTable dt)
        {
            dt.Columns[0].ColumnName = "Mã Khoản";
            dt.Columns[1].ColumnName = "Tên Khoản";
            dt.Columns[2].ColumnName = "ĐVT";
            dt.Columns[0].Unique = true;
            dt.Columns[1].Unique = true;
            dtgDMKhoanLuong.DataSource = dt;
            StyleDatagrid();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = true;
                dt.Columns[0].ColumnName = "MaKhoan";
                dt.Columns[1].ColumnName = "TenKhoan";
                dt.Columns[2].ColumnName = "DonViTinh";
                adapter.Update(dt);
                dt.Columns[0].ColumnName = "Mã Khoản";
                dt.Columns[1].ColumnName = "Tên Khoản";
                dt.Columns[2].ColumnName = "ĐVT";
                //dt.Columns[0].Unique = true;
                //dt.Columns[1].Unique = true;

                BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
                add = false;
                if (ok) MessageBox.Show("Cập nhật thành công!", "Thông báo");
                dtgDMKhoanLuong.AllowUserToAddRows = false;
                dtgDMKhoanLuong.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật dữ liệu\nLỗi được thông báo là: " + ex.Message.ToString(), "Lỗi");
            }
        }

        private void dtgDMKhoanLuong_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Dữ liệu nhập chưa đúng! Có thể đã trùng mã SP hoặc tên SP hoặc dữ liệu chưa đúng định dạng!", "Lỗi");
        }

        private void StyleDatagrid()
        {
            try
            {
                for (int i = 0; i < dtgDMKhoanLuong.Rows.Count; ++i)
                {
                    if (dtgDMKhoanLuong.Rows[i].Cells[3].Value.ToString() != "True")
                    {
                        if (i % 2 == 0) dtgDMKhoanLuong.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDMKhoanLuong.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                    }
                    else
                        dtgDMKhoanLuong.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                }
            }
            catch (Exception ex) { }
        }

        private void dtgDMKhoanLuong_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!add)
            {
                try
                {
                    int row = e.RowIndex;
                    for (int i = 0; i < dtgDMKhoanLuong.Rows.Count; ++i)
                    {
                        if (dtgDMKhoanLuong.Rows[i].Cells[3].Value.ToString() != "True")
                        {
                            if (i % 2 == 0) dtgDMKhoanLuong.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                            else dtgDMKhoanLuong.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                        }
                        //Màu cho hàng được chọn
                        else
                            dtgDMKhoanLuong.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    //Màu cho Mouse Hover
                    if (dtgDMKhoanLuong.Rows[row].Cells[3].Value.ToString() != "True")
                        dtgDMKhoanLuong.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(181, 218, 174);
                }
                catch (Exception ex) { }
            }
        }

        private void dtgDMKhoanLuong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (!add)
                {
                    string ok = dtgDMKhoanLuong.Rows[e.RowIndex].Cells[3].Value.ToString();
                    bool check = (ok == "True") ? true : false;
                    int j = e.RowIndex;
                    //MessageBox.Show(i.ToString());
                    if (ok == "True")
                    {
                        count--;
                        if (j % 2 == 0) dtgDMKhoanLuong.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDMKhoanLuong.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(196, 195, 193);
                    }
                    else
                    {
                        count++;
                        dtgDMKhoanLuong.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    dtgDMKhoanLuong.Rows[e.RowIndex].Cells[3].Value = !check;
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
                        for (int i = 0; i < dtgDMKhoanLuong.Rows.Count; ++i)
                        {
                            if (dtgDMKhoanLuong.Rows[i].Cells[3].Value.ToString() == "True")
                            {
                                array.Add(dtgDMKhoanLuong.Rows[i].Cells[0].Value.ToString());
                            }
                        }
                        bsDanhMuc.DeleteFromDanhMuc(array, "KhoanLuong", "MaKhoan");
                        dt = bsDanhMuc.GetDanhMuc("KhoanLuong");
                        LoadDataToGrid(dt);
                        dtgDMKhoanLuong.ReadOnly = true;
                    }
            }
            catch (Exception ex) { }
        }

        private void dtgDMKhoanLuong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnLuu.Enabled = true;
        }

        //Sự kiện khi form đã load xong
        private void frmDMKhoanLuong_Shown(object sender, EventArgs e)
        {
            StyleDatagrid();
        }

        private void dtgDMKhoanLuong_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StyleDatagrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dtgDMKhoanLuong);
        }
    }
}
