namespace BaiTap_Chuong2
{
    partial class Bai7_tr36
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
            this.lblLop = new System.Windows.Forms.Label();
            this.lblDSL = new System.Windows.Forms.Label();
            this.lblDTB = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblLTGD = new System.Windows.Forms.Label();
            this.lblMTT = new System.Windows.Forms.Label();
            this.lblSQL = new System.Windows.Forms.Label();
            this.lstvDSL = new System.Windows.Forms.ListView();
            this.btThem = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.nuLTGB = new System.Windows.Forms.NumericUpDown();
            this.nuMMT = new System.Windows.Forms.NumericUpDown();
            this.nuSQL = new System.Windows.Forms.NumericUpDown();
            this.lblSVTB = new System.Windows.Forms.Label();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLTGB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMMT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSQL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nuLTGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(12, 30);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(40, 22);
            this.lblLop.TabIndex = 0;
            this.lblLop.Text = "Lớp";
            // 
            // lblDSL
            // 
            this.lblDSL.AutoSize = true;
            this.lblDSL.Location = new System.Drawing.Point(12, 75);
            this.lblDSL.Name = "lblDSL";
            this.lblDSL.Size = new System.Drawing.Size(130, 22);
            this.lblDSL.TabIndex = 1;
            this.lblDSL.Text = "Danh sách lớp:";
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Location = new System.Drawing.Point(12, 270);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(204, 22);
            this.lblDTB.TabIndex = 2;
            this.lblDTB.Text = "Điểm trung bình của SV:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(513, 100);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(68, 22);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblLTGD
            // 
            this.lblLTGD.AutoSize = true;
            this.lblLTGD.Location = new System.Drawing.Point(513, 138);
            this.lblLTGD.Name = "lblLTGD";
            this.lblLTGD.Size = new System.Drawing.Size(117, 22);
            this.lblLTGD.TabIndex = 4;
            this.lblLTGD.Text = "Lập trình GD:";
            // 
            // lblMTT
            // 
            this.lblMTT.AutoSize = true;
            this.lblMTT.Location = new System.Drawing.Point(513, 179);
            this.lblMTT.Name = "lblMTT";
            this.lblMTT.Size = new System.Drawing.Size(90, 22);
            this.lblMTT.TabIndex = 5;
            this.lblMTT.Text = "Mạng MT:";
            // 
            // lblSQL
            // 
            this.lblSQL.AutoSize = true;
            this.lblSQL.Location = new System.Drawing.Point(513, 217);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(104, 22);
            this.lblSQL.TabIndex = 6;
            this.lblSQL.Text = "CSDL SQL:";
            // 
            // lstvDSL
            // 
            this.lstvDSL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHoTen,
            this.colLTGB,
            this.colMMT,
            this.colSQL});
            this.lstvDSL.FullRowSelect = true;
            this.lstvDSL.GridLines = true;
            this.lstvDSL.HideSelection = false;
            this.lstvDSL.Location = new System.Drawing.Point(12, 100);
            this.lstvDSL.Name = "lstvDSL";
            this.lstvDSL.Size = new System.Drawing.Size(414, 139);
            this.lstvDSL.TabIndex = 7;
            this.lstvDSL.UseCompatibleStateImageBehavior = false;
            this.lstvDSL.View = System.Windows.Forms.View.Details;
            this.lstvDSL.SelectedIndexChanged += new System.EventHandler(this.lstvDSL_SelectedIndexChanged);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(432, 100);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 44);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.Location = new System.Drawing.Point(432, 150);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(75, 44);
            this.btCapNhat.TabIndex = 9;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(432, 200);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 44);
            this.btThoat.TabIndex = 10;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(644, 94);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(168, 28);
            this.txtHoTen.TabIndex = 11;
            // 
            // nuLTGB
            // 
            this.nuLTGB.Location = new System.Drawing.Point(644, 136);
            this.nuLTGB.Name = "nuLTGB";
            this.nuLTGB.Size = new System.Drawing.Size(168, 28);
            this.nuLTGB.TabIndex = 12;
            // 
            // nuMMT
            // 
            this.nuMMT.Location = new System.Drawing.Point(644, 177);
            this.nuMMT.Name = "nuMMT";
            this.nuMMT.Size = new System.Drawing.Size(168, 28);
            this.nuMMT.TabIndex = 13;
            // 
            // nuSQL
            // 
            this.nuSQL.Location = new System.Drawing.Point(644, 215);
            this.nuSQL.Name = "nuSQL";
            this.nuSQL.Size = new System.Drawing.Size(168, 28);
            this.nuSQL.TabIndex = 14;
            // 
            // lblSVTB
            // 
            this.lblSVTB.AutoSize = true;
            this.lblSVTB.Location = new System.Drawing.Point(222, 270);
            this.lblSVTB.Name = "lblSVTB";
            this.lblSVTB.Size = new System.Drawing.Size(25, 22);
            this.lblSVTB.TabIndex = 15;
            this.lblSVTB.Text = "...";
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(95, 27);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(187, 30);
            this.cbbLop.TabIndex = 16;
            this.cbbLop.SelectedIndexChanged += new System.EventHandler(this.cbbLop_SelectedIndexChanged);
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 82;
            // 
            // colLTGB
            // 
            this.colLTGB.Text = "Lập trình GB";
            this.colLTGB.Width = 116;
            // 
            // colMMT
            // 
            this.colMMT.Text = "Mạng MT";
            this.colMMT.Width = 95;
            // 
            // colSQL
            // 
            this.colSQL.Text = "CSDL SQL";
            this.colSQL.Width = 117;
            // 
            // Bai7_tr36
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 317);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.lblSVTB);
            this.Controls.Add(this.nuSQL);
            this.Controls.Add(this.nuMMT);
            this.Controls.Add(this.nuLTGB);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.lstvDSL);
            this.Controls.Add(this.lblSQL);
            this.Controls.Add(this.lblMTT);
            this.Controls.Add(this.lblLTGD);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblDTB);
            this.Controls.Add(this.lblDSL);
            this.Controls.Add(this.lblLop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai7_tr36";
            this.Text = "Bai7_tr36";
            this.Load += new System.EventHandler(this.Bai7_tr36_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuLTGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblDSL;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblLTGD;
        private System.Windows.Forms.Label lblMTT;
        private System.Windows.Forms.Label lblSQL;
        private System.Windows.Forms.ListView lstvDSL;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.NumericUpDown nuLTGB;
        private System.Windows.Forms.NumericUpDown nuMMT;
        private System.Windows.Forms.NumericUpDown nuSQL;
        private System.Windows.Forms.Label lblSVTB;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colLTGB;
        private System.Windows.Forms.ColumnHeader colMMT;
        private System.Windows.Forms.ColumnHeader colSQL;
    }
}