namespace QuanLyShow_CrystalReport.GUI
{
    partial class FormReport
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
            this.crystalReportShow = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportShow
            // 
            this.crystalReportShow.ActiveViewIndex = -1;
            this.crystalReportShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportShow.Location = new System.Drawing.Point(0, 0);
            this.crystalReportShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crystalReportShow.Name = "crystalReportShow";
            this.crystalReportShow.Size = new System.Drawing.Size(1000, 562);
            this.crystalReportShow.TabIndex = 0;
            this.crystalReportShow.ToolPanelWidth = 250;
            this.crystalReportShow.Load += new System.EventHandler(this.crystalReportShow_Load);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.crystalReportShow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportShow;
    }
}