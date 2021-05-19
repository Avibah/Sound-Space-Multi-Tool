using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SS_Multi_Tool
{
    public partial class Axis_Offsetter : Form
    {
        public Axis_Offsetter()
        {
            InitializeComponent();
        }

        private void OffsetXAmount_Scroll(object sender, EventArgs e)
        {
            OffsetXBox.Text = (decimal.Parse(OffsetXAmount.Value.ToString()) / -5).ToString();
        }

        private void OffsetYAmount_Scroll(object sender, EventArgs e)
        {
            OffsetYBox.Text = (decimal.Parse(OffsetYAmount.Value.ToString()) / -5).ToString();
        }

        private void Offset_Click(object sender, EventArgs e)
        {
            try
            {
                string data = Input.Text;
                if (data.Contains("https:"))
                {
                    try
                    {
                        SecureWebClient wc = new SecureWebClient();
                        data = wc.DownloadString(data);
                    }
                    catch
                    {
                        MessageBox.Show("Failed to download data from url");
                    }
                }
                string output = data.Substring(0, data.IndexOf(','));
                if (decimal.TryParse(OffsetXBox.Text, out _) == false)
                {
                    OffsetXBox.Text = "0";
                }
                if (decimal.TryParse(OffsetYBox.Text, out _) == false)
                {
                    OffsetYBox.Text = "0";
                }
                decimal xos = decimal.Parse(OffsetXBox.Text);
                decimal yos = decimal.Parse(OffsetYBox.Text);
                data = data.Replace(output + ",", "");
                string[] newdata = data.Split(',');
                decimal x;
                decimal y;
                decimal time;
                foreach (var line in newdata)
                {
                    var lineSplit = Regex.Matches(line, "([^|]+)");
                    x = decimal.Parse(lineSplit[0].Value);
                    y = decimal.Parse(lineSplit[1].Value);
                    time = decimal.Parse(lineSplit[2].Value);
                    x += xos;
                    y += yos;
                    output += "," + x + "|" + y + "|" + time;
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

        private void Copy_Click(object sender, EventArgs e)
        {
            if (Output.Text != "")
            {
                Clipboard.SetText(Output.Text);
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
                MessageBox.Show("The data has been successfully exported.");
            }
            catch
            {

            }
        }
    }
}
