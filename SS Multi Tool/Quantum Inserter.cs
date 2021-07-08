﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Net;

namespace SS_Multi_Tool
{
    public partial class Quantum_Inserter : Form
    {
        public Quantum_Inserter()
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

        private void Insert_Click(object sender, EventArgs e)
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
                string output = "";
                for (int k = 0; k < RepeatNumber.Value; k++)
                {
                    if (output != "")
                    {
                        data = output;
                    }
                    if (decimal.TryParse(SectionStart.Text, out _) == false)
                    {
                        SectionStart.Text = "0";
                    }
                    if (decimal.TryParse(SectionEnd.Text, out _) == false)
                    {
                        SectionEnd.Text = "0";
                    }
                    decimal x, y, time, x2 = 0, y2 = 0, time2 = 0, xf, yf, timef;
                    output = data.Substring(0, data.IndexOf(','));
                    data = data.Replace(output + ",", "");
                    string[] newdata = data.Split(',');
                    for (int i = 0; i + 1 < newdata.Count(); i++)
                    {
                        var lineSplit = Regex.Matches(newdata[i], "([^|]+)");
                        x = decimal.Parse(lineSplit[0].Value);
                        y = decimal.Parse(lineSplit[1].Value);
                        time = decimal.Parse(lineSplit[2].Value);
                        var lineSplit2 = Regex.Matches(newdata[i + 1], "([^|]+)");
                        x2 = decimal.Parse(lineSplit2[0].Value);
                        y2 = decimal.Parse(lineSplit2[1].Value);
                        time2 = decimal.Parse(lineSplit2[2].Value);
                        if (SetLimits.Checked == true)
                        {
                            if (time >= decimal.Parse(SectionStart.Text) && time2 <= decimal.Parse(SectionEnd.Text))
                            {
                                xf = Math.Round((x2 + x) / 2, 2);
                                yf = Math.Round((y2 + y) / 2, 2);
                                timef = Math.Round((time2 + time) / 2);
                                output += "," + xf + "|" + yf + "|" + timef;
                            }
                        }
                        else
                        {
                            xf = Math.Round((x2 + x) / 2, 2);
                            yf = Math.Round((y2 + y) / 2, 2);
                            timef = Math.Round((time2 + time) / 2);
                            output += "," + x + "|" + y + "|" + time + "," + xf + "|" + yf + "|" + timef;
                        }
                    }
                    output += "," + x2 + "|" + y2 + "|" + time2;
                    if (k == RepeatNumber.Value - 1)
                    {
                        Output.Text = output;
                    }
                }
            }
            catch (Exception ex)
            {
                var st = new StackTrace(ex, true);
                var frame = st.GetFrame(st.FrameCount - 1);
                var line = frame.GetFileLineNumber();
                Console.WriteLine(line);
            }
        }

        private void SetLimits_CheckedChanged(object sender, EventArgs e)
        {
            SectionStart.Enabled = SetLimits.Checked;
            SectionEnd.Enabled = SetLimits.Checked;
        }
    }
}
