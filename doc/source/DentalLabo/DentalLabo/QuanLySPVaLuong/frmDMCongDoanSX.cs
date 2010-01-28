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
    public partial class frmDMCongDoanSX : Form
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

        public frmDMCongDoanSX()
        {
            InitializeComponent();
            add = false;
            mouse = false;
        }

        private void frmDMCongDoanSX_Load(object sender, EventArgs e)
        {
            BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
            dt = bsDanhMuc.GetDanhMuc("CongDoanSX");

            con = DataConnection.Connect();
            sqlCom = new SqlCommand("Select * from CongDoanSX", con);

            // Create a SqlDataAdapter object 
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCom;

            // Create a SqlCommandBuilder object 
            builder = new SqlCommandBuilder(adapter);

            // Fill DataSet with data from Employees table
            //adapter.Fill(dataSet, "VatLieuPhu");

            // Bind the DataGrid at run time
            //adapter.TableMappings.Add("Table", dt.TableName);
            //dtgDanhMucCongDoanSX.SetDataBinding(dataSet, "VatLieuPhu");
            LoadDataToGrid(dt);
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            btnLuu.Enabled = true;

            dtgDanhMucCongDoanSX.AllowUserToAddRows = true;
            dtgDanhMucCongDoanSX.ReadOnly = false;
            dtgDanhMucCongDoanSX.Columns[4].ReadOnly = true;
        }

        private void LoadDataToGrid(DataTable dt)
        {
            dt.Columns[0].ColumnName = "Mã CĐ";
            dt.Columns[1].ColumnName = "Tên Công Đoạn";
            dt.Columns[2].ColumnName = "ĐVT";
            dt.Columns[3].ColumnName = "Hệ số";
            dt.Columns[0].Unique = true;
            dt.Columns[1].Unique = true;
            dtgDanhMucCongDoanSX.DataSource = dt;
            StyleDatagrid();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = true;
                dt.Columns[0].ColumnName = "MaCD";
                dt.Columns[1].ColumnName = "TenCD";
                dt.Columns[2].ColumnName = "DonViTinh";
                dt.Columns[3].ColumnName = "SoLuongQuyChieu";
                adapter.Update(dt);
                dt.Columns[0].ColumnName = "Mã CĐ";
                dt.Columns[1].ColumnName = "Tên Công Đoạn";
                dt.Columns[2].ColumnName = "ĐVT";
                dt.Columns[3].ColumnName = "Hệ số";
                //dt.Columns[0].Unique = true;
                //dt.Columns[1].Unique = true;

                BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
                add = false;
                if (ok) MessageBox.Show("Cập nhật thành công!", "Thông báo");
                dtgDanhMucCongDoanSX.AllowUserToAddRows = false;
                dtgDanhMucCongDoanSX.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật dữ liệu\nLỗi được thông báo là: " + ex.Message.ToString(), "Lỗi");
            }
        }

        private void dtgDanhMucCongDoanSX_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Dữ liệu nhập chưa đúng! Có thể đã trùng mã SP hoặc tên SP hoặc dữ liệu chưa đúng định dạng!", "Lỗi");
        }

        private void StyleDatagrid()
        {
            try
            {
                for (int i = 0; i < dtgDanhMucCongDoanSX.Rows.Count; ++i)
                {
                    if (dtgDanhMucCongDoanSX.Rows[i].Cells[4].Value.ToString() != "True")
                    {
                        if (i % 2 == 0) dtgDanhMucCongDoanSX.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucCongDoanSX.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                    }
                    else
                        dtgDanhMucCongDoanSX.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                }
            }
            catch (Exception ex) { }
        }

        private void dtgDanhMucCongDoanSX_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!add)
            {
                try
                {
                    int row = e.RowIndex;
                    for (int i = 0; i < dtgDanhMucCongDoanSX.Rows.Count; ++i)
                    {
                        if (dtgDanhMucCongDoanSX.Rows[i].Cells[4].Value.ToString() != "True")
                        {
                            if (i % 2 == 0) dtgDanhMucCongDoanSX.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                            else dtgDanhMucCongDoanSX.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                        }
                        //Màu cho hàng được chọn
                        else
                            dtgDanhMucCongDoanSX.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    //Màu cho Mouse Hover
                    if (dtgDanhMucCongDoanSX.Rows[row].Cells[4].Value.ToString() != "True")
                        dtgDanhMucCongDoanSX.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(181, 218, 174);
                }
                catch (Exception ex) { }
            }
        }

        private void dtgDanhMucCongDoanSX_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (!add)
                {
                    string ok = dtgDanhMucCongDoanSX.Rows[e.RowIndex].Cells[4].Value.ToString();
                    bool check = (ok == "True") ? true : false;
                    int j = e.RowIndex;
                    //MessageBox.Show(i.ToString());
                    if (ok == "True")
                    {
                        count--;
                        if (j % 2 == 0) dtgDanhMucCongDoanSX.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucCongDoanSX.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(196, 195, 193);
                    }
                    else
                    {
                        count++;
                        dtgDanhMucCongDoanSX.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    dtgDanhMucCongDoanSX.Rows[e.RowIndex].Cells[4].Value = !check;
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
                        for (int i = 0; i < dtgDanhMucCongDoanSX.Rows.Count; ++i)
                        {
                            if (dtgDanhMucCongDoanSX.Rows[i].Cells[4].Value.ToString() == "True")
                            {
                                array.Add(dtgDanhMucCongDoanSX.Rows[i].Cells[0].Value.ToString());
                            }
                        }
                        bsDanhMuc.DeleteFromDanhMuc(array, "CongDoanSX", "MaCD");
                        dt = bsDanhMuc.GetDanhMuc("CongDoanSX");
                        LoadDataToGrid(dt);
                        dtgDanhMucCongDoanSX.ReadOnly = true;
                    }
            }
            catch (Exception ex) { }
        }

        private void dtgDanhMucCongDoanSX_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnLuu.Enabled = true;
        }

        //Sự kiện khi form đã load xong
        private void frmDMCongDoanSX_Shown(object sender, EventArgs e)
        {
            StyleDatagrid();
        }

        private void dtgDanhMucCongDoanSX_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StyleDatagrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dtgDanhMucCongDoanSX);
        }

    }
}
