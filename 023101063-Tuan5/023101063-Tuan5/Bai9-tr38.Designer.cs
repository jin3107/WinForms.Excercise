namespace _023101063_Tuan5
{
    partial class Bai9_tr38
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
            this.lblTD = new System.Windows.Forms.Label();
            this.lblLoaiMonAn = new System.Windows.Forms.Label();
            this.cbbLoaiMonAn = new System.Windows.Forms.ComboBox();
            this.grbCTMA = new System.Windows.Forms.GroupBox();
            this.grbCMADC = new System.Windows.Forms.GroupBox();
            this.grbSL = new System.Windows.Forms.GroupBox();
            this.nuSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btChon = new System.Windows.Forms.Button();
            this.btBoChon = new System.Windows.Forms.Button();
            this.lstvCacMonAn = new System.Windows.Forms.ListView();
            this.colTenMonAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btTaoMoi = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.clbChiTietMonAn = new System.Windows.Forms.CheckedListBox();
            this.grbCTMA.SuspendLayout();
            this.grbCMADC.SuspendLayout();
            this.grbSL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTD
            // 
            this.lblTD.AutoSize = true;
            this.lblTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTD.Location = new System.Drawing.Point(187, 9);
            this.lblTD.Name = "lblTD";
            this.lblTD.Size = new System.Drawing.Size(339, 29);
            this.lblTD.TabIndex = 0;
            this.lblTD.Text = "CHỌN THỰC ĐƠN MÓN ĂN";
            // 
            // lblLoaiMonAn
            // 
            this.lblLoaiMonAn.AutoSize = true;
            this.lblLoaiMonAn.Location = new System.Drawing.Point(12, 69);
            this.lblLoaiMonAn.Name = "lblLoaiMonAn";
            this.lblLoaiMonAn.Size = new System.Drawing.Size(113, 22);
            this.lblLoaiMonAn.TabIndex = 1;
            this.lblLoaiMonAn.Text = "Loại món ăn:";
            // 
            // cbbLoaiMonAn
            // 
            this.cbbLoaiMonAn.FormattingEnabled = true;
            this.cbbLoaiMonAn.Location = new System.Drawing.Point(16, 94);
            this.cbbLoaiMonAn.Name = "cbbLoaiMonAn";
            this.cbbLoaiMonAn.Size = new System.Drawing.Size(153, 30);
            this.cbbLoaiMonAn.TabIndex = 2;
            this.cbbLoaiMonAn.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiMonAn_SelectedIndexChanged);
            // 
            // grbCTMA
            // 
            this.grbCTMA.Controls.Add(this.clbChiTietMonAn);
            this.grbCTMA.Location = new System.Drawing.Point(12, 149);
            this.grbCTMA.Name = "grbCTMA";
            this.grbCTMA.Size = new System.Drawing.Size(258, 227);
            this.grbCTMA.TabIndex = 3;
            this.grbCTMA.TabStop = false;
            this.grbCTMA.Text = "Chi tiết món ăn:";
            // 
            // grbCMADC
            // 
            this.grbCMADC.Controls.Add(this.lstvCacMonAn);
            this.grbCMADC.Location = new System.Drawing.Point(440, 149);
            this.grbCMADC.Name = "grbCMADC";
            this.grbCMADC.Size = new System.Drawing.Size(258, 227);
            this.grbCMADC.TabIndex = 4;
            this.grbCMADC.TabStop = false;
            this.grbCMADC.Text = "Các món ăn đã chọn:";
            // 
            // grbSL
            // 
            this.grbSL.Controls.Add(this.btBoChon);
            this.grbSL.Controls.Add(this.btChon);
            this.grbSL.Controls.Add(this.nuSoLuong);
            this.grbSL.Location = new System.Drawing.Point(276, 149);
            this.grbSL.Name = "grbSL";
            this.grbSL.Size = new System.Drawing.Size(158, 227);
            this.grbSL.TabIndex = 5;
            this.grbSL.TabStop = false;
            this.grbSL.Text = "Số lượng:";
            // 
            // nuSoLuong
            // 
            this.nuSoLuong.Location = new System.Drawing.Point(21, 27);
            this.nuSoLuong.Name = "nuSoLuong";
            this.nuSoLuong.Size = new System.Drawing.Size(120, 28);
            this.nuSoLuong.TabIndex = 0;
            this.nuSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btChon
            // 
            this.btChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChon.Location = new System.Drawing.Point(21, 81);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(120, 36);
            this.btChon.TabIndex = 1;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // btBoChon
            // 
            this.btBoChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBoChon.Location = new System.Drawing.Point(21, 132);
            this.btBoChon.Name = "btBoChon";
            this.btBoChon.Size = new System.Drawing.Size(120, 36);
            this.btBoChon.TabIndex = 2;
            this.btBoChon.Text = "Bỏ chọn";
            this.btBoChon.UseVisualStyleBackColor = true;
            this.btBoChon.Click += new System.EventHandler(this.btBoChon_Click);
            // 
            // lstvCacMonAn
            // 
            this.lstvCacMonAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenMonAn,
            this.colSoLuong});
            this.lstvCacMonAn.FullRowSelect = true;
            this.lstvCacMonAn.GridLines = true;
            this.lstvCacMonAn.HideSelection = false;
            this.lstvCacMonAn.Location = new System.Drawing.Point(6, 27);
            this.lstvCacMonAn.Name = "lstvCacMonAn";
            this.lstvCacMonAn.Size = new System.Drawing.Size(246, 194);
            this.lstvCacMonAn.TabIndex = 0;
            this.lstvCacMonAn.UseCompatibleStateImageBehavior = false;
            this.lstvCacMonAn.View = System.Windows.Forms.View.Details;
            // 
            // colTenMonAn
            // 
            this.colTenMonAn.Text = "Tên món Ăn";
            this.colTenMonAn.Width = 154;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 87;
            // 
            // btTaoMoi
            // 
            this.btTaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoMoi.Location = new System.Drawing.Point(192, 382);
            this.btTaoMoi.Name = "btTaoMoi";
            this.btTaoMoi.Size = new System.Drawing.Size(120, 36);
            this.btTaoMoi.TabIndex = 6;
            this.btTaoMoi.Text = "Tạo mới";
            this.btTaoMoi.UseVisualStyleBackColor = true;
            this.btTaoMoi.Click += new System.EventHandler(this.btTaoMoi_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(406, 382);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(120, 36);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // clbChiTietMonAn
            // 
            this.clbChiTietMonAn.FormattingEnabled = true;
            this.clbChiTietMonAn.Location = new System.Drawing.Point(6, 27);
            this.clbChiTietMonAn.Name = "clbChiTietMonAn";
            this.clbChiTietMonAn.Size = new System.Drawing.Size(246, 188);
            this.clbChiTietMonAn.TabIndex = 8;
            // 
            // Bai9_tr38
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 458);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTaoMoi);
            this.Controls.Add(this.grbSL);
            this.Controls.Add(this.grbCMADC);
            this.Controls.Add(this.grbCTMA);
            this.Controls.Add(this.cbbLoaiMonAn);
            this.Controls.Add(this.lblLoaiMonAn);
            this.Controls.Add(this.lblTD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai9_tr38";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai9_tr38";
            this.Load += new System.EventHandler(this.Bai9_tr38_Load);
            this.grbCTMA.ResumeLayout(false);
            this.grbCMADC.ResumeLayout(false);
            this.grbSL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTD;
        private System.Windows.Forms.Label lblLoaiMonAn;
        private System.Windows.Forms.ComboBox cbbLoaiMonAn;
        private System.Windows.Forms.GroupBox grbCTMA;
        private System.Windows.Forms.GroupBox grbCMADC;
        private System.Windows.Forms.GroupBox grbSL;
        private System.Windows.Forms.Button btBoChon;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.NumericUpDown nuSoLuong;
        private System.Windows.Forms.CheckedListBox clbChiTietMonAn;
        private System.Windows.Forms.ListView lstvCacMonAn;
        private System.Windows.Forms.ColumnHeader colTenMonAn;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.Button btTaoMoi;
        private System.Windows.Forms.Button btThoat;
    }
}