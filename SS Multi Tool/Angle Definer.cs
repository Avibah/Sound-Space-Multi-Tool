using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace SS_Multi_Tool
{
    public partial class Angle_Definer : Form
    {
        public Angle_Definer()
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

        private void Define_Click(object sender, EventArgs e)
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
            output = "";
            double x;
            double nextx;
            double y;
            double nexty;
            double time;
            double diffx;
            double diffy;
            double angle;
            string prevloc = "";
            string[] newdata = data.Split(',');
            for (int i = 0; i < newdata.Count() - 1; i++)
            {
                var lineSplit = Regex.Matches(newdata[i], "([^|]+)");
                x = double.Parse(lineSplit[0].Value);
                x = x * -1 + 2;
                y = double.Parse(lineSplit[1].Value);
                var nextlineSplit = Regex.Matches(newdata[i + 1], "([^|]+)");
                nextx = double.Parse(nextlineSplit[0].Value);
                nextx = nextx * -1 + 2;
                nexty = double.Parse(nextlineSplit[1].Value);
                diffx = nextx - x;
                diffy = nexty - y;
                time = double.Parse(nextlineSplit[2].Value);
                if (prevloc != x + "|" + y)
                {
                    angle = Math.Round(Math.Atan2(diffy, diffx) * (180 / Math.PI), 2);
                    if (angle < 0)
                    {
                        angle += 360;
                    }
                    output += "\n" + angle + " | " + time;
                    prevloc = x + "|" + y;
                }
            }
            output = output.Substring(1, output.Length - 1);
            Output.Text = output;
        }
    }
}
