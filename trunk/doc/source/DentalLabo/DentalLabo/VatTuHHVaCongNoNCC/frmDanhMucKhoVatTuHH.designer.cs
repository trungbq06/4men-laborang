namespace DentalLabo.Vat_tu_hang_hoa_va_Cong_no_NCC
{
    partial class frmDanhMucKhoVatTuHH
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
            this.dtgDanhMucKhoVatTuHangHoa = new System.Windows.Forms.DataGridView();
            this.clnMaKhoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTenKhoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnThuKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnXacNhan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucKhoVatTuHangHoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgDanhMucKhoVatTuHangHoa
            // 
            this.dtgDanhMucKhoVatTuHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhMucKhoVatTuHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMaKhoHang,
            this.clnTenKhoHang,
            this.clnMaTK,
            this.clnDiaChi,
            this.clnDienThoai,
            this.clnThuKho,
            this.clnXacNhan});
            this.dtgDanhMucKhoVatTuHangHoa.Location = new System.Drawing.Point(12, 93);
            this.dtgDanhMucKhoVatTuHangHoa.Name = "dtgDanhMucKhoVatTuHangHoa";
            this.dtgDanhMucKhoVatTuHangHoa.Size = new System.Drawing.Size(736, 164);
            this.dtgDanhMucKhoVatTuHangHoa.TabIndex = 25;
            // 
            // clnMaKhoHang
            // 
            this.clnMaKhoHang.HeaderText = "Mã kho hàng";
            this.clnMaKhoHang.Name = "clnMaKhoHang";
            // 
            // clnTenKhoHang
            // 
            this.clnTenKhoHang.HeaderText = "Tên Kho Hàng";
            this.clnTenKhoHang.Name = "clnTenKhoHang";
            // 
            // clnMaTK
            // 
            this.clnMaTK.HeaderText = "Mã TK";
            this.clnMaTK.Name = "clnMaTK";
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
            // clnThuKho
            // 
            this.clnThuKho.HeaderText = "Thủ Kho";
            this.clnThuKho.Name = "clnThuKho";
            // 
            // clnXacNhan
            // 
            this.clnXacNhan.HeaderText = "Xác nhận";
            this.clnXacNhan.Name = "clnXacNhan";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(12, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(736, 33);
            this.label12.TabIndex = 26;
            this.label12.Text = "DANH MỤC KHO VẬT TƯ HÀNG HÓA";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(161, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(63, 23);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(282, 22);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 23);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(409, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 23);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.Location = new System.Drawing.Point(544, 22);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(63, 23);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Location = new System.Drawing.Point(12, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 62);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // frmDanhMucKhoVatTuHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 335);
            this.Controls.Add(this.dtgDanhMucKhoVatTuHangHoa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDanhMucKhoVatTuHH";
            this.Text = "Danh Muc Kho Vat Tu Hang Hoa";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucKhoVatTuHangHoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDanhMucKhoVatTuHangHoa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaKhoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTenKhoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThuKho;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnXacNhan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}