namespace Bai2
{
    partial class Form2
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
            this.lblTT = new System.Windows.Forms.Label();
            this.lblDST = new System.Windows.Forms.Label();
            this.lblDSCD = new System.Windows.Forms.Label();
            this.lblHoatDong = new System.Windows.Forms.Label();
            this.lblCTCD = new System.Windows.Forms.Label();
            this.lstbDSTinh = new System.Windows.Forms.ListBox();
            this.lstbDSChienDich = new System.Windows.Forms.ListBox();
            this.lstvHoatDong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvCTCD = new System.Windows.Forms.DataGridView();
            this.grbTTCD = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbTCTH = new System.Windows.Forms.ComboBox();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenCD = new System.Windows.Forms.TextBox();
            this.txtMaCD = new System.Windows.Forms.TextBox();
            this.lblTCTH = new System.Windows.Forms.Label();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTenCD = new System.Windows.Forms.Label();
            this.lblMaCD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTCD)).BeginInit();
            this.grbTTCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTT.Location = new System.Drawing.Point(302, 9);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(496, 22);
            this.lblTT.TabIndex = 0;
            this.lblTT.Text = "THÔNG TIN CÁC CHIẾN DỊCH BẢO VỆ MÔI TRƯỜNG";
            // 
            // lblDST
            // 
            this.lblDST.AutoSize = true;
            this.lblDST.Location = new System.Drawing.Point(12, 46);
            this.lblDST.Name = "lblDST";
            this.lblDST.Size = new System.Drawing.Size(130, 22);
            this.lblDST.TabIndex = 1;
            this.lblDST.Text = "Danh sách tỉnh";
            // 
            // lblDSCD
            // 
            this.lblDSCD.AutoSize = true;
            this.lblDSCD.Location = new System.Drawing.Point(12, 232);
            this.lblDSCD.Name = "lblDSCD";
            this.lblDSCD.Size = new System.Drawing.Size(215, 22);
            this.lblDSCD.TabIndex = 2;
            this.lblDSCD.Text = "Danh sách các chiến dịch";
            // 
            // lblHoatDong
            // 
            this.lblHoatDong.AutoSize = true;
            this.lblHoatDong.Location = new System.Drawing.Point(258, 46);
            this.lblHoatDong.Name = "lblHoatDong";
            this.lblHoatDong.Size = new System.Drawing.Size(176, 22);
            this.lblHoatDong.TabIndex = 3;
            this.lblHoatDong.Text = "Các hoạt động ở tỉnh";
            // 
            // lblCTCD
            // 
            this.lblCTCD.AutoSize = true;
            this.lblCTCD.Location = new System.Drawing.Point(258, 232);
            this.lblCTCD.Name = "lblCTCD";
            this.lblCTCD.Size = new System.Drawing.Size(152, 22);
            this.lblCTCD.TabIndex = 4;
            this.lblCTCD.Text = "Chi tiết chiến dịch";
            // 
            // lstbDSTinh
            // 
            this.lstbDSTinh.FormattingEnabled = true;
            this.lstbDSTinh.ItemHeight = 22;
            this.lstbDSTinh.Location = new System.Drawing.Point(16, 71);
            this.lstbDSTinh.Name = "lstbDSTinh";
            this.lstbDSTinh.Size = new System.Drawing.Size(211, 158);
            this.lstbDSTinh.TabIndex = 5;
            this.lstbDSTinh.SelectedIndexChanged += new System.EventHandler(this.lstbDSTinh_SelectedIndexChanged);
            // 
            // lstbDSChienDich
            // 
            this.lstbDSChienDich.FormattingEnabled = true;
            this.lstbDSChienDich.ItemHeight = 22;
            this.lstbDSChienDich.Location = new System.Drawing.Point(16, 257);
            this.lstbDSChienDich.Name = "lstbDSChienDich";
            this.lstbDSChienDich.Size = new System.Drawing.Size(211, 202);
            this.lstbDSChienDich.TabIndex = 6;
            this.lstbDSChienDich.SelectedIndexChanged += new System.EventHandler(this.lstbDSChienDich_SelectedIndexChanged);
            // 
            // lstvHoatDong
            // 
            this.lstvHoatDong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstvHoatDong.FullRowSelect = true;
            this.lstvHoatDong.GridLines = true;
            this.lstvHoatDong.HideSelection = false;
            this.lstvHoatDong.Location = new System.Drawing.Point(262, 71);
            this.lstvHoatDong.Name = "lstvHoatDong";
            this.lstvHoatDong.Size = new System.Drawing.Size(388, 158);
            this.lstvHoatDong.TabIndex = 7;
            this.lstvHoatDong.UseCompatibleStateImageBehavior = false;
            this.lstvHoatDong.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hoạt động chính";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Trạng thái";
            this.columnHeader2.Width = 150;
            // 
            // dgvCTCD
            // 
            this.dgvCTCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTCD.Location = new System.Drawing.Point(262, 257);
            this.dgvCTCD.Name = "dgvCTCD";
            this.dgvCTCD.RowHeadersWidth = 51;
            this.dgvCTCD.RowTemplate.Height = 24;
            this.dgvCTCD.Size = new System.Drawing.Size(388, 202);
            this.dgvCTCD.TabIndex = 8;
            // 
            // grbTTCD
            // 
            this.grbTTCD.Controls.Add(this.btnXoa);
            this.grbTTCD.Controls.Add(this.btnCapNhat);
            this.grbTTCD.Controls.Add(this.btnThem);
            this.grbTTCD.Controls.Add(this.cbbTCTH);
            this.grbTTCD.Controls.Add(this.dtpNgayKT);
            this.grbTTCD.Controls.Add(this.dtpNgayBD);
            this.grbTTCD.Controls.Add(this.txtMoTa);
            this.grbTTCD.Controls.Add(this.txtTenCD);
            this.grbTTCD.Controls.Add(this.txtMaCD);
            this.grbTTCD.Controls.Add(this.lblTCTH);
            this.grbTTCD.Controls.Add(this.lblNgayKT);
            this.grbTTCD.Controls.Add(this.lblNgayBD);
            this.grbTTCD.Controls.Add(this.lblMoTa);
            this.grbTTCD.Controls.Add(this.lblTenCD);
            this.grbTTCD.Controls.Add(this.lblMaCD);
            this.grbTTCD.Location = new System.Drawing.Point(668, 46);
            this.grbTTCD.Name = "grbTTCD";
            this.grbTTCD.Size = new System.Drawing.Size(352, 420);
            this.grbTTCD.TabIndex = 9;
            this.grbTTCD.TabStop = false;
            this.grbTTCD.Text = "Thông tin chiến dịch";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(258, 355);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 42);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(128, 355);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(97, 42);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 355);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 42);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbTCTH
            // 
            this.cbbTCTH.FormattingEnabled = true;
            this.cbbTCTH.Location = new System.Drawing.Point(169, 292);
            this.cbbTCTH.Name = "cbbTCTH";
            this.cbbTCTH.Size = new System.Drawing.Size(157, 30);
            this.cbbTCTH.TabIndex = 11;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKT.Location = new System.Drawing.Point(169, 248);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(157, 28);
            this.dtpNgayKT.TabIndex = 10;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(169, 206);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(157, 28);
            this.dtpNgayBD.TabIndex = 9;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(169, 143);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(157, 40);
            this.txtMoTa.TabIndex = 8;
            // 
            // txtTenCD
            // 
            this.txtTenCD.Location = new System.Drawing.Point(169, 91);
            this.txtTenCD.Name = "txtTenCD";
            this.txtTenCD.Size = new System.Drawing.Size(157, 28);
            this.txtTenCD.TabIndex = 7;
            // 
            // txtMaCD
            // 
            this.txtMaCD.Location = new System.Drawing.Point(169, 41);
            this.txtMaCD.Name = "txtMaCD";
            this.txtMaCD.Size = new System.Drawing.Size(157, 28);
            this.txtMaCD.TabIndex = 6;
            // 
            // lblTCTH
            // 
            this.lblTCTH.AutoSize = true;
            this.lblTCTH.Location = new System.Drawing.Point(15, 300);
            this.lblTCTH.Name = "lblTCTH";
            this.lblTCTH.Size = new System.Drawing.Size(158, 22);
            this.lblTCTH.TabIndex = 5;
            this.lblTCTH.Text = "Tổ chức thực hiện:";
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Location = new System.Drawing.Point(15, 254);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(125, 22);
            this.lblNgayKT.TabIndex = 4;
            this.lblNgayKT.Text = "Ngày kết thúc:";
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Location = new System.Drawing.Point(15, 211);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(122, 22);
            this.lblNgayBD.TabIndex = 3;
            this.lblNgayBD.Text = "Ngày bắt đầu:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(15, 149);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(59, 22);
            this.lblMoTa.TabIndex = 2;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // lblTenCD
            // 
            this.lblTenCD.AutoSize = true;
            this.lblTenCD.Location = new System.Drawing.Point(15, 97);
            this.lblTenCD.Name = "lblTenCD";
            this.lblTenCD.Size = new System.Drawing.Size(133, 22);
            this.lblTenCD.TabIndex = 1;
            this.lblTenCD.Text = "Tên chiến dịch:";
            // 
            // lblMaCD
            // 
            this.lblMaCD.AutoSize = true;
            this.lblMaCD.Location = new System.Drawing.Point(15, 47);
            this.lblMaCD.Name = "lblMaCD";
            this.lblMaCD.Size = new System.Drawing.Size(125, 22);
            this.lblMaCD.TabIndex = 0;
            this.lblMaCD.Text = "Mã chiến dịch:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 478);
            this.Controls.Add(this.grbTTCD);
            this.Controls.Add(this.dgvCTCD);
            this.Controls.Add(this.lstvHoatDong);
            this.Controls.Add(this.lstbDSChienDich);
            this.Controls.Add(this.lstbDSTinh);
            this.Controls.Add(this.lblCTCD);
            this.Controls.Add(this.lblHoatDong);
            this.Controls.Add(this.lblDSCD);
            this.Controls.Add(this.lblDST);
            this.Controls.Add(this.lblTT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTCD)).EndInit();
            this.grbTTCD.ResumeLayout(false);
            this.grbTTCD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Label lblDST;
        private System.Windows.Forms.Label lblDSCD;
        private System.Windows.Forms.Label lblHoatDong;
        private System.Windows.Forms.Label lblCTCD;
        private System.Windows.Forms.ListBox lstbDSTinh;
        private System.Windows.Forms.ListBox lstbDSChienDich;
        private System.Windows.Forms.ListView lstvHoatDong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataGridView dgvCTCD;
        private System.Windows.Forms.GroupBox grbTTCD;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblTenCD;
        private System.Windows.Forms.Label lblMaCD;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbTCTH;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenCD;
        private System.Windows.Forms.TextBox txtMaCD;
        private System.Windows.Forms.Label lblTCTH;
    }
}