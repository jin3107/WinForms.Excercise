namespace QuanLyDanhMucNhanVien
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDMPB = new System.Windows.Forms.Label();
            this.tvwPhongBan = new System.Windows.Forms.TreeView();
            this.lblTruongPhong = new System.Windows.Forms.Label();
            this.grbTTNV = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.dtpNgayTuyen = new System.Windows.Forms.DateTimePicker();
            this.cbbPhongBan = new System.Windows.Forms.ComboBox();
            this.cbbBac = new System.Windows.Forms.ComboBox();
            this.cbbNgach = new System.Windows.Forms.ComboBox();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblHeSoLuong = new System.Windows.Forms.Label();
            this.lblBac = new System.Windows.Forms.Label();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.lblPhai = new System.Windows.Forms.Label();
            this.lblNgayTuyen = new System.Windows.Forms.Label();
            this.lblNganh = new System.Windows.Forms.Label();
            this.lblTenCV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtTruongPhong = new System.Windows.Forms.TextBox();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.picNhanVien = new System.Windows.Forms.PictureBox();
            this.grbTTNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(367, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(293, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // lblDMPB
            // 
            this.lblDMPB.AutoSize = true;
            this.lblDMPB.Location = new System.Drawing.Point(12, 46);
            this.lblDMPB.Name = "lblDMPB";
            this.lblDMPB.Size = new System.Drawing.Size(214, 22);
            this.lblDMPB.TabIndex = 1;
            this.lblDMPB.Text = "Danh mục các phòng ban";
            // 
            // tvwPhongBan
            // 
            this.tvwPhongBan.Location = new System.Drawing.Point(16, 71);
            this.tvwPhongBan.Name = "tvwPhongBan";
            this.tvwPhongBan.Size = new System.Drawing.Size(224, 359);
            this.tvwPhongBan.TabIndex = 2;
            this.tvwPhongBan.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwPhongBan_AfterSelect);
            // 
            // lblTruongPhong
            // 
            this.lblTruongPhong.AutoSize = true;
            this.lblTruongPhong.Location = new System.Drawing.Point(12, 457);
            this.lblTruongPhong.Name = "lblTruongPhong";
            this.lblTruongPhong.Size = new System.Drawing.Size(128, 22);
            this.lblTruongPhong.TabIndex = 3;
            this.lblTruongPhong.Text = "Trưởng phòng:";
            // 
            // grbTTNV
            // 
            this.grbTTNV.Controls.Add(this.btnHuy);
            this.grbTTNV.Controls.Add(this.btnCapNhat);
            this.grbTTNV.Controls.Add(this.btnGhi);
            this.grbTTNV.Controls.Add(this.btnThem);
            this.grbTTNV.Controls.Add(this.rbtnNu);
            this.grbTTNV.Controls.Add(this.rbtnNam);
            this.grbTTNV.Controls.Add(this.dtpNgayTuyen);
            this.grbTTNV.Controls.Add(this.cbbPhongBan);
            this.grbTTNV.Controls.Add(this.cbbBac);
            this.grbTTNV.Controls.Add(this.cbbNgach);
            this.grbTTNV.Controls.Add(this.txtHeSoLuong);
            this.grbTTNV.Controls.Add(this.txtTenCV);
            this.grbTTNV.Controls.Add(this.txtHoTen);
            this.grbTTNV.Controls.Add(this.txtMaNV);
            this.grbTTNV.Controls.Add(this.lblHeSoLuong);
            this.grbTTNV.Controls.Add(this.lblBac);
            this.grbTTNV.Controls.Add(this.lblPhongBan);
            this.grbTTNV.Controls.Add(this.lblPhai);
            this.grbTTNV.Controls.Add(this.lblNgayTuyen);
            this.grbTTNV.Controls.Add(this.lblNganh);
            this.grbTTNV.Controls.Add(this.lblTenCV);
            this.grbTTNV.Controls.Add(this.lblHoTen);
            this.grbTTNV.Controls.Add(this.lblMaNV);
            this.grbTTNV.Location = new System.Drawing.Point(403, 71);
            this.grbTTNV.Name = "grbTTNV";
            this.grbTTNV.Size = new System.Drawing.Size(651, 243);
            this.grbTTNV.TabIndex = 4;
            this.grbTTNV.TabStop = false;
            this.grbTTNV.Text = "Thông tin nhân viên";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(502, 192);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(97, 39);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(348, 192);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(97, 39);
            this.btnCapNhat.TabIndex = 21;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(188, 192);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(97, 39);
            this.btnGhi.TabIndex = 20;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(38, 192);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 39);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(533, 67);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(54, 26);
            this.rbtnNu.TabIndex = 18;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(410, 67);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(68, 26);
            this.rbtnNam.TabIndex = 17;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgayTuyen
            // 
            this.dtpNgayTuyen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTuyen.Location = new System.Drawing.Point(414, 27);
            this.dtpNgayTuyen.Name = "dtpNgayTuyen";
            this.dtpNgayTuyen.Size = new System.Drawing.Size(173, 28);
            this.dtpNgayTuyen.TabIndex = 16;
            // 
            // cbbPhongBan
            // 
            this.cbbPhongBan.FormattingEnabled = true;
            this.cbbPhongBan.Location = new System.Drawing.Point(414, 102);
            this.cbbPhongBan.Name = "cbbPhongBan";
            this.cbbPhongBan.Size = new System.Drawing.Size(173, 30);
            this.cbbPhongBan.TabIndex = 15;
            // 
            // cbbBac
            // 
            this.cbbBac.FormattingEnabled = true;
            this.cbbBac.Location = new System.Drawing.Point(307, 142);
            this.cbbBac.Name = "cbbBac";
            this.cbbBac.Size = new System.Drawing.Size(92, 30);
            this.cbbBac.TabIndex = 14;
            this.cbbBac.SelectedIndexChanged += new System.EventHandler(this.cbbBac_SelectedIndexChanged);
            // 
            // cbbNgach
            // 
            this.cbbNgach.FormattingEnabled = true;
            this.cbbNgach.Location = new System.Drawing.Point(103, 142);
            this.cbbNgach.Name = "cbbNgach";
            this.cbbNgach.Size = new System.Drawing.Size(151, 30);
            this.cbbNgach.TabIndex = 13;
            this.cbbNgach.SelectedIndexChanged += new System.EventHandler(this.cbbNgach_SelectedIndexChanged);
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Location = new System.Drawing.Point(529, 147);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(101, 28);
            this.txtHeSoLuong.TabIndex = 12;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(103, 99);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(154, 28);
            this.txtTenCV.TabIndex = 11;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(103, 65);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(198, 28);
            this.txtHoTen.TabIndex = 10;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(103, 27);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(154, 28);
            this.txtMaNV.TabIndex = 9;
            // 
            // lblHeSoLuong
            // 
            this.lblHeSoLuong.AutoSize = true;
            this.lblHeSoLuong.Location = new System.Drawing.Point(417, 153);
            this.lblHeSoLuong.Name = "lblHeSoLuong";
            this.lblHeSoLuong.Size = new System.Drawing.Size(106, 22);
            this.lblHeSoLuong.TabIndex = 8;
            this.lblHeSoLuong.Text = "Hệ số lương";
            // 
            // lblBac
            // 
            this.lblBac.AutoSize = true;
            this.lblBac.Location = new System.Drawing.Point(260, 150);
            this.lblBac.Name = "lblBac";
            this.lblBac.Size = new System.Drawing.Size(41, 22);
            this.lblBac.TabIndex = 7;
            this.lblBac.Text = "Bậc";
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Location = new System.Drawing.Point(307, 110);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(97, 22);
            this.lblPhongBan.TabIndex = 6;
            this.lblPhongBan.Text = "Phòng ban";
            // 
            // lblPhai
            // 
            this.lblPhai.AutoSize = true;
            this.lblPhai.Location = new System.Drawing.Point(307, 71);
            this.lblPhai.Name = "lblPhai";
            this.lblPhai.Size = new System.Drawing.Size(46, 22);
            this.lblPhai.TabIndex = 5;
            this.lblPhai.Text = "Phái";
            // 
            // lblNgayTuyen
            // 
            this.lblNgayTuyen.AutoSize = true;
            this.lblNgayTuyen.Location = new System.Drawing.Point(307, 35);
            this.lblNgayTuyen.Name = "lblNgayTuyen";
            this.lblNgayTuyen.Size = new System.Drawing.Size(101, 22);
            this.lblNgayTuyen.TabIndex = 4;
            this.lblNgayTuyen.Text = "Ngày tuyển";
            // 
            // lblNganh
            // 
            this.lblNganh.AutoSize = true;
            this.lblNganh.Location = new System.Drawing.Point(6, 153);
            this.lblNganh.Name = "lblNganh";
            this.lblNganh.Size = new System.Drawing.Size(62, 22);
            this.lblNganh.TabIndex = 3;
            this.lblNganh.Text = "Ngạch";
            // 
            // lblTenCV
            // 
            this.lblTenCV.AutoSize = true;
            this.lblTenCV.Location = new System.Drawing.Point(6, 110);
            this.lblTenCV.Name = "lblTenCV";
            this.lblTenCV.Size = new System.Drawing.Size(72, 22);
            this.lblTenCV.TabIndex = 2;
            this.lblTenCV.Text = "Tên CV";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(6, 71);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(63, 22);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(6, 35);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(64, 22);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã NV";
            // 
            // txtTruongPhong
            // 
            this.txtTruongPhong.Location = new System.Drawing.Point(167, 451);
            this.txtTruongPhong.Name = "txtTruongPhong";
            this.txtTruongPhong.Size = new System.Drawing.Size(154, 28);
            this.txtTruongPhong.TabIndex = 5;
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Location = new System.Drawing.Point(399, 317);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(214, 22);
            this.lblTongSo.TabIndex = 6;
            this.lblTongSo.Text = "Tổng số nhân viên phòng";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(403, 342);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(651, 147);
            this.dgvNhanVien.TabIndex = 7;
            // 
            // picNhanVien
            // 
            this.picNhanVien.Location = new System.Drawing.Point(265, 106);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(117, 117);
            this.picNhanVien.TabIndex = 8;
            this.picNhanVien.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 501);
            this.Controls.Add(this.picNhanVien);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.txtTruongPhong);
            this.Controls.Add(this.grbTTNV);
            this.Controls.Add(this.lblTruongPhong);
            this.Controls.Add(this.tvwPhongBan);
            this.Controls.Add(this.lblDMPB);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbTTNV.ResumeLayout(false);
            this.grbTTNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDMPB;
        private System.Windows.Forms.TreeView tvwPhongBan;
        private System.Windows.Forms.Label lblTruongPhong;
        private System.Windows.Forms.GroupBox grbTTNV;
        private System.Windows.Forms.Label lblBac;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.Label lblPhai;
        private System.Windows.Forms.Label lblNgayTuyen;
        private System.Windows.Forms.Label lblNganh;
        private System.Windows.Forms.Label lblTenCV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.ComboBox cbbPhongBan;
        private System.Windows.Forms.ComboBox cbbBac;
        private System.Windows.Forms.ComboBox cbbNgach;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblHeSoLuong;
        private System.Windows.Forms.TextBox txtTruongPhong;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.DateTimePicker dtpNgayTuyen;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.PictureBox picNhanVien;
    }
}

