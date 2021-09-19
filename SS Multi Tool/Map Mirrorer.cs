using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace SS_Multi_Tool
{
    public partial class Map_Mirrorer : Form
    {
        public Map_Mirrorer()
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

        public static bool CheckBH(string[] data)
        {
            bool international = true;
            string numint = "50,000";
            decimal numTest = decimal.Parse(numint);
            if (numTest == 50000)
            {
                international = false;
            }
            bool bhmap = false;
            bool negative = false;
            bool lanes = true;
            bool lowersecondtime = false;
            bool lowerdigits = true;
            decimal x;
            string xs;
            decimal y;
            string ys;
            decimal time;
            decimal? firsttime = null;
            int firstdigits = 0;
            foreach (var line in data)
            {
                var lineSplit = Regex.Matches(line, "([^|]+)");
                xs = lineSplit[0].Value;
                ys = lineSplit[1].Value;
                if (international == true)
                {
                    xs = xs.Replace(".", ",");
                    ys = ys.Replace(".", ",");
                }
                x = decimal.Parse(xs);
                y = decimal.Parse(ys);
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

        private void Mirror_Click(object sender, EventArgs e)
        {
            try
            {
                bool international = true;
                string numint = "50,000";
                decimal numTest = decimal.Parse(numint);
                if (numTest == 50000)
                {
                    international = false;
                }
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
                decimal x;
                string xs;
                decimal y;
                string ys;
                decimal time;
                string[] newdata = data.Split(',');
                if (!CheckBH(newdata))
                {
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
                        x = decimal.Parse(xs);
                        y = decimal.Parse(ys);
                        time = decimal.Parse(lineSplit[2].Value);
                        if (MirrorH.Checked == true)
                        {
                            x = 2 - x;
                        }
                        if (MirrorV.Checked == true)
                        {
                            y = 2 - y;
                        }
                        xs = x.ToString();
                        ys = y.ToString();
                        if (international == true)
                        {
                            xs = xs.Replace(",", ".");
                            ys = ys.Replace(",", ".");
                        }
                        output += "," + xs + "|" + ys + "|" + time;
                    }
                }
                else
                {
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
                        x = decimal.Parse(xs);
                        y = decimal.Parse(ys);
                        time = decimal.Parse(lineSplit[2].Value);
                        x = 4 - x;
                        xs = x.ToString();
                        ys = y.ToString();
                        if (international == true)
                        {
                            xs = xs.Replace(",", ".");
                            ys = ys.Replace(",", ".");
                        }
                        output += "," + x + "|" + y + "|" + time;
                    }
                }
                Output.Text = output;
            }
            catch
            {

            }
        }
    }
}
