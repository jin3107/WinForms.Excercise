namespace BT_BS9
{
    partial class Cau2
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
            this.lblTTCT = new System.Windows.Forms.Label();
            this.lblDMDD = new System.Windows.Forms.Label();
            this.lblLK = new System.Windows.Forms.Label();
            this.grbTTCT = new System.Windows.Forms.GroupBox();
            this.lblMaDD = new System.Windows.Forms.Label();
            this.lblTenDD = new System.Windows.Forms.Label();
            this.lblTinhThanhPho = new System.Windows.Forms.Label();
            this.txtMaDD = new System.Windows.Forms.TextBox();
            this.txtTenDD = new System.Windows.Forms.TextBox();
            this.cbbTinhTP = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lstvTourDiaDanh = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenTour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoNgay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaVe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhuongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAnhMinhHoa = new System.Windows.Forms.Label();
            this.picAnhMinhHoa = new System.Windows.Forms.PictureBox();
            this.clbDMDD = new System.Windows.Forms.CheckedListBox();
            this.grbTTCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMinhHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTTCT
            // 
            this.lblTTCT.AutoSize = true;
            this.lblTTCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTCT.Location = new System.Drawing.Point(202, 9);
            this.lblTTCT.Name = "lblTTCT";
            this.lblTTCT.Size = new System.Drawing.Size(437, 25);
            this.lblTTCT.TabIndex = 0;
            this.lblTTCT.Text = "THÔNG TIN CHI TIẾT CÁC TOUR DU LỊCH";
            // 
            // lblDMDD
            // 
            this.lblDMDD.AutoSize = true;
            this.lblDMDD.Location = new System.Drawing.Point(12, 43);
            this.lblDMDD.Name = "lblDMDD";
            this.lblDMDD.Size = new System.Drawing.Size(154, 20);
            this.lblDMDD.TabIndex = 1;
            this.lblDMDD.Text = "Danh mục địa danh";
            // 
            // lblLK
            // 
            this.lblLK.AutoSize = true;
            this.lblLK.Location = new System.Drawing.Point(12, 251);
            this.lblLK.Name = "lblLK";
            this.lblLK.Size = new System.Drawing.Size(216, 20);
            this.lblLK.TabIndex = 2;
            this.lblLK.Text = "Liệt kê các tour có địa danh";
            // 
            // grbTTCT
            // 
            this.grbTTCT.Controls.Add(this.btnCapNhat);
            this.grbTTCT.Controls.Add(this.btnGhi);
            this.grbTTCT.Controls.Add(this.btnThem);
            this.grbTTCT.Controls.Add(this.cbbTinhTP);
            this.grbTTCT.Controls.Add(this.txtTenDD);
            this.grbTTCT.Controls.Add(this.txtMaDD);
            this.grbTTCT.Controls.Add(this.lblTinhThanhPho);
            this.grbTTCT.Controls.Add(this.lblTenDD);
            this.grbTTCT.Controls.Add(this.lblMaDD);
            this.grbTTCT.Location = new System.Drawing.Point(253, 66);
            this.grbTTCT.Name = "grbTTCT";
            this.grbTTCT.Size = new System.Drawing.Size(542, 164);
            this.grbTTCT.TabIndex = 4;
            this.grbTTCT.TabStop = false;
            this.grbTTCT.Text = "Thông tin chi tiết";
            // 
            // lblMaDD
            // 
            this.lblMaDD.AutoSize = true;
            this.lblMaDD.Location = new System.Drawing.Point(22, 41);
            this.lblMaDD.Name = "lblMaDD";
            this.lblMaDD.Size = new System.Drawing.Size(68, 20);
            this.lblMaDD.TabIndex = 0;
            this.lblMaDD.Text = "Mã DD:";
            // 
            // lblTenDD
            // 
            this.lblTenDD.AutoSize = true;
            this.lblTenDD.Location = new System.Drawing.Point(22, 82);
            this.lblTenDD.Name = "lblTenDD";
            this.lblTenDD.Size = new System.Drawing.Size(110, 20);
            this.lblTenDD.TabIndex = 1;
            this.lblTenDD.Text = "Tên địa danh:";
            // 
            // lblTinhThanhPho
            // 
            this.lblTinhThanhPho.AutoSize = true;
            this.lblTinhThanhPho.Location = new System.Drawing.Point(22, 122);
            this.lblTinhThanhPho.Name = "lblTinhThanhPho";
            this.lblTinhThanhPho.Size = new System.Drawing.Size(129, 20);
            this.lblTinhThanhPho.TabIndex = 2;
            this.lblTinhThanhPho.Text = "Tỉnh/Thành phố:";
            // 
            // txtMaDD
            // 
            this.txtMaDD.Location = new System.Drawing.Point(167, 34);
            this.txtMaDD.Name = "txtMaDD";
            this.txtMaDD.Size = new System.Drawing.Size(219, 27);
            this.txtMaDD.TabIndex = 3;
            // 
            // txtTenDD
            // 
            this.txtTenDD.Location = new System.Drawing.Point(167, 75);
            this.txtTenDD.Name = "txtTenDD";
            this.txtTenDD.Size = new System.Drawing.Size(219, 27);
            this.txtTenDD.TabIndex = 4;
            // 
            // cbbTinhTP
            // 
            this.cbbTinhTP.FormattingEnabled = true;
            this.cbbTinhTP.Location = new System.Drawing.Point(167, 114);
            this.cbbTinhTP.Name = "cbbTinhTP";
            this.cbbTinhTP.Size = new System.Drawing.Size(219, 28);
            this.cbbTinhTP.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(423, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 34);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(423, 71);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(82, 34);
            this.btnGhi.TabIndex = 7;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(423, 111);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(82, 34);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lstvTourDiaDanh
            // 
            this.lstvTourDiaDanh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colTenTour,
            this.colSoNgay,
            this.colGiaVe,
            this.colPhuongTien});
            this.lstvTourDiaDanh.FullRowSelect = true;
            this.lstvTourDiaDanh.GridLines = true;
            this.lstvTourDiaDanh.HideSelection = false;
            this.lstvTourDiaDanh.Location = new System.Drawing.Point(16, 274);
            this.lstvTourDiaDanh.Name = "lstvTourDiaDanh";
            this.lstvTourDiaDanh.Size = new System.Drawing.Size(585, 193);
            this.lstvTourDiaDanh.TabIndex = 5;
            this.lstvTourDiaDanh.UseCompatibleStateImageBehavior = false;
            this.lstvTourDiaDanh.View = System.Windows.Forms.View.Details;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colTenTour
            // 
            this.colTenTour.Text = "Tên tour";
            this.colTenTour.Width = 120;
            // 
            // colSoNgay
            // 
            this.colSoNgay.Text = "Số ngày";
            this.colSoNgay.Width = 80;
            // 
            // colGiaVe
            // 
            this.colGiaVe.Text = "Giá vé";
            this.colGiaVe.Width = 120;
            // 
            // colPhuongTien
            // 
            this.colPhuongTien.Text = "Phương tiện";
            this.colPhuongTien.Width = 200;
            // 
            // lblAnhMinhHoa
            // 
            this.lblAnhMinhHoa.AutoSize = true;
            this.lblAnhMinhHoa.Location = new System.Drawing.Point(628, 251);
            this.lblAnhMinhHoa.Name = "lblAnhMinhHoa";
            this.lblAnhMinhHoa.Size = new System.Drawing.Size(111, 20);
            this.lblAnhMinhHoa.TabIndex = 6;
            this.lblAnhMinhHoa.Text = "Ảnh minh họa";
            // 
            // picAnhMinhHoa
            // 
            this.picAnhMinhHoa.Location = new System.Drawing.Point(632, 274);
            this.picAnhMinhHoa.Name = "picAnhMinhHoa";
            this.picAnhMinhHoa.Size = new System.Drawing.Size(218, 193);
            this.picAnhMinhHoa.TabIndex = 7;
            this.picAnhMinhHoa.TabStop = false;
            // 
            // clbDMDD
            // 
            this.clbDMDD.FormattingEnabled = true;
            this.clbDMDD.Location = new System.Drawing.Point(16, 66);
            this.clbDMDD.Name = "clbDMDD";
            this.clbDMDD.Size = new System.Drawing.Size(212, 158);
            this.clbDMDD.TabIndex = 8;
            this.clbDMDD.SelectedIndexChanged += new System.EventHandler(this.clbDMDD_SelectedIndexChanged);
            // 
            // Cau2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 479);
            this.Controls.Add(this.clbDMDD);
            this.Controls.Add(this.picAnhMinhHoa);
            this.Controls.Add(this.lblAnhMinhHoa);
            this.Controls.Add(this.lstvTourDiaDanh);
            this.Controls.Add(this.grbTTCT);
            this.Controls.Add(this.lblLK);
            this.Controls.Add(this.lblDMDD);
            this.Controls.Add(this.lblTTCT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cau2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cau2";
            this.Load += new System.EventHandler(this.Cau2_Load);
            this.grbTTCT.ResumeLayout(false);
            this.grbTTCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMinhHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTTCT;
        private System.Windows.Forms.Label lblDMDD;
        private System.Windows.Forms.Label lblLK;
        private System.Windows.Forms.GroupBox grbTTCT;
        private System.Windows.Forms.Label lblTenDD;
        private System.Windows.Forms.Label lblMaDD;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbTinhTP;
        private System.Windows.Forms.TextBox txtTenDD;
        private System.Windows.Forms.TextBox txtMaDD;
        private System.Windows.Forms.Label lblTinhThanhPho;
        private System.Windows.Forms.ListView lstvTourDiaDanh;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colTenTour;
        private System.Windows.Forms.ColumnHeader colSoNgay;
        private System.Windows.Forms.ColumnHeader colGiaVe;
        private System.Windows.Forms.ColumnHeader colPhuongTien;
        private System.Windows.Forms.Label lblAnhMinhHoa;
        private System.Windows.Forms.PictureBox picAnhMinhHoa;
        private System.Windows.Forms.CheckedListBox clbDMDD;
    }
}