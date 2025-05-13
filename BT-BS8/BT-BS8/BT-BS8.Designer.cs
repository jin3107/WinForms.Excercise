namespace BT_BS8
{
    partial class BT_BS8
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
            this.lblTTCD = new System.Windows.Forms.Label();
            this.lblDST = new System.Windows.Forms.Label();
            this.lblHoatDong = new System.Windows.Forms.Label();
            this.lstbDSTinh = new System.Windows.Forms.ListBox();
            this.lstvHoatDongChinh = new System.Windows.Forms.ListView();
            this.colHoatDongChinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDSCD = new System.Windows.Forms.Label();
            this.lstbDSChienDich = new System.Windows.Forms.ListBox();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.dgvCCCD = new System.Windows.Forms.DataGridView();
            this.grbCTCD = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbTCTH = new System.Windows.Forms.ComboBox();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenChienDich = new System.Windows.Forms.TextBox();
            this.txtMaChienDich = new System.Windows.Forms.TextBox();
            this.lblTCTH = new System.Windows.Forms.Label();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTenChienDich = new System.Windows.Forms.Label();
            this.lblMaChienDich = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCCCD)).BeginInit();
            this.grbCTCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTTCD
            // 
            this.lblTTCD.AutoSize = true;
            this.lblTTCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTCD.ForeColor = System.Drawing.Color.Red;
            this.lblTTCD.Location = new System.Drawing.Point(339, 9);
            this.lblTTCD.Name = "lblTTCD";
            this.lblTTCD.Size = new System.Drawing.Size(642, 29);
            this.lblTTCD.TabIndex = 0;
            this.lblTTCD.Text = "THÔNG TIN CÁC CHIẾN DỊCH BẢO VỆ MÔI TRƯỜNG";
            // 
            // lblDST
            // 
            this.lblDST.AutoSize = true;
            this.lblDST.Location = new System.Drawing.Point(12, 69);
            this.lblDST.Name = "lblDST";
            this.lblDST.Size = new System.Drawing.Size(163, 22);
            this.lblDST.TabIndex = 1;
            this.lblDST.Text = "Danh sách các tỉnh";
            // 
            // lblHoatDong
            // 
            this.lblHoatDong.AutoSize = true;
            this.lblHoatDong.Location = new System.Drawing.Point(266, 69);
            this.lblHoatDong.Name = "lblHoatDong";
            this.lblHoatDong.Size = new System.Drawing.Size(224, 22);
            this.lblHoatDong.TabIndex = 2;
            this.lblHoatDong.Text = "Các hoạt động chính ở tỉnh";
            // 
            // lstbDSTinh
            // 
            this.lstbDSTinh.FormattingEnabled = true;
            this.lstbDSTinh.ItemHeight = 22;
            this.lstbDSTinh.Location = new System.Drawing.Point(16, 94);
            this.lstbDSTinh.Name = "lstbDSTinh";
            this.lstbDSTinh.Size = new System.Drawing.Size(248, 180);
            this.lstbDSTinh.TabIndex = 3;
            this.lstbDSTinh.SelectedIndexChanged += new System.EventHandler(this.lstbDSTinh_SelectedIndexChanged);
            // 
            // lstvHoatDongChinh
            // 
            this.lstvHoatDongChinh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHoatDongChinh,
            this.colTrangThai});
            this.lstvHoatDongChinh.FullRowSelect = true;
            this.lstvHoatDongChinh.GridLines = true;
            this.lstvHoatDongChinh.HideSelection = false;
            this.lstvHoatDongChinh.Location = new System.Drawing.Point(270, 94);
            this.lstvHoatDongChinh.Name = "lstvHoatDongChinh";
            this.lstvHoatDongChinh.Size = new System.Drawing.Size(458, 180);
            this.lstvHoatDongChinh.TabIndex = 4;
            this.lstvHoatDongChinh.UseCompatibleStateImageBehavior = false;
            this.lstvHoatDongChinh.View = System.Windows.Forms.View.Details;
            this.lstvHoatDongChinh.SelectedIndexChanged += new System.EventHandler(this.lstvHoatDongChinh_SelectedIndexChanged);
            // 
            // colHoatDongChinh
            // 
            this.colHoatDongChinh.Text = "Hoạt động chính";
            this.colHoatDongChinh.Width = 300;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Text = "Trạng thái";
            this.colTrangThai.Width = 150;
            // 
            // lblDSCD
            // 
            this.lblDSCD.AutoSize = true;
            this.lblDSCD.Location = new System.Drawing.Point(12, 282);
            this.lblDSCD.Name = "lblDSCD";
            this.lblDSCD.Size = new System.Drawing.Size(215, 22);
            this.lblDSCD.TabIndex = 5;
            this.lblDSCD.Text = "Danh sách các chiến dịch";
            // 
            // lstbDSChienDich
            // 
            this.lstbDSChienDich.FormattingEnabled = true;
            this.lstbDSChienDich.ItemHeight = 22;
            this.lstbDSChienDich.Location = new System.Drawing.Point(12, 309);
            this.lstbDSChienDich.Name = "lstbDSChienDich";
            this.lstbDSChienDich.Size = new System.Drawing.Size(248, 180);
            this.lstbDSChienDich.TabIndex = 6;
            this.lstbDSChienDich.SelectedIndexChanged += new System.EventHandler(this.lstbDSChienDich_SelectedIndexChanged);
            // 
            // lblChiTiet
            // 
            this.lblChiTiet.AutoSize = true;
            this.lblChiTiet.Location = new System.Drawing.Point(415, 282);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(152, 22);
            this.lblChiTiet.TabIndex = 7;
            this.lblChiTiet.Text = "Chi tiết chiến dịch";
            // 
            // dgvCCCD
            // 
            this.dgvCCCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCCCD.Location = new System.Drawing.Point(266, 310);
            this.dgvCCCD.Name = "dgvCCCD";
            this.dgvCCCD.RowHeadersWidth = 51;
            this.dgvCCCD.RowTemplate.Height = 24;
            this.dgvCCCD.Size = new System.Drawing.Size(462, 179);
            this.dgvCCCD.TabIndex = 8;
            // 
            // grbCTCD
            // 
            this.grbCTCD.Controls.Add(this.btnXoa);
            this.grbCTCD.Controls.Add(this.btnCapNhat);
            this.grbCTCD.Controls.Add(this.btnThem);
            this.grbCTCD.Controls.Add(this.cbbTCTH);
            this.grbCTCD.Controls.Add(this.dtpNgayKT);
            this.grbCTCD.Controls.Add(this.dtpNgayBD);
            this.grbCTCD.Controls.Add(this.txtMoTa);
            this.grbCTCD.Controls.Add(this.txtTenChienDich);
            this.grbCTCD.Controls.Add(this.txtMaChienDich);
            this.grbCTCD.Controls.Add(this.lblTCTH);
            this.grbCTCD.Controls.Add(this.lblNgayKT);
            this.grbCTCD.Controls.Add(this.lblNgayBD);
            this.grbCTCD.Controls.Add(this.lblMoTa);
            this.grbCTCD.Controls.Add(this.lblTenChienDich);
            this.grbCTCD.Controls.Add(this.lblMaChienDich);
            this.grbCTCD.Location = new System.Drawing.Point(734, 69);
            this.grbCTCD.Name = "grbCTCD";
            this.grbCTCD.Size = new System.Drawing.Size(481, 464);
            this.grbCTCD.TabIndex = 9;
            this.grbCTCD.TabStop = false;
            this.grbCTCD.Text = "Thông tin chi tiết chiến dịch";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Window;
            this.btnXoa.Location = new System.Drawing.Point(353, 400);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 48);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.Window;
            this.btnCapNhat.Location = new System.Drawing.Point(189, 400);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(103, 48);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Window;
            this.btnThem.Location = new System.Drawing.Point(29, 400);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 48);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbTCTH
            // 
            this.cbbTCTH.FormattingEnabled = true;
            this.cbbTCTH.Location = new System.Drawing.Point(187, 343);
            this.cbbTCTH.Name = "cbbTCTH";
            this.cbbTCTH.Size = new System.Drawing.Size(269, 30);
            this.cbbTCTH.TabIndex = 11;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKT.Location = new System.Drawing.Point(187, 281);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(269, 28);
            this.dtpNgayKT.TabIndex = 10;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(187, 207);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(269, 28);
            this.dtpNgayBD.TabIndex = 9;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(187, 130);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(269, 55);
            this.txtMoTa.TabIndex = 8;
            // 
            // txtTenChienDich
            // 
            this.txtTenChienDich.Location = new System.Drawing.Point(187, 86);
            this.txtTenChienDich.Name = "txtTenChienDich";
            this.txtTenChienDich.Size = new System.Drawing.Size(269, 28);
            this.txtTenChienDich.TabIndex = 7;
            // 
            // txtMaChienDich
            // 
            this.txtMaChienDich.Location = new System.Drawing.Point(187, 43);
            this.txtMaChienDich.Name = "txtMaChienDich";
            this.txtMaChienDich.Size = new System.Drawing.Size(162, 28);
            this.txtMaChienDich.TabIndex = 6;
            // 
            // lblTCTH
            // 
            this.lblTCTH.AutoSize = true;
            this.lblTCTH.Location = new System.Drawing.Point(25, 351);
            this.lblTCTH.Name = "lblTCTH";
            this.lblTCTH.Size = new System.Drawing.Size(158, 22);
            this.lblTCTH.TabIndex = 5;
            this.lblTCTH.Text = "Tổ chức thực hiện:";
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Location = new System.Drawing.Point(25, 287);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(125, 22);
            this.lblNgayKT.TabIndex = 4;
            this.lblNgayKT.Text = "Ngày kết thúc:";
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Location = new System.Drawing.Point(25, 212);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(122, 22);
            this.lblNgayBD.TabIndex = 3;
            this.lblNgayBD.Text = "Ngày bắt đầu:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(25, 136);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(59, 22);
            this.lblMoTa.TabIndex = 2;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // lblTenChienDich
            // 
            this.lblTenChienDich.AutoSize = true;
            this.lblTenChienDich.Location = new System.Drawing.Point(26, 92);
            this.lblTenChienDich.Name = "lblTenChienDich";
            this.lblTenChienDich.Size = new System.Drawing.Size(133, 22);
            this.lblTenChienDich.TabIndex = 1;
            this.lblTenChienDich.Text = "Tên chiến dịch:";
            // 
            // lblMaChienDich
            // 
            this.lblMaChienDich.AutoSize = true;
            this.lblMaChienDich.Location = new System.Drawing.Point(25, 49);
            this.lblMaChienDich.Name = "lblMaChienDich";
            this.lblMaChienDich.Size = new System.Drawing.Size(134, 22);
            this.lblMaChienDich.TabIndex = 0;
            this.lblMaChienDich.Text = "Mã Chiến dịch: ";
            // 
            // BT_BS8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1227, 544);
            this.Controls.Add(this.grbCTCD);
            this.Controls.Add(this.dgvCCCD);
            this.Controls.Add(this.lblChiTiet);
            this.Controls.Add(this.lstbDSChienDich);
            this.Controls.Add(this.lblDSCD);
            this.Controls.Add(this.lstvHoatDongChinh);
            this.Controls.Add(this.lstbDSTinh);
            this.Controls.Add(this.lblHoatDong);
            this.Controls.Add(this.lblDST);
            this.Controls.Add(this.lblTTCD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BT_BS8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BT_BS8";
            this.Load += new System.EventHandler(this.BT_BS8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCCCD)).EndInit();
            this.grbCTCD.ResumeLayout(false);
            this.grbCTCD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTTCD;
        private System.Windows.Forms.Label lblDST;
        private System.Windows.Forms.Label lblHoatDong;
        private System.Windows.Forms.ListBox lstbDSTinh;
        private System.Windows.Forms.ListView lstvHoatDongChinh;
        private System.Windows.Forms.ColumnHeader colHoatDongChinh;
        private System.Windows.Forms.ColumnHeader colTrangThai;
        private System.Windows.Forms.Label lblDSCD;
        private System.Windows.Forms.ListBox lstbDSChienDich;
        private System.Windows.Forms.Label lblChiTiet;
        private System.Windows.Forms.DataGridView dgvCCCD;
        private System.Windows.Forms.GroupBox grbCTCD;
        private System.Windows.Forms.Label lblTenChienDich;
        private System.Windows.Forms.Label lblMaChienDich;
        private System.Windows.Forms.TextBox txtMaChienDich;
        private System.Windows.Forms.Label lblTCTH;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtTenChienDich;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbTCTH;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.TextBox txtMoTa;
    }
}