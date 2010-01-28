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
    public partial class frmDanhMucSP : Form
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

        public frmDanhMucSP()
        {
            InitializeComponent();
            add = false;
            mouse = false;
        }

        private void frmDanhMucSP_Load(object sender, EventArgs e)
        {
            BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
            dt = bsDanhMuc.GetDanhMuc("SanPham");

            con = DataConnection.Connect();
            sqlCom = new SqlCommand("Select * from SanPham", con);

            // Create a SqlDataAdapter object 
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCom;

            // Create a SqlCommandBuilder object 
            builder = new SqlCommandBuilder(adapter);

            // Fill DataSet with data from Employees table
            //adapter.Fill(dataSet, "SanPham");

            // Bind the DataGrid at run time
            //adapter.TableMappings.Add("Table", dt.TableName);
            //dtgDanhMucSP.SetDataBinding(dataSet, "SanPham");
            LoadDataToGrid(dt);
            button3.Enabled = false;         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add = true;
            btnLuu.Enabled = true;

            dtgDanhMucSP.AllowUserToAddRows = true;
            dtgDanhMucSP.ReadOnly = false;
            dtgDanhMucSP.Columns[7].ReadOnly = true;
        }        

        private void LoadDataToGrid(DataTable dt)
        {
            dt.Columns[0].ColumnName = "Mã SP";
            dt.Columns[1].ColumnName = "Tên Sản Phẩm";
            dt.Columns[2].ColumnName = "Phẩm chất";
            dt.Columns[3].ColumnName = "ĐVT";
            dt.Columns[4].ColumnName = "Nhóm hàng hóa";
            dt.Columns[5].ColumnName = "Ghi chú";
            dt.Columns[6].ColumnName = "Số lượng quy chuẩn";
            dt.Columns[0].Unique = true;
            
            dtgDanhMucSP.DataSource = dt;
            StyleDatagrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = true;
                dt.Columns[0].ColumnName = "MaSP";
                dt.Columns[1].ColumnName = "TenSP";
                dt.Columns[2].ColumnName = "PhamChat";
                dt.Columns[3].ColumnName = "DVT";
                dt.Columns[4].ColumnName = "NhomHangHoa";
                dt.Columns[5].ColumnName = "GhiChu";
                dt.Columns[6].ColumnName = "SoLuongQuyChuan";
                adapter.Update(dt);
                dt.Columns[0].ColumnName = "Mã SP";
                dt.Columns[1].ColumnName = "Tên Sản Phẩm";
                dt.Columns[2].ColumnName = "Phẩm chất";
                dt.Columns[3].ColumnName = "ĐVT";
                dt.Columns[4].ColumnName = "Nhóm hàng hóa";
                dt.Columns[5].ColumnName = "Ghi chú";
                dt.Columns[6].ColumnName = "Số lượng quy chuẩn";
                dt.Columns[0].Unique = true;
                

                BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();                
                add = false;
                if (ok) MessageBox.Show("Cập nhật thành công!", "Thông báo");
                dtgDanhMucSP.AllowUserToAddRows = false;
                dtgDanhMucSP.ReadOnly = true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Không thể cập nhật dữ liệu\nLỗi được thông báo là: " + ex.Message.ToString(), "Lỗi");
            }
        }

        private void dtgDanhMucSP_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Dữ liệu nhập chưa đúng! Có thể đã trùng mã SP hoặc tên SP!", "Lỗi");
        }

        private void StyleDatagrid()
        {
            try
            {
                for (int i = 0; i < dtgDanhMucSP.Rows.Count; ++i)
                {
                    if (dtgDanhMucSP.Rows[i].Cells[7].Value.ToString() != "True")
                    {
                        if (i % 2 == 0) dtgDanhMucSP.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucSP.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                    }
                    else
                        dtgDanhMucSP.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                }
            }
            catch (Exception ex) { }
        }

        private void dtgDanhMucSP_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!add)
            {
                try
                {
                    int row = e.RowIndex;
                    for (int i = 0; i < dtgDanhMucSP.Rows.Count; ++i)
                    {
                        if (dtgDanhMucSP.Rows[i].Cells[7].Value.ToString() != "True")
                        {
                            if (i % 2 == 0) dtgDanhMucSP.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                            else dtgDanhMucSP.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                        }
                        //Màu cho hàng được chọn
                        else
                            dtgDanhMucSP.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    //Màu cho Mouse Hover
                    if (dtgDanhMucSP.Rows[row].Cells[7].Value.ToString() != "True")
                        dtgDanhMucSP.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(181, 218, 174);
                }
                catch (Exception ex) { }
            }
        }

        private void dtgDanhMucSP_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (!add)
                {
                    string ok = dtgDanhMucSP.Rows[e.RowIndex].Cells[7].Value.ToString();
                    bool check = (ok == "True") ? true : false;
                    int j = e.RowIndex;
                    //MessageBox.Show(i.ToString());
                    if (ok == "True")
                    {
                        count--;
                        if (j % 2 == 0) dtgDanhMucSP.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucSP.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(196, 195, 193);
                    }
                    else
                    {
                        count++;
                        dtgDanhMucSP.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    dtgDanhMucSP.Rows[e.RowIndex].Cells[7].Value = !check;
                    if (count > 0) button3.Enabled = true;
                    else button3.Enabled = false;
                }
            }
            catch (Exception ex) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
                ArrayList array = new ArrayList();
                if (count > 0)
                    if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu không?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {                        
                        for (int i = 0; i < dtgDanhMucSP.Rows.Count; ++i)
                        {                     
                            if (dtgDanhMucSP.Rows[i].Cells[7].Value.ToString() == "True")
                            {
                                array.Add(dtgDanhMucSP.Rows[i].Cells[0].Value.ToString());
                            }
                        }                        
                        bsDanhMuc.DeleteFromDanhMuc(array, "SanPham", "MaSP");
                        dt = bsDanhMuc.GetDanhMuc("SanPham");
                        LoadDataToGrid(dt);
                        dtgDanhMucSP.ReadOnly = true;
                    }                
            }
            catch (Exception ex) { }
        }

        private void dtgDanhMucSP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnLuu.Enabled = true;
        }

        //Sự kiện khi form đã load xong
        private void frmDanhMucSP_Shown(object sender, EventArgs e)
        {
            StyleDatagrid();
        }

        private void dtgDanhMucSP_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StyleDatagrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dtgDanhMucSP);
        }

    }
}
