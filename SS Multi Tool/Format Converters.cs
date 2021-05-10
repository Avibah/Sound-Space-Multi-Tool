using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SS_Multi_Tool
{
    public partial class Converters : Form
    {
        public Converters()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConverterList.SelectedItem.ToString() == "SS to Beat Hop")
            {
                OpenInfo.Enabled = false;
                Info.Enabled = false;
                AudioID.Enabled = false;
                DownloadAudio.Enabled = false;
                Offset.Enabled = false;
                AudioSpeed.Enabled = false;
                SSGuides.Enabled = false;
                XOffgrid.Enabled = false;
                YOffgrid.Enabled = false;
                Random.Enabled = false;
                RandomQuantum.Enabled = false;
                YOffgridValue.Enabled = false;
                XOffgridValue.Enabled = false;
                Difficulty.Enabled = false;
                ImageDir.Enabled = false;
                Title.Enabled = false;
                Author.Enabled = false;
                SelectImage.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                Copy.Enabled = true;
                Export.Enabled = true;
                Output.Enabled = true;
                Convert.Enabled = true;
                Open.Enabled = true;
                Paste.Enabled = true;
                Input.Enabled = true;
            }
            else if (ConverterList.SelectedItem.ToString() == "SS to OSU")
            {
                OpenInfo.Enabled = false;
                Info.Enabled = false;
                AudioID.Enabled = false;
                DownloadAudio.Enabled = false;
                Offset.Enabled = true;
                AudioSpeed.Enabled = false;
                SSGuides.Enabled = true;
                XOffgrid.Enabled = false;
                YOffgrid.Enabled = false;
                Random.Enabled = false;
                RandomQuantum.Enabled = false;
                YOffgridValue.Enabled = false;
                XOffgridValue.Enabled = false;
                Difficulty.Enabled = false;
                ImageDir.Enabled = true;
                Title.Enabled = true;
                Author.Enabled = true;
                SelectImage.Enabled = true;
                label1.Enabled = false;
                label2.Enabled = true;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = true;
                label6.Enabled = true;
                Copy.Enabled = false;
                Export.Enabled = false;
                Output.Enabled = false;
                Convert.Enabled = true;
                Open.Enabled = true;
                Paste.Enabled = true;
                Input.Enabled = true;
            }
            else if (ConverterList.SelectedItem.ToString() == "OSU to SS")
            {
                OpenInfo.Enabled = false;
                Info.Enabled = false;
                AudioID.Enabled = true;
                DownloadAudio.Enabled = true;
                Offset.Enabled = true;
                AudioSpeed.Enabled = true;
                SSGuides.Enabled = true;
                XOffgrid.Enabled = false;
                YOffgrid.Enabled = false;
                Random.Enabled = false;
                RandomQuantum.Enabled = false;
                YOffgridValue.Enabled = false;
                XOffgridValue.Enabled = false;
                Difficulty.Enabled = false;
                ImageDir.Enabled = false;
                Title.Enabled = false;
                Author.Enabled = false;
                SelectImage.Enabled = false;
                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                Copy.Enabled = true;
                Export.Enabled = true;
                Output.Enabled = true;
                Convert.Enabled = true;
                Open.Enabled = true;
                Paste.Enabled = true;
                Input.Enabled = true;
            }
            else if (ConverterList.SelectedItem.ToString() == "Beat Saber to SS")
            {
                OpenInfo.Enabled = true;
                Info.Enabled = true;
                AudioID.Enabled = true;
                DownloadAudio.Enabled = true;
                Offset.Enabled = true;
                AudioSpeed.Enabled = true;
                SSGuides.Enabled = false;
                XOffgrid.Enabled = true;
                YOffgrid.Enabled = true;
                Random.Enabled = true;
                RandomQuantum.Enabled = false;
                YOffgridValue.Enabled = false;
                XOffgridValue.Enabled = false;
                Difficulty.Enabled = false;
                ImageDir.Enabled = false;
                Title.Enabled = false;
                Author.Enabled = false;
                SelectImage.Enabled = false;
                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                Copy.Enabled = true;
                Export.Enabled = true;
                Output.Enabled = true;
                Convert.Enabled = true;
                Open.Enabled = true;
                Paste.Enabled = true;
                Input.Enabled = true;
            }
            else if (ConverterList.SelectedItem.ToString() == "Clone Hero to SS")
            {
                OpenInfo.Enabled = false;
                Info.Enabled = false;
                AudioID.Enabled = true;
                DownloadAudio.Enabled = true;
                Offset.Enabled = true;
                AudioSpeed.Enabled = true;
                SSGuides.Enabled = false;
                XOffgrid.Enabled = false;
                YOffgrid.Enabled = false;
                Random.Enabled = false;
                RandomQuantum.Enabled = false;
                YOffgridValue.Enabled = false;
                XOffgridValue.Enabled = false;
                Difficulty.Enabled = true;
                ImageDir.Enabled = false;
                Title.Enabled = false;
                Author.Enabled = false;
                SelectImage.Enabled = false;
                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = false;
                label6.Enabled = false;
                Copy.Enabled = true;
                Export.Enabled = true;
                Output.Enabled = true;
                Convert.Enabled = true;
                Open.Enabled = true;
                Paste.Enabled = true;
                Input.Enabled = true;
            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            if (ConverterList.SelectedItem.ToString() == "SS to Beat Hop")
            {
                try
                {
                    bool international;
                    string num = "50,000";
                    decimal numTest = decimal.Parse(num);
                    if (numTest == 50000)
                    {
                        international = false;
                    }
                    else
                    {
                        international = true;
                    }
                    string data = Input.Text;
                    int rep = data.IndexOf(",");
                    string audioID = data.Substring(0, rep);
                    data = data.Replace(audioID + ",", "");
                    decimal x;
                    string xs;
                    decimal y;
                    string ys;
                    int timec = 0;
                    decimal location;
                    decimal time;
                    string output = audioID;
                    string[] newdata = data.Split(',');
                    List<decimal> times = new List<decimal>();
                    foreach (var line in newdata)
                    {
                        var lineSplit = Regex.Matches(line, "([^|]+)");
                        time = decimal.Parse(lineSplit[2].Value);
                        times.Add(time);
                    }
                    foreach (var line in newdata)
                    {
                        var lineSplit = Regex.Matches(line, "([^|]+)");
                        xs = lineSplit[0].Value;
                        ys = lineSplit[1].Value;
                        if (international == true)
                        {
                            xs = xs.Replace(".", ",");
                            ys = ys.Replace(".", ",");
                        }
                        x = decimal.Parse(xs);
                        y = decimal.Parse(ys);
                        time = times[timec];
                        if (timec - 1 >= 0)
                        {
                            time -= 2 * times[timec - 1];
                        }
                        if (timec - 2 >= 0)
                        {
                            time += times[timec - 2];
                        }
                        location = x + y;
                        if (location > 4)
                        {
                            location = 4;
                        }
                        else if (location < 0)
                        {
                            location = 0;
                        }
                        output += "," + location.ToString().Replace(",", ".") + "|0|" + time;
                        timec += 1;
                    }
                    Output.Text = output;
                }
                catch
                {

                }
            }
            else if (ConverterList.SelectedItem.ToString() == "SS to OSU")
            {
                try
                {
                    if (Input.Text == "" || Author.Text == "" || Title.Text == "")
                    {
                        MessageBox.Show("Please enter all required information (Title, Author, Map Data)", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        bool international;
                        string num = "50,000";
                        decimal numTest = decimal.Parse(num);
                        if (numTest == 50000)
                        {
                            international = false;
                        }
                        else
                        {
                            international = true;
                        }
                        string title = Title.Text;
                        string author = Author.Text;
                        title = title.Replace(" ", "_");
                        author = author.Replace(" ", "_");
                        string data = Input.Text;
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
                                using (var wc = new SecureWebClient())
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
                            string xs;
                            string ys;
                            decimal time;
                            decimal xmin = 50000;
                            decimal xmax = -50000;
                            decimal ymin = 50000;
                            decimal ymax = -50000;
                            string output = "osu file format v14\n\n[General]\nAudioFilename: " + id + ".mp3\nAudioLeadIn: 0\nPreviewTime: -1\nCountdown: 1\nSampleSet: None\nStackLeniency: 0.7\nMode: 0\nLetterboxInBreaks: 0\nWidescreenStoryboard: 0\n\n[Editor]\nDistanceSpacing: 1.2\nBeatDivisor: 4\nGridSize: 32\nTimelineZoom: 1\n\n[Metadata]\nTitle:" + title + "\nTitleUnicode:" + title + "\nArtist:" + author + "\nArtistUnicode:" + author + "\nCreator:_\nVersion:_\nSource: \nTags: \nBeatmapID:0\nBeatmapSetID:-1\n\n[Difficulty]\nHPDrainRate:5\nCircleSize:5\nOverallDifficulty:1\nApproachRate:10\nSliderMultiplier:1.4\nSliderTickRate:1\n\n[Events]\n//Background and Video events\n//Break Periods\n//Storyboard Layer 0 (Background)\n//Storyboard Layer 1 (Fail)\n//Storyboard Layer 2 (Pass)\n//Storyboard Layer 3 (Foreground)\n//Storyboard Layer 4 (Overlay)\n//Storyboard Sound Samples\n\n\n[HitObjects]";
                            data = data.Replace(id + ",", "");
                            string[] newdata = data.Split(',');
                            if (SSGuides.Checked == false)
                            {
                                foreach (var line in newdata)
                                {
                                    var lineSplit = Regex.Matches(line, "([^|]+)");
                                    xs = lineSplit[0].Value;
                                    ys = lineSplit[1].Value;
                                    if (international == true)
                                    {
                                        xs = xs.Replace(".", ",");
                                        ys = ys.Replace(".", ",");
                                    }
                                    x = decimal.Parse(xs);
                                    y = decimal.Parse(ys);
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
                                    xs = lineSplit[0].Value;
                                    ys = lineSplit[1].Value;
                                    if (international == true)
                                    {
                                        xs = xs.Replace(".", ",");
                                        ys = ys.Replace(".", ",");
                                        Offset.Text = Offset.Text.Replace(".", ",");
                                    }
                                    x = decimal.Parse(xs);
                                    y = decimal.Parse(ys);
                                    time = decimal.Parse(lineSplit[2].Value);
                                    time += decimal.Parse(Offset.Text);
                                    x = (x - xmin) * (512 / xmax);
                                    y = (y - ymin) * (384 / ymax);
                                    output += "\n" + x.ToString().Replace(",", ".") + "," + y.ToString().Replace(",", ".") + "," + Math.Round(time) + ",1,0,0:0:0:0:";
                                }
                            }
                            else
                            {
                                foreach (var line in newdata)
                                {
                                    var lineSplit = Regex.Matches(line, "([^|]+)");
                                    xs = lineSplit[0].Value;
                                    ys = lineSplit[1].Value;
                                    if (international == true)
                                    {
                                        xs = xs.Replace(".", ",");
                                        ys = ys.Replace(".", ",");
                                        Offset.Text = Offset.Text.Replace(".", ",");
                                    }
                                    x = decimal.Parse(xs);
                                    y = decimal.Parse(ys);
                                    time = decimal.Parse(lineSplit[2].Value);
                                    time += decimal.Parse(Offset.Text);
                                    x = x * -64 + 320;
                                    y = y * -64 + 256;
                                    output += "\n" + x.ToString().Replace(",", ".") + "," + y.ToString().Replace(",", ".") + "," + Math.Round(time) + ",1,0,0:0:0:0:";
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
                                        using (var wc = new SecureWebClient())
                                        {
                                            wc.DownloadFile("https://raw.githubusercontent.com/Avibah/Sound-Space-Multi-Tool/main/SS_OSU_Tutorial.png", directoryF + "\\background.png");
                                        }
                                        MessageBox.Show("Failed to copy selected file, downloading default tutorial image");
                                        output = output.Replace("//Background and Video events", "//Background and Video events\n0,0,\"background.png\",0,0");
                                    }
                                }
                                else
                                {
                                    using (var wc = new SecureWebClient())
                                    {
                                        wc.DownloadFile("https://raw.githubusercontent.com/Avibah/Sound-Space-Multi-Tool/main/SS_OSU_Tutorial.png", directoryF + "\\background.png");
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
            else if (ConverterList.SelectedItem.ToString() == "OSU to SS")
            {
                if (AudioID.Text == "")
                {
                    MessageBox.Show("Please enter an audio ID into its designated text box.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool regionCheck;
                    string num = "50,000";
                    decimal numTest = decimal.Parse(num);
                    if (numTest == 50000)
                    {
                        regionCheck = false;
                    }
                    else
                    {
                        regionCheck = true;
                    }
                    try
                    {
                        string data = Input.Text;
                        decimal multiplier = decimal.Parse(AudioSpeed.Text);
                        decimal offset = decimal.Parse(Offset.Text);
                        int rep;
                        string reps;
                        if (data.Contains("HitObjects"))
                        {
                            rep = data.IndexOf("HitObjects");
                            reps = data.Substring(0, rep);
                            data = data.Replace(reps, "");
                            data = data.Replace("HitObjects]", "");
                            data = data.Substring(1, data.Length - 1);
                        }
                        string final;
                        string xs;
                        string xf;
                        decimal x;
                        string ys;
                        string yf;
                        decimal y;
                        string time;
                        decimal timed;
                        string timef;
                        decimal xmin = 5000;
                        decimal xmax = -2000;
                        decimal ymax = -2000;
                        decimal ymin = 5000;
                        var rand = new Random();
                        string[] newData = data.Split('\n');
                        final = AudioID.Text;
                        if (regionCheck == true)
                        {
                            YOffgridValue.Text = YOffgridValue.Text.Replace(".", ",");
                            XOffgridValue.Text = XOffgridValue.Text.Replace(".", ",");
                        }
                        /*
                        if (decimal.Parse(XOffgridValue.Text) > decimal.Divide(85, 100))
                        {
                            XOffgridValue.Text = "0.85";
                        }
                        if (decimal.Parse(YOffgridValue.Text) > decimal.Divide(85, 100))
                        {
                            YOffgridValue.Text = "0.85";
                        }
                        //*/
                        if (regionCheck == true)
                        {
                            YOffgridValue.Text = YOffgridValue.Text.Replace(".", ",");
                            XOffgridValue.Text = XOffgridValue.Text.Replace(".", ",");
                        }
                        if (SSGuides.Checked == true)
                        {
                            foreach (var line2 in newData)
                            {
                                if (line2 != "")
                                {
                                    rep = line2.IndexOf(',');
                                    xs = line2.Substring(0, rep);
                                    ys = line2.Remove(0, xs.Length).Insert(0, "");
                                    ys = ys.Substring(1, ys.Length - 1);
                                    rep = ys.IndexOf(',');
                                    ys = ys.Substring(0, rep);
                                    time = line2.Remove(0, xs.Length).Insert(0, "");
                                    time = time.Substring(1, time.Length - 1);
                                    time = time.Remove(0, ys.Length).Insert(0, "");
                                    time = time.Substring(1, time.Length - 1);
                                    rep = time.IndexOf(',');
                                    time = time.Substring(0, rep);
                                    timed = (decimal.Parse(time) / multiplier) + offset;
                                    timed = Math.Round(timed);
                                    timef = timed.ToString();
                                    x = decimal.Parse(xs);
                                    x = (x - 320) * -1 / 64;
                                    y = decimal.Parse(ys);
                                    y = (y - 256) * -1 / 64;
                                    /*
                                    if (x < decimal.Divide(-85, 100))
                                    {
                                        x = decimal.Divide(-85, 100);
                                    }
                                    else if (x > decimal.Divide(285, 100))
                                    {
                                        x = decimal.Divide(285, 100);
                                    }
                                    if (y < decimal.Divide(-85, 100))
                                    {
                                        y = decimal.Divide(-85, 100);
                                    }
                                    else if (y > decimal.Divide(285, 100))
                                    {
                                        y = decimal.Divide(285, 100);
                                    }
                                    //*/
                                    x = Math.Round(x, 2);
                                    y = Math.Round(y, 2);
                                    xf = x.ToString();
                                    yf = y.ToString();
                                    if (regionCheck == true)
                                    {
                                        xf = xf.Replace(",", ".");
                                        yf = yf.Replace(",", ".");
                                    }
                                    final += "," + xf + "|" + yf + "|" + timef;
                                }
                            }
                        }
                        else
                        {
                            foreach (var line1 in newData)
                            {
                                if (line1 != "")
                                {
                                    rep = line1.IndexOf(',');
                                    xs = line1.Substring(0, rep);
                                    ys = line1.Remove(0, xs.Length).Insert(0, "");
                                    ys = ys.Substring(1, ys.Length - 1);
                                    rep = ys.IndexOf(',');
                                    ys = ys.Substring(0, rep);
                                    x = decimal.Parse(xs);
                                    y = decimal.Parse(ys);
                                    if (x > xmax)
                                    {
                                        xmax = x;
                                        xmax = Math.Round(xmax);
                                    }
                                    if (x < xmin)
                                    {
                                        xmin = x;
                                        xmin = Math.Round(xmin);
                                    }
                                    if (y > ymax)
                                    {
                                        ymax = y;
                                        ymax = Math.Round(ymax);
                                    }
                                    if (y < ymin)
                                    {
                                        ymin = y;
                                        ymin = Math.Round(ymin);
                                    }
                                }
                            }
                            ymax -= ymin;
                            xmax -= xmin;
                            foreach (var line2 in newData)
                            {
                                if (line2 != "")
                                {
                                    rep = line2.IndexOf(',');
                                    xs = line2.Substring(0, rep);
                                    ys = line2.Remove(0, xs.Length).Insert(0, "");
                                    ys = ys.Substring(1, ys.Length - 1);
                                    rep = ys.IndexOf(',');
                                    ys = ys.Substring(0, rep);
                                    time = line2.Remove(0, xs.Length).Insert(0, "");
                                    time = time.Substring(1, time.Length - 1);
                                    time = time.Remove(0, ys.Length).Insert(0, "");
                                    time = time.Substring(1, time.Length - 1);
                                    rep = time.IndexOf(',');
                                    time = time.Substring(0, rep);
                                    x = decimal.Parse(xs);
                                    y = decimal.Parse(ys);
                                    x -= xmin;
                                    y -= ymin;
                                    x = x * -1 + xmax;
                                    y = y * -1 + ymax;
                                    if (XOffgrid.Checked == true)
                                    {
                                        x = (x * ((2 * decimal.Parse(XOffgridValue.Text)) + 2) / xmax) - decimal.Parse(XOffgridValue.Text);
                                    }
                                    else
                                    {
                                        x = x * 2 / xmax;
                                    }
                                    if (YOffgrid.Checked == true)
                                    {
                                        if (XOffgrid.Checked == true)
                                        {
                                            y = y * (decimal.Parse(YOffgridValue.Text) + 2) / ymax;
                                        }
                                        else
                                        {
                                            y = (y * ((2 * decimal.Parse(YOffgridValue.Text)) + 2) / ymax) - decimal.Parse(YOffgridValue.Text);
                                        }
                                    }
                                    else
                                    {
                                        y = y * 2 / ymax;
                                    }
                                    timed = (decimal.Parse(time) / multiplier) + offset;
                                    timed = Math.Round(timed);
                                    timef = timed.ToString();
                                    if (Random.Checked == true)
                                    {
                                        if (RandomQuantum.Checked == false)
                                        {
                                            x = rand.Next(0, 3);
                                            if (XOffgrid.Checked == true)
                                            {
                                                x = (x * ((2 * decimal.Parse(XOffgridValue.Text) + 2) / 2)) - decimal.Parse(XOffgridValue.Text);
                                            }
                                            y = rand.Next(0, 3);
                                            if (YOffgrid.Checked == true)
                                            {
                                                if (XOffgrid.Checked == true)
                                                {
                                                    y = y * (decimal.Parse(YOffgridValue.Text) + 2) / 2;
                                                }
                                                else
                                                {
                                                    y = (y * ((2 * decimal.Parse(YOffgridValue.Text)) + 2) / 2) - decimal.Parse(YOffgridValue.Text);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            x = rand.Next(0, 2001);
                                            x = decimal.Divide(x, 1000);
                                            if (XOffgrid.Checked == true)
                                            {
                                                x = x * (2 * decimal.Parse(XOffgridValue.Text) + 2) / 2 - decimal.Parse(XOffgridValue.Text);
                                            }
                                            y = rand.Next(0, 2001);
                                            y = decimal.Divide(y, 1000);
                                            if (YOffgrid.Checked == true)
                                            {
                                                y = (y * ((2 * decimal.Parse(YOffgridValue.Text)) + 2) / 2) - decimal.Parse(YOffgridValue.Text);
                                            }
                                        }
                                    }
                                    x = Math.Round(x, 2);
                                    y = Math.Round(y, 2);
                                    xf = x.ToString();
                                    yf = y.ToString();
                                    if (regionCheck == true)
                                    {
                                        xf = xf.Replace(",", ".");
                                        yf = yf.Replace(",", ".");
                                    }
                                    final += "," + xf + "|" + yf + "|" + timef;
                                }
                            }
                        }
                        Output.Text = final;
                    }
                    catch
                    {
                        MessageBox.Show("An error has ocurred while trying to parse the data. Check if all files are properly loaded.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (ConverterList.SelectedItem.ToString() == "Beat Saber to SS")
            {
                bool regionCheck;
                string result = "50,000";
                double resultTest = double.Parse(result);
                if (resultTest == 50000)
                {
                    regionCheck = false;
                }
                else
                {
                    regionCheck = true;
                }
                double xOffgridValue = 0.5;
                double yOffgridValue = 0.5;
                /*
                if (decimal.Parse(XOffgridValue.Text) > decimal.Divide(85, 100))
                {
                    XOffgridValue.Text = "0.85";
                }
                if (decimal.Parse(YOffgridValue.Text) > decimal.Divide(85, 100))
                {
                    YOffgridValue.Text = "0.85";
                }
                //*/
                if (XOffgrid.Checked == true)
                {
                    try
                    {
                        xOffgridValue = Double.Parse(XOffgridValue.Text);
                    }
                    catch
                    {
                        XOffgridValue.Text = "0.5";
                    }
                }
                if (YOffgrid.Checked == true)
                {
                    try
                    {
                        yOffgridValue = Double.Parse(YOffgridValue.Text);
                    }
                    catch
                    {
                        YOffgridValue.Text = "0.5";
                    }
                }
                try
                {
                    string bpmt = Info.Text;
                    int rep = bpmt.IndexOf("Minute");
                    string reps = bpmt.Substring(0, rep);
                    string reps2 = "";
                    bpmt = bpmt.Replace(reps, "");
                    rep = bpmt.IndexOf(",");
                    bpmt = bpmt.Substring(0, rep);
                    bpmt = bpmt.Replace("Minute\":", "");
                    decimal bpm = System.Convert.ToDecimal(bpmt);
                    bpm = Decimal.Round(bpm, 1);
                    decimal offset = decimal.Parse(Offset.Text);
                    decimal multiplier = decimal.Parse(AudioSpeed.Text);
                    string data = Input.Text;
                    double x = 0;
                    double xmin = 5000;
                    double xmax = -2000;
                    bool xzero = false;
                    double ymax = -2000;
                    double ymin = 5000;
                    double y = 0;
                    decimal time = 0;
                    string xs;
                    string xf;
                    string ys;
                    string yf;
                    string timef;
                    int type = 0;
                    string output = AudioID.Text;
                    double xLength;
                    var rand = new Random();
                    rep = data.IndexOf("notes");
                    reps = data.Substring(0, rep);
                    data = data.Replace(reps, "");
                    rep = data.IndexOf("],\"_obstacles");
                    data = data.Substring(0, rep);
                    data = data.Replace("[", "");
                    data = data.Replace("\"", "");
                    data = data.Replace("notes:", "");
                    data = data.Replace("_time:", "");
                    data = data.Replace("_lineIndex:", "");
                    data = data.Replace("_lineLayer:", "");
                    data = data.Replace("_type:", "");
                    data = data.Replace("_cutDirection:", "");
                    data = Regex.Replace(data, ",[^,]+}", "");
                    data = data.Replace("{", "\n");
                    data = data.Replace(",\n", "\n");
                    data = data.Substring(1, data.Length - 1);
                    string[] newData = data.Split('\n');
                    foreach (var line1 in newData)
                    {
                        rep = line1.LastIndexOf(',');
                        reps = line1.Substring(0, rep);
                        rep = reps.LastIndexOf(',');
                        reps = reps.Substring(0, rep);
                        rep = reps.IndexOf(',');
                        reps2 = reps.Substring(0, rep);
                        reps = reps.Remove(0, reps2.Length).Insert(0, "");
                        reps = reps.Replace(",", "");
                        x = System.Convert.ToDouble(reps);
                        if (x > xmax)
                        {
                            xmax = x;
                            xmax = Math.Round(xmax);
                        }
                        if (x < xmin)
                        {
                            xmin = x;
                            xmin = Math.Round(xmin);
                        }
                        if (x == 0)
                        {
                            xzero = true;
                        }
                        rep = line1.LastIndexOf(',');
                        reps = line1.Substring(0, rep);
                        rep = reps.IndexOf(',');
                        reps2 = reps.Substring(0, rep);
                        reps = reps.Remove(0, reps2.Length).Insert(0, "");
                        reps = reps.Substring(1);
                        rep = reps.IndexOf(',');
                        reps2 = reps.Substring(0, rep);
                        reps2 = "," + reps2 + ",";
                        reps = reps.Replace(reps2, "");
                        rep = reps.IndexOf(',');
                        reps2 = reps.Substring(0, rep) + ",";
                        reps = reps.Replace(reps2, "");
                        y = System.Convert.ToDouble(reps);
                        if (y > ymax)
                        {
                            ymax = y;
                            ymax = Math.Round(ymax);
                        }
                        if (y < ymin)
                        {
                            ymin = y;
                            ymin = Math.Round(ymin);
                        }
                    }
                    xLength = xmax.ToString().Length;
                    xs = xmax.ToString();
                    xmax = Math.Round(xmax / Math.Pow(10, (xs.Length - 1)), 1);
                    xs = xmin.ToString();
                    if (xmin < 0)
                    {
                        xmin = Math.Round(xmin / Math.Pow(10, (xs.Length - 2)), 1);
                    }
                    else
                    {
                        xmin = Math.Round(xmin / Math.Pow(10, (xs.Length - 1)), 1);
                    }
                    ys = ymax.ToString();
                    ymax = Math.Round(ymax / Math.Pow(10, (ys.Length - 1)), 1);
                    ys = ymin.ToString();
                    if (ymin < 0)
                    {
                        ymin = Math.Round(ymin / Math.Pow(10, (ys.Length - 2)), 1);
                    }
                    else
                    {
                        ymin = Math.Round(ymin / Math.Pow(10, (ys.Length - 1)), 1);
                    }
                    if (xmin == 0)
                    {
                        xzero = false;
                    }
                    if (xzero == true)
                    {
                        xmax -= xmin;
                    }
                    ymax -= ymin;
                    foreach (var line2 in newData)
                    {
                        rep = line2.IndexOf(',');
                        reps = line2.Substring(0, rep);
                        if (regionCheck == true)
                        {
                            reps = reps.Replace(".", ",");
                        }
                        time = System.Convert.ToDecimal(reps);
                        time = decimal.Round((time / bpm * 60 * 1000 / multiplier) + offset);
                        timef = time.ToString();
                        rep = line2.LastIndexOf(',');
                        reps = line2.Substring(0, rep);
                        rep = reps.LastIndexOf(',');
                        reps = reps.Substring(0, rep);
                        rep = reps.IndexOf(',');
                        reps2 = reps.Substring(0, rep);
                        reps = reps.Remove(0, reps2.Length).Insert(0, "");
                        reps = reps.Replace(",", "");
                        x = System.Convert.ToDouble(reps);
                        if (x < 0)
                        {
                            x /= Math.Pow(10, x.ToString().Length - 2);
                        }
                        else
                        {
                            x /= Math.Pow(10, x.ToString().Length - 1);
                        }
                        if (xzero == false && x < 0)
                        {
                            x -= xmin;
                        }
                        if (xzero == true)
                        {
                            x -= xmin;
                        }
                        if (XOffgrid.Checked == true)
                        {
                            x = (x * ((2 * xOffgridValue) + 2) / xmax) - xOffgridValue;
                        }
                        else
                        {
                            x = x * 2 / xmax;
                        }
                        if (Random.Checked == true)
                        {
                            if (RandomQuantum.Checked == false)
                            {
                                x = rand.Next(0, 3);
                                if (XOffgrid.Checked == true)
                                {
                                    x = x * (2 * xOffgridValue + 2) / 2 - xOffgridValue;
                                }
                            }
                            else
                            {
                                x = rand.Next(0, 2001);
                                x /= 1000;
                                if (XOffgrid.Checked == true)
                                {
                                    x = x * (2 * xOffgridValue + 2) / 2 - xOffgridValue;
                                }
                            }
                        }
                        x = Math.Round(x, 2);
                        rep = line2.LastIndexOf(',');
                        reps = line2.Substring(0, rep);
                        rep = reps.IndexOf(',');
                        reps2 = reps.Substring(0, rep);
                        reps = reps.Remove(0, reps2.Length).Insert(0, "");
                        reps = reps.Substring(1);
                        rep = reps.IndexOf(',');
                        reps2 = reps.Substring(0, rep);
                        reps2 = "," + reps2 + ",";
                        reps = reps.Replace(reps2, "");
                        rep = reps.IndexOf(',');
                        reps2 = reps.Substring(0, rep) + ",";
                        reps = reps.Replace(reps2, "");
                        y = System.Convert.ToDouble(reps);
                        if (y < 0)
                        {
                            y /= Math.Pow(10, y.ToString().Length - 2);
                        }
                        else
                        {
                            y /= Math.Pow(10, y.ToString().Length - 1);
                        }

                        y -= ymin;
                        if (YOffgrid.Checked == true)
                        {
                            y = y * (2 * yOffgridValue + 2) / ymax - yOffgridValue;
                        }
                        else
                        {
                            y = y * 2 / ymax;
                        }
                        if (Random.Checked == true)
                        {
                            if (RandomQuantum.Checked == false)
                            {
                                y = rand.Next(0, 3);
                                if (YOffgrid.Checked == true)
                                {
                                    y = y * (2 * yOffgridValue + 2) / 2 - yOffgridValue;
                                }
                            }
                            else
                            {
                                y = rand.Next(0, 2001);
                                y /= 1000;
                                if (YOffgrid.Checked == true)
                                {
                                    y = y * (2 * yOffgridValue + 2) / 2 - yOffgridValue;
                                }
                            }
                        }
                        y = Math.Round(y, 2);
                        /*
                        if (x < (-85/100))
                        {
                            x = -85 / 100;
                        }
                        else if (x > (285 / 100))
                        {
                            x = 285 / 100;
                        }
                        if (y < (-85 / 100))
                        {
                            y = -85 / 100;
                        }
                        else if (y > (285 / 100))
                        {
                            y = 285 / 100;
                        }
                        //*/
                        yf = y.ToString();
                        xf = x.ToString();
                        if (regionCheck == true)
                        {
                            yf = yf.Replace(",", ".");
                            xf = xf.Replace(",", ".");
                        }
                        rep = line2.LastIndexOf(',');
                        reps = line2.Substring(0, rep);
                        reps2 = line2.Replace(reps, "");
                        reps2 = reps2.Replace(",", "");
                        type = Int32.Parse(reps2);
                        if (type != 3)
                        {
                            output = output + "," + xf + "|" + yf + "|" + timef;
                        }

                    }
                    Output.Text = output;
                }
                catch (Exception)
                {
                    MessageBox.Show("An error has ocurred while trying to parse the data. Check if all files were properly loaded.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ConverterList.SelectedItem.ToString() == "Clone Hero to SS")
            {
                if (AudioID.Text == "" || decimal.TryParse(AudioID.Text, out _) == false)
                {
                    MessageBox.Show("Please enter an audio ID into its designated text box.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Difficulty.SelectedItem == null)
                {
                    MessageBox.Show("Please select a difficulty to be converted.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        bool international;
                        string num = "50,000";
                        decimal numTest = decimal.Parse(num);
                        if (numTest == 50000)
                        {
                            international = false;
                        }
                        else
                        {
                            international = true;
                        }
                        string data = Input.Text;
                        string final = AudioID.Text;
                        decimal x = 0;
                        decimal y = 0;
                        decimal time;
                        int rep;
                        string reps;
                        string reps2;
                        decimal resolution;
                        decimal bpm;
                        decimal bpmTime;
                        decimal location;
                        decimal check;
                        decimal difference;
                        decimal diffFinal;
                        string difficulty = Difficulty.SelectedItem.ToString() + "Single";
                        int listIndex = 0;
                        var rand = new Random();
                        rep = data.IndexOf("Resolution");
                        reps = data.Substring(0, rep);
                        reps2 = data.Replace(reps, "");
                        rep = reps2.IndexOf("\n");
                        reps2 = reps2.Substring(0, rep);
                        reps2 = reps2.Replace("Resolution = ", "");
                        resolution = decimal.Parse(reps2);
                        rep = data.IndexOf("SyncTrack");
                        reps = data.Substring(0, rep);
                        reps2 = data.Replace(reps, "");
                        rep = reps2.IndexOf("}");
                        reps2 = reps2.Substring(0, rep);
                        reps2 = reps2.Replace("SyncTrack]\n{", "");
                        string[] bpmArray = reps2.Split('\n');
                        List<string> bpmList = new List<string>();
                        List<string> timeList = new List<string>();
                        List<string> msList = new List<string>();
                        foreach (var line in bpmArray)
                        {
                            if (line.Contains("B"))
                            {
                                rep = line.IndexOf(" B ");
                                reps = line.Substring(0, rep);
                                reps2 = line.Replace(reps, "");
                                reps2 = reps2.Replace(" B ", "");
                                if (international == true)
                                {
                                    reps2 = reps2.Replace(".", ",");
                                }
                                bpm = decimal.Parse(reps2);
                                bpm /= 1000;
                                bpmList.Add(bpm.ToString());
                                reps = reps.Replace(" =", "");
                                if (international == true)
                                {
                                    reps = reps.Replace(".", ",");
                                }
                                bpmTime = decimal.Parse(reps);
                                timeList.Add(bpmTime.ToString());
                            }
                        }
                        foreach (var item in timeList)
                        {
                            listIndex = timeList.IndexOf(item);
                            if (listIndex != 0)
                            {
                                difference = decimal.Parse(item) - decimal.Parse(timeList[listIndex - 1]);
                                bpm = decimal.Parse(bpmList[listIndex - 1]);
                                difference = Math.Round(1000 * (difference / (bpm * resolution / 60)), 2);
                                diffFinal = difference + decimal.Parse(msList[listIndex - 1]);
                                msList.Add(diffFinal.ToString());
                            }
                            else
                            {
                                difference = decimal.Parse(timeList[listIndex]);
                                msList.Add(timeList[listIndex]);
                            }
                        }
                        rep = data.IndexOf(difficulty);
                        reps = data.Substring(0, rep);
                        reps2 = data.Replace(reps, "");
                        rep = reps2.IndexOf("}");
                        reps2 = reps2.Substring(0, rep);
                        rep = reps2.IndexOf("]");
                        reps = reps2.Substring(0, rep);
                        reps2 = reps2.Replace(reps2 + "]\n{", "");
                        string[] newdata = reps2.Split('\n');
                        foreach (var line in newdata)
                        {
                            if (line.Contains("N"))
                            {
                                rep = line.IndexOf(" = ");
                                reps = line.Substring(0, rep);
                                time = decimal.Parse(reps);
                                rep = line.IndexOf("N");
                                reps = line.Substring(0, rep);
                                reps2 = line.Replace(reps, "");
                                reps2 = reps2.Replace("N ", "");
                                rep = reps2.IndexOf(" ");
                                reps = reps2.Substring(0, rep);
                                location = decimal.Parse(reps);
                                if (location == 0)
                                {
                                    x = 2;
                                    y = 2;
                                }
                                else if (location == 1)
                                {
                                    check = rand.Next(0, 2);
                                    if (check == 0)
                                    {
                                        x = 1;
                                        y = 2;
                                    }
                                    else
                                    {
                                        x = 2;
                                        y = 1;
                                    }
                                }
                                else if (location == 2)
                                {
                                    check = rand.Next(0, 2);
                                    if (check == 0)
                                    {
                                        x = 0;
                                        y = 2;
                                    }
                                    else
                                    {
                                        x = 2;
                                        y = 0;
                                    }
                                }
                                else if (location == 3)
                                {
                                    check = rand.Next(0, 2);
                                    if (check == 0)
                                    {
                                        x = 0;
                                        y = 1;
                                    }
                                    else
                                    {
                                        x = 1;
                                        y = 0;
                                    }
                                }
                                else if (location == 4)
                                {
                                    x = 0;
                                    y = 0;
                                }
                                else if (location == 7)
                                {
                                    x = 1;
                                    y = 1;
                                }
                                foreach (var item in timeList)
                                {
                                    if (time >= decimal.Parse(item))
                                    {
                                        listIndex = timeList.IndexOf(item);
                                    }
                                }
                                if (location != 5 && location != 6)
                                {
                                    bpm = decimal.Parse(bpmList[listIndex]);
                                    time -= decimal.Parse(timeList[listIndex]);
                                    time = Math.Round(1000 * (time / (bpm * resolution / 60)) + decimal.Parse(msList[listIndex])) / decimal.Parse(AudioSpeed.Text) + decimal.Parse(Offset.Text);
                                    final += "," + x + "|" + y + "|" + time;
                                }
                            }
                        }
                        Output.Text = final;
                    }
                    catch
                    {
                        MessageBox.Show("An error has occurred during converting. Check if the selected difficulty exists and if the chart was properly loaded.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            XOffgridValue.Enabled = XOffgrid.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            YOffgridValue.Enabled = YOffgrid.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            RandomQuantum.Enabled = Random.Checked;
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            Input.Text = Clipboard.GetText();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Title = "Save file as";
                saveFileDialog1.ShowDialog();
                TextWriter txt = new StreamWriter(saveFileDialog1.FileName);
                txt.Write(Output.Text);
                txt.Close();
                if (true)
                {
                    MessageBox.Show("The data has been successfully exported.");
                }
            }
            catch
            {

            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (Output.Text != "")
            {
                Clipboard.SetText(Output.Text);
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (ConverterList.SelectedItem.ToString() == "SS to Beat Hop" || ConverterList.SelectedItem.ToString() == "SS to OSU")
            {
                openFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            }
            else if (ConverterList.SelectedItem.ToString() == "Clone Hero to SS")
            {
                openFileDialog1.Filter = "Chart File (*.chart)|*.chart|All Files (*.*)|*.*";
            }
            else if (ConverterList.SelectedItem.ToString() == "OSU to SS")
            {
                openFileDialog1.Filter = "Osu Beatmap (*.osu)|*.osu|All Files (*.*)|*.*";
            }
            else if (ConverterList.SelectedItem.ToString() == "Beat Saber to SS")
            {
                openFileDialog1.Filter = "Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
            }
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

        private void OpenInfo_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            try
            {
                string readfile = File.ReadAllText(filename);
                Info.Text = readfile;
                if (Info.Text.Substring(0, 2) == "PK")
                {
                    MessageBox.Show("Please extract the '.zip' file before attempting to load files from it.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Info.Text = "";
                }
                else if (Info.Text.Length < 10)
                {
                    MessageBox.Show("No valid file was selected for loading.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Info.Text = "";
                }
            }
            catch
            {
                Info.Text = "";
            }
        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg|All Files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            try
            {
                YOffgridValue.Text = filename;
            }
            catch
            {

            }
        }

        private void DownloadAudio_Click(object sender, EventArgs e)
        {
            string id = AudioID.Text;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ConverterList.SelectedItem.ToString() == "OSU to SS")
            {
                XOffgrid.Enabled = !SSGuides.Checked;
                YOffgrid.Enabled = !SSGuides.Checked;
                Random.Enabled = !SSGuides.Checked;
            }
        }

        private void OpenDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory());
        }
    }
}
