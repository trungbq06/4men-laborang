namespace DentalLabo
{
    partial class frmDieuChinhTyGiaTT
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTyGiaTT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.dtgTyGiaTT = new System.Windows.Forms.DataGridView();
            this.txtTenNgoaiTe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnApDung = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDanhMucBoPhanLuu = new System.Windows.Forms.Button();
            this.btnDanhMucBoPhanXoa = new System.Windows.Forms.Button();
            this.btnDanhMucBoPhanSua = new System.Windows.Forms.Button();
            this.btnDanhMucBoPhanThemMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTyGiaTT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên ngoại tệ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tỷ giá TT";
            // 
            // txtTyGiaTT
            // 
            this.txtTyGiaTT.Location = new System.Drawing.Point(227, 86);
            this.txtTyGiaTT.Name = "txtTyGiaTT";
            this.txtTyGiaTT.Size = new System.Drawing.Size(108, 20);
            this.txtTyGiaTT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(81, 52);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(138, 20);
            this.dtpTuNgay.TabIndex = 5;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(298, 52);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(138, 20);
            this.dtpDenNgay.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên KH";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(81, 19);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(138, 20);
            this.txtTenKH.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(298, 19);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(138, 20);
            this.txtMaKH.TabIndex = 11;
            // 
            // dtgTyGiaTT
            // 
            this.dtgTyGiaTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTyGiaTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtgTyGiaTT.Location = new System.Drawing.Point(12, 225);
            this.dtgTyGiaTT.Name = "dtgTyGiaTT";
            this.dtgTyGiaTT.Size = new System.Drawing.Size(443, 225);
            this.dtgTyGiaTT.TabIndex = 12;
            // 
            // txtTenNgoaiTe
            // 
            this.txtTenNgoaiTe.FormattingEnabled = true;
            this.txtTenNgoaiTe.Location = new System.Drawing.Point(81, 86);
            this.txtTenNgoaiTe.Name = "txtTenNgoaiTe";
            this.txtTenNgoaiTe.Size = new System.Drawing.Size(77, 21);
            this.txtTenNgoaiTe.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(73, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(349, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "ĐIỀU CHỈNH TỶ GIÁ THANH TOÁN";
            // 
            // btnApDung
            // 
            this.btnApDung.Location = new System.Drawing.Point(361, 86);
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.Size = new System.Drawing.Size(75, 23);
            this.btnApDung.TabIndex = 15;
            this.btnApDung.Text = "Áp dụng";
            this.btnApDung.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApDung);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpTuNgay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTenNgoaiTe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTyGiaTT);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.dtpDenNgay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 123);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(124, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "TỶ GIÁ THANH TOÁN";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã số KH";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên ngoại tệ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tỷ giá thanh toán";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Từ ngày";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Đến ngày";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Xác nhận";
            this.Column7.Name = "Column7";
            // 
            // btnDanhMucBoPhanLuu
            // 
            this.btnDanhMucBoPhanLuu.Location = new System.Drawing.Point(373, 479);
            this.btnDanhMucBoPhanLuu.Name = "btnDanhMucBoPhanLuu";
            this.btnDanhMucBoPhanLuu.Size = new System.Drawing.Size(75, 23);
            this.btnDanhMucBoPhanLuu.TabIndex = 24;
            this.btnDanhMucBoPhanLuu.Text = "Lưu";
            this.btnDanhMucBoPhanLuu.UseVisualStyleBackColor = true;
            // 
            // btnDanhMucBoPhanXoa
            // 
            this.btnDanhMucBoPhanXoa.Location = new System.Drawing.Point(254, 479);
            this.btnDanhMucBoPhanXoa.Name = "btnDanhMucBoPhanXoa";
            this.btnDanhMucBoPhanXoa.Size = new System.Drawing.Size(75, 23);
            this.btnDanhMucBoPhanXoa.TabIndex = 23;
            this.btnDanhMucBoPhanXoa.Text = "Xóa";
            this.btnDanhMucBoPhanXoa.UseVisualStyleBackColor = true;
            // 
            // btnDanhMucBoPhanSua
            // 
            this.btnDanhMucBoPhanSua.Location = new System.Drawing.Point(143, 479);
            this.btnDanhMucBoPhanSua.Name = "btnDanhMucBoPhanSua";
            this.btnDanhMucBoPhanSua.Size = new System.Drawing.Size(75, 23);
            this.btnDanhMucBoPhanSua.TabIndex = 22;
            this.btnDanhMucBoPhanSua.Text = "Sửa";
            this.btnDanhMucBoPhanSua.UseVisualStyleBackColor = true;
            // 
            // btnDanhMucBoPhanThemMoi
            // 
            this.btnDanhMucBoPhanThemMoi.Location = new System.Drawing.Point(50, 479);
            this.btnDanhMucBoPhanThemMoi.Name = "btnDanhMucBoPhanThemMoi";
            this.btnDanhMucBoPhanThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnDanhMucBoPhanThemMoi.TabIndex = 21;
            this.btnDanhMucBoPhanThemMoi.Text = "Thêm mới";
            this.btnDanhMucBoPhanThemMoi.UseVisualStyleBackColor = true;
            // 
            // frmDieuChinhTyGiaTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 514);
            this.Controls.Add(this.btnDanhMucBoPhanLuu);
            this.Controls.Add(this.btnDanhMucBoPhanXoa);
            this.Controls.Add(this.btnDanhMucBoPhanSua);
            this.Controls.Add(this.btnDanhMucBoPhanThemMoi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgTyGiaTT);
            this.Name = "frmDieuChinhTyGiaTT";
            this.Text = "Điều chỉnh tỷ giá thanh toán";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTyGiaTT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTyGiaTT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.DataGridView dtgTyGiaTT;
        private System.Windows.Forms.ComboBox txtTenNgoaiTe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnApDung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.Button btnDanhMucBoPhanLuu;
        private System.Windows.Forms.Button btnDanhMucBoPhanXoa;
        private System.Windows.Forms.Button btnDanhMucBoPhanSua;
        private System.Windows.Forms.Button btnDanhMucBoPhanThemMoi;
    }
}