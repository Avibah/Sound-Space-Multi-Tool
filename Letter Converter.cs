using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Program_Launcher
{
    public partial class Letter_Converter : Form
    {
        public Letter_Converter()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
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
                decimal x;
                string xs;
                decimal y;
                string ys;
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
                foreach (var line in newdata)
                {
                    var lineSplit = Regex.Matches(line, "([^|]+)");
                    xs = lineSplit[0].Value;
                    ys = lineSplit[1].Value;
                    if (international == true)
                    {
                        xs = xs.Replace(".", ",");
                        ys = ys.Replace(".", ",");
                    }
                    x = Math.Round(decimal.Parse(xs));
                    y = Math.Round(decimal.Parse(ys));
                    xy = x.ToString() + y.ToString();
                    if (SetCap.Checked == false || note < noteCap)
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
