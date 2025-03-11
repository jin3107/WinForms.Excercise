namespace _023101063_Tuan5
{
    partial class Bai8_tr37
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
            this.lblMENU = new System.Windows.Forms.Label();
            this.lblTU = new System.Windows.Forms.Label();
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.lvMenu1 = new System.Windows.Forms.ListView();
            this.columnSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTU1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMenu2 = new System.Windows.Forms.ListView();
            this.columnTU2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btPhai = new System.Windows.Forms.Button();
            this.btTrai = new System.Windows.Forms.Button();
            this.btTT = new System.Windows.Forms.Button();
            this.lblTT = new System.Windows.Forms.Label();
            this.cbTU = new System.Windows.Forms.ComboBox();
            this.grbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMENU
            // 
            this.lblMENU.AutoSize = true;
            this.lblMENU.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMENU.Location = new System.Drawing.Point(400, 9);
            this.lblMENU.Name = "lblMENU";
            this.lblMENU.Size = new System.Drawing.Size(278, 32);
            this.lblMENU.TabIndex = 0;
            this.lblMENU.Text = "MENU THỨC UỐNG";
            // 
            // lblTU
            // 
            this.lblTU.AutoSize = true;
            this.lblTU.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTU.Location = new System.Drawing.Point(25, 93);
            this.lblTU.Name = "lblTU";
            this.lblTU.Size = new System.Drawing.Size(158, 26);
            this.lblTU.TabIndex = 1;
            this.lblTU.Text = "Loại thức uống:";
            // 
            // grbMenu
            // 
            this.grbMenu.Controls.Add(this.lvMenu1);
            this.grbMenu.Location = new System.Drawing.Point(31, 146);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(443, 327);
            this.grbMenu.TabIndex = 2;
            this.grbMenu.TabStop = false;
            this.grbMenu.Text = "Menu";
            // 
            // lvMenu1
            // 
            this.lvMenu1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSTT,
            this.columnTU1,
            this.columnDG});
            this.lvMenu1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMenu1.FullRowSelect = true;
            this.lvMenu1.GridLines = true;
            this.lvMenu1.HideSelection = false;
            this.lvMenu1.Location = new System.Drawing.Point(7, 31);
            this.lvMenu1.Name = "lvMenu1";
            this.lvMenu1.Size = new System.Drawing.Size(429, 289);
            this.lvMenu1.TabIndex = 0;
            this.lvMenu1.UseCompatibleStateImageBehavior = false;
            this.lvMenu1.View = System.Windows.Forms.View.Details;
            // 
            // columnSTT
            // 
            this.columnSTT.Text = "STT";
            // 
            // columnTU1
            // 
            this.columnTU1.Text = "Thức uống";
            this.columnTU1.Width = 178;
            // 
            // columnDG
            // 
            this.columnDG.Text = "Đơn giá";
            this.columnDG.Width = 151;
            // 
            // lvMenu2
            // 
            this.lvMenu2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTU2,
            this.columnSL,
            this.columnTT});
            this.lvMenu2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMenu2.FullRowSelect = true;
            this.lvMenu2.GridLines = true;
            this.lvMenu2.HideSelection = false;
            this.lvMenu2.Location = new System.Drawing.Point(648, 178);
            this.lvMenu2.Name = "lvMenu2";
            this.lvMenu2.Size = new System.Drawing.Size(429, 289);
            this.lvMenu2.TabIndex = 3;
            this.lvMenu2.UseCompatibleStateImageBehavior = false;
            this.lvMenu2.View = System.Windows.Forms.View.Details;
            // 
            // columnTU2
            // 
            this.columnTU2.Text = "Thức uống";
            this.columnTU2.Width = 130;
            // 
            // columnSL
            // 
            this.columnSL.Text = "Số lượng";
            this.columnSL.Width = 137;
            // 
            // columnTT
            // 
            this.columnTT.Text = "Thành tiền";
            this.columnTT.Width = 121;
            // 
            // btPhai
            // 
            this.btPhai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPhai.Location = new System.Drawing.Point(520, 234);
            this.btPhai.Name = "btPhai";
            this.btPhai.Size = new System.Drawing.Size(82, 77);
            this.btPhai.TabIndex = 5;
            this.btPhai.Text = ">";
            this.btPhai.UseVisualStyleBackColor = true;
            this.btPhai.Click += new System.EventHandler(this.btPhai_Click);
            // 
            // btTrai
            // 
            this.btTrai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrai.Location = new System.Drawing.Point(520, 340);
            this.btTrai.Name = "btTrai";
            this.btTrai.Size = new System.Drawing.Size(82, 77);
            this.btTrai.TabIndex = 6;
            this.btTrai.Text = "<";
            this.btTrai.UseVisualStyleBackColor = true;
            this.btTrai.Click += new System.EventHandler(this.btTrai_Click);
            // 
            // btTT
            // 
            this.btTT.BackColor = System.Drawing.Color.Navy;
            this.btTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTT.ForeColor = System.Drawing.SystemColors.Control;
            this.btTT.Location = new System.Drawing.Point(648, 83);
            this.btTT.Name = "btTT";
            this.btTT.Size = new System.Drawing.Size(128, 50);
            this.btTT.TabIndex = 7;
            this.btTT.Text = "Thành tiền";
            this.btTT.UseVisualStyleBackColor = false;
            this.btTT.Click += new System.EventHandler(this.btTT_Click);
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Location = new System.Drawing.Point(797, 97);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(20, 23);
            this.lblTT.TabIndex = 8;
            this.lblTT.Text = "0";
            // 
            // cbTU
            // 
            this.cbTU.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTU.FormattingEnabled = true;
            this.cbTU.Location = new System.Drawing.Point(213, 88);
            this.cbTU.Name = "cbTU";
            this.cbTU.Size = new System.Drawing.Size(389, 30);
            this.cbTU.TabIndex = 9;
            this.cbTU.SelectedIndexChanged += new System.EventHandler(this.cbTU_SelectedIndexChanged);
            // 
            // Bai8_tr37
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1091, 508);
            this.Controls.Add(this.cbTU);
            this.Controls.Add(this.lblTT);
            this.Controls.Add(this.btTT);
            this.Controls.Add(this.btTrai);
            this.Controls.Add(this.btPhai);
            this.Controls.Add(this.lvMenu2);
            this.Controls.Add(this.grbMenu);
            this.Controls.Add(this.lblTU);
            this.Controls.Add(this.lblMENU);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bai8_tr37";
            this.Text = "Bai8_tr37";
            this.Load += new System.EventHandler(this.Bai8_tr37_Load);
            this.grbMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMENU;
        private System.Windows.Forms.Label lblTU;
        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.ListView lvMenu1;
        private System.Windows.Forms.ColumnHeader columnSTT;
        private System.Windows.Forms.ColumnHeader columnTU1;
        private System.Windows.Forms.ColumnHeader columnDG;
        private System.Windows.Forms.ListView lvMenu2;
        private System.Windows.Forms.ColumnHeader columnTU2;
        private System.Windows.Forms.ColumnHeader columnSL;
        private System.Windows.Forms.ColumnHeader columnTT;
        private System.Windows.Forms.Button btPhai;
        private System.Windows.Forms.Button btTrai;
        private System.Windows.Forms.Button btTT;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.ComboBox cbTU;
    }
}