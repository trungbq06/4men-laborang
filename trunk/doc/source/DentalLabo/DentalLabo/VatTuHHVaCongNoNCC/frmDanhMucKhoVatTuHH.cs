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
    public partial class frmDanhMucKhoVatTuHH : Form
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

        public frmDanhMucKhoVatTuHH()
        {
            InitializeComponent();
            add = false;
            mouse = false;
        }

        private void frmDanhMucKhoVatTuHH_Load(object sender, EventArgs e)
        {
            BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
            dt = bsDanhMuc.GetDanhMuc("KhoHang");

            con = DataConnection.Connect();
            sqlCom = new SqlCommand("Select * from KhoHang", con);

            // Create a SqlDataAdapter object 
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCom;

            // Create a SqlCommandBuilder object 
            builder = new SqlCommandBuilder(adapter);

            // Fill DataSet with data from Employees table
            //adapter.Fill(dataSet, "VatLieuPhu");

            // Bind the DataGrid at run time
            //adapter.TableMappings.Add("Table", dt.TableName);
            //dtgDanhMucKhoVatTuHH.SetDataBinding(dataSet, "VatLieuPhu");
            LoadDataToGrid(dt);
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            btnLuu.Enabled = true;

            dtgDanhMucKhoVatTuHH.AllowUserToAddRows = true;
            dtgDanhMucKhoVatTuHH.ReadOnly = false;
            dtgDanhMucKhoVatTuHH.Columns[6].ReadOnly = true;
        }

        private void LoadDataToGrid(DataTable dt)
        {
            dt.Columns[0].ColumnName = "Mã Kho";
            dt.Columns[1].ColumnName = "Tên Kho";
            dt.Columns[2].ColumnName = "Mã Thủ Kho";
            dt.Columns[3].ColumnName = "Địa chỉ";
            dt.Columns[4].ColumnName = "Điện thoại";
            dt.Columns[5].ColumnName = "Thủ Kho";
            dt.Columns[0].Unique = true;
            dt.Columns[1].Unique = true;
            dtgDanhMucKhoVatTuHH.DataSource = dt;
            StyleDatagrid();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = true;
                dt.Columns[0].ColumnName = "MaKho";
                dt.Columns[1].ColumnName = "TenKho";                
                dt.Columns[2].ColumnName = "MaThuKho";
                dt.Columns[3].ColumnName = "DiaChi";
                dt.Columns[4].ColumnName = "DienThoai";
                dt.Columns[5].ColumnName = "ThuKho";
                adapter.Update(dt);
                dt.Columns[0].ColumnName = "Mã Kho";
                dt.Columns[1].ColumnName = "Tên Kho";
                dt.Columns[2].ColumnName = "Mã Thủ Kho";
                dt.Columns[3].ColumnName = "Địa chỉ";
                dt.Columns[4].ColumnName = "Điện thoại";
                dt.Columns[5].ColumnName = "Thủ Kho";
                //dt.Columns[0].Unique = true;
                //dt.Columns[1].Unique = true;

                BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
                add = false;
                if (ok) MessageBox.Show("Cập nhật thành công!", "Thông báo");
                dtgDanhMucKhoVatTuHH.AllowUserToAddRows = false;
                dtgDanhMucKhoVatTuHH.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật dữ liệu\nLỗi được thông báo là: " + ex.Message.ToString(), "Lỗi");
            }
        }

        private void dtgDanhMucKhoVatTuHH_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Dữ liệu nhập chưa đúng! Có thể đã trùng mã SP hoặc tên SP hoặc dữ liệu chưa đúng định dạng!", "Lỗi");
        }

        private void StyleDatagrid()
        {
            try
            {
                for (int i = 0; i < dtgDanhMucKhoVatTuHH.Rows.Count; ++i)
                {
                    if (dtgDanhMucKhoVatTuHH.Rows[i].Cells[6].Value.ToString() != "True")
                    {
                        if (i % 2 == 0) dtgDanhMucKhoVatTuHH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucKhoVatTuHH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                    }
                    else
                        dtgDanhMucKhoVatTuHH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                }
            }
            catch (Exception ex) { }
        }

        private void dtgDanhMucKhoVatTuHH_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!add)
            {
                try
                {
                    int row = e.RowIndex;
                    for (int i = 0; i < dtgDanhMucKhoVatTuHH.Rows.Count; ++i)
                    {
                        if (dtgDanhMucKhoVatTuHH.Rows[i].Cells[6].Value.ToString() != "True")
                        {
                            if (i % 2 == 0) dtgDanhMucKhoVatTuHH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                            else dtgDanhMucKhoVatTuHH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                        }
                        //Màu cho hàng được chọn
                        else
                            dtgDanhMucKhoVatTuHH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    //Màu cho Mouse Hover
                    if (dtgDanhMucKhoVatTuHH.Rows[row].Cells[6].Value.ToString() != "True")
                        dtgDanhMucKhoVatTuHH.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(181, 218, 174);
                }
                catch (Exception ex) { }
            }
        }

        private void dtgDanhMucKhoVatTuHH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (!add)
                {
                    string ok = dtgDanhMucKhoVatTuHH.Rows[e.RowIndex].Cells[6].Value.ToString();
                    bool check = (ok == "True") ? true : false;
                    int j = e.RowIndex;
                    //MessageBox.Show(i.ToString());
                    if (ok == "True")
                    {
                        count--;
                        if (j % 2 == 0) dtgDanhMucKhoVatTuHH.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucKhoVatTuHH.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(196, 195, 193);
                    }
                    else
                    {
                        count++;
                        dtgDanhMucKhoVatTuHH.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    dtgDanhMucKhoVatTuHH.Rows[e.RowIndex].Cells[6].Value = !check;
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
                        for (int i = 0; i < dtgDanhMucKhoVatTuHH.Rows.Count; ++i)
                        {
                            if (dtgDanhMucKhoVatTuHH.Rows[i].Cells[6].Value.ToString() == "True")
                            {
                                array.Add(dtgDanhMucKhoVatTuHH.Rows[i].Cells[0].Value.ToString());
                            }
                        }
                        bsDanhMuc.DeleteFromDanhMuc(array, "KhoHang", "MaKho");
                        dt = bsDanhMuc.GetDanhMuc("KhoHang");
                        LoadDataToGrid(dt);
                        dtgDanhMucKhoVatTuHH.ReadOnly = true;
                    }
            }
            catch (Exception ex) { }
        }

        private void dtgDanhMucKhoVatTuHH_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnLuu.Enabled = true;
        }

        //Sự kiện khi form đã load xong
        private void frmDanhMucKhoVatTuHH_Shown(object sender, EventArgs e)
        {
            StyleDatagrid();
        }

        private void dtgDanhMucKhoVatTuHH_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StyleDatagrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dtgDanhMucKhoVatTuHH);
        }

    }
}
