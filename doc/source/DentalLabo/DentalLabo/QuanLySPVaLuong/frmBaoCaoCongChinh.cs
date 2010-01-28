using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DentalLabo.Data;
using PrintDataGrid;

namespace DentalLabo.QuanLySPVaLuong
{
    public partial class frmBaoCaoCongChinh : Form
    {
        public frmBaoCaoCongChinh()
        {
            InitializeComponent();
            DataTable dtBoPhan = new DataTable();
            dtBoPhan = DataConnection.Query("Select * from BoPhan");
            cbTenBP.DataSource = dtBoPhan;
            cbTenBP.DisplayMember = "TenBP";
            cbTenBP.ValueMember = "TenBP";

            cbMaBP.DataSource = dtBoPhan;
            cbMaBP.DisplayMember = "MaBP";
            cbMaBP.ValueMember = "MaBP";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query, query1, tmpQuery;
            query1 = "Select * from ChamCong_History where Month(Ngay) = '" + Int32.Parse(dtpThang.Value.ToString("MM")) + "' and Day(Ngay)=";
            tmpQuery = query1;
            query = "Select MaNV, TenNV from NhanVien where MaBP = '" + cbMaBP.Text + "'";

            DataTable newTable = new DataTable();
            newTable.Columns.Add("TT");
            newTable.Columns.Add("Họ và tên");
            for (int i = 1;i <= 31;i++)
            {
                newTable.Columns.Add("" + i + "");
            }
            newTable.Columns.Add("Tổng số");
            dtgCongChinh.Columns.Clear();

            DataTable records = new DataTable();
            DataTable tmpTable = new DataTable();
            records = DataConnection.Query(query);
            DataRow newRow;
            double sumCongChinh = 0;
            int j = 0;
            DateTime date;
            
            foreach (DataRow row in records.Rows)
            {
                newRow = newTable.NewRow();
                sumCongChinh = 0;
                j++;
                newRow[0] = j;
                newRow[1] = row["TenNV"];
                for (int i = 1; i <= 31; ++i)
                {
                    query1 = tmpQuery + "'" + i + "' and MaNV='" + row["MaNV"].ToString() + "'";
                    tmpTable = DataConnection.Query(query1);
                    if (tmpTable.Rows.Count != 0)
                    {
                        double t = Double.Parse(tmpTable.Rows[0]["CongChinh"].ToString()) +
                                        Double.Parse(tmpTable.Rows[0]["TrucChuNhat"].ToString());
                        newRow[i + 1] = (t.ToString() != "0" ? t.ToString() : "0.0");
                        sumCongChinh += Double.Parse(newRow[i + 1].ToString());
                    }
                    else
                    {
                        newRow[i + 1] = "0.0";
                    }
                }
                newRow[33] = sumCongChinh;
                newTable.Rows.Add(newRow);
            }

            dtgCongChinh.DataSource = newTable;

            for (int i = 1; i <= 31; ++i)
            {
                if (i < DateTime.DaysInMonth(Int32.Parse(dtpThang.Value.ToString("yyyy")), Int32.Parse(dtpThang.Value.ToString("MM"))))
                {
                    date = new DateTime(Int32.Parse(dtpThang.Value.ToString("yyyy")),
                                        Int32.Parse(dtpThang.Value.ToString("MM")), i);
                    if (date.DayOfWeek.ToString() == "Sunday")
                    {
                        dtgCongChinh.Columns[i + 1].DefaultCellStyle.BackColor = Color.FromArgb(212, 211, 209);
                    }
                }
            }

        }

        private void frmBaoCaoCongChinh_Load(object sender, EventArgs e)
        {
            dtgCongChinh.Columns.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dtgCongChinh);
        }
    }
}
