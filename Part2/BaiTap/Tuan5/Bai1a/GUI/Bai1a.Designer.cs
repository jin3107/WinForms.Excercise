namespace Tuan5.Bai1a.GUI
{
    partial class Form1
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
            this.dtgDS = new System.Windows.Forms.DataGridView();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.lblDS = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDS
            // 
            this.dtgDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDS.Location = new System.Drawing.Point(23, 137);
            this.dtgDS.Name = "dtgDS";
            this.dtgDS.RowHeadersWidth = 51;
            this.dtgDS.Size = new System.Drawing.Size(738, 159);
            this.dtgDS.TabIndex = 7;
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(103, 37);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(279, 30);
            this.cbbLop.TabIndex = 6;
            this.cbbLop.SelectedIndexChanged += new System.EventHandler(this.cbbLop_SelectedIndexChanged);
            // 
            // lblDS
            // 
            this.lblDS.AutoSize = true;
            this.lblDS.Location = new System.Drawing.Point(23, 95);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(240, 22);
            this.lblDS.TabIndex = 5;
            this.lblDS.Text = "Danh sách sinh viên của lớp ";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(23, 45);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(45, 22);
            this.lblLop.TabIndex = 4;
            this.lblLop.Text = "Lớp:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 324);
            this.Controls.Add(this.dtgDS);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.lblDS);
            this.Controls.Add(this.lblLop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Bai1a_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDS;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.Label lblLop;
    }
}