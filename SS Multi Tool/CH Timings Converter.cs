using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Program_Launcher
{
    public partial class CH_OSU_Timings_Converter : Form
    {
        public CH_OSU_Timings_Converter()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Chart File (*.chart)|*.chart|All Files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            try
            {
                string readfile = File.ReadAllText(filename);
                richTextBox1.Text = readfile;
                if (richTextBox1.Text.Substring(0, 2) == "PK")
                {
                    MessageBox.Show("Please extract the '.zip' file before attempting to load files from it.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    richTextBox1.Text = "";
                }
                else if (richTextBox1.Text.Length < 10)
                {
                    MessageBox.Show("No valid file was selected for loading.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    richTextBox1.Text = "";
                }
            }
            catch
            {
                richTextBox1.Text = "";
            }
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText();
        }

        private void ConvertOSU_Click(object sender, EventArgs e)
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
                string data = richTextBox1.Text;
                richTextBox3.Text = "";
                int rep;
                string output = "";
                string reps;
                string reps2;
                decimal resolution;
                decimal bpm;
                decimal bpmTime;
                decimal difference;
                decimal diffFinal;
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
                foreach (var item in msList)
                {
                    listIndex = msList.IndexOf(item);
                    if (output != "")
                    {
                        output += "\n";
                    }
                    output += item + "," + Math.Round(60000 / decimal.Parse(bpmList[listIndex]), 3).ToString().Replace(",", ".") + ",4,1,0,100,1,0";
                }
                richTextBox3.Text = output;
            }
            catch
            {
                    
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (richTextBox3.Text != "")
            {
                Clipboard.SetText(richTextBox3.Text);
            }
        }

        private void ConvertMS_Click(object sender, EventArgs e)
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
                string data = richTextBox1.Text;
                richTextBox3.Text = "";
                int rep;
                string output = "";
                string reps;
                string reps2;
                decimal resolution;
                decimal bpm;
                decimal bpmTime;
                decimal difference;
                decimal diffFinal;
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
                foreach (var item in msList)
                {
                    listIndex = msList.IndexOf(item);
                    if (output != "")
                    {
                        output += "\n";
                    }
                    output += item.ToString().Replace(",", ".") + " | " + decimal.Parse(bpmList[listIndex]).ToString().Replace(",", ".");
                }
                richTextBox3.Text = output;
            }
            catch
            {
                    
            }
        }
    }
}
