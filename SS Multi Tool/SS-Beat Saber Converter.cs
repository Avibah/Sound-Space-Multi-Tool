using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO.Compression;
using System.Net;

namespace SS_Multi_Tool
{
    public partial class SS_Beat_Saber_Converter : Form
    {
        public SS_Beat_Saber_Converter()
        {
            InitializeComponent();
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

        private void OpenDir_Click(object sender, EventArgs e)
        {
            Process.Start(Directory.GetCurrentDirectory());
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            if (Offset.Text == "")
            {
                Offset.Text = "0";
            }
            if (Author.Text != "" && Title.Text != "" && BPM.Text != "" && Input.Text != "")
            {
                string data = Input.Text;
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
                string id = data.Substring(0, data.IndexOf(','));
                string directory = Directory.GetCurrentDirectory();
                data = data.Replace(id + ",", "");
                string[] newdata = data.Split(',');
                decimal x;
                decimal y;
                decimal x2;
                decimal y2;
                decimal time;
                int i = 1;
                decimal xmax = -50;
                decimal xmin = 50;
                decimal ymax = -50;
                decimal ymin = 50;
                int type;
                int direction = 0;
                string xyxy;
                string filename = "\\" + Author.Text + " - " + Title.Text;
                var rand = new Random();
                decimal offset = decimal.Parse(Offset.Text);
                try
                {
                    if (!Directory.Exists(directory + filename))
                    {
                        Directory.CreateDirectory(directory + filename);
                    }
                    directory += filename;
                    if (!File.Exists(directory + "\\" + id + ".egg"))
                    {
                        using (var wc = new SecureWebClient())
                        {
                            wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + id, directory + "\\" + id + ".egg");
                        }
                    }
                    if (!File.Exists(directory + "\\cover.jpg"))
                    {
                        using (var wc = new WebClient())
                        {
                            wc.DownloadFile("https://raw.githubusercontent.com/Avibah/Sound-Space-Multi-Tool/accompanying-files/cover.jpeg", directory + "\\cover.jpg");
                        }
                    }
                    try
                    {
                        decimal bpm = decimal.Parse(BPM.Text);
                        if (bpm == 0)
                        {
                            bpm = 100;
                        }
                        foreach (var line in newdata)
                        {
                            var lineSplit = Regex.Matches(line, "([^|]+)");
                            x = decimal.Parse(lineSplit[0].Value);
                            y = decimal.Parse(lineSplit[1].Value);
                            if (x > xmax)
                            {
                                xmax = x;
                            }
                            if (x < xmin)
                            {
                                xmin = x;
                            }
                            if (y > ymax)
                            {
                                ymax = y;
                            }
                            if (y < ymin)
                            {
                                ymin = y;
                            }
                        }
                        xmax -= xmin;
                        ymax -= ymin;
                        if (xmax == 0)
                        {
                            xmax = 1;
                        }
                        if (ymax == 0)
                        {
                            ymax = 1;
                        }
                        string output = "{\"_version\":\"2.0.0\",\"_customData\":{\"_time\":0,\"_BPMChanges\":[],\"_bookmarks\":[]},\"_events\":[],\"_notes\":[";
                        foreach (var line in newdata)
                        {
                            if (i != 1)
                            {
                                output += ",";
                            }
                            var lineSplit = Regex.Matches(line, "([^|]+)");
                            x = decimal.Parse(lineSplit[0].Value);
                            y = decimal.Parse(lineSplit[1].Value);
                            time = decimal.Parse(lineSplit[2].Value);
                            if (ApplyOffset.Checked == true)
                            {
                                time += offset;
                            }
                            x -= xmin;
                            x = x * 2 / xmax;
                            y -= ymin;
                            y = y * 2 / ymax;
                            if (Directions.Checked == true)
                            {
                                if (i >= newdata.Length)
                                {
                                    xyxy = Math.Round(x).ToString() + Math.Round(y).ToString();
                                    var lineSplit2 = Regex.Matches(newdata[i - 2], "([^|]+)");
                                    x2 = decimal.Parse(lineSplit2[0].Value);
                                    y2 = decimal.Parse(lineSplit2[1].Value);
                                    xyxy += Math.Round(x2).ToString() + Math.Round(y2).ToString();
                                }
                                else
                                {
                                    xyxy = Math.Round(x).ToString() + Math.Round(y).ToString();
                                    var lineSplit2 = Regex.Matches(newdata[i], "([^|]+)");
                                    x2 = decimal.Parse(lineSplit2[0].Value);
                                    y2 = decimal.Parse(lineSplit2[1].Value);
                                    xyxy += Math.Round(x2).ToString() + Math.Round(y2).ToString();
                                }
                                switch (xyxy)
                                {
                                    case "2000":
                                    case "2010":
                                    case "2101":
                                    case "2111":
                                    case "2202":
                                    case "2212":
                                    case "1000":
                                    case "1101":
                                    case "1202":
                                        direction = 2;
                                        break;
                                    case "0001":
                                    case "0002":
                                    case "1011":
                                    case "1012":
                                    case "2021":
                                    case "2022":
                                    case "0102":
                                    case "1112":
                                    case "2122":
                                        direction = 1;
                                        break;
                                    case "0200":
                                    case "0201":
                                    case "1210":
                                    case "1211":
                                    case "2220":
                                    case "2221":
                                    case "0100":
                                    case "1110":
                                    case "2120":
                                        direction = 0;
                                        break;
                                    case "0210":
                                    case "0220":
                                    case "0211":
                                    case "0221":
                                    case "1120":
                                    case "1221":
                                    case "1220":
                                    case "0110":
                                    case "0120":
                                        direction = 5;
                                        break;
                                    case "2200":
                                    case "2201":
                                    case "2211":
                                    case "2210":
                                    case "1100":
                                    case "2100":
                                    case "2110":
                                    case "1200":
                                    case "1201":
                                        direction = 4;
                                        break;
                                    case "0010":
                                    case "0020":
                                    case "0111":
                                    case "0121":
                                    case "0212":
                                    case "0222":
                                    case "1020":
                                    case "1121":
                                    case "1222":
                                        direction = 3;
                                        break;
                                    case "0000":
                                    case "0101":
                                    case "0202":
                                    case "1010":
                                    case "1111":
                                    case "1212":
                                    case "2020":
                                    case "2121":
                                    case "2222":
                                        direction = 8;
                                        break;
                                    case "0011":
                                    case "0021":
                                    case "0012":
                                    case "0022":
                                    case "0112":
                                    case "0122":
                                    case "1021":
                                    case "1022":
                                    case "1122":
                                        direction = 7;
                                        break;
                                    case "2011":
                                    case "2001":
                                    case "2012":
                                    case "2002":
                                    case "1001":
                                    case "1002":
                                    case "1102":
                                    case "2112":
                                    case "2102":
                                        direction = 6;
                                        break;
                                }
                            }
                            else
                            {
                                direction = 8;
                            }
                            x = x * -1 + 2;
                            if (rand.Next(0,2) == 1)
                            {
                                x *= 2000;
                            }
                            else
                            {
                                x = x * 2000 + 1000;
                            }
                            if (i % 2 == 0)
                            {
                                type = 1;
                            }
                            else
                            {
                                type = 0;
                            }
                            y = y * 1000 + 1000;
                            x = Math.Round(x);
                            y = Math.Round(y);
                            time /= 60000 / bpm;
                            time = Math.Round(time, 6);
                            
                            output += "{\"_time\":" + time + ",\"_lineIndex\":" + x + ",\"_lineLayer\":" + y + ",\"_type\":" + type + ",\"_cutDirection\":" + direction + "}";
                            i += 1;
                        }
                        output += "],\"_obstacles\":[]}";
                        using (FileStream fs = File.Create(directory + "\\" + "Easy.dat"))
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(output);
                            fs.Write(info, 0, info.Length);
                        }
                        output = "{\n  \"_version\": \"2.0.0\",\n  \"_songName\": \"" + Title.Text + "\",\n  \"_songSubName\": \"\",\n  \"_songAuthorName\": \"" + Author.Text + "\",\n  \"_levelAuthorName\": \"djk\",\n  \"_beatsPerMinute\": " + BPM.Text + ",\n  \"_songTimeOffset\": 0,\n  \"_shuffle\": 0,\n  \"_shufflePeriod\": 0.5,\n  \"_previewStartTime\": 20,\n  \"_previewDuration\": 10,\n  \"_songFilename\": \"" + id + ".egg\",\n  \"_coverImageFilename\": \"cover.jpg\",\n  \"_environmentName\": \"BigMirrorEnvironment\",\n  \"_difficultyBeatmapSets\": [\n    {\n      \"_beatmapCharacteristicName\": \"Standard\",\n      \"_difficultyBeatmaps\": [\n        {\n          \"_difficulty\": \"Easy\",\n          \"_difficultyRank\": 1,\n          \"_beatmapFilename\": \"Easy.dat\",\n          \"_noteJumpMovementSpeed\": 18,\n          \"_noteJumpStartBeatOffset\": 0,\n          \"_customData\": {\n            \"_requirements\": [\n              \"Mapping Extensions\"\n            ]\n          }\n        }\n      ]\n    }\n  ]\n}";
                        using (FileStream fs = File.Create(directory + "\\" + "info.dat"))
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(output);
                            fs.Write(info, 0, info.Length);
                        }
                        string zipPath = directory.Replace(filename, "") + filename + ".zip";
                        if (File.Exists(directory.Replace(filename, "") + filename + ".zip"))
                        {
                            File.Delete(directory.Replace(filename, "") + filename + ".zip");
                        }
                        ZipFile.CreateFromDirectory(directory, zipPath);
                        Directory.Delete(directory, true);
                        MessageBox.Show("Map successfully converted!");
                    }
                    catch
                    {

                    }
                }
                catch
                {
                    MessageBox.Show("Failed to download audio with id: " + id, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Make sure to fill in every empty box with the appropriate information");
            }
            
        }
    }
}
