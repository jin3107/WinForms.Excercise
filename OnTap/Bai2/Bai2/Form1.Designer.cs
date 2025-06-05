namespace Bai2
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
            this.lblPDKMS = new System.Windows.Forms.Label();
            this.lblDMS = new System.Windows.Forms.Label();
            this.lblDSTK = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblTienPhaiTra = new System.Windows.Forms.Label();
            this.lstvDS = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtTienPT = new System.Windows.Forms.TextBox();
            this.grbTTCT = new System.Windows.Forms.GroupBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.cbbKhoi = new System.Windows.Forms.ComboBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblKhoi = new System.Windows.Forms.Label();
            this.clbDMS = new System.Windows.Forms.CheckedListBox();
            this.grbTTCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPDKMS
            // 
            this.lblPDKMS.AutoSize = true;
            this.lblPDKMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDKMS.Location = new System.Drawing.Point(140, 9);
            this.lblPDKMS.Name = "lblPDKMS";
            this.lblPDKMS.Size = new System.Drawing.Size(688, 29);
            this.lblPDKMS.TabIndex = 0;
            this.lblPDKMS.Text = "PHIẾU ĐĂNG KÝ MUA SÁCH TRƯỜNG THCS XUÂN DIỆU";
            // 
            // lblDMS
            // 
            this.lblDMS.AutoSize = true;
            this.lblDMS.Location = new System.Drawing.Point(12, 55);
            this.lblDMS.Name = "lblDMS";
            this.lblDMS.Size = new System.Drawing.Size(134, 22);
            this.lblDMS.TabIndex = 1;
            this.lblDMS.Text = "Danh mục sách";
            // 
            // lblDSTK
            // 
            this.lblDSTK.AutoSize = true;
            this.lblDSTK.Location = new System.Drawing.Point(12, 256);
            this.lblDSTK.Name = "lblDSTK";
            this.lblDSTK.Size = new System.Drawing.Size(170, 22);
            this.lblDSTK.TabIndex = 2;
            this.lblDSTK.Text = "Danh sách thống kê";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(612, 281);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(86, 22);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(612, 337);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(81, 22);
            this.lblGiamGia.TabIndex = 4;
            this.lblGiamGia.Text = "Giảm giá";
            // 
            // lblTienPhaiTra
            // 
            this.lblTienPhaiTra.AutoSize = true;
            this.lblTienPhaiTra.Location = new System.Drawing.Point(612, 395);
            this.lblTienPhaiTra.Name = "lblTienPhaiTra";
            this.lblTienPhaiTra.Size = new System.Drawing.Size(111, 22);
            this.lblTienPhaiTra.TabIndex = 5;
            this.lblTienPhaiTra.Text = "Tiền phải trả";
            // 
            // lstvDS
            // 
            this.lstvDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colTenSach,
            this.colMaSach,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien});
            this.lstvDS.FullRowSelect = true;
            this.lstvDS.GridLines = true;
            this.lstvDS.HideSelection = false;
            this.lstvDS.Location = new System.Drawing.Point(16, 281);
            this.lstvDS.Name = "lstvDS";
            this.lstvDS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstvDS.Size = new System.Drawing.Size(565, 136);
            this.lstvDS.TabIndex = 6;
            this.lstvDS.UseCompatibleStateImageBehavior = false;
            this.lstvDS.View = System.Windows.Forms.View.Details;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colTenSach
            // 
            this.colTenSach.Text = "Tên sách";
            this.colTenSach.Width = 100;
            // 
            // colMaSach
            // 
            this.colMaSach.Text = "Mã sách";
            this.colMaSach.Width = 100;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 100;
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.Width = 100;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Text = "Thành tiền";
            this.colThanhTien.Width = 100;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(752, 275);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(172, 28);
            this.txtTongTien.TabIndex = 7;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(752, 331);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(172, 28);
            this.txtGiamGia.TabIndex = 8;
            // 
            // txtTienPT
            // 
            this.txtTienPT.Location = new System.Drawing.Point(752, 389);
            this.txtTienPT.Name = "txtTienPT";
            this.txtTienPT.Size = new System.Drawing.Size(172, 28);
            this.txtTienPT.TabIndex = 9;
            // 
            // grbTTCT
            // 
            this.grbTTCT.Controls.Add(this.btnTinhTien);
            this.grbTTCT.Controls.Add(this.btnThem);
            this.grbTTCT.Controls.Add(this.numSL);
            this.grbTTCT.Controls.Add(this.cbbLop);
            this.grbTTCT.Controls.Add(this.cbbKhoi);
            this.grbTTCT.Controls.Add(this.lblSL);
            this.grbTTCT.Controls.Add(this.lblLop);
            this.grbTTCT.Controls.Add(this.lblKhoi);
            this.grbTTCT.Location = new System.Drawing.Point(264, 55);
            this.grbTTCT.Name = "grbTTCT";
            this.grbTTCT.Size = new System.Drawing.Size(547, 190);
            this.grbTTCT.TabIndex = 10;
            this.grbTTCT.TabStop = false;
            this.grbTTCT.Text = "Thông tin chi tiết";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(397, 116);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(95, 36);
            this.btnTinhTien.TabIndex = 7;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(397, 61);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 34);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(138, 137);
            this.numSL.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numSL.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(179, 28);
            this.numSL.TabIndex = 5;
            this.numSL.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(138, 89);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(179, 30);
            this.cbbLop.TabIndex = 4;
            // 
            // cbbKhoi
            // 
            this.cbbKhoi.FormattingEnabled = true;
            this.cbbKhoi.Location = new System.Drawing.Point(138, 40);
            this.cbbKhoi.Name = "cbbKhoi";
            this.cbbKhoi.Size = new System.Drawing.Size(179, 30);
            this.cbbKhoi.TabIndex = 3;
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(25, 143);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(86, 22);
            this.lblSL.TabIndex = 2;
            this.lblSL.Text = "Số lượng:";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(25, 97);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(45, 22);
            this.lblLop.TabIndex = 1;
            this.lblLop.Text = "Lớp:";
            // 
            // lblKhoi
            // 
            this.lblKhoi.AutoSize = true;
            this.lblKhoi.Location = new System.Drawing.Point(25, 48);
            this.lblKhoi.Name = "lblKhoi";
            this.lblKhoi.Size = new System.Drawing.Size(51, 22);
            this.lblKhoi.TabIndex = 0;
            this.lblKhoi.Text = "Khối:";
            // 
            // clbDMS
            // 
            this.clbDMS.FormattingEnabled = true;
            this.clbDMS.Location = new System.Drawing.Point(16, 80);
            this.clbDMS.Name = "clbDMS";
            this.clbDMS.Size = new System.Drawing.Size(227, 165);
            this.clbDMS.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 433);
            this.Controls.Add(this.clbDMS);
            this.Controls.Add(this.grbTTCT);
            this.Controls.Add(this.txtTienPT);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lstvDS);
            this.Controls.Add(this.lblTienPhaiTra);
            this.Controls.Add(this.lblGiamGia);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblDSTK);
            this.Controls.Add(this.lblDMS);
            this.Controls.Add(this.lblPDKMS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbTTCT.ResumeLayout(false);
            this.grbTTCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPDKMS;
        private System.Windows.Forms.Label lblDMS;
        private System.Windows.Forms.Label lblDSTK;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblTienPhaiTra;
        private System.Windows.Forms.ListView lstvDS;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colTenSach;
        private System.Windows.Forms.ColumnHeader colMaSach;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colThanhTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtTienPT;
        private System.Windows.Forms.GroupBox grbTTCT;
        private System.Windows.Forms.Label lblKhoi;
        private System.Windows.Forms.CheckedListBox clbDMS;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.ComboBox cbbKhoi;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblLop;
    }
}

