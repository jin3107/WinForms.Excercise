namespace BT_BS4
{
    partial class BasicChemicalReactions
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAcid = new System.Windows.Forms.Label();
            this.lblOxidebase = new System.Windows.Forms.Label();
            this.lblPTPU = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lbAcid = new System.Windows.Forms.ListBox();
            this.clbOxideBase = new System.Windows.Forms.CheckedListBox();
            this.lbPTPU = new System.Windows.Forms.ListBox();
            this.btArrow = new System.Windows.Forms.Button();
            this.lblCTTQ = new System.Windows.Forms.Label();
            this.picCTTQ = new System.Windows.Forms.PictureBox();
            this.btXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCTTQ)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHƯƠNG TRÌNH PHẢN ỨNG CƠ BẢN";
            // 
            // lblAcid
            // 
            this.lblAcid.AutoSize = true;
            this.lblAcid.Location = new System.Drawing.Point(12, 84);
            this.lblAcid.Name = "lblAcid";
            this.lblAcid.Size = new System.Drawing.Size(45, 22);
            this.lblAcid.TabIndex = 1;
            this.lblAcid.Text = "Acid";
            // 
            // lblOxidebase
            // 
            this.lblOxidebase.AutoSize = true;
            this.lblOxidebase.Location = new System.Drawing.Point(297, 84);
            this.lblOxidebase.Name = "lblOxidebase";
            this.lblOxidebase.Size = new System.Drawing.Size(101, 22);
            this.lblOxidebase.TabIndex = 2;
            this.lblOxidebase.Text = "Oxide base";
            // 
            // lblPTPU
            // 
            this.lblPTPU.AutoSize = true;
            this.lblPTPU.Location = new System.Drawing.Point(96, 289);
            this.lblPTPU.Name = "lblPTPU";
            this.lblPTPU.Size = new System.Drawing.Size(192, 22);
            this.lblPTPU.TabIndex = 3;
            this.lblPTPU.Text = "Phương trình phản ứng";
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Location = new System.Drawing.Point(274, 195);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(21, 22);
            this.lblPlus.TabIndex = 4;
            this.lblPlus.Text = "+";
            // 
            // lbAcid
            // 
            this.lbAcid.FormattingEnabled = true;
            this.lbAcid.ItemHeight = 22;
            this.lbAcid.Location = new System.Drawing.Point(16, 109);
            this.lbAcid.Name = "lbAcid";
            this.lbAcid.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAcid.Size = new System.Drawing.Size(252, 180);
            this.lbAcid.TabIndex = 5;
            // 
            // clbOxideBase
            // 
            this.clbOxideBase.FormattingEnabled = true;
            this.clbOxideBase.Location = new System.Drawing.Point(301, 109);
            this.clbOxideBase.Name = "clbOxideBase";
            this.clbOxideBase.Size = new System.Drawing.Size(270, 165);
            this.clbOxideBase.TabIndex = 6;
            // 
            // lbPTPU
            // 
            this.lbPTPU.FormattingEnabled = true;
            this.lbPTPU.ItemHeight = 22;
            this.lbPTPU.Location = new System.Drawing.Point(52, 314);
            this.lbPTPU.Name = "lbPTPU";
            this.lbPTPU.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPTPU.Size = new System.Drawing.Size(519, 136);
            this.lbPTPU.TabIndex = 7;
            this.lbPTPU.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbPTPU_DrawItem);
            // 
            // btArrow
            // 
            this.btArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btArrow.Location = new System.Drawing.Point(577, 184);
            this.btArrow.Name = "btArrow";
            this.btArrow.Size = new System.Drawing.Size(64, 42);
            this.btArrow.TabIndex = 8;
            this.btArrow.Text = "→";
            this.btArrow.UseVisualStyleBackColor = true;
            this.btArrow.Click += new System.EventHandler(this.btArrow_Click);
            // 
            // lblCTTQ
            // 
            this.lblCTTQ.AutoSize = true;
            this.lblCTTQ.Location = new System.Drawing.Point(686, 84);
            this.lblCTTQ.Name = "lblCTTQ";
            this.lblCTTQ.Size = new System.Drawing.Size(172, 22);
            this.lblCTTQ.TabIndex = 9;
            this.lblCTTQ.Text = "Công thức tổng quát";
            // 
            // picCTTQ
            // 
            this.picCTTQ.Image = global::BT_BS4.Properties.Resources.CTTQ;
            this.picCTTQ.Location = new System.Drawing.Point(647, 109);
            this.picCTTQ.Name = "picCTTQ";
            this.picCTTQ.Size = new System.Drawing.Size(281, 202);
            this.picCTTQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCTTQ.TabIndex = 10;
            this.picCTTQ.TabStop = false;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(577, 354);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(80, 45);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // BasicChemicalReactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 478);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.picCTTQ);
            this.Controls.Add(this.lblCTTQ);
            this.Controls.Add(this.btArrow);
            this.Controls.Add(this.lbPTPU);
            this.Controls.Add(this.clbOxideBase);
            this.Controls.Add(this.lbAcid);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblPTPU);
            this.Controls.Add(this.lblOxidebase);
            this.Controls.Add(this.lblAcid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BasicChemicalReactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasicChemicalReactions";
            this.Load += new System.EventHandler(this.BasicChemicalReactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCTTQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAcid;
        private System.Windows.Forms.Label lblOxidebase;
        private System.Windows.Forms.Label lblPTPU;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.ListBox lbAcid;
        private System.Windows.Forms.CheckedListBox clbOxideBase;
        private System.Windows.Forms.ListBox lbPTPU;
        private System.Windows.Forms.Button btArrow;
        private System.Windows.Forms.Label lblCTTQ;
        private System.Windows.Forms.PictureBox picCTTQ;
        private System.Windows.Forms.Button btXoa;
    }
}