using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuan5.TreeView.DAO;

namespace Tuan5.TreeView.GUI
{
    public partial class TreeView : Form
    {
        public Database db;

        public TreeView()
        {
            InitializeComponent();
        }

        private void TreeView_Load(object sender, EventArgs e)
        {
            db = new Database("RAINY", "QLSV_Tuan5");
            DataTable dt = db.LayDL("Select MaLop, TenLop From Lop");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TreeNode node = new TreeNode();
                node.Text= "Lớp " + dt.Rows[i][1].ToString();
                node.Tag = dt.Rows[i][0].ToString();
                node.ImageIndex = 0;
                DataTable dt1 = db.LayDL($"Select MaSV, TenSV From SinhVien Where MaLop = '{node.Tag.ToString()}'");
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    TreeNode node1 = new TreeNode();
                    node1.Text = "Sinh viên " + dt1.Rows[j][1].ToString();
                    node1.Tag = dt1.Rows[j][0].ToString();
                    node1.ImageIndex = 1;
                    node.Nodes.Add(node1);
                }
                tvw.Nodes.Add(node);
            }
        }
    }
}
