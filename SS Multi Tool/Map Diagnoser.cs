using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;


namespace SS_Multi_Tool
{
    public partial class Map_Diagnoser : Form
    {
        public Map_Diagnoser()
        {
            InitializeComponent();
        }

        public static bool CheckBH(string[] data)
        {
            bool bhmap = false;
            bool negative = false;
            bool lanes = true;
            bool lowersecondtime = false;
            bool lowerdigits = true;
            decimal x;
            decimal y;
            decimal time;
            decimal? firsttime = null;
            int firstdigits = 0;
            foreach (var line in data)
            {
                var lineSplit = Regex.Matches(line, "([^|]+)");
                x = decimal.Parse(lineSplit[0].Value);
                y = decimal.Parse(lineSplit[1].Value);
                time = decimal.Parse(lineSplit[2].Value);
                int digits = (int)Math.Floor(Math.Log10(Math.Abs((double)time)) + 1);
                if (time < 0)
                {
                    negative = true;
                }
                if (y < -1 || y > 1 || !int.TryParse(y.ToString(), out _))
                {
                    lanes = false;
                }
                if (firsttime != null && firsttime > time)
                {
                    lowersecondtime = true;
                }
                else if (firsttime == null)
                {
                    firsttime = time;
                    firstdigits = digits;
                }
                if (digits > firstdigits)
                {
                    lowerdigits = false;
                }
            }
            if (negative == true && lanes == true && lowersecondtime == true && lowerdigits == true)
            {
                bhmap = true;
            }
            return bhmap;
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

        private void Diagnose_Click(object sender, EventArgs e)
        {
            try
            {
                bool charlim = false;
                bool highcharlim = false;
                bool fiveklim = false;
                bool tenklim = false;
                bool faroffgrid = false;
                List<decimal> offgridtimes = new List<decimal>();
                bool earlynote = false;
                bool latenote = false;
                bool audioerror = false;
                bool link = false;
                bool nestedlink = false;

                string data = Input.Text;
                int linkcount = 0;
                SecureWebClient wc = new SecureWebClient();
                try
                {
                    while (true)
                    {
                        data = wc.DownloadString(data);
                        linkcount += 1;
                    }
                }
                catch
                {

                }

                if (linkcount > 1)
                {
                    nestedlink = true;
                    link = true;
                }
                else if (linkcount == 1)
                {
                    link = true;
                }

                if (data.Length > 16384)
                {
                    charlim = true;
                }

                if (data.Length > 200000)
                {
                    highcharlim = true;
                }

                string audioID = data.Substring(0, data.IndexOf(","));
                data = data.Replace(audioID + ",", "");
                string[] newdata = data.Split(',');
                List<string> finaldata = new List<string>();
                bool BH = CheckBH(newdata);
                if (BH)
                {
                    long num = 0L;
                    long num2 = 0L;
                    foreach (var line in newdata)
                    {
                        var lineSplit = Regex.Matches(line, "([^|]+)");
                        float num3 = float.Parse(lineSplit[0].Value);
                        float num4 = float.Parse(lineSplit[1].Value);
                        long num5 = long.Parse(lineSplit[2].Value);
                        long num6;
                        if (num == 0L)
                        {
                            num2 = num5;
                            num6 = num5;
                        }
                        else
                        {
                            num6 = num2 + num5;
                            if (num6 != num2)
                            {
                                num2 = num6;
                            }
                        }
                        num += num6;
                        num5 = num;
                        finaldata.Add(num3 + "|" + num4 + "|" + num5);
                    }
                }
                else
                {
                    finaldata = newdata.ToList();
                }

                if (!BH)
                {
                    if (newdata.Length > 5000)
                    {
                        fiveklim = true;
                    }
                    if (newdata.Length > 10000)
                    {
                        tenklim = true;
                    }
                }

                decimal x;
                decimal y;
                decimal time;
                int i = 0;
                string output = "";

                string directory = Directory.GetCurrentDirectory();
                try
                {
                    string dir = directory + "\\" + audioID + ".mp3";
                    if (!File.Exists(dir))
                    {
                        using (wc = new SecureWebClient())
                        {
                            wc.DownloadFile("https://assetdelivery.roblox.com/v1/asset/?id=" + audioID, dir);
                            File.Delete(dir);
                        }
                    }
                }
                catch
                {
                    audioerror = true;
                }

                foreach (var line in finaldata)
                {
                    var lineSplit = Regex.Matches(line, "([^|]+)");
                    x = decimal.Parse(lineSplit[0].Value);
                    y = decimal.Parse(lineSplit[1].Value);
                    time = decimal.Parse(lineSplit[2].Value);

                    if (BH)
                    {
                        if (x < 0 || x > 4)
                        {
                            faroffgrid = true;
                            offgridtimes.Add(time);
                        }
                    }
                    else
                    {
                        if (x < decimal.Parse("-0.875") || x > decimal.Parse("2.875") || y < decimal.Parse("-0.875") || y > decimal.Parse("2.875"))
                        {
                            faroffgrid = true;
                            offgridtimes.Add(time);
                        }
                    }
                    if (time < 0)
                    {
                        earlynote = true;
                    }
                    if (i + 1 == newdata.Length)
                    {
                        var lineSplit2 = Regex.Matches(finaldata[i - 1], "([^|]+)");
                        decimal time2 = decimal.Parse(lineSplit2[2].Value);
                        if (time > decimal.Parse("1.5") * time2)
                        {
                            latenote = true;
                        }
                    }

                    i += 1;
                }

                if (audioerror)
                {
                    output += "\n\nUnable to download sound data, check if the audio was taken down";
                }
                if (charlim && !link)
                {
                    output += "\n\nFile is over text box character limit, use gist.github.com to create a gist to use";
                }
                if (nestedlink)
                {
                    output += "\n\nThe link provided redirects to a second link, which is currently not supported ingame.";
                }
                if (fiveklim)
                {
                    output += "\n\nFile is over 5 thousand notes, trim it down to 5 thousand if you don't own the 'Not Enough Notes' gamepass";
                }
                if (tenklim)
                {
                    output += "\n\nFile is over 10 thousand notes, trim it down to 10 thousand";
                }
                if (earlynote)
                {
                    output += "\n\nA note is placed before the song begins";
                }
                if (latenote)
                {
                    output += "\n\nA note may be after the song ends, check this in the editor before continuing";
                }
                if (highcharlim)
                {
                    output += "\n\nFile is over the string limit for maps, the limit for strings is 200,000 characters";
                }
                if (faroffgrid)
                {
                    output += "\n\nOne or more notes are outside the offgrid borders, fix the offgrid distance of the notes at the timestamps listed below.";
                    if (BH)
                    {
                        output += " The offgrid borders for Beat Hop are 0 and 4.\n";
                    }
                    else
                    {
                        output += " The offgrid borders for Sound Space are -0.875 and 2.875.\n";
                    }
                    foreach (var line in offgridtimes)
                    {
                        output += "\n" + line;
                    }
                }
                if (output.Length > 2)
                {
                    Output.Text = output.Substring(2, output.Length - 2);
                }
                else
                {
                    Output.Text = "No explicit errors were detected in the map. Check if there are notes after the end of the song and whether the audio is still available on the site.";
                }
                MessageBox.Show("Check the output box for steps in fixing map data. Some may not always apply to the map.\n\nCheck whether there are notes after the end of the song.\n\nIf none of the following steps solve the problem, check whether the audio was bypassed, as ROBLOX may stop audios from playing ingame but not take them off the website.");
            }
            catch
            {

            }
        }
    }
}
