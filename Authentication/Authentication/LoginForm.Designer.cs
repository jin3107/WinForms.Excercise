namespace Authentication
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            labelEmail = new Label();
            labelPassword = new Label();
            maskedTextBoxPassword = new MaskedTextBox();
            textBoxEmail = new TextBox();
            labelLogIn = new Label();
            buttonRegister = new Button();
            buttonConfirm = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelEmail
            // 
            resources.ApplyResources(labelEmail, "labelEmail");
            labelEmail.Name = "labelEmail";
            // 
            // labelPassword
            // 
            resources.ApplyResources(labelPassword, "labelPassword");
            labelPassword.Name = "labelPassword";
            // 
            // maskedTextBoxPassword
            // 
            resources.ApplyResources(maskedTextBoxPassword, "maskedTextBoxPassword");
            maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            // 
            // textBoxEmail
            // 
            resources.ApplyResources(textBoxEmail, "textBoxEmail");
            textBoxEmail.Name = "textBoxEmail";
            // 
            // labelLogIn
            // 
            resources.ApplyResources(labelLogIn, "labelLogIn");
            labelLogIn.Name = "labelLogIn";
            // 
            // buttonRegister
            // 
            resources.ApplyResources(buttonRegister, "buttonRegister");
            buttonRegister.BackColor = Color.SkyBlue;
            buttonRegister.Name = "buttonRegister";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonConfirm
            // 
            resources.ApplyResources(buttonConfirm, "buttonConfirm");
            buttonConfirm.BackColor = Color.PaleGreen;
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonExit
            // 
            resources.ApplyResources(buttonExit, "buttonExit");
            buttonExit.BackColor = Color.Tomato;
            buttonExit.Name = "buttonExit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            Controls.Add(buttonExit);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonRegister);
            Controls.Add(labelLogIn);
            Controls.Add(textBoxEmail);
            Controls.Add(maskedTextBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmail;
        private Label labelPassword;
        private MaskedTextBox maskedTextBoxPassword;
        private TextBox textBoxEmail;
        private Label labelLogIn;
        private Button buttonRegister;
        private Button buttonConfirm;
        private Button buttonExit;
    }
}