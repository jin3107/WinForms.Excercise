namespace _023101063_Tuan3
{
    partial class Bai2_tr33
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
            components = new System.ComponentModel.Container();
            labelHoTen = new Label();
            labelNgaySinh = new Label();
            labelSoThoch = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBoxHoTen = new TextBox();
            dateTimePickerNgaySinh = new DateTimePicker();
            textBoxSoThich = new TextBox();
            buttonXacNhan = new Button();
            SuspendLayout();
            // 
            // labelHoTen
            // 
            labelHoTen.AutoSize = true;
            labelHoTen.Location = new Point(37, 38);
            labelHoTen.Name = "labelHoTen";
            labelHoTen.Size = new Size(80, 28);
            labelHoTen.TabIndex = 0;
            labelHoTen.Text = "Họ tên: ";
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Location = new Point(37, 103);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(103, 28);
            labelNgaySinh.TabIndex = 1;
            labelNgaySinh.Text = "Ngày sinh:";
            // 
            // labelSoThoch
            // 
            labelSoThoch.AutoSize = true;
            labelSoThoch.Location = new Point(37, 176);
            labelSoThoch.Name = "labelSoThoch";
            labelSoThoch.Size = new Size(87, 28);
            labelSoThoch.TabIndex = 2;
            labelSoThoch.Text = "Sở thích:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Location = new Point(173, 32);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(303, 34);
            textBoxHoTen.TabIndex = 4;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Short;
            dateTimePickerNgaySinh.Location = new Point(173, 97);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(303, 34);
            dateTimePickerNgaySinh.TabIndex = 5;
            // 
            // textBoxSoThich
            // 
            textBoxSoThich.Location = new Point(173, 170);
            textBoxSoThich.Multiline = true;
            textBoxSoThich.Name = "textBoxSoThich";
            textBoxSoThich.Size = new Size(303, 143);
            textBoxSoThich.TabIndex = 6;
            // 
            // buttonXacNhan
            // 
            buttonXacNhan.Location = new Point(173, 340);
            buttonXacNhan.Name = "buttonXacNhan";
            buttonXacNhan.Size = new Size(111, 40);
            buttonXacNhan.TabIndex = 7;
            buttonXacNhan.Text = "Xác nhận";
            buttonXacNhan.UseVisualStyleBackColor = true;
            buttonXacNhan.Click += buttonXacNhan_Click;
            // 
            // Bai2_tr33
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 432);
            Controls.Add(buttonXacNhan);
            Controls.Add(textBoxSoThich);
            Controls.Add(dateTimePickerNgaySinh);
            Controls.Add(textBoxHoTen);
            Controls.Add(labelSoThoch);
            Controls.Add(labelNgaySinh);
            Controls.Add(labelHoTen);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Bai2_tr33";
            Text = "frm_ThongTinCaNhan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHoTen;
        private Label labelNgaySinh;
        private Label labelSoThoch;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBoxHoTen;
        private DateTimePicker dateTimePickerNgaySinh;
        private TextBox textBoxSoThich;
        private Button buttonXacNhan;
    }
}