using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace SS_Multi_Tool
{
    public partial class Copy_Paste_Detector : Form
    {
        public Copy_Paste_Detector()
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

        private void Paste_Click(object sender, EventArgs e)
        {
            Input.Text = Clipboard.GetText();
        }

        private void Examine_Click(object sender, EventArgs e)
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
            int rep = data.IndexOf(',');
            string reps = data.Substring(0, rep);
            data = data.Replace(reps + ",", "");
            string[] newdata = data.Split(',');
            List<string> comparison = new List<string>();
            foreach (var line in newdata)
            {
                rep = line.LastIndexOf('|');
                reps = line.Substring(0, rep);
                comparison.Add(reps);
            }

        }
    }
}
