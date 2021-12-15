using System;
using System.Windows.Forms;
using System.IO;

namespace SS_Multi_Tool
{
    public partial class OSU_Timings_Converter : Form
    {
        public OSU_Timings_Converter()
        {
            InitializeComponent();
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
                int rep;
                string reps;
                decimal time;
                decimal bpm;
                string output = "";
                if (data.Contains("TimingPoints") == true)
                {
                    rep = data.IndexOf("TimingPoints");
                    reps = data.Substring(0, rep + 13);
                    data = data.Replace(reps, "");
                    rep = data.IndexOf("[");
                    data = data.Substring(0, rep);
                }
                string[] newdata = data.Split('\n');
                foreach (var line in newdata)
                {
                    if (line != "")
                    {
                        rep = line.IndexOf(",");
                        reps = line.Substring(0, rep);
                        if (international == true)
                        {
                            reps = reps.Replace(".", ",");
                        }
                        time = decimal.Parse(reps);
                        reps = line.Remove(0, reps.Length + 1);
                        rep = reps.IndexOf(",");
                        if (international == true)
                        {
                            bpm = Math.Round(60000 / decimal.Parse(reps.Substring(0, rep).Replace(".", ",")), 2);
                        }
                        else
                        {
                            bpm = Math.Round(60000 / decimal.Parse(reps.Substring(0, rep)), 2);
                        }
                        if (bpm > 0)
                        {
                            if (output == "")
                            {
                                output = time.ToString().Replace(",", ".") + " | " + bpm.ToString().Replace(",", ".");
                            }
                            else
                            {
                                output += "\n" + (time + decimal.Parse(Offset.Text)).ToString().Replace(",", ".") + " | " + bpm.ToString().Replace(",", ".");
                            }
                        }
                    }
                }
                Output.Text = output;
            }
            catch
            {

            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Osu Beatmap (*.osu)|*.osu|All Files (*.*)|*.*";
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
    }
}
