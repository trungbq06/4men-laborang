namespace DentalLabo.Nhap_kho_va_ban_hang
{
    partial class frmPhieuTT
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
            this.label12 = new System.Windows.Forms.Label();
            this.dtgChiTietCongNoKH = new System.Windows.Forms.DataGridView();
            this.clnThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNgayNhanMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMaSoMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNoiDungCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPhieuNhapKho = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dateNgayTT = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoPhieuTT = new System.Windows.Forms.TextBox();
            this.boPhanNhapKho = new System.Windows.Forms.GroupBox();
            this.txtMaSoBP = new System.Windows.Forms.TextBox();
            this.txtNguoiDaiDien = new System.Windows.Forms.TextBox();
            this.txtMaSoThue = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuDauKy = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.lblDuCuoiKy = new System.Windows.Forms.Label();
            this.txtDuCuoiKy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietCongNoKH)).BeginInit();
            this.grpPhieuNhapKho.SuspendLayout();
            this.boPhanNhapKho.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(725, 33);
            this.label12.TabIndex = 24;
            this.label12.Text = "SỔ CHI TIẾT CÔNG NỢ KHÁCH HÀNG MUA HÀNG TRONG KỲ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgChiTietCongNoKH
            // 
            this.dtgChiTietCongNoKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChiTietCongNoKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnThuTu,
            this.clnNgayNhanMau,
            this.clnNgay,
            this.clnSoHD,
            this.clnMaSoMau,
            this.clnNoiDungCongViec,
            this.clnThanhTien});
            this.dtgChiTietCongNoKH.Location = new System.Drawing.Point(12, 48);
            this.dtgChiTietCongNoKH.Name = "dtgChiTietCongNoKH";
            this.dtgChiTietCongNoKH.Size = new System.Drawing.Size(736, 164);
            this.dtgChiTietCongNoKH.TabIndex = 23;
            this.dtgChiTietCongNoKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgChiTietCongNoKH_CellContentClick);
            // 
            // clnThuTu
            // 
            this.clnThuTu.Frozen = true;
            this.clnThuTu.HeaderText = "TT";
            this.clnThuTu.Name = "clnThuTu";
            this.clnThuTu.Width = 50;
            // 
            // clnNgayNhanMau
            // 
            this.clnNgayNhanMau.Frozen = true;
            this.clnNgayNhanMau.HeaderText = "Ngày nhận mẫu";
            this.clnNgayNhanMau.Name = "clnNgayNhanMau";
            this.clnNgayNhanMau.Width = 150;
            // 
            // clnNgay
            // 
            this.clnNgay.HeaderText = "Ngày";
            this.clnNgay.Name = "clnNgay";
            // 
            // clnSoHD
            // 
            this.clnSoHD.HeaderText = "Số HD";
            this.clnSoHD.Name = "clnSoHD";
            // 
            // clnMaSoMau
            // 
            this.clnMaSoMau.HeaderText = "Mã số mẫu";
            this.clnMaSoMau.Name = "clnMaSoMau";
            // 
            // clnNoiDungCongViec
            // 
            this.clnNoiDungCongViec.HeaderText = "Nội dung công việc";
            this.clnNoiDungCongViec.Name = "clnNoiDungCongViec";
            this.clnNoiDungCongViec.Width = 300;
            // 
            // clnThanhTien
            // 
            this.clnThanhTien.HeaderText = "Thành tiền";
            this.clnThanhTien.Name = "clnThanhTien";
            // 
            // grpPhieuNhapKho
            // 
            this.grpPhieuNhapKho.Controls.Add(this.btnTimKiem);
            this.grpPhieuNhapKho.Controls.Add(this.dateNgayTT);
            this.grpPhieuNhapKho.Controls.Add(this.label11);
            this.grpPhieuNhapKho.Controls.Add(this.label8);
            this.grpPhieuNhapKho.Controls.Add(this.txtSoPhieuTT);
            this.grpPhieuNhapKho.Location = new System.Drawing.Point(530, 68);
            this.grpPhieuNhapKho.Name = "grpPhieuNhapKho";
            this.grpPhieuNhapKho.Size = new System.Drawing.Size(268, 124);
            this.grpPhieuNhapKho.TabIndex = 20;
            this.grpPhieuNhapKho.TabStop = false;
            this.grpPhieuNhapKho.Text = "Số phiếu thanh toán";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(104, 88);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dateNgayTT
            // 
            this.dateNgayTT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTT.Location = new System.Drawing.Point(88, 33);
            this.dateNgayTT.Name = "dateNgayTT";
            this.dateNgayTT.Size = new System.Drawing.Size(174, 20);
            this.dateNgayTT.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ngày TT";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số phiếu TT";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoPhieuTT
            // 
            this.txtSoPhieuTT.Location = new System.Drawing.Point(88, 62);
            this.txtSoPhieuTT.Name = "txtSoPhieuTT";
            this.txtSoPhieuTT.Size = new System.Drawing.Size(174, 20);
            this.txtSoPhieuTT.TabIndex = 1;
            // 
            // boPhanNhapKho
            // 
            this.boPhanNhapKho.Controls.Add(this.txtMaSoBP);
            this.boPhanNhapKho.Controls.Add(this.txtNguoiDaiDien);
            this.boPhanNhapKho.Controls.Add(this.txtMaSoThue);
            this.boPhanNhapKho.Controls.Add(this.txtDiaChi);
            this.boPhanNhapKho.Controls.Add(this.txtTenKhachHang);
            this.boPhanNhapKho.Controls.Add(this.label7);
            this.boPhanNhapKho.Controls.Add(this.label3);
            this.boPhanNhapKho.Controls.Add(this.label2);
            this.boPhanNhapKho.Controls.Add(this.label5);
            this.boPhanNhapKho.Controls.Add(this.label1);
            this.boPhanNhapKho.Location = new System.Drawing.Point(29, 68);
            this.boPhanNhapKho.Name = "boPhanNhapKho";
            this.boPhanNhapKho.Size = new System.Drawing.Size(484, 124);
            this.boPhanNhapKho.TabIndex = 19;
            this.boPhanNhapKho.TabStop = false;
            this.boPhanNhapKho.Text = "Khách hàng";
            // 
            // txtMaSoBP
            // 
            this.txtMaSoBP.Location = new System.Drawing.Point(327, 30);
            this.txtMaSoBP.Name = "txtMaSoBP";
            this.txtMaSoBP.Size = new System.Drawing.Size(138, 20);
            this.txtMaSoBP.TabIndex = 1;
            this.txtMaSoBP.TextChanged += new System.EventHandler(this.txtMaSoBP_TextChanged);
            // 
            // txtNguoiDaiDien
            // 
            this.txtNguoiDaiDien.Location = new System.Drawing.Point(285, 85);
            this.txtNguoiDaiDien.Name = "txtNguoiDaiDien";
            this.txtNguoiDaiDien.Size = new System.Drawing.Size(180, 20);
            this.txtNguoiDaiDien.TabIndex = 1;
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.Location = new System.Drawing.Point(98, 85);
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.Size = new System.Drawing.Size(99, 20);
            this.txtMaSoThue.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(98, 59);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(367, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(98, 30);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(100, 20);
            this.txtTenKhachHang.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Người đại diện";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã số thuế";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa chỉ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã số BP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dư đầu kỳ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDuDauKy
            // 
            this.txtDuDauKy.Location = new System.Drawing.Point(559, 13);
            this.txtDuDauKy.Name = "txtDuDauKy";
            this.txtDuDauKy.Size = new System.Drawing.Size(168, 20);
            this.txtDuDauKy.TabIndex = 1;
            this.txtDuDauKy.TextChanged += new System.EventHandler(this.txtMaSoBP_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgChiTietCongNoKH);
            this.groupBox1.Controls.Add(this.btnXemBaoCao);
            this.groupBox1.Controls.Add(this.btnInPhieu);
            this.groupBox1.Controls.Add(this.lblDuCuoiKy);
            this.groupBox1.Controls.Add(this.txtDuCuoiKy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDuDauKy);
            this.groupBox1.Location = new System.Drawing.Point(29, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 330);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sổ chi tiết công nợ";
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.AutoSize = true;
            this.btnXemBaoCao.Location = new System.Drawing.Point(439, 279);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(125, 23);
            this.btnXemBaoCao.TabIndex = 3;
            this.btnXemBaoCao.Text = "Xem báo cáo tổng hợp";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.AutoSize = true;
            this.btnInPhieu.Location = new System.Drawing.Point(185, 279);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(154, 23);
            this.btnInPhieu.TabIndex = 3;
            this.btnInPhieu.Text = "In phiếu tổng hợp thanh toán";
            this.btnInPhieu.UseVisualStyleBackColor = true;
            // 
            // lblDuCuoiKy
            // 
            this.lblDuCuoiKy.AutoSize = true;
            this.lblDuCuoiKy.Location = new System.Drawing.Point(476, 228);
            this.lblDuCuoiKy.Name = "lblDuCuoiKy";
            this.lblDuCuoiKy.Size = new System.Drawing.Size(58, 13);
            this.lblDuCuoiKy.TabIndex = 0;
            this.lblDuCuoiKy.Text = "Dư cuối kỳ";
            this.lblDuCuoiKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDuCuoiKy.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDuCuoiKy
            // 
            this.txtDuCuoiKy.Location = new System.Drawing.Point(559, 225);
            this.txtDuCuoiKy.Name = "txtDuCuoiKy";
            this.txtDuCuoiKy.Size = new System.Drawing.Size(168, 20);
            this.txtDuCuoiKy.TabIndex = 1;
            this.txtDuCuoiKy.TextChanged += new System.EventHandler(this.txtMaSoBP_TextChanged);
            // 
            // frmPhieuTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 589);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grpPhieuNhapKho);
            this.Controls.Add(this.boPhanNhapKho);
            this.Name = "frmPhieuTT";
            this.Text = "So chi tiet cong no khach hang mua hang trong ky";
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietCongNoKH)).EndInit();
            this.grpPhieuNhapKho.ResumeLayout(false);
            this.grpPhieuNhapKho.PerformLayout();
            this.boPhanNhapKho.ResumeLayout(false);
            this.boPhanNhapKho.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dtgChiTietCongNoKH;
        private System.Windows.Forms.GroupBox grpPhieuNhapKho;
        private System.Windows.Forms.DateTimePicker dateNgayTT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoPhieuTT;
        private System.Windows.Forms.GroupBox boPhanNhapKho;
        private System.Windows.Forms.TextBox txtMaSoBP;
        private System.Windows.Forms.TextBox txtNguoiDaiDien;
        private System.Windows.Forms.TextBox txtMaSoThue;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuDauKy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Label lblDuCuoiKy;
        private System.Windows.Forms.TextBox txtDuCuoiKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThuTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNgayNhanMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaSoMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNoiDungCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThanhTien;
    }
}