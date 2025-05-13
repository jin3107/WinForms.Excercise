using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BT_BS8
{
    public partial class BT_BS8 : Form
    {
        private SqlConnection connection;

        public BT_BS8()
        {
            InitializeComponent();
        }

        private void BT_BS8_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=QLCD;Integrated Security=True;");
            HienThiListBoxTinh();
        }

        private void HienThiListBoxTinh()
        {
            string query = "SELECT TINH FROM DIADIEM";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            lstbDSTinh.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                lstbDSTinh.Items.Add(item[0].ToString());
            }
        }

        private void lstbDSTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tinh = lstbDSTinh.SelectedItem.ToString();
            string query = "SELECT Hoatdongchinh, Trangthai " +
                "FROM TRIENKHAICHIENDICH TK, DIADIEM DD " + 
                $"WHERE TK.MaDD = DD.MaDD AND DD.Tinh LIKE N'%{tinh}%'";
            HienThiListView(query);
        }

        private void HienThiListView(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            lstvHoatDongChinh.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                ListViewItem listItem = new ListViewItem(item[0].ToString());
                listItem.SubItems.Add(item[1].ToString());
                lstvHoatDongChinh.Items.Add(listItem);
            }
        }
    }
}
