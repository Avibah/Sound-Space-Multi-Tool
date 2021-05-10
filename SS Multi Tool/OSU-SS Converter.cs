using System;
using System.Windows.Forms;
using System.IO;

namespace SS_Multi_Tool
{
    public partial class OSU_SS_Converter : Form
    {
        int check = 1;

        public OSU_SS_Converter()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Osu Beatmap (*.osu)|*.osu|All Files (*.*)|*.*";
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

        private void Copy_Click(object sender, EventArgs e)
        {
            if (Output.Text != "")
            {
                Clipboard.SetText(Output.Text);
            }
        }

        private void YOffgrid_CheckedChanged(object sender, EventArgs e)
        {
            ZBound.Enabled = YOffgrid.Checked;
            YOffgridValue.Enabled = YOffgrid.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            RandomQuantum.Enabled = Random.Checked;
        }

        private void XOffgrid_CheckedChanged(object sender, EventArgs e)
        {
            XOffgridValue.Enabled = XOffgrid.Checked;
        }

        private void Info_Click(object sender, EventArgs e)
        {
            new Info().Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (SSGuides.Checked == false)
            {
                if (XOffgrid.Checked == true)
                {
                    XOffgridValue.Enabled = true;
                }
                if (YOffgrid.Checked == true)
                {
                    YOffgridValue.Enabled = true;
                    ZBound.Enabled = true;
                }
                if (Random.Checked == true)
                {
                    RandomQuantum.Enabled = true;
                }
                XOffgrid.Enabled = true;
                YOffgrid.Enabled = true;
                Random.Enabled = true;
            }
            else
            {
                XOffgrid.Enabled = false;
                YOffgrid.Enabled = false;
                ZBound.Enabled = false;
                Random.Enabled = false;
                RandomQuantum.Enabled = false;
                YOffgridValue.Enabled = false;
                XOffgridValue.Enabled = false;
            }
            if (check == 1 && SSGuides.Checked == false)
            {
                MessageBox.Show("Only uncheck this box if you did not use fogsaturate's placement guides. Otherwise, re-check it.");
                check += 1;
            }
        }

        private void Convert_Click(object sender, EventArgs e)
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
                progressBar1.Value = 0;
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
                    int max = 0;
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
                        foreach (var count in newData)
                        {
                            if (count != "")
                            {
                                max += 1;
                            }
                        }
                        progressBar1.Maximum = max;
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
                                progressBar1.Value += 1;
                            }
                        }
                    }
                    else
                    {
                        foreach (var count in newData)
                        {
                            if (count != "")
                            {
                                max += 1;
                            }
                        }
                        progressBar1.Maximum = 2 * max;
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
                                progressBar1.Value += 1;
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
                                    if (ZBound.Checked == true)
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
                                            if (ZBound.Checked == true)
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
                                            if (ZBound.Checked == true)
                                            {
                                                y = y * (decimal.Parse(YOffgridValue.Text) + 2) / 2;
                                            }
                                            else
                                            {
                                                y = (y * ((2 * decimal.Parse(YOffgridValue.Text)) + 2) / 2) - decimal.Parse(YOffgridValue.Text);
                                            }
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
                                progressBar1.Value += 1;
                                final += "," + xf + "|" + yf + "|" + timef;
                            }
                        }
                    }
                    Output.Text = final;
                }
                catch
                {
                    MessageBox.Show("An error has ocurred while trying to parse the data.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void OpenDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory());
        }
    }
}
 