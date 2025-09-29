namespace BT_BS5
{
    partial class BT_BS5
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
            this.tvPhanLoai = new System.Windows.Forms.TreeView();
            this.lbSanPham = new System.Windows.Forms.ListBox();
            this.lvDonHang = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btNhap = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btTinh = new System.Windows.Forms.Button();
            this.lblCHVVP = new System.Windows.Forms.Label();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.lblTSLuong = new System.Windows.Forms.Label();
            this.lblTSLoai = new System.Windows.Forms.Label();
            this.lblTTDH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvPhanLoai
            // 
            this.tvPhanLoai.Location = new System.Drawing.Point(12, 82);
            this.tvPhanLoai.Name = "tvPhanLoai";
            this.tvPhanLoai.Size = new System.Drawing.Size(212, 339);
            this.tvPhanLoai.TabIndex = 0;
            this.tvPhanLoai.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPhanLoai_AfterSelect);
            // 
            // lbSanPham
            // 
            this.lbSanPham.FormattingEnabled = true;
            this.lbSanPham.ItemHeight = 22;
            this.lbSanPham.Location = new System.Drawing.Point(251, 82);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSanPham.Size = new System.Drawing.Size(172, 202);
            this.lbSanPham.TabIndex = 1;
            // 
            // lvDonHang
            // 
            this.lvDonHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colTenSP,
            this.colSL,
            this.colLoaiSP});
            this.lvDonHang.FullRowSelect = true;
            this.lvDonHang.GridLines = true;
            this.lvDonHang.HideSelection = false;
            this.lvDonHang.Location = new System.Drawing.Point(523, 82);
            this.lvDonHang.Name = "lvDonHang";
            this.lvDonHang.Size = new System.Drawing.Size(363, 202);
            this.lvDonHang.TabIndex = 2;
            this.lvDonHang.UseCompatibleStateImageBehavior = false;
            this.lvDonHang.View = System.Windows.Forms.View.Details;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 79;
            // 
            // colTenSP
            // 
            this.colTenSP.Text = "Tên hàng";
            this.colTenSP.Width = 89;
            // 
            // colSL
            // 
            this.colSL.Text = "Số lượng";
            this.colSL.Width = 92;
            // 
            // colLoaiSP
            // 
            this.colLoaiSP.Text = "Loại";
            this.colLoaiSP.Width = 95;
            // 
            // btNhap
            // 
            this.btNhap.Location = new System.Drawing.Point(427, 113);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(90, 44);
            this.btNhap.TabIndex = 3;
            this.btNhap.Text = "Nhập";
            this.btNhap.UseVisualStyleBackColor = true;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(427, 173);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 43);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btTinh
            // 
            this.btTinh.Location = new System.Drawing.Point(427, 232);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(90, 43);
            this.btTinh.TabIndex = 5;
            this.btTinh.Text = "Tính";
            this.btTinh.UseVisualStyleBackColor = true;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // lblCHVVP
            // 
            this.lblCHVVP.AutoSize = true;
            this.lblCHVVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCHVVP.ForeColor = System.Drawing.Color.Red;
            this.lblCHVVP.Location = new System.Drawing.Point(268, 9);
            this.lblCHVVP.Name = "lblCHVVP";
            this.lblCHVVP.Size = new System.Drawing.Size(381, 29);
            this.lblCHVVP.TabIndex = 6;
            this.lblCHVVP.Text = "CỬA HÀNG VĂN PHÒNG PHẨM";
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.AutoSize = true;
            this.lblPhanLoai.Location = new System.Drawing.Point(12, 57);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Size = new System.Drawing.Size(85, 22);
            this.lblPhanLoai.TabIndex = 7;
            this.lblPhanLoai.Text = "Phân loại";
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Location = new System.Drawing.Point(254, 57);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(91, 22);
            this.lblSanPham.TabIndex = 8;
            this.lblSanPham.Text = "Sản phẩm";
            // 
            // lblTSLuong
            // 
            this.lblTSLuong.AutoSize = true;
            this.lblTSLuong.Location = new System.Drawing.Point(519, 313);
            this.lblTSLuong.Name = "lblTSLuong";
            this.lblTSLuong.Size = new System.Drawing.Size(130, 22);
            this.lblTSLuong.TabIndex = 9;
            this.lblTSLuong.Text = "Tổng số lượng:";
            // 
            // lblTSLoai
            // 
            this.lblTSLoai.AutoSize = true;
            this.lblTSLoai.Location = new System.Drawing.Point(519, 352);
            this.lblTSLoai.Name = "lblTSLoai";
            this.lblTSLoai.Size = new System.Drawing.Size(114, 22);
            this.lblTSLoai.TabIndex = 10;
            this.lblTSLoai.Text = "Tổng số loại:";
            // 
            // lblTTDH
            // 
            this.lblTTDH.AutoSize = true;
            this.lblTTDH.Location = new System.Drawing.Point(519, 57);
            this.lblTTDH.Name = "lblTTDH";
            this.lblTTDH.Size = new System.Drawing.Size(166, 22);
            this.lblTTDH.TabIndex = 11;
            this.lblTTDH.Text = "Thông tin đơn hàng";
            // 
            // BT_BS5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 433);
            this.Controls.Add(this.lblTTDH);
            this.Controls.Add(this.lblTSLoai);
            this.Controls.Add(this.lblTSLuong);
            this.Controls.Add(this.lblSanPham);
            this.Controls.Add(this.lblPhanLoai);
            this.Controls.Add(this.lblCHVVP);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btNhap);
            this.Controls.Add(this.lvDonHang);
            this.Controls.Add(this.lbSanPham);
            this.Controls.Add(this.tvPhanLoai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BT_BS5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stationery_Store";
            this.Load += new System.EventHandler(this.BT_BS5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvPhanLoai;
        private System.Windows.Forms.ListBox lbSanPham;
        private System.Windows.Forms.ListView lvDonHang;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colTenSP;
        private System.Windows.Forms.ColumnHeader colSL;
        private System.Windows.Forms.ColumnHeader colLoaiSP;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btTinh;
        private System.Windows.Forms.Label lblCHVVP;
        private System.Windows.Forms.Label lblPhanLoai;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.Label lblTSLuong;
        private System.Windows.Forms.Label lblTSLoai;
        private System.Windows.Forms.Label lblTTDH;
    }
}