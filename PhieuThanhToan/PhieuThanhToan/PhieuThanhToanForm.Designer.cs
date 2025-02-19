namespace PhieuThanhToan
{
    partial class PhieuThanhToanForm
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
            labelPhieuThanhToan = new Label();
            labelTenKhacHang = new Label();
            checkBoxCaoVoi = new CheckBox();
            checkBoxChupHinhRang = new CheckBox();
            checkBoxTayRang = new CheckBox();
            label1tr200k = new Label();
            label200k = new Label();
            label100k = new Label();
            textBoxTenKhachHang = new TextBox();
            labelTramRang = new Label();
            label80k = new Label();
            labelTongTien = new Label();
            labelKetQua = new Label();
            buttonTinh = new Button();
            buttonThoat = new Button();
            numericUpDownTramRang = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTramRang).BeginInit();
            SuspendLayout();
            // 
            // labelPhieuThanhToan
            // 
            labelPhieuThanhToan.AutoSize = true;
            labelPhieuThanhToan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPhieuThanhToan.Location = new Point(100, 23);
            labelPhieuThanhToan.Name = "labelPhieuThanhToan";
            labelPhieuThanhToan.Size = new Size(276, 38);
            labelPhieuThanhToan.TabIndex = 0;
            labelPhieuThanhToan.Text = "PHIẾU THANH TOÁN";
            // 
            // labelTenKhacHang
            // 
            labelTenKhacHang.AutoSize = true;
            labelTenKhacHang.Location = new Point(30, 95);
            labelTenKhacHang.Name = "labelTenKhacHang";
            labelTenKhacHang.Size = new Size(150, 28);
            labelTenKhacHang.TabIndex = 1;
            labelTenKhacHang.Text = "Tên khách hàng:";
            // 
            // checkBoxCaoVoi
            // 
            checkBoxCaoVoi.AutoSize = true;
            checkBoxCaoVoi.Location = new Point(30, 172);
            checkBoxCaoVoi.Name = "checkBoxCaoVoi";
            checkBoxCaoVoi.Size = new Size(100, 32);
            checkBoxCaoVoi.TabIndex = 2;
            checkBoxCaoVoi.Text = "Cạo vôi";
            checkBoxCaoVoi.UseVisualStyleBackColor = true;
            checkBoxCaoVoi.CheckedChanged += checkBoxCaoVoi_CheckedChanged;
            // 
            // checkBoxChupHinhRang
            // 
            checkBoxChupHinhRang.AutoSize = true;
            checkBoxChupHinhRang.Location = new Point(30, 331);
            checkBoxChupHinhRang.Name = "checkBoxChupHinhRang";
            checkBoxChupHinhRang.Size = new Size(168, 32);
            checkBoxChupHinhRang.TabIndex = 3;
            checkBoxChupHinhRang.Text = "Chụp hình răng";
            checkBoxChupHinhRang.UseVisualStyleBackColor = true;
            checkBoxChupHinhRang.CheckedChanged += checkBoxChupHinhRang_CheckedChanged;
            // 
            // checkBoxTayRang
            // 
            checkBoxTayRang.AutoSize = true;
            checkBoxTayRang.Location = new Point(30, 252);
            checkBoxTayRang.Name = "checkBoxTayRang";
            checkBoxTayRang.Size = new Size(109, 32);
            checkBoxTayRang.TabIndex = 4;
            checkBoxTayRang.Text = "Tẩy răng";
            checkBoxTayRang.UseVisualStyleBackColor = true;
            checkBoxTayRang.CheckedChanged += checkBoxTayRang_CheckedChanged;
            // 
            // label1tr200k
            // 
            label1tr200k.AutoSize = true;
            label1tr200k.Location = new Point(332, 254);
            label1tr200k.Name = "label1tr200k";
            label1tr200k.Size = new Size(143, 28);
            label1tr200k.TabIndex = 5;
            label1tr200k.Text = "1.200.000 VNĐ";
            // 
            // label200k
            // 
            label200k.AutoSize = true;
            label200k.Location = new Point(332, 333);
            label200k.Name = "label200k";
            label200k.Size = new Size(128, 28);
            label200k.TabIndex = 6;
            label200k.Text = "200.000 VNĐ";
            // 
            // label100k
            // 
            label100k.AutoSize = true;
            label100k.Location = new Point(332, 174);
            label100k.Name = "label100k";
            label100k.Size = new Size(128, 28);
            label100k.TabIndex = 7;
            label100k.Text = "100.000 VNĐ";
            // 
            // textBoxTenKhachHang
            // 
            textBoxTenKhachHang.Location = new Point(218, 92);
            textBoxTenKhachHang.Name = "textBoxTenKhachHang";
            textBoxTenKhachHang.Size = new Size(242, 34);
            textBoxTenKhachHang.TabIndex = 8;
            textBoxTenKhachHang.TextChanged += textBoxTenKhachHang_TextChanged;
            // 
            // labelTramRang
            // 
            labelTramRang.AutoSize = true;
            labelTramRang.Location = new Point(30, 408);
            labelTramRang.Name = "labelTramRang";
            labelTramRang.Size = new Size(103, 28);
            labelTramRang.TabIndex = 9;
            labelTramRang.Text = "Trám răng:";
            // 
            // label80k
            // 
            label80k.AutoSize = true;
            label80k.Location = new Point(332, 408);
            label80k.Name = "label80k";
            label80k.Size = new Size(117, 28);
            label80k.TabIndex = 11;
            label80k.Text = "80.000 VNĐ";
            // 
            // labelTongTien
            // 
            labelTongTien.AutoSize = true;
            labelTongTien.Location = new Point(30, 477);
            labelTongTien.Name = "labelTongTien";
            labelTongTien.Size = new Size(99, 28);
            labelTongTien.TabIndex = 12;
            labelTongTien.Text = "Tổng tiền:";
            // 
            // labelKetQua
            // 
            labelKetQua.AutoSize = true;
            labelKetQua.Location = new Point(149, 477);
            labelKetQua.Name = "labelKetQua";
            labelKetQua.Size = new Size(0, 28);
            labelKetQua.TabIndex = 13;
            // 
            // buttonTinh
            // 
            buttonTinh.BackColor = Color.LightGreen;
            buttonTinh.Location = new Point(30, 545);
            buttonTinh.Name = "buttonTinh";
            buttonTinh.Size = new Size(91, 50);
            buttonTinh.TabIndex = 14;
            buttonTinh.Text = "TÍNH";
            buttonTinh.UseVisualStyleBackColor = false;
            buttonTinh.Click += buttonTinh_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.BackColor = Color.LightCoral;
            buttonThoat.Location = new Point(323, 545);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(91, 50);
            buttonThoat.TabIndex = 15;
            buttonThoat.Text = "THOÁT";
            buttonThoat.UseVisualStyleBackColor = false;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // numericUpDownTramRang
            // 
            numericUpDownTramRang.Location = new Point(149, 405);
            numericUpDownTramRang.Name = "numericUpDownTramRang";
            numericUpDownTramRang.Size = new Size(100, 34);
            numericUpDownTramRang.TabIndex = 16;
            // 
            // PhieuThanhToanForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(505, 625);
            Controls.Add(numericUpDownTramRang);
            Controls.Add(buttonThoat);
            Controls.Add(buttonTinh);
            Controls.Add(labelKetQua);
            Controls.Add(labelTongTien);
            Controls.Add(label80k);
            Controls.Add(labelTramRang);
            Controls.Add(textBoxTenKhachHang);
            Controls.Add(label100k);
            Controls.Add(label200k);
            Controls.Add(label1tr200k);
            Controls.Add(checkBoxTayRang);
            Controls.Add(checkBoxChupHinhRang);
            Controls.Add(checkBoxCaoVoi);
            Controls.Add(labelTenKhacHang);
            Controls.Add(labelPhieuThanhToan);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "PhieuThanhToanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhieuThanhToanForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTramRang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPhieuThanhToan;
        private Label labelTenKhacHang;
        private CheckBox checkBoxCaoVoi;
        private CheckBox checkBoxChupHinhRang;
        private CheckBox checkBoxTayRang;
        private Label label1tr200k;
        private Label label200k;
        private Label label100k;
        private TextBox textBoxTenKhachHang;
        private Label labelTramRang;
        private Label label80k;
        private Label labelTongTien;
        private Label labelKetQua;
        private Button buttonTinh;
        private Button buttonThoat;
        private NumericUpDown numericUpDownTramRang;
    }
}