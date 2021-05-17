using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace SS_Multi_Tool
{
    public partial class BS_SS_Converter : Form
    {
        public BS_SS_Converter()
        {
            InitializeComponent();
        }

        private void OpenBeatmap_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            try
            {
                string readfile = File.ReadAllText(filename);
                Beatmap.Text = readfile;
                if (Beatmap.Text.Substring(0, 2) == "PK")
                {
                    MessageBox.Show("Please extract the '.zip' file before attempting to load files from it.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Beatmap.Text = "";
                }
                else if (Beatmap.Text.Length < 10)
                {
                    MessageBox.Show("No valid file was selected for loading.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Beatmap.Text = "";
                }
            }
            catch
            {
                Beatmap.Text = "";
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
                InfoFile.Text = readfile;
                if (InfoFile.Text.Substring(0, 2) == "PK")
                {
                    MessageBox.Show("Please extract the '.zip' file before attempting to load files from it.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    InfoFile.Text = "";
                }
                else if (InfoFile.Text.Length < 10)
                {
                    MessageBox.Show("No valid file was selected for loading.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    InfoFile.Text = "";
                }
            }
            catch
            {
                InfoFile.Text = "";
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

        private void Copy_Click(object sender, EventArgs e)
        {
            if (Output.Text != "")
            {
                Clipboard.SetText(Output.Text);
            }
        }

        private void XOffgrid_CheckedChanged(object sender, EventArgs e)
        {
            XOffgridValue.Enabled = XOffgrid.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            AdjustValue.Enabled = Adjust.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            RandomQuantum.Enabled = Random.Checked;
        }

        private void YOffgrid_CheckedChanged(object sender, EventArgs e)
        {
            YOffgridValue.Enabled = YOffgrid.Checked;
            ZBound.Enabled = YOffgrid.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Adjust.Enabled = Playable.Checked;
            if (Playable.Checked == false)
            {
                AdjustValue.Enabled = false;
            }
            else if (Playable.Checked == true && Adjust.Checked == true)
            {
                AdjustValue.Enabled = true;
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            new ConverterInfo().Show();
        }

        private void Convert_Click(object sender, EventArgs e)
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
                string bpmt = InfoFile.Text;
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
                string data = Beatmap.Text;
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
                decimal timePrev = -50000;
                int type = 0;
                int max = 0;
                string output = AudioID.Text;
                double xLength;
                var rand = new Random();
                decimal timeAdjust = decimal.Parse(AdjustValue.Text);
                progressBar1.Value = 0;
                progressBar1.Maximum = 100;
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
                foreach (var count in newData)
                {
                    max += 1;
                }
                progressBar1.Maximum = 2 * max;
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
                    progressBar1.Value += 1;
                }
                if (xmax == 0)
                {
                    xmax = 1;
                }
                if (ymax == 0)
                {
                    ymax = 1;
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
                        if (ZBound.Checked == true)
                        {
                            y = y * (yOffgridValue + 2) / ymax;
                        }
                        else
                        {
                            y = y * (2 * yOffgridValue + 2) / ymax - yOffgridValue;
                        }
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
                                if (ZBound.Checked == true)
                                {
                                    y = y * (yOffgridValue + 2) / 2;
                                }
                                else
                                {
                                    y = y * (2 * yOffgridValue + 2) / 2 - yOffgridValue;
                                }
                            }
                        }
                        else
                        {
                            y = rand.Next(0, 2001);
                            y /= 1000;
                            if (YOffgrid.Checked == true)
                            {
                                if (ZBound.Checked == true)
                                {
                                    y = y * (yOffgridValue + 2) / 2;
                                }
                                else
                                {
                                    y = y * (2 * yOffgridValue + 2) / 2 - yOffgridValue;
                                }
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
                        if (Playable.Checked == true)
                        {
                            if (Adjust.Checked == true)
                            {
                                if (time > timePrev)
                                {
                                    output = output + "," + xf + "|" + yf + "|" + timef;
                                    timePrev = time;
                                }
                                else if (time <= timePrev)
                                {
                                    time = timePrev + timeAdjust;
                                    timef = time.ToString();
                                    output = output + "," + xf + "|" + yf + "|" + timef;
                                    timePrev = time;
                                }
                            }
                            else
                            {
                                if (time > timePrev)
                                {
                                    output = output + "," + xf + "|" + yf + "|" + timef;
                                    timePrev = time;
                                }
                            }
                        }
                        else
                        {
                            output = output + "," + xf + "|" + yf + "|" + timef;
                        }
                    }

                    progressBar1.Value += 1;
                }
                Output.Text = output;
            }
            catch
            {

            }
        }
    }
}
 