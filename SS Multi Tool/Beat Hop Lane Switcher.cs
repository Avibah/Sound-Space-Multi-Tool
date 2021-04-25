using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace SS_Multi_Tool
{
    public partial class Beat_Hop_Lane_Switcher : Form
    {
        public Beat_Hop_Lane_Switcher()
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

        private void Convert_Click(object sender, EventArgs e)
        {
            try
            {
                string data = Input.Text;
                int rep = data.IndexOf(",");
                string audioID = data.Substring(0, rep);
                data = data.Replace(audioID + ",", "");
                decimal x;
                decimal y;
                decimal time;
                string output = audioID;
                string[] newdata = data.Split(',');
                foreach (var line in newdata)
                {
                    var lineSplit = Regex.Matches(line, "([^|]+)");
                    x = decimal.Parse(lineSplit[0].Value);
                    time = decimal.Parse(lineSplit[2].Value);
                    y = decimal.Parse(lane.Value.ToString());
                    output += "," + x + "|" + y + "|" + time;
                }
                Output.Text = output;
            }
            catch
            {

            }
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            Input.Text = Clipboard.GetText();
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
    }
}
