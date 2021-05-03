using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SS_Multi_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            try
            {
                string program = ProgramList.GetItemText(ProgramList.SelectedItem);
                if (program != "")
                {
                    program = program.Replace("Format Converters", "Converters");
                    program = program.Replace("Highest BPM Identifier", "Highest BPM Identifier (WIP)");
                    program = program.Replace("CH Timings Converter", "CH-OSU Timings Converter");
                    program = program.Replace(" ", "_");
                    program = program.Replace("-", "_");
                    program = program.Replace("(", "_");
                    program = program.Replace(")", "_");
                    program = program.Replace("+", "_");
                    Type type = Type.GetType("SS_Multi_Tool." + program);
                    object obj = Activator.CreateInstance(type);
                    (obj as Form).ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("The previous program exited due to an error.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string updateDate = "2021-05-03";
            var parsedDate = DateTime.Parse(updateDate);
            try
            {
                var glog = "https://raw.githubusercontent.com/Avibah/Sound-Space-Multi-Tool/accompanying-files/UpdateLog";
                SecureWebClient wc = new SecureWebClient();
                var reply = wc.DownloadString(glog);
                int rep = reply.IndexOf('\n');
                var date = DateTime.Parse(reply.Substring(0, rep));
                string changelog = reply.Substring(rep + 1, reply.Length - rep - 1);
                if (date > parsedDate)
                {
                    MessageBox.Show("Updates are ready for this program! Check the GitHub page to download the new version.\n\n" + changelog);
                }
            }
            catch
            {
                MessageBox.Show("The version log location may have changed, check the GitHub repository for an update.\nCurrent version release date: " + updateDate);
            }
        }

        private void OpenGit_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Avibah/Sound-Space-Multi-Tool/releases/");
        }

        private void OpenDir_Click(object sender, EventArgs e)
        {
            Process.Start(Directory.GetCurrentDirectory());
        }
    }
}