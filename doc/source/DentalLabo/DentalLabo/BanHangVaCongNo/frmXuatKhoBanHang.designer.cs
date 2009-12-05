namespace DentalLabo.Nhap_kho_va_ban_hang
{
    partial class frmXuatKhoBanHang
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
            this.dtgNoiDungXuatKho = new System.Windows.Forms.DataGridView();
            this.clnXacNhan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMaSoMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNoiDungPhucHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLoaiVatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnVLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDVTVLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSoLuongVLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnThanhTienVLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpPhieuNhapKho = new System.Windows.Forms.GroupBox();
            this.dateNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
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
            this.label13 = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNoiDungXuatKho)).BeginInit();
            this.grpPhieuNhapKho.SuspendLayout();
            this.boPhanNhapKho.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(31, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(725, 33);
            this.label12.TabIndex = 9;
            this.label12.Text = "HÓA ĐƠN BÁN HÀNG KIÊM PHIẾU XUẤT KHO";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgNoiDungXuatKho
            // 
            this.dtgNoiDungXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNoiDungXuatKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnXacNhan,
            this.clnThuTu,
            this.clnMaSoMau,
            this.clnNoiDungPhucHinh,
            this.clnTenSanPham,
            this.clnLoaiVatLieu,
            this.clnDVT,
            this.clnSoLuong,
            this.clnThanhTien,
            this.clnVLP,
            this.clnDVTVLP,
            this.clnSoLuongVLP,
            this.clnThanhTienVLP});
            this.dtgNoiDungXuatKho.Location = new System.Drawing.Point(29, 307);
            this.dtgNoiDungXuatKho.Name = "dtgNoiDungXuatKho";
            this.dtgNoiDungXuatKho.Size = new System.Drawing.Size(727, 150);
            this.dtgNoiDungXuatKho.TabIndex = 8;
            // 
            // clnXacNhan
            // 
            this.clnXacNhan.HeaderText = "Xác nhận";
            this.clnXacNhan.Name = "clnXacNhan";
            this.clnXacNhan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnXacNhan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clnThuTu
            // 
            this.clnThuTu.HeaderText = "TT";
            this.clnThuTu.Name = "clnThuTu";
            // 
            // clnMaSoMau
            // 
            this.clnMaSoMau.HeaderText = "Mã số mẫu";
            this.clnMaSoMau.Name = "clnMaSoMau";
            // 
            // clnNoiDungPhucHinh
            // 
            this.clnNoiDungPhucHinh.HeaderText = "Nội dung phục hình";
            this.clnNoiDungPhucHinh.Name = "clnNoiDungPhucHinh";
            // 
            // clnTenSanPham
            // 
            this.clnTenSanPham.HeaderText = "Tên sản phẩm";
            this.clnTenSanPham.Name = "clnTenSanPham";
            // 
            // clnLoaiVatLieu
            // 
            this.clnLoaiVatLieu.HeaderText = "Loại vật liệu";
            this.clnLoaiVatLieu.Name = "clnLoaiVatLieu";
            // 
            // clnDVT
            // 
            this.clnDVT.HeaderText = "ĐVT";
            this.clnDVT.Name = "clnDVT";
            // 
            // clnSoLuong
            // 
            this.clnSoLuong.HeaderText = "Số Lượng";
            this.clnSoLuong.Name = "clnSoLuong";
            // 
            // clnThanhTien
            // 
            this.clnThanhTien.HeaderText = "Thành tiền";
            this.clnThanhTien.Name = "clnThanhTien";
            // 
            // clnVLP
            // 
            this.clnVLP.HeaderText = "Vật liệu phụ";
            this.clnVLP.Name = "clnVLP";
            // 
            // clnDVTVLP
            // 
            this.clnDVTVLP.HeaderText = "ĐVT";
            this.clnDVTVLP.Name = "clnDVTVLP";
            // 
            // clnSoLuongVLP
            // 
            this.clnSoLuongVLP.HeaderText = "Số Lượng";
            this.clnSoLuongVLP.Name = "clnSoLuongVLP";
            // 
            // clnThanhTienVLP
            // 
            this.clnThanhTienVLP.HeaderText = "Thành tiền";
            this.clnThanhTienVLP.Name = "clnThanhTienVLP";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(356, 223);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // grpPhieuNhapKho
            // 
            this.grpPhieuNhapKho.Controls.Add(this.dateNgayXuat);
            this.grpPhieuNhapKho.Controls.Add(this.label9);
            this.grpPhieuNhapKho.Controls.Add(this.txtMaNhanVien);
            this.grpPhieuNhapKho.Controls.Add(this.label11);
            this.grpPhieuNhapKho.Controls.Add(this.label8);
            this.grpPhieuNhapKho.Controls.Add(this.txtSoPhieu);
            this.grpPhieuNhapKho.Location = new System.Drawing.Point(530, 77);
            this.grpPhieuNhapKho.Name = "grpPhieuNhapKho";
            this.grpPhieuNhapKho.Size = new System.Drawing.Size(226, 124);
            this.grpPhieuNhapKho.TabIndex = 6;
            this.grpPhieuNhapKho.TabStop = false;
            this.grpPhieuNhapKho.Text = "Số HĐ xuất kho";
            // 
            // dateNgayXuat
            // 
            this.dateNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayXuat.Location = new System.Drawing.Point(88, 33);
            this.dateNgayXuat.Name = "dateNgayXuat";
            this.dateNgayXuat.Size = new System.Drawing.Size(132, 20);
            this.dateNgayXuat.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã nhân viên";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(88, 93);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(132, 20);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ngày xuất";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số phiếu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(88, 62);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(132, 20);
            this.txtSoPhieu.TabIndex = 1;
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
            this.boPhanNhapKho.Location = new System.Drawing.Point(29, 77);
            this.boPhanNhapKho.Name = "boPhanNhapKho";
            this.boPhanNhapKho.Size = new System.Drawing.Size(484, 124);
            this.boPhanNhapKho.TabIndex = 5;
            this.boPhanNhapKho.TabStop = false;
            this.boPhanNhapKho.Text = "Khách hàng";
            // 
            // txtMaSoBP
            // 
            this.txtMaSoBP.Location = new System.Drawing.Point(327, 30);
            this.txtMaSoBP.Name = "txtMaSoBP";
            this.txtMaSoBP.Size = new System.Drawing.Size(138, 20);
            this.txtMaSoBP.TabIndex = 1;
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
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(31, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(725, 33);
            this.label13.TabIndex = 9;
            this.label13.Text = "NỘI DUNG XUẤT KHO BÁN HÀNG";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.AutoSize = true;
            this.btnThemMoi.Location = new System.Drawing.Point(137, 493);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(136, 23);
            this.btnThemMoi.TabIndex = 7;
            this.btnThemMoi.Text = "Thêm mới phiếu xuất kho";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.AutoSize = true;
            this.btnXuat.Location = new System.Drawing.Point(326, 493);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(92, 23);
            this.btnXuat.TabIndex = 7;
            this.btnXuat.Text = "Xuất kho và lưu";
            this.btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnXem
            // 
            this.btnXem.AutoSize = true;
            this.btnXem.Location = new System.Drawing.Point(469, 493);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(139, 23);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "Xem phiếu xuất - hóa đơn";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // frmXuatKhoBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 547);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtgNoiDungXuatKho);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grpPhieuNhapKho);
            this.Controls.Add(this.boPhanNhapKho);
            this.Name = "frmXuatKhoBanHang";
            this.Text = "Hoa don ban hang kiem Phiêu xuat kho";
            this.Load += new System.EventHandler(this.frmXuatKhoBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNoiDungXuatKho)).EndInit();
            this.grpPhieuNhapKho.ResumeLayout(false);
            this.grpPhieuNhapKho.PerformLayout();
            this.boPhanNhapKho.ResumeLayout(false);
            this.boPhanNhapKho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dtgNoiDungXuatKho;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox grpPhieuNhapKho;
        private System.Windows.Forms.DateTimePicker dateNgayXuat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoPhieu;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnXacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThuTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaSoMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNoiDungPhucHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLoaiVatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnVLP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDVTVLP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSoLuongVLP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThanhTienVLP;
    }
}