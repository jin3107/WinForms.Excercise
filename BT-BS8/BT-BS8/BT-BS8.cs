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
        }
    }
}
