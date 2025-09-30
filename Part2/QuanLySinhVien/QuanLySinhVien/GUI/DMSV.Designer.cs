namespace QuanLySinhVien.GUI
{
    partial class DMSV
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
            this.lblDMSV = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblPhai = new System.Windows.Forms.Label();
            this.grbTTSV = new System.Windows.Forms.GroupBox();
            this.cbbPhai = new System.Windows.Forms.CheckBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lstvDMSV = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbTTSV.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDMSV
            // 
            this.lblDMSV.AutoSize = true;
            this.lblDMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMSV.ForeColor = System.Drawing.Color.Red;
            this.lblDMSV.Location = new System.Drawing.Point(231, 9);
            this.lblDMSV.Name = "lblDMSV";
            this.lblDMSV.Size = new System.Drawing.Size(282, 29);
            this.lblDMSV.TabIndex = 0;
            this.lblDMSV.Text = "DANH MỤC SINH VIÊN";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(6, 35);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(63, 22);
            this.lblMaSV.TabIndex = 1;
            this.lblMaSV.Text = "Mã SV";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(6, 89);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(63, 22);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(451, 35);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(90, 22);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblPhai
            // 
            this.lblPhai.AutoSize = true;
            this.lblPhai.Location = new System.Drawing.Point(451, 89);
            this.lblPhai.Name = "lblPhai";
            this.lblPhai.Size = new System.Drawing.Size(46, 22);
            this.lblPhai.TabIndex = 4;
            this.lblPhai.Text = "Phái";
            // 
            // grbTTSV
            // 
            this.grbTTSV.Controls.Add(this.cbbPhai);
            this.grbTTSV.Controls.Add(this.dtpNgaySinh);
            this.grbTTSV.Controls.Add(this.txtTen);
            this.grbTTSV.Controls.Add(this.txtHoLot);
            this.grbTTSV.Controls.Add(this.txtMaSV);
            this.grbTTSV.Controls.Add(this.lblMaSV);
            this.grbTTSV.Controls.Add(this.lblNgaySinh);
            this.grbTTSV.Controls.Add(this.lblPhai);
            this.grbTTSV.Controls.Add(this.lblHoTen);
            this.grbTTSV.Location = new System.Drawing.Point(16, 50);
            this.grbTTSV.Name = "grbTTSV";
            this.grbTTSV.Size = new System.Drawing.Size(717, 128);
            this.grbTTSV.TabIndex = 5;
            this.grbTTSV.TabStop = false;
            this.grbTTSV.Text = "Thông tin sinh viên";
            // 
            // cbbPhai
            // 
            this.cbbPhai.AutoSize = true;
            this.cbbPhai.Location = new System.Drawing.Point(563, 85);
            this.cbbPhai.Name = "cbbPhai";
            this.cbbPhai.Size = new System.Drawing.Size(107, 26);
            this.cbbPhai.TabIndex = 9;
            this.cbbPhai.Text = "Nam / Nữ";
            this.cbbPhai.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(563, 27);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(133, 28);
            this.dtpNgaySinh.TabIndex = 8;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(285, 83);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(128, 28);
            this.txtTen.TabIndex = 7;
            // 
            // txtHoLot
            // 
            this.txtHoLot.Location = new System.Drawing.Point(75, 83);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(178, 28);
            this.txtHoLot.TabIndex = 6;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(79, 29);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(178, 28);
            this.txtMaSV.TabIndex = 5;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnHuy);
            this.grbChucNang.Controls.Add(this.btnCapNhat);
            this.grbChucNang.Controls.Add(this.btnKhong);
            this.grbChucNang.Controls.Add(this.btnGhi);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Location = new System.Drawing.Point(16, 184);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(717, 87);
            this.grbChucNang.TabIndex = 6;
            this.grbChucNang.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(609, 27);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 40);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(451, 27);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(98, 40);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.Location = new System.Drawing.Point(304, 27);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(87, 40);
            this.btnKhong.TabIndex = 2;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = true;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(157, 27);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(87, 40);
            this.btnGhi.TabIndex = 1;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lstvDMSV
            // 
            this.lstvDMSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colMaSV,
            this.colHoTen,
            this.colPhai,
            this.colNgaySinh});
            this.lstvDMSV.FullRowSelect = true;
            this.lstvDMSV.GridLines = true;
            this.lstvDMSV.HideSelection = false;
            this.lstvDMSV.Location = new System.Drawing.Point(16, 277);
            this.lstvDMSV.Name = "lstvDMSV";
            this.lstvDMSV.Size = new System.Drawing.Size(717, 211);
            this.lstvDMSV.TabIndex = 7;
            this.lstvDMSV.UseCompatibleStateImageBehavior = false;
            this.lstvDMSV.View = System.Windows.Forms.View.Details;
            this.lstvDMSV.SelectedIndexChanged += new System.EventHandler(this.lstvDMSV_SelectedIndexChanged);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 50;
            // 
            // colMaSV
            // 
            this.colMaSV.Text = "Mã SV";
            this.colMaSV.Width = 120;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ Tên";
            this.colHoTen.Width = 250;
            // 
            // colPhai
            // 
            this.colPhai.Text = "Phái";
            this.colPhai.Width = 70;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 120;
            // 
            // DMSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 500);
            this.Controls.Add(this.lstvDMSV);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbTTSV);
            this.Controls.Add(this.lblDMSV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DMSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMSV";
            this.Load += new System.EventHandler(this.DMSV_Load);
            this.grbTTSV.ResumeLayout(false);
            this.grbTTSV.PerformLayout();
            this.grbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDMSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblPhai;
        private System.Windows.Forms.GroupBox grbTTSV;
        private System.Windows.Forms.CheckBox cbbPhai;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView lstvDMSV;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colPhai;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
    }
}