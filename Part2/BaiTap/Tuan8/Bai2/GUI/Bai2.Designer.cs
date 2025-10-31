namespace Tuan8.Bai2.GUI
{
    partial class Bai2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai2));
            this.tvwPhongBan = new System.Windows.Forms.TreeView();
            this.lblDMSV = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblPhai = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblNoiSinh = new System.Windows.Forms.Label();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.lblTongNam = new System.Windows.Forms.Label();
            this.lblTongNu = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.cbbPhai = new System.Windows.Forms.ComboBox();
            this.cbbTenKhoa = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dgvDMSV = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNhapFileExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMSV)).BeginInit();
            this.SuspendLayout();
            // 
            // tvwPhongBan
            // 
            this.tvwPhongBan.ImageIndex = 0;
            this.tvwPhongBan.ImageList = this.imageList1;
            this.tvwPhongBan.Location = new System.Drawing.Point(12, 69);
            this.tvwPhongBan.Name = "tvwPhongBan";
            this.tvwPhongBan.SelectedImageIndex = 0;
            this.tvwPhongBan.Size = new System.Drawing.Size(251, 295);
            this.tvwPhongBan.TabIndex = 0;
            this.tvwPhongBan.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwPhongBan_AfterSelect);
            // 
            // lblDMSV
            // 
            this.lblDMSV.AutoSize = true;
            this.lblDMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMSV.Location = new System.Drawing.Point(347, 9);
            this.lblDMSV.Name = "lblDMSV";
            this.lblDMSV.Size = new System.Drawing.Size(282, 29);
            this.lblDMSV.TabIndex = 1;
            this.lblDMSV.Text = "DANH MỤC SINH VIÊN";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(313, 69);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(63, 22);
            this.lblMaSV.TabIndex = 2;
            this.lblMaSV.Text = "Mã SV";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(313, 120);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(63, 22);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblPhai
            // 
            this.lblPhai.AutoSize = true;
            this.lblPhai.Location = new System.Drawing.Point(313, 176);
            this.lblPhai.Name = "lblPhai";
            this.lblPhai.Size = new System.Drawing.Size(46, 22);
            this.lblPhai.TabIndex = 4;
            this.lblPhai.Text = "Phái";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(313, 230);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(90, 22);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblNoiSinh
            // 
            this.lblNoiSinh.AutoSize = true;
            this.lblNoiSinh.Location = new System.Drawing.Point(313, 284);
            this.lblNoiSinh.Name = "lblNoiSinh";
            this.lblNoiSinh.Size = new System.Drawing.Size(75, 22);
            this.lblNoiSinh.TabIndex = 6;
            this.lblNoiSinh.Text = "Nơi sinh";
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(313, 342);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(86, 22);
            this.lblTenKhoa.TabIndex = 7;
            this.lblTenKhoa.Text = "Tên khoa";
            // 
            // lblTongNam
            // 
            this.lblTongNam.AutoSize = true;
            this.lblTongNam.Location = new System.Drawing.Point(66, 392);
            this.lblTongNam.Name = "lblTongNam";
            this.lblTongNam.Size = new System.Drawing.Size(177, 22);
            this.lblTongNam.TabIndex = 8;
            this.lblTongNam.Text = "Tổng sinh viên nam: ";
            // 
            // lblTongNu
            // 
            this.lblTongNu.AutoSize = true;
            this.lblTongNu.Location = new System.Drawing.Point(538, 392);
            this.lblTongNu.Name = "lblTongNu";
            this.lblTongNu.Size = new System.Drawing.Size(187, 22);
            this.lblTongNu.TabIndex = 9;
            this.lblTongNu.Text = "Tổng số sinh viên nữ: ";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(417, 63);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(181, 28);
            this.txtMaSV.TabIndex = 10;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(417, 114);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(212, 28);
            this.txtHo.TabIndex = 11;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(666, 114);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(105, 28);
            this.txtTen.TabIndex = 12;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(417, 278);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(181, 28);
            this.txtNoiSinh.TabIndex = 13;
            // 
            // cbbPhai
            // 
            this.cbbPhai.FormattingEnabled = true;
            this.cbbPhai.Location = new System.Drawing.Point(417, 168);
            this.cbbPhai.Name = "cbbPhai";
            this.cbbPhai.Size = new System.Drawing.Size(167, 30);
            this.cbbPhai.TabIndex = 14;
            // 
            // cbbTenKhoa
            // 
            this.cbbTenKhoa.FormattingEnabled = true;
            this.cbbTenKhoa.Location = new System.Drawing.Point(417, 334);
            this.cbbTenKhoa.Name = "cbbTenKhoa";
            this.cbbTenKhoa.Size = new System.Drawing.Size(212, 30);
            this.cbbTenKhoa.TabIndex = 15;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(417, 224);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(212, 28);
            this.dtpNgaySinh.TabIndex = 16;
            // 
            // btnThem
            // 
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.ImageIndex = 2;
            this.btnThem.ImageList = this.imageList1;
            this.btnThem.Location = new System.Drawing.Point(834, 37);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 44);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(834, 102);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(125, 40);
            this.btnGhi.TabIndex = 18;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.ImageIndex = 4;
            this.btnKhong.Location = new System.Drawing.Point(834, 160);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(125, 44);
            this.btnKhong.TabIndex = 19;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = true;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.ImageIndex = 4;
            this.btnHuy.ImageList = this.imageList1;
            this.btnHuy.Location = new System.Drawing.Point(834, 224);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(125, 44);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.ImageIndex = 3;
            this.btnCapNhat.ImageList = this.imageList1;
            this.btnCapNhat.Location = new System.Drawing.Point(834, 284);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(125, 44);
            this.btnCapNhat.TabIndex = 21;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // dgvDMSV
            // 
            this.dgvDMSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMSV.Location = new System.Drawing.Point(12, 432);
            this.dgvDMSV.Name = "dgvDMSV";
            this.dgvDMSV.RowHeadersWidth = 51;
            this.dgvDMSV.RowTemplate.Height = 24;
            this.dgvDMSV.Size = new System.Drawing.Size(947, 175);
            this.dgvDMSV.TabIndex = 22;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "online-learning.png");
            this.imageList1.Images.SetKeyName(1, "student.png");
            this.imageList1.Images.SetKeyName(2, "plus.png");
            this.imageList1.Images.SetKeyName(3, "update.png");
            this.imageList1.Images.SetKeyName(4, "delete.png");
            // 
            // btnNhapFileExcel
            // 
            this.btnNhapFileExcel.Location = new System.Drawing.Point(798, 342);
            this.btnNhapFileExcel.Name = "btnNhapFileExcel";
            this.btnNhapFileExcel.Size = new System.Drawing.Size(161, 41);
            this.btnNhapFileExcel.TabIndex = 23;
            this.btnNhapFileExcel.Text = "Nhập từ file Excel";
            this.btnNhapFileExcel.UseVisualStyleBackColor = true;
            this.btnNhapFileExcel.Click += new System.EventHandler(this.btnNhapFileExcel_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 619);
            this.Controls.Add(this.btnNhapFileExcel);
            this.Controls.Add(this.dgvDMSV);
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
            this.Controls.Add(this.lblTongNu);
            this.Controls.Add(this.lblTongNam);
            this.Controls.Add(this.lblTenKhoa);
            this.Controls.Add(this.lblNoiSinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblPhai);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.lblDMSV);
            this.Controls.Add(this.tvwPhongBan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai2";
            this.Load += new System.EventHandler(this.Bai2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvwPhongBan;
        private System.Windows.Forms.Label lblDMSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblPhai;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblNoiSinh;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.Label lblTongNam;
        private System.Windows.Forms.Label lblTongNu;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.ComboBox cbbPhai;
        private System.Windows.Forms.ComboBox cbbTenKhoa;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dgvDMSV;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnNhapFileExcel;
    }
}