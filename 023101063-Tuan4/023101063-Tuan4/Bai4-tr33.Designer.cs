namespace _023101063_Tuan4
{
    partial class Bai4_tr33
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
            this.DanhSachCacNuoc = new System.Windows.Forms.ListBox();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DanhSachCacNuoc
            // 
            this.DanhSachCacNuoc.FormattingEnabled = true;
            this.DanhSachCacNuoc.ItemHeight = 22;
            this.DanhSachCacNuoc.Location = new System.Drawing.Point(21, 48);
            this.DanhSachCacNuoc.Name = "DanhSachCacNuoc";
            this.DanhSachCacNuoc.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.DanhSachCacNuoc.Size = new System.Drawing.Size(346, 180);
            this.DanhSachCacNuoc.TabIndex = 0;
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.Location = new System.Drawing.Point(402, 98);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(96, 25);
            this.lblNoiDung.TabIndex = 1;
            this.lblNoiDung.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(504, 95);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(249, 28);
            this.txtNoiDung.TabIndex = 2;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.LawnGreen;
            this.btThem.Location = new System.Drawing.Point(21, 249);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(109, 47);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "THÊM";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Crimson;
            this.btXoa.Location = new System.Drawing.Point(203, 249);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(109, 47);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "XÓA";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.BackColor = System.Drawing.Color.Yellow;
            this.btCapNhat.Location = new System.Drawing.Point(407, 249);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(145, 47);
            this.btCapNhat.TabIndex = 5;
            this.btCapNhat.Text = "CẬP NHẬT";
            this.btCapNhat.UseVisualStyleBackColor = false;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btThoat.Location = new System.Drawing.Point(644, 249);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(109, 47);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // Bai4_tr33
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 321);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.DanhSachCacNuoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bai4_tr33";
            this.Text = "Bai4_tr33";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DanhSachCacNuoc;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btThoat;
    }
}