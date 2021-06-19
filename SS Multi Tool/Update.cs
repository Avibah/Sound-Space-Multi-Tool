using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace SS_Multi_Tool
{
    public partial class Update : Form
    {
        public string version;
        public Update(string changelog, string vers)
        {
            InitializeComponent();
            richTextBox1.Text = changelog;
            version = vers;
        }

        private void Yes_Click(object sender, System.EventArgs e)
        {
            string directory = Directory.GetCurrentDirectory();
            try
            {
                if (!File.Exists(directory + "\\Multi Tool Updater.exe"))
                {
                    WebClient wc = new WebClient();
                    wc.DownloadFile("https://github.com/Avibah/Sound-Space-Multi-Tool/raw/accompanying-files/Multi%20Tool%20Updater.exe", directory + "\\Multi Tool Updater.exe");
                    Process.Start(directory + "\\Multi Tool Updater.exe");
                }
                else
                {
                    Process.Start(directory + "\\Multi Tool Updater.exe");
                }
            }
            catch
            {
                if (MessageBox.Show("Failed to download update. Would you like to retry?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    Yes_Click(sender, e);
                }
                Close();
            }
        }

        private void No_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
