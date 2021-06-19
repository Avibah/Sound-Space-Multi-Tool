using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

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
                    program = program.Replace(" ", "_");
                    program = program.Replace("-", "_");
                    program = program.Replace("(", "_");
                    program = program.Replace(")", "_");
                    program = program.Replace("+", "_");
                    Type type = Type.GetType("SS_Multi_Tool." + program);
                    object obj = Activator.CreateInstance(type);
                    (obj as Form).Show();
                }
            }
            catch
            {
                MessageBox.Show("The previous program exited due to an error.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var glog = "https://raw.githubusercontent.com/Avibah/Sound-Space-Multi-Tool/accompanying-files/UpdateLog";
                SecureWebClient wc = new SecureWebClient();
                var reply = wc.DownloadString(glog);

                int rep = reply.IndexOf('\n');
                int rep2 = reply.IndexOf('v');
                string version = reply.Substring(rep2 + 1, rep - rep2 - 1);

                string data = Changelog.Text;
                int rep3 = data.IndexOf('\n');
                int rep4 = data.IndexOf('v');
                string version2 = data.Substring(rep4 + 1, rep3 - rep4 - 1);

                var lineSplit = Regex.Matches(version, "([^.]+)");
                var lineSplit2 = Regex.Matches(version2, "([^.]+)");

                bool updateReady = false;

                if (int.Parse(lineSplit[0].Value) > int.Parse(lineSplit2[0].Value))
                {
                    updateReady = true;
                }
                else
                {
                    if (int.Parse(lineSplit[1].Value) > int.Parse(lineSplit2[1].Value))
                    {
                        updateReady = true;
                    }
                    else
                    {
                        if (3 == lineSplit.Count)
                        {
                            if (3 == lineSplit2.Count)
                            {
                                if (int.Parse(lineSplit[2].Value) > int.Parse(lineSplit2[2].Value))
                                {
                                    updateReady = true;
                                }
                            }
                            else if (!(int.Parse(lineSplit[1].Value) < int.Parse(lineSplit2[1].Value)))
                            {
                                updateReady = true;
                            }
                        }
                    }
                }

                string changelog = reply.Substring(rep + 1, reply.Length - rep - 1);
                if (updateReady == true)
                {
                    new Update(changelog, version).ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("The version log location may have changed, check the GitHub repository for an update.");
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