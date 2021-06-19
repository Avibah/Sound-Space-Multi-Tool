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

        private void Mirror_Click(object sender, EventArgs e)
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
                string output = data.Substring(0, data.IndexOf(','));
                data = data.Replace(output + ",", "");
                decimal x;
                string xs;
                decimal y;
                string ys;
                decimal time;
                string[] newdata = data.Split(',');
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
                        x = x * -1 + 2;
                    }
                    if (MirrorV.Checked == true)
                    {
                        y = y * -1 + 2;
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
