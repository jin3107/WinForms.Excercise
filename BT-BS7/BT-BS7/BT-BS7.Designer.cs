namespace BT_BS7
{
    partial class BT_BS7
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
            this.lblDMNV = new System.Windows.Forms.Label();
            this.grbTTCT = new System.Windows.Forms.GroupBox();
            this.cbbBangCap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbTTC = new System.Windows.Forms.GroupBox();
            this.lstvTTC = new System.Windows.Forms.ListView();
            this.colMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbTTCT.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.grbTTC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDMNV
            // 
            this.lblDMNV.AutoSize = true;
            this.lblDMNV.BackColor = System.Drawing.Color.Transparent;
            this.lblDMNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMNV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDMNV.Location = new System.Drawing.Point(377, 9);
            this.lblDMNV.Name = "lblDMNV";
            this.lblDMNV.Size = new System.Drawing.Size(401, 38);
            this.lblDMNV.TabIndex = 0;
            this.lblDMNV.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // grbTTCT
            // 
            this.grbTTCT.Controls.Add(this.cbbBangCap);
            this.grbTTCT.Controls.Add(this.label1);
            this.grbTTCT.Controls.Add(this.txtDiaChi);
            this.grbTTCT.Controls.Add(this.txtDienThoai);
            this.grbTTCT.Controls.Add(this.dtpNgaySinh);
            this.grbTTCT.Controls.Add(this.txtHoTen);
            this.grbTTCT.Controls.Add(this.lblDiaChi);
            this.grbTTCT.Controls.Add(this.lblDienThoai);
            this.grbTTCT.Controls.Add(this.lblNgaySinh);
            this.grbTTCT.Controls.Add(this.lblHoTen);
            this.grbTTCT.Location = new System.Drawing.Point(12, 59);
            this.grbTTCT.Name = "grbTTCT";
            this.grbTTCT.Size = new System.Drawing.Size(1082, 208);
            this.grbTTCT.TabIndex = 1;
            this.grbTTCT.TabStop = false;
            this.grbTTCT.Text = "Thông tin chi tiết";
            // 
            // cbbBangCap
            // 
            this.cbbBangCap.FormattingEnabled = true;
            this.cbbBangCap.Location = new System.Drawing.Point(722, 80);
            this.cbbBangCap.Name = "cbbBangCap";
            this.cbbBangCap.Size = new System.Drawing.Size(330, 33);
            this.cbbBangCap.TabIndex = 9;
            this.cbbBangCap.SelectedIndexChanged += new System.EventHandler(this.cbbBangCap_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bằng cấp:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(146, 142);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(313, 30);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(722, 36);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(330, 30);
            this.txtDienThoai.TabIndex = 6;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(146, 83);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(313, 30);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(150, 36);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(309, 30);
            this.txtHoTen.TabIndex = 4;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(29, 145);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(82, 25);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Địa chỉ: ";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(592, 41);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(105, 25);
            this.lblDienThoai.TabIndex = 2;
            this.lblDienThoai.Text = "Điện thoại:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(29, 88);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(105, 25);
            this.lblNgaySinh.TabIndex = 1;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(29, 39);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(75, 25);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnHuy);
            this.grbChucNang.Controls.Add(this.btnLuu);
            this.grbChucNang.Controls.Add(this.btnThoat);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Location = new System.Drawing.Point(325, 283);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(769, 96);
            this.grbChucNang.TabIndex = 2;
            this.grbChucNang.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(517, 29);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 52);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(385, 29);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(99, 52);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(650, 29);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 52);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(256, 29);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 52);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(127, 29);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 52);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 52);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbTTC
            // 
            this.grbTTC.Controls.Add(this.lstvTTC);
            this.grbTTC.Location = new System.Drawing.Point(12, 385);
            this.grbTTC.Name = "grbTTC";
            this.grbTTC.Size = new System.Drawing.Size(1082, 292);
            this.grbTTC.TabIndex = 3;
            this.grbTTC.TabStop = false;
            this.grbTTC.Text = "Thông tin chung";
            // 
            // lstvTTC
            // 
            this.lstvTTC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNV,
            this.colHoTen,
            this.colNgaySinh,
            this.colDiaChi,
            this.colDienThoai,
            this.colBC});
            this.lstvTTC.FullRowSelect = true;
            this.lstvTTC.GridLines = true;
            this.lstvTTC.HideSelection = false;
            this.lstvTTC.Location = new System.Drawing.Point(13, 29);
            this.lstvTTC.Name = "lstvTTC";
            this.lstvTTC.Size = new System.Drawing.Size(1054, 246);
            this.lstvTTC.TabIndex = 0;
            this.lstvTTC.UseCompatibleStateImageBehavior = false;
            this.lstvTTC.View = System.Windows.Forms.View.Details;
            this.lstvTTC.SelectedIndexChanged += new System.EventHandler(this.lstvTTC_SelectedIndexChanged);
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "Mã NV";
            this.colMaNV.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 200;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 200;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 300;
            // 
            // colDienThoai
            // 
            this.colDienThoai.Text = "Điện thoại";
            this.colDienThoai.Width = 120;
            // 
            // colBC
            // 
            this.colBC.Text = "Bằng cấp";
            this.colBC.Width = 150;
            // 
            // BT_BS7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1106, 689);
            this.Controls.Add(this.grbTTC);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbTTCT);
            this.Controls.Add(this.lblDMNV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BT_BS7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BT_BS7";
            this.Load += new System.EventHandler(this.BT_BS7_Load);
            this.grbTTCT.ResumeLayout(false);
            this.grbTTCT.PerformLayout();
            this.grbChucNang.ResumeLayout(false);
            this.grbTTC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDMNV;
        private System.Windows.Forms.GroupBox grbTTCT;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbTTC;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.ListView lstvTTC;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colDienThoai;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader colBC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cbbBangCap;
    }
}