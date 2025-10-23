namespace Tuan5.TreeView.GUI
{
    partial class TreeView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeView));
            this.tvw = new System.Windows.Forms.TreeView();
            this.image = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tvw
            // 
            this.tvw.ImageIndex = 0;
            this.tvw.ImageList = this.image;
            this.tvw.Location = new System.Drawing.Point(104, 44);
            this.tvw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvw.Name = "tvw";
            this.tvw.SelectedImageIndex = 0;
            this.tvw.Size = new System.Drawing.Size(614, 432);
            this.tvw.TabIndex = 0;
            // 
            // image
            // 
            this.image.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image.ImageStream")));
            this.image.TransparentColor = System.Drawing.Color.Transparent;
            this.image.Images.SetKeyName(0, "cce1be0995dc188241cd.jpg");
            this.image.Images.SetKeyName(1, "pic.jpg");
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 548);
            this.Controls.Add(this.tvw);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.TreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvw;
        private System.Windows.Forms.ImageList image;
    }
}