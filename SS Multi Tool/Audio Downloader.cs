using System;
using System.Windows.Forms;
using System.IO;

namespace SS_Multi_Tool
{
    public partial class Audio_Downloader : Form
    {
        public Audio_Downloader()
        {
            InitializeComponent();
        }

        private void mp3_Click(object sender, EventArgs e)
        {
            if (audioID.Text != "")
            {
                string id = audioID.Text;
                string directory = Directory.GetCurrentDirectory();
                try
                {
                    if (!File.Exists(directory + "\\" + id + ".mp3"))
                    {
                        using (var wc = new SecureWebClient())
                        {
                            wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directory + "\\" + id + ".mp3");
                        }
                        MessageBox.Show("Successfully downloaded audio at " + directory);
                    }
                    else
                    {
                        MessageBox.Show("Audio already downloaded!");
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to download audio with id: " + id, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory());
        }

        private void ogg_Click(object sender, EventArgs e)
        {
            if (audioID.Text != "")
            {
                string id = audioID.Text;
                string directory = Directory.GetCurrentDirectory();
                try
                {
                    if (!File.Exists(directory + "\\" + id + ".mp3"))
                    {
                        using (var wc = new SecureWebClient())
                        {
                            wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directory + "\\" + id + ".ogg");
                        }
                        MessageBox.Show("Successfully downloaded audio at " + directory);
                    }
                    else
                    {
                        MessageBox.Show("Audio already downloaded!");
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to download audio with id: " + id, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
