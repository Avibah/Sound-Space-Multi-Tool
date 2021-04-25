using System;
using System.Windows.Forms;

namespace SS_Multi_Tool
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            MessageBox.Show("For standard use, load the beatmap, paste in the audio ID, and press 'Convert'. Other settings should only be changed if you aren't doing a simple conversion or if you never used fog's guides.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button prompts you to open the OSU beatmap you want to convert.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button pastes whatever you have copied in your clipboard to the text box below. This is useful if you don't want to open a map through the prompt.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button copies whatever is in the text box below to your clipboard. This makes copying the output data much easier.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button prompts you to save the output data that has been converted as a .txt file.");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This text box contains the data in the OSU beatmap. This is what will be converted when you press 'Convert'.");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This text box contains the converted data.");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This text box contains the audio ID you want associated with the map data. Without this, the data will not load.");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This text box contains an offset you may want to apply to a map. This is in milliseconds and can save you a trip to the editor when trying to test a map. The default value is 0.");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This value should only be changed if the uploaded audio from Roblox has been sped up or slowed down to avoid copyright. This should be set to however the audio pitch has been changed to keep timestamps lined up in the map. The default value is 1.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This setting refers to fogsaturate's mapping guide contained in the zip folder. If you used it to make a map to convert to Sound Space, use this setting. If you didn't, the formatting will be based off where notes are placed on the entire space in the OSU editor, with scaling based off the furthest notes on each axis.");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This setting is enabled by unchecking the 'Sound Space Guides Used' setting.\n\nIf you want to randomize the locations of notes on the grid, use this setting. Keep this off for normal use.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This setting is enabled by unchecking the 'Sound Space Guides Used' setting.\n\nIf you want to spread the notes out along the X axis to put them offgrid, use this setting.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This setting is enabled by unchecking the 'Sound Space Guides Used' setting.\n\nIf you want to spread the notes out along the Y axis to put them offgrid, use this setting.");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This setting is enabled by checking the 'Randomize Notes' setting.\n\nThis will make randomized notes be able to go anywhere on the grid.");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This starts conversion of the loaded beatmap with the current settings and values.");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a progress bar and it can be used for debugging if something errors with conversion or as feedback to show a map is properly converting.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This setting is enabled by checking the 'X-Axis Offgrid' setting.\n\nThis value is how far offgrid notes go along the X axis.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This setting is enabled by checking the 'Y-Axis Offgrid' setting.\n\nThis value is how far offgrid notes go along the Y axis.");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This setting is enabled by checking the 'Y-Axis Offgrid' setting.\n\nThis normally won't be used, but it binds notes on the Y axis to the bottom of the 3x3 grid. The offgrid value set in the 'Y-Axis Offgrid' text box will be how far it goes above the grid.");
        }
    }
}
