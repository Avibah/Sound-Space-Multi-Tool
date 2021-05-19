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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            DivisorLabel.Text = "Divisor - " + (Divisor.Value);
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
                saveFileDialog1.Title = "Save file as";
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
                if (data.Contains("https:"))
                {
                    try
                    {
                        SecureWebClient wc = new SecureWebClient();
                        data = wc.DownloadString(data);
                    }
                    catch
                    {
                        MessageBox.Show("Failed to download data from url");
                    }
                }
                string xs;
                string ys;
                decimal time;
                decimal bpm;
                decimal offset = -50;
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
                List<decimal> intervals = new List<decimal>();
                foreach (var line in newdata)
                {
                    var lineSplit = Regex.Matches(line, "([^|]+)");
                    Console.WriteLine(lineSplit[2].Value);
                    time = decimal.Parse(lineSplit[2].Value);
                    if (offset == -50)
                    {
                        offset = time;
                    }
                }
                current += offset;
                final += offset;
                intervals.Add(offset);
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
                    if (offset == -50)
                    {
                        offset = time;
                    }
                    time = Math.Round(intervals.Aggregate((x, y) => Math.Abs(x - time) < Math.Abs(y - time) ? x : y));
                    output += "," + xs + "|" + ys + "|" + time.ToString().Replace(",", ".");
                }
                Output.Text = output;
            }
        }
    }
}
