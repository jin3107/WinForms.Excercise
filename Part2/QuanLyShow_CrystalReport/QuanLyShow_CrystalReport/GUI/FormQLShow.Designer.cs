namespace QuanLyShow_CrystalReport.GUI
{
    partial class FormQLShow
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
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDSShow = new System.Windows.Forms.Label();
            this.tvwDiaChiSanKhau = new System.Windows.Forms.TreeView();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.picCaSi = new System.Windows.Forms.PictureBox();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.cbbCaSiDongHanh = new System.Windows.Forms.ComboBox();
            this.cbbCaSiChinh = new System.Windows.Forms.ComboBox();
            this.txtGioDB = new System.Windows.Forms.TextBox();
            this.txtMaShow = new System.Windows.Forms.TextBox();
            this.lbGioBD = new System.Windows.Forms.Label();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.lblCaSiDongHanh = new System.Windows.Forms.Label();
            this.lblCaSiChinh = new System.Windows.Forms.Label();
            this.lblMaShow = new System.Windows.Forms.Label();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.lblTongsoCS = new System.Windows.Forms.Label();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(397, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TICKET\'S BOX SHOW";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(12, 39);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(133, 20);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Địa chỉ sân khấu";
            // 
            // lblDSShow
            // 
            this.lblDSShow.AutoSize = true;
            this.lblDSShow.Location = new System.Drawing.Point(259, 324);
            this.lblDSShow.Name = "lblDSShow";
            this.lblDSShow.Size = new System.Drawing.Size(194, 20);
            this.lblDSShow.TabIndex = 2;
            this.lblDSShow.Text = "Danh sách các show tại ";
            // 
            // tvwDiaChiSanKhau
            // 
            this.tvwDiaChiSanKhau.Location = new System.Drawing.Point(16, 62);
            this.tvwDiaChiSanKhau.Name = "tvwDiaChiSanKhau";
            this.tvwDiaChiSanKhau.Size = new System.Drawing.Size(241, 444);
            this.tvwDiaChiSanKhau.TabIndex = 3;
            this.tvwDiaChiSanKhau.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwDiaChiSanKhau_AfterSelect);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.picCaSi);
            this.grbThongTin.Controls.Add(this.btnInBaoCao);
            this.grbThongTin.Controls.Add(this.btnXoa);
            this.grbThongTin.Controls.Add(this.btnKhong);
            this.grbThongTin.Controls.Add(this.btnGhi);
            this.grbThongTin.Controls.Add(this.btnThem);
            this.grbThongTin.Controls.Add(this.dtpNgayBD);
            this.grbThongTin.Controls.Add(this.cbbCaSiDongHanh);
            this.grbThongTin.Controls.Add(this.cbbCaSiChinh);
            this.grbThongTin.Controls.Add(this.txtGioDB);
            this.grbThongTin.Controls.Add(this.txtMaShow);
            this.grbThongTin.Controls.Add(this.lbGioBD);
            this.grbThongTin.Controls.Add(this.lblNgayBD);
            this.grbThongTin.Controls.Add(this.lblCaSiDongHanh);
            this.grbThongTin.Controls.Add(this.lblCaSiChinh);
            this.grbThongTin.Controls.Add(this.lblMaShow);
            this.grbThongTin.Location = new System.Drawing.Point(263, 62);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(804, 230);
            this.grbThongTin.TabIndex = 4;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin các show diễn";
            // 
            // picCaSi
            // 
            this.picCaSi.Location = new System.Drawing.Point(454, 33);
            this.picCaSi.Name = "picCaSi";
            this.picCaSi.Size = new System.Drawing.Size(182, 144);
            this.picCaSi.TabIndex = 15;
            this.picCaSi.TabStop = false;
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Location = new System.Drawing.Point(659, 183);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(115, 36);
            this.btnInBaoCao.TabIndex = 14;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(680, 141);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 36);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.Location = new System.Drawing.Point(680, 99);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(94, 36);
            this.btnKhong.TabIndex = 12;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = true;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(680, 57);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(94, 36);
            this.btnGhi.TabIndex = 11;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(680, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 36);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(157, 144);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(214, 27);
            this.dtpNgayBD.TabIndex = 9;
            // 
            // cbbCaSiDongHanh
            // 
            this.cbbCaSiDongHanh.FormattingEnabled = true;
            this.cbbCaSiDongHanh.Location = new System.Drawing.Point(157, 106);
            this.cbbCaSiDongHanh.Name = "cbbCaSiDongHanh";
            this.cbbCaSiDongHanh.Size = new System.Drawing.Size(214, 28);
            this.cbbCaSiDongHanh.TabIndex = 8;
            // 
            // cbbCaSiChinh
            // 
            this.cbbCaSiChinh.FormattingEnabled = true;
            this.cbbCaSiChinh.Location = new System.Drawing.Point(157, 67);
            this.cbbCaSiChinh.Name = "cbbCaSiChinh";
            this.cbbCaSiChinh.Size = new System.Drawing.Size(214, 28);
            this.cbbCaSiChinh.TabIndex = 7;
            // 
            // txtGioDB
            // 
            this.txtGioDB.Location = new System.Drawing.Point(157, 184);
            this.txtGioDB.Name = "txtGioDB";
            this.txtGioDB.Size = new System.Drawing.Size(214, 27);
            this.txtGioDB.TabIndex = 6;
            // 
            // txtMaShow
            // 
            this.txtMaShow.Location = new System.Drawing.Point(157, 33);
            this.txtMaShow.Name = "txtMaShow";
            this.txtMaShow.Size = new System.Drawing.Size(214, 27);
            this.txtMaShow.TabIndex = 5;
            // 
            // lbGioBD
            // 
            this.lbGioBD.AutoSize = true;
            this.lbGioBD.Location = new System.Drawing.Point(6, 191);
            this.lbGioBD.Name = "lbGioBD";
            this.lbGioBD.Size = new System.Drawing.Size(95, 20);
            this.lbGioBD.TabIndex = 4;
            this.lbGioBD.Text = "Giờ bắt đầu";
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Location = new System.Drawing.Point(6, 151);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(119, 20);
            this.lblNgayBD.TabIndex = 3;
            this.lblNgayBD.Text = "Ngày biễu diễn";
            // 
            // lblCaSiDongHanh
            // 
            this.lblCaSiDongHanh.AutoSize = true;
            this.lblCaSiDongHanh.Location = new System.Drawing.Point(6, 114);
            this.lblCaSiDongHanh.Name = "lblCaSiDongHanh";
            this.lblCaSiDongHanh.Size = new System.Drawing.Size(130, 20);
            this.lblCaSiDongHanh.TabIndex = 2;
            this.lblCaSiDongHanh.Text = "Ca sĩ đồng hành";
            // 
            // lblCaSiChinh
            // 
            this.lblCaSiChinh.AutoSize = true;
            this.lblCaSiChinh.Location = new System.Drawing.Point(6, 75);
            this.lblCaSiChinh.Name = "lblCaSiChinh";
            this.lblCaSiChinh.Size = new System.Drawing.Size(93, 20);
            this.lblCaSiChinh.TabIndex = 1;
            this.lblCaSiChinh.Text = "Ca sĩ chính";
            // 
            // lblMaShow
            // 
            this.lblMaShow.AutoSize = true;
            this.lblMaShow.Location = new System.Drawing.Point(6, 40);
            this.lblMaShow.Name = "lblMaShow";
            this.lblMaShow.Size = new System.Drawing.Size(76, 20);
            this.lblMaShow.TabIndex = 0;
            this.lblMaShow.Text = "Mã show";
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(267, 361);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 24;
            this.dgvShow.Size = new System.Drawing.Size(800, 145);
            this.dgvShow.TabIndex = 5;
            // 
            // lblTongsoCS
            // 
            this.lblTongsoCS.AutoSize = true;
            this.lblTongsoCS.Location = new System.Drawing.Point(845, 324);
            this.lblTongsoCS.Name = "lblTongsoCS";
            this.lblTongsoCS.Size = new System.Drawing.Size(192, 20);
            this.lblTongsoCS.TabIndex = 6;
            this.lblTongsoCS.Text = "Tổng số ca sĩ biểu diễn: ";
            // 
            // FormQLShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 518);
            this.Controls.Add(this.lblTongsoCS);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.tvwDiaChiSanKhau);
            this.Controls.Add(this.lblDSShow);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQLShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLShow";
            this.Load += new System.EventHandler(this.FormQLShow_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaSi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDSShow;
        private System.Windows.Forms.TreeView tvwDiaChiSanKhau;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Label lbGioBD;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.Label lblCaSiDongHanh;
        private System.Windows.Forms.Label lblCaSiChinh;
        private System.Windows.Forms.Label lblMaShow;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.ComboBox cbbCaSiDongHanh;
        private System.Windows.Forms.ComboBox cbbCaSiChinh;
        private System.Windows.Forms.TextBox txtGioDB;
        private System.Windows.Forms.TextBox txtMaShow;
        private System.Windows.Forms.PictureBox picCaSi;
        private System.Windows.Forms.Label lblTongsoCS;
    }
}