namespace UCLN_BCNN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxNhap = new GroupBox();
            textBoxSoThuHai = new TextBox();
            textBoxSoThuNhat = new TextBox();
            groupBoxChonTim = new GroupBox();
            radioButtonBCNN = new RadioButton();
            radioButtonUCLN = new RadioButton();
            labelSoThuHai = new Label();
            labelSoThuNhat = new Label();
            groupBoxXuat = new GroupBox();
            buttonThoat = new Button();
            buttonBoQua = new Button();
            buttonTim = new Button();
            textBoxKetQua = new TextBox();
            labelKetQua = new Label();
            groupBoxNhap.SuspendLayout();
            groupBoxChonTim.SuspendLayout();
            groupBoxXuat.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxNhap
            // 
            groupBoxNhap.Controls.Add(textBoxSoThuHai);
            groupBoxNhap.Controls.Add(textBoxSoThuNhat);
            groupBoxNhap.Controls.Add(groupBoxChonTim);
            groupBoxNhap.Controls.Add(labelSoThuHai);
            groupBoxNhap.Controls.Add(labelSoThuNhat);
            groupBoxNhap.Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxNhap.Location = new Point(14, 27);
            groupBoxNhap.Name = "groupBoxNhap";
            groupBoxNhap.Size = new Size(510, 210);
            groupBoxNhap.TabIndex = 0;
            groupBoxNhap.TabStop = false;
            groupBoxNhap.Text = "Nhập";
            // 
            // textBoxSoThuHai
            // 
            textBoxSoThuHai.Location = new Point(174, 135);
            textBoxSoThuHai.Name = "textBoxSoThuHai";
            textBoxSoThuHai.Size = new Size(125, 28);
            textBoxSoThuHai.TabIndex = 4;
            // 
            // textBoxSoThuNhat
            // 
            textBoxSoThuNhat.Location = new Point(174, 69);
            textBoxSoThuNhat.Name = "textBoxSoThuNhat";
            textBoxSoThuNhat.Size = new Size(125, 28);
            textBoxSoThuNhat.TabIndex = 3;
            // 
            // groupBoxChonTim
            // 
            groupBoxChonTim.Controls.Add(radioButtonBCNN);
            groupBoxChonTim.Controls.Add(radioButtonUCLN);
            groupBoxChonTim.Location = new Point(317, 27);
            groupBoxChonTim.Name = "groupBoxChonTim";
            groupBoxChonTim.Size = new Size(154, 148);
            groupBoxChonTim.TabIndex = 2;
            groupBoxChonTim.TabStop = false;
            groupBoxChonTim.Text = "Chọn tìm:";
            // 
            // radioButtonBCNN
            // 
            radioButtonBCNN.AutoSize = true;
            radioButtonBCNN.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonBCNN.Location = new Point(32, 108);
            radioButtonBCNN.Name = "radioButtonBCNN";
            radioButtonBCNN.Size = new Size(66, 24);
            radioButtonBCNN.TabIndex = 1;
            radioButtonBCNN.TabStop = true;
            radioButtonBCNN.Text = "BCNN";
            radioButtonBCNN.UseVisualStyleBackColor = true;
            // 
            // radioButtonUCLN
            // 
            radioButtonUCLN.AutoSize = true;
            radioButtonUCLN.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonUCLN.Location = new Point(32, 42);
            radioButtonUCLN.Name = "radioButtonUCLN";
            radioButtonUCLN.Size = new Size(66, 24);
            radioButtonUCLN.TabIndex = 0;
            radioButtonUCLN.TabStop = true;
            radioButtonUCLN.Text = "UCLN";
            radioButtonUCLN.UseVisualStyleBackColor = true;
            // 
            // labelSoThuHai
            // 
            labelSoThuHai.AutoSize = true;
            labelSoThuHai.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSoThuHai.Location = new Point(42, 143);
            labelSoThuHai.Name = "labelSoThuHai";
            labelSoThuHai.Size = new Size(117, 20);
            labelSoThuHai.TabIndex = 1;
            labelSoThuHai.Text = "Số thứ hai: ";
            // 
            // labelSoThuNhat
            // 
            labelSoThuNhat.AutoSize = true;
            labelSoThuNhat.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSoThuNhat.Location = new Point(42, 76);
            labelSoThuNhat.Name = "labelSoThuNhat";
            labelSoThuNhat.Size = new Size(126, 20);
            labelSoThuNhat.TabIndex = 0;
            labelSoThuNhat.Text = "Số thứ nhất: ";
            // 
            // groupBoxXuat
            // 
            groupBoxXuat.Controls.Add(buttonThoat);
            groupBoxXuat.Controls.Add(buttonBoQua);
            groupBoxXuat.Controls.Add(buttonTim);
            groupBoxXuat.Controls.Add(textBoxKetQua);
            groupBoxXuat.Controls.Add(labelKetQua);
            groupBoxXuat.Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxXuat.Location = new Point(16, 256);
            groupBoxXuat.Name = "groupBoxXuat";
            groupBoxXuat.Size = new Size(508, 185);
            groupBoxXuat.TabIndex = 0;
            groupBoxXuat.TabStop = false;
            groupBoxXuat.Text = "Xuất";
            // 
            // buttonThoat
            // 
            buttonThoat.BackColor = Color.DeepSkyBlue;
            buttonThoat.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonThoat.Location = new Point(347, 132);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(94, 29);
            buttonThoat.TabIndex = 7;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = false;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // buttonBoQua
            // 
            buttonBoQua.BackColor = Color.DeepSkyBlue;
            buttonBoQua.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBoQua.Location = new Point(347, 82);
            buttonBoQua.Name = "buttonBoQua";
            buttonBoQua.Size = new Size(94, 29);
            buttonBoQua.TabIndex = 6;
            buttonBoQua.Text = "Bỏ Qua";
            buttonBoQua.UseVisualStyleBackColor = false;
            buttonBoQua.Click += buttonBoQua_Click;
            // 
            // buttonTim
            // 
            buttonTim.BackColor = Color.DeepSkyBlue;
            buttonTim.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTim.Location = new Point(347, 27);
            buttonTim.Name = "buttonTim";
            buttonTim.Size = new Size(94, 29);
            buttonTim.TabIndex = 5;
            buttonTim.Text = "Tìm";
            buttonTim.UseVisualStyleBackColor = false;
            buttonTim.Click += buttonTim_Click;
            // 
            // textBoxKetQua
            // 
            textBoxKetQua.Location = new Point(172, 83);
            textBoxKetQua.Name = "textBoxKetQua";
            textBoxKetQua.Size = new Size(125, 28);
            textBoxKetQua.TabIndex = 4;
            // 
            // labelKetQua
            // 
            labelKetQua.AutoSize = true;
            labelKetQua.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelKetQua.Location = new Point(40, 91);
            labelKetQua.Name = "labelKetQua";
            labelKetQua.Size = new Size(81, 20);
            labelKetQua.TabIndex = 0;
            labelKetQua.Text = "Kết quả:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(548, 462);
            Controls.Add(groupBoxXuat);
            Controls.Add(groupBoxNhap);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_UCLN-BCNN";
            Load += Form1_Load;
            groupBoxNhap.ResumeLayout(false);
            groupBoxNhap.PerformLayout();
            groupBoxChonTim.ResumeLayout(false);
            groupBoxChonTim.PerformLayout();
            groupBoxXuat.ResumeLayout(false);
            groupBoxXuat.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxNhap;
        private Label labelSoThuNhat;
        private GroupBox groupBoxXuat;
        private TextBox textBoxSoThuHai;
        private TextBox textBoxSoThuNhat;
        private GroupBox groupBoxChonTim;
        private Label labelSoThuHai;
        private RadioButton radioButtonBCNN;
        private RadioButton radioButtonUCLN;
        private Button buttonTim;
        private TextBox textBoxKetQua;
        private Label labelKetQua;
        private Button buttonThoat;
        private Button buttonBoQua;
    }
}
