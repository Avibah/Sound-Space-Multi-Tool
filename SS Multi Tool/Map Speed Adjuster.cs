using System;
using System.Windows.Forms;
using System.IO;

namespace Program_Launcher
{
    public partial class Map_Speed_Adjuster : Form
    {
        public Map_Speed_Adjuster()
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
                saveFileDialog1.Title = "Save file as";
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
                if (Speed.Text == "")
                {
                    Speed.Text = "1";
                }
                if (international == true)
                {
                    Speed.Text = Speed.Text.Replace(".", ",");
                }
                string data = Input.Text;
                string final;
                string locations;
                decimal time;
                int rep = data.IndexOf(',');
                string reps = data.Substring(0, rep);
                data = data.Replace(reps + ",", "");
                final = reps;
                string reps2;
                string[] newdata = data.Split(',');
                foreach (var line in newdata)
                {
                    rep = line.LastIndexOf('|');
                    reps = line.Substring(0, rep + 1);
                    locations = reps;
                    reps2 = line.Replace(reps, "");
                    reps2 = reps2.Replace("|", "");
                    time = decimal.Parse(reps2);
                    time /= decimal.Parse(Speed.Text);
                    time = Math.Round(time);
                    final += "," + locations + time;
                }
                Output.Text = final;
            }
            catch
            {

            }
        }
    }
}
