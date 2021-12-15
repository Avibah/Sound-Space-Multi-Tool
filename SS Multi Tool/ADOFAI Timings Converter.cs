using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace SS_Multi_Tool
{
    public partial class ADOFAI_Timings_Converter : Form
    {
        public ADOFAI_Timings_Converter()
        {
            InitializeComponent();
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

        private void Convert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(Offset.Text, out _))
                {
                    Offset.Text = "0";
                }
                string data = Input.Text;
                string output = "";
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
                            string mult = line.Substring(line.IndexOf("bpmMultiplier"), line.Length - line.IndexOf("bpmMultiplier"));
                            mult = mult.Replace("bpmMultiplier\": ", "");
                            mult = mult.Replace(" }", "");
                            mult = mult.Replace(",", "");
                            currentbpm *= double.Parse(mult);
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
                    if (prevnote != '!')
                    {
                        char nextnote = mapdata[i];
                        if (nextnote == '!')
                        {
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
                        multiplierindexes.Add(i);
                    }
                    
                }
                double time = multipliers[0] * offsetnum;
                double bpmd = initbpm;
                double prevbpmd = initbpm;
                int prevbpmdindex = 0;
                for (int i = 0; i < multipliers.Count; i++)
                {
                    int bpmindex = multiplierindexes[i];
                    if (bpmnotes.Contains(bpmindex))
                    {
                        bpmd = bpms[bpmnotes.IndexOf(bpmindex)];
                    }
                    if (i > 0)
                    {
                        time += 60000 / bpmd * multipliers[i];
                    }
                    if (prevbpmd != bpmd && !(prevbpmd % bpmd == 0 || bpmd % prevbpmd == 0 || bpmd * multipliers[i] % prevbpmd * multipliers[prevbpmdindex] == 0 || prevbpmd * multipliers[prevbpmdindex] % bpmd * multipliers[i] == 0))
                    {
                        output += "\n" + (Math.Round(time) + double.Parse(Offset.Text)) + " | " + bpmd;
                        prevbpmd = bpmd;
                        prevbpmdindex = i;
                    }
                }
                output = output.Substring(1, output.Length - 1);
                Output.Text = output;
            }
            catch
            {
                
            }
        }
    }
}
