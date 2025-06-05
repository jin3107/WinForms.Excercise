namespace Bai1
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
            this.lblQLTLS = new System.Windows.Forms.Label();
            this.lblDSTLS = new System.Windows.Forms.Label();
            this.lblMaTL = new System.Windows.Forms.Label();
            this.lblTenTL = new System.Windows.Forms.Label();
            this.lstbDSTLSach = new System.Windows.Forms.ListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLTLS
            // 
            this.lblQLTLS.AutoSize = true;
            this.lblQLTLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLTLS.Location = new System.Drawing.Point(183, 9);
            this.lblQLTLS.Name = "lblQLTLS";
            this.lblQLTLS.Size = new System.Drawing.Size(323, 29);
            this.lblQLTLS.TabIndex = 0;
            this.lblQLTLS.Text = "QUẢN LÝ THỂ LOẠI SÁCH";
            // 
            // lblDSTLS
            // 
            this.lblDSTLS.AutoSize = true;
            this.lblDSTLS.Location = new System.Drawing.Point(12, 68);
            this.lblDSTLS.Name = "lblDSTLS";
            this.lblDSTLS.Size = new System.Drawing.Size(202, 22);
            this.lblDSTLS.TabIndex = 1;
            this.lblDSTLS.Text = "Danh sách thể loại sách";
            // 
            // lblMaTL
            // 
            this.lblMaTL.AutoSize = true;
            this.lblMaTL.Location = new System.Drawing.Point(334, 134);
            this.lblMaTL.Name = "lblMaTL";
            this.lblMaTL.Size = new System.Drawing.Size(102, 22);
            this.lblMaTL.TabIndex = 2;
            this.lblMaTL.Text = "Mã thể loại:";
            // 
            // lblTenTL
            // 
            this.lblTenTL.AutoSize = true;
            this.lblTenTL.Location = new System.Drawing.Point(334, 193);
            this.lblTenTL.Name = "lblTenTL";
            this.lblTenTL.Size = new System.Drawing.Size(110, 22);
            this.lblTenTL.TabIndex = 3;
            this.lblTenTL.Text = "Tên thể loại:";
            // 
            // lstbDSTLSach
            // 
            this.lstbDSTLSach.FormattingEnabled = true;
            this.lstbDSTLSach.ItemHeight = 22;
            this.lstbDSTLSach.Location = new System.Drawing.Point(16, 93);
            this.lstbDSTLSach.Name = "lstbDSTLSach";
            this.lstbDSTLSach.Size = new System.Drawing.Size(198, 180);
            this.lstbDSTLSach.TabIndex = 4;
            this.lstbDSTLSach.SelectedIndexChanged += new System.EventHandler(this.lstbDSTLSach_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(139, 298);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(322, 298);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(75, 40);
            this.btnGhi.TabIndex = 6;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(506, 298);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 40);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaTL
            // 
            this.txtMaTL.Location = new System.Drawing.Point(467, 128);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(164, 28);
            this.txtMaTL.TabIndex = 8;
            // 
            // txtTenTL
            // 
            this.txtTenTL.Location = new System.Drawing.Point(467, 187);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(164, 28);
            this.txtTenTL.TabIndex = 9;
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(16, 361);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(678, 155);
            this.dgvSach.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 528);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.txtTenTL);
            this.Controls.Add(this.txtMaTL);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lstbDSTLSach);
            this.Controls.Add(this.lblTenTL);
            this.Controls.Add(this.lblMaTL);
            this.Controls.Add(this.lblDSTLS);
            this.Controls.Add(this.lblQLTLS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLTLS;
        private System.Windows.Forms.Label lblDSTLS;
        private System.Windows.Forms.Label lblMaTL;
        private System.Windows.Forms.Label lblTenTL;
        private System.Windows.Forms.ListBox lstbDSTLSach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.DataGridView dgvSach;
    }
}