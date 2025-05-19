namespace BT_BS9
{
    partial class Cau1
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
            this.lblQL = new System.Windows.Forms.Label();
            this.lblDMSP = new System.Windows.Forms.Label();
            this.lblDSTK = new System.Windows.Forms.Label();
            this.lstbDMSP = new System.Windows.Forms.ListBox();
            this.grbTTDH = new System.Windows.Forms.GroupBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbbChuyen = new System.Windows.Forms.ComboBox();
            this.cbbPhanXuong = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblChuyen = new System.Windows.Forms.Label();
            this.lblPhanXuong = new System.Windows.Forms.Label();
            this.lstvDSTK = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhanXuongChuyen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblTienPhaiTra = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtTienPhaiTra = new System.Windows.Forms.TextBox();
            this.colSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbTTDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQL
            // 
            this.lblQL.AutoSize = true;
            this.lblQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQL.Location = new System.Drawing.Point(287, 9);
            this.lblQL.Name = "lblQL";
            this.lblQL.Size = new System.Drawing.Size(385, 29);
            this.lblQL.TabIndex = 0;
            this.lblQL.Text = "QUẢN LÝ SẢN PHẨM MAY MẶC";
            // 
            // lblDMSP
            // 
            this.lblDMSP.AutoSize = true;
            this.lblDMSP.Location = new System.Drawing.Point(12, 59);
            this.lblDMSP.Name = "lblDMSP";
            this.lblDMSP.Size = new System.Drawing.Size(164, 20);
            this.lblDMSP.TabIndex = 1;
            this.lblDMSP.Text = "Danh mục sản phẩm";
            // 
            // lblDSTK
            // 
            this.lblDSTK.AutoSize = true;
            this.lblDSTK.Location = new System.Drawing.Point(12, 305);
            this.lblDSTK.Name = "lblDSTK";
            this.lblDSTK.Size = new System.Drawing.Size(158, 20);
            this.lblDSTK.TabIndex = 2;
            this.lblDSTK.Text = "Danh sách thống kê";
            // 
            // lstbDMSP
            // 
            this.lstbDMSP.FormattingEnabled = true;
            this.lstbDMSP.ItemHeight = 20;
            this.lstbDMSP.Location = new System.Drawing.Point(12, 82);
            this.lstbDMSP.Name = "lstbDMSP";
            this.lstbDMSP.Size = new System.Drawing.Size(172, 204);
            this.lstbDMSP.TabIndex = 3;
            // 
            // grbTTDH
            // 
            this.grbTTDH.Controls.Add(this.btnTinhTien);
            this.grbTTDH.Controls.Add(this.btnThem);
            this.grbTTDH.Controls.Add(this.numSoLuong);
            this.grbTTDH.Controls.Add(this.cbbChuyen);
            this.grbTTDH.Controls.Add(this.cbbPhanXuong);
            this.grbTTDH.Controls.Add(this.lblSoLuong);
            this.grbTTDH.Controls.Add(this.lblChuyen);
            this.grbTTDH.Controls.Add(this.lblPhanXuong);
            this.grbTTDH.Location = new System.Drawing.Point(204, 82);
            this.grbTTDH.Name = "grbTTDH";
            this.grbTTDH.Size = new System.Drawing.Size(433, 204);
            this.grbTTDH.TabIndex = 4;
            this.grbTTDH.TabStop = false;
            this.grbTTDH.Text = "Thông tin đặt hàng";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(312, 121);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(90, 34);
            this.btnTinhTien.TabIndex = 7;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(312, 69);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 34);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(138, 145);
            this.numSoLuong.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(143, 27);
            this.numSoLuong.TabIndex = 5;
            // 
            // cbbChuyen
            // 
            this.cbbChuyen.FormattingEnabled = true;
            this.cbbChuyen.Location = new System.Drawing.Point(138, 94);
            this.cbbChuyen.Name = "cbbChuyen";
            this.cbbChuyen.Size = new System.Drawing.Size(143, 28);
            this.cbbChuyen.TabIndex = 4;
            // 
            // cbbPhanXuong
            // 
            this.cbbPhanXuong.FormattingEnabled = true;
            this.cbbPhanXuong.Location = new System.Drawing.Point(138, 44);
            this.cbbPhanXuong.Name = "cbbPhanXuong";
            this.cbbPhanXuong.Size = new System.Drawing.Size(143, 28);
            this.cbbPhanXuong.TabIndex = 3;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(15, 152);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(79, 20);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblChuyen
            // 
            this.lblChuyen.AutoSize = true;
            this.lblChuyen.Location = new System.Drawing.Point(15, 102);
            this.lblChuyen.Name = "lblChuyen";
            this.lblChuyen.Size = new System.Drawing.Size(70, 20);
            this.lblChuyen.TabIndex = 1;
            this.lblChuyen.Text = "Chuyền:";
            // 
            // lblPhanXuong
            // 
            this.lblPhanXuong.AutoSize = true;
            this.lblPhanXuong.Location = new System.Drawing.Point(15, 52);
            this.lblPhanXuong.Name = "lblPhanXuong";
            this.lblPhanXuong.Size = new System.Drawing.Size(101, 20);
            this.lblPhanXuong.TabIndex = 0;
            this.lblPhanXuong.Text = "Phân xưởng:";
            // 
            // lstvDSTK
            // 
            this.lstvDSTK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colPhanXuongChuyen,
            this.colSanPham,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien});
            this.lstvDSTK.FullRowSelect = true;
            this.lstvDSTK.GridLines = true;
            this.lstvDSTK.HideSelection = false;
            this.lstvDSTK.Location = new System.Drawing.Point(16, 339);
            this.lstvDSTK.Name = "lstvDSTK";
            this.lstvDSTK.Size = new System.Drawing.Size(677, 157);
            this.lstvDSTK.TabIndex = 5;
            this.lstvDSTK.UseCompatibleStateImageBehavior = false;
            this.lstvDSTK.View = System.Windows.Forms.View.Details;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colPhanXuongChuyen
            // 
            this.colPhanXuongChuyen.Text = "Phân xưởng/Chuyền";
            this.colPhanXuongChuyen.Width = 180;
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
            this.colThanhTien.Width = 120;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(720, 362);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(83, 20);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(720, 409);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(81, 20);
            this.lblGiamGia.TabIndex = 7;
            this.lblGiamGia.Text = "Giảm giá:";
            // 
            // lblTienPhaiTra
            // 
            this.lblTienPhaiTra.AutoSize = true;
            this.lblTienPhaiTra.Location = new System.Drawing.Point(718, 457);
            this.lblTienPhaiTra.Name = "lblTienPhaiTra";
            this.lblTienPhaiTra.Size = new System.Drawing.Size(107, 20);
            this.lblTienPhaiTra.TabIndex = 8;
            this.lblTienPhaiTra.Text = "Tiền phải trả:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(839, 355);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(121, 27);
            this.txtTongTien.TabIndex = 9;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(839, 402);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(121, 27);
            this.txtGiamGia.TabIndex = 10;
            // 
            // txtTienPhaiTra
            // 
            this.txtTienPhaiTra.Location = new System.Drawing.Point(839, 450);
            this.txtTienPhaiTra.Name = "txtTienPhaiTra";
            this.txtTienPhaiTra.Size = new System.Drawing.Size(121, 27);
            this.txtTienPhaiTra.TabIndex = 11;
            // 
            // colSanPham
            // 
            this.colSanPham.Text = "Sản phẩm";
            this.colSanPham.Width = 110;
            // 
            // Cau1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 515);
            this.Controls.Add(this.txtTienPhaiTra);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTienPhaiTra);
            this.Controls.Add(this.lblGiamGia);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lstvDSTK);
            this.Controls.Add(this.grbTTDH);
            this.Controls.Add(this.lstbDMSP);
            this.Controls.Add(this.lblDSTK);
            this.Controls.Add(this.lblDMSP);
            this.Controls.Add(this.lblQL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cau1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cau1";
            this.Load += new System.EventHandler(this.Cau1_Load);
            this.grbTTDH.ResumeLayout(false);
            this.grbTTDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQL;
        private System.Windows.Forms.Label lblDMSP;
        private System.Windows.Forms.Label lblDSTK;
        private System.Windows.Forms.ListBox lstbDMSP;
        private System.Windows.Forms.GroupBox grbTTDH;
        private System.Windows.Forms.ComboBox cbbPhanXuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblChuyen;
        private System.Windows.Forms.Label lblPhanXuong;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.ComboBox cbbChuyen;
        private System.Windows.Forms.ListView lstvDSTK;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colPhanXuongChuyen;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colThanhTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblTienPhaiTra;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtTienPhaiTra;
        private System.Windows.Forms.ColumnHeader colSanPham;
    }
}