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

namespace SS_Multi_Tool
{
    public partial class Beat_Hop_SS_Converter : Form
    {
        public Beat_Hop_SS_Converter()
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

        private void Convert_Click(object sender, EventArgs e)
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
                string[] newdata = data.Split(',');
                List<string> finaldata = new List<string>();
                decimal x;
                decimal y = 0;
                decimal time;
                decimal check;
                var rand = new Random();
                long num = 0L;
                long num2 = 0L;
                foreach (var line in newdata)
                {
                    var lineSplit = Regex.Matches(line, "([^|]+)");
                    float num3 = float.Parse(lineSplit[0].Value);
                    float num4 = float.Parse(lineSplit[1].Value);
                    long num5 = long.Parse(lineSplit[2].Value);
                    long num6;
                    if (num == 0L)
                    {
                        num2 = num5;
                        num6 = num5;
                    }
                    else
                    {
                        num6 = num2 + num5;
                        if (num6 != num2)
                        {
                            num2 = num6;
                        }
                    }
                    num += num6;
                    num5 = num;
                    finaldata.Add(num3 + "|" + num4 + "|" + num5);
                }
                foreach (var line in finaldata)
                {
                    var lineSplit = Regex.Matches(line, "([^|]+)");
                    x = decimal.Parse(lineSplit[0].Value);
                    time = decimal.Parse(lineSplit[2].Value);
                    x = Math.Round(x);
                    if (x > 4)
                    {
                        x = 4;
                    }
                    if (x < 0)
                    {
                        x = 0;
                    }
                    switch (x)
                    {
                        case 0:
                            x = 0;
                            y = 0;
                            break;
                        case 1:
                            check = rand.Next(0, 2);
                            if (check == 0)
                            {
                                x = 1;
                                y = 0;
                            }
                            else
                            {
                                x = 0;
                                y = 1;
                            }
                            break;
                        case 2:
                            check = rand.Next(0, 3);
                            if (check == 0)
                            {
                                x = 2;
                                y = 0;
                            }
                            else if (check == 1)
                            {
                                x = 1;
                                y = 1;
                            }
                            else
                            {
                                x = 0;
                                y = 2;
                            }
                            break;
                        case 3:
                            check = rand.Next(0, 2);
                            if (check == 0)
                            {
                                x = 2;
                                y = 1;
                            }
                            else
                            {
                                x = 1;
                                y = 2;
                            }
                            break;
                        case 4:
                            x = 2;
                            y = 2;
                            break;
                    }
                    output += "," + x + "|" + y + "|" + time;
                }
                Output.Text = output;
            }
            catch
            {

            }
        }
    }
}
