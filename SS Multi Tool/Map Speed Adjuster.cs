﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace SS_Multi_Tool
{
    public partial class Map_Speed_Adjuster : Form
    {
        public Map_Speed_Adjuster()
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

        private void Copy_Click(object sender, EventArgs e)
        {
            if (Output.Text != "")
            {
                Clipboard.SetText(Output.Text);
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Title = "Save as";
                saveFileDialog1.ShowDialog();
                TextWriter txt = new StreamWriter(saveFileDialog1.FileName);
                txt.Write(Output.Text);
                txt.Close();
                MessageBox.Show("The data has been successfully exported.");
            }
            catch
            {

            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            try
            {
                bool international;
                string numint = "50,000";
                decimal numTest = decimal.Parse(numint);
                if (numTest == 50000)
                {
                    international = false;
                }
                else
                {
                    international = true;
                }
                Output.Text = "";
                if (Speed.Text == "")
                {
                    Speed.Text = "1";
                }
                if (international == true)
                {
                    Speed.Text = Speed.Text.Replace(".", ",");
                }
                string data = Input.Text;
                SecureWebClient wc = new SecureWebClient();
                try
                {
                    while (true)
                    {
                        data = wc.DownloadString(data);
                    }
                }
                catch
                {

                }
                string final;
                string locations;
                decimal time;
                int rep = data.IndexOf(',');
                string reps = data.Substring(0, rep);
                data = data.Replace(reps + ",", "");
                final = reps;
                string reps2;
                decimal offset = 0;
                string[] newdata = data.Split(',');
                List<string> finaldata = new List<string>();
                List<decimal> times = new List<decimal>();
                List<decimal> timesf = new List<decimal>();
                List<string> locationslist = new List<string>();
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
                if (LockOffset.Checked == true)
                {
                    var lineSplit = Regex.Matches(newdata[0], "([^|]+)");
                    offset = decimal.Parse(lineSplit[2].Value);
                }
                foreach (var line in finaldata)
                {
                    rep = line.LastIndexOf('|');
                    reps = line.Substring(0, rep + 1);
                    locations = reps;
                    reps2 = line.Replace(reps, "");
                    reps2 = reps2.Replace("|", "");
                    time = decimal.Parse(reps2);
                    time -= offset;
                    time /= decimal.Parse(Speed.Text);
                    time += offset;
                    time = Math.Round(time);
                    if (BH)
                    {
                        locationslist.Add(locations);
                        times.Add(time);
                    }
                    else
                    {
                        final += "," + locations + time;
                    }
                }
                if (BH)
                {
                    for (int i = 0; i < times.Count; i++)
                    {
                        time = times[i];
                        if (i >= 1)
                        {
                            time -= 2 * times[i - 1];
                        }
                        if (i >= 2)
                        {
                            time += times[i - 2];
                        }
                        timesf.Add(time);
                    }
                    for (int i = 0; i < timesf.Count; i++)
                    {
                        final += "," + locationslist[i] + timesf[i];
                    }
                }
                Output.Text = final;
            }
            catch
            {

            }
        }
    }
}
