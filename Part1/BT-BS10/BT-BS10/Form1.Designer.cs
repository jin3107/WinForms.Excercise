namespace BT_BS10
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
            this.lblPTTN = new System.Windows.Forms.Label();
            this.lblSoM = new System.Windows.Forms.Label();
            this.lblBangKeCT = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lstvBangKeCT = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSoM = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPTTN
            // 
            this.lblPTTN.AutoSize = true;
            this.lblPTTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTTN.Location = new System.Drawing.Point(97, 9);
            this.lblPTTN.Name = "lblPTTN";
            this.lblPTTN.Size = new System.Drawing.Size(307, 29);
            this.lblPTTN.TabIndex = 0;
            this.lblPTTN.Text = "PHIẾU TÍNH TIỀN NƯỚC";
            // 
            // lblSoM
            // 
            this.lblSoM.AutoSize = true;
            this.lblSoM.Location = new System.Drawing.Point(28, 65);
            this.lblSoM.Name = "lblSoM";
            this.lblSoM.Size = new System.Drawing.Size(102, 22);
            this.lblSoM.TabIndex = 1;
            this.lblSoM.Text = "Nhập số m³";
            // 
            // lblBangKeCT
            // 
            this.lblBangKeCT.AutoSize = true;
            this.lblBangKeCT.Location = new System.Drawing.Point(28, 154);
            this.lblBangKeCT.Name = "lblBangKeCT";
            this.lblBangKeCT.Size = new System.Drawing.Size(133, 22);
            this.lblBangKeCT.TabIndex = 2;
            this.lblBangKeCT.Text = "Bảng kê chi tiết";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(132, 385);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(91, 22);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // lstvBangKeCT
            // 
            this.lstvBangKeCT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstvBangKeCT.FullRowSelect = true;
            this.lstvBangKeCT.GridLines = true;
            this.lstvBangKeCT.HideSelection = false;
            this.lstvBangKeCT.Location = new System.Drawing.Point(32, 196);
            this.lstvBangKeCT.Name = "lstvBangKeCT";
            this.lstvBangKeCT.Size = new System.Drawing.Size(416, 174);
            this.lstvBangKeCT.TabIndex = 4;
            this.lstvBangKeCT.UseCompatibleStateImageBehavior = false;
            this.lstvBangKeCT.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bậc";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mức sử dụng";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 100;
            // 
            // txtSoM
            // 
            this.txtSoM.Location = new System.Drawing.Point(150, 59);
            this.txtSoM.Name = "txtSoM";
            this.txtSoM.Size = new System.Drawing.Size(170, 28);
            this.txtSoM.TabIndex = 5;
            this.txtSoM.TabStop = false;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(346, 55);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(102, 37);
            this.btnTinhTien.TabIndex = 6;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 436);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtSoM);
            this.Controls.Add(this.lstvBangKeCT);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblBangKeCT);
            this.Controls.Add(this.lblSoM);
            this.Controls.Add(this.lblPTTN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPTTN;
        private System.Windows.Forms.Label lblSoM;
        private System.Windows.Forms.Label lblBangKeCT;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.ListView lstvBangKeCT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtSoM;
        private System.Windows.Forms.Button btnTinhTien;
    }
}

