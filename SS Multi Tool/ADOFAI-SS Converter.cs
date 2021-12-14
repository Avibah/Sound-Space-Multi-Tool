using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace SS_Multi_Tool
{
    public partial class ADOFAI_SS_Converter : Form
    {
        public ADOFAI_SS_Converter()
        {
            InitializeComponent();
        }

        private void Random_CheckedChanged(object sender, EventArgs e)
        {
            RandomQuantum.Enabled = Random.Checked;
        }

        private void XOffgrid_CheckedChanged(object sender, EventArgs e)
        {
            XOffgridValue.Enabled = XOffgrid.Checked;
        }

        private void YOffgrid_CheckedChanged(object sender, EventArgs e)
        {
            YOffgridValue.Enabled = YOffgrid.Checked;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "ADOFAI Beatmaps (*.adofai)|*.adofai|All Files (*.*)|*.*";
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
        public Random rand = new Random();
        public string NoteLocation(char c, double mult)
        {
            string location;
            int random = rand.Next(1, 9);
            double x = 0;
            double y = 0;
            double xoffgrid = 0;
            double yoffgrid = 0;
            if (XOffgrid.Checked)
            {
                if (double.TryParse(XOffgridValue.Text, out _))
                {
                    xoffgrid = double.Parse(XOffgridValue.Text);
                }
                else
                {
                    XOffgridValue.Text = "0.5";
                    xoffgrid = 0.5;
                }
            }
            if (YOffgrid.Checked)
            {
                if (double.TryParse(YOffgridValue.Text, out _))
                {
                    yoffgrid = double.Parse(YOffgridValue.Text);
                }
                else
                {
                    YOffgridValue.Text = "0.5";
                    yoffgrid = 0.5;
                }
            }
            switch (c)
            {
                case 'R':
                    x = 0;
                    y = 1;
                    break;
                case 'J':
                    x = 2;
                    y = 1;
                    break;
                case 'E':
                    x = 0;
                    y = 2;
                    break;
                case 'T':
                    x = 2;
                    y = 0;
                    break;
                case 'U':
                    x = 1;
                    y = 2;
                    break;
                case 'G':
                    x = 1;
                    y = 0;
                    break;
                case 'Q':
                    x = 2;
                    y = 2;
                    break;
                case 'H':
                    x = 0;
                    y = 0;
                    break;
                case 'L':
                    x = 2;
                    y = 1;
                    break;
                case 'N':
                    x = 0;
                    y = 1;
                    break;
                case 'Z':
                    x = 2;
                    y = 0;
                    break;
                case 'F':
                    x = 0;
                    y = 2;
                    break;
                case 'D':
                    x = 1;
                    y = 0;
                    break;
                case 'B':
                    x = 1;
                    y = 2;
                    break;
                case 'C':
                    x = 0;
                    y = 0;
                    break;
                case 'M':
                    x = 2;
                    y = 2;
                    break;
            }
            if (Random.Checked)
            {
                if (RandomQuantum.Checked)
                {
                    x = rand.Next(0, 2001);
                    y = rand.Next(0, 2001);
                    x /= 1000;
                    y /= 1000;
                }
                else
                {
                    x = rand.Next(0, 3);
                    y = rand.Next(0, 3);
                }
            }
            x = x * (1 + xoffgrid) - xoffgrid;
            y = y * (1 + yoffgrid) - yoffgrid;
            location = x + "|" + y + "|";
            if (random == 2 || mult == 2)
            {
                location = "1|1|";
            }
            return location;
        }

        public double Deg(char c)
        {
            double degree = 69;
            switch (c)
            {
                case 'R':
                    degree = 0;
                    break;
                case 'J':
                    degree = 30;
                    break;
                case 'E':
                    degree = 45;
                    break;
                case 'T':
                    degree = 60;
                    break;
                case 'U':
                    degree = 90;
                    break;
                case 'G':
                    degree = 120;
                    break;
                case 'Q':
                    degree = 135;
                    break;
                case 'H':
                    degree = 150;
                    break;
                case 'L':
                    degree = 180;
                    break;
                case 'N':
                    degree = 210;
                    break;
                case 'Z':
                    degree = 225;
                    break;
                case 'F':
                    degree = 240;
                    break;
                case 'D':
                    degree = 270;
                    break;
                case 'B':
                    degree = 300;
                    break;
                case 'C':
                    degree = 315;
                    break;
                case 'M':
                    degree = 330;
                    break;
                case 'x':
                    degree = 195;
                    break;
                case 'W':
                    degree = 165;
                    break;
                case 'A':
                    degree = 345;
                    break;
                case 'p':
                    degree = 15;
                    break;
                case 'q':
                    degree = 105;
                    break;
                case 'Y':
                    degree = 285;
                    break;
                case 'o':
                    degree = 75;
                    break;
                case 'V':
                    degree = 255;
                    break;
            }
            if (degree == 69 && !double.TryParse(c.ToString(), out _))
            {
                Console.WriteLine(c);
            }
            return degree;
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(AudioSpeed.Text, out _))
            {
                AudioSpeed.Text = "1";
            }
            if (AudioID.Text != "")
            {
                double audiospeed = double.Parse(AudioSpeed.Text);
                try
                {
                    string data = Input.Text;
                    string output = AudioID.Text;
                    string curbpm = data.Substring(data.IndexOf("bpm"), data.Length - data.IndexOf("bpm"));
                    string mapdata = data.Substring(data.IndexOf("pathData"), data.IndexOf(",") - data.IndexOf("pathData"));
                    mapdata = mapdata.Replace("pathData\": \"", "");
                    mapdata = mapdata.Replace("\"", "");
                    string offset = data.Substring(data.IndexOf("offset"), data.Length - data.IndexOf("offset"));
                    offset = offset.Substring(0, offset.IndexOf(","));
                    offset = offset.Replace("offset\": ", "");
                    double offsetnum = double.Parse(offset);
                    double currentbpm = double.Parse(curbpm.Substring(6, curbpm.IndexOf(",") - 6));
                    double initbpm = currentbpm;
                    data = data.Substring(data.IndexOf("\"actions\":"), data.Length - data.IndexOf("\"actions\":"));
                    data = data.Replace("\"actions\":\n", "");
                    if (data.Substring(0, 1) == "\t")
                    {
                        data = data.Substring(1, data.Length - 1);
                    }
                    data = data.Substring(2, data.Length - 2);
                    data = data.Substring(0, data.IndexOf("]\n"));
                    if (data.Substring(data.Length - 1, 1) == "\t")
                    {
                        data = data.Substring(0, data.Length - 1);
                    }
                    data = data.Substring(0, data.Length - 1);
                    string[] newdata = data.Split('\n');
                    List<int> bpmnotes = new List<int>();
                    List<int> twirlnotes = new List<int>();
                    List<double> notetimes = new List<double>();
                    List<double> bpms = new List<double>();
                    List<double> multipliers = new List<double>();
                    List<int> multiplierindexes = new List<int>();
                    for (int i = 0; i < newdata.Count(); i++)
                    {
                        string line = newdata[i];
                        if (line.Contains("SetSpeed"))
                        {
                            string liner = line.Substring(line.IndexOf(":"), line.Length - line.IndexOf(":"));
                            liner = liner.Substring(2, liner.IndexOf(',') - 2);
                            bpmnotes.Add(int.Parse(liner));
                            if (line.Contains("speedType\": \"Multiplier"))
                            {
                                string bpm = line.Substring(line.IndexOf("beatsPerMinute"), line.IndexOf("bpmMultiplier") - line.IndexOf("beatsPerMinute"));
                                bpm = bpm.Replace("beatsPerMinute\": ", "");
                                bpm = bpm.Replace(", \"", "");
                                string mult = line.Substring(line.IndexOf("bpmMultiplier"), line.Length - line.IndexOf("bpmMultiplier"));
                                mult = mult.Replace("bpmMultiplier\": ", "");
                                mult = mult.Replace(" }", "");
                                mult = mult.Replace(",", "");
                                currentbpm *= double.Parse(bpm) / 100 * double.Parse(mult);
                                bpms.Add(currentbpm);
                            }
                            else
                            {
                                string bpm = line.Substring(line.IndexOf("beatsPerMinute"), line.IndexOf("bpmMultiplier") - line.IndexOf("beatsPerMinute"));
                                bpm = bpm.Replace("beatsPerMinute\": ", "");
                                bpm = bpm.Replace(", \"", "");
                                currentbpm = double.Parse(bpm);
                                bpms.Add(currentbpm);
                            }
                        }
                        else if (line.Contains("Twirl"))
                        {
                            string liner = line.Substring(line.IndexOf(":"), line.Length - line.IndexOf(":"));
                            liner = liner.Substring(2, liner.IndexOf(',') - 2);
                            twirlnotes.Add(int.Parse(liner));
                        }
                    }
                    bool clock = true;
                    multipliers.Add((180 - Deg(mapdata[0])) / 180);
                    multiplierindexes.Add(0);
                    for (int i = 1; i < mapdata.Length; i++)
                    {
                        char prevnote = mapdata[i - 1];
                        int index = i;
                        if (prevnote != '!')
                        {
                            char nextnote = mapdata[i];
                            if (nextnote == '!')
                            {
                                index += 1;
                                nextnote = mapdata[i + 1];
                            }
                            if (twirlnotes.Contains(i))
                            {
                                clock = !clock;
                            }
                            double prevangle = Deg(prevnote) + 180;
                            if (mapdata[i] == '!')
                            {
                                prevangle -= 180;
                            }
                            if (prevangle > 360)
                            {
                                prevangle -= 360;
                            }
                            double nextangle = Deg(nextnote);
                            double angle = prevangle - nextangle;
                            if (angle <= 0)
                            {
                                angle += 360;
                            }
                            if (!clock)
                            {
                                angle = 360 - angle;
                            }
                            if (angle <= 0)
                            {
                                angle += 360;
                            }
                            angle /= 180;
                            multipliers.Add(angle);
                            multiplierindexes.Add(index);
                        }

                    }
                    double time = multipliers[0] * offsetnum;
                    double bpmd = initbpm;
                    for (int i = 0; i < multipliers.Count; i++)
                    {
                        int bpmindex = multiplierindexes[i];
                        if (bpmnotes.Contains(bpmindex))
                        {
                            bpmd = bpms[bpmnotes.IndexOf(bpmindex)];
                        }
                        if (i > 0)
                        {
                            time += 60000 / bpmd * multipliers[i] / audiospeed;
                        }
                        output += "," + NoteLocation(mapdata[bpmindex], multipliers[i]) + Math.Round(time);
                    }
                    Output.Text = output;
                }
                catch
                {

                }
            }
        }
    }
}
