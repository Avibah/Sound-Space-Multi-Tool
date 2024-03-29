﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SS_Multi_Tool
{
    public partial class Map_Randomizer : Form
    {
        public Map_Randomizer()
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

        private void Offgrid_CheckedChanged(object sender, EventArgs e)
        {
            OffgridValue.Enabled = Offgrid.Checked;
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

        private void Copy_Click(object sender, EventArgs e)
        {
            if (Output.Text != "")
            {
                Clipboard.SetText(Output.Text);
            }
        }

        private void Randomize_Click(object sender, EventArgs e)
        {
            try
            {
                Output.Text = "";
                string data = Input.Text;
                SecureWebClient wc = new SecureWebClient();
                try
                {
                    while (true)
                        data = wc.DownloadString(data);
                }
                catch { }
                decimal x;
                decimal y;
                decimal time;
                int rep;
                string reps;
                decimal offgridX = 0;
                decimal offgridY = 0;
                if (decimal.Parse(OffgridValue.Text) > decimal.Divide(85, 100))
                {
                    OffgridValue.Text = "0.85";
                }
                if (decimal.Parse(OffgridValue.Text) < 0)
                {
                    OffgridValue.Text = "0";
                }
                rep = data.IndexOf(',');
                reps = data.Substring(0, rep);
                string output = reps;
                string[] newdata;
                var rand = new Random();
                data = data.Replace(reps, "");
                data = data.Substring(1, data.Length - 1);
                newdata = data.Split(',');
                if (!CheckBH(newdata))
                {
                    foreach (var line in newdata)
                    {
                        var lineSplit = Regex.Matches(line, "([^|]+)");
                        x = decimal.Parse(lineSplit[0].Value);
                        y = decimal.Parse(lineSplit[1].Value);
                        time = decimal.Parse(lineSplit[2].Value);
                        if (Quantum.Checked == true)
                        {
                            if (KeepOffgrid.Checked == true)
                            {
                                if (x < 0)
                                {
                                    offgridX = -1 * x;
                                }
                                else if (x > 2)
                                {
                                    offgridX = x - 2;
                                }
                                else
                                {
                                    offgridX = 0;
                                }
                                if (y < 0)
                                {
                                    offgridY = -1 * y;
                                }
                                else if (y > 2)
                                {
                                    offgridY = y - 2;
                                }
                                else
                                {
                                    offgridY = 0;
                                }
                            }
                            x = rand.Next(0, 2001);
                            x = decimal.Divide(x, 1000);
                            y = rand.Next(0, 2001);
                            y = decimal.Divide(y, 1000);
                            if (Offgrid.Checked == true)
                            {
                                x = (x * ((2 * decimal.Parse(OffgridValue.Text)) + 2) / 2) - decimal.Parse(OffgridValue.Text);
                                y = (y * ((2 * decimal.Parse(OffgridValue.Text)) + 2) / 2) - decimal.Parse(OffgridValue.Text);
                            }
                            if (KeepOffgrid.Checked == true)
                            {
                                if (x >= 1 && offgridX != 0)
                                {
                                    x = 2 + offgridX;
                                }
                                else if (x < 1 && offgridX != 0)
                                {
                                    x = 0 - offgridX;
                                }
                                if (y >= 1 && offgridY != 0)
                                {
                                    y = 2 + offgridY;
                                }
                                else if (y < 1 && offgridY != 0)
                                {
                                    y = 0 - offgridY;
                                }
                            }
                            x = Math.Round(x, 2);
                            y = Math.Round(y, 2);
                        }
                        else
                        {
                            if (KeepOffgrid.Checked == true)
                            {
                                if (x < 0)
                                {
                                    offgridX = -1 * x;
                                }
                                else if (x > 2)
                                {
                                    offgridX = x - 2;
                                }
                                else
                                {
                                    offgridX = 0;
                                }
                                if (y < 0)
                                {
                                    offgridY = -1 * y;
                                }
                                else if (y > 2)
                                {
                                    offgridY = y - 2;
                                }
                                else
                                {
                                    offgridY = 0;
                                }
                            }
                            x = rand.Next(0, 3);
                            y = rand.Next(0, 3);
                            if (Offgrid.Checked == true)
                            {
                                x = (x * ((2 * decimal.Parse(OffgridValue.Text)) + 2) / 2) - decimal.Parse(OffgridValue.Text);
                                y = (y * ((2 * decimal.Parse(OffgridValue.Text)) + 2) / 2) - decimal.Parse(OffgridValue.Text);
                            }
                            if (KeepOffgrid.Checked == true)
                            {
                                if (x >= 1 && offgridX != 0)
                                {
                                    x = 2 + offgridX;
                                }
                                else if (x < 1 && offgridX != 0)
                                {
                                    x = 0 - offgridX;
                                }
                                if (y >= 1 && offgridY != 0)
                                {
                                    y = 2 + offgridY;
                                }
                                else if (y < 1 && offgridY != 0)
                                {
                                    y = 0 - offgridY;
                                }
                            }
                        }
                        output += "," + x + "|" + y + "|" + time;
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
                        if (KeepOffgrid.Checked == true)
                        {
                            if (x < 0)
                            {
                                offgridX = -1 * x;
                            }
                            else if (x > 4)
                            {
                                offgridX = x - 4;
                            }
                            else
                            {
                                offgridX = 0;
                            }
                        }
                        if (Quantum.Checked)
                        {
                            x = rand.Next(0, 4001);
                            x /= 1000;
                        }
                        else
                        {
                            x = rand.Next(0, 5);
                        }
                        if (x >= 2 && offgridX != 0)
                        {
                            x = 4 + offgridX;
                        }
                        else if (x < 2 && offgridX != 0)
                        {
                            x = 0 - offgridX;
                        }
                        if (Offgrid.Checked == true)
                        {
                            x = x * ((decimal.Parse(OffgridValue.Text) + 2) / 2) - decimal.Parse(OffgridValue.Text);
                        }
                        output += "," + x + "|" + y + "|" + time;
                    }
                }
                Output.Text = output;
            }
            catch
            {

            }
        }
    }
}
