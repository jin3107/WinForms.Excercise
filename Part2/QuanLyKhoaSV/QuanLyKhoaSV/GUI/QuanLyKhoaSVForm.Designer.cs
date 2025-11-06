namespace QuanLyKhoaSV.GUI
{
    partial class QuanLyKhoaSVForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyKhoaSVForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tvwPhongBan = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnNhapFileExcel = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbTenKhoa = new System.Windows.Forms.ComboBox();
            this.cbbPhai = new System.Windows.Forms.ComboBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.lblNoiSinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblPhai = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.dgvDMSV = new System.Windows.Forms.DataGridView();
            this.lblTongNu = new System.Windows.Forms.Label();
            this.lblTongNam = new System.Windows.Forms.Label();
            this.btnXuatFileExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMSV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(332, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH MỤC SINH VIÊN";
            // 
            // tvwPhongBan
            // 
            this.tvwPhongBan.ImageIndex = 0;
            this.tvwPhongBan.ImageList = this.imgList;
            this.tvwPhongBan.Location = new System.Drawing.Point(12, 57);
            this.tvwPhongBan.Name = "tvwPhongBan";
            this.tvwPhongBan.SelectedImageIndex = 0;
            this.tvwPhongBan.Size = new System.Drawing.Size(258, 243);
            this.tvwPhongBan.TabIndex = 1;
            this.tvwPhongBan.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwPhongBan_AfterSelect);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "department.png");
            this.imgList.Images.SetKeyName(1, "student.png");
            this.imgList.Images.SetKeyName(2, "add.png");
            this.imgList.Images.SetKeyName(3, "update.png");
            this.imgList.Images.SetKeyName(4, "delete.png");
            // 
            // btnNhapFileExcel
            // 
            this.btnNhapFileExcel.Location = new System.Drawing.Point(633, 262);
            this.btnNhapFileExcel.Name = "btnNhapFileExcel";
            this.btnNhapFileExcel.Size = new System.Drawing.Size(163, 38);
            this.btnNhapFileExcel.TabIndex = 43;
            this.btnNhapFileExcel.Text = "Nhập từ file Excel";
            this.btnNhapFileExcel.UseVisualStyleBackColor = true;
            this.btnNhapFileExcel.Click += new System.EventHandler(this.btnNhapFileExcel_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.ImageIndex = 3;
            this.btnCapNhat.ImageList = this.imgList;
            this.btnCapNhat.Location = new System.Drawing.Point(802, 216);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(138, 40);
            this.btnCapNhat.TabIndex = 42;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.ImageIndex = 4;
            this.btnHuy.ImageList = this.imgList;
            this.btnHuy.Location = new System.Drawing.Point(802, 171);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(138, 39);
            this.btnHuy.TabIndex = 41;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.ImageIndex = 4;
            this.btnKhong.Location = new System.Drawing.Point(802, 124);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(138, 41);
            this.btnKhong.TabIndex = 40;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = true;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(802, 79);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(138, 39);
            this.btnGhi.TabIndex = 39;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.ImageIndex = 2;
            this.btnThem.ImageList = this.imgList;
            this.btnThem.Location = new System.Drawing.Point(802, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 42);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(402, 171);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(212, 28);
            this.dtpNgaySinh.TabIndex = 37;
            // 
            // cbbTenKhoa
            // 
            this.cbbTenKhoa.FormattingEnabled = true;
            this.cbbTenKhoa.Location = new System.Drawing.Point(402, 259);
            this.cbbTenKhoa.Name = "cbbTenKhoa";
            this.cbbTenKhoa.Size = new System.Drawing.Size(212, 30);
            this.cbbTenKhoa.TabIndex = 36;
            // 
            // cbbPhai
            // 
            this.cbbPhai.FormattingEnabled = true;
            this.cbbPhai.Location = new System.Drawing.Point(402, 132);
            this.cbbPhai.Name = "cbbPhai";
            this.cbbPhai.Size = new System.Drawing.Size(181, 30);
            this.cbbPhai.TabIndex = 35;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(402, 216);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(212, 28);
            this.txtNoiSinh.TabIndex = 34;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(641, 90);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(113, 28);
            this.txtTen.TabIndex = 33;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(402, 90);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(212, 28);
            this.txtHo.TabIndex = 32;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(402, 51);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(181, 28);
            this.txtMaSV.TabIndex = 31;
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(298, 267);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(86, 22);
            this.lblTenKhoa.TabIndex = 30;
            this.lblTenKhoa.Text = "Tên khoa";
            // 
            // lblNoiSinh
            // 
            this.lblNoiSinh.AutoSize = true;
            this.lblNoiSinh.Location = new System.Drawing.Point(298, 222);
            this.lblNoiSinh.Name = "lblNoiSinh";
            this.lblNoiSinh.Size = new System.Drawing.Size(75, 22);
            this.lblNoiSinh.TabIndex = 29;
            this.lblNoiSinh.Text = "Nơi sinh";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(298, 177);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(90, 22);
            this.lblNgaySinh.TabIndex = 28;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblPhai
            // 
            this.lblPhai.AutoSize = true;
            this.lblPhai.Location = new System.Drawing.Point(298, 140);
            this.lblPhai.Name = "lblPhai";
            this.lblPhai.Size = new System.Drawing.Size(46, 22);
            this.lblPhai.TabIndex = 27;
            this.lblPhai.Text = "Phái";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(298, 96);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(63, 22);
            this.lblHoTen.TabIndex = 26;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(298, 57);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(63, 22);
            this.lblMaSV.TabIndex = 25;
            this.lblMaSV.Text = "Mã SV";
            // 
            // dgvDMSV
            // 
            this.dgvDMSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMSV.Location = new System.Drawing.Point(12, 377);
            this.dgvDMSV.Name = "dgvDMSV";
            this.dgvDMSV.RowHeadersWidth = 51;
            this.dgvDMSV.RowTemplate.Height = 24;
            this.dgvDMSV.Size = new System.Drawing.Size(924, 175);
            this.dgvDMSV.TabIndex = 46;
            // 
            // lblTongNu
            // 
            this.lblTongNu.AutoSize = true;
            this.lblTongNu.Location = new System.Drawing.Point(637, 330);
            this.lblTongNu.Name = "lblTongNu";
            this.lblTongNu.Size = new System.Drawing.Size(187, 22);
            this.lblTongNu.TabIndex = 45;
            this.lblTongNu.Text = "Tổng số sinh viên nữ: ";
            // 
            // lblTongNam
            // 
            this.lblTongNam.AutoSize = true;
            this.lblTongNam.Location = new System.Drawing.Point(93, 330);
            this.lblTongNam.Name = "lblTongNam";
            this.lblTongNam.Size = new System.Drawing.Size(177, 22);
            this.lblTongNam.TabIndex = 44;
            this.lblTongNam.Text = "Tổng sinh viên nam: ";
            // 
            // btnXuatFileExcel
            // 
            this.btnXuatFileExcel.Location = new System.Drawing.Point(802, 262);
            this.btnXuatFileExcel.Name = "btnXuatFileExcel";
            this.btnXuatFileExcel.Size = new System.Drawing.Size(138, 38);
            this.btnXuatFileExcel.TabIndex = 47;
            this.btnXuatFileExcel.Text = "Xuất file Excel";
            this.btnXuatFileExcel.UseVisualStyleBackColor = true;
            this.btnXuatFileExcel.Click += new System.EventHandler(this.btnXuatFileExcel_Click);
            // 
            // QuanLyKhoaSVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 566);
            this.Controls.Add(this.btnXuatFileExcel);
            this.Controls.Add(this.dgvDMSV);
            this.Controls.Add(this.lblTongNu);
            this.Controls.Add(this.lblTongNam);
            this.Controls.Add(this.btnNhapFileExcel);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cbbTenKhoa);
            this.Controls.Add(this.cbbPhai);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblTenKhoa);
            this.Controls.Add(this.lblNoiSinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblPhai);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.tvwPhongBan);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyKhoaSVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyKhoaSVForm";
            this.Load += new System.EventHandler(this.QuanLyKhoaSVForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TreeView tvwPhongBan;
        private System.Windows.Forms.Button btnNhapFileExcel;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbbTenKhoa;
        private System.Windows.Forms.ComboBox cbbPhai;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.Label lblNoiSinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblPhai;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.DataGridView dgvDMSV;
        private System.Windows.Forms.Label lblTongNu;
        private System.Windows.Forms.Label lblTongNam;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Button btnXuatFileExcel;
    }
}