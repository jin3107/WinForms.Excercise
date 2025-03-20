namespace _023101063_Tuan6
{
    partial class Hinh2_27
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
            this.lblDSXe = new System.Windows.Forms.Label();
            this.lblTTCT = new System.Windows.Forms.Label();
            this.tvwDSXe = new System.Windows.Forms.TreeView();
            this.lvwTTCT = new System.Windows.Forms.ListView();
            this.colHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNamSX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDongCo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblDSXe
            // 
            this.lblDSXe.AutoSize = true;
            this.lblDSXe.Location = new System.Drawing.Point(12, 9);
            this.lblDSXe.Name = "lblDSXe";
            this.lblDSXe.Size = new System.Drawing.Size(125, 22);
            this.lblDSXe.TabIndex = 0;
            this.lblDSXe.Text = "Danh sách xe:";
            // 
            // lblTTCT
            // 
            this.lblTTCT.AutoSize = true;
            this.lblTTCT.Location = new System.Drawing.Point(310, 9);
            this.lblTTCT.Name = "lblTTCT";
            this.lblTTCT.Size = new System.Drawing.Size(148, 22);
            this.lblTTCT.TabIndex = 1;
            this.lblTTCT.Text = "Thông tin chi tiết:";
            // 
            // tvwDSXe
            // 
            this.tvwDSXe.Location = new System.Drawing.Point(16, 34);
            this.tvwDSXe.Name = "tvwDSXe";
            this.tvwDSXe.Size = new System.Drawing.Size(273, 218);
            this.tvwDSXe.TabIndex = 2;
            this.tvwDSXe.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwDSXe_AfterSelect);
            // 
            // lvwTTCT
            // 
            this.lvwTTCT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHang,
            this.colNamSX,
            this.colDongCo,
            this.colGia});
            this.lvwTTCT.FullRowSelect = true;
            this.lvwTTCT.GridLines = true;
            this.lvwTTCT.HideSelection = false;
            this.lvwTTCT.Location = new System.Drawing.Point(314, 34);
            this.lvwTTCT.Name = "lvwTTCT";
            this.lvwTTCT.Size = new System.Drawing.Size(323, 218);
            this.lvwTTCT.TabIndex = 3;
            this.lvwTTCT.UseCompatibleStateImageBehavior = false;
            this.lvwTTCT.View = System.Windows.Forms.View.Details;
            // 
            // colHang
            // 
            this.colHang.Text = "Hãng";
            // 
            // colNamSX
            // 
            this.colNamSX.Text = "Năm SX";
            // 
            // colDongCo
            // 
            this.colDongCo.Text = "Động cơ";
            // 
            // colGia
            // 
            this.colGia.Text = "Giá";
            // 
            // Hinh2_27
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 266);
            this.Controls.Add(this.lvwTTCT);
            this.Controls.Add(this.tvwDSXe);
            this.Controls.Add(this.lblTTCT);
            this.Controls.Add(this.lblDSXe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Hinh2_27";
            this.Text = "Hinh2_27";
            this.Load += new System.EventHandler(this.Hinh2_27_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDSXe;
        private System.Windows.Forms.Label lblTTCT;
        private System.Windows.Forms.TreeView tvwDSXe;
        private System.Windows.Forms.ListView lvwTTCT;
        private System.Windows.Forms.ColumnHeader colHang;
        private System.Windows.Forms.ColumnHeader colNamSX;
        private System.Windows.Forms.ColumnHeader colDongCo;
        private System.Windows.Forms.ColumnHeader colGia;
    }
}