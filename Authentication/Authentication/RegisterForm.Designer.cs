namespace Authentication
{
    partial class RegisterForm
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
            labelRegister = new Label();
            buttonExit = new Button();
            buttonConfirm = new Button();
            SuspendLayout();
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold);
            labelRegister.Location = new Point(232, 21);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(104, 30);
            labelRegister.TabIndex = 5;
            labelRegister.Text = "Đăng Ký";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Tomato;
            buttonExit.ImeMode = ImeMode.NoControl;
            buttonExit.Location = new Point(314, 198);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(101, 40);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.LightBlue;
            buttonConfirm.ImeMode = ImeMode.NoControl;
            buttonConfirm.Location = new Point(159, 198);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(101, 40);
            buttonConfirm.TabIndex = 8;
            buttonConfirm.Text = "Xác Nhận";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(565, 269);
            Controls.Add(buttonExit);
            Controls.Add(buttonConfirm);
            Controls.Add(labelRegister);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRegister;
        private Button buttonExit;
        private Button buttonConfirm;
    }
}