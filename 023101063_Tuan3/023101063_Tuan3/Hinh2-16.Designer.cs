namespace _023101063_Tuan3
{
    partial class Hinh2_16
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
            label1 = new Label();
            textBoxMauChu = new TextBox();
            groupBoxKieuChu = new GroupBox();
            checkBoxGachChan = new CheckBox();
            checkBoxInNghieng = new CheckBox();
            checkBoxInDam = new CheckBox();
            groupBoxFontChu = new GroupBox();
            radioButtonArial = new RadioButton();
            radioButtonTNR = new RadioButton();
            radioButtonVNI = new RadioButton();
            labelCoChu = new Label();
            numericUpDownCoChu = new NumericUpDown();
            groupBoxKieuChu.SuspendLayout();
            groupBoxFontChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCoChu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 27);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 0;
            label1.Text = "Mẫu chữ";
            // 
            // textBoxMauChu
            // 
            textBoxMauChu.Location = new Point(38, 81);
            textBoxMauChu.Multiline = true;
            textBoxMauChu.Name = "textBoxMauChu";
            textBoxMauChu.Size = new Size(246, 41);
            textBoxMauChu.TabIndex = 1;
            textBoxMauChu.Text = "Công Nghệ .NET";
            // 
            // groupBoxKieuChu
            // 
            groupBoxKieuChu.Controls.Add(checkBoxGachChan);
            groupBoxKieuChu.Controls.Add(checkBoxInNghieng);
            groupBoxKieuChu.Controls.Add(checkBoxInDam);
            groupBoxKieuChu.Location = new Point(38, 216);
            groupBoxKieuChu.Name = "groupBoxKieuChu";
            groupBoxKieuChu.Size = new Size(246, 235);
            groupBoxKieuChu.TabIndex = 2;
            groupBoxKieuChu.TabStop = false;
            groupBoxKieuChu.Text = "Kiểu chữ";
            // 
            // checkBoxGachChan
            // 
            checkBoxGachChan.AutoSize = true;
            checkBoxGachChan.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            checkBoxGachChan.Location = new Point(30, 178);
            checkBoxGachChan.Name = "checkBoxGachChan";
            checkBoxGachChan.Size = new Size(124, 32);
            checkBoxGachChan.TabIndex = 2;
            checkBoxGachChan.Text = "Gạch chân";
            checkBoxGachChan.UseVisualStyleBackColor = true;
            checkBoxGachChan.CheckedChanged += checkBoxGachChan_CheckedChanged_1;
            // 
            // checkBoxInNghieng
            // 
            checkBoxInNghieng.AutoSize = true;
            checkBoxInNghieng.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBoxInNghieng.Location = new Point(30, 111);
            checkBoxInNghieng.Name = "checkBoxInNghieng";
            checkBoxInNghieng.Size = new Size(126, 32);
            checkBoxInNghieng.TabIndex = 1;
            checkBoxInNghieng.Text = "In nghiêng";
            checkBoxInNghieng.UseVisualStyleBackColor = true;
            checkBoxInNghieng.CheckedChanged += checkBoxInNghieng_CheckedChanged;
            // 
            // checkBoxInDam
            // 
            checkBoxInDam.AutoSize = true;
            checkBoxInDam.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxInDam.Location = new Point(30, 54);
            checkBoxInDam.Name = "checkBoxInDam";
            checkBoxInDam.Size = new Size(100, 32);
            checkBoxInDam.TabIndex = 0;
            checkBoxInDam.Text = "In đậm";
            checkBoxInDam.UseVisualStyleBackColor = true;
            checkBoxInDam.CheckedChanged += checkBoxInDam_CheckedChanged;
            // 
            // groupBoxFontChu
            // 
            groupBoxFontChu.Controls.Add(radioButtonArial);
            groupBoxFontChu.Controls.Add(radioButtonTNR);
            groupBoxFontChu.Controls.Add(radioButtonVNI);
            groupBoxFontChu.Location = new Point(324, 216);
            groupBoxFontChu.Name = "groupBoxFontChu";
            groupBoxFontChu.Size = new Size(246, 235);
            groupBoxFontChu.TabIndex = 3;
            groupBoxFontChu.TabStop = false;
            groupBoxFontChu.Text = "Font chữ";
            // 
            // radioButtonArial
            // 
            radioButtonArial.AutoSize = true;
            radioButtonArial.ForeColor = Color.Green;
            radioButtonArial.Location = new Point(36, 177);
            radioButtonArial.Name = "radioButtonArial";
            radioButtonArial.Size = new Size(73, 32);
            radioButtonArial.TabIndex = 2;
            radioButtonArial.TabStop = true;
            radioButtonArial.Text = "Arial";
            radioButtonArial.UseVisualStyleBackColor = true;
            radioButtonArial.CheckedChanged += radioButtonArial_CheckedChanged;
            // 
            // radioButtonTNR
            // 
            radioButtonTNR.AutoSize = true;
            radioButtonTNR.ForeColor = Color.Blue;
            radioButtonTNR.Location = new Point(36, 111);
            radioButtonTNR.Name = "radioButtonTNR";
            radioButtonTNR.Size = new Size(193, 32);
            radioButtonTNR.TabIndex = 1;
            radioButtonTNR.TabStop = true;
            radioButtonTNR.Text = "Times New Roman";
            radioButtonTNR.UseVisualStyleBackColor = true;
            radioButtonTNR.CheckedChanged += radioButtonTNR_CheckedChanged;
            // 
            // radioButtonVNI
            // 
            radioButtonVNI.AutoSize = true;
            radioButtonVNI.ForeColor = Color.Red;
            radioButtonVNI.Location = new Point(36, 54);
            radioButtonVNI.Name = "radioButtonVNI";
            radioButtonVNI.Size = new Size(123, 32);
            radioButtonVNI.TabIndex = 0;
            radioButtonVNI.TabStop = true;
            radioButtonVNI.Text = "VNI-Times";
            radioButtonVNI.UseVisualStyleBackColor = true;
            radioButtonVNI.CheckedChanged += radioButtonVNI_CheckedChanged;
            // 
            // labelCoChu
            // 
            labelCoChu.AutoSize = true;
            labelCoChu.Location = new Point(324, 27);
            labelCoChu.Name = "labelCoChu";
            labelCoChu.Size = new Size(73, 28);
            labelCoChu.TabIndex = 4;
            labelCoChu.Text = "Cỡ chữ";
            // 
            // numericUpDownCoChu
            // 
            numericUpDownCoChu.DecimalPlaces = 1;
            numericUpDownCoChu.Location = new Point(324, 88);
            numericUpDownCoChu.Name = "numericUpDownCoChu";
            numericUpDownCoChu.Size = new Size(164, 34);
            numericUpDownCoChu.TabIndex = 5;
            numericUpDownCoChu.ValueChanged += numericUpDownCoChu_ValueChanged;
            // 
            // Hinh2_16
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 472);
            Controls.Add(numericUpDownCoChu);
            Controls.Add(labelCoChu);
            Controls.Add(groupBoxFontChu);
            Controls.Add(groupBoxKieuChu);
            Controls.Add(textBoxMauChu);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Hinh2_16";
            Text = "Hinh2_16";
            groupBoxKieuChu.ResumeLayout(false);
            groupBoxKieuChu.PerformLayout();
            groupBoxFontChu.ResumeLayout(false);
            groupBoxFontChu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCoChu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxMauChu;
        private GroupBox groupBoxKieuChu;
        private CheckBox checkBoxGachChan;
        private CheckBox checkBoxInNghieng;
        private CheckBox checkBoxInDam;
        private GroupBox groupBoxFontChu;
        private RadioButton radioButtonArial;
        private RadioButton radioButtonTNR;
        private RadioButton radioButtonVNI;
        private Label labelCoChu;
        private NumericUpDown numericUpDownCoChu;
    }
}