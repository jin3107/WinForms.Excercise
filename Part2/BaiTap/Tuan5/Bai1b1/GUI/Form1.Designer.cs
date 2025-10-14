namespace Tuan5.Bai1b1.GUI
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
            this.btnIn = new System.Windows.Forms.Button();
            this.dtgDSSV = new System.Windows.Forms.DataGridView();
            this.grbTTSV = new System.Windows.Forms.GroupBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtLanThi = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.grbDuyetDL = new System.Windows.Forms.GroupBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDoubleNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnDoublePrevious = new System.Windows.Forms.Button();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblLanThi = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.cbbTenMH = new System.Windows.Forms.ComboBox();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.lblTTSV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSSV)).BeginInit();
            this.grbTTSV.SuspendLayout();
            this.grbDuyetDL.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(478, 130);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 38);
            this.btnIn.TabIndex = 18;
            this.btnIn.Text = "In bảng";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // dtgDSSV
            // 
            this.dtgDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSSV.Location = new System.Drawing.Point(478, 175);
            this.dtgDSSV.Name = "dtgDSSV";
            this.dtgDSSV.RowHeadersWidth = 51;
            this.dtgDSSV.Size = new System.Drawing.Size(472, 150);
            this.dtgDSSV.TabIndex = 17;
            // 
            // grbTTSV
            // 
            this.grbTTSV.Controls.Add(this.txtDiem);
            this.grbTTSV.Controls.Add(this.txtLanThi);
            this.grbTTSV.Controls.Add(this.txtTenSV);
            this.grbTTSV.Controls.Add(this.txtMaSV);
            this.grbTTSV.Controls.Add(this.grbDuyetDL);
            this.grbTTSV.Controls.Add(this.lblMaSV);
            this.grbTTSV.Controls.Add(this.lblTenSV);
            this.grbTTSV.Controls.Add(this.lblLanThi);
            this.grbTTSV.Controls.Add(this.lblDiem);
            this.grbTTSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTSV.Location = new System.Drawing.Point(16, 109);
            this.grbTTSV.Name = "grbTTSV";
            this.grbTTSV.Size = new System.Drawing.Size(456, 281);
            this.grbTTSV.TabIndex = 16;
            this.grbTTSV.TabStop = false;
            this.grbTTSV.Text = "Xem thông tin sinh viên";
            // 
            // txtDiem
            // 
            this.txtDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem.Location = new System.Drawing.Point(162, 141);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(251, 30);
            this.txtDiem.TabIndex = 14;
            // 
            // txtLanThi
            // 
            this.txtLanThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanThi.Location = new System.Drawing.Point(162, 104);
            this.txtLanThi.Name = "txtLanThi";
            this.txtLanThi.Size = new System.Drawing.Size(251, 30);
            this.txtLanThi.TabIndex = 13;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSV.Location = new System.Drawing.Point(162, 66);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(251, 30);
            this.txtTenSV.TabIndex = 12;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(162, 29);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(251, 30);
            this.txtMaSV.TabIndex = 11;
            // 
            // grbDuyetDL
            // 
            this.grbDuyetDL.Controls.Add(this.txtCurrent);
            this.grbDuyetDL.Controls.Add(this.btnNext);
            this.grbDuyetDL.Controls.Add(this.btnDoubleNext);
            this.grbDuyetDL.Controls.Add(this.btnPrevious);
            this.grbDuyetDL.Controls.Add(this.btnDoublePrevious);
            this.grbDuyetDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDuyetDL.Location = new System.Drawing.Point(6, 202);
            this.grbDuyetDL.Name = "grbDuyetDL";
            this.grbDuyetDL.Size = new System.Drawing.Size(430, 69);
            this.grbDuyetDL.TabIndex = 10;
            this.grbDuyetDL.TabStop = false;
            this.grbDuyetDL.Text = "Duyệt dữ liệu";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Enabled = false;
            this.txtCurrent.Location = new System.Drawing.Point(137, 31);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.ReadOnly = true;
            this.txtCurrent.Size = new System.Drawing.Size(138, 30);
            this.txtCurrent.TabIndex = 13;
            this.txtCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(290, 31);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(48, 26);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDoubleNext
            // 
            this.btnDoubleNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoubleNext.Location = new System.Drawing.Point(354, 31);
            this.btnDoubleNext.Name = "btnDoubleNext";
            this.btnDoubleNext.Size = new System.Drawing.Size(53, 26);
            this.btnDoubleNext.TabIndex = 11;
            this.btnDoubleNext.Text = ">>";
            this.btnDoubleNext.UseVisualStyleBackColor = true;
            this.btnDoubleNext.Click += new System.EventHandler(this.btnDoubleNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(74, 31);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(47, 26);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnDoublePrevious
            // 
            this.btnDoublePrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoublePrevious.Location = new System.Drawing.Point(20, 31);
            this.btnDoublePrevious.Name = "btnDoublePrevious";
            this.btnDoublePrevious.Size = new System.Drawing.Size(46, 26);
            this.btnDoublePrevious.TabIndex = 9;
            this.btnDoublePrevious.Text = "<<";
            this.btnDoublePrevious.UseVisualStyleBackColor = true;
            this.btnDoublePrevious.Click += new System.EventHandler(this.btnDoublePrevious_Click);
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(22, 35);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(128, 25);
            this.lblMaSV.TabIndex = 4;
            this.lblMaSV.Text = "Mã sinh viên:";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.Location = new System.Drawing.Point(22, 72);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(135, 25);
            this.lblTenSV.TabIndex = 5;
            this.lblTenSV.Text = "Tên sinh viên:";
            // 
            // lblLanThi
            // 
            this.lblLanThi.AutoSize = true;
            this.lblLanThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanThi.Location = new System.Drawing.Point(22, 110);
            this.lblLanThi.Name = "lblLanThi";
            this.lblLanThi.Size = new System.Drawing.Size(76, 25);
            this.lblLanThi.TabIndex = 6;
            this.lblLanThi.Text = "Lần thi:";
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.Location = new System.Drawing.Point(22, 147);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(63, 25);
            this.lblDiem.TabIndex = 7;
            this.lblDiem.Text = "Điểm:";
            // 
            // cbbTenMH
            // 
            this.cbbTenMH.FormattingEnabled = true;
            this.cbbTenMH.Location = new System.Drawing.Point(163, 63);
            this.cbbTenMH.Name = "cbbTenMH";
            this.cbbTenMH.Size = new System.Drawing.Size(309, 30);
            this.cbbTenMH.TabIndex = 15;
            this.cbbTenMH.SelectedIndexChanged += new System.EventHandler(this.cbbTenMH_SelectedIndexChanged);
            // 
            // lblTenMH
            // 
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMH.Location = new System.Drawing.Point(12, 68);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(145, 25);
            this.lblTenMH.TabIndex = 14;
            this.lblTenMH.Text = "Tên môn học:";
            // 
            // lblTTSV
            // 
            this.lblTTSV.AutoSize = true;
            this.lblTTSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTSV.Location = new System.Drawing.Point(223, 9);
            this.lblTTSV.Name = "lblTTSV";
            this.lblTTSV.Size = new System.Drawing.Size(562, 31);
            this.lblTTSV.TabIndex = 13;
            this.lblTTSV.Text = "THÔNG TIN SINH VIÊN THEO MÔN HỌC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 400);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.dtgDSSV);
            this.Controls.Add(this.grbTTSV);
            this.Controls.Add(this.cbbTenMH);
            this.Controls.Add(this.lblTenMH);
            this.Controls.Add(this.lblTTSV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSSV)).EndInit();
            this.grbTTSV.ResumeLayout(false);
            this.grbTTSV.PerformLayout();
            this.grbDuyetDL.ResumeLayout(false);
            this.grbDuyetDL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridView dtgDSSV;
        private System.Windows.Forms.GroupBox grbTTSV;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtLanThi;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.GroupBox grbDuyetDL;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDoubleNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnDoublePrevious;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblLanThi;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.ComboBox cbbTenMH;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.Label lblTTSV;
    }
}