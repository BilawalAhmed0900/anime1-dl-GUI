using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace anime1_dl_GUI
{
    public partial class anime1dl_GUI : Form
    {
        public anime1dl_GUI()
        {
            InitializeComponent();
        }

        private void dButton_Click(object sender, EventArgs e)
        {
            string Exe = Directory.GetCurrentDirectory() + "\\" + "anime1-dl.exe";
            if (linkBox.Text != "" && linkBox.Text.Contains("http://www.anime1.com/watch/") && File.Exists(Exe))
            {
                Process process = Process.Start(Exe, linkBox.Text);
                process.WaitForExit();
            }
            else if (!linkBox.Text.Contains("http://www.anime1.com/watch/"))
            {
                MessageBox.Show("Link invalid\nExampe: http://www.anime1.com/watch/one-piece\nor\nhttp://www.anime1.com/watch/one-punch-man/episode-1");
            }
            else if (!File.Exists(Exe))
            {
                MessageBox.Show("Cannot find anime1-dl.exe\nMake sure it is in the same directory");
            }
        }
    }
}
