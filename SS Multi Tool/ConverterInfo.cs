using System;
using System.Windows.Forms;

namespace SS_Multi_Tool
{
    public partial class ConverterInfo : Form
    {
        public ConverterInfo()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button prompts you to open the .dat file containing the beatmap you would like to convert.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button prompts you to open the .dat file containing the information the beatmap uses to create proper timestamps.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button copies everything in the below text box to your clipboard so you can easily paste it into a map editor or as map data ingame.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button prompts you to save everything in the below text box as a .txt file.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This box is used to contain the loaded beatmap, allowing you to check if you loaded the right file.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This box is used to contain the loaded information file, allowing you to check if you loaded the right file.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This box contains the converted beatmap after pressing Convert.");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This box is where you place the audio ID from the Roblox library to be inputted into the resuling map data.");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This box allows you to offset every note's timestamps, in milliseconds.");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This box allows you to adjust the timestamps of each note by a multiplier placed in this box. This is useful if the audio from Roblox is sped up or slowed down to avoid copyright. This box uses the multiplier the audio was sped up or slowed down by, not the multiplier that would change the speed to make it normal.");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This checkbox allows you to spread out the notes on the X axis to beyond the 3x3 grid.");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This checkbox allows you to spread out the notes on the Y axis to beyond the 3x3 grid.");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This box allows you to set how far the notes go offgrid from the 3x3 grid on the X axis while the X-Axis Offgrid checkbox is checked.");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This box allows you to set how far the notes go offgrid from the 3x3 grid on the Y axis while the Y-Axis Offgrid checkbox is checked.");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This checkbox makes the notes not go offgrid on the Y axis beyond the bottom of the grid. They still go offgrid on the top of the grid by the specified amount in the box to the right of the Y-Axis Offgrid checkbox.");
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button begins converting the map and adjusts it with the configuration settings you have prepared.");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a progress bar that will somewhat show the progress of the map being converted. This can be used for debugging if something goes wrong or just as feedback that the map is being converted. You don't need to rely on this for the progress of the map being converted, as whenever the output box becomes filled, the map is finished converting.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This checkbox enables randomization of every note's grid location in the map.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This checkbox tells the randomizer to use quantum placements of the notes. This will scale properly with the offgrid settings.");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This checkbox will remove notes if their timestamps are equivalent to previous notes. If you want to move them forward instead of remove them entirely, check the below checkbox.");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This checkbox will switch from removing notes with equivalent timestamps of previous notes to moving them forward by the amount of milliseconds defined in the below box.");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This box defines the amount of milliseconds that notes are moved forward if their timestamps are equivalent to previous timestamps.");
        }
    }
}
