namespace BT_BS1
{
    partial class Traffic_lights
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
            this.lblDGT = new System.Windows.Forms.Label();
            this.grbCH = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btHienThi = new System.Windows.Forms.Button();
            this.txtTGDo = new System.Windows.Forms.TextBox();
            this.txtTGXanh = new System.Windows.Forms.TextBox();
            this.lblTGVang = new System.Windows.Forms.Label();
            this.lblTGDo = new System.Windows.Forms.Label();
            this.lblTGXanh = new System.Windows.Forms.Label();
            this.grbDen = new System.Windows.Forms.GroupBox();
            this.picDo = new System.Windows.Forms.PictureBox();
            this.picVang = new System.Windows.Forms.PictureBox();
            this.picXanh = new System.Windows.Forms.PictureBox();
            this.lblTG = new System.Windows.Forms.Label();
            this.grbCH.SuspendLayout();
            this.grbDen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXanh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDGT
            // 
            this.lblDGT.AutoSize = true;
            this.lblDGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDGT.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDGT.Location = new System.Drawing.Point(92, 9);
            this.lblDGT.Name = "lblDGT";
            this.lblDGT.Size = new System.Drawing.Size(371, 29);
            this.lblDGT.TabIndex = 0;
            this.lblDGT.Text = "TÍNH HIỆU ĐÈN GIAO THÔNG";
            // 
            // grbCH
            // 
            this.grbCH.Controls.Add(this.btThoat);
            this.grbCH.Controls.Add(this.btHienThi);
            this.grbCH.Controls.Add(this.txtTGDo);
            this.grbCH.Controls.Add(this.txtTGXanh);
            this.grbCH.Controls.Add(this.lblTGVang);
            this.grbCH.Controls.Add(this.lblTGDo);
            this.grbCH.Controls.Add(this.lblTGXanh);
            this.grbCH.Location = new System.Drawing.Point(180, 77);
            this.grbCH.Name = "grbCH";
            this.grbCH.Size = new System.Drawing.Size(306, 312);
            this.grbCH.TabIndex = 1;
            this.grbCH.TabStop = false;
            this.grbCH.Text = "Cấu hình";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(164, 225);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(91, 40);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btHienThi
            // 
            this.btHienThi.Location = new System.Drawing.Point(36, 225);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(91, 40);
            this.btHienThi.TabIndex = 5;
            this.btHienThi.Text = "Hiển thị";
            this.btHienThi.UseVisualStyleBackColor = true;
            this.btHienThi.Click += new System.EventHandler(this.btHienThi_Click);
            // 
            // txtTGDo
            // 
            this.txtTGDo.Location = new System.Drawing.Point(172, 102);
            this.txtTGDo.Name = "txtTGDo";
            this.txtTGDo.Size = new System.Drawing.Size(62, 28);
            this.txtTGDo.TabIndex = 4;
            // 
            // txtTGXanh
            // 
            this.txtTGXanh.Location = new System.Drawing.Point(172, 34);
            this.txtTGXanh.Name = "txtTGXanh";
            this.txtTGXanh.Size = new System.Drawing.Size(62, 28);
            this.txtTGXanh.TabIndex = 3;
            // 
            // lblTGVang
            // 
            this.lblTGVang.AutoSize = true;
            this.lblTGVang.Location = new System.Drawing.Point(32, 171);
            this.lblTGVang.Name = "lblTGVang";
            this.lblTGVang.Size = new System.Drawing.Size(202, 22);
            this.lblTGVang.TabIndex = 2;
            this.lblTGVang.Text = "Thời gian vàng:    5 giây";
            // 
            // lblTGDo
            // 
            this.lblTGDo.AutoSize = true;
            this.lblTGDo.Location = new System.Drawing.Point(32, 108);
            this.lblTGDo.Name = "lblTGDo";
            this.lblTGDo.Size = new System.Drawing.Size(115, 22);
            this.lblTGDo.TabIndex = 1;
            this.lblTGDo.Text = "Thời gian đỏ:";
            // 
            // lblTGXanh
            // 
            this.lblTGXanh.AutoSize = true;
            this.lblTGXanh.Location = new System.Drawing.Point(32, 40);
            this.lblTGXanh.Name = "lblTGXanh";
            this.lblTGXanh.Size = new System.Drawing.Size(134, 22);
            this.lblTGXanh.TabIndex = 0;
            this.lblTGXanh.Text = "Thời gian xanh:";
            // 
            // grbDen
            // 
            this.grbDen.Controls.Add(this.picDo);
            this.grbDen.Controls.Add(this.picVang);
            this.grbDen.Controls.Add(this.picXanh);
            this.grbDen.Location = new System.Drawing.Point(12, 77);
            this.grbDen.Name = "grbDen";
            this.grbDen.Size = new System.Drawing.Size(162, 312);
            this.grbDen.TabIndex = 2;
            this.grbDen.TabStop = false;
            // 
            // picDo
            // 
            this.picDo.BackColor = System.Drawing.Color.Red;
            this.picDo.Location = new System.Drawing.Point(35, 213);
            this.picDo.Name = "picDo";
            this.picDo.Size = new System.Drawing.Size(90, 73);
            this.picDo.TabIndex = 2;
            this.picDo.TabStop = false;
            // 
            // picVang
            // 
            this.picVang.BackColor = System.Drawing.Color.Yellow;
            this.picVang.Location = new System.Drawing.Point(36, 120);
            this.picVang.Name = "picVang";
            this.picVang.Size = new System.Drawing.Size(90, 73);
            this.picVang.TabIndex = 1;
            this.picVang.TabStop = false;
            // 
            // picXanh
            // 
            this.picXanh.BackColor = System.Drawing.Color.LimeGreen;
            this.picXanh.Location = new System.Drawing.Point(35, 27);
            this.picXanh.Name = "picXanh";
            this.picXanh.Size = new System.Drawing.Size(90, 73);
            this.picXanh.TabIndex = 0;
            this.picXanh.TabStop = false;
            // 
            // lblTG
            // 
            this.lblTG.AutoSize = true;
            this.lblTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTG.Location = new System.Drawing.Point(9, 28);
            this.lblTG.Name = "lblTG";
            this.lblTG.Size = new System.Drawing.Size(77, 46);
            this.lblTG.TabIndex = 3;
            this.lblTG.Text = "TG";
            // 
            // Traffic_lights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(501, 401);
            this.Controls.Add(this.lblTG);
            this.Controls.Add(this.grbDen);
            this.Controls.Add(this.grbCH);
            this.Controls.Add(this.lblDGT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Traffic_lights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traffic_lights";
            this.grbCH.ResumeLayout(false);
            this.grbCH.PerformLayout();
            this.grbDen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDGT;
        private System.Windows.Forms.GroupBox grbCH;
        private System.Windows.Forms.GroupBox grbDen;
        private System.Windows.Forms.Label lblTGVang;
        private System.Windows.Forms.Label lblTGDo;
        private System.Windows.Forms.Label lblTGXanh;
        private System.Windows.Forms.PictureBox picDo;
        private System.Windows.Forms.PictureBox picVang;
        private System.Windows.Forms.PictureBox picXanh;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btHienThi;
        private System.Windows.Forms.TextBox txtTGDo;
        private System.Windows.Forms.TextBox txtTGXanh;
        private System.Windows.Forms.Label lblTG;
    }
}