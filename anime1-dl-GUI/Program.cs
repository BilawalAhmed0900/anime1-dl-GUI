using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace anime1_dl_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new anime1dl_GUI());
        }
    }
}
