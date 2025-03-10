using System;
using System.Windows.Forms;

namespace _023101063_Tuan5
{
    public partial class Hinh2_26 : Form
    {
        public Hinh2_26()
        {
            InitializeComponent();
        }

        private void lvMH_Click(object sender, EventArgs e)
        {
            if (lvMH.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvMH.SelectedItems[0];
                txtMHP.Text = selectedItem.Text;
                txtTHP.Text = selectedItem.SubItems[1].Text;
                nuSTC.Value = int.TryParse(selectedItem.SubItems[2].Text, out int stc) ? stc : 0;
            }
        }

        private void Clear()
        {
            txtMHP.Clear();
            txtTHP.Clear();
            nuSTC.Value = 0;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string maHP = txtMHP.Text.Trim();
            string tenHP = txtTHP.Text.Trim();
            int stc = (int)nuSTC.Value;

            if (string.IsNullOrEmpty(maHP))
            {
                MessageBox.Show("Mã học phần không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tenHP))
            {
                MessageBox.Show("Tên học phần không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (stc == 0)
            {
                MessageBox.Show("Số tín chỉ phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (ListViewItem item in lvMH.Items)
            {
                if (item.Text.Equals(maHP, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã học phần đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            ListViewItem newItem = new ListViewItem(maHP);
            newItem.SubItems.Add(tenHP);
            newItem.SubItems.Add(stc.ToString());
            lvMH.Items.Add(newItem);
            Clear();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (lvMH.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một học phần để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHP = txtMHP.Text.Trim();
            string tenHP = txtTHP.Text.Trim();
            int stc = (int)nuSTC.Value;

            if (string.IsNullOrEmpty(maHP) || string.IsNullOrEmpty(tenHP) || stc == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem selectedItem = lvMH.SelectedItems[0];
            selectedItem.Text = maHP;
            selectedItem.SubItems[1].Text = tenHP;
            selectedItem.SubItems[2].Text = stc.ToString();
            Clear();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (lvMH.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một học phần để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa học phần này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lvMH.Items.Remove(lvMH.SelectedItems[0]);
                Clear();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
