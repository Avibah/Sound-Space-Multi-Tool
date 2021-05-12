using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SS_Multi_Tool
{
    public partial class Randomizer : Form
    {
        public Randomizer()
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            OffgridValue.Enabled = Offgrid.Checked;
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

        private void Randomize_Click(object sender, EventArgs e)
        {
            try
            {
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
                Output.Text = "";
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
                decimal x;
                decimal y;
                decimal time;
                int rep;
                string reps;
                decimal offgridX = 0;
                decimal offgridY = 0;
                if (international == true)
                {
                    OffgridValue.Text = OffgridValue.Text.Replace(".", ",");
                }
                if (decimal.Parse(OffgridValue.Text) > decimal.Divide(85, 100))
                {
                    if (international == true)
                    {
                        OffgridValue.Text = "0,85";
                    }
                    else
                    {
                        OffgridValue.Text = "0.85";
                    }
                }
                if (decimal.Parse(OffgridValue.Text) < 0)
                {
                    OffgridValue.Text = "0";
                }
                rep = data.IndexOf(',');
                reps = data.Substring(0, rep);
                string output = reps;
                foreach (char c in output)
                {
                    if (decimal.TryParse(c.ToString(), out _) != true)
                    {
                        output = output.Replace(c.ToString(), "");
                    }
                }
                string[] newdata;
                var rand = new Random();
                data = data.Replace(reps, "");
                data = data.Substring(1, data.Length - 1);
                newdata = data.Split(',');
                foreach (var line in newdata)
                {
                    var lineSplit = Regex.Matches(line, "([^|]+)");
                    x = decimal.Parse(lineSplit[0].Value);
                    y = decimal.Parse(lineSplit[1].Value);
                    time = decimal.Parse(lineSplit[2].Value);
                    if (Quantum.Checked == true)
                    {
                        if (KeepOffgrid.Checked == true)
                        {
                            if (x < 0)
                            {
                                offgridX = -1 * x;
                            }
                            else if (x > 2)
                            {
                                offgridX = x - 2;
                            }
                            else
                            {
                                offgridX = 0;
                            }
                            if (y < 0)
                            {
                                offgridY = -1 * y;
                            }
                            else if (y > 2)
                            {
                                offgridY = y - 2;
                            }
                            else
                            {
                                offgridY = 0;
                            }
                        }
                        x = rand.Next(0, 2001);
                        x = decimal.Divide(x, 1000);
                        y = rand.Next(0, 2001);
                        y = decimal.Divide(y, 1000);
                        if (Offgrid.Checked == true)
                        {
                            x = (x * ((2 * decimal.Parse(OffgridValue.Text)) + 2) / 2) - decimal.Parse(OffgridValue.Text);
                            y = (y * ((2 * decimal.Parse(OffgridValue.Text)) + 2) / 2) - decimal.Parse(OffgridValue.Text);
                        }
                        if (KeepOffgrid.Checked == true)
                        {
                            if (x >= 1 && offgridX != 0)
                            {
                                x = 2 + offgridX;
                            }
                            else if (x < 1 && offgridX != 0)
                            {
                                x = 0 - offgridX;
                            }
                            if (y >= 1 && offgridY != 0)
                            {
                                y = 2 + offgridY;
                            }
                            else if (y < 1 && offgridY != 0)
                            {
                                y = 0 - offgridY;
                            }
                        }
                        x = Math.Round(x, 2);
                        y = Math.Round(y, 2);
                    }
                    else
                    {
                        if (KeepOffgrid.Checked == true)
                        {
                            if (x < 0)
                            {
                                offgridX = -1 * x;
                            }
                            else if (x > 2)
                            {
                                offgridX = x - 2;
                            }
                            else
                            {
                                offgridX = 0;
                            }
                            if (y < 0)
                            {
                                offgridY = -1 * y;
                            }
                            else if (y > 2)
                            {
                                offgridY = y - 2;
                            }
                            else
                            {
                                offgridY = 0;
                            }
                        }
                        x = rand.Next(0, 3);
                        y = rand.Next(0, 3);
                        if (Offgrid.Checked == true)
                        {
                            x = (x * ((2 * decimal.Parse(OffgridValue.Text)) + 2) / 2) - decimal.Parse(OffgridValue.Text);
                            y = (y * ((2 * decimal.Parse(OffgridValue.Text)) + 2) / 2) - decimal.Parse(OffgridValue.Text);
                        }
                        if (KeepOffgrid.Checked == true)
                        {
                            if (x >= 1 && offgridX != 0)
                            {
                                x = 2 + offgridX;
                            }
                            else if (x < 1 && offgridX != 0)
                            {
                                x = 0 - offgridX;
                            }
                            if (y >= 1 && offgridY != 0)
                            {
                                y = 2 + offgridY;
                            }
                            else if (y < 1 && offgridY != 0)
                            {
                                y = 0 - offgridY;
                            }
                        }
                    }
                    output += "," + x.ToString().Replace(",", ".") + "|" + y.ToString().Replace(",", ".") + "|" + time;
                }
                Output.Text = output;
            }
            catch
            {

            }
        }
    }
}
