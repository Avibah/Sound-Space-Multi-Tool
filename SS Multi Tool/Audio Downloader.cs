using System;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace SS_Multi_Tool
{
    public partial class Audio_Downloader : Form
    {
        public Audio_Downloader()
        {
            InitializeComponent();
        }

        private void MP3_Click(object sender, EventArgs e)
        {
            if (audioID.Text != "")
            {
                string data = audioID.Text;
                string id;
                if (data.Contains("https:"))
                {
                    try
                    {
                        WebClient wc = new WebClient();
                        data = wc.DownloadString(data);
                    }
                    catch
                    {
                        MessageBox.Show("Failed to download data from url");
                    }
                }
                if (data.Contains(","))
                {
                    id = data.Substring(0, data.IndexOf(','));
                }
                else
                {
                    id = data;
                }
                string directory = Directory.GetCurrentDirectory();
                try
                {
                    if (!File.Exists(directory + "\\" + id + ".mp3") && !File.Exists(directory + "\\" + FileName.Text + ".mp3"))
                    {
                        using (var wc = new SecureWebClient())
                        {
                            if (FileName.Text != "")
                            {
                                try
                                {
                                    wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directory + "\\" + FileName.Text + ".mp3");
                                }
                                catch
                                {
                                    wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directory + "\\" + id + ".mp3");
                                }
                            }
                            else
                            {
                                wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directory + "\\" + id + ".mp3");
                            }
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

        private void OGG_Click(object sender, EventArgs e)
        {
            if (audioID.Text != "")
            {
                string data = audioID.Text;
                string id;
                if (data.Contains("https:"))
                {
                    try
                    {
                        WebClient wc = new WebClient();
                        data = wc.DownloadString(data);
                    }
                    catch
                    {
                        MessageBox.Show("Failed to download data from url");
                    }
                }
                if (data.Contains(","))
                {
                    id = data.Substring(0, data.IndexOf(','));
                }
                else
                {
                    id = data;
                }
                string directory = Directory.GetCurrentDirectory();
                try
                {
                    if (!File.Exists(directory + "\\" + id + ".ogg") && !File.Exists(directory + "\\" + FileName.Text + ".ogg"))
                    {
                        using (var wc = new SecureWebClient())
                        {
                            if (FileName.Text != "")
                            {
                                try
                                {
                                    wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directory + "\\" + FileName.Text + ".ogg");
                                }
                                catch
                                {
                                    wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directory + "\\" + id + ".ogg");
                                }
                            }
                            else
                            {
                                wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directory + "\\" + id + ".ogg");
                            }
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
