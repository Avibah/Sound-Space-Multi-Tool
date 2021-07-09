using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace SS_Multi_Tool
{
    public partial class Map_Quantizer : Form
    {
        public Map_Quantizer()
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

        private void Divisor_Scroll(object sender, EventArgs e)
        {
            DivisorLabel.Text = "Divisor - " + Divisor.Value;
        }

        private void Open_Click_1(object sender, EventArgs e)
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

        private void Quantize_Click(object sender, EventArgs e)
        {
            if (Input.Text != "" && BPM.Text != "")
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
                string xs;
                string ys;
                decimal time;
                decimal bpm;
                decimal? offset = null;
                decimal final = decimal.Parse(data.Replace(data.Substring(0, data.LastIndexOf("|") + 1), ""));
                decimal current = 0;
                if (international == true)
                {
                    bpm = decimal.Parse(BPM.Text.Replace(".", ","));
                }
                else
                {
                    bpm = decimal.Parse(BPM.Text);
                }
                int divisor = Divisor.Value;
                decimal interval = 60000 / bpm / divisor;
                int rep = data.IndexOf(",");
                string output = data.Substring(0, rep);
                data = data.Replace(output + ",", "");
                string[] newdata = data.Split(',');
                List<string> finaldata = new List<string>();
                List<decimal> times = new List<decimal>();
                List<decimal> timesf = new List<decimal>();
                List<string> locations = new List<string>();
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
                List<decimal> intervals = new List<decimal>();
                foreach (var line in newdata)
                {
                    var lineSplit = Regex.Matches(line, "([^|]+)");
                    Console.WriteLine(lineSplit[2].Value);
                    time = decimal.Parse(lineSplit[2].Value);
                    if (offset == null)
                    {
                        offset = time;
                    }
                }
                current += (decimal)offset;
                final += (decimal)offset;
                intervals.Add((decimal)offset);
                while (current < final)
                {
                    current += interval;
                    intervals.Add(current);
                }
                foreach (var line in newdata)
                {
                    var lineSplit = Regex.Matches(line, "([^|]+)");
                    xs = lineSplit[0].Value;
                    ys = lineSplit[1].Value;
                    time = decimal.Parse(lineSplit[2].Value);
                    time = Math.Round(intervals.Aggregate((x, y) => Math.Abs(x - time) < Math.Abs(y - time) ? x : y));
                    if (BH)
                    {
                        times.Add(time);
                        locations.Add(xs + "|" + ys + "|");
                    }
                    else
                    {
                        output += "," + xs + "|" + ys + "|" + time;
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
                        output += "," + locations[i] + timesf[i];
                    }
                }
                Output.Text = output;
            }
        }
    }
}
