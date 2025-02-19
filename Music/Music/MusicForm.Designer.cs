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
            ListBoxMusic = new ListBox();
            labelDanhSach = new Label();
            buttonThoat = new Button();
            labelDuongDan = new Label();
            buttonBrowse = new Button();
            textBoxDuongDan = new TextBox();
            lyrictimer = new System.Windows.Forms.Timer(components);
            labelLyric = new Label();
            label1 = new Label();
            pictureBoxCircle = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCircle).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer
            // 
            axWindowsMediaPlayer.Enabled = true;
            axWindowsMediaPlayer.Location = new Point(21, 55);
            axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            axWindowsMediaPlayer.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer.OcxState");
            axWindowsMediaPlayer.Size = new Size(450, 400);
            axWindowsMediaPlayer.TabIndex = 0;
            // 
            // ListBoxMusic
            // 
            ListBoxMusic.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListBoxMusic.FormattingEnabled = true;
            ListBoxMusic.Location = new Point(530, 124);
            ListBoxMusic.Name = "ListBoxMusic";
            ListBoxMusic.Size = new Size(371, 84);
            ListBoxMusic.TabIndex = 2;
            ListBoxMusic.DoubleClick += listBoxMusic_DoubleClick;
            // 
            // labelDanhSach
            // 
            labelDanhSach.AutoSize = true;
            labelDanhSach.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDanhSach.Location = new Point(530, 55);
            labelDanhSach.Name = "labelDanhSach";
            labelDanhSach.Size = new Size(260, 38);
            labelDanhSach.TabIndex = 3;
            labelDanhSach.Text = "Danh Sách Bài Hát";
            // 
            // buttonThoat
            // 
            buttonThoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonThoat.Location = new Point(779, 492);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(101, 47);
            buttonThoat.TabIndex = 4;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // labelDuongDan
            // 
            labelDuongDan.AutoSize = true;
            labelDuongDan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDuongDan.Location = new Point(21, 498);
            labelDuongDan.Name = "labelDuongDan";
            labelDuongDan.Size = new Size(100, 25);
            labelDuongDan.TabIndex = 5;
            labelDuongDan.Text = "Đang phát:";
            // 
            // buttonBrowse
            // 
            buttonBrowse.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBrowse.Location = new Point(530, 491);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(94, 41);
            buttonBrowse.TabIndex = 6;
            buttonBrowse.Text = "Browse ...";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // textBoxDuongDan
            // 
            textBoxDuongDan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDuongDan.Location = new Point(127, 492);
            textBoxDuongDan.Name = "textBoxDuongDan";
            textBoxDuongDan.Size = new Size(386, 34);
            textBoxDuongDan.TabIndex = 7;
            textBoxDuongDan.TextChanged += textBoxDuongDan_TextChanged;
            // 
            // lyrictimer
            // 
            lyrictimer.Tick += lyrictimer_Tick;
            // 
            // labelLyric
            // 
            labelLyric.AutoSize = true;
            labelLyric.BackColor = SystemColors.Control;
            labelLyric.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelLyric.ForeColor = SystemColors.Desktop;
            labelLyric.Location = new Point(530, 325);
            labelLyric.Name = "labelLyric";
            labelLyric.Size = new Size(36, 28);
            labelLyric.TabIndex = 8;
            labelLyric.Text = "---";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(530, 270);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 9;
            label1.Text = "Lyric:";
            // 
            // pictureBoxCircle
            // 
            pictureBoxCircle.BackgroundImage = Properties.Resources.logo_600x600;
            pictureBoxCircle.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxCircle.Location = new Point(96, 80);
            pictureBoxCircle.Name = "pictureBoxCircle";
            pictureBoxCircle.Size = new Size(300, 300);
            pictureBoxCircle.TabIndex = 10;
            pictureBoxCircle.TabStop = false;
            // 
            // MusicForm
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(937, 557);
            Controls.Add(pictureBoxCircle);
            Controls.Add(label1);
            Controls.Add(labelLyric);
            Controls.Add(textBoxDuongDan);
            Controls.Add(buttonBrowse);
            Controls.Add(labelDuongDan);
            Controls.Add(buttonThoat);
            Controls.Add(labelDanhSach);
            Controls.Add(ListBoxMusic);
            Controls.Add(axWindowsMediaPlayer);
            Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "MusicForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MusicForm";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCircle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private ListBox ListBoxMusic;
        private Label labelDanhSach;
        private Button buttonThoat;
        private Label labelDuongDan;
        private Button buttonBrowse;
        private TextBox textBoxDuongDan;
        private System.Windows.Forms.Timer lyrictimer;
        private Label labelLyric;
        private Label label1;
        private PictureBox pictureBoxCircle;
    }
}