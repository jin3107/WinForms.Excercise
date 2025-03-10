namespace _023101063_Tuan5
{
    partial class Hinh2_26
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
            this.lvMH = new System.Windows.Forms.ListView();
            this.columnMHP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTHP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbHP = new System.Windows.Forms.GroupBox();
            this.nuSTC = new System.Windows.Forms.NumericUpDown();
            this.txtTHP = new System.Windows.Forms.TextBox();
            this.txtMHP = new System.Windows.Forms.TextBox();
            this.lblTHP = new System.Windows.Forms.Label();
            this.lblSTC = new System.Windows.Forms.Label();
            this.lblMHP = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.grbHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuSTC)).BeginInit();
            this.SuspendLayout();
            // 
            // lvMH
            // 
            this.lvMH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMHP,
            this.columnTHP,
            this.columnSTC});
            this.lvMH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvMH.FullRowSelect = true;
            this.lvMH.GridLines = true;
            this.lvMH.HideSelection = false;
            this.lvMH.Location = new System.Drawing.Point(12, 37);
            this.lvMH.Name = "lvMH";
            this.lvMH.Size = new System.Drawing.Size(626, 266);
            this.lvMH.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvMH.TabIndex = 0;
            this.lvMH.UseCompatibleStateImageBehavior = false;
            this.lvMH.View = System.Windows.Forms.View.Details;
            this.lvMH.Click += new System.EventHandler(this.lvMH_Click);
            // 
            // columnMHP
            // 
            this.columnMHP.Text = "Mã học phần";
            this.columnMHP.Width = 131;
            // 
            // columnTHP
            // 
            this.columnTHP.Text = "Tên học phần";
            this.columnTHP.Width = 387;
            // 
            // columnSTC
            // 
            this.columnSTC.Text = "Số tín chỉ";
            this.columnSTC.Width = 137;
            // 
            // grbHP
            // 
            this.grbHP.Controls.Add(this.nuSTC);
            this.grbHP.Controls.Add(this.txtTHP);
            this.grbHP.Controls.Add(this.txtMHP);
            this.grbHP.Controls.Add(this.lblTHP);
            this.grbHP.Controls.Add(this.lblSTC);
            this.grbHP.Controls.Add(this.lblMHP);
            this.grbHP.Location = new System.Drawing.Point(664, 37);
            this.grbHP.Name = "grbHP";
            this.grbHP.Size = new System.Drawing.Size(441, 266);
            this.grbHP.TabIndex = 1;
            this.grbHP.TabStop = false;
            this.grbHP.Text = "Học phần";
            // 
            // nuSTC
            // 
            this.nuSTC.Location = new System.Drawing.Point(151, 198);
            this.nuSTC.Name = "nuSTC";
            this.nuSTC.Size = new System.Drawing.Size(284, 30);
            this.nuSTC.TabIndex = 5;
            // 
            // txtTHP
            // 
            this.txtTHP.Location = new System.Drawing.Point(151, 130);
            this.txtTHP.Name = "txtTHP";
            this.txtTHP.Size = new System.Drawing.Size(284, 30);
            this.txtTHP.TabIndex = 4;
            // 
            // txtMHP
            // 
            this.txtMHP.Location = new System.Drawing.Point(151, 62);
            this.txtMHP.Name = "txtMHP";
            this.txtMHP.Size = new System.Drawing.Size(284, 30);
            this.txtMHP.TabIndex = 3;
            // 
            // lblTHP
            // 
            this.lblTHP.AutoSize = true;
            this.lblTHP.Location = new System.Drawing.Point(38, 135);
            this.lblTHP.Name = "lblTHP";
            this.lblTHP.Size = new System.Drawing.Size(85, 25);
            this.lblTHP.TabIndex = 2;
            this.lblTHP.Text = "Tên HP:";
            // 
            // lblSTC
            // 
            this.lblSTC.AutoSize = true;
            this.lblSTC.Location = new System.Drawing.Point(38, 203);
            this.lblSTC.Name = "lblSTC";
            this.lblSTC.Size = new System.Drawing.Size(76, 25);
            this.lblSTC.TabIndex = 1;
            this.lblSTC.Text = "Số TC:";
            // 
            // lblMHP
            // 
            this.lblMHP.AutoSize = true;
            this.lblMHP.Location = new System.Drawing.Point(38, 67);
            this.lblMHP.Name = "lblMHP";
            this.lblMHP.Size = new System.Drawing.Size(78, 25);
            this.lblMHP.TabIndex = 0;
            this.lblMHP.Text = "Mã HP:";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Lime;
            this.btThem.Location = new System.Drawing.Point(79, 323);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(98, 46);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "THÊM";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.DeepPink;
            this.btXoa.Location = new System.Drawing.Point(255, 323);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(98, 46);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "XÓA";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.BackColor = System.Drawing.Color.Gold;
            this.btCapNhat.Location = new System.Drawing.Point(445, 323);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(135, 46);
            this.btCapNhat.TabIndex = 4;
            this.btCapNhat.Text = "CẬP NHẬT";
            this.btCapNhat.UseVisualStyleBackColor = false;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Crimson;
            this.btThoat.Location = new System.Drawing.Point(664, 323);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(98, 46);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // Hinh2_26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1117, 401);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.grbHP);
            this.Controls.Add(this.lvMH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Hinh2_26";
            this.Text = "Hinh2_26";
            this.grbHP.ResumeLayout(false);
            this.grbHP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuSTC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMH;
        private System.Windows.Forms.ColumnHeader columnMHP;
        private System.Windows.Forms.ColumnHeader columnTHP;
        private System.Windows.Forms.ColumnHeader columnSTC;
        private System.Windows.Forms.GroupBox grbHP;
        private System.Windows.Forms.TextBox txtTHP;
        private System.Windows.Forms.TextBox txtMHP;
        private System.Windows.Forms.Label lblTHP;
        private System.Windows.Forms.Label lblSTC;
        private System.Windows.Forms.Label lblMHP;
        private System.Windows.Forms.NumericUpDown nuSTC;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btThoat;
    }
}