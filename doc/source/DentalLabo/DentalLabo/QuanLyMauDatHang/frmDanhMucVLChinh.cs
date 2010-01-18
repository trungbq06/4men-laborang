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
    public partial class frmDanhMucVLChinh : Form
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

        public frmDanhMucVLChinh()
        {
            InitializeComponent();
            add = false;
            mouse = false;
        }

        private void frmDanhMucVLChinh_Load(object sender, EventArgs e)
        {
            BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
            dt = bsDanhMuc.GetDanhMuc("VatLieuChinh");

            con = DataConnection.Connect();
            sqlCom = new SqlCommand("Select * from VatLieuChinh", con);

            // Create a SqlDataAdapter object 
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCom;

            // Create a SqlCommandBuilder object 
            builder = new SqlCommandBuilder(adapter);

            // Fill DataSet with data from Employees table
            //adapter.Fill(dataSet, "VatLieuChinh");

            // Bind the DataGrid at run time
            //adapter.TableMappings.Add("Table", dt.TableName);
            //dtgDanhMucVLC.SetDataBinding(dataSet, "VatLieuChinh");
            LoadDataToGrid(dt);
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            btnLuu.Enabled = true;

            dtgDanhMucVLC.AllowUserToAddRows = true;
            dtgDanhMucVLC.ReadOnly = false;
            dtgDanhMucVLC.Columns[2].ReadOnly = true;
        }

        private void LoadDataToGrid(DataTable dt)
        {
            dt.Columns[0].ColumnName = "Mã VL";
            dt.Columns[1].ColumnName = "Tên Vật Liệu";
            dt.Columns[0].Unique = true;
            dt.Columns[1].Unique = true;
            dtgDanhMucVLC.DataSource = dt;
            StyleDatagrid();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = true;
                dt.Columns[0].ColumnName = "MaVL";
                dt.Columns[1].ColumnName = "TenVL";
                adapter.Update(dt);
                dt.Columns[0].ColumnName = "Mã VL";
                dt.Columns[1].ColumnName = "Tên Vật Liệu";
                dt.Columns[0].Unique = true;
                dt.Columns[1].Unique = true;

                BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
                add = false;
                if (ok) MessageBox.Show("Cập nhật thành công!", "Thông báo");
                dtgDanhMucVLC.AllowUserToAddRows = false;
                dtgDanhMucVLC.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật dữ liệu\nLỗi được thông báo là: " + ex.Message.ToString(), "Lỗi");
            }
        }

        private void dtgDanhMucVLC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Dữ liệu nhập chưa đúng! Có thể đã trùng mã SP hoặc tên SP!", "Lỗi");
        }

        private void StyleDatagrid()
        {
            try
            {
                for (int i = 0; i < dtgDanhMucVLC.Rows.Count; ++i)
                {
                    if (dtgDanhMucVLC.Rows[i].Cells[2].Value.ToString() != "True")
                    {
                        if (i % 2 == 0) dtgDanhMucVLC.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucVLC.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                    }
                    else
                        dtgDanhMucVLC.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                }
            }
            catch (Exception ex) { }
        }

        private void dtgDanhMucVLC_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!add)
            {
                try
                {
                    int row = e.RowIndex;
                    for (int i = 0; i < dtgDanhMucVLC.Rows.Count; ++i)
                    {
                        if (dtgDanhMucVLC.Rows[i].Cells[2].Value.ToString() != "True")
                        {
                            if (i % 2 == 0) dtgDanhMucVLC.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                            else dtgDanhMucVLC.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                        }
                        //Màu cho hàng được chọn
                        else
                            dtgDanhMucVLC.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    //Màu cho Mouse Hover
                    if (dtgDanhMucVLC.Rows[row].Cells[2].Value.ToString() != "True")
                        dtgDanhMucVLC.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(181, 218, 174);
                }
                catch (Exception ex) { }
            }
        }

        private void dtgDanhMucVLC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (!add)
                {
                    string ok = dtgDanhMucVLC.Rows[e.RowIndex].Cells[2].Value.ToString();
                    bool check = (ok == "True") ? true : false;
                    int j = e.RowIndex;
                    //MessageBox.Show(i.ToString());
                    if (ok == "True")
                    {
                        count--;
                        if (j % 2 == 0) dtgDanhMucVLC.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucVLC.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(196, 195, 193);
                    }
                    else
                    {
                        count++;
                        dtgDanhMucVLC.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    dtgDanhMucVLC.Rows[e.RowIndex].Cells[2].Value = !check;
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
                        for (int i = 0; i < dtgDanhMucVLC.Rows.Count; ++i)
                        {
                            if (dtgDanhMucVLC.Rows[i].Cells[2].Value.ToString() == "True")
                            {
                                array.Add(dtgDanhMucVLC.Rows[i].Cells[0].Value.ToString());
                            }
                        }
                        bsDanhMuc.DeleteFromDanhMuc(array, "VatLieuChinh", "MaVL");
                        dt = bsDanhMuc.GetDanhMuc("VatLieuChinh");
                        LoadDataToGrid(dt);
                        dtgDanhMucVLC.ReadOnly = true;
                    }
            }
            catch (Exception ex) { }
        }

        private void dtgDanhMucVLC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnLuu.Enabled = true;
        }

        //Sự kiện khi form đã load xong
        private void frmDanhMucVLChinh_Shown(object sender, EventArgs e)
        {
            StyleDatagrid();
        }

        private void dtgDanhMucVLC_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StyleDatagrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dtgDanhMucVLC);
        }

    }
}
