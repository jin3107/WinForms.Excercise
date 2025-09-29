namespace DanhMucTapChiTinhDiem
{
    partial class frmDMTC
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
            this.dtgvDMTC = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtCQXB = new System.Windows.Forms.TextBox();
            this.txtTenTC = new System.Windows.Forms.TextBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.lblCQXB = new System.Windows.Forms.Label();
            this.lblTenTC = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblSTT = new System.Windows.Forms.Label();
            this.lblDMTC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDMTC)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDMTC
            // 
            this.dtgvDMTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDMTC.Location = new System.Drawing.Point(18, 269);
            this.dtgvDMTC.Name = "dtgvDMTC";
            this.dtgvDMTC.RowHeadersWidth = 51;
            this.dtgvDMTC.RowTemplate.Height = 24;
            this.dtgvDMTC.Size = new System.Drawing.Size(856, 183);
            this.dtgvDMTC.TabIndex = 33;
            this.dtgvDMTC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDMTC_CellClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(778, 209);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 41);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(608, 209);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(96, 41);
            this.btnCapNhat.TabIndex = 31;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.Location = new System.Drawing.Point(421, 209);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(96, 41);
            this.btnKhong.TabIndex = 30;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = true;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(240, 209);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(96, 41);
            this.btnGhi.TabIndex = 29;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(57, 209);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 41);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbLoai
            // 
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(496, 49);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(173, 30);
            this.cbbLoai.TabIndex = 27;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(752, 51);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(122, 28);
            this.txtDiem.TabIndex = 26;
            // 
            // txtCQXB
            // 
            this.txtCQXB.Location = new System.Drawing.Point(496, 141);
            this.txtCQXB.Name = "txtCQXB";
            this.txtCQXB.Size = new System.Drawing.Size(378, 28);
            this.txtCQXB.TabIndex = 25;
            // 
            // txtTenTC
            // 
            this.txtTenTC.Location = new System.Drawing.Point(126, 141);
            this.txtTenTC.Name = "txtTenTC";
            this.txtTenTC.Size = new System.Drawing.Size(210, 28);
            this.txtTenTC.TabIndex = 24;
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(126, 53);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(210, 28);
            this.txtSTT.TabIndex = 23;
            // 
            // lblCQXB
            // 
            this.lblCQXB.AutoSize = true;
            this.lblCQXB.Location = new System.Drawing.Point(373, 147);
            this.lblCQXB.Name = "lblCQXB";
            this.lblCQXB.Size = new System.Drawing.Size(107, 22);
            this.lblCQXB.TabIndex = 22;
            this.lblCQXB.Text = "Cơ quan XB";
            // 
            // lblTenTC
            // 
            this.lblTenTC.AutoSize = true;
            this.lblTenTC.Location = new System.Drawing.Point(14, 147);
            this.lblTenTC.Name = "lblTenTC";
            this.lblTenTC.Size = new System.Drawing.Size(100, 22);
            this.lblTenTC.TabIndex = 21;
            this.lblTenTC.Text = "Tên tạp chí";
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(685, 59);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(51, 22);
            this.lblDiem.TabIndex = 20;
            this.lblDiem.Text = "Điểm";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(436, 59);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(44, 22);
            this.lblLoai.TabIndex = 19;
            this.lblLoai.Text = "Loại";
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Location = new System.Drawing.Point(14, 59);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(46, 22);
            this.lblSTT.TabIndex = 18;
            this.lblSTT.Text = "STT";
            // 
            // lblDMTC
            // 
            this.lblDMTC.AutoSize = true;
            this.lblDMTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMTC.ForeColor = System.Drawing.Color.Red;
            this.lblDMTC.Location = new System.Drawing.Point(281, 9);
            this.lblDMTC.Name = "lblDMTC";
            this.lblDMTC.Size = new System.Drawing.Size(303, 22);
            this.lblDMTC.TabIndex = 17;
            this.lblDMTC.Text = "DANH MỤC TẠP CHÍ TÍNH ĐIỂM";
            // 
            // frmDMTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 476);
            this.Controls.Add(this.dtgvDMTC);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtCQXB);
            this.Controls.Add(this.txtTenTC);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.lblCQXB);
            this.Controls.Add(this.lblTenTC);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.lblSTT);
            this.Controls.Add(this.lblDMTC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDMTC";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmDMTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDMTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDMTC;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtCQXB;
        private System.Windows.Forms.TextBox txtTenTC;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Label lblCQXB;
        private System.Windows.Forms.Label lblTenTC;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Label lblDMTC;
    }
}

