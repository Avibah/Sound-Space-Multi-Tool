﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace SS_Multi_Tool
{
    public partial class SS_Beat_Hop_Converter : Form
    {
        public SS_Beat_Hop_Converter()
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
                        data = wc.DownloadString(data);
                }
                catch { }
                int rep = data.IndexOf(",");
                string audioID = data.Substring(0, rep);
                data = data.Replace(audioID + ",", "");
                decimal x;
                decimal y;
                int timec = 0;
                decimal location;
                decimal time;
                string output = audioID;
                string[] newdata = data.Split(',');
                List<decimal> times = new List<decimal>();
                foreach (var line in newdata)
                {
                    var lineSplit = Regex.Matches(line, "([^|]+)");
                    time = decimal.Parse(lineSplit[2].Value);
                    times.Add(time);
                }
                foreach (var line in newdata)
                {
                    var lineSplit = Regex.Matches(line, "([^|]+)");
                    x = decimal.Parse(lineSplit[0].Value);
                    y = decimal.Parse(lineSplit[1].Value);
                    time = times[timec];
                    if (timec - 1 >= 0)
                    {
                        time -= 2 * times[timec - 1];
                    }
                    if (timec - 2 >= 0)
                    {
                        time += times[timec - 2];
                    }
                    location = x + y;
                    if (location > 4)
                    {
                        location = 4;
                    }
                    else if (location < 0)
                    {
                        location = 0;
                    }
                    output += "," + location.ToString().Replace(",", ".") + "|0|" + time;
                    timec += 1;
                }
                Output.Text = output;
            }
            catch
            {

            }
            
        }
    }
}
