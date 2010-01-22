namespace DentalLabo.QuanLySPVaLuong
{
    partial class frmChiTietKetQuaCongViec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblChiTietKetQuaCongViec = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaBoPhan = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenBoPhan = new System.Windows.Forms.TextBox();
            this.dtgChiTiet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTuNgay = new System.Windows.Forms.TextBox();
            this.txtDenNgay = new System.Windows.Forms.TextBox();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCongDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongQuyChuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChiTietKetQuaCongViec
            // 
            this.lblChiTietKetQuaCongViec.AutoSize = true;
            this.lblChiTietKetQuaCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietKetQuaCongViec.ForeColor = System.Drawing.Color.Blue;
            this.lblChiTietKetQuaCongViec.Location = new System.Drawing.Point(165, 31);
            this.lblChiTietKetQuaCongViec.Name = "lblChiTietKetQuaCongViec";
            this.lblChiTietKetQuaCongViec.Size = new System.Drawing.Size(306, 25);
            this.lblChiTietKetQuaCongViec.TabIndex = 0;
            this.lblChiTietKetQuaCongViec.Text = "CHI TIẾT KẾT QUẢ CÔNG VIỆC";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(34, 85);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(72, 13);
            this.lblMaNhanVien.TabIndex = 1;
            this.lblMaNhanVien.Text = "Mã nhân viên";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(346, 85);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(76, 13);
            this.lblTenNhanVien.TabIndex = 2;
            this.lblTenNhanVien.Text = "Tên nhân viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(121, 82);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(152, 20);
            this.txtMaNhanVien.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên bộ phận";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã bộ phận";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMaBoPhan
            // 
            this.txtMaBoPhan.Enabled = false;
            this.txtMaBoPhan.Location = new System.Drawing.Point(121, 124);
            this.txtMaBoPhan.Name = "txtMaBoPhan";
            this.txtMaBoPhan.Size = new System.Drawing.Size(152, 20);
            this.txtMaBoPhan.TabIndex = 6;
            this.txtMaBoPhan.TextChanged += new System.EventHandler(this.txtMaBoPhan_TextChanged);
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Enabled = false;
            this.txtTenNhanVien.Location = new System.Drawing.Point(441, 82);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(174, 20);
            this.txtTenNhanVien.TabIndex = 7;
            // 
            // txtTenBoPhan
            // 
            this.txtTenBoPhan.Enabled = false;
            this.txtTenBoPhan.Location = new System.Drawing.Point(441, 124);
            this.txtTenBoPhan.Name = "txtTenBoPhan";
            this.txtTenBoPhan.Size = new System.Drawing.Size(174, 20);
            this.txtTenBoPhan.TabIndex = 8;
            this.txtTenBoPhan.TextChanged += new System.EventHandler(this.txtTenBoPhan_TextChanged);
            // 
            // dtgChiTiet
            // 
            this.dtgChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TT,
            this.mamau,
            this.TenCongDoan,
            this.SoLuongQuyChuan,
            this.Solan});
            this.dtgChiTiet.Location = new System.Drawing.Point(37, 238);
            this.dtgChiTiet.Name = "dtgChiTiet";
            this.dtgChiTiet.Size = new System.Drawing.Size(578, 185);
            this.dtgChiTiet.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(106, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "DANH SÁCH CÁC CÔNG ĐOẠN THAM GIA Ở CÁC MẪU";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(254, 438);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 25);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Từ ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Đến ngày";
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.Enabled = false;
            this.txtTuNgay.Location = new System.Drawing.Point(121, 164);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Size = new System.Drawing.Size(152, 20);
            this.txtTuNgay.TabIndex = 14;
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.Enabled = false;
            this.txtDenNgay.Location = new System.Drawing.Point(441, 164);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Size = new System.Drawing.Size(174, 20);
            this.txtDenNgay.TabIndex = 15;
            // 
            // TT
            // 
            this.TT.HeaderText = "TT";
            this.TT.Name = "TT";
            // 
            // mamau
            // 
            this.mamau.HeaderText = "Mã Mẫu";
            this.mamau.Name = "mamau";
            // 
            // TenCongDoan
            // 
            this.TenCongDoan.HeaderText = "Tên Công Đoạn";
            this.TenCongDoan.Name = "TenCongDoan";
            // 
            // SoLuongQuyChuan
            // 
            this.SoLuongQuyChuan.HeaderText = "Số lượng quy chuẩn";
            this.SoLuongQuyChuan.Name = "SoLuongQuyChuan";
            // 
            // Solan
            // 
            this.Solan.HeaderText = "Số đơn vị làm lại";
            this.Solan.Name = "Solan";
            // 
            // frmChiTietKetQuaCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 482);
            this.Controls.Add(this.txtDenNgay);
            this.Controls.Add(this.txtTuNgay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgChiTiet);
            this.Controls.Add(this.txtTenBoPhan);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtMaBoPhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.lblMaNhanVien);
            this.Controls.Add(this.lblChiTietKetQuaCongViec);
            this.Name = "frmChiTietKetQuaCongViec";
            this.Text = "frmChiTietKetQuaCongViec";
            this.Load += new System.EventHandler(this.frmChiTietKetQuaCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChiTietKetQuaCongViec;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaBoPhan;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtTenBoPhan;
        private System.Windows.Forms.DataGridView dtgChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTuNgay;
        private System.Windows.Forms.TextBox txtDenNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCongDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongQuyChuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solan;
    }
}