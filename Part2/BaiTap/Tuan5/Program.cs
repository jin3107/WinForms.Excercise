using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuan5.Bai1a.GUI;
using Tuan5.Bai1b1.GUI;
using Tuan5.TreeView.GUI;

namespace Tuan5
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Tuan5.TreeView.GUI.TreeView());
        }
    }
}
