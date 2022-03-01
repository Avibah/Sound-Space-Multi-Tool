using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace SS_Multi_Tool
{
    public partial class Map_Resizer : Form
    {
        public Map_Resizer()
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

        private void CustomButton_CheckedChanged(object sender, EventArgs e)
        {
            CustomOffgrid.Enabled = CustomButton.Checked;
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
            }
            catch
            {

            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            if (Input.Text != "")
            {
                if (CustomOffgrid.Text == "" && CustomButton.Checked)
                {
                    if (ApplyMultiplier.Checked)
                    {
                        CustomOffgrid.Text = "1";
                    }
                    else
                    {
                        CustomOffgrid.Text = "0";
                    }
                }
                try
                {
                    decimal offgridMultiplier = 0;
                    Output.Text = "";
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
                    if (!decimal.TryParse(OffsetXBox.Text, out _))
                    {
                        OffsetXBox.Text = "0";
                    }
                    if (!decimal.TryParse(OffsetYBox.Text, out _))
                    {
                        OffsetYBox.Text = "0";
                    }
                    decimal xos = decimal.Parse(OffsetXBox.Text);
                    decimal yos = decimal.Parse(OffsetYBox.Text);
                    string final;
                    decimal x = 0;
                    decimal y = 0;
                    decimal time = 0;
                    decimal xmax = -50;
                    decimal xmin = 50;
                    decimal ymax = -50;
                    decimal ymin = 50;
                    int rep;
                    string audioID;
                    string[] newdata;
                    var checkedButton = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                    if (checkedButton.Text != "Custom")
                    {
                        offgridMultiplier = decimal.Parse(checkedButton.Text);
                    }
                    else
                    {
                        offgridMultiplier = decimal.Parse(CustomOffgrid.Text);
                    }
                    if (offgridMultiplier < -1)
                    {
                        offgridMultiplier = -1;
                        CustomOffgrid.Text = "-1";
                    }
                    offgridMultiplier = Math.Round(offgridMultiplier, 2);
                    rep = data.IndexOf(',');
                    audioID = data.Substring(0, rep);
                    data = data.Replace(audioID, "");
                    data = data.Substring(1, data.Length - 1);
                    newdata = data.Split(',');
                    final = audioID;
                    foreach (var line in newdata)
                    {
                        var lineSplit = Regex.Matches(line, "([^|]+)");
                        x = decimal.Parse(lineSplit[0].Value);
                        y = decimal.Parse(lineSplit[1].Value);
                        if (KeepOffgrid.Checked && x <= 2 && x >= 0 && y <= 2 && y >= 0 && KeepOffgrid.Enabled)
                        {
                            xmax = Math.Max(xmax, x);
                            xmin = Math.Min(xmin, x);
                            ymax = Math.Max(ymax, y);
                            ymin = Math.Min(ymin, y);
                        }
                        else if (!KeepOffgrid.Checked || !KeepOffgrid.Enabled)
                        {
                            xmax = Math.Max(xmax, x);
                            xmin = Math.Min(xmin, x);
                            ymax = Math.Max(ymax, y);
                            ymin = Math.Min(ymin, y);
                        }
                    }
                    xmax -= xmin;
                    ymax -= ymin;
                    if (xmax == 0)
                        xmax = 1;
                    if (ymax == 0)
                        ymax = 1;
                    foreach (var line in newdata)
                    {
                        var lineSplit = Regex.Matches(line, "([^|]+)");
                        x = decimal.Parse(lineSplit[0].Value);
                        y = decimal.Parse(lineSplit[1].Value);
                        time = decimal.Parse(lineSplit[2].Value);
                        if (KeepOffgrid.Checked && x <= 2 && x >= 0 && y <= 2 && y >= 0 && KeepOffgrid.Enabled)
                        {
                            if (ApplyMultiplier.Checked)
                            {
                                x = (x - 1) * offgridMultiplier + 1;
                                y = (y - 1) * offgridMultiplier + 1;
                            }
                            else
                            {
                                x = (x - xmin) * 2 / xmax;
                                y = (y - ymin) * 2 / ymax;
                                x = x * (offgridMultiplier + 1) - offgridMultiplier;
                                y = y * (offgridMultiplier + 1) - offgridMultiplier;
                            }
                        }
                        else if (!KeepOffgrid.Checked || !KeepOffgrid.Enabled)
                        {
                            if (KeepNormal.Checked && KeepNormal.Enabled)
                            {
                                if (x > 2 || x < 0 || y > 2 || y < 0)
                                {
                                    x = (x - xmin) * 2 / xmax;
                                    y = (y - ymin) * 2 / ymax;
                                }
                            }
                            else if (!ConvertOffgrid.Checked)
                            {
                                x = (x - xmin) * 2 / xmax;
                                y = (y - ymin) * 2 / ymax;
                            }
                            if (ConvertOffgrid.Checked)
                            {
                                if (ApplyMultiplier.Checked)
                                {
                                    x = (x - 1) * offgridMultiplier + 1;
                                    y = (y - 1) * offgridMultiplier + 1;
                                }
                                else
                                {
                                    x = (x - xmin) * 2 / xmax;
                                    y = (y - ymin) * 2 / ymax;
                                    x = x * (offgridMultiplier + 1) - offgridMultiplier;
                                    y = y * (offgridMultiplier + 1) - offgridMultiplier;
                                }
                            }
                        }
                        x += xos;
                        y += yos;
                        if (OffgridLimit.Checked)
                        {
                            x = Math.Min(2.85m, Math.Max(-0.85m, x));
                            y = Math.Min(2.85m, Math.Max(-0.85m, y));
                        }
                        x = Math.Round(x, 2);
                        y = Math.Round(y, 2);
                        final += "," + x + "|" + y + "|" + time;
                    }
                    Output.Text = final;
                }
                catch
                {

                }
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

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!ConvertOffgrid.Checked)
            {
                ConvertNormal.Checked = true;
            }
            ConvertOffgrid.Checked = false;
            KeepOffgrid.Enabled = false;
            KeepNormal.Enabled = true;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            CustomButton.Enabled = false;
            CustomOffgrid.Enabled = false;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!ConvertNormal.Checked)
            {
                ConvertOffgrid.Checked = true;
            }
            ConvertNormal.Checked = false;
            KeepOffgrid.Enabled = true;
            KeepNormal.Enabled = false;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            CustomButton.Enabled = true;
            if (CustomButton.Checked)
            {
                CustomOffgrid.Enabled = true;
            }
        }

        private void OffsetYAmount_Scroll(object sender, EventArgs e)
        {
            OffsetYBox.Text = (decimal.Parse(OffsetYAmount.Value.ToString()) / -5).ToString();
        }

        private void OffsetXAmount_Scroll(object sender, EventArgs e)
        {
            OffsetXBox.Text = (decimal.Parse(OffsetXAmount.Value.ToString()) / -5).ToString();
        }

        private void ApplyMultiplier_CheckedChanged(object sender, EventArgs e)
        {
            if (ApplyMultiplier.Checked == true)
            {
                radioButton1.Text = "1.25";
                radioButton2.Text = "1.5";
                radioButton3.Text = "1.75";
                if (CustomOffgrid.Text == "0" || CustomOffgrid.Text == "" || !int.TryParse(CustomOffgrid.Text, out _))
                {
                    CustomOffgrid.Text = "1";
                }
            }
            else
            {
                radioButton1.Text = "0.25";
                radioButton2.Text = "0.5";
                radioButton3.Text = "0.75";
                if (CustomOffgrid.Text == "1" || CustomOffgrid.Text == "" || !int.TryParse(CustomOffgrid.Text, out _))
                {
                    CustomOffgrid.Text = "0";
                }
            }
        }
    }
}
