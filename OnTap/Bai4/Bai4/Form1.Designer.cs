namespace Bai4
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
            this.lblDSHS = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblToan = new System.Windows.Forms.Label();
            this.lblNguVan = new System.Windows.Forms.Label();
            this.lblNgoaiNgu = new System.Windows.Forms.Label();
            this.lstvDSHS = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.numToan = new System.Windows.Forms.NumericUpDown();
            this.numNguVan = new System.Windows.Forms.NumericUpDown();
            this.numNgoaiNgu = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblXuatSac = new System.Windows.Forms.Label();
            this.lblYeu = new System.Windows.Forms.Label();
            this.lblTrungBinh = new System.Windows.Forms.Label();
            this.lblKha = new System.Windows.Forms.Label();
            this.lblGioi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNguVan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNgoaiNgu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDSHS
            // 
            this.lblDSHS.AutoSize = true;
            this.lblDSHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSHS.Location = new System.Drawing.Point(301, 9);
            this.lblDSHS.Name = "lblDSHS";
            this.lblDSHS.Size = new System.Drawing.Size(291, 29);
            this.lblDSHS.TabIndex = 0;
            this.lblDSHS.Text = "DANH SÁCH HỌC SINH";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(12, 80);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(63, 22);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblToan
            // 
            this.lblToan.AutoSize = true;
            this.lblToan.Location = new System.Drawing.Point(324, 77);
            this.lblToan.Name = "lblToan";
            this.lblToan.Size = new System.Drawing.Size(52, 22);
            this.lblToan.TabIndex = 2;
            this.lblToan.Text = "Toán";
            // 
            // lblNguVan
            // 
            this.lblNguVan.AutoSize = true;
            this.lblNguVan.Location = new System.Drawing.Point(478, 77);
            this.lblNguVan.Name = "lblNguVan";
            this.lblNguVan.Size = new System.Drawing.Size(80, 22);
            this.lblNguVan.TabIndex = 3;
            this.lblNguVan.Text = "Ngữ Văn";
            // 
            // lblNgoaiNgu
            // 
            this.lblNgoaiNgu.AutoSize = true;
            this.lblNgoaiNgu.Location = new System.Drawing.Point(671, 77);
            this.lblNgoaiNgu.Name = "lblNgoaiNgu";
            this.lblNgoaiNgu.Size = new System.Drawing.Size(95, 22);
            this.lblNgoaiNgu.TabIndex = 4;
            this.lblNgoaiNgu.Text = "Ngoại Ngữ";
            // 
            // lstvDSHS
            // 
            this.lstvDSHS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstvDSHS.FullRowSelect = true;
            this.lstvDSHS.GridLines = true;
            this.lstvDSHS.HideSelection = false;
            this.lstvDSHS.Location = new System.Drawing.Point(12, 126);
            this.lstvDSHS.Name = "lstvDSHS";
            this.lstvDSHS.Size = new System.Drawing.Size(866, 202);
            this.lstvDSHS.TabIndex = 5;
            this.lstvDSHS.UseCompatibleStateImageBehavior = false;
            this.lstvDSHS.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Toán";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngữ văn";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngoại ngữ";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Điểm trung bình";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Xếp loại";
            this.columnHeader6.Width = 150;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(81, 74);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(218, 28);
            this.txtHoTen.TabIndex = 6;
            // 
            // numToan
            // 
            this.numToan.DecimalPlaces = 2;
            this.numToan.Location = new System.Drawing.Point(382, 71);
            this.numToan.Name = "numToan";
            this.numToan.Size = new System.Drawing.Size(90, 28);
            this.numToan.TabIndex = 7;
            // 
            // numNguVan
            // 
            this.numNguVan.DecimalPlaces = 2;
            this.numNguVan.Location = new System.Drawing.Point(564, 71);
            this.numNguVan.Name = "numNguVan";
            this.numNguVan.Size = new System.Drawing.Size(90, 28);
            this.numNguVan.TabIndex = 8;
            // 
            // numNgoaiNgu
            // 
            this.numNgoaiNgu.DecimalPlaces = 2;
            this.numNgoaiNgu.Location = new System.Drawing.Point(772, 71);
            this.numNgoaiNgu.Name = "numNgoaiNgu";
            this.numNgoaiNgu.Size = new System.Drawing.Size(90, 28);
            this.numNgoaiNgu.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 359);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 40);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(172, 359);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(127, 40);
            this.btnThongKe.TabIndex = 11;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblXuatSac
            // 
            this.lblXuatSac.AutoSize = true;
            this.lblXuatSac.Location = new System.Drawing.Point(378, 359);
            this.lblXuatSac.Name = "lblXuatSac";
            this.lblXuatSac.Size = new System.Drawing.Size(319, 22);
            this.lblXuatSac.TabIndex = 12;
            this.lblXuatSac.Text = "Tổng số học sinh xếp loại Xuất sắc là: ";
            // 
            // lblYeu
            // 
            this.lblYeu.AutoSize = true;
            this.lblYeu.Location = new System.Drawing.Point(378, 495);
            this.lblYeu.Name = "lblYeu";
            this.lblYeu.Size = new System.Drawing.Size(281, 22);
            this.lblYeu.TabIndex = 13;
            this.lblYeu.Text = "Tổng số học sinh xếp loại Yếu là: ";
            // 
            // lblTrungBinh
            // 
            this.lblTrungBinh.AutoSize = true;
            this.lblTrungBinh.Location = new System.Drawing.Point(378, 460);
            this.lblTrungBinh.Name = "lblTrungBinh";
            this.lblTrungBinh.Size = new System.Drawing.Size(336, 22);
            this.lblTrungBinh.TabIndex = 14;
            this.lblTrungBinh.Text = "Tổng số học sinh xếp loại Trung bình là: ";
            // 
            // lblKha
            // 
            this.lblKha.AutoSize = true;
            this.lblKha.Location = new System.Drawing.Point(378, 426);
            this.lblKha.Name = "lblKha";
            this.lblKha.Size = new System.Drawing.Size(281, 22);
            this.lblKha.TabIndex = 15;
            this.lblKha.Text = "Tổng số học sinh xếp loại Khá là: ";
            // 
            // lblGioi
            // 
            this.lblGioi.AutoSize = true;
            this.lblGioi.Location = new System.Drawing.Point(378, 392);
            this.lblGioi.Name = "lblGioi";
            this.lblGioi.Size = new System.Drawing.Size(281, 22);
            this.lblGioi.TabIndex = 16;
            this.lblGioi.Text = "Tổng số học sinh xếp loại Giỏi là: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 531);
            this.Controls.Add(this.lblGioi);
            this.Controls.Add(this.lblKha);
            this.Controls.Add(this.lblTrungBinh);
            this.Controls.Add(this.lblYeu);
            this.Controls.Add(this.lblXuatSac);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.numNgoaiNgu);
            this.Controls.Add(this.numNguVan);
            this.Controls.Add(this.numToan);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lstvDSHS);
            this.Controls.Add(this.lblNgoaiNgu);
            this.Controls.Add(this.lblNguVan);
            this.Controls.Add(this.lblToan);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblDSHS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNguVan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNgoaiNgu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDSHS;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblToan;
        private System.Windows.Forms.Label lblNguVan;
        private System.Windows.Forms.Label lblNgoaiNgu;
        private System.Windows.Forms.ListView lstvDSHS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.NumericUpDown numToan;
        private System.Windows.Forms.NumericUpDown numNguVan;
        private System.Windows.Forms.NumericUpDown numNgoaiNgu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblXuatSac;
        private System.Windows.Forms.Label lblYeu;
        private System.Windows.Forms.Label lblTrungBinh;
        private System.Windows.Forms.Label lblKha;
        private System.Windows.Forms.Label lblGioi;
    }
}

