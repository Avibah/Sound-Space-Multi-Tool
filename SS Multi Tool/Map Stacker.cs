using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SS_Multi_Tool
{
    public partial class Map_Stacker : Form
    {
        public Map_Stacker()
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

        private void Stack_Click(object sender, EventArgs e)
        {
            if (Spacing.Text == "")
            {
                Spacing.Text = "0";
            }
            if (int.TryParse(Spacing.Text, out _))
            {
                try
                {
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
                    string output = data.Substring(0, data.IndexOf(','));
                    data = data.Replace(output + ",", "");
                    decimal x;
                    decimal y;
                    decimal time;
                    string[] newdata = data.Split(',');
                    foreach (var line in newdata)
                    {
                        var lineSplit = Regex.Matches(line, "([^|]+)");
                        x = decimal.Parse(lineSplit[0].Value);
                        y = decimal.Parse(lineSplit[1].Value);
                        time = decimal.Parse(lineSplit[2].Value);
                        for (int i = 0; i < StackSize.Value; i++)
                        {
                            output += "," + x + "|" + y + "|" + (time + i * int.Parse(Spacing.Text));
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
}
