namespace DentalLabo.Nhap_kho_va_ban_hang
{
    partial class frmHoaDonBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.label12 = new System.Windows.Forms.Label();
            this.dtgHoaDonBanHang = new System.Windows.Forms.DataGridView();
            this.clnThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMaSoMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNgayNhanMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNoiDungCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauHang_Hay_GiamTru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInPhieuXuat = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.grpPhieuNhapKho = new System.Windows.Forms.GroupBox();
            this.dateNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.boPhanNhapKho = new System.Windows.Forms.GroupBox();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.cmbTenKH = new System.Windows.Forms.ComboBox();
            this.txtNguoiDaiDien = new System.Windows.Forms.TextBox();
            this.txtMaSoThue = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoTienTT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDonBanHang)).BeginInit();
            this.grpPhieuNhapKho.SuspendLayout();
            this.boPhanNhapKho.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.label12.TabIndex = 18;
            this.label12.Text = "HÓA ĐƠN BÁN HÀNG KIÊM PHIẾU XUẤT KHO";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgHoaDonBanHang
            // 
            this.dtgHoaDonBanHang.AllowUserToAddRows = false;
            this.dtgHoaDonBanHang.AllowUserToDeleteRows = false;
            this.dtgHoaDonBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgHoaDonBanHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHoaDonBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHoaDonBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnThuTu,
            this.clnMaSoMau,
            this.clnNgayNhanMau,
            this.clnNoiDungCongViec,
            this.clnThanhTien,
            this.MauHang_Hay_GiamTru});
            this.dtgHoaDonBanHang.Location = new System.Drawing.Point(17, 247);
            this.dtgHoaDonBanHang.Name = "dtgHoaDonBanHang";
            this.dtgHoaDonBanHang.ReadOnly = true;
            this.dtgHoaDonBanHang.Size = new System.Drawing.Size(720, 219);
            this.dtgHoaDonBanHang.TabIndex = 16;
            // 
            // clnThuTu
            // 
            this.clnThuTu.HeaderText = "TT";
            this.clnThuTu.Name = "clnThuTu";
            this.clnThuTu.ReadOnly = true;
            this.clnThuTu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnMaSoMau
            // 
            this.clnMaSoMau.HeaderText = "Mã số mẫu";
            this.clnMaSoMau.Name = "clnMaSoMau";
            this.clnMaSoMau.ReadOnly = true;
            this.clnMaSoMau.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnNgayNhanMau
            // 
            this.clnNgayNhanMau.HeaderText = "Ngày nhận mẫu";
            this.clnNgayNhanMau.Name = "clnNgayNhanMau";
            this.clnNgayNhanMau.ReadOnly = true;
            this.clnNgayNhanMau.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnNoiDungCongViec
            // 
            this.clnNoiDungCongViec.HeaderText = "Nội dung công việc";
            this.clnNoiDungCongViec.Name = "clnNoiDungCongViec";
            this.clnNoiDungCongViec.ReadOnly = true;
            this.clnNoiDungCongViec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnThanhTien
            // 
            this.clnThanhTien.HeaderText = "Thành tiền";
            this.clnThanhTien.Name = "clnThanhTien";
            this.clnThanhTien.ReadOnly = true;
            this.clnThanhTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MauHang_Hay_GiamTru
            // 
            this.MauHang_Hay_GiamTru.HeaderText = "Loai";
            this.MauHang_Hay_GiamTru.Name = "MauHang_Hay_GiamTru";
            this.MauHang_Hay_GiamTru.ReadOnly = true;
            this.MauHang_Hay_GiamTru.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MauHang_Hay_GiamTru.Visible = false;
            // 
            // btnInPhieuXuat
            // 
            this.btnInPhieuXuat.AutoSize = true;
            this.btnInPhieuXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieuXuat.Location = new System.Drawing.Point(292, 3);
            this.btnInPhieuXuat.MaximumSize = new System.Drawing.Size(163, 30);
            this.btnInPhieuXuat.MinimumSize = new System.Drawing.Size(163, 30);
            this.btnInPhieuXuat.Name = "btnInPhieuXuat";
            this.btnInPhieuXuat.Size = new System.Drawing.Size(163, 30);
            this.btnInPhieuXuat.TabIndex = 14;
            this.btnInPhieuXuat.Text = "In phiếu xuất - hóa đơn";
            this.btnInPhieuXuat.UseVisualStyleBackColor = true;
            this.btnInPhieuXuat.Click += new System.EventHandler(this.btnInPhieuXuat_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoSize = true;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(141, 3);
            this.btnThanhToan.MaximumSize = new System.Drawing.Size(145, 30);
            this.btnThanhToan.MinimumSize = new System.Drawing.Size(145, 30);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(145, 30);
            this.btnThanhToan.TabIndex = 12;
            this.btnThanhToan.Text = "Thanh toán tiền mặt";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // grpPhieuNhapKho
            // 
            this.grpPhieuNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPhieuNhapKho.Controls.Add(this.dateNgayXuat);
            this.grpPhieuNhapKho.Controls.Add(this.label9);
            this.grpPhieuNhapKho.Controls.Add(this.txtMaNhanVien);
            this.grpPhieuNhapKho.Controls.Add(this.label11);
            this.grpPhieuNhapKho.Controls.Add(this.label8);
            this.grpPhieuNhapKho.Controls.Add(this.txtSoPhieu);
            this.grpPhieuNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPhieuNhapKho.Location = new System.Drawing.Point(501, 3);
            this.grpPhieuNhapKho.Name = "grpPhieuNhapKho";
            this.grpPhieuNhapKho.Size = new System.Drawing.Size(215, 134);
            this.grpPhieuNhapKho.TabIndex = 11;
            this.grpPhieuNhapKho.TabStop = false;
            this.grpPhieuNhapKho.Text = "Số HĐ xuất kho";
            // 
            // dateNgayXuat
            // 
            this.dateNgayXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayXuat.Location = new System.Drawing.Point(76, 27);
            this.dateNgayXuat.Name = "dateNgayXuat";
            this.dateNgayXuat.Size = new System.Drawing.Size(131, 23);
            this.dateNgayXuat.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã NV";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(76, 96);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(131, 23);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ngày xuất";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số phiếu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoPhieu.Location = new System.Drawing.Point(76, 62);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(131, 23);
            this.txtSoPhieu.TabIndex = 1;
            // 
            // boPhanNhapKho
            // 
            this.boPhanNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.boPhanNhapKho.Controls.Add(this.cmbMaKH);
            this.boPhanNhapKho.Controls.Add(this.cmbTenKH);
            this.boPhanNhapKho.Controls.Add(this.txtNguoiDaiDien);
            this.boPhanNhapKho.Controls.Add(this.txtMaSoThue);
            this.boPhanNhapKho.Controls.Add(this.txtDiaChi);
            this.boPhanNhapKho.Controls.Add(this.label7);
            this.boPhanNhapKho.Controls.Add(this.label3);
            this.boPhanNhapKho.Controls.Add(this.label2);
            this.boPhanNhapKho.Controls.Add(this.label5);
            this.boPhanNhapKho.Controls.Add(this.label1);
            this.boPhanNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boPhanNhapKho.Location = new System.Drawing.Point(3, 3);
            this.boPhanNhapKho.Name = "boPhanNhapKho";
            this.boPhanNhapKho.Size = new System.Drawing.Size(492, 134);
            this.boPhanNhapKho.TabIndex = 10;
            this.boPhanNhapKho.TabStop = false;
            this.boPhanNhapKho.Text = "Khách hàng";
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(380, 27);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(106, 24);
            this.cmbMaKH.TabIndex = 3;
            this.cmbMaKH.SelectedIndexChanged += new System.EventHandler(this.cmbMaKH_SelectedIndexChanged);
            // 
            // cmbTenKH
            // 
            this.cmbTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTenKH.FormattingEnabled = true;
            this.cmbTenKH.Location = new System.Drawing.Point(98, 27);
            this.cmbTenKH.Name = "cmbTenKH";
            this.cmbTenKH.Size = new System.Drawing.Size(205, 24);
            this.cmbTenKH.TabIndex = 2;
            this.cmbTenKH.SelectedIndexChanged += new System.EventHandler(this.cmbTenKH_SelectedIndexChanged);
            // 
            // txtNguoiDaiDien
            // 
            this.txtNguoiDaiDien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNguoiDaiDien.Location = new System.Drawing.Point(305, 93);
            this.txtNguoiDaiDien.Name = "txtNguoiDaiDien";
            this.txtNguoiDaiDien.Size = new System.Drawing.Size(181, 23);
            this.txtNguoiDaiDien.TabIndex = 1;
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.Location = new System.Drawing.Point(99, 93);
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.Size = new System.Drawing.Size(99, 23);
            this.txtMaSoThue.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Location = new System.Drawing.Point(98, 59);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(388, 23);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Người đại diện";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã số thuế";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
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
            this.label5.Location = new System.Drawing.Point(324, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã KH";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên KH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.26286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.73713F));
            this.tableLayoutPanel1.Controls.Add(this.boPhanNhapKho, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpPhieuNhapKho, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 147);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnInPhieuXuat, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThanhToan, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 472);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(719, 36);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(461, 3);
            this.button1.MaximumSize = new System.Drawing.Size(117, 30);
            this.button1.MinimumSize = new System.Drawing.Size(117, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thêm Giảm Trừ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoTienTT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(17, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 41);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // txtSoTienTT
            // 
            this.txtSoTienTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienTT.Location = new System.Drawing.Point(147, 13);
            this.txtSoTienTT.Name = "txtSoTienTT";
            this.txtSoTienTT.Size = new System.Drawing.Size(230, 22);
            this.txtSoTienTT.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Tiền Thanh toán";
            // 
            // frmHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtgHoaDonBanHang);
            this.Name = "frmHoaDonBanHang";
            this.Text = "Hoa Don Ban Hang";
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDonBanHang)).EndInit();
            this.grpPhieuNhapKho.ResumeLayout(false);
            this.grpPhieuNhapKho.PerformLayout();
            this.boPhanNhapKho.ResumeLayout(false);
            this.boPhanNhapKho.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.DataGridView dtgHoaDonBanHang;
        public System.Windows.Forms.Button btnInPhieuXuat;
        public System.Windows.Forms.Button btnThanhToan;
        public System.Windows.Forms.GroupBox grpPhieuNhapKho;
        public System.Windows.Forms.DateTimePicker dateNgayXuat;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtMaNhanVien;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtSoPhieu;
        public System.Windows.Forms.GroupBox boPhanNhapKho;
        public System.Windows.Forms.TextBox txtNguoiDaiDien;
        public System.Windows.Forms.TextBox txtMaSoThue;
        public System.Windows.Forms.TextBox txtDiaChi;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.ComboBox cmbTenKH;
        public System.Windows.Forms.ComboBox cmbMaKH;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridViewTextBoxColumn clnThuTu;
        public System.Windows.Forms.DataGridViewTextBoxColumn clnMaSoMau;
        public System.Windows.Forms.DataGridViewTextBoxColumn clnNgayNhanMau;
        public System.Windows.Forms.DataGridViewTextBoxColumn clnNoiDungCongViec;
        public System.Windows.Forms.DataGridViewTextBoxColumn clnThanhTien;
        public System.Windows.Forms.DataGridViewTextBoxColumn MauHang_Hay_GiamTru;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSoTienTT;
    }
}