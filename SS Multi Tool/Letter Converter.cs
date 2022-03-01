using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SS_Multi_Tool
{
    public partial class Letter_Converter : Form
    {
        public Letter_Converter()
        {
            InitializeComponent();
        }

        public static bool CheckBH(string[] data)
        {
            bool bhmap = false;
            bool negative = false;
            bool lanes = true;
            bool lowersecondtime = false;
            bool lowerdigits = true;
            decimal x;
            decimal y;
            decimal time;
            decimal? firsttime = null;
            int firstdigits = 0;
            foreach (var line in data)
            {
                var lineSplit = Regex.Matches(line, "([^|]+)");
                x = decimal.Parse(lineSplit[0].Value);
                y = decimal.Parse(lineSplit[1].Value);
                time = decimal.Parse(lineSplit[2].Value);
                int digits = (int)Math.Floor(Math.Log10(Math.Abs((double)time)) + 1);
                if (time < 0)
                {
                    negative = true;
                }
                if (y < -1 || y > 1 || !int.TryParse(y.ToString(), out _))
                {
                    lanes = false;
                }
                if (firsttime != null && firsttime > time)
                {
                    lowersecondtime = true;
                }
                else if (firsttime == null)
                {
                    firsttime = time;
                    firstdigits = digits;
                }
                if (digits > firstdigits)
                {
                    lowerdigits = false;
                }
            }
            if (negative == true && lanes == true && lowersecondtime == true && lowerdigits == true)
            {
                bhmap = true;
            }
            return bhmap;
        }

        private void SetCap_CheckedChanged(object sender, EventArgs e)
        {
            if (SetCap.Checked == true)
            {
                Cap.Enabled = true;
            }
            else
            {
                Cap.Enabled = false;
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
                if (Input.Text.Length < 10)
                {
                    MessageBox.Show("No valid file was selected for loading.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                
            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            try
            {
                Output.Text = "";
                string data = Input.Text;
                SecureWebClient wc = new SecureWebClient();
                try
                {
                    while (true)
                        data = wc.DownloadString(data);
                }
                catch { }
                decimal x;
                decimal y;
                string xy;
                int note = 0;
                int noteCap = 0;
                if (SetCap.Checked == true)
                {
                    if (Cap.Text == "")
                    {
                        noteCap = 0;
                    }
                    else
                    {
                        noteCap = int.Parse(Cap.Text);
                    }
                }
                int rep;
                string reps;
                string letter = "";
                string output = "";
                string[] newdata;
                rep = data.IndexOf(',');
                reps = data.Substring(0, rep);
                data = data.Replace(reps, "");
                data = data.Substring(1, data.Length - 1);
                newdata = data.Split(',');
                bool BH = CheckBH(newdata);
                foreach (var line in newdata)
                {
                    var lineSplit = Regex.Matches(line, "([^|]+)");
                    x = Math.Round(decimal.Parse(lineSplit[0].Value));
                    y = Math.Round(decimal.Parse(lineSplit[1].Value));
                    if (BH)
                    {
                        if (x < 0)
                        {
                            x = 0;
                        }
                        if (x > 4)
                        {
                            x = 4;
                        }
                    }
                    else
                    {
                        if (x < 0)
                        {
                            x = 0;
                        }
                        else if (x > 2)
                        {
                            x = 2;
                        }
                        if (y < 0)
                        {
                            y = 0;
                        }
                        else if (y > 2)
                        {
                            y = 2;
                        }
                    }
                    xy = x.ToString() + y.ToString();
                    if (SetCap.Checked == false || note < noteCap)
                    {
                        if (!BH)
                        {
                            switch (xy)
                            {
                                case "22":
                                    letter = "Q";
                                    break;
                                case "12":
                                    letter = "W";
                                    break;
                                case "02":
                                    letter = "E";
                                    break;
                                case "21":
                                    letter = "A";
                                    break;
                                case "11":
                                    letter = "S";
                                    break;
                                case "01":
                                    letter = "D";
                                    break;
                                case "20":
                                    letter = "Z";
                                    break;
                                case "10":
                                    letter = "X";
                                    break;
                                case "00":
                                    letter = "C";
                                    break;
                            }
                        }
                        else
                        {
                            switch (x)
                            {
                                case 0:
                                    letter = "Q";
                                    break;
                                case 1:
                                    letter = "W";
                                    break;
                                case 2:
                                    letter = "E";
                                    break;
                                case 3:
                                    letter = "R";
                                    break;
                                case 4:
                                    letter = "T";
                                    break;
                            }
                        }
                        output += letter;
                        if (Spaces.Checked == true)
                        {
                            output += " ";
                        }
                    }
                    note += 1;
                }
                if (Capitals.Checked != true)
                {
                    output = output.ToLower();
                }
                Output.Text = output;
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
    }
}
