namespace DentalLabo
{
    partial class frmDanhMucNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDanhMucNhanVien = new System.Windows.Forms.Label();
            this.lblTenBoPhan = new System.Windows.Forms.Label();
            this.lblMaBoPhan = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.dtgDanhMucNhanVien = new System.Windows.Forms.DataGridView();
            this.dmnvTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmnvMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmnvTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmnvXacNhan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtTenBoPhan = new System.Windows.Forms.TextBox();
            this.txtMaBoPhan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDanhMucNhanVien
            // 
            this.lblDanhMucNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDanhMucNhanVien.AutoEllipsis = true;
            this.lblDanhMucNhanVien.AutoSize = true;
            this.lblDanhMucNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDanhMucNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMucNhanVien.ForeColor = System.Drawing.Color.Blue;
            this.lblDanhMucNhanVien.Location = new System.Drawing.Point(240, 31);
            this.lblDanhMucNhanVien.Name = "lblDanhMucNhanVien";
            this.lblDanhMucNhanVien.Size = new System.Drawing.Size(244, 25);
            this.lblDanhMucNhanVien.TabIndex = 9;
            this.lblDanhMucNhanVien.Text = "DANH MỤC NHÂN VIÊN";
            this.lblDanhMucNhanVien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTenBoPhan
            // 
            this.lblTenBoPhan.AutoSize = true;
            this.lblTenBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBoPhan.Location = new System.Drawing.Point(41, 80);
            this.lblTenBoPhan.Name = "lblTenBoPhan";
            this.lblTenBoPhan.Size = new System.Drawing.Size(89, 17);
            this.lblTenBoPhan.TabIndex = 10;
            this.lblTenBoPhan.Text = "Tên bộ phận";
            // 
            // lblMaBoPhan
            // 
            this.lblMaBoPhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaBoPhan.AutoSize = true;
            this.lblMaBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBoPhan.Location = new System.Drawing.Point(453, 80);
            this.lblMaBoPhan.Name = "lblMaBoPhan";
            this.lblMaBoPhan.Size = new System.Drawing.Size(83, 17);
            this.lblMaBoPhan.TabIndex = 11;
            this.lblMaBoPhan.Text = "Mã bộ phận";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(515, 17);
            this.btnLuu.MaximumSize = new System.Drawing.Size(75, 30);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(365, 17);
            this.btnXoa.MaximumSize = new System.Drawing.Size(75, 30);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(201, 17);
            this.btnSua.MaximumSize = new System.Drawing.Size(75, 30);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(21, 17);
            this.btnThemMoi.MaximumSize = new System.Drawing.Size(96, 30);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(96, 30);
            this.btnThemMoi.TabIndex = 22;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // dtgDanhMucNhanVien
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgDanhMucNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDanhMucNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDanhMucNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDanhMucNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDanhMucNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhMucNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dmnvTT,
            this.dmnvMaNhanVien,
            this.dmnvTenNhanVien,
            this.dmnvXacNhan});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDanhMucNhanVien.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgDanhMucNhanVien.Location = new System.Drawing.Point(44, 133);
            this.dtgDanhMucNhanVien.Name = "dtgDanhMucNhanVien";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDanhMucNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgDanhMucNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgDanhMucNhanVien.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgDanhMucNhanVien.Size = new System.Drawing.Size(654, 288);
            this.dtgDanhMucNhanVien.TabIndex = 21;
            // 
            // dmnvTT
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dmnvTT.DefaultCellStyle = dataGridViewCellStyle3;
            this.dmnvTT.HeaderText = "TT";
            this.dmnvTT.Name = "dmnvTT";
            // 
            // dmnvMaNhanVien
            // 
            this.dmnvMaNhanVien.HeaderText = "Mã nhân viên";
            this.dmnvMaNhanVien.Name = "dmnvMaNhanVien";
            // 
            // dmnvTenNhanVien
            // 
            this.dmnvTenNhanVien.HeaderText = "Tên nhân viên";
            this.dmnvTenNhanVien.Name = "dmnvTenNhanVien";
            // 
            // dmnvXacNhan
            // 
            this.dmnvXacNhan.HeaderText = "Xác nhận";
            this.dmnvXacNhan.Name = "dmnvXacNhan";
            this.dmnvXacNhan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dmnvXacNhan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtTenBoPhan
            // 
            this.txtTenBoPhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenBoPhan.Location = new System.Drawing.Point(134, 80);
            this.txtTenBoPhan.MaximumSize = new System.Drawing.Size(600, 20);
            this.txtTenBoPhan.Name = "txtTenBoPhan";
            this.txtTenBoPhan.Size = new System.Drawing.Size(230, 20);
            this.txtTenBoPhan.TabIndex = 26;
            // 
            // txtMaBoPhan
            // 
            this.txtMaBoPhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaBoPhan.Location = new System.Drawing.Point(559, 80);
            this.txtMaBoPhan.MaximumSize = new System.Drawing.Size(300, 20);
            this.txtMaBoPhan.Name = "txtMaBoPhan";
            this.txtMaBoPhan.Size = new System.Drawing.Size(139, 20);
            this.txtMaBoPhan.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Location = new System.Drawing.Point(44, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 64);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // frmDanhMucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMaBoPhan);
            this.Controls.Add(this.txtTenBoPhan);
            this.Controls.Add(this.dtgDanhMucNhanVien);
            this.Controls.Add(this.lblMaBoPhan);
            this.Controls.Add(this.lblTenBoPhan);
            this.Controls.Add(this.lblDanhMucNhanVien);
            this.Name = "frmDanhMucNhanVien";
            this.Text = "Danh Muc Nhan Vien";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhMucNhanVien;
        private System.Windows.Forms.Label lblTenBoPhan;
        private System.Windows.Forms.Label lblMaBoPhan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.DataGridView dtgDanhMucNhanVien;
        private System.Windows.Forms.TextBox txtTenBoPhan;
        private System.Windows.Forms.TextBox txtMaBoPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dmnvTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dmnvMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dmnvTenNhanVien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dmnvXacNhan;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}