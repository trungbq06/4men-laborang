﻿namespace DentalLabo
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucCongDoanSX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDanhMucCongDoanSX
            // 
            this.lblDanhMucCongDoanSX.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.dtgDanhMucCongDoanSX.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dtgDanhMucCongDoanSX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDanhMucCongDoanSX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDanhMucCongDoanSX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDanhMucCongDoanSX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDanhMucCongDoanSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDanhMucCongDoanSX.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDanhMucCongDoanSX.Location = new System.Drawing.Point(71, 94);
            this.dtgDanhMucCongDoanSX.Name = "dtgDanhMucCongDoanSX";
            this.dtgDanhMucCongDoanSX.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgDanhMucCongDoanSX.Size = new System.Drawing.Size(642, 307);
            this.dtgDanhMucCongDoanSX.TabIndex = 8;
            this.dtgDanhMucCongDoanSX.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhMucCongDoanSX_CellValueChanged);
            this.dtgDanhMucCongDoanSX.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgDanhMucCongDoanSX_CellMouseClick);
            this.dtgDanhMucCongDoanSX.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhMucCongDoanSX_CellMouseEnter);
            this.dtgDanhMucCongDoanSX.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgDanhMucCongDoanSX_DataError);
            this.dtgDanhMucCongDoanSX.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgDanhMucCongDoanSX_DataBindingComplete);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(354, 19);
            this.btnXoa.MaximumSize = new System.Drawing.Size(75, 30);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(214, 19);
            this.btnLuu.MaximumSize = new System.Drawing.Size(75, 30);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(58, 19);
            this.btnThem.MaximumSize = new System.Drawing.Size(95, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 30);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm/Sửa";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Location = new System.Drawing.Point(71, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 64);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(476, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(117, 29);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "In danh mục";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmDMCongDoanSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgDanhMucCongDoanSX);
            this.Controls.Add(this.lblDanhMucCongDoanSX);
            this.Name = "frmDMCongDoanSX";
            this.Text = "Danh Muc Cong Doan San Xuat";
            this.Shown += new System.EventHandler(this.frmDMCongDoanSX_Shown);
            this.Load += new System.EventHandler(this.frmDMCongDoanSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMucCongDoanSX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhMucCongDoanSX;
        private System.Windows.Forms.DataGridView dtgDanhMucCongDoanSX;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrint;
    }
}