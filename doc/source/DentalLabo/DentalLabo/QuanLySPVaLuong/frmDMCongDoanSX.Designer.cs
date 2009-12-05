namespace DentalLabo.Quan_ly_san_pham_va_tinh_luong
{
    partial class frmDMCongDoanSX
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDanhMucCongDoanSX = new System.Windows.Forms.Label();
            this.dtgDanhMucCongDoanSX = new System.Windows.Forms.DataGridView();
            this.btnDanhMucCongDoanSXLuu = new System.Windows.Forms.Button();
            this.btnDanhMucCongDoanSXXoa = new System.Windows.Forms.Button();
            this.btnDanhMucCongDoanSXSua = new System.Windows.Forms.Button();
            this.btnDanhMucCongDoanSXThemMoi = new System.Windows.Forms.Button();
            this.dmcdsxTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmcsxMaCongDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmcdsxTenCongDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmcdsxXacNhan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucCongDoanSX)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDanhMucCongDoanSX
            // 
            this.lblDanhMucCongDoanSX.AutoSize = true;
            this.lblDanhMucCongDoanSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMucCongDoanSX.ForeColor = System.Drawing.Color.Blue;
            this.lblDanhMucCongDoanSX.Location = new System.Drawing.Point(222, 35);
            this.lblDanhMucCongDoanSX.Name = "lblDanhMucCongDoanSX";
            this.lblDanhMucCongDoanSX.Size = new System.Drawing.Size(370, 25);
            this.lblDanhMucCongDoanSX.TabIndex = 7;
            this.lblDanhMucCongDoanSX.Text = "DANH MỤC CÔNG ĐOẠN SẢN XUẤT";
            // 
            // dtgDanhMucCongDoanSX
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgDanhMucCongDoanSX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDanhMucCongDoanSX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDanhMucCongDoanSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhMucCongDoanSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dmcdsxTT,
            this.dmcsxMaCongDoan,
            this.dmcdsxTenCongDoan,
            this.dmcdsxXacNhan});
            this.dtgDanhMucCongDoanSX.Location = new System.Drawing.Point(71, 94);
            this.dtgDanhMucCongDoanSX.Name = "dtgDanhMucCongDoanSX";
            this.dtgDanhMucCongDoanSX.Size = new System.Drawing.Size(642, 294);
            this.dtgDanhMucCongDoanSX.TabIndex = 8;
            // 
            // btnDanhMucCongDoanSXLuu
            // 
            this.btnDanhMucCongDoanSXLuu.Location = new System.Drawing.Point(565, 414);
            this.btnDanhMucCongDoanSXLuu.Name = "btnDanhMucCongDoanSXLuu";
            this.btnDanhMucCongDoanSXLuu.Size = new System.Drawing.Size(75, 23);
            this.btnDanhMucCongDoanSXLuu.TabIndex = 15;
            this.btnDanhMucCongDoanSXLuu.Text = "Lưu";
            this.btnDanhMucCongDoanSXLuu.UseVisualStyleBackColor = true;
            // 
            // btnDanhMucCongDoanSXXoa
            // 
            this.btnDanhMucCongDoanSXXoa.Location = new System.Drawing.Point(420, 414);
            this.btnDanhMucCongDoanSXXoa.Name = "btnDanhMucCongDoanSXXoa";
            this.btnDanhMucCongDoanSXXoa.Size = new System.Drawing.Size(75, 23);
            this.btnDanhMucCongDoanSXXoa.TabIndex = 14;
            this.btnDanhMucCongDoanSXXoa.Text = "Xóa";
            this.btnDanhMucCongDoanSXXoa.UseVisualStyleBackColor = true;
            // 
            // btnDanhMucCongDoanSXSua
            // 
            this.btnDanhMucCongDoanSXSua.Location = new System.Drawing.Point(278, 414);
            this.btnDanhMucCongDoanSXSua.Name = "btnDanhMucCongDoanSXSua";
            this.btnDanhMucCongDoanSXSua.Size = new System.Drawing.Size(75, 23);
            this.btnDanhMucCongDoanSXSua.TabIndex = 13;
            this.btnDanhMucCongDoanSXSua.Text = "Sửa";
            this.btnDanhMucCongDoanSXSua.UseVisualStyleBackColor = true;
            // 
            // btnDanhMucCongDoanSXThemMoi
            // 
            this.btnDanhMucCongDoanSXThemMoi.Location = new System.Drawing.Point(130, 414);
            this.btnDanhMucCongDoanSXThemMoi.Name = "btnDanhMucCongDoanSXThemMoi";
            this.btnDanhMucCongDoanSXThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnDanhMucCongDoanSXThemMoi.TabIndex = 12;
            this.btnDanhMucCongDoanSXThemMoi.Text = "Thêm mới";
            this.btnDanhMucCongDoanSXThemMoi.UseVisualStyleBackColor = true;
            // 
            // dmcdsxTT
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dmcdsxTT.DefaultCellStyle = dataGridViewCellStyle3;
            this.dmcdsxTT.HeaderText = "TT";
            this.dmcdsxTT.Name = "dmcdsxTT";
            this.dmcdsxTT.Width = 50;
            // 
            // dmcsxMaCongDoan
            // 
            this.dmcsxMaCongDoan.HeaderText = "Mã công đoạn";
            this.dmcsxMaCongDoan.Name = "dmcsxMaCongDoan";
            this.dmcsxMaCongDoan.Width = 150;
            // 
            // dmcdsxTenCongDoan
            // 
            this.dmcdsxTenCongDoan.HeaderText = "Tên công đoạn";
            this.dmcdsxTenCongDoan.Name = "dmcdsxTenCongDoan";
            this.dmcdsxTenCongDoan.Width = 300;
            // 
            // dmcdsxXacNhan
            // 
            this.dmcdsxXacNhan.HeaderText = "Xác nhận";
            this.dmcdsxXacNhan.Name = "dmcdsxXacNhan";
            this.dmcdsxXacNhan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dmcdsxXacNhan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmDMCongDoanSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 483);
            this.Controls.Add(this.btnDanhMucCongDoanSXLuu);
            this.Controls.Add(this.btnDanhMucCongDoanSXXoa);
            this.Controls.Add(this.btnDanhMucCongDoanSXSua);
            this.Controls.Add(this.btnDanhMucCongDoanSXThemMoi);
            this.Controls.Add(this.dtgDanhMucCongDoanSX);
            this.Controls.Add(this.lblDanhMucCongDoanSX);
            this.Name = "frmDMCongDoanSX";
            this.Text = "Danh mục công đoàn sản xuất";
            this.Load += new System.EventHandler(this.frmDMCongDoanSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucCongDoanSX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhMucCongDoanSX;
        private System.Windows.Forms.DataGridView dtgDanhMucCongDoanSX;
        private System.Windows.Forms.Button btnDanhMucCongDoanSXLuu;
        private System.Windows.Forms.Button btnDanhMucCongDoanSXXoa;
        private System.Windows.Forms.Button btnDanhMucCongDoanSXSua;
        private System.Windows.Forms.Button btnDanhMucCongDoanSXThemMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dmcdsxTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dmcsxMaCongDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dmcdsxTenCongDoan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dmcdsxXacNhan;
    }
}