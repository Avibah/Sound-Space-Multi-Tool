using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;

namespace SS_Multi_Tool
{
    public partial class Map_Rotator : Form
    {
        public Map_Rotator()
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

        private void Rotate_Click(object sender, EventArgs e)
        {
            try
            {
                string data = Input.Text;
                if (data.Contains("https:"))
                {
                    try
                    {
                        WebClient wc = new WebClient();
                        data = wc.DownloadString(data);
                    }
                    catch
                    {
                        MessageBox.Show("Failed to download data from url");
                    }
                }
                string audioID = data.Substring(0, data.IndexOf(","));
                data = data.Replace(audioID + ",", "");
                string output = "";
                decimal x;
                decimal y;
                decimal time;
                string[] newdata = data.Split(',');
                for (int i = 0; i < iterations.Value; i++)
                {
                    output = "";
                    foreach (var line in newdata)
                    {
                        if (line != "")
                        {
                            var lineSplit = Regex.Matches(line, "([^|]+)");
                            x = decimal.Parse(lineSplit[0].Value);
                            y = decimal.Parse(lineSplit[1].Value);
                            time = decimal.Parse(lineSplit[2].Value);
                            output += "," + (2 - y) + "|" + x + "|" + time;
                        }
                    }
                    newdata = output.Split(',');
                }
                Output.Text = audioID + output;
            }
            catch
            {

            }
            
        }
    }
}
