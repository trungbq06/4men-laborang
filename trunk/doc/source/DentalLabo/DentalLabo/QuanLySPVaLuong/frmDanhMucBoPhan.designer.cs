namespace DentalLabo
{
    partial class frmDanhMucBoPhan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDanhMucBoPhan = new System.Windows.Forms.Label();
            this.btnDanhMucBoPhanLuu = new System.Windows.Forms.Button();
            this.btnDanhMucBoPhanXoa = new System.Windows.Forms.Button();
            this.btnDanhMucBoPhanSua = new System.Windows.Forms.Button();
            this.btnDanhMucBoPhanThemMoi = new System.Windows.Forms.Button();
            this.dtgDanhMucCongDoanSX = new System.Windows.Forms.DataGridView();
            this.dmbpTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmbpMaBoPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmbpTenBoPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmbpXacNhan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucCongDoanSX)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDanhMucBoPhan
            // 
            this.lblDanhMucBoPhan.AutoSize = true;
            this.lblDanhMucBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMucBoPhan.ForeColor = System.Drawing.Color.Blue;
            this.lblDanhMucBoPhan.Location = new System.Drawing.Point(239, 42);
            this.lblDanhMucBoPhan.Name = "lblDanhMucBoPhan";
            this.lblDanhMucBoPhan.Size = new System.Drawing.Size(225, 25);
            this.lblDanhMucBoPhan.TabIndex = 8;
            this.lblDanhMucBoPhan.Text = "DANH MỤC BỘ PHẬN";
            // 
            // btnDanhMucBoPhanLuu
            // 
            this.btnDanhMucBoPhanLuu.Location = new System.Drawing.Point(544, 426);
            this.btnDanhMucBoPhanLuu.Name = "btnDanhMucBoPhanLuu";
            this.btnDanhMucBoPhanLuu.Size = new System.Drawing.Size(75, 23);
            this.btnDanhMucBoPhanLuu.TabIndex = 20;
            this.btnDanhMucBoPhanLuu.Text = "Lưu";
            this.btnDanhMucBoPhanLuu.UseVisualStyleBackColor = true;
            // 
            // btnDanhMucBoPhanXoa
            // 
            this.btnDanhMucBoPhanXoa.Location = new System.Drawing.Point(399, 426);
            this.btnDanhMucBoPhanXoa.Name = "btnDanhMucBoPhanXoa";
            this.btnDanhMucBoPhanXoa.Size = new System.Drawing.Size(75, 23);
            this.btnDanhMucBoPhanXoa.TabIndex = 19;
            this.btnDanhMucBoPhanXoa.Text = "Xóa";
            this.btnDanhMucBoPhanXoa.UseVisualStyleBackColor = true;
            // 
            // btnDanhMucBoPhanSua
            // 
            this.btnDanhMucBoPhanSua.Location = new System.Drawing.Point(257, 426);
            this.btnDanhMucBoPhanSua.Name = "btnDanhMucBoPhanSua";
            this.btnDanhMucBoPhanSua.Size = new System.Drawing.Size(75, 23);
            this.btnDanhMucBoPhanSua.TabIndex = 18;
            this.btnDanhMucBoPhanSua.Text = "Sửa";
            this.btnDanhMucBoPhanSua.UseVisualStyleBackColor = true;
            // 
            // btnDanhMucBoPhanThemMoi
            // 
            this.btnDanhMucBoPhanThemMoi.Location = new System.Drawing.Point(109, 426);
            this.btnDanhMucBoPhanThemMoi.Name = "btnDanhMucBoPhanThemMoi";
            this.btnDanhMucBoPhanThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnDanhMucBoPhanThemMoi.TabIndex = 17;
            this.btnDanhMucBoPhanThemMoi.Text = "Thêm mới";
            this.btnDanhMucBoPhanThemMoi.UseVisualStyleBackColor = true;
            // 
            // dtgDanhMucCongDoanSX
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgDanhMucCongDoanSX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDanhMucCongDoanSX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgDanhMucCongDoanSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhMucCongDoanSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dmbpTT,
            this.dmbpMaBoPhan,
            this.dmbpTenBoPhan,
            this.dmbpXacNhan});
            this.dtgDanhMucCongDoanSX.Location = new System.Drawing.Point(52, 100);
            this.dtgDanhMucCongDoanSX.Name = "dtgDanhMucCongDoanSX";
            this.dtgDanhMucCongDoanSX.Size = new System.Drawing.Size(642, 298);
            this.dtgDanhMucCongDoanSX.TabIndex = 16;
            // 
            // dmbpTT
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dmbpTT.DefaultCellStyle = dataGridViewCellStyle9;
            this.dmbpTT.HeaderText = "TT";
            this.dmbpTT.Name = "dmbpTT";
            this.dmbpTT.Width = 50;
            // 
            // dmbpMaBoPhan
            // 
            this.dmbpMaBoPhan.HeaderText = "Mã bộ phận";
            this.dmbpMaBoPhan.Name = "dmbpMaBoPhan";
            this.dmbpMaBoPhan.Width = 150;
            // 
            // dmbpTenBoPhan
            // 
            this.dmbpTenBoPhan.HeaderText = "Tên bộ phận";
            this.dmbpTenBoPhan.Name = "dmbpTenBoPhan";
            this.dmbpTenBoPhan.Width = 300;
            // 
            // dmbpXacNhan
            // 
            this.dmbpXacNhan.HeaderText = "Xác nhận";
            this.dmbpXacNhan.Name = "dmbpXacNhan";
            this.dmbpXacNhan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dmbpXacNhan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmDanhMucBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 483);
            this.Controls.Add(this.btnDanhMucBoPhanLuu);
            this.Controls.Add(this.btnDanhMucBoPhanXoa);
            this.Controls.Add(this.btnDanhMucBoPhanSua);
            this.Controls.Add(this.btnDanhMucBoPhanThemMoi);
            this.Controls.Add(this.dtgDanhMucCongDoanSX);
            this.Controls.Add(this.lblDanhMucBoPhan);
            this.Name = "FrmDanhMucBoPhan";
            this.Text = "Danh mục bộ phận";
            this.Load += new System.EventHandler(this.FrmDanhMucBoPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucCongDoanSX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhMucBoPhan;
        private System.Windows.Forms.Button btnDanhMucBoPhanLuu;
        private System.Windows.Forms.Button btnDanhMucBoPhanXoa;
        private System.Windows.Forms.Button btnDanhMucBoPhanSua;
        private System.Windows.Forms.Button btnDanhMucBoPhanThemMoi;
        private System.Windows.Forms.DataGridView dtgDanhMucCongDoanSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dmbpTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dmbpMaBoPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dmbpTenBoPhan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dmbpXacNhan;
    }
}