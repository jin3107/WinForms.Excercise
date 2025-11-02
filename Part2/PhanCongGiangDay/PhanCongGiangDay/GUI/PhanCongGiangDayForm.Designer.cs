namespace PhanCongGiangDay.GUI
{
    partial class PhanCongGiangDayForm
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
            this.tvwDMGD = new System.Windows.Forms.TreeView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbCTHP = new System.Windows.Forms.GroupBox();
            this.cbbGV = new System.Windows.Forms.ComboBox();
            this.numSoTiet = new System.Windows.Forms.NumericUpDown();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.lblGiangVien = new System.Windows.Forms.Label();
            this.lblSoTiet = new System.Windows.Forms.Label();
            this.lblTenHP = new System.Windows.Forms.Label();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.dtgHocPhan = new System.Windows.Forms.DataGridView();
            this.lblHPDD = new System.Windows.Forms.Label();
            this.lblHPCD = new System.Windows.Forms.Label();
            this.grbCTHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // tvwDMGD
            // 
            this.tvwDMGD.Location = new System.Drawing.Point(12, 65);
            this.tvwDMGD.Name = "tvwDMGD";
            this.tvwDMGD.Size = new System.Drawing.Size(213, 266);
            this.tvwDMGD.TabIndex = 0;
            this.tvwDMGD.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwDMGD_AfterSelect);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(311, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "PHÂN CÔNG GIẢNG DẠY";
            // 
            // grbCTHP
            // 
            this.grbCTHP.Controls.Add(this.cbbGV);
            this.grbCTHP.Controls.Add(this.numSoTiet);
            this.grbCTHP.Controls.Add(this.txtTenHP);
            this.grbCTHP.Controls.Add(this.txtMaHP);
            this.grbCTHP.Controls.Add(this.lblGiangVien);
            this.grbCTHP.Controls.Add(this.lblSoTiet);
            this.grbCTHP.Controls.Add(this.lblTenHP);
            this.grbCTHP.Controls.Add(this.lblMaHP);
            this.grbCTHP.Location = new System.Drawing.Point(254, 65);
            this.grbCTHP.Name = "grbCTHP";
            this.grbCTHP.Size = new System.Drawing.Size(409, 203);
            this.grbCTHP.TabIndex = 2;
            this.grbCTHP.TabStop = false;
            this.grbCTHP.Text = "Chi tiết học phần";
            // 
            // cbbGV
            // 
            this.cbbGV.FormattingEnabled = true;
            this.cbbGV.Location = new System.Drawing.Point(133, 154);
            this.cbbGV.Name = "cbbGV";
            this.cbbGV.Size = new System.Drawing.Size(207, 30);
            this.cbbGV.TabIndex = 7;
            // 
            // numSoTiet
            // 
            this.numSoTiet.Location = new System.Drawing.Point(133, 114);
            this.numSoTiet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoTiet.Name = "numSoTiet";
            this.numSoTiet.Size = new System.Drawing.Size(207, 28);
            this.numSoTiet.TabIndex = 6;
            this.numSoTiet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTenHP
            // 
            this.txtTenHP.Location = new System.Drawing.Point(133, 76);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(207, 28);
            this.txtTenHP.TabIndex = 5;
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(133, 36);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(207, 28);
            this.txtMaHP.TabIndex = 4;
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.AutoSize = true;
            this.lblGiangVien.Location = new System.Drawing.Point(6, 162);
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.Size = new System.Drawing.Size(96, 22);
            this.lblGiangVien.TabIndex = 3;
            this.lblGiangVien.Text = "Giảng viên";
            // 
            // lblSoTiet
            // 
            this.lblSoTiet.AutoSize = true;
            this.lblSoTiet.Location = new System.Drawing.Point(6, 120);
            this.lblSoTiet.Name = "lblSoTiet";
            this.lblSoTiet.Size = new System.Drawing.Size(61, 22);
            this.lblSoTiet.TabIndex = 2;
            this.lblSoTiet.Text = "Số tiết";
            // 
            // lblTenHP
            // 
            this.lblTenHP.AutoSize = true;
            this.lblTenHP.Location = new System.Drawing.Point(6, 82);
            this.lblTenHP.Name = "lblTenHP";
            this.lblTenHP.Size = new System.Drawing.Size(72, 22);
            this.lblTenHP.TabIndex = 1;
            this.lblTenHP.Text = "Tên HP";
            // 
            // lblMaHP
            // 
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Location = new System.Drawing.Point(6, 42);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(64, 22);
            this.lblMaHP.TabIndex = 0;
            this.lblMaHP.Text = "Mã HP";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(254, 283);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 48);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm all";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(409, 283);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 48);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoá all";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(561, 283);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(102, 48);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // dtgHocPhan
            // 
            this.dtgHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHocPhan.Location = new System.Drawing.Point(12, 355);
            this.dtgHocPhan.Name = "dtgHocPhan";
            this.dtgHocPhan.RowHeadersWidth = 51;
            this.dtgHocPhan.RowTemplate.Height = 24;
            this.dtgHocPhan.Size = new System.Drawing.Size(651, 144);
            this.dtgHocPhan.TabIndex = 6;
            // 
            // lblHPDD
            // 
            this.lblHPDD.AutoSize = true;
            this.lblHPDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHPDD.Location = new System.Drawing.Point(72, 515);
            this.lblHPDD.Name = "lblHPDD";
            this.lblHPDD.Size = new System.Drawing.Size(200, 22);
            this.lblHPDD.TabIndex = 7;
            this.lblHPDD.Text = "Số học phần đã dạy: ";
            // 
            // lblHPCD
            // 
            this.lblHPCD.AutoSize = true;
            this.lblHPCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHPCD.Location = new System.Drawing.Point(393, 515);
            this.lblHPCD.Name = "lblHPCD";
            this.lblHPCD.Size = new System.Drawing.Size(221, 22);
            this.lblHPCD.TabIndex = 8;
            this.lblHPCD.Text = "Số học phần chưa dạy: ";
            // 
            // PhanCongGiangDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 563);
            this.Controls.Add(this.lblHPCD);
            this.Controls.Add(this.lblHPDD);
            this.Controls.Add(this.dtgHocPhan);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbCTHP);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tvwDMGD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhanCongGiangDayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhanCongGiangDayForm";
            this.Load += new System.EventHandler(this.PhanCongGiangDayForm_Load);
            this.grbCTHP.ResumeLayout(false);
            this.grbCTHP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvwDMGD;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbCTHP;
        private System.Windows.Forms.NumericUpDown numSoTiet;
        private System.Windows.Forms.TextBox txtTenHP;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Label lblGiangVien;
        private System.Windows.Forms.Label lblSoTiet;
        private System.Windows.Forms.Label lblTenHP;
        private System.Windows.Forms.Label lblMaHP;
        private System.Windows.Forms.ComboBox cbbGV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridView dtgHocPhan;
        private System.Windows.Forms.Label lblHPDD;
        private System.Windows.Forms.Label lblHPCD;
    }
}