namespace DentalLabo.Vat_tu_hang_hoa_va_Cong_no_NCC
{
    partial class frmDanhMucVatTuHH
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgDanhMucVatTuHH = new System.Windows.Forms.DataGridView();
            this.clnMaHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnXacNhan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucVatTuHH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(377, 303);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 23);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(285, 303);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 23);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(199, 303);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(63, 23);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dtgDanhMucVatTuHH
            // 
            this.dtgDanhMucVatTuHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhMucVatTuHH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMaHangHoa,
            this.clnTenHangHoa,
            this.clnMaTK,
            this.clnDiaChi,
            this.clnDienThoai,
            this.clnXacNhan});
            this.dtgDanhMucVatTuHH.Location = new System.Drawing.Point(12, 93);
            this.dtgDanhMucVatTuHH.Name = "dtgDanhMucVatTuHH";
            this.dtgDanhMucVatTuHH.Size = new System.Drawing.Size(736, 164);
            this.dtgDanhMucVatTuHH.TabIndex = 28;
            // 
            // clnMaHangHoa
            // 
            this.clnMaHangHoa.HeaderText = "Mã hàng hóa";
            this.clnMaHangHoa.Name = "clnMaHangHoa";
            // 
            // clnTenHangHoa
            // 
            this.clnTenHangHoa.HeaderText = "Tên hàng hóa";
            this.clnTenHangHoa.Name = "clnTenHangHoa";
            // 
            // clnMaTK
            // 
            this.clnMaTK.HeaderText = "ĐVT";
            this.clnMaTK.Name = "clnMaTK";
            // 
            // clnDiaChi
            // 
            this.clnDiaChi.HeaderText = "Nhóm hàng hóa";
            this.clnDiaChi.Name = "clnDiaChi";
            this.clnDiaChi.Width = 150;
            // 
            // clnDienThoai
            // 
            this.clnDienThoai.HeaderText = "Quy cách";
            this.clnDienThoai.Name = "clnDienThoai";
            this.clnDienThoai.Width = 200;
            // 
            // clnXacNhan
            // 
            this.clnXacNhan.HeaderText = "Xác nhận";
            this.clnXacNhan.Name = "clnXacNhan";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(736, 33);
            this.label12.TabIndex = 29;
            this.label12.Text = "DANH MỤC VẬT TƯ HÀNG HÓA";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.Location = new System.Drawing.Point(469, 303);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(63, 23);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // frmDanhMucVatTuHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 349);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgDanhMucVatTuHH);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnLuu);
            this.Name = "frmDanhMucVatTuHH";
            this.Text = "Danh muc vat tu hang hoa";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucVatTuHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgDanhMucVatTuHH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDienThoai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnXacNhan;
    }
}