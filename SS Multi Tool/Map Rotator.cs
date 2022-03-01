using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

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
                SecureWebClient wc = new SecureWebClient();
                try
                {
                    while (true)
                        data = wc.DownloadString(data);
                }catch { }
                string output = data.Substring(0, data.IndexOf(","));
                data = data.Replace(output + ",", "");
                double x;
                double y;
                double angle;
                double distance;
                string time;
                string[] newdata = data.Split(',');
                if (!double.TryParse(Degrees.Text, out _))
                {
                    Degrees.Text = "0";
                }
                double degrees = double.Parse(Degrees.Text);
                foreach (var line in newdata)
                {
                    if (line != "")
                    {
                        var lineSplit = Regex.Matches(line, "([^|]+)");
                        x = double.Parse(lineSplit[0].Value);
                        y = double.Parse(lineSplit[1].Value);
                        time = lineSplit[2].Value;
                        angle = Math.Atan2(y - 1, 2 - x - 1) * (180 / Math.PI);
                        if (angle < 0)
                            angle += 360;
                        distance = Math.Sqrt(Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2));
                        x = Math.Round(Math.Cos((angle + (360 - degrees) - 90) / (180 / Math.PI)) * distance + 1, 2);
                        y = Math.Round(Math.Sin((angle + (360 - degrees) - 90) / (180 / Math.PI)) * distance + 1, 2);
                        output += "," + y + "|" + x + "|" + time;
                    }
                }
                Output.Text = output;
            }
            catch
            {

            }
            
        }
    }
}
