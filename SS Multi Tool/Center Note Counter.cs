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
    public partial class Center_Note_Counter : Form
    {
        public Center_Note_Counter()
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
                Input.Text = File.ReadAllText(filename);
            }
            catch
            {

            }
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            Input.Text = Clipboard.GetText();
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            string data = Input.Text;
            SecureWebClient wc = new SecureWebClient();
            try
            {
                while (true)
                    data = wc.DownloadString(data);
            }
            catch { }
            decimal width = (decimal)(0.5 - 0.125 / 2);
            decimal x;
            decimal y;
            int count = 0;
            data = data.Replace(data.Substring(0, data.IndexOf(',')) + ",", "");
            string[] newdata = data.Split(',');
            foreach (var line in newdata)
            {
                var lineSplit = Regex.Matches(line, "([^|]+)");
                x = decimal.Parse(lineSplit[0].Value);
                y = decimal.Parse(lineSplit[1].Value);
                if (x <= 1 + width && x >= 1 - width && y <= 1 + width && y >= 1 - width)
                    count += 1;
            }
            Count.Text = count.ToString();
            Ratio.Text = $"{Math.Round(count / (decimal)newdata.Count() * 100, 2)}%";
        }
    }
}
