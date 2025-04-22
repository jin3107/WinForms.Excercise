namespace BaiTap_Chuong5
{
    partial class QuanLyGiangVien
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
            this.lblQLGV = new System.Windows.Forms.Label();
            this.grbTTCT = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.grbTTC = new System.Windows.Forms.GroupBox();
            this.lstViewGV = new System.Windows.Forms.ListView();
            this.colMaGV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbTTCT.SuspendLayout();
            this.grbTTC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQLGV
            // 
            this.lblQLGV.AutoSize = true;
            this.lblQLGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLGV.Location = new System.Drawing.Point(263, 9);
            this.lblQLGV.Name = "lblQLGV";
            this.lblQLGV.Size = new System.Drawing.Size(277, 29);
            this.lblQLGV.TabIndex = 0;
            this.lblQLGV.Text = "QUẢN LÝ GIẢNG VIÊN";
            // 
            // grbTTCT
            // 
            this.grbTTCT.Controls.Add(this.btnThoat);
            this.grbTTCT.Controls.Add(this.btnCapNhat);
            this.grbTTCT.Controls.Add(this.btnHuy);
            this.grbTTCT.Controls.Add(this.btnLuu);
            this.grbTTCT.Controls.Add(this.btnThem);
            this.grbTTCT.Controls.Add(this.dtpNgaySinh);
            this.grbTTCT.Controls.Add(this.cbbGioiTinh);
            this.grbTTCT.Controls.Add(this.txtHoTen);
            this.grbTTCT.Controls.Add(this.txtSDT);
            this.grbTTCT.Controls.Add(this.txtDiaChi);
            this.grbTTCT.Controls.Add(this.txtMaGV);
            this.grbTTCT.Controls.Add(this.lblSoDT);
            this.grbTTCT.Controls.Add(this.lblDiaChi);
            this.grbTTCT.Controls.Add(this.lblGioiTinh);
            this.grbTTCT.Controls.Add(this.lblNgaySinh);
            this.grbTTCT.Controls.Add(this.lblHoTen);
            this.grbTTCT.Controls.Add(this.lblMaGV);
            this.grbTTCT.Location = new System.Drawing.Point(12, 57);
            this.grbTTCT.Name = "grbTTCT";
            this.grbTTCT.Size = new System.Drawing.Size(818, 238);
            this.grbTTCT.TabIndex = 1;
            this.grbTTCT.TabStop = false;
            this.grbTTCT.Text = "Thông tin chi tiết:";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(674, 185);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 47);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(517, 185);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(107, 47);
            this.btnCapNhat.TabIndex = 15;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(347, 185);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(107, 47);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(179, 185);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 47);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(28, 185);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 47);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(138, 124);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 28);
            this.dtpNgaySinh.TabIndex = 11;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Location = new System.Drawing.Point(556, 32);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(225, 30);
            this.cbbGioiTinh.TabIndex = 10;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(113, 78);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(225, 28);
            this.txtHoTen.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(556, 123);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(225, 28);
            this.txtSDT.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(556, 78);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(225, 28);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(113, 34);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(225, 28);
            this.txtMaGV.TabIndex = 6;
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(465, 129);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(67, 22);
            this.lblSoDT.TabIndex = 5;
            this.lblSoDT.Text = "Số ĐT:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(465, 84);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(70, 22);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(465, 40);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(81, 22);
            this.lblGioiTinh.TabIndex = 3;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(24, 129);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(95, 22);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(24, 84);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(68, 22);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(24, 40);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(70, 22);
            this.lblMaGV.TabIndex = 0;
            this.lblMaGV.Text = "Mã GV:";
            // 
            // grbTTC
            // 
            this.grbTTC.Controls.Add(this.lstViewGV);
            this.grbTTC.Location = new System.Drawing.Point(12, 301);
            this.grbTTC.Name = "grbTTC";
            this.grbTTC.Size = new System.Drawing.Size(818, 271);
            this.grbTTC.TabIndex = 2;
            this.grbTTC.TabStop = false;
            this.grbTTC.Text = "Thông tin chung:";
            // 
            // lstViewGV
            // 
            this.lstViewGV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaGV,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colDiaChi,
            this.colSDT});
            this.lstViewGV.FullRowSelect = true;
            this.lstViewGV.GridLines = true;
            this.lstViewGV.HideSelection = false;
            this.lstViewGV.Location = new System.Drawing.Point(14, 27);
            this.lstViewGV.Name = "lstViewGV";
            this.lstViewGV.Size = new System.Drawing.Size(798, 238);
            this.lstViewGV.TabIndex = 0;
            this.lstViewGV.UseCompatibleStateImageBehavior = false;
            this.lstViewGV.View = System.Windows.Forms.View.Details;
            this.lstViewGV.Click += new System.EventHandler(this.lstViewGV_Click);
            // 
            // colMaGV
            // 
            this.colMaGV.Text = "Mã GV";
            this.colMaGV.Width = 70;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 200;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.Width = 80;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày Sinh";
            this.colNgaySinh.Width = 120;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 150;
            // 
            // colSDT
            // 
            this.colSDT.Text = "Số ĐT";
            this.colSDT.Width = 200;
            // 
            // QuanLyGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 584);
            this.Controls.Add(this.grbTTC);
            this.Controls.Add(this.grbTTCT);
            this.Controls.Add(this.lblQLGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyGiangVien";
            this.Load += new System.EventHandler(this.QuanLyGiangVien_Load);
            this.grbTTCT.ResumeLayout(false);
            this.grbTTCT.PerformLayout();
            this.grbTTC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLGV;
        private System.Windows.Forms.GroupBox grbTTCT;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.GroupBox grbTTC;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lstViewGV;
        private System.Windows.Forms.ColumnHeader colMaGV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.ColumnHeader colSDT;
    }
}