namespace MusicGame
{
    partial class MusicGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicGame));
            this.gbTuyChon = new System.Windows.Forms.GroupBox();
            this.rbtKho = new System.Windows.Forms.RadioButton();
            this.rbtVua = new System.Windows.Forms.RadioButton();
            this.rbtDe = new System.Windows.Forms.RadioButton();
            this.DanhSachBaiHat = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.BaiHatDaNhap = new System.Windows.Forms.ListBox();
            this.lblNhap = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btStart = new System.Windows.Forms.Button();
            this.gbTuyChon.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTuyChon
            // 
            this.gbTuyChon.Controls.Add(this.rbtKho);
            this.gbTuyChon.Controls.Add(this.rbtVua);
            this.gbTuyChon.Controls.Add(this.rbtDe);
            this.gbTuyChon.Location = new System.Drawing.Point(346, 30);
            this.gbTuyChon.Name = "gbTuyChon";
            this.gbTuyChon.Size = new System.Drawing.Size(222, 227);
            this.gbTuyChon.TabIndex = 0;
            this.gbTuyChon.TabStop = false;
            this.gbTuyChon.Text = "Tùy chọn";
            // 
            // rbtKho
            // 
            this.rbtKho.AutoSize = true;
            this.rbtKho.Location = new System.Drawing.Point(34, 173);
            this.rbtKho.Name = "rbtKho";
            this.rbtKho.Size = new System.Drawing.Size(69, 29);
            this.rbtKho.TabIndex = 2;
            this.rbtKho.TabStop = true;
            this.rbtKho.Text = "Khó";
            this.rbtKho.UseVisualStyleBackColor = true;
            // 
            // rbtVua
            // 
            this.rbtVua.AutoSize = true;
            this.rbtVua.Location = new System.Drawing.Point(34, 115);
            this.rbtVua.Name = "rbtVua";
            this.rbtVua.Size = new System.Drawing.Size(69, 29);
            this.rbtVua.TabIndex = 1;
            this.rbtVua.TabStop = true;
            this.rbtVua.Text = "Vừa";
            this.rbtVua.UseVisualStyleBackColor = true;
            // 
            // rbtDe
            // 
            this.rbtDe.AutoSize = true;
            this.rbtDe.Location = new System.Drawing.Point(34, 54);
            this.rbtDe.Name = "rbtDe";
            this.rbtDe.Size = new System.Drawing.Size(58, 29);
            this.rbtDe.TabIndex = 0;
            this.rbtDe.TabStop = true;
            this.rbtDe.Text = "Dễ";
            this.rbtDe.UseVisualStyleBackColor = true;
            // 
            // DanhSachBaiHat
            // 
            this.DanhSachBaiHat.BackColor = System.Drawing.Color.MistyRose;
            this.DanhSachBaiHat.FormattingEnabled = true;
            this.DanhSachBaiHat.ItemHeight = 25;
            this.DanhSachBaiHat.Location = new System.Drawing.Point(34, 30);
            this.DanhSachBaiHat.Name = "DanhSachBaiHat";
            this.DanhSachBaiHat.Size = new System.Drawing.Size(254, 404);
            this.DanhSachBaiHat.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btCheck);
            this.groupBox1.Controls.Add(this.BaiHatDaNhap);
            this.groupBox1.Location = new System.Drawing.Point(610, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 389);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Tomato;
            this.btThoat.Location = new System.Drawing.Point(272, 304);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(101, 46);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Gold;
            this.btXoa.Location = new System.Drawing.Point(160, 304);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(91, 46);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btCheck
            // 
            this.btCheck.BackColor = System.Drawing.Color.Cyan;
            this.btCheck.Location = new System.Drawing.Point(29, 304);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(101, 46);
            this.btCheck.TabIndex = 1;
            this.btCheck.Text = "Check";
            this.btCheck.UseVisualStyleBackColor = false;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // BaiHatDaNhap
            // 
            this.BaiHatDaNhap.BackColor = System.Drawing.Color.Bisque;
            this.BaiHatDaNhap.FormattingEnabled = true;
            this.BaiHatDaNhap.ItemHeight = 25;
            this.BaiHatDaNhap.Location = new System.Drawing.Point(29, 51);
            this.BaiHatDaNhap.Name = "BaiHatDaNhap";
            this.BaiHatDaNhap.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.BaiHatDaNhap.Size = new System.Drawing.Size(342, 229);
            this.BaiHatDaNhap.TabIndex = 0;
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(115, 463);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(160, 25);
            this.lblNhap.TabIndex = 3;
            this.lblNhap.Text = "Nhập tên bài hát:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(287, 460);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(323, 30);
            this.txtNhap.TabIndex = 4;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Lime;
            this.btThem.Location = new System.Drawing.Point(658, 456);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(101, 38);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.BackColor = System.Drawing.Color.MistyRose;
            this.txtDiem.Location = new System.Drawing.Point(882, 440);
            this.txtDiem.Multiline = true;
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(99, 54);
            this.txtDiem.TabIndex = 6;
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(346, 277);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(222, 157);
            this.WindowsMediaPlayer.TabIndex = 7;
            this.WindowsMediaPlayer.Visible = false;
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btStart.Location = new System.Drawing.Point(34, 456);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 38);
            this.btStart.TabIndex = 8;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // MusicGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1044, 545);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DanhSachBaiHat);
            this.Controls.Add(this.gbTuyChon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MusicGame";
            this.Text = "MusicGame";
            this.gbTuyChon.ResumeLayout(false);
            this.gbTuyChon.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTuyChon;
        private System.Windows.Forms.ListBox DanhSachBaiHat;
        private System.Windows.Forms.RadioButton rbtKho;
        private System.Windows.Forms.RadioButton rbtVua;
        private System.Windows.Forms.RadioButton rbtDe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox BaiHatDaNhap;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtDiem;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Button btStart;
    }
}