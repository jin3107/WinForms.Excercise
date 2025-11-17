namespace HoaDonBanHang_CrystalReport.GUI
{
    partial class FormHoaDonBanHang
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
            this.crystalReportHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportHoaDon
            // 
            this.crystalReportHoaDon.ActiveViewIndex = -1;
            this.crystalReportHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportHoaDon.Location = new System.Drawing.Point(0, 0);
            this.crystalReportHoaDon.Name = "crystalReportHoaDon";
            this.crystalReportHoaDon.Size = new System.Drawing.Size(1008, 589);
            this.crystalReportHoaDon.TabIndex = 0;
            // 
            // FormHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 589);
            this.Controls.Add(this.crystalReportHoaDon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormHoaDonBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoaDonBanHang";
            this.Load += new System.EventHandler(this.FormHoaDonBanHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportHoaDon;
    }
}