using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Net;

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
            try
            {
                string data = Input.Text;
                if (data.Contains("https:"))
                {
                    try
                    {
                        WebClient wc = new WebClient();
                        data = wc.DownloadString(data);
                    }
                    catch
                    {
                        MessageBox.Show("Failed to download data from url");
                    }
                }
                int rep = data.IndexOf(',');
                int m;
                int mavg;
                bool cont = true;
                bool blacklisted;
                string reps = data.Substring(0, rep);
                data = data.Replace(reps + ",", "");
                string[] newdata = data.Split(',');
                List<string> compare = new List<string>();
                List<string> matches = new List<string>();
                List<string> usednotes = new List<string>();
                List<int> indexblacklist = new List<int>();
                string comparison;
                string compares = "";
                foreach (var line in newdata)
                {
                    rep = line.LastIndexOf('|');
                    reps = line.Substring(0, rep);
                    compare.Add(reps);
                    compares += "," + reps;
                }
                compares = compares.Substring(1, compares.Length - 1);
                for (int i = 0; i < compare.Count; i++)
                {
                    if (!usednotes.Contains(compare[i]))
                    {
                        List<int> indexlist = new List<int>();
                        for (int j = 0; j < compare.Count; j++)
                        {
                            if (j > i && compare[i] == compare[j])
                            {
                                indexlist.Add(j);
                            }
                        }
                        for (int l = 0; l < indexlist.Count; l++)
                        {
                            blacklisted = false;
                            for (int n = 0; n < indexblacklist.Count; n++)
                            {
                                if (indexblacklist[n] == indexlist[l])
                                {
                                    blacklisted = true;
                                }
                            }
                            if (blacklisted == false)
                            {
                                comparison = compare[i];
                                cont = true;
                                for (int j = indexlist[l]; j + 1 < compare.Count && cont == true; j++)
                                {
                                    comparison += "," + compare[j + 1];
                                    int count = 0;
                                    int a = 0;
                                    while ((a = compares.IndexOf(comparison, a)) != -1)
                                    {
                                        a += comparison.Length;
                                        count++;
                                    }
                                    if (count == 1)
                                    {
                                        cont = false;
                                        matches.Add(comparison.Substring(0, comparison.Length - compare[j].Length));
                                    }
                                }
                                indexblacklist.Add(l);
                            }
                        }
                        usednotes.Add(compare[i]);
                    }
                }
                mavg = 0;
                Output.Text = "";
                matches = matches.Distinct().ToList();
                foreach (var item in matches)
                {
                    mavg += item.Count(f => f == '|');
                }
                mavg /= matches.Count;
                m = 0;
                foreach (var item in matches)
                {
                    if (item.Count(f => f == '|') >= mavg)
                    {
                        m += item.Count(f => f == '|');
                    }
                }
                decimal percent = Math.Round(decimal.Divide(decimal.Divide(m, usednotes.Count), newdata.Count()) * 100, 2);
                if (percent > 100)
                {
                    percent = 100;
                }
                Output.Text = "There is approximately a " + percent + "% chance there is some copy-and-paste in this map";
            }
            catch
            {

            }
        }
    }
}
