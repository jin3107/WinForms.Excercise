namespace DenGiaoThong
{
    partial class DenGiaoThongForm
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
            groupBoxCauHinh = new GroupBox();
            buttonThoat = new Button();
            buttonHienThi = new Button();
            textBoxTgDo = new TextBox();
            textBoxTgXanh = new TextBox();
            labelTgDo = new Label();
            labelTgVang = new Label();
            labelTgXanh = new Label();
            labelTieuDe = new Label();
            pictureBoxXanh = new PictureBox();
            pictureBoxVang = new PictureBox();
            pictureBoxDo = new PictureBox();
            groupBoxDen = new GroupBox();
            labelTG = new Label();
            groupBoxCauHinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxXanh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDo).BeginInit();
            groupBoxDen.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCauHinh
            // 
            groupBoxCauHinh.Controls.Add(buttonThoat);
            groupBoxCauHinh.Controls.Add(buttonHienThi);
            groupBoxCauHinh.Controls.Add(textBoxTgDo);
            groupBoxCauHinh.Controls.Add(textBoxTgXanh);
            groupBoxCauHinh.Controls.Add(labelTgDo);
            groupBoxCauHinh.Controls.Add(labelTgVang);
            groupBoxCauHinh.Controls.Add(labelTgXanh);
            groupBoxCauHinh.Location = new Point(197, 112);
            groupBoxCauHinh.Name = "groupBoxCauHinh";
            groupBoxCauHinh.Size = new Size(315, 332);
            groupBoxCauHinh.TabIndex = 0;
            groupBoxCauHinh.TabStop = false;
            groupBoxCauHinh.Text = "Cấu hình";
            // 
            // buttonThoat
            // 
            buttonThoat.Location = new Point(178, 267);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(99, 40);
            buttonThoat.TabIndex = 6;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // buttonHienThi
            // 
            buttonHienThi.Location = new Point(44, 267);
            buttonHienThi.Name = "buttonHienThi";
            buttonHienThi.Size = new Size(99, 40);
            buttonHienThi.TabIndex = 5;
            buttonHienThi.Text = "Hiển thị";
            buttonHienThi.UseVisualStyleBackColor = true;
            buttonHienThi.Click += buttonHienThi_Click;
            // 
            // textBoxTgDo
            // 
            textBoxTgDo.Location = new Point(209, 144);
            textBoxTgDo.Name = "textBoxTgDo";
            textBoxTgDo.Size = new Size(65, 34);
            textBoxTgDo.TabIndex = 4;
            // 
            // textBoxTgXanh
            // 
            textBoxTgXanh.Location = new Point(209, 68);
            textBoxTgXanh.Name = "textBoxTgXanh";
            textBoxTgXanh.Size = new Size(65, 34);
            textBoxTgXanh.TabIndex = 3;
            // 
            // labelTgDo
            // 
            labelTgDo.AutoSize = true;
            labelTgDo.Location = new Point(41, 147);
            labelTgDo.Name = "labelTgDo";
            labelTgDo.Size = new Size(126, 28);
            labelTgDo.TabIndex = 2;
            labelTgDo.Text = "Thời gian đỏ:";
            // 
            // labelTgVang
            // 
            labelTgVang.AutoSize = true;
            labelTgVang.Location = new Point(44, 212);
            labelTgVang.Name = "labelTgVang";
            labelTgVang.Size = new Size(233, 28);
            labelTgVang.TabIndex = 1;
            labelTgVang.Text = "Thời gian vàng:       5 giây";
            // 
            // labelTgXanh
            // 
            labelTgXanh.AutoSize = true;
            labelTgXanh.Location = new Point(41, 71);
            labelTgXanh.Name = "labelTgXanh";
            labelTgXanh.Size = new Size(143, 28);
            labelTgXanh.TabIndex = 0;
            labelTgXanh.Text = "Thời gian xanh:";
            // 
            // labelTieuDe
            // 
            labelTieuDe.AutoSize = true;
            labelTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTieuDe.ForeColor = Color.DodgerBlue;
            labelTieuDe.Location = new Point(52, 18);
            labelTieuDe.Name = "labelTieuDe";
            labelTieuDe.Size = new Size(442, 41);
            labelTieuDe.TabIndex = 2;
            labelTieuDe.Text = "TÍNH HIỆU ĐÈN GIAO THÔNG";
            // 
            // pictureBoxXanh
            // 
            pictureBoxXanh.BackColor = Color.Lime;
            pictureBoxXanh.BackgroundImageLayout = ImageLayout.None;
            pictureBoxXanh.Location = new Point(26, 33);
            pictureBoxXanh.Name = "pictureBoxXanh";
            pictureBoxXanh.Size = new Size(89, 77);
            pictureBoxXanh.TabIndex = 3;
            pictureBoxXanh.TabStop = false;
            pictureBoxXanh.Click += pictureBoxXanh_Click;
            // 
            // pictureBoxVang
            // 
            pictureBoxVang.BackColor = Color.Yellow;
            pictureBoxVang.Location = new Point(26, 130);
            pictureBoxVang.Name = "pictureBoxVang";
            pictureBoxVang.Size = new Size(89, 83);
            pictureBoxVang.TabIndex = 4;
            pictureBoxVang.TabStop = false;
            pictureBoxVang.Click += pictureBoxVang_Click;
            // 
            // pictureBoxDo
            // 
            pictureBoxDo.BackColor = Color.Red;
            pictureBoxDo.Location = new Point(26, 243);
            pictureBoxDo.Name = "pictureBoxDo";
            pictureBoxDo.Size = new Size(89, 83);
            pictureBoxDo.TabIndex = 5;
            pictureBoxDo.TabStop = false;
            pictureBoxDo.Click += pictureBoxDo_Click;
            // 
            // groupBoxDen
            // 
            groupBoxDen.Controls.Add(pictureBoxXanh);
            groupBoxDen.Controls.Add(pictureBoxDo);
            groupBoxDen.Controls.Add(pictureBoxVang);
            groupBoxDen.Location = new Point(26, 112);
            groupBoxDen.Name = "groupBoxDen";
            groupBoxDen.Size = new Size(142, 359);
            groupBoxDen.TabIndex = 6;
            groupBoxDen.TabStop = false;
            groupBoxDen.Enter += groupBoxDen_Enter;
            // 
            // labelTG
            // 
            labelTG.AutoSize = true;
            labelTG.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTG.Location = new Point(26, 71);
            labelTG.Name = "labelTG";
            labelTG.Size = new Size(0, 38);
            labelTG.TabIndex = 7;
            labelTG.Click += labelTG_Click;
            // 
            // DenGiaoThongForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(547, 483);
            Controls.Add(labelTG);
            Controls.Add(groupBoxDen);
            Controls.Add(labelTieuDe);
            Controls.Add(groupBoxCauHinh);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "DenGiaoThongForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DenGiaoThongForm";
            Load += DenGiaoThongForm_Load;
            groupBoxCauHinh.ResumeLayout(false);
            groupBoxCauHinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxXanh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDo).EndInit();
            groupBoxDen.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCauHinh;
        private TextBox textBoxTgXanh;
        private Label labelTgDo;
        private Label labelTgVang;
        private Label labelTgXanh;
        private TextBox textBoxTgDo;
        private Label labelTieuDe;
        private Button buttonThoat;
        private Button buttonHienThi;
        private PictureBox pictureBoxXanh;
        private PictureBox pictureBoxVang;
        private PictureBox pictureBoxDo;
        private GroupBox groupBoxDen;
        private Label labelTG;
    }
}