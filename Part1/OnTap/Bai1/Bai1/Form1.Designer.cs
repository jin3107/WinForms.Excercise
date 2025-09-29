namespace Bai1
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
            this.lblDKHPTC = new System.Windows.Forms.Label();
            this.lblSTT = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblChon = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.rdbtnNhom1 = new System.Windows.Forms.RadioButton();
            this.rdbtnNhom2 = new System.Windows.Forms.RadioButton();
            this.clbHocPhan = new System.Windows.Forms.CheckedListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lstvDSHP = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNhom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHP1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHP2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblDKHPTC
            // 
            this.lblDKHPTC.AutoSize = true;
            this.lblDKHPTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDKHPTC.Location = new System.Drawing.Point(336, 9);
            this.lblDKHPTC.Name = "lblDKHPTC";
            this.lblDKHPTC.Size = new System.Drawing.Size(390, 29);
            this.lblDKHPTC.TabIndex = 0;
            this.lblDKHPTC.Text = "ĐĂNG KÝ HỌC PHẦN TỰ CHỌN";
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Location = new System.Drawing.Point(21, 69);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(51, 22);
            this.lblSTT.TabIndex = 1;
            this.lblSTT.Text = "STT:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(21, 116);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(68, 22);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblChon
            // 
            this.lblChon.AutoSize = true;
            this.lblChon.Location = new System.Drawing.Point(21, 198);
            this.lblChon.Name = "lblChon";
            this.lblChon.Size = new System.Drawing.Size(147, 22);
            this.lblChon.TabIndex = 3;
            this.lblChon.Text = "Chọn 2 học phần";
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(120, 63);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(150, 28);
            this.txtSTT.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(120, 110);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(150, 28);
            this.txtHoTen.TabIndex = 5;
            // 
            // rdbtnNhom1
            // 
            this.rdbtnNhom1.AutoSize = true;
            this.rdbtnNhom1.Location = new System.Drawing.Point(25, 159);
            this.rdbtnNhom1.Name = "rdbtnNhom1";
            this.rdbtnNhom1.Size = new System.Drawing.Size(93, 26);
            this.rdbtnNhom1.TabIndex = 6;
            this.rdbtnNhom1.TabStop = true;
            this.rdbtnNhom1.Text = "Nhóm 1";
            this.rdbtnNhom1.UseVisualStyleBackColor = true;
            this.rdbtnNhom1.CheckedChanged += new System.EventHandler(this.rdbtnNhom1_CheckedChanged);
            // 
            // rdbtnNhom2
            // 
            this.rdbtnNhom2.AutoSize = true;
            this.rdbtnNhom2.Location = new System.Drawing.Point(177, 159);
            this.rdbtnNhom2.Name = "rdbtnNhom2";
            this.rdbtnNhom2.Size = new System.Drawing.Size(93, 26);
            this.rdbtnNhom2.TabIndex = 7;
            this.rdbtnNhom2.TabStop = true;
            this.rdbtnNhom2.Text = "Nhóm 2";
            this.rdbtnNhom2.UseVisualStyleBackColor = true;
            this.rdbtnNhom2.CheckedChanged += new System.EventHandler(this.rdbtnNhom2_CheckedChanged);
            // 
            // clbHocPhan
            // 
            this.clbHocPhan.FormattingEnabled = true;
            this.clbHocPhan.Location = new System.Drawing.Point(25, 223);
            this.clbHocPhan.Name = "clbHocPhan";
            this.clbHocPhan.Size = new System.Drawing.Size(199, 188);
            this.clbHocPhan.TabIndex = 8;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(256, 198);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(100, 34);
            this.btnChon.TabIndex = 9;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(256, 256);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(100, 34);
            this.btnTiep.TabIndex = 10;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(256, 319);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 34);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(256, 377);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 34);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lstvDSHP
            // 
            this.lstvDSHP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colHoTen,
            this.colNhom,
            this.colHP1,
            this.colHP2});
            this.lstvDSHP.FullRowSelect = true;
            this.lstvDSHP.GridLines = true;
            this.lstvDSHP.HideSelection = false;
            this.lstvDSHP.Location = new System.Drawing.Point(386, 69);
            this.lstvDSHP.Name = "lstvDSHP";
            this.lstvDSHP.Size = new System.Drawing.Size(666, 342);
            this.lstvDSHP.TabIndex = 13;
            this.lstvDSHP.UseCompatibleStateImageBehavior = false;
            this.lstvDSHP.View = System.Windows.Forms.View.Details;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 200;
            // 
            // colNhom
            // 
            this.colNhom.Text = "Nhóm";
            // 
            // colHP1
            // 
            this.colHP1.Text = "Học phần 1";
            this.colHP1.Width = 170;
            // 
            // colHP2
            // 
            this.colHP2.Text = "Học phần 2";
            this.colHP2.Width = 170;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 434);
            this.Controls.Add(this.lstvDSHP);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.clbHocPhan);
            this.Controls.Add(this.rdbtnNhom2);
            this.Controls.Add(this.rdbtnNhom1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.lblChon);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblSTT);
            this.Controls.Add(this.lblDKHPTC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDKHPTC;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblChon;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.RadioButton rdbtnNhom1;
        private System.Windows.Forms.RadioButton rdbtnNhom2;
        private System.Windows.Forms.CheckedListBox clbHocPhan;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lstvDSHP;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colNhom;
        private System.Windows.Forms.ColumnHeader colHP1;
        private System.Windows.Forms.ColumnHeader colHP2;
    }
}

