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
            richTextBoxLyric = new RichTextBox();
            lyrictimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer
            // 
            axWindowsMediaPlayer.Enabled = true;
            axWindowsMediaPlayer.Location = new Point(21, 40);
            axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            axWindowsMediaPlayer.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer.OcxState");
            axWindowsMediaPlayer.Size = new Size(686, 530);
            axWindowsMediaPlayer.TabIndex = 0;
            // 
            // ListBoxMusic
            // 
            ListBoxMusic.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListBoxMusic.FormattingEnabled = true;
            ListBoxMusic.ItemHeight = 17;
            ListBoxMusic.Location = new Point(749, 90);
            ListBoxMusic.Name = "ListBoxMusic";
            ListBoxMusic.Size = new Size(350, 480);
            ListBoxMusic.TabIndex = 2;
            ListBoxMusic.DoubleClick += listBoxMusic_DoubleClick;
            // 
            // labelDanhSach
            // 
            labelDanhSach.AutoSize = true;
            labelDanhSach.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDanhSach.Location = new Point(749, 40);
            labelDanhSach.Name = "labelDanhSach";
            labelDanhSach.Size = new Size(260, 38);
            labelDanhSach.TabIndex = 3;
            labelDanhSach.Text = "Danh Sách Bài Hát";
            // 
            // buttonThoat
            // 
            buttonThoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonThoat.Location = new Point(998, 585);
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
            labelDuongDan.Location = new Point(21, 598);
            labelDuongDan.Name = "labelDuongDan";
            labelDuongDan.Size = new Size(100, 25);
            labelDuongDan.TabIndex = 5;
            labelDuongDan.Text = "Đang phát:";
            // 
            // buttonBrowse
            // 
            buttonBrowse.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBrowse.Location = new Point(613, 591);
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
            textBoxDuongDan.Location = new Point(127, 593);
            textBoxDuongDan.Name = "textBoxDuongDan";
            textBoxDuongDan.Size = new Size(480, 34);
            textBoxDuongDan.TabIndex = 7;
            textBoxDuongDan.TextChanged += textBoxDuongDan_TextChanged;
            // 
            // richTextBoxLyric
            // 
            richTextBoxLyric.BackColor = SystemColors.Desktop;
            richTextBoxLyric.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxLyric.ForeColor = SystemColors.Window;
            richTextBoxLyric.Location = new Point(21, 441);
            richTextBoxLyric.Name = "richTextBoxLyric";
            richTextBoxLyric.Size = new Size(686, 50);
            richTextBoxLyric.TabIndex = 8;
            richTextBoxLyric.Text = "";
            richTextBoxLyric.TextChanged += richTextBoxLyric_TextChanged;
            // 
            // lyrictimer
            // 
            lyrictimer.Tick += lyrictimer_Tick;
            // 
            // MusicForm
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1127, 656);
            Controls.Add(richTextBoxLyric);
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
        private RichTextBox richTextBoxLyric;
        private System.Windows.Forms.Timer lyrictimer;
    }
}