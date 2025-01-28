namespace UCLN_BCNN
{
    partial class frmUCLNBCNN
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
            this.NhapGroupBox = new System.Windows.Forms.GroupBox();
            this.ChonTimGroupBox = new System.Windows.Forms.GroupBox();
            this.UCLNRadioButton = new System.Windows.Forms.RadioButton();
            this.SoThuHaiTextBox = new System.Windows.Forms.TextBox();
            this.SoThuNhatTextBox = new System.Windows.Forms.TextBox();
            this.SoThuHaiLabel = new System.Windows.Forms.Label();
            this.SoThuNhatLabel = new System.Windows.Forms.Label();
            this.XuatGroupBox = new System.Windows.Forms.GroupBox();
            this.KetQuaTextBox = new System.Windows.Forms.TextBox();
            this.ThoatButton = new System.Windows.Forms.Button();
            this.BoQuaButton = new System.Windows.Forms.Button();
            this.TimButton = new System.Windows.Forms.Button();
            this.BCNNRadioButton = new System.Windows.Forms.RadioButton();
            this.NhapGroupBox.SuspendLayout();
            this.ChonTimGroupBox.SuspendLayout();
            this.XuatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NhapGroupBox
            // 
            this.NhapGroupBox.Controls.Add(this.ChonTimGroupBox);
            this.NhapGroupBox.Controls.Add(this.SoThuHaiTextBox);
            this.NhapGroupBox.Controls.Add(this.SoThuNhatTextBox);
            this.NhapGroupBox.Controls.Add(this.SoThuHaiLabel);
            this.NhapGroupBox.Controls.Add(this.SoThuNhatLabel);
            this.NhapGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapGroupBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NhapGroupBox.Location = new System.Drawing.Point(12, 22);
            this.NhapGroupBox.Name = "NhapGroupBox";
            this.NhapGroupBox.Size = new System.Drawing.Size(563, 226);
            this.NhapGroupBox.TabIndex = 0;
            this.NhapGroupBox.TabStop = false;
            this.NhapGroupBox.Text = "Nhập";
            this.NhapGroupBox.Enter += new System.EventHandler(this.NhapGroupBox_Enter);
            // 
            // ChonTimGroupBox
            // 
            this.ChonTimGroupBox.Controls.Add(this.BCNNRadioButton);
            this.ChonTimGroupBox.Controls.Add(this.UCLNRadioButton);
            this.ChonTimGroupBox.Location = new System.Drawing.Point(356, 21);
            this.ChonTimGroupBox.Name = "ChonTimGroupBox";
            this.ChonTimGroupBox.Size = new System.Drawing.Size(188, 171);
            this.ChonTimGroupBox.TabIndex = 4;
            this.ChonTimGroupBox.TabStop = false;
            this.ChonTimGroupBox.Text = "Chọn tìm";
            // 
            // UCLNRadioButton
            // 
            this.UCLNRadioButton.AutoSize = true;
            this.UCLNRadioButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.UCLNRadioButton.Location = new System.Drawing.Point(29, 41);
            this.UCLNRadioButton.Name = "UCLNRadioButton";
            this.UCLNRadioButton.Size = new System.Drawing.Size(68, 20);
            this.UCLNRadioButton.TabIndex = 0;
            this.UCLNRadioButton.TabStop = true;
            this.UCLNRadioButton.Text = "UCLN";
            this.UCLNRadioButton.UseVisualStyleBackColor = false;
            this.UCLNRadioButton.CheckedChanged += new System.EventHandler(this.UCLNRadioButton_CheckedChanged);
            // 
            // SoThuHaiTextBox
            // 
            this.SoThuHaiTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoThuHaiTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.SoThuHaiTextBox.Location = new System.Drawing.Point(158, 135);
            this.SoThuHaiTextBox.Name = "SoThuHaiTextBox";
            this.SoThuHaiTextBox.Size = new System.Drawing.Size(172, 22);
            this.SoThuHaiTextBox.TabIndex = 3;
            this.SoThuHaiTextBox.TextChanged += new System.EventHandler(this.SoThuHaiTextBox_TextChanged);
            // 
            // SoThuNhatTextBox
            // 
            this.SoThuNhatTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoThuNhatTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.SoThuNhatTextBox.Location = new System.Drawing.Point(158, 61);
            this.SoThuNhatTextBox.Name = "SoThuNhatTextBox";
            this.SoThuNhatTextBox.Size = new System.Drawing.Size(172, 22);
            this.SoThuNhatTextBox.TabIndex = 2;
            this.SoThuNhatTextBox.TextChanged += new System.EventHandler(this.SoThuNhatTextBox_TextChanged);
            // 
            // SoThuHaiLabel
            // 
            this.SoThuHaiLabel.AutoSize = true;
            this.SoThuHaiLabel.Location = new System.Drawing.Point(42, 141);
            this.SoThuHaiLabel.Name = "SoThuHaiLabel";
            this.SoThuHaiLabel.Size = new System.Drawing.Size(79, 16);
            this.SoThuHaiLabel.TabIndex = 1;
            this.SoThuHaiLabel.Text = "Số thứ hai:";
            // 
            // SoThuNhatLabel
            // 
            this.SoThuNhatLabel.AutoSize = true;
            this.SoThuNhatLabel.Location = new System.Drawing.Point(42, 67);
            this.SoThuNhatLabel.Name = "SoThuNhatLabel";
            this.SoThuNhatLabel.Size = new System.Drawing.Size(87, 16);
            this.SoThuNhatLabel.TabIndex = 0;
            this.SoThuNhatLabel.Text = "Số thứ nhất:";
            // 
            // XuatGroupBox
            // 
            this.XuatGroupBox.Controls.Add(this.KetQuaTextBox);
            this.XuatGroupBox.Controls.Add(this.ThoatButton);
            this.XuatGroupBox.Controls.Add(this.BoQuaButton);
            this.XuatGroupBox.Controls.Add(this.TimButton);
            this.XuatGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XuatGroupBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.XuatGroupBox.Location = new System.Drawing.Point(16, 277);
            this.XuatGroupBox.Name = "XuatGroupBox";
            this.XuatGroupBox.Size = new System.Drawing.Size(559, 132);
            this.XuatGroupBox.TabIndex = 1;
            this.XuatGroupBox.TabStop = false;
            this.XuatGroupBox.Text = "Xuất";
            // 
            // KetQuaTextBox
            // 
            this.KetQuaTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.KetQuaTextBox.Location = new System.Drawing.Point(154, 21);
            this.KetQuaTextBox.Name = "KetQuaTextBox";
            this.KetQuaTextBox.Size = new System.Drawing.Size(172, 22);
            this.KetQuaTextBox.TabIndex = 3;
            this.KetQuaTextBox.TextChanged += new System.EventHandler(this.KetQuaTextBox_TextChanged);
            // 
            // ThoatButton
            // 
            this.ThoatButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ThoatButton.Location = new System.Drawing.Point(352, 65);
            this.ThoatButton.Name = "ThoatButton";
            this.ThoatButton.Size = new System.Drawing.Size(87, 38);
            this.ThoatButton.TabIndex = 2;
            this.ThoatButton.Text = "Thoát";
            this.ThoatButton.UseVisualStyleBackColor = false;
            this.ThoatButton.Click += new System.EventHandler(this.ThoatButton_Click);
            // 
            // BoQuaButton
            // 
            this.BoQuaButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BoQuaButton.Location = new System.Drawing.Point(198, 65);
            this.BoQuaButton.Name = "BoQuaButton";
            this.BoQuaButton.Size = new System.Drawing.Size(87, 38);
            this.BoQuaButton.TabIndex = 1;
            this.BoQuaButton.Text = "Bỏ qua";
            this.BoQuaButton.UseVisualStyleBackColor = false;
            this.BoQuaButton.Click += new System.EventHandler(this.BoQuaButton_Click);
            // 
            // TimButton
            // 
            this.TimButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TimButton.Location = new System.Drawing.Point(48, 65);
            this.TimButton.Name = "TimButton";
            this.TimButton.Size = new System.Drawing.Size(87, 38);
            this.TimButton.TabIndex = 0;
            this.TimButton.Text = "Tìm";
            this.TimButton.UseVisualStyleBackColor = false;
            this.TimButton.Click += new System.EventHandler(this.TimButton_Click);
            // 
            // BCNNRadioButton
            // 
            this.BCNNRadioButton.AutoSize = true;
            this.BCNNRadioButton.Location = new System.Drawing.Point(29, 106);
            this.BCNNRadioButton.Name = "BCNNRadioButton";
            this.BCNNRadioButton.Size = new System.Drawing.Size(70, 20);
            this.BCNNRadioButton.TabIndex = 1;
            this.BCNNRadioButton.TabStop = true;
            this.BCNNRadioButton.Text = "BCNN";
            this.BCNNRadioButton.UseVisualStyleBackColor = true;
            this.BCNNRadioButton.CheckedChanged += new System.EventHandler(this.BCNNRadioButton_CheckedChanged);
            // 
            // frmUCLNBCNN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(594, 432);
            this.Controls.Add(this.XuatGroupBox);
            this.Controls.Add(this.NhapGroupBox);
            this.Name = "frmUCLNBCNN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_UCLN-BCNN";
            this.Load += new System.EventHandler(this.frmUCLNBCNN_Load);
            this.NhapGroupBox.ResumeLayout(false);
            this.NhapGroupBox.PerformLayout();
            this.ChonTimGroupBox.ResumeLayout(false);
            this.ChonTimGroupBox.PerformLayout();
            this.XuatGroupBox.ResumeLayout(false);
            this.XuatGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NhapGroupBox;
        private System.Windows.Forms.TextBox SoThuNhatTextBox;
        private System.Windows.Forms.Label SoThuHaiLabel;
        private System.Windows.Forms.Label SoThuNhatLabel;
        private System.Windows.Forms.GroupBox ChonTimGroupBox;
        private System.Windows.Forms.RadioButton UCLNRadioButton;
        private System.Windows.Forms.TextBox SoThuHaiTextBox;
        private System.Windows.Forms.GroupBox XuatGroupBox;
        private System.Windows.Forms.Button ThoatButton;
        private System.Windows.Forms.Button BoQuaButton;
        private System.Windows.Forms.Button TimButton;
        private System.Windows.Forms.TextBox KetQuaTextBox;
        private System.Windows.Forms.RadioButton BCNNRadioButton;
    }
}

