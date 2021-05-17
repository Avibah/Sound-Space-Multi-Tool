using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SS_Multi_Tool
{
    public partial class Offgrid_Converter : Form
    {
        public Offgrid_Converter()
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
                if (Input.Text.Length < 10)
                {
                    Input.Text = "";
                }
            }
            catch
            {

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                CustomOffgrid.Enabled = true;
            }
            else
            {
                CustomOffgrid.Enabled = false;
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

        private void Convert_Click(object sender, EventArgs e)
        {
            if (Input.Text != "")
            {
                if (CustomOffgrid.Text == "" && radioButton4.Checked == true)
                {
                    CustomOffgrid.Text = "0";
                }
                try
                {
                    decimal offgridMultiplier = 0;
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
                    string final;
                    decimal x = 0;
                    decimal y = 0;
                    decimal time = 0;
                    decimal xmax = -50;
                    decimal xmin = 50;
                    decimal ymax = -50;
                    decimal ymin = 50;
                    int rep;
                    string audioID;
                    string[] newdata;
                    if (radioButton1.Checked == true)
                    {
                        offgridMultiplier = decimal.Parse(radioButton1.Text);
                    }
                    else if (radioButton2.Checked == true)
                    {
                        offgridMultiplier = decimal.Parse(radioButton2.Text);
                    }
                    else if (radioButton3.Checked == true)
                    {
                        offgridMultiplier = decimal.Parse(radioButton3.Text);
                    }
                    else if (radioButton4.Checked == true)
                    {
                        offgridMultiplier = decimal.Parse(CustomOffgrid.Text);
                    }
                    if (offgridMultiplier > decimal.Divide(85, 100))
                    {
                        offgridMultiplier = decimal.Divide(85, 100);
                        CustomOffgrid.Text = "0.85";
                    }
                    if (offgridMultiplier < decimal.Parse("-1"))
                    {
                        offgridMultiplier = decimal.Parse("-1");
                        CustomOffgrid.Text = "-1";
                    }
                    offgridMultiplier = Math.Round(offgridMultiplier, 2);
                    CustomOffgrid.Text = offgridMultiplier.ToString();
                    rep = data.IndexOf(',');
                    audioID = data.Substring(0, rep);
                    data = data.Replace(audioID, "");
                    data = data.Substring(1, data.Length - 1);
                    newdata = data.Split(',');
                    final = audioID;
                    foreach (var line in newdata)
                    {
                        var lineSplit = Regex.Matches(line, "([^|]+)");
                        x = decimal.Parse(lineSplit[0].Value);
                        y = decimal.Parse(lineSplit[1].Value);
                        if (KeepOffgrid.Checked == true && x <= 2 && x >= 0 && y <= 2 && y >= 0 && KeepOffgrid.Enabled == true)
                        {
                            if (x > xmax)
                            {
                                xmax = x;
                            }
                            if (x < xmin)
                            {
                                xmin = x;
                            }
                            if (y > ymax)
                            {
                                ymax = y;
                            }
                            if (y < ymin)
                            {
                                ymin = y;
                            }
                        }
                        else if (KeepOffgrid.Checked == false || KeepOffgrid.Enabled == false)
                        {
                            if (x > xmax)
                            {
                                xmax = x;
                            }
                            if (x < xmin)
                            {
                                xmin = x;
                            }
                            if (y > ymax)
                            {
                                ymax = y;
                            }
                            if (y < ymin)
                            {
                                ymin = y;
                            }
                        }
                    }
                    xmax -= xmin;
                    ymax -= ymin;
                    if (xmax == 0)
                    {
                        xmax = 1;
                    }
                    if (ymax == 0)
                    {
                        ymax = 1;
                    }
                    foreach (var line in newdata)
                    {
                        var lineSplit = Regex.Matches(line, "([^|]+)");
                        x = decimal.Parse(lineSplit[0].Value);
                        y = decimal.Parse(lineSplit[1].Value);
                        time = decimal.Parse(lineSplit[2].Value);
                        if (KeepOffgrid.Checked == true && x <= 2 && x >= 0 && y <= 2 && y >= 0 && KeepOffgrid.Enabled == true)
                        {
                            if (KeepNormal.Checked == true && x > 2 && y > 2 && x < 0 && y < 0 && KeepNormal.Enabled == true)
                            {
                                x -= xmin;
                                y -= ymin;
                                x = x * 2 / xmax;
                                y = y * 2 / ymax;
                            }
                            else if (KeepNormal.Enabled == false || KeepNormal.Checked == false)
                            {
                                x -= xmin;
                                y -= ymin;
                                x = x * 2 / xmax;
                                y = y * 2 / ymax;
                            }

                            if (ConvertOffgrid.Checked == true)
                            {
                                x = (x * ((2 * offgridMultiplier) + 2) / 2) - offgridMultiplier;
                                y = (y * ((2 * offgridMultiplier) + 2) / 2) - offgridMultiplier;
                            }
                            x = Math.Round(x, 2);
                            y = Math.Round(y, 2);
                            if (x == decimal.Parse("0.0") || x == decimal.Parse("1.0") || x == decimal.Parse("2.0") || x == decimal.Parse("0.00") || x == decimal.Parse("1.00") || x == decimal.Parse("2.00"))
                            {
                                x = decimal.Round(x);
                            }
                            if (y == decimal.Parse("0.0") || y == decimal.Parse("1.0") || y == decimal.Parse("2.0") || y == decimal.Parse("0.00") || y == decimal.Parse("1.00") || y == decimal.Parse("2.00"))
                            {
                                y = decimal.Round(y);
                            }
                        }
                        else if (KeepOffgrid.Checked == false || KeepOffgrid.Enabled == false)
                        {
                            if (KeepNormal.Checked == true && x > 2 && KeepNormal.Enabled == true)
                            {
                                x -= xmin;
                                y -= ymin;
                                x = x * 2 / xmax;
                                y = y * 2 / ymax;
                            }
                            else if (KeepNormal.Checked == true && x < 0 && KeepNormal.Enabled == true)
                            {
                                x -= xmin;
                                y -= ymin;
                                x = x * 2 / xmax;
                                y = y * 2 / ymax;
                            }
                            else if (KeepNormal.Checked == true && y > 2 && KeepNormal.Enabled == true)
                            {
                                x -= xmin;
                                y -= ymin;
                                x = x * 2 / xmax;
                                y = y * 2 / ymax;
                            }
                            else if (KeepNormal.Checked == true && y < 0 && KeepNormal.Enabled == true)
                            {
                                x -= xmin;
                                y -= ymin;
                                x = x * 2 / xmax;
                                y = y * 2 / ymax;
                            }
                            else if (KeepNormal.Enabled == false || KeepNormal.Checked == false)
                            {
                                x -= xmin;
                                y -= ymin;
                                x = x * 2 / xmax;
                                y = y * 2 / ymax;
                            }
                            if (ConvertOffgrid.Checked == true)
                            {
                                x = (x * ((2 * offgridMultiplier) + 2) / 2) - offgridMultiplier;
                                y = (y * ((2 * offgridMultiplier) + 2) / 2) - offgridMultiplier;
                            }
                            x = Math.Round(x, 2);
                            y = Math.Round(y, 2);
                            if (x == decimal.Parse("0.0") || x == decimal.Parse("1.0") || x == decimal.Parse("2.0") || x == decimal.Parse("0.00") || x == decimal.Parse("1.00") || x == decimal.Parse("2.00"))
                            {
                                x = decimal.Round(x);
                            }
                            if (y == decimal.Parse("0.0") || y == decimal.Parse("1.0") || y == decimal.Parse("2.0") || y == decimal.Parse("0.00") || y == decimal.Parse("1.00") || y == decimal.Parse("2.00"))
                            {
                                y = decimal.Round(y);
                            }
                        }

                        final += "," + x + "|" + y + "|" + time;
                    }
                    Output.Text = final;
                }
                catch
                {

                }
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ConvertOffgrid.Checked == false)
            {
                ConvertNormal.Checked = true;
            }
            ConvertOffgrid.Checked = false;
            KeepOffgrid.Enabled = false;
            KeepNormal.Enabled = true;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            CustomOffgrid.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ConvertNormal.Checked == false)
            {
                ConvertOffgrid.Checked = true;
            }
            ConvertNormal.Checked = false;
            KeepOffgrid.Enabled = true;
            KeepNormal.Enabled = false;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            if (radioButton4.Checked == true)
            {
                CustomOffgrid.Enabled = true;
            }
        }
    }
}
