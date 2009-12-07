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
            this.dtgDanhMucNhaCC = new System.Windows.Forms.DataGridView();
            this.clnMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMSThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNguoiDaiDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnXacNhan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucNhaCC)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(17, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(723, 33);
            this.label12.TabIndex = 35;
            this.label12.Text = "DANH MỤC NHÀ CUNG CẤP";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgDanhMucNhaCC
            // 
            this.dtgDanhMucNhaCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDanhMucNhaCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDanhMucNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhMucNhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMaNCC,
            this.clnTenNCC,
            this.clnMSThue,
            this.clnNguoiDaiDien,
            this.clnDiaChi,
            this.clnDienThoai,
            this.clnXacNhan});
            this.dtgDanhMucNhaCC.Location = new System.Drawing.Point(17, 81);
            this.dtgDanhMucNhaCC.Name = "dtgDanhMucNhaCC";
            this.dtgDanhMucNhaCC.Size = new System.Drawing.Size(723, 375);
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
            // 
            // clnDiaChi
            // 
            this.clnDiaChi.HeaderText = "Địa chỉ";
            this.clnDiaChi.Name = "clnDiaChi";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnThem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSua, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnXoa, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 469);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 35);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(218, 3);
            this.btnThem.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(442, 3);
            this.btnLuu.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(63, 30);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(304, 3);
            this.btnSua.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 30);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(373, 3);
            this.btnXoa.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 30);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // frmDanhMucNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 516);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtgDanhMucNhaCC);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmDanhMucNhaCC";
            this.Text = "Danh Muc Nha Cung Cap";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucNhaCC)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dtgDanhMucNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMSThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNguoiDaiDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDienThoai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnXacNhan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}