﻿namespace DentalLabo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDanhMucNhanVien = new System.Windows.Forms.Label();
            this.lblTenBoPhan = new System.Windows.Forms.Label();
            this.lblMaBoPhan = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.dtgDanhMucNhanVien = new System.Windows.Forms.DataGridView();
            this.txtTenBoPhan = new System.Windows.Forms.TextBox();
            this.txtMaBoPhan = new System.Windows.Forms.TextBox();
            this.dmnvTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmnvMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmnvTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmnvXacNhan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDanhMucNhanVien
            // 
            this.lblDanhMucNhanVien.AutoSize = true;
            this.lblDanhMucNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDanhMucNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMucNhanVien.ForeColor = System.Drawing.Color.Blue;
            this.lblDanhMucNhanVien.Location = new System.Drawing.Point(221, 31);
            this.lblDanhMucNhanVien.Name = "lblDanhMucNhanVien";
            this.lblDanhMucNhanVien.Size = new System.Drawing.Size(244, 25);
            this.lblDanhMucNhanVien.TabIndex = 9;
            this.lblDanhMucNhanVien.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // lblTenBoPhan
            // 
            this.lblTenBoPhan.AutoSize = true;
            this.lblTenBoPhan.Location = new System.Drawing.Point(41, 83);
            this.lblTenBoPhan.Name = "lblTenBoPhan";
            this.lblTenBoPhan.Size = new System.Drawing.Size(68, 13);
            this.lblTenBoPhan.TabIndex = 10;
            this.lblTenBoPhan.Text = "Tên bộ phận";
            // 
            // lblMaBoPhan
            // 
            this.lblMaBoPhan.AutoSize = true;
            this.lblMaBoPhan.Location = new System.Drawing.Point(451, 83);
            this.lblMaBoPhan.Name = "lblMaBoPhan";
            this.lblMaBoPhan.Size = new System.Drawing.Size(64, 13);
            this.lblMaBoPhan.TabIndex = 11;
            this.lblMaBoPhan.Text = "Mã bộ phận";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(535, 451);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(390, 451);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(248, 451);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(100, 451);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 22;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // dtgDanhMucNhanVien
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgDanhMucNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dtgDanhMucNhanVien.Location = new System.Drawing.Point(44, 133);
            this.dtgDanhMucNhanVien.Name = "dtgDanhMucNhanVien";
            this.dtgDanhMucNhanVien.Size = new System.Drawing.Size(642, 298);
            this.dtgDanhMucNhanVien.TabIndex = 21;
            // 
            // txtTenBoPhan
            // 
            this.txtTenBoPhan.Location = new System.Drawing.Point(134, 80);
            this.txtTenBoPhan.Name = "txtTenBoPhan";
            this.txtTenBoPhan.Size = new System.Drawing.Size(218, 20);
            this.txtTenBoPhan.TabIndex = 26;
            // 
            // txtMaBoPhan
            // 
            this.txtMaBoPhan.Location = new System.Drawing.Point(547, 80);
            this.txtMaBoPhan.Name = "txtMaBoPhan";
            this.txtMaBoPhan.Size = new System.Drawing.Size(139, 20);
            this.txtMaBoPhan.TabIndex = 27;
            // 
            // dmnvTT
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dmnvTT.DefaultCellStyle = dataGridViewCellStyle3;
            this.dmnvTT.HeaderText = "TT";
            this.dmnvTT.Name = "dmnvTT";
            this.dmnvTT.Width = 50;
            // 
            // dmnvMaNhanVien
            // 
            this.dmnvMaNhanVien.HeaderText = "Mã nhân viên";
            this.dmnvMaNhanVien.Name = "dmnvMaNhanVien";
            this.dmnvMaNhanVien.Width = 150;
            // 
            // dmnvTenNhanVien
            // 
            this.dmnvTenNhanVien.HeaderText = "Tên nhân viên";
            this.dmnvTenNhanVien.Name = "dmnvTenNhanVien";
            this.dmnvTenNhanVien.Width = 300;
            // 
            // dmnvXacNhan
            // 
            this.dmnvXacNhan.HeaderText = "Xác nhận";
            this.dmnvXacNhan.Name = "dmnvXacNhan";
            this.dmnvXacNhan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dmnvXacNhan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmDanhMucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.txtMaBoPhan);
            this.Controls.Add(this.txtTenBoPhan);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.dtgDanhMucNhanVien);
            this.Controls.Add(this.lblMaBoPhan);
            this.Controls.Add(this.lblTenBoPhan);
            this.Controls.Add(this.lblDanhMucNhanVien);
            this.Name = "frmDanhMucNhanVien";
            this.Text = "Danh mục nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucNhanVien)).EndInit();
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
    }
}