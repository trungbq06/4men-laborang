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
    public partial class frmBangGiaSP : Form
    {
        private DataTable dt;
        private int count;
        private bool add;
        private bool edit;
        private bool entering;
        private DataTable dtSanPham;
        private DataTable dtVLC;

        public frmBangGiaSP()
        {
            InitializeComponent();
            count = 0;
            add = true;
            edit = false;
            entering = false;
            dtSanPham = DataConnection.Query("Select * from SanPham");
            dtVLC = DataConnection.Query("Select * from VatLieuChinh");
            cbTenSP.DataSource = dtSanPham;            
            cbTenSP.DisplayMember = "TenSP";
            cbTenSP.ValueMember = "TenSP";
            cbMaSP.DataSource = dtSanPham;
            cbMaSP.DisplayMember = "MaSP";
            cbMaSP.ValueMember = "MaSP";

            cbTenVLC.DataSource = dtVLC;
            cbTenVLC.DisplayMember = "TenVL";
            cbTenVLC.ValueMember = "TenVL";
            cbMaVLC.DataSource = dtVLC;
            cbMaVLC.DisplayMember = "MaVL";
            cbMaVLC.ValueMember = "MaVL";
        }

        private void dtgBangGiaSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edit = true;
            add = false;
            try
            {
                if (!add)
                {
                    string ok = dtgBangGiaSP.Rows[e.RowIndex].Cells[7].Value.ToString();
                    bool check = (ok == "True") ? true : false;
                    int j = e.RowIndex;
                    //MessageBox.Show(i.ToString());
                    if (ok == "True")
                    {
                        count--;
                        if (j % 2 == 0) dtgBangGiaSP.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgBangGiaSP.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(196, 195, 193);
                    }
                    else
                    {
                        count++;
                        dtgBangGiaSP.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    dtgBangGiaSP.Rows[e.RowIndex].Cells[7].Value = !check;
                    if (count > 0) btnXoa.Enabled = true;
                    else btnXoa.Enabled = false;
                }
            }
            catch (Exception ex) { }

            btnXoa.Enabled = true;
            try
            {
                cbMaSP.SelectedValue = dtgBangGiaSP.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbTenSP.Text = dtgBangGiaSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbMaVLC.Text = dtgBangGiaSP.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbTenVLC.Text = dtgBangGiaSP.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDonGia.Text = dtgBangGiaSP.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDonGia29.Text = dtgBangGiaSP.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDonGia10.Text = dtgBangGiaSP.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception ex) {}
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
                        for (int i = 0; i < dtgBangGiaSP.Rows.Count; ++i)
                        {
                            if (dtgBangGiaSP.Rows[i].Cells[7].Value.ToString() == "True")
                            {
                                array.Add(dtgBangGiaSP.Rows[i].Cells[0].Value.ToString());
                                array1.Add(dtgBangGiaSP.Rows[i].Cells[2].Value.ToString());
                            }
                        }                        
                        bsDanhMuc.DeleteFromDanhMucs(array, array1, "BangGia", "MaSP", "MaVL");
                        dt = bsDanhMuc.GetDanhMuc("BangGia");
                        LoadDataToGrid(dt);
                        dtgBangGiaSP.ReadOnly = true;
                        Reset();
                    }
            }
            catch (Exception ex) { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                BussinessBangGiaSP bsBanggia = new BussinessBangGiaSP();
                if (cbMaSP.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã SP", "Thông báo");
                else if (cbMaVLC.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã VL", "Thông báo");
                else
                {
                    BangGiaSP banggia = new BangGiaSP();

                    banggia.MaSP = cbMaSP.SelectedValue.ToString();
                    banggia.MaVL = cbMaVLC.SelectedValue.ToString();
                    banggia.DonGia = Double.Parse(txtDonGia.Text.ToString());
                    banggia.DonGia2_9 = Double.Parse(txtDonGia29.Text.ToString());
                    banggia.DonGia10 = Double.Parse(txtDonGia10.Text.ToString());

                    if (add)
                    {
                        bsBanggia.AddDanhMuc(banggia);
                    }
                    else if (edit) bsBanggia.UpdateDanhMuc(banggia, "MaSP", banggia.MaSP, "MaVL", banggia.MaVL);

                    BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
                    dt = bsDanhMuc.GetDanhMuc("BangGia");
                    LoadDataToGrid(dt);
                    add = true;
                    edit = false;
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình lưu\n" + ex.Message.ToString(), "Lỗi");
            }
        }

        private void frmBangGiaSP_Load(object sender, EventArgs e)
        {
            BusinessDanhMucSP bsDanhMuc = new BusinessDanhMucSP();
            dt = bsDanhMuc.GetDanhMuc("BangGia");
            LoadDataToGrid(dt);
        }

        private void LoadDataToGrid(DataTable dt)
        {
            DataTable dtNew = new DataTable();
            dtNew.Columns.Add(new DataColumn("Mã SP"));
            dtNew.Columns.Add(new DataColumn("Tên SP"));
            dtNew.Columns.Add(new DataColumn("Mã VLC"));
            dtNew.Columns.Add(new DataColumn("Tên VLC"));
            dtNew.Columns.Add(new DataColumn("Đơn giá"));
            dtNew.Columns.Add(new DataColumn("Đơn giá 2-9"));
            dtNew.Columns.Add(new DataColumn("Đơn giá 10"));
            DataTable dtTmp = new DataTable();
            foreach (DataRow row in dt.Rows)
            {
                DataRow newRow = dtNew.NewRow();
                newRow[0] = row[0];
                dtTmp = DataConnection.Query("Select TenSP from SanPham where MaSP='" + row[0] + "'");
                newRow[1] = dtTmp.Rows[0][0];
                dtTmp = DataConnection.Query("Select TenVL from VatLieuChinh where MaVL='" + row[1] + "'");
                newRow[2] = row[1];
                newRow[3] = dtTmp.Rows[0][0];
                newRow[4] = row[2];
                newRow[5] = row[3];
                newRow[6] = row[4];
                dtNew.Rows.Add(newRow);
            }
            DataColumn dtColumn = new DataColumn();
            dtColumn.ColumnName = "Xác nhận";
            dtColumn.DataType = typeof(bool);
            dtNew.Columns.Add(dtColumn);
            dtgBangGiaSP.DataSource = dtNew;
            dtgBangGiaSP.Columns[4].DefaultCellStyle.Format = "N0";
            dtgBangGiaSP.Columns[5].DefaultCellStyle.Format = "N0";
            dtgBangGiaSP.Columns[6].DefaultCellStyle.Format = "N0";
            dtgBangGiaSP.Columns[7].ValueType = typeof(bool);
        }

        private void StyleDatagrid()
        {
            try
            {
                for (int i = 0; i < dtgBangGiaSP.Rows.Count; ++i)
                {
                    if (dtgBangGiaSP.Rows[i].Cells[7].Value.ToString() != "True")
                    {
                        if (i % 2 == 0) dtgBangGiaSP.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgBangGiaSP.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                    }
                    else
                        dtgBangGiaSP.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                }
            }
            catch (Exception ex) { }
        }

        private void frmBangGiaSP_Shown(object sender, EventArgs e)
        {
            StyleDatagrid();
        }

        private void dtgBangGiaSP_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StyleDatagrid();
        }

        private void dtgBangGiaSP_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!add || !edit)
            {
                try
                {
                    int row = e.RowIndex;
                    for (int i = 0; i < dtgBangGiaSP.Rows.Count; ++i)
                    {
                        if (dtgBangGiaSP.Rows[i].Cells[7].Value.ToString() != "True")
                        {
                            if (i % 2 == 0) dtgBangGiaSP.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                            else dtgBangGiaSP.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                        }
                        //Màu cho hàng được chọn
                        else
                            dtgBangGiaSP.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    //Màu cho Mouse Hover
                    if (dtgBangGiaSP.Rows[row].Cells[7].Value.ToString() != "True")
                        dtgBangGiaSP.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(181, 218, 174);
                }
                catch (Exception ex) { }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDataGrid.PrintDGV.Print_DataGridView(dtgBangGiaSP);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            edit = false;
            Reset();
        }

        private void Reset()
        {
            txtDonGia.Text = "";
            txtDonGia29.Text = "";
            txtDonGia10.Text = "";
        }

        private void dtgBangGiaSP_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Dữ liệu nhập chưa đúng! Có thể đã trùng mã SP hoặc tên SP hoặc dữ liệu chưa đúng định dạng!", "Lỗi");
        }
        
        private void cbMaBP_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt = DataConnection.Query("Select * from BoPhan where MaBP = '" + cbTenBP.Text + "'");
            //if (dt.Rows.Count > 0) cbTenBP.Text = dt.Rows[0][1].ToString();
        }

        private void dtgBangGiaSP_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            edit = true;
            add = false;
            try
            {
                if (!add)
                {
                    string ok = dtgBangGiaSP.Rows[e.RowIndex].Cells[7].Value.ToString();
                    bool check = (ok == "True") ? true : false;
                    int j = e.RowIndex;
                    //MessageBox.Show(i.ToString());
                    if (ok == "True")
                    {
                        count--;
                        if (j % 2 == 0) dtgBangGiaSP.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 239);
                        else dtgBangGiaSP.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(196, 195, 193);
                    }
                    else
                    {
                        count++;
                        dtgBangGiaSP.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(235, 195, 133);
                    }
                    dtgBangGiaSP.Rows[e.RowIndex].Cells[7].Value = !check;
                    if (count > 0) btnXoa.Enabled = true;
                    else btnXoa.Enabled = false;
                }
            }
            catch (Exception ex) { }

            btnXoa.Enabled = true;
            try
            {
                cbMaSP.SelectedValue = dtgBangGiaSP.Rows[e.RowIndex].Cells[0].Value.ToString();       
                cbTenSP.SelectedValue = dtgBangGiaSP.Rows[e.RowIndex].Cells[1].Value.ToString();    
                cbMaVLC.SelectedValue = dtgBangGiaSP.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbTenVLC.SelectedValue = dtgBangGiaSP.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDonGia.Text = dtgBangGiaSP.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDonGia29.Text = dtgBangGiaSP.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDonGia10.Text = dtgBangGiaSP.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception ex) { }
        }

    }
}
