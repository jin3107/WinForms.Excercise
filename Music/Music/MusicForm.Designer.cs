namespace Music
{
    partial class MusicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicForm));
            axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            buttonThoat = new Button();
            labelDuongDan = new Label();
            textBoxDuongDan = new TextBox();
            lyrictimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            pictureBoxCircle = new PictureBox();
            richTextBoxLyric = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCircle).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer
            // 
            axWindowsMediaPlayer.Enabled = true;
            axWindowsMediaPlayer.Location = new Point(21, 12);
            axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            axWindowsMediaPlayer.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer.OcxState");
            axWindowsMediaPlayer.Size = new Size(599, 476);
            axWindowsMediaPlayer.TabIndex = 0;
            // 
            // buttonThoat
            // 
            buttonThoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonThoat.Location = new Point(519, 612);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(101, 35);
            buttonThoat.TabIndex = 4;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // labelDuongDan
            // 
            labelDuongDan.AutoSize = true;
            labelDuongDan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDuongDan.Location = new Point(21, 618);
            labelDuongDan.Name = "labelDuongDan";
            labelDuongDan.Size = new Size(100, 25);
            labelDuongDan.TabIndex = 5;
            labelDuongDan.Text = "Đang phát:";
            // 
            // textBoxDuongDan
            // 
            textBoxDuongDan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDuongDan.Location = new Point(127, 612);
            textBoxDuongDan.Name = "textBoxDuongDan";
            textBoxDuongDan.Size = new Size(386, 34);
            textBoxDuongDan.TabIndex = 7;
            textBoxDuongDan.TextChanged += textBoxDuongDan_TextChanged;
            // 
            // lyrictimer
            // 
            lyrictimer.Tick += lyrictimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(21, 491);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 9;
            label1.Text = "Lyric:";
            // 
            // pictureBoxCircle
            // 
            pictureBoxCircle.BackgroundImage = (Image)resources.GetObject("pictureBoxCircle.BackgroundImage");
            pictureBoxCircle.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxCircle.Location = new Point(54, 25);
            pictureBoxCircle.Name = "pictureBoxCircle";
            pictureBoxCircle.Size = new Size(532, 400);
            pictureBoxCircle.TabIndex = 10;
            pictureBoxCircle.TabStop = false;
            // 
            // richTextBoxLyric
            // 
            richTextBoxLyric.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            richTextBoxLyric.Location = new Point(21, 522);
            richTextBoxLyric.Name = "richTextBoxLyric";
            richTextBoxLyric.Size = new Size(599, 70);
            richTextBoxLyric.TabIndex = 11;
            richTextBoxLyric.Text = "";
            // 
            // MusicForm
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(639, 669);
            Controls.Add(richTextBoxLyric);
            Controls.Add(pictureBoxCircle);
            Controls.Add(label1);
            Controls.Add(textBoxDuongDan);
            Controls.Add(labelDuongDan);
            Controls.Add(buttonThoat);
            Controls.Add(axWindowsMediaPlayer);
            Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7);
            Name = "MusicForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MusicForm";
            Load += MusicForm_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCircle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private Button buttonThoat;
        private Label labelDuongDan;
        private TextBox textBoxDuongDan;
        private System.Windows.Forms.Timer lyrictimer;
        private Label label1;
        private PictureBox pictureBoxCircle;
        private RichTextBox richTextBoxLyric;
    }
}