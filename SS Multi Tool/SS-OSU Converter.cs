﻿using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace SS_Multi_Tool
{
    public partial class SS_OSU_Converter : Form
    {
        public SS_OSU_Converter()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            try
            {
                if (Input.Text == "" || Author.Text == "" || Title.Text == "" || BPM.Text == "" || !decimal.TryParse(BPM.Text, out _))
                {
                    MessageBox.Show("Please enter all required information (Title, Author, Map Data, BPM)", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string title = Title.Text;
                    string author = Author.Text;
                    title = title.Replace(" ", "_");
                    author = author.Replace(" ", "_");
                    string data = Input.Text;
                    SecureWebClient wc = new SecureWebClient();
                    try
                    {
                        while (true)
                            data = wc.DownloadString(data);
                    }
                    catch { }
                    int rep = data.IndexOf(',');
                    string id = data.Substring(0, rep);
                    int i = 0;
                    string directory = Directory.GetCurrentDirectory();
                    string directoryF = directory + "\\" + author + " - " + title;
                    if (!Directory.Exists(directoryF))
                    {
                        Directory.CreateDirectory(directoryF);
                    }
                    try
                    {
                        if (!File.Exists(directoryF + "\\" + id + ".mp3"))
                        {
                            using (wc = new SecureWebClient())
                            {
                                wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directoryF + "\\" + id + ".mp3");
                            }
                        }
                        i = 1;
                    }
                    catch
                    {
                        MessageBox.Show("Failed to download audio with id: " + id, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (i == 1)
                    {
                        decimal x;
                        decimal y;
                        decimal time;
                        decimal xmin = 50000;
                        decimal xmax = -50000;
                        decimal ymin = 50000;
                        decimal ymax = -50000;
                        decimal bpm = 60000 / decimal.Parse(BPM.Text);
                        string output = "osu file format v14\n\n[General]\nAudioFilename: " + id + ".mp3\nAudioLeadIn: 0\nPreviewTime: -1\nCountdown: 1\nSampleSet: None\nStackLeniency: 0.7\nMode: 0\nLetterboxInBreaks: 0\nWidescreenStoryboard: 0\n\n[Editor]\nDistanceSpacing: 1.2\nBeatDivisor: 4\nGridSize: 32\nTimelineZoom: 1\n\n[Metadata]\nTitle:" + title + "\nTitleUnicode:" + title + "\nArtist:" + author + "\nArtistUnicode:" + author + "\nCreator:_\nVersion:_\nSource: \nTags: \nBeatmapID:0\nBeatmapSetID:-1\n\n[Difficulty]\nHPDrainRate:5\nCircleSize:5\nOverallDifficulty:1\nApproachRate:10\nSliderMultiplier:1.4\nSliderTickRate:1\n\n[Events]\n//Background and Video events\n//Break Periods\n//Storyboard Layer 0 (Background)\n//Storyboard Layer 1 (Fail)\n//Storyboard Layer 2 (Pass)\n//Storyboard Layer 3 (Foreground)\n//Storyboard Layer 4 (Overlay)\n//Storyboard Sound Samples\n\n[TimingPoints]\n0," + bpm + ",4,2,0,100,1,0\n\n\n[HitObjects]";
                        data = data.Replace(id + ",", "");
                        string[] newdata = data.Split(',');
                        if (SSGuides.Checked == false)
                        {
                            foreach (var line in newdata)
                            {
                                var lineSplit = Regex.Matches(line, "([^|]+)");
                                x = decimal.Parse(lineSplit[0].Value);
                                y = decimal.Parse(lineSplit[1].Value);
                                if (x < xmin)
                                {
                                    xmin = x;
                                }
                                else if (x > xmax)
                                {
                                    xmax = x;
                                }
                                if (y < ymin)
                                {
                                    ymin = y;
                                }
                                else if (y > ymax)
                                {
                                    ymax = y;
                                }
                            }
                            ymax -= ymin;
                            xmax -= xmin;
                            foreach (var line in newdata)
                            {
                                var lineSplit = Regex.Matches(line, "([^|]+)");
                                x = decimal.Parse(lineSplit[0].Value);
                                y = decimal.Parse(lineSplit[1].Value);
                                time = decimal.Parse(lineSplit[2].Value);
                                if (ApplyOffset.Checked == true)
                                {
                                    time += decimal.Parse(Offset.Text);
                                }
                                x = (x - xmin) * (512 / xmax);
                                y = (y - ymin) * (384 / ymax);
                                output += "\n" + x + "," + y + "," + Math.Round(time) + ",1,0,0:0:0:0:";
                            }
                        }
                        else
                        {
                            foreach (var line in newdata)
                            {
                                var lineSplit = Regex.Matches(line, "([^|]+)");
                                x = decimal.Parse(lineSplit[0].Value);
                                y = decimal.Parse(lineSplit[1].Value);
                                time = decimal.Parse(lineSplit[2].Value);
                                if (ApplyOffset.Checked == true)
                                {
                                    time += decimal.Parse(Offset.Text);
                                }
                                x = x * -64 + 320;
                                y = y * -64 + 256;
                                output += "\n" + x + "," + y + "," + Math.Round(time) + ",1,0,0:0:0:0:";
                            }
                            if (ImageDir.Text != "")
                            {
                                try
                                {
                                    string fileName = Path.GetFileName(ImageDir.Text);
                                    string destFile = Path.Combine(directoryF, fileName);
                                    string ext = Path.GetExtension(destFile);
                                    File.Copy(ImageDir.Text, destFile, true);
                                    File.Move(destFile, directoryF + "\\background" + ext);
                                    output = output.Replace("//Background and Video events", "//Background and Video events\n0,0,\"background" + ext + "\",0,0");
                                }
                                catch
                                {
                                    using (wc = new SecureWebClient())
                                    {
                                        wc.DownloadFile("https://raw.githubusercontent.com/Avibah/Sound-Space-Multi-Tool/accompanying-files/SS_OSU_Tutorial.png", directoryF + "\\background.png");
                                    }
                                    MessageBox.Show("Failed to copy selected file, downloading default tutorial image");
                                    output = output.Replace("//Background and Video events", "//Background and Video events\n0,0,\"background.png\",0,0");
                                }
                            }
                            else
                            {
                                using (wc = new SecureWebClient())
                                {
                                    wc.DownloadFile("https://raw.githubusercontent.com/Avibah/Sound-Space-Multi-Tool/accompanying-files/SS_OSU_Tutorial.png", directoryF + "\\background.png");
                                }
                                output = output.Replace("//Background and Video events", "//Background and Video events\n0,0,\"background.png\",0,0");
                            }
                        }
                        TextWriter txt = new StreamWriter(directoryF + "\\" + author + " - " + title + " (_) [_].osu");
                        txt.Write(output);
                        txt.Close();
                        
                        MessageBox.Show("Beatmap successfully created at " + directory);
                    }
                }
            }
            catch
            {
                
            }
        }

        private void ApplyOffset_CheckedChanged(object sender, EventArgs e)
        {
            Offset.Enabled = ApplyOffset.Checked;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            try
            {
                string readfile = File.ReadAllText(filename);
                Input.Text = readfile;
                if (Input.Text.Substring(0, 2) == "PK")
                {
                    MessageBox.Show("Please extract the '.zip' file before attempting to load files from it.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Input.Text = "";
                }
                else if (Input.Text.Length < 10)
                {
                    MessageBox.Show("No valid file was selected for loading.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Input.Text = "";
                }
            }
            catch
            {
                Input.Text = "";
            }
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            Input.Text = Clipboard.GetText();
        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg|All Files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            try
            {
                ImageDir.Text = filename;
            }
            catch
            {
                
            }
        }

        private void OpenDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory());
        }
    }
    class SecureWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            HttpWebRequest request = base.GetWebRequest(address) as HttpWebRequest;
            request.UserAgent = "RobloxProxy";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            return request;
        }
    }
}
