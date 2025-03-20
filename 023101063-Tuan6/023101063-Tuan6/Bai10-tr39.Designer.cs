namespace _023101063_Tuan6
{
    partial class Bai10_tr39
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
            this.lblDSSach = new System.Windows.Forms.Label();
            this.tvwDSSach = new System.Windows.Forms.TreeView();
            this.lvwDSSach = new System.Windows.Forms.ListView();
            this.colHP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTT = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDSSach
            // 
            this.lblDSSach.AutoSize = true;
            this.lblDSSach.Location = new System.Drawing.Point(12, 9);
            this.lblDSSach.Name = "lblDSSach";
            this.lblDSSach.Size = new System.Drawing.Size(207, 22);
            this.lblDSSach.TabIndex = 0;
            this.lblDSSach.Text = "Danh sách thể loại sách:";
            // 
            // tvwDSSach
            // 
            this.tvwDSSach.Location = new System.Drawing.Point(16, 34);
            this.tvwDSSach.Name = "tvwDSSach";
            this.tvwDSSach.Size = new System.Drawing.Size(203, 178);
            this.tvwDSSach.TabIndex = 1;
            this.tvwDSSach.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwDSSach_AfterSelect);
            // 
            // lvwDSSach
            // 
            this.lvwDSSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHP,
            this.colTG,
            this.colDG});
            this.lvwDSSach.FullRowSelect = true;
            this.lvwDSSach.GridLines = true;
            this.lvwDSSach.HideSelection = false;
            this.lvwDSSach.Location = new System.Drawing.Point(225, 34);
            this.lvwDSSach.Name = "lvwDSSach";
            this.lvwDSSach.Size = new System.Drawing.Size(353, 178);
            this.lvwDSSach.TabIndex = 2;
            this.lvwDSSach.UseCompatibleStateImageBehavior = false;
            this.lvwDSSach.View = System.Windows.Forms.View.Details;
            // 
            // colHP
            // 
            this.colHP.Text = "Học phần";
            // 
            // colTG
            // 
            this.colTG.Text = "Tác giả";
            // 
            // colDG
            // 
            this.colDG.Text = "Đơn giá";
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Location = new System.Drawing.Point(221, 215);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(160, 22);
            this.lblTT.TabIndex = 3;
            this.lblTT.Text = "Tổng thành tiền là:";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(387, 215);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(20, 22);
            this.lblT.TabIndex = 4;
            this.lblT.Text = "0";
            // 
            // Bai10_tr39
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 251);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblTT);
            this.Controls.Add(this.lvwDSSach);
            this.Controls.Add(this.tvwDSSach);
            this.Controls.Add(this.lblDSSach);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bai10_tr39";
            this.Text = "Bai10_tr39";
            this.Load += new System.EventHandler(this.Bai10_tr39_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDSSach;
        private System.Windows.Forms.TreeView tvwDSSach;
        private System.Windows.Forms.ListView lvwDSSach;
        private System.Windows.Forms.ColumnHeader colHP;
        private System.Windows.Forms.ColumnHeader colTG;
        private System.Windows.Forms.ColumnHeader colDG;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Label lblT;
    }
}