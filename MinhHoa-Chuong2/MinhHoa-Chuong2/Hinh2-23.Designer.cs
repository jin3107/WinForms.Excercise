using System.Drawing;
using System.Windows.Forms;

namespace MinhHoa_Chuong2
{
    partial class Hinh2_23
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
            lstMonHoc = new ListBox();
            labelMonHoc = new Label();
            labelViTri = new Label();
            textBoxMH = new TextBox();
            numericUpDownVT = new NumericUpDown();
            buttonThem = new Button();
            buttonXoa = new Button();
            buttonThoat = new Button();
            groupBoxTTCT = new GroupBox();
            textBoxChiSo = new TextBox();
            textBoxMHDuocChon = new TextBox();
            labelChiSo = new Label();
            labelMHDuocChon = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVT).BeginInit();
            groupBoxTTCT.SuspendLayout();
            SuspendLayout();
            // 
            // lstMonHoc
            // 
            lstMonHoc.FormattingEnabled = true;
            lstMonHoc.ItemHeight = 25;
            lstMonHoc.Location = new Point(31, 38);
            lstMonHoc.Margin = new Padding(4);
            lstMonHoc.Name = "lstMonHoc";
            lstMonHoc.SelectionMode = SelectionMode.MultiSimple;
            lstMonHoc.Size = new Size(235, 479);
            lstMonHoc.TabIndex = 0;
            lstMonHoc.Click += lstMonHoc_Click;
            // 
            // labelMonHoc
            // 
            labelMonHoc.AutoSize = true;
            labelMonHoc.Location = new Point(319, 38);
            labelMonHoc.Margin = new Padding(4, 0, 4, 0);
            labelMonHoc.Name = "labelMonHoc";
            labelMonHoc.Size = new Size(87, 25);
            labelMonHoc.TabIndex = 1;
            labelMonHoc.Text = "Môn học:";
            // 
            // labelViTri
            // 
            labelViTri.AutoSize = true;
            labelViTri.Location = new Point(319, 115);
            labelViTri.Margin = new Padding(4, 0, 4, 0);
            labelViTri.Name = "labelViTri";
            labelViTri.Size = new Size(52, 25);
            labelViTri.TabIndex = 2;
            labelViTri.Text = "Vị trí:";
            // 
            // textBoxMH
            // 
            textBoxMH.Location = new Point(432, 35);
            textBoxMH.Name = "textBoxMH";
            textBoxMH.Size = new Size(361, 31);
            textBoxMH.TabIndex = 3;
            // 
            // numericUpDownVT
            // 
            numericUpDownVT.Location = new Point(432, 113);
            numericUpDownVT.Name = "numericUpDownVT";
            numericUpDownVT.Size = new Size(361, 31);
            numericUpDownVT.TabIndex = 4;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(319, 173);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(99, 37);
            buttonThem.TabIndex = 5;
            buttonThem.Text = "THÊM";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(516, 173);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(99, 37);
            buttonXoa.TabIndex = 6;
            buttonXoa.Text = "XÓA";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.Location = new Point(694, 173);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(99, 37);
            buttonThoat.TabIndex = 7;
            buttonThoat.Text = "THOÁT";
            buttonThoat.UseVisualStyleBackColor = true;
            // 
            // groupBoxTTCT
            // 
            groupBoxTTCT.Controls.Add(textBoxChiSo);
            groupBoxTTCT.Controls.Add(textBoxMHDuocChon);
            groupBoxTTCT.Controls.Add(labelChiSo);
            groupBoxTTCT.Controls.Add(labelMHDuocChon);
            groupBoxTTCT.Location = new Point(319, 240);
            groupBoxTTCT.Name = "groupBoxTTCT";
            groupBoxTTCT.Size = new Size(474, 277);
            groupBoxTTCT.TabIndex = 8;
            groupBoxTTCT.TabStop = false;
            groupBoxTTCT.Text = "Thông tin chi tiết";
            // 
            // textBoxChiSo
            // 
            textBoxChiSo.Location = new Point(58, 226);
            textBoxChiSo.Name = "textBoxChiSo";
            textBoxChiSo.Size = new Size(410, 31);
            textBoxChiSo.TabIndex = 3;
            // 
            // textBoxMHDuocChon
            // 
            textBoxMHDuocChon.Location = new Point(58, 71);
            textBoxMHDuocChon.Multiline = true;
            textBoxMHDuocChon.Name = "textBoxMHDuocChon";
            textBoxMHDuocChon.Size = new Size(410, 111);
            textBoxMHDuocChon.TabIndex = 2;
            // 
            // labelChiSo
            // 
            labelChiSo.AutoSize = true;
            labelChiSo.Location = new Point(6, 185);
            labelChiSo.Name = "labelChiSo";
            labelChiSo.Size = new Size(233, 25);
            labelChiSo.TabIndex = 1;
            labelChiSo.Text = "Chỉ số các dòng được chọn:";
            // 
            // labelMHDuocChon
            // 
            labelMHDuocChon.AutoSize = true;
            labelMHDuocChon.Location = new Point(6, 43);
            labelMHDuocChon.Name = "labelMHDuocChon";
            labelMHDuocChon.Size = new Size(177, 25);
            labelMHDuocChon.TabIndex = 0;
            labelMHDuocChon.Text = "Môn học được chọn:";
            // 
            // Hinh2_23
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 545);
            Controls.Add(groupBoxTTCT);
            Controls.Add(buttonThoat);
            Controls.Add(buttonXoa);
            Controls.Add(buttonThem);
            Controls.Add(numericUpDownVT);
            Controls.Add(textBoxMH);
            Controls.Add(labelViTri);
            Controls.Add(labelMonHoc);
            Controls.Add(lstMonHoc);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Hinh2_23";
            Text = "Hinh2_23";
            ((System.ComponentModel.ISupportInitialize)numericUpDownVT).EndInit();
            groupBoxTTCT.ResumeLayout(false);
            groupBoxTTCT.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMonHoc;
        private Label labelMonHoc;
        private Label labelViTri;
        private TextBox textBoxMH;
        private NumericUpDown numericUpDownVT;
        private Button buttonThem;
        private Button buttonXoa;
        private Button buttonThoat;
        private GroupBox groupBoxTTCT;
        private Label labelMHDuocChon;
        private Label labelChiSo;
        private TextBox textBoxChiSo;
        private TextBox textBoxMHDuocChon;
    }
}