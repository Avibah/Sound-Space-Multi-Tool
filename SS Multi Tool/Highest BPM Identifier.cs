using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Net;

namespace SS_Multi_Tool
{
    public partial class Highest_BPM_Identifier : Form
    {
        public Highest_BPM_Identifier()
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

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                Output.Text = "";
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
                if (decimal.TryParse(SectionStart.Text, out _) == false)
                {
                    SectionStart.Text = "0";
                }
                if (decimal.TryParse(SectionEnd.Text, out _) == false)
                {
                    SectionEnd.Text = "0";
                }
                string locations;
                string locationsPrev = "7|7|";
                decimal time;
                decimal timePrev = 0;
                decimal bpm;
                decimal timeOcc = 0;
                decimal average = 0;
                int rep = data.IndexOf(',');
                string reps = data.Substring(0, rep);
                data = data.Replace(reps + ",", "");
                string reps2;
                string[] newdata = data.Split(',');
                List<string> bpms = new List<string>();
                foreach (var line in newdata)
                {
                    rep = line.LastIndexOf('|');
                    reps = line.Substring(0, rep + 1);
                    locations = reps;
                    reps2 = line.Replace(reps, "");
                    reps2 = reps2.Replace("|", "");
                    time = decimal.Parse(reps2);
                    if (SetLimits.Checked == true && time >= decimal.Parse(SectionStart.Text) && time <= decimal.Parse(SectionEnd.Text) || SetLimits.Checked == false)
                    {
                        if (locations != locationsPrev)
                        {
                            if (time > timePrev)
                            {
                                average = 0;
                                foreach (var item in bpms)
                                {
                                    average += decimal.Parse(item);
                                }
                                if (bpms.Count > 0)
                                {
                                    average /= bpms.Count;
                                }
                                bpm = Math.Round(60000 / (time - timePrev) / 4);
                                if (average - bpm <= 20 && average - bpm >= -20)
                                {
                                    bpms.Add(bpm.ToString());
                                    timeOcc = time;
                                }
                                else if (bpm > average)
                                {
                                    bpms.Clear();
                                    bpms.Add(bpm.ToString());
                                    timeOcc = time;
                                }
                                average = Math.Round(average, 2);
                                timePrev = time;
                            }
                            locationsPrev = locations;
                        }
                    }
                }
                Output.Text = timeOcc + " | " + average.ToString().Replace(",", ".");
            }
            catch
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SectionStart.Enabled = SetLimits.Checked;
            SectionEnd.Enabled = SetLimits.Checked;
        }
    }
}
