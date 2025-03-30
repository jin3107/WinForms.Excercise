namespace BT_BS2
{
    partial class Taxi
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
            this.lblTaxi = new System.Windows.Forms.Label();
            this.lblNhapKm = new System.Windows.Forms.Label();
            this.grbBangKe = new System.Windows.Forms.GroupBox();
            this.lblMuc1 = new System.Windows.Forms.Label();
            this.lblMuc2 = new System.Windows.Forms.Label();
            this.lblMuc3 = new System.Windows.Forms.Label();
            this.lblMuc4 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtSoKm = new System.Windows.Forms.TextBox();
            this.btTinhTien = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.grbBangKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTaxi
            // 
            this.lblTaxi.AutoSize = true;
            this.lblTaxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxi.ForeColor = System.Drawing.Color.Red;
            this.lblTaxi.Location = new System.Drawing.Point(86, 9);
            this.lblTaxi.Name = "lblTaxi";
            this.lblTaxi.Size = new System.Drawing.Size(411, 29);
            this.lblTaxi.TabIndex = 0;
            this.lblTaxi.Text = "CHƯƠNG TRÌNH TÍNH TIỀN TAXI";
            // 
            // lblNhapKm
            // 
            this.lblNhapKm.AutoSize = true;
            this.lblNhapKm.Location = new System.Drawing.Point(25, 67);
            this.lblNhapKm.Name = "lblNhapKm";
            this.lblNhapKm.Size = new System.Drawing.Size(110, 22);
            this.lblNhapKm.TabIndex = 1;
            this.lblNhapKm.Text = "Nhập số km:";
            // 
            // grbBangKe
            // 
            this.grbBangKe.Controls.Add(this.lblTongTien);
            this.grbBangKe.Controls.Add(this.lblMuc4);
            this.grbBangKe.Controls.Add(this.lblMuc3);
            this.grbBangKe.Controls.Add(this.lblMuc2);
            this.grbBangKe.Controls.Add(this.lblMuc1);
            this.grbBangKe.Location = new System.Drawing.Point(29, 142);
            this.grbBangKe.Name = "grbBangKe";
            this.grbBangKe.Size = new System.Drawing.Size(369, 236);
            this.grbBangKe.TabIndex = 2;
            this.grbBangKe.TabStop = false;
            this.grbBangKe.Text = "Bảng kê chi tiết";
            // 
            // lblMuc1
            // 
            this.lblMuc1.AutoSize = true;
            this.lblMuc1.Location = new System.Drawing.Point(30, 46);
            this.lblMuc1.Name = "lblMuc1";
            this.lblMuc1.Size = new System.Drawing.Size(148, 22);
            this.lblMuc1.TabIndex = 2;
            this.lblMuc1.Text = "Số tiền Mức 1 là: ";
            // 
            // lblMuc2
            // 
            this.lblMuc2.AutoSize = true;
            this.lblMuc2.Location = new System.Drawing.Point(30, 85);
            this.lblMuc2.Name = "lblMuc2";
            this.lblMuc2.Size = new System.Drawing.Size(143, 22);
            this.lblMuc2.TabIndex = 3;
            this.lblMuc2.Text = "Số tiền Mức 2 là:";
            // 
            // lblMuc3
            // 
            this.lblMuc3.AutoSize = true;
            this.lblMuc3.Location = new System.Drawing.Point(30, 120);
            this.lblMuc3.Name = "lblMuc3";
            this.lblMuc3.Size = new System.Drawing.Size(143, 22);
            this.lblMuc3.TabIndex = 4;
            this.lblMuc3.Text = "Số tiền Mức 3 là:";
            // 
            // lblMuc4
            // 
            this.lblMuc4.AutoSize = true;
            this.lblMuc4.Location = new System.Drawing.Point(30, 157);
            this.lblMuc4.Name = "lblMuc4";
            this.lblMuc4.Size = new System.Drawing.Size(143, 22);
            this.lblMuc4.TabIndex = 5;
            this.lblMuc4.Text = "Số tiền Mức 4 là:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(47, 195);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(252, 22);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "Số kmTổng tiền phải trả là:";
            // 
            // txtSoKm
            // 
            this.txtSoKm.Location = new System.Drawing.Point(186, 61);
            this.txtSoKm.Name = "txtSoKm";
            this.txtSoKm.Size = new System.Drawing.Size(212, 28);
            this.txtSoKm.TabIndex = 3;
            // 
            // btTinhTien
            // 
            this.btTinhTien.Location = new System.Drawing.Point(424, 61);
            this.btTinhTien.Name = "btTinhTien";
            this.btTinhTien.Size = new System.Drawing.Size(111, 39);
            this.btTinhTien.TabIndex = 4;
            this.btTinhTien.Text = "Tính tiền";
            this.btTinhTien.UseVisualStyleBackColor = true;
            this.btTinhTien.Click += new System.EventHandler(this.btTinhTien_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(424, 136);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(111, 39);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // Taxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(555, 393);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTinhTien);
            this.Controls.Add(this.txtSoKm);
            this.Controls.Add(this.grbBangKe);
            this.Controls.Add(this.lblNhapKm);
            this.Controls.Add(this.lblTaxi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Taxi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taxi";
            this.Load += new System.EventHandler(this.Taxi_Load);
            this.grbBangKe.ResumeLayout(false);
            this.grbBangKe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaxi;
        private System.Windows.Forms.Label lblNhapKm;
        private System.Windows.Forms.GroupBox grbBangKe;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblMuc4;
        private System.Windows.Forms.Label lblMuc3;
        private System.Windows.Forms.Label lblMuc2;
        private System.Windows.Forms.Label lblMuc1;
        private System.Windows.Forms.TextBox txtSoKm;
        private System.Windows.Forms.Button btTinhTien;
        private System.Windows.Forms.Button btThoat;
    }
}