namespace BT_BS6
{
    partial class BT_BS6
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
            this.lblTTVTVL = new System.Windows.Forms.Label();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.clbDanhMuc = new System.Windows.Forms.CheckedListBox();
            this.grbTT = new System.Windows.Forms.GroupBox();
            this.grbSapXep = new System.Windows.Forms.GroupBox();
            this.lblMaVT = new System.Windows.Forms.Label();
            this.lblTenVT = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.rdbtnTang = new System.Windows.Forms.RadioButton();
            this.rdbtnGiam = new System.Windows.Forms.RadioButton();
            this.lblLKNV = new System.Windows.Forms.Label();
            this.lstvNhanVien = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhongBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbTT.SuspendLayout();
            this.grbSapXep.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTTVTVL
            // 
            this.lblTTVTVL.AutoSize = true;
            this.lblTTVTVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTVTVL.Location = new System.Drawing.Point(358, 9);
            this.lblTTVTVL.Name = "lblTTVTVL";
            this.lblTTVTVL.Size = new System.Drawing.Size(358, 29);
            this.lblTTVTVL.TabIndex = 0;
            this.lblTTVTVL.Text = "THÔNG TIN VỊ TRÍ VIỆC LÀM";
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Location = new System.Drawing.Point(12, 51);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(199, 22);
            this.lblDanhMuc.TabIndex = 1;
            this.lblDanhMuc.Text = "Danh mục vị trí việc làm";
            // 
            // clbDanhMuc
            // 
            this.clbDanhMuc.BackColor = System.Drawing.Color.White;
            this.clbDanhMuc.FormattingEnabled = true;
            this.clbDanhMuc.Location = new System.Drawing.Point(12, 76);
            this.clbDanhMuc.Name = "clbDanhMuc";
            this.clbDanhMuc.Size = new System.Drawing.Size(217, 211);
            this.clbDanhMuc.TabIndex = 2;
            this.clbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.clbDanhMuc_SelectedIndexChanged);
            // 
            // grbTT
            // 
            this.grbTT.Controls.Add(this.btnHuy);
            this.grbTT.Controls.Add(this.btnCapNhat);
            this.grbTT.Controls.Add(this.btnThem);
            this.grbTT.Controls.Add(this.txtLuong);
            this.grbTT.Controls.Add(this.txtTenVT);
            this.grbTT.Controls.Add(this.txtMaVT);
            this.grbTT.Controls.Add(this.lblLuong);
            this.grbTT.Controls.Add(this.lblTenVT);
            this.grbTT.Controls.Add(this.lblMaVT);
            this.grbTT.Location = new System.Drawing.Point(256, 76);
            this.grbTT.Name = "grbTT";
            this.grbTT.Size = new System.Drawing.Size(448, 211);
            this.grbTT.TabIndex = 3;
            this.grbTT.TabStop = false;
            this.grbTT.Text = "Thông tin chi tiết";
            // 
            // grbSapXep
            // 
            this.grbSapXep.Controls.Add(this.rdbtnGiam);
            this.grbSapXep.Controls.Add(this.rdbtnTang);
            this.grbSapXep.Location = new System.Drawing.Point(724, 110);
            this.grbSapXep.Name = "grbSapXep";
            this.grbSapXep.Size = new System.Drawing.Size(292, 138);
            this.grbSapXep.TabIndex = 4;
            this.grbSapXep.TabStop = false;
            this.grbSapXep.Text = "Sắp xếp theo lương";
            // 
            // lblMaVT
            // 
            this.lblMaVT.AutoSize = true;
            this.lblMaVT.Location = new System.Drawing.Point(19, 34);
            this.lblMaVT.Name = "lblMaVT";
            this.lblMaVT.Size = new System.Drawing.Size(82, 22);
            this.lblMaVT.TabIndex = 0;
            this.lblMaVT.Text = "Mã vị trí: ";
            // 
            // lblTenVT
            // 
            this.lblTenVT.AutoSize = true;
            this.lblTenVT.Location = new System.Drawing.Point(19, 93);
            this.lblTenVT.Name = "lblTenVT";
            this.lblTenVT.Size = new System.Drawing.Size(85, 22);
            this.lblTenVT.TabIndex = 1;
            this.lblTenVT.Text = "Tên vị trí:";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(19, 150);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(65, 22);
            this.lblLuong.TabIndex = 2;
            this.lblLuong.Text = "Lương:";
            // 
            // txtMaVT
            // 
            this.txtMaVT.Location = new System.Drawing.Point(107, 28);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(199, 28);
            this.txtMaVT.TabIndex = 3;
            // 
            // txtTenVT
            // 
            this.txtTenVT.Location = new System.Drawing.Point(110, 87);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(196, 28);
            this.txtTenVT.TabIndex = 4;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(107, 144);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(199, 28);
            this.txtLuong.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightGreen;
            this.btnThem.Location = new System.Drawing.Point(323, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 43);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnCapNhat.Location = new System.Drawing.Point(323, 80);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(107, 43);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnHuy.Location = new System.Drawing.Point(323, 140);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(107, 43);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // rdbtnTang
            // 
            this.rdbtnTang.AutoSize = true;
            this.rdbtnTang.Location = new System.Drawing.Point(21, 46);
            this.rdbtnTang.Name = "rdbtnTang";
            this.rdbtnTang.Size = new System.Drawing.Size(197, 26);
            this.rdbtnTang.TabIndex = 0;
            this.rdbtnTang.TabStop = true;
            this.rdbtnTang.Text = "Theo lương tăng dần";
            this.rdbtnTang.UseVisualStyleBackColor = true;
            this.rdbtnTang.CheckedChanged += new System.EventHandler(this.rdbtnTang_CheckedChanged);
            // 
            // rdbtnGiam
            // 
            this.rdbtnGiam.AutoSize = true;
            this.rdbtnGiam.Location = new System.Drawing.Point(21, 90);
            this.rdbtnGiam.Name = "rdbtnGiam";
            this.rdbtnGiam.Size = new System.Drawing.Size(200, 26);
            this.rdbtnGiam.TabIndex = 1;
            this.rdbtnGiam.TabStop = true;
            this.rdbtnGiam.Text = "Theo lương giảm dần";
            this.rdbtnGiam.UseVisualStyleBackColor = true;
            this.rdbtnGiam.CheckedChanged += new System.EventHandler(this.rdbtnGiam_CheckedChanged);
            // 
            // lblLKNV
            // 
            this.lblLKNV.AutoSize = true;
            this.lblLKNV.Location = new System.Drawing.Point(12, 305);
            this.lblLKNV.Name = "lblLKNV";
            this.lblLKNV.Size = new System.Drawing.Size(294, 22);
            this.lblLKNV.TabIndex = 5;
            this.lblLKNV.Text = "Liệt kê nhân viên theo vị trí việc làm";
            // 
            // lstvNhanVien
            // 
            this.lstvNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.lstvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colHoTen,
            this.colPhongBan,
            this.colLuong});
            this.lstvNhanVien.FullRowSelect = true;
            this.lstvNhanVien.GridLines = true;
            this.lstvNhanVien.HideSelection = false;
            this.lstvNhanVien.Location = new System.Drawing.Point(12, 343);
            this.lstvNhanVien.Name = "lstvNhanVien";
            this.lstvNhanVien.Size = new System.Drawing.Size(617, 196);
            this.lstvNhanVien.TabIndex = 6;
            this.lstvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lstvNhanVien.View = System.Windows.Forms.View.Details;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 200;
            // 
            // colPhongBan
            // 
            this.colPhongBan.Text = "Phòng ban";
            this.colPhongBan.Width = 200;
            // 
            // colLuong
            // 
            this.colLuong.Text = "Lương";
            this.colLuong.Width = 150;
            // 
            // BT_BS6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1027, 555);
            this.Controls.Add(this.lstvNhanVien);
            this.Controls.Add(this.lblLKNV);
            this.Controls.Add(this.grbSapXep);
            this.Controls.Add(this.grbTT);
            this.Controls.Add(this.clbDanhMuc);
            this.Controls.Add(this.lblDanhMuc);
            this.Controls.Add(this.lblTTVTVL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BT_BS6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BT_BS6";
            this.Load += new System.EventHandler(this.BT_BS6_Load);
            this.grbTT.ResumeLayout(false);
            this.grbTT.PerformLayout();
            this.grbSapXep.ResumeLayout(false);
            this.grbSapXep.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTTVTVL;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.CheckedListBox clbDanhMuc;
        private System.Windows.Forms.GroupBox grbTT;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblTenVT;
        private System.Windows.Forms.Label lblMaVT;
        private System.Windows.Forms.GroupBox grbSapXep;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.RadioButton rdbtnGiam;
        private System.Windows.Forms.RadioButton rdbtnTang;
        private System.Windows.Forms.Label lblLKNV;
        private System.Windows.Forms.ListView lstvNhanVien;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colPhongBan;
        private System.Windows.Forms.ColumnHeader colLuong;
    }
}