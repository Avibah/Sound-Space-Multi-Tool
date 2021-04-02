using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Program_Launcher
{
    public partial class CH_SS_Converter : Form
    {
        public CH_SS_Converter()
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

        private void Paste_Click(object sender, EventArgs e)
        {
            Input.Text = Clipboard.GetText();
        }

        private void Convert_Click(object sender, EventArgs e)
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
                    string difficulty = Difficulty.SelectedItem.ToString();
                    if (DoubleChart.Checked == true)
                    {
                        difficulty += "Double";
                    }
                    else
                    {
                        difficulty += "Single";
                    }
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
                                time = Math.Round(1000 * (time / (bpm * resolution / 60)) + decimal.Parse(msList[listIndex]));
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
}
