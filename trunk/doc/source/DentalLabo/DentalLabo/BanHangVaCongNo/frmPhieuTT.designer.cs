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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dateNgayTT = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoPhieuTT = new System.Windows.Forms.TextBox();
            this.boPhanNhapKho = new System.Windows.Forms.GroupBox();
            this.dateTimeNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateTimeNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.txtMaSoBP = new System.Windows.Forms.TextBox();
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
            this.lblDuCuoiKy = new System.Windows.Forms.Label();
            this.txtDuCuoiKy = new System.Windows.Forms.TextBox();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietCongNoKH)).BeginInit();
            this.grpPhieuNhapKho.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.boPhanNhapKho.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(725, 33);
            this.label12.TabIndex = 24;
            this.label12.Text = "BẢNG TỔNG HỢP CÔNG NỢ KHÁCH MUA HÀNG TRONG KỲ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgChiTietCongNoKH
            // 
            this.dtgChiTietCongNoKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgChiTietCongNoKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnThuTu,
            this.clnNgayNhanMau,
            this.clnNgay,
            this.clnSoHD,
            this.clnMaSoMau,
            this.clnNoiDungCongViec,
            this.clnThanhTien});
            this.dtgChiTietCongNoKH.Location = new System.Drawing.Point(6, 42);
            this.dtgChiTietCongNoKH.Name = "dtgChiTietCongNoKH";
            this.dtgChiTietCongNoKH.Size = new System.Drawing.Size(705, 164);
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
            this.grpPhieuNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPhieuNhapKho.Controls.Add(this.tableLayoutPanel2);
            this.grpPhieuNhapKho.Controls.Add(this.dateNgayTT);
            this.grpPhieuNhapKho.Controls.Add(this.label11);
            this.grpPhieuNhapKho.Controls.Add(this.label8);
            this.grpPhieuNhapKho.Controls.Add(this.txtSoPhieuTT);
            this.grpPhieuNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPhieuNhapKho.Location = new System.Drawing.Point(505, 3);
            this.grpPhieuNhapKho.Name = "grpPhieuNhapKho";
            this.grpPhieuNhapKho.Size = new System.Drawing.Size(217, 136);
            this.grpPhieuNhapKho.TabIndex = 20;
            this.grpPhieuNhapKho.TabStop = false;
            this.grpPhieuNhapKho.Text = "Số phiếu thanh toán";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnTimKiem, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 88);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 36);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(54, 3);
            this.btnTimKiem.MaximumSize = new System.Drawing.Size(91, 30);
            this.btnTimKiem.MinimumSize = new System.Drawing.Size(91, 30);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(91, 30);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dateNgayTT
            // 
            this.dateNgayTT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateNgayTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayTT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTT.Location = new System.Drawing.Point(94, 24);
            this.dateNgayTT.Name = "dateNgayTT";
            this.dateNgayTT.Size = new System.Drawing.Size(115, 23);
            this.dateNgayTT.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ngày TT";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số phiếu TT";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoPhieuTT
            // 
            this.txtSoPhieuTT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoPhieuTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhieuTT.Location = new System.Drawing.Point(94, 56);
            this.txtSoPhieuTT.Name = "txtSoPhieuTT";
            this.txtSoPhieuTT.Size = new System.Drawing.Size(115, 23);
            this.txtSoPhieuTT.TabIndex = 1;
            // 
            // boPhanNhapKho
            // 
            this.boPhanNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.boPhanNhapKho.Controls.Add(this.dateTimeNgayKetThuc);
            this.boPhanNhapKho.Controls.Add(this.dateTimeNgayBatDau);
            this.boPhanNhapKho.Controls.Add(this.txtMaSoBP);
            this.boPhanNhapKho.Controls.Add(this.txtDiaChi);
            this.boPhanNhapKho.Controls.Add(this.txtTenKhachHang);
            this.boPhanNhapKho.Controls.Add(this.label7);
            this.boPhanNhapKho.Controls.Add(this.label3);
            this.boPhanNhapKho.Controls.Add(this.label2);
            this.boPhanNhapKho.Controls.Add(this.label5);
            this.boPhanNhapKho.Controls.Add(this.label1);
            this.boPhanNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boPhanNhapKho.Location = new System.Drawing.Point(3, 3);
            this.boPhanNhapKho.Name = "boPhanNhapKho";
            this.boPhanNhapKho.Size = new System.Drawing.Size(496, 136);
            this.boPhanNhapKho.TabIndex = 19;
            this.boPhanNhapKho.TabStop = false;
            this.boPhanNhapKho.Text = "Khách hàng";
            // 
            // dateTimeNgayKetThuc
            // 
            this.dateTimeNgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayKetThuc.Location = new System.Drawing.Point(345, 98);
            this.dateTimeNgayKetThuc.Name = "dateTimeNgayKetThuc";
            this.dateTimeNgayKetThuc.Size = new System.Drawing.Size(142, 23);
            this.dateTimeNgayKetThuc.TabIndex = 4;
            // 
            // dateTimeNgayBatDau
            // 
            this.dateTimeNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayBatDau.Location = new System.Drawing.Point(71, 101);
            this.dateTimeNgayBatDau.Name = "dateTimeNgayBatDau";
            this.dateTimeNgayBatDau.Size = new System.Drawing.Size(124, 23);
            this.dateTimeNgayBatDau.TabIndex = 3;
            // 
            // txtMaSoBP
            // 
            this.txtMaSoBP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaSoBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSoBP.Location = new System.Drawing.Point(345, 24);
            this.txtMaSoBP.Name = "txtMaSoBP";
            this.txtMaSoBP.Size = new System.Drawing.Size(142, 23);
            this.txtMaSoBP.TabIndex = 1;
            this.txtMaSoBP.TextChanged += new System.EventHandler(this.txtMaSoBP_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(71, 62);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(416, 23);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(71, 24);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(188, 23);
            this.txtTenKhachHang.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đến ngày";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Từ ngày";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa chỉ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã KH";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên KH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(444, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dư đầu kỳ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDuDauKy
            // 
            this.txtDuDauKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuDauKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuDauKy.Location = new System.Drawing.Point(524, 13);
            this.txtDuDauKy.Name = "txtDuDauKy";
            this.txtDuDauKy.Size = new System.Drawing.Size(168, 23);
            this.txtDuDauKy.TabIndex = 1;
            this.txtDuDauKy.TextChanged += new System.EventHandler(this.txtMaSoBP_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtgChiTietCongNoKH);
            this.groupBox1.Controls.Add(this.lblDuCuoiKy);
            this.groupBox1.Controls.Add(this.txtDuCuoiKy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDuDauKy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 252);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sổ chi tiết công nợ";
            // 
            // lblDuCuoiKy
            // 
            this.lblDuCuoiKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuCuoiKy.AutoSize = true;
            this.lblDuCuoiKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuCuoiKy.Location = new System.Drawing.Point(442, 219);
            this.lblDuCuoiKy.Name = "lblDuCuoiKy";
            this.lblDuCuoiKy.Size = new System.Drawing.Size(74, 17);
            this.lblDuCuoiKy.TabIndex = 0;
            this.lblDuCuoiKy.Text = "Dư cuối kỳ";
            this.lblDuCuoiKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDuCuoiKy.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDuCuoiKy
            // 
            this.txtDuCuoiKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuCuoiKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuCuoiKy.Location = new System.Drawing.Point(524, 216);
            this.txtDuCuoiKy.Name = "txtDuCuoiKy";
            this.txtDuCuoiKy.Size = new System.Drawing.Size(168, 23);
            this.txtDuCuoiKy.TabIndex = 1;
            this.txtDuCuoiKy.TextChanged += new System.EventHandler(this.txtMaSoBP_TextChanged);
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.AutoSize = true;
            this.btnXemBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBaoCao.Location = new System.Drawing.Point(382, 3);
            this.btnXemBaoCao.MaximumSize = new System.Drawing.Size(161, 30);
            this.btnXemBaoCao.MinimumSize = new System.Drawing.Size(161, 30);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(161, 30);
            this.btnXemBaoCao.TabIndex = 3;
            this.btnXemBaoCao.Text = "Xem báo cáo tổng hợp";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.AutoSize = true;
            this.btnInPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieu.Location = new System.Drawing.Point(176, 3);
            this.btnInPhieu.MaximumSize = new System.Drawing.Size(200, 30);
            this.btnInPhieu.MinimumSize = new System.Drawing.Size(200, 30);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(200, 30);
            this.btnInPhieu.TabIndex = 3;
            this.btnInPhieu.Text = "In phiếu tổng hợp thanh toán";
            this.btnInPhieu.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.30556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.69444F));
            this.tableLayoutPanel1.Controls.Add(this.boPhanNhapKho, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpPhieuNhapKho, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 151);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnXemBaoCao, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnInPhieu, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(17, 472);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(720, 33);
            this.tableLayoutPanel3.TabIndex = 28;
            // 
            // frmPhieuTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 516);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Name = "frmPhieuTT";
            this.Text = "Bang tong hop cong no khach mua hang";
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietCongNoKH)).EndInit();
            this.grpPhieuNhapKho.ResumeLayout(false);
            this.grpPhieuNhapKho.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.boPhanNhapKho.ResumeLayout(false);
            this.boPhanNhapKho.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DateTimePicker dateTimeNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dateTimeNgayBatDau;
    }
}