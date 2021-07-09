using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace SS_Multi_Tool
{
    public partial class NPS_Calculator : Form
    {
        public NPS_Calculator()
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

        private void AvgNPS_CheckedChanged(object sender, EventArgs e)
        {
            HighestNPS.Checked = !AvgNPS.Checked;
        }

        private void HighestNPS_CheckedChanged(object sender, EventArgs e)
        {
            AvgNPS.Checked = !HighestNPS.Checked;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
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
                data = data.Replace(data.Substring(0, data.IndexOf(',')), "");
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
                decimal total = 0;
                decimal time;
                decimal time2;
                decimal highest = 0;
                if (decimal.TryParse(SectionStart.Text, out _) == false)
                {
                    SectionStart.Text = "0";
                }
                if (decimal.TryParse(SectionEnd.Text, out _) == false)
                {
                    SectionEnd.Text = "0";
                }
                List<decimal> totals = new List<decimal>();
                for (int i = 1; i < finaldata.Count; i++)
                {
                    if (i > 1)
                    {
                        var lineSplit = Regex.Matches(finaldata[i], "([^|]+)");
                        time = decimal.Parse(lineSplit[2].Value);
                        var lineSplit2 = Regex.Matches(finaldata[i - 1], "([^|]+)");
                        time2 = decimal.Parse(lineSplit2[2].Value);
                        if (SetLimits.Checked == true)
                        {
                            if (time2 >= decimal.Parse(SectionStart.Text) && time <= decimal.Parse(SectionEnd.Text))
                            {
                                decimal diff = 1000 / (time - time2);
                                totals.Add(diff);
                                if (diff > highest)
                                {
                                    highest = diff;
                                }
                            }
                        }
                        else
                        {
                            if (time2 != time)
                            {
                                decimal diff = 1000 / (time - time2);
                                totals.Add(diff);
                                if (diff > highest)
                                {
                                    highest = diff;
                                }
                            }
                        }
                        
                    }
                }
                foreach (var item in totals)
                {
                    total += item;
                }
                total /= totals.Count;
                if (AvgNPS.Checked == true)
                {
                    Output.Text = Math.Round(total, 2).ToString();
                }
                else
                {
                    Output.Text = Math.Round(highest, 2).ToString();
                }
            }
            catch
            {
                Output.Text = "0";
            }
        }

        private void SetLimits_CheckedChanged(object sender, EventArgs e)
        {
            SectionEnd.Enabled = SetLimits.Checked;
            SectionStart.Enabled = SetLimits.Checked;
        }
    }
}
