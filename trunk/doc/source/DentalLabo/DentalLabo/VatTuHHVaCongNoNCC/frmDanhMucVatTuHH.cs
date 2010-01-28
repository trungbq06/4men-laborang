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
    public partial class frmDanhMucVatTuHH : Form
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

        public frmDanhMucVatTuHH()
        {
            InitializeComponent();
            add = true;
            mouse = false;
            DataTable dtBoPhan = new DataTable();
            dtBoPhan = DataConnection.Query("Select * from NhaCungCap");
            cbTenNCC.DataSource = dtBoPhan;
            cbTenNCC.DisplayMember = "TenNCC";
            cbTenNCC.ValueMember = "TenNCC";
            cbTenNCC1.DataSource = dtBoPhan;
            cbTenNCC1.DisplayMember = "TenNCC";
            cbTenNCC1.ValueMember = "TenNCC";

            cbMaNCC.DataSource = dtBoPhan;
            cbMaNCC.DisplayMember = "MaNCC";
            cbMaNCC.ValueMember = "MaNCC";
            cbMaNCC1.DataSource = dtBoPhan;
            cbMaNCC1.DisplayMember = "MaNCC";
            cbMaNCC1.ValueMember = "MaNCC";

            edit = false;
        }

        private void frmDanhMucVatTuHH_Load(object sender, EventArgs e)
        {
            BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
            dt = bsDanhMuc.GetDanhMuc("VatTu");
                        
            LoadDataToGrid(dt);
            btnXoa.Enabled = false;
            txtMaVT.Text = DataConnection.GetMa("VatTu", "MaVatTu", "VT");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            btnLuu.Enabled = true;
            Reset();            
        }

        private void Reset()
        {
            txtTenVT.Text = "";
            txtMaVT.Text = "";
            txtNhomHH.Text = "";
            txtQuyCach.Text = "";
            txtDonGia.Text = "";
            txtDVT.Text = "";
            txtMaVT.Text = DataConnection.GetMa("VatTu", "MaVatTu", "VT");
        }

        private void LoadDataToGrid(DataTable dt)
        {
            dt.Columns[0].ColumnName = "Mã VT";
            dt.Columns[1].ColumnName = "Mã NCC";
            dt.Columns[2].ColumnName = "Tên Vật Tư";
            dt.Columns[3].ColumnName = "ĐVT";
            dt.Columns[4].ColumnName = "Nhóm Hàng Hóa";
            dt.Columns[5].ColumnName = "Quy Cách";
            dt.Columns[6].ColumnName = "Đơn Giá";
            dt.Columns[0].Unique = true;
            if (dt.Columns.Count < 8)
            {
                DataColumn dtColumn = new DataColumn();
                dtColumn.ColumnName = "Xác nhận";
                dtColumn.DataType = typeof(bool);
                dt.Columns.Add(dtColumn);
            }
            dtgDanhMucVatTuHH.DataSource = dt;
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
                    com.CommandText = "Insert into VatTu values(@MaVatTu, @MaNCC, @TenVatTu, @DVT, @NhomHangHoa, @QuyCach, @DonGia)";
                    com.Parameters.Add("@MaVatTu", txtMaVT.Text);
                    com.Parameters.Add("@MaNCC", cbMaNCC.Text);
                    com.Parameters.Add("@TenVatTu", txtTenVT.Text);
                    com.Parameters.Add("@DVT", txtDVT.Text);
                    com.Parameters.Add("@NhomHangHoa", txtNhomHH.Text);
                    com.Parameters.Add("@QuyCach", txtQuyCach.Text);
                    com.Parameters.Add("@DonGia", txtDonGia.Text);
                    com.ExecuteNonQuery();
                }
                else if (edit) 
                {
                    string str;
                    str = "Update VatTu set MaNCC='" + cbMaNCC.Text + "', ";
                    str += "TenVatTu=N'" + txtTenVT.Text + "', ";
                    str += "DVT=N'" + txtDVT.Text + "', ";
                    str += "NhomHangHoa=N'" + txtNhomHH.Text + "', ";
                    str += "QuyCach=N'" + txtQuyCach.Text + "', ";
                    str += "DonGia=N'" + cbMaNCC.Text + "'";
                    str += " where MaVatTu='" + txtMaVT.Text + "'";
                    MessageBox.Show(str);
                    com.CommandText = str;
                    com.ExecuteNonQuery();
                }

                add = true;
                edit = false;
                if (ok) MessageBox.Show("Cập nhật thành công!", "Thông báo");
                BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
                dt = bsDanhMuc.GetDanhMuc("VatTu");
                LoadDataToGrid(dt);
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật dữ liệu\nLỗi được thông báo là: " + ex.Message.ToString(), "Lỗi");
            }
        }

        private void dtgDanhMucVatTuHH_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Dữ liệu nhập chưa đúng! Có thể đã trùng mã SP hoặc tên SP hoặc dữ liệu chưa đúng định dạng!", "Lỗi");
        }

        private void StyleDatagrid()
        {
            try
            {
                for (int i = 0; i < dtgDanhMucVatTuHH.Rows.Count; ++i)
                {
                    if (dtgDanhMucVatTuHH.Rows[i].Cells[7].Value.ToString() != "True")
                    {
                        if (i % 2 == 0) dtgDanhMucVatTuHH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucVatTuHH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                    }
                    else
                        dtgDanhMucVatTuHH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                }
            }
            catch (Exception ex) { }
        }

        private void dtgDanhMucVatTuHH_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!add || !edit)
            {
                try
                {
                    int row = e.RowIndex;
                    for (int i = 0; i < dtgDanhMucVatTuHH.Rows.Count; ++i)
                    {
                        if (dtgDanhMucVatTuHH.Rows[i].Cells[7].Value.ToString() != "True")
                        {
                            if (i % 2 == 0) dtgDanhMucVatTuHH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                            else dtgDanhMucVatTuHH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                        }
                        //Màu cho hàng được chọn
                        else
                            dtgDanhMucVatTuHH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    //Màu cho Mouse Hover
                    if (dtgDanhMucVatTuHH.Rows[row].Cells[7].Value.ToString() != "True")
                        dtgDanhMucVatTuHH.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(181, 218, 174);
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
                        for (int i = 0; i < dtgDanhMucVatTuHH.Rows.Count; ++i)
                        {
                            if (dtgDanhMucVatTuHH.Rows[i].Cells[7].Value.ToString() == "True")
                            {
                                array.Add(dtgDanhMucVatTuHH.Rows[i].Cells[0].Value.ToString());
                            }
                        }
                        bsDanhMuc.DeleteFromDanhMuc(array, "VatTu", "MaVatTu");
                        dt = bsDanhMuc.GetDanhMuc("VatTu");
                        LoadDataToGrid(dt);
                        Reset();
                    }
            }
            catch (Exception ex) { }
        }

        private void dtgDanhMucVatTuHH_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnLuu.Enabled = true;
        }

        //Sự kiện khi form đã load xong
        private void frmDanhMucVatTuHH_Shown(object sender, EventArgs e)
        {
            StyleDatagrid();
        }

        private void dtgDanhMucVatTuHH_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StyleDatagrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dtgDanhMucVatTuHH);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string str = "Select * from VatTu where MaNCC = '" + cbMaNCC1.Text + "'";
            if (cbMaNCC1.Text == "") str = "Select * from VatTu";
            DataTable dt = DataConnection.Query(str);
            LoadDataToGrid(dt);
        }

        private void dtgDanhMucVatTuHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            add = false;
            edit = true;
            try
            {
                if (!add)
                {
                    string ok = dtgDanhMucVatTuHH.Rows[e.RowIndex].Cells[7].Value.ToString();
                    bool check = (ok == "True") ? true : false;
                    int j = e.RowIndex;
                    //MessageBox.Show(i.ToString());
                    if (ok == "True")
                    {
                        count--;
                        if (j % 2 == 0) dtgDanhMucVatTuHH.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgDanhMucVatTuHH.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(196, 195, 193);
                    }
                    else
                    {
                        count++;
                        dtgDanhMucVatTuHH.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    dtgDanhMucVatTuHH.Rows[e.RowIndex].Cells[7].Value = !check;
                    if (count > 0) btnXoa.Enabled = true;
                    else btnXoa.Enabled = false;
                }
            }
            catch (Exception ex) { }

            btnXoa.Enabled = true;
            try
            {
                txtMaVT.Text = dtgDanhMucVatTuHH.Rows[e.RowIndex].Cells[0].Value.ToString();                
                cbMaNCC.Text = dtgDanhMucVatTuHH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenVT.Text = dtgDanhMucVatTuHH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDVT.Text = dtgDanhMucVatTuHH.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNhomHH.Text = dtgDanhMucVatTuHH.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtQuyCach.Text = dtgDanhMucVatTuHH.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDonGia.Text = dtgDanhMucVatTuHH.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception ex) { }
        }

    }
}
