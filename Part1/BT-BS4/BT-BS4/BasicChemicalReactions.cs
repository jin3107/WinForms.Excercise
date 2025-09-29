using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_BS4
{
    public partial class BasicChemicalReactions : Form
    {
        public BasicChemicalReactions()
        {
            InitializeComponent();
            lbPTPU.DrawMode = DrawMode.OwnerDrawFixed;
            lbPTPU.DrawItem += lbPTPU_DrawItem;
        }

        private void BasicChemicalReactions_Load(object sender, EventArgs e)
        {
            lbAcid.Items.Add("H\u2082SO\u2084");
            lbAcid.Items.Add("HCl");
            lbAcid.Items.Add("H\u2082CO\u2083");
            lbAcid.Items.Add("HNO\u2083");

            clbOxideBase.Items.Add("CaO");
            clbOxideBase.Items.Add("Na\u2082O");
            clbOxideBase.Items.Add("K\u2082O");
            clbOxideBase.Items.Add("SO\u2082");
            clbOxideBase.Items.Add("CO\u2082");
        }

        private void btArrow_Click(object sender, EventArgs e)
        {
            if (lbAcid.SelectedIndex == -1 || clbOxideBase.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 acid và ít nhất 1 Oxide base.", "Cảnh báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PhanUngHoaHoc();
        }

        private void PhanUngHoaHoc()
        {
            lbPTPU.Items.Clear();
            foreach (object acidObj in lbAcid.SelectedItems)
            {
                string acid = acidObj.ToString();
                foreach (object item in clbOxideBase.CheckedItems)
                {
                    string oxideBase = item.ToString();
                    string phanUng = KhoiTaoPhanUng(acid, oxideBase);
                    lbPTPU.Items.Add(phanUng);
                }
            }
        }

        private string KhoiTaoPhanUng(string acid, string oxideBase)
        {
            string congThucAcid = acid;
            string muoi = "";
            string nuoc = "H\u2082O";
            switch (acid)
            {
                case "H\u2082SO\u2084": // H₂SO₄
                    if (oxideBase == "CaO")
                    {
                        muoi = "CaSO\u2084";
                        return $"{congThucAcid} + {oxideBase} -> {muoi} + {nuoc}";
                    }
                    else if (oxideBase == "Na\u2082O")
                    {
                        muoi = "Na\u2082SO\u2084";
                        return $"{congThucAcid} + {oxideBase} -> {muoi} + {nuoc}";
                    }
                    else if (oxideBase == "K\u2082O")
                    {
                        muoi = "K\u2082SO\u2084";
                        return $"{congThucAcid} + {oxideBase} -> {muoi} + {nuoc}";
                    }
                    else if (oxideBase == "SO\u2082" || oxideBase == "CO\u2082")
                        return $"Không có phản ứng giữa {acid} và {oxideBase}";
                    break;

                case "HCl":
                    if (oxideBase == "CaO")
                    {
                        muoi = "CaCl\u2082";
                        return $"2{congThucAcid} + {oxideBase} -> {muoi} + {nuoc}";
                    }
                    else if (oxideBase == "Na\u2082O")
                    {
                        muoi = "2NaCl";
                        return $"2{congThucAcid} + {oxideBase} -> {muoi} + {nuoc}";
                    }
                    else if (oxideBase == "K\u2082O")
                    {
                        muoi = "2KCl";
                        return $"2{congThucAcid} + {oxideBase} -> {muoi} + {nuoc}";
                    }
                    else if (oxideBase == "SO\u2082" || oxideBase == "CO\u2082")
                        return $"Không có phản ứng giữa {acid} và {oxideBase}";
                    break;

                case "H\u2082CO\u2083": // H₂CO₃
                    if (oxideBase == "CaO")
                    {
                        muoi = "CaCO\u2083";
                        return $"{congThucAcid} + {oxideBase} -> {muoi} + {nuoc}";
                    }
                    else if (oxideBase == "Na\u2082O")
                    {
                        muoi = "Na\u2082CO\u2083";
                        return $"{congThucAcid} + {oxideBase} -> {muoi} + {nuoc}";
                    }
                    else if (oxideBase == "K\u2082O")
                    {
                        muoi = "K\u2082CO\u2083";
                        return $"{congThucAcid} + {oxideBase} -> {muoi} + {nuoc}";
                    }
                    else if (oxideBase == "SO\u2082" || oxideBase == "CO\u2082")
                        return $"Không có phản ứng giữa {acid} và {oxideBase}";
                    break;

                case "HNO\u2083": // HNO₃
                    if (oxideBase == "CaO")
                    {
                        muoi = "Ca(NO\u2083)\u2082";
                        return $"2{congThucAcid} + {oxideBase} -> {muoi} + {nuoc}";
                    }
                    else if (oxideBase == "Na\u2082O")
                    {
                        muoi = "2NaNO\u2083";
                        return $"2{congThucAcid} + {oxideBase} -> {muoi} + {nuoc}";
                    }
                    else if (oxideBase == "K\u2082O")
                    {
                        muoi = "2KNO\u2083";
                        return $"2{congThucAcid} + {oxideBase} -> {muoi} + {nuoc}";
                    }
                    else if (oxideBase == "SO\u2082" || oxideBase == "CO\u2082")
                        return $"Không có phản ứng giữa {acid} và {oxideBase}";
                    break;
            }
            return $"Không có phản ứng giữa {acid} và {oxideBase}";
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbOxideBase.Items.Count; i++)
            {
                clbOxideBase.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void lbPTPU_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            string item = lbPTPU.Items[e.Index].ToString();
            e.DrawBackground();
            Color color;
            if (item.Contains("Không có phản ứng"))
                color = Color.Red;
            else if (e.Index % 4 == 0)
                color = Color.Green;
            else if (e.Index % 4 == 1)
                color = Color.Blue;
            else if (e.Index % 4 == 2)
                color = Color.Orange;
            else
                color = Color.Purple;
            using (Brush brush = new SolidBrush(color))
            {
                e.Graphics.DrawString(item, e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            }   
            e.DrawFocusRectangle();
        }
    }
}
