using System.Windows.Forms;

namespace SS_Multi_Tool
{
    public partial class Update : Form
    {
        public string version;
        public Update(string changelog, string vers)
        {
            InitializeComponent();
            richTextBox1.Text = changelog;
            version = vers;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Avibah/Sound-Space-Multi-Tool/releases/v" + version);
        }
    }
}
