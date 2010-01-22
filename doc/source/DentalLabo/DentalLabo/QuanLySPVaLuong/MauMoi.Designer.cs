namespace DentalLabo.QuanLySPVaLuong
{
    partial class MauMoi
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
            this.labelMaumoi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaMau = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGioTra = new System.Windows.Forms.TextBox();
            this.btnXong = new System.Windows.Forms.Button();
            this.lblLoaiPhucHinh = new System.Windows.Forms.Label();
            this.txtLoaiPhucHinh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelMaumoi
            // 
            this.labelMaumoi.AutoSize = true;
            this.labelMaumoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaumoi.ForeColor = System.Drawing.Color.Blue;
            this.labelMaumoi.Location = new System.Drawing.Point(184, 19);
            this.labelMaumoi.Name = "labelMaumoi";
            this.labelMaumoi.Size = new System.Drawing.Size(199, 25);
            this.labelMaumoi.TabIndex = 0;
            this.labelMaumoi.Text = "TẠO MỘT MẪU MỚI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã mẫu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày trả";
            // 
            // txtMaMau
            // 
            this.txtMaMau.Location = new System.Drawing.Point(133, 85);
            this.txtMaMau.Name = "txtMaMau";
            this.txtMaMau.Size = new System.Drawing.Size(116, 20);
            this.txtMaMau.TabIndex = 5;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(430, 88);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(116, 20);
            this.txtMaKhachHang.TabIndex = 6;
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.CustomFormat = "d/M/yyyy";
            this.dtpNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhan.Location = new System.Drawing.Point(133, 148);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(116, 20);
            this.dtpNgayNhan.TabIndex = 7;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "d/M/yyyy";
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(430, 148);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(116, 20);
            this.dtpNgayTra.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giờ trả";
            // 
            // txtGioTra
            // 
            this.txtGioTra.Location = new System.Drawing.Point(133, 212);
            this.txtGioTra.Name = "txtGioTra";
            this.txtGioTra.Size = new System.Drawing.Size(54, 20);
            this.txtGioTra.TabIndex = 10;
            // 
            // btnXong
            // 
            this.btnXong.Location = new System.Drawing.Point(226, 270);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(124, 25);
            this.btnXong.TabIndex = 15;
            this.btnXong.Text = "Cập nhật vào CSDL";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // lblLoaiPhucHinh
            // 
            this.lblLoaiPhucHinh.AutoSize = true;
            this.lblLoaiPhucHinh.Location = new System.Drawing.Point(336, 215);
            this.lblLoaiPhucHinh.Name = "lblLoaiPhucHinh";
            this.lblLoaiPhucHinh.Size = new System.Drawing.Size(77, 13);
            this.lblLoaiPhucHinh.TabIndex = 16;
            this.lblLoaiPhucHinh.Text = "Loại phục hình";
            // 
            // txtLoaiPhucHinh
            // 
            this.txtLoaiPhucHinh.Location = new System.Drawing.Point(427, 213);
            this.txtLoaiPhucHinh.Name = "txtLoaiPhucHinh";
            this.txtLoaiPhucHinh.Size = new System.Drawing.Size(116, 20);
            this.txtLoaiPhucHinh.TabIndex = 17;
            // 
            // MauMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 322);
            this.Controls.Add(this.txtLoaiPhucHinh);
            this.Controls.Add(this.lblLoaiPhucHinh);
            this.Controls.Add(this.btnXong);
            this.Controls.Add(this.txtGioTra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.dtpNgayNhan);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.txtMaMau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMaumoi);
            this.Name = "MauMoi";
            this.Text = "MauMoi";
            this.Load += new System.EventHandler(this.MauMoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaumoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaMau;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGioTra;
        private System.Windows.Forms.Button btnXong;
        private System.Windows.Forms.Label lblLoaiPhucHinh;
        private System.Windows.Forms.TextBox txtLoaiPhucHinh;
    }
}