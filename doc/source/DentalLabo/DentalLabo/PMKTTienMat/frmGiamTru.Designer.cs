namespace DentalLabo.Nhap_kho_va_ban_hang
{
    partial class frmGiamTru
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
            this.txtKySanXuat = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaSoBP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoPhieuTT = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpPhieuNhapKho = new System.Windows.Forms.GroupBox();
            this.dateNgayTT = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVaoPhieu = new System.Windows.Forms.Button();
            this.btnLuuHeThong = new System.Windows.Forms.Button();
            this.boPhanNhapKho = new System.Windows.Forms.GroupBox();
            this.dtgChiTietCongNoKH = new System.Windows.Forms.DataGridView();
            this.clnXacNhan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNoiDungCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.grpPhieuNhapKho.SuspendLayout();
            this.boPhanNhapKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietCongNoKH)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKySanXuat
            // 
            this.txtKySanXuat.Location = new System.Drawing.Point(98, 85);
            this.txtKySanXuat.Name = "txtKySanXuat";
            this.txtKySanXuat.Size = new System.Drawing.Size(99, 20);
            this.txtKySanXuat.TabIndex = 1;
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
            // txtMaSoBP
            // 
            this.txtMaSoBP.Location = new System.Drawing.Point(327, 30);
            this.txtMaSoBP.Name = "txtMaSoBP";
            this.txtMaSoBP.Size = new System.Drawing.Size(138, 20);
            this.txtMaSoBP.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kỳ sản xuất";
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
            this.label5.Location = new System.Drawing.Point(268, 33);
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
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(43, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(767, 33);
            this.label12.TabIndex = 30;
            this.label12.Text = "GIẢM TRỪ THANH TOÁN TRONG KỲ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtSoPhieuTT
            // 
            this.txtSoPhieuTT.Location = new System.Drawing.Point(88, 62);
            this.txtSoPhieuTT.Name = "txtSoPhieuTT";
            this.txtSoPhieuTT.Size = new System.Drawing.Size(174, 20);
            this.txtSoPhieuTT.TabIndex = 1;
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
            // grpPhieuNhapKho
            // 
            this.grpPhieuNhapKho.Controls.Add(this.btnTimKiem);
            this.grpPhieuNhapKho.Controls.Add(this.dateNgayTT);
            this.grpPhieuNhapKho.Controls.Add(this.label11);
            this.grpPhieuNhapKho.Controls.Add(this.label8);
            this.grpPhieuNhapKho.Controls.Add(this.txtSoPhieuTT);
            this.grpPhieuNhapKho.Location = new System.Drawing.Point(542, 65);
            this.grpPhieuNhapKho.Name = "grpPhieuNhapKho";
            this.grpPhieuNhapKho.Size = new System.Drawing.Size(268, 124);
            this.grpPhieuNhapKho.TabIndex = 27;
            this.grpPhieuNhapKho.TabStop = false;
            this.grpPhieuNhapKho.Text = "Số phiếu thanh toán";
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
            // btnVaoPhieu
            // 
            this.btnVaoPhieu.AutoSize = true;
            this.btnVaoPhieu.Location = new System.Drawing.Point(194, 449);
            this.btnVaoPhieu.Name = "btnVaoPhieu";
            this.btnVaoPhieu.Size = new System.Drawing.Size(136, 23);
            this.btnVaoPhieu.TabIndex = 28;
            this.btnVaoPhieu.Text = "Vào phiếu Thanh toán";
            this.btnVaoPhieu.UseVisualStyleBackColor = true;
            // 
            // btnLuuHeThong
            // 
            this.btnLuuHeThong.AutoSize = true;
            this.btnLuuHeThong.Location = new System.Drawing.Point(379, 449);
            this.btnLuuHeThong.Name = "btnLuuHeThong";
            this.btnLuuHeThong.Size = new System.Drawing.Size(127, 23);
            this.btnLuuHeThong.TabIndex = 29;
            this.btnLuuHeThong.Text = "Lưu hệ thống";
            this.btnLuuHeThong.UseVisualStyleBackColor = true;
            // 
            // boPhanNhapKho
            // 
            this.boPhanNhapKho.Controls.Add(this.txtMaSoBP);
            this.boPhanNhapKho.Controls.Add(this.txtKySanXuat);
            this.boPhanNhapKho.Controls.Add(this.txtDiaChi);
            this.boPhanNhapKho.Controls.Add(this.txtTenKhachHang);
            this.boPhanNhapKho.Controls.Add(this.label3);
            this.boPhanNhapKho.Controls.Add(this.label2);
            this.boPhanNhapKho.Controls.Add(this.label5);
            this.boPhanNhapKho.Controls.Add(this.label1);
            this.boPhanNhapKho.Location = new System.Drawing.Point(41, 65);
            this.boPhanNhapKho.Name = "boPhanNhapKho";
            this.boPhanNhapKho.Size = new System.Drawing.Size(484, 124);
            this.boPhanNhapKho.TabIndex = 26;
            this.boPhanNhapKho.TabStop = false;
            this.boPhanNhapKho.Text = "Khách hàng";
            // 
            // dtgChiTietCongNoKH
            // 
            this.dtgChiTietCongNoKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChiTietCongNoKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnXacNhan,
            this.clnThuTu,
            this.clnMaSo,
            this.clnNoiDungCongViec,
            this.clnDVT,
            this.clnSoLuong,
            this.clnDonGia,
            this.clnThanhTien,
            this.clnGhiChu,
            this.clnTrangThai});
            this.dtgChiTietCongNoKH.Location = new System.Drawing.Point(41, 255);
            this.dtgChiTietCongNoKH.Name = "dtgChiTietCongNoKH";
            this.dtgChiTietCongNoKH.Size = new System.Drawing.Size(769, 164);
            this.dtgChiTietCongNoKH.TabIndex = 31;
            // 
            // clnXacNhan
            // 
            this.clnXacNhan.Frozen = true;
            this.clnXacNhan.HeaderText = "Xác nhận";
            this.clnXacNhan.Name = "clnXacNhan";
            // 
            // clnThuTu
            // 
            this.clnThuTu.Frozen = true;
            this.clnThuTu.HeaderText = "TT";
            this.clnThuTu.Name = "clnThuTu";
            this.clnThuTu.Width = 50;
            // 
            // clnMaSo
            // 
            this.clnMaSo.HeaderText = "Mã số";
            this.clnMaSo.Name = "clnMaSo";
            // 
            // clnNoiDungCongViec
            // 
            this.clnNoiDungCongViec.HeaderText = "Nội dung giảm trừ";
            this.clnNoiDungCongViec.Name = "clnNoiDungCongViec";
            this.clnNoiDungCongViec.Width = 300;
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
            // clnDonGia
            // 
            this.clnDonGia.HeaderText = "Đơn giá";
            this.clnDonGia.Name = "clnDonGia";
            // 
            // clnThanhTien
            // 
            this.clnThanhTien.HeaderText = "Thành tiền";
            this.clnThanhTien.Name = "clnThanhTien";
            // 
            // clnGhiChu
            // 
            this.clnGhiChu.HeaderText = "Ghi chú";
            this.clnGhiChu.Name = "clnGhiChu";
            // 
            // clnTrangThai
            // 
            this.clnTrangThai.HeaderText = "Trạng thái";
            this.clnTrangThai.Name = "clnTrangThai";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(43, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(767, 33);
            this.label4.TabIndex = 30;
            this.label4.Text = "NỘI DUNG GIẢM TRỪ CHI PHÍ ĐẶT HÀNG";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.AutoSize = true;
            this.btnXemBaoCao.Location = new System.Drawing.Point(551, 449);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(136, 23);
            this.btnXemBaoCao.TabIndex = 28;
            this.btnXemBaoCao.Text = "Xem báo cáo tổng hợp";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            // 
            // frmGiamTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 572);
            this.Controls.Add(this.dtgChiTietCongNoKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grpPhieuNhapKho);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.btnVaoPhieu);
            this.Controls.Add(this.btnLuuHeThong);
            this.Controls.Add(this.boPhanNhapKho);
            this.Name = "frmGiamTru";
            this.Text = "Giam Tru Thanh Toan Trong Ky";
            this.grpPhieuNhapKho.ResumeLayout(false);
            this.grpPhieuNhapKho.PerformLayout();
            this.boPhanNhapKho.ResumeLayout(false);
            this.boPhanNhapKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietCongNoKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKySanXuat;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtMaSoBP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSoPhieuTT;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox grpPhieuNhapKho;
        private System.Windows.Forms.DateTimePicker dateNgayTT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVaoPhieu;
        private System.Windows.Forms.Button btnLuuHeThong;
        private System.Windows.Forms.GroupBox boPhanNhapKho;
        private System.Windows.Forms.DataGridView dtgChiTietCongNoKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnXacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThuTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNoiDungCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTrangThai;
        private System.Windows.Forms.Button btnXemBaoCao;
    }
}