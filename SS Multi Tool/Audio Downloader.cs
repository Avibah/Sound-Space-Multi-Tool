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

        public static string GetFinalRedirect(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return url;

            int maxRedirCount = 8;  // prevent infinite loops
            string newUrl = url;
            do
            {
                HttpWebRequest req;
                HttpWebResponse resp = null;
                try
                {
                    req = (HttpWebRequest)WebRequest.Create(url);
                    req.Method = "HEAD";
                    req.AllowAutoRedirect = false;
                    resp = (HttpWebResponse)req.GetResponse();
                    switch (resp.StatusCode)
                    {
                        case HttpStatusCode.OK:
                            return newUrl;
                        case HttpStatusCode.Redirect:
                        case HttpStatusCode.MovedPermanently:
                        case HttpStatusCode.RedirectKeepVerb:
                        case HttpStatusCode.RedirectMethod:
                            newUrl = resp.Headers["Location"];
                            if (newUrl == null)
                                return url;

                            if (newUrl.IndexOf("://", StringComparison.Ordinal) == -1)
                            {
                                // Doesn't have a URL Schema, meaning it's a relative or absolute URL
                                Uri u = new Uri(new Uri(url), newUrl);
                                newUrl = u.ToString();
                            }
                            break;
                        default:
                            return newUrl;
                    }
                    url = newUrl;
                }
                catch (WebException)
                {
                    // Return the last known good URL
                    return newUrl;
                }
                catch (Exception)
                {
                    return null;
                }
                finally
                {
                    if (resp != null)
                        resp.Close();
                }
            } while (maxRedirCount-- > 0);

            return newUrl;
        }

        private void MP3_Click(object sender, EventArgs e)
        {
            if (audioID.Text != "")
            {
                string data = audioID.Text;
                string id;
                try
                {
                    while (data.Contains("https:"))
                    {
                        SecureWebClient wc = new SecureWebClient();
                        data = wc.DownloadString(data);
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to download data from url");
                }
                if (data.Contains(","))
                {
                    id = data.Substring(0, data.IndexOf(','));
                }
                else
                {
                    id = data;
                }
                string filename;
                if (CatalogName.Checked == true)
                {
                    string url = "https://www.roblox.com/library/" + id;
                    string finalurl = GetFinalRedirect(url);
                    filename = finalurl.Substring(finalurl.LastIndexOf('/') + 1, finalurl.Length - finalurl.LastIndexOf('/') - 1);
                    filename = filename.Replace("-", " ");
                }
                else
                {
                    filename = FileName.Text;
                }
                string directory = Directory.GetCurrentDirectory();
                try
                {
                    using (var wc = new SecureWebClient())
                    {
                        if (filename != "" && !File.Exists(directory + "\\" + filename + ".mp3"))
                        {
                            try
                            {
                                wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directory + "\\" + filename + ".mp3");
                            }
                            catch
                            {
                                wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directory + "\\" + id + ".mp3");
                            }
                            MessageBox.Show("Successfully downloaded audio at " + directory);
                        }
                        else if (!File.Exists(directory + "\\" + id + ".mp3"))
                        {
                            wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directory + "\\" + id + ".mp3");
                            MessageBox.Show("Successfully downloaded audio at " + directory);
                        }
                        else
                        {
                            MessageBox.Show("Audio already downloaded!");
                        }
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
                try
                {
                    while (data.Contains("https:"))
                    {
                        SecureWebClient wc = new SecureWebClient();
                        data = wc.DownloadString(data);
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to download data from url");
                }
                if (data.Contains(","))
                {
                    id = data.Substring(0, data.IndexOf(','));
                }
                else
                {
                    id = data;
                }
                string filename;
                if (CatalogName.Checked == true)
                {
                    string url = "https://www.roblox.com/library/" + id;
                    string finalurl = GetFinalRedirect(url);
                    filename = finalurl.Substring(finalurl.LastIndexOf('/') + 1, finalurl.Length - finalurl.LastIndexOf('/') - 1);
                    filename = filename.Replace("-", " ");
                }
                else
                {
                    filename = FileName.Text;
                }
                string directory = Directory.GetCurrentDirectory();
                try
                {
                    using (var wc = new SecureWebClient())
                    {
                        if (filename != "" && !File.Exists(directory + "\\" + filename + ".ogg"))
                        {
                            try
                            {
                                wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directory + "\\" + filename + ".ogg");
                            }
                            catch
                            {
                                wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directory + "\\" + id + ".ogg");
                            }
                            MessageBox.Show("Successfully downloaded audio at " + directory);
                        }
                        else if (!File.Exists(directory + "\\" + id + ".ogg"))
                        {
                            wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directory + "\\" + id + ".ogg");
                            MessageBox.Show("Successfully downloaded audio at " + directory);
                        }
                        else
                        {
                            MessageBox.Show("Audio already downloaded!");
                        }
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
