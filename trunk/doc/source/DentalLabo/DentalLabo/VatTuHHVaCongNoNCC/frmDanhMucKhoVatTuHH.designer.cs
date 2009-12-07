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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucKhoVatTuHangHoa)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgDanhMucKhoVatTuHangHoa
            // 
            this.dtgDanhMucKhoVatTuHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDanhMucKhoVatTuHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDanhMucKhoVatTuHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhMucKhoVatTuHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMaKhoHang,
            this.clnTenKhoHang,
            this.clnMaTK,
            this.clnDiaChi,
            this.clnDienThoai,
            this.clnThuKho,
            this.clnXacNhan});
            this.dtgDanhMucKhoVatTuHangHoa.Location = new System.Drawing.Point(12, 75);
            this.dtgDanhMucKhoVatTuHangHoa.Name = "dtgDanhMucKhoVatTuHangHoa";
            this.dtgDanhMucKhoVatTuHangHoa.Size = new System.Drawing.Size(728, 376);
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
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(728, 40);
            this.label12.TabIndex = 26;
            this.label12.Text = "DANH MỤC KHO VẬT TƯ HÀNG HÓA";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnSua.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnXoa.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnLuu.Click += new System.EventHandler(this.btnThem_Click);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 469);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 35);
            this.tableLayoutPanel1.TabIndex = 28;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // frmDanhMucKhoVatTuHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 516);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dtgDanhMucKhoVatTuHangHoa);
            this.Controls.Add(this.label12);
            this.Name = "frmDanhMucKhoVatTuHH";
            this.Text = "Danh Muc Kho Vat Tu Hang Hoa";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucKhoVatTuHangHoa)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}