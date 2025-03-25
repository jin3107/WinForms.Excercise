namespace BaiTap_Chuong2
{
    partial class Bai6_tr35
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoaiXe = new System.Windows.Forms.Label();
            this.grbTT = new System.Windows.Forms.GroupBox();
            this.lblTenXe = new System.Windows.Forms.Label();
            this.lblMauSac = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTT = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.btTT = new System.Windows.Forms.Button();
            this.cbbLoaiXe = new System.Windows.Forms.ComboBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.txtMauSac = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.nuSoLuong = new System.Windows.Forms.NumericUpDown();
            this.grbTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH CÁC LOẠI XE";
            // 
            // lblLoaiXe
            // 
            this.lblLoaiXe.AutoSize = true;
            this.lblLoaiXe.Location = new System.Drawing.Point(61, 88);
            this.lblLoaiXe.Name = "lblLoaiXe";
            this.lblLoaiXe.Size = new System.Drawing.Size(73, 22);
            this.lblLoaiXe.TabIndex = 1;
            this.lblLoaiXe.Text = "Loại xe:";
            // 
            // grbTT
            // 
            this.grbTT.Controls.Add(this.nuSoLuong);
            this.grbTT.Controls.Add(this.txtDonGia);
            this.grbTT.Controls.Add(this.txtMauSac);
            this.grbTT.Controls.Add(this.txtTenXe);
            this.grbTT.Controls.Add(this.lblSoLuong);
            this.grbTT.Controls.Add(this.lblDonGia);
            this.grbTT.Controls.Add(this.lblMauSac);
            this.grbTT.Controls.Add(this.lblTenXe);
            this.grbTT.Location = new System.Drawing.Point(12, 166);
            this.grbTT.Name = "grbTT";
            this.grbTT.Size = new System.Drawing.Size(455, 206);
            this.grbTT.TabIndex = 2;
            this.grbTT.TabStop = false;
            this.grbTT.Text = "Thông tin chi tiết:";
            // 
            // lblTenXe
            // 
            this.lblTenXe.AutoSize = true;
            this.lblTenXe.Location = new System.Drawing.Point(26, 45);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(71, 22);
            this.lblTenXe.TabIndex = 2;
            this.lblTenXe.Text = "Tên xe:";
            // 
            // lblMauSac
            // 
            this.lblMauSac.AutoSize = true;
            this.lblMauSac.Location = new System.Drawing.Point(26, 83);
            this.lblMauSac.Name = "lblMauSac";
            this.lblMauSac.Size = new System.Drawing.Size(82, 22);
            this.lblMauSac.TabIndex = 3;
            this.lblMauSac.Text = "Màu sắc:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(26, 124);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(77, 22);
            this.lblDonGia.TabIndex = 4;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(26, 164);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(86, 22);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Location = new System.Drawing.Point(203, 391);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(101, 22);
            this.lblTT.TabIndex = 3;
            this.lblTT.Text = "Thành tiền:";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(355, 391);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(20, 22);
            this.lblT.TabIndex = 4;
            this.lblT.Text = "0";
            // 
            // btTT
            // 
            this.btTT.Location = new System.Drawing.Point(37, 378);
            this.btTT.Name = "btTT";
            this.btTT.Size = new System.Drawing.Size(109, 48);
            this.btTT.TabIndex = 5;
            this.btTT.Text = "Tính tiền";
            this.btTT.UseVisualStyleBackColor = true;
            this.btTT.Click += new System.EventHandler(this.btTT_Click);
            // 
            // cbbLoaiXe
            // 
            this.cbbLoaiXe.FormattingEnabled = true;
            this.cbbLoaiXe.Location = new System.Drawing.Point(178, 85);
            this.cbbLoaiXe.Name = "cbbLoaiXe";
            this.cbbLoaiXe.Size = new System.Drawing.Size(236, 30);
            this.cbbLoaiXe.TabIndex = 6;
            this.cbbLoaiXe.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiXe_SelectedIndexChanged);
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(195, 42);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(239, 28);
            this.txtTenXe.TabIndex = 6;
            // 
            // txtMauSac
            // 
            this.txtMauSac.Location = new System.Drawing.Point(195, 80);
            this.txtMauSac.Name = "txtMauSac";
            this.txtMauSac.Size = new System.Drawing.Size(239, 28);
            this.txtMauSac.TabIndex = 7;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(195, 118);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(239, 28);
            this.txtDonGia.TabIndex = 8;
            // 
            // nuSoLuong
            // 
            this.nuSoLuong.Location = new System.Drawing.Point(195, 158);
            this.nuSoLuong.Name = "nuSoLuong";
            this.nuSoLuong.Size = new System.Drawing.Size(239, 28);
            this.nuSoLuong.TabIndex = 9;
            // 
            // Bai6_tr35
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 441);
            this.Controls.Add(this.cbbLoaiXe);
            this.Controls.Add(this.btTT);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblTT);
            this.Controls.Add(this.grbTT);
            this.Controls.Add(this.lblLoaiXe);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai6_tr35";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai6_tr35";
            this.Load += new System.EventHandler(this.Bai6_tr35_Load);
            this.grbTT.ResumeLayout(false);
            this.grbTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoaiXe;
        private System.Windows.Forms.GroupBox grbTT;
        private System.Windows.Forms.Label lblMauSac;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.NumericUpDown nuSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtMauSac;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Button btTT;
        private System.Windows.Forms.ComboBox cbbLoaiXe;
    }
}