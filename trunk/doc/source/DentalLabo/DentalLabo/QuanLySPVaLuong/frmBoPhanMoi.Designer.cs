namespace DentalLabo.QuanLySPVaLuong
{
    partial class frmBoPhanMoi
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
            this.lblThemBoPhan = new System.Windows.Forms.Label();
            this.lblMaBoPhan = new System.Windows.Forms.Label();
            this.lblTenBoPhan = new System.Windows.Forms.Label();
            this.txtMaBoPhan = new System.Windows.Forms.TextBox();
            this.txtTenBoPhan = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThemBoPhan
            // 
            this.lblThemBoPhan.AutoSize = true;
            this.lblThemBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemBoPhan.ForeColor = System.Drawing.Color.Blue;
            this.lblThemBoPhan.Location = new System.Drawing.Point(190, 41);
            this.lblThemBoPhan.Name = "lblThemBoPhan";
            this.lblThemBoPhan.Size = new System.Drawing.Size(206, 25);
            this.lblThemBoPhan.TabIndex = 0;
            this.lblThemBoPhan.Text = "THÊM BỘ PHẬN MỚI";
            // 
            // lblMaBoPhan
            // 
            this.lblMaBoPhan.AutoSize = true;
            this.lblMaBoPhan.Location = new System.Drawing.Point(67, 104);
            this.lblMaBoPhan.Name = "lblMaBoPhan";
            this.lblMaBoPhan.Size = new System.Drawing.Size(64, 13);
            this.lblMaBoPhan.TabIndex = 1;
            this.lblMaBoPhan.Text = "Mã bộ phận";
            // 
            // lblTenBoPhan
            // 
            this.lblTenBoPhan.AutoSize = true;
            this.lblTenBoPhan.Location = new System.Drawing.Point(328, 104);
            this.lblTenBoPhan.Name = "lblTenBoPhan";
            this.lblTenBoPhan.Size = new System.Drawing.Size(68, 13);
            this.lblTenBoPhan.TabIndex = 2;
            this.lblTenBoPhan.Text = "Tên bộ phận";
            // 
            // txtMaBoPhan
            // 
            this.txtMaBoPhan.Location = new System.Drawing.Point(147, 101);
            this.txtMaBoPhan.Name = "txtMaBoPhan";
            this.txtMaBoPhan.Size = new System.Drawing.Size(118, 20);
            this.txtMaBoPhan.TabIndex = 3;
            // 
            // txtTenBoPhan
            // 
            this.txtTenBoPhan.Location = new System.Drawing.Point(411, 101);
            this.txtTenBoPhan.Name = "txtTenBoPhan";
            this.txtTenBoPhan.Size = new System.Drawing.Size(154, 20);
            this.txtTenBoPhan.TabIndex = 4;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(256, 161);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 23);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Thêm vào CSDL";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmBoPhanMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 208);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenBoPhan);
            this.Controls.Add(this.txtMaBoPhan);
            this.Controls.Add(this.lblTenBoPhan);
            this.Controls.Add(this.lblMaBoPhan);
            this.Controls.Add(this.lblThemBoPhan);
            this.Name = "frmBoPhanMoi";
            this.Text = "frmBoPhanMoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThemBoPhan;
        private System.Windows.Forms.Label lblMaBoPhan;
        private System.Windows.Forms.Label lblTenBoPhan;
        private System.Windows.Forms.TextBox txtMaBoPhan;
        private System.Windows.Forms.TextBox txtTenBoPhan;
        private System.Windows.Forms.Button btnLuu;
    }
}