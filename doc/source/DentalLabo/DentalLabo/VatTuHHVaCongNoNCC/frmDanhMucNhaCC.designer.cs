namespace DentalLabo.Vat_tu_hang_hoa_va_Cong_no_NCC
{
    partial class frmDanhMucNhaCC
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtgDanhMucNhaCC = new System.Windows.Forms.DataGridView();
            this.clnMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMSThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNguoiDaiDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnXacNhan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucNhaCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(22, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(736, 33);
            this.label12.TabIndex = 35;
            this.label12.Text = "DANH MỤC NHÀ CUNG CẤP";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(295, 301);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 23);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(209, 301);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(63, 23);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(387, 301);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 23);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dtgDanhMucNhaCC
            // 
            this.dtgDanhMucNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhMucNhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMaNCC,
            this.clnTenNCC,
            this.clnMSThue,
            this.clnNguoiDaiDien,
            this.clnDiaChi,
            this.clnDienThoai,
            this.clnXacNhan});
            this.dtgDanhMucNhaCC.Location = new System.Drawing.Point(22, 91);
            this.dtgDanhMucNhaCC.Name = "dtgDanhMucNhaCC";
            this.dtgDanhMucNhaCC.Size = new System.Drawing.Size(736, 164);
            this.dtgDanhMucNhaCC.TabIndex = 34;
            // 
            // clnMaNCC
            // 
            this.clnMaNCC.HeaderText = "Mã NCC";
            this.clnMaNCC.Name = "clnMaNCC";
            // 
            // clnTenNCC
            // 
            this.clnTenNCC.HeaderText = "Tên NCC";
            this.clnTenNCC.Name = "clnTenNCC";
            // 
            // clnMSThue
            // 
            this.clnMSThue.HeaderText = "Mã số thuế";
            this.clnMSThue.Name = "clnMSThue";
            // 
            // clnNguoiDaiDien
            // 
            this.clnNguoiDaiDien.HeaderText = "Người đại diện";
            this.clnNguoiDaiDien.Name = "clnNguoiDaiDien";
            this.clnNguoiDaiDien.Width = 150;
            // 
            // clnDiaChi
            // 
            this.clnDiaChi.HeaderText = "Địa chỉ";
            this.clnDiaChi.Name = "clnDiaChi";
            this.clnDiaChi.Width = 200;
            // 
            // clnDienThoai
            // 
            this.clnDienThoai.HeaderText = "Điện thoại";
            this.clnDienThoai.Name = "clnDienThoai";
            // 
            // clnXacNhan
            // 
            this.clnXacNhan.HeaderText = "Xác nhận";
            this.clnXacNhan.Name = "clnXacNhan";
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.Location = new System.Drawing.Point(479, 301);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(63, 23);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // frmDanhMucNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 339);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dtgDanhMucNhaCC);
            this.Controls.Add(this.btnLuu);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmDanhMucNhaCC";
            this.Text = "Danh muc nha cung cap";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucNhaCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dtgDanhMucNhaCC;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMSThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNguoiDaiDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDienThoai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnXacNhan;
    }
}