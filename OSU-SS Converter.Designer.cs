namespace Program_Launcher
{
    partial class OSU_SS_Converter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OSU_SS_Converter));
            this.Info = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.RandomQuantum = new System.Windows.Forms.CheckBox();
            this.Random = new System.Windows.Forms.CheckBox();
            this.ZBound = new System.Windows.Forms.CheckBox();
            this.YOffgridValue = new System.Windows.Forms.TextBox();
            this.XOffgridValue = new System.Windows.Forms.TextBox();
            this.YOffgrid = new System.Windows.Forms.CheckBox();
            this.XOffgrid = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Convert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AudioID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Offset = new System.Windows.Forms.TextBox();
            this.AudioSpeed = new System.Windows.Forms.TextBox();
            this.SSGuides = new System.Windows.Forms.CheckBox();
            this.Export = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Copy = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DownloadAudio = new System.Windows.Forms.Button();
            this.OpenDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(440, 263);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(25, 22);
            this.Info.TabIndex = 68;
            this.Info.Text = "?";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(116, 2);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(108, 36);
            this.Paste.TabIndex = 67;
            this.Paste.Text = "Paste Data";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // RandomQuantum
            // 
            this.RandomQuantum.AutoSize = true;
            this.RandomQuantum.Enabled = false;
            this.RandomQuantum.Location = new System.Drawing.Point(116, 214);
            this.RandomQuantum.Name = "RandomQuantum";
            this.RandomQuantum.Size = new System.Drawing.Size(112, 17);
            this.RandomQuantum.TabIndex = 66;
            this.RandomQuantum.Text = "Random Quantum";
            this.RandomQuantum.UseVisualStyleBackColor = true;
            // 
            // Random
            // 
            this.Random.AutoSize = true;
            this.Random.Enabled = false;
            this.Random.Location = new System.Drawing.Point(116, 175);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(110, 17);
            this.Random.TabIndex = 65;
            this.Random.Text = "Randomize Notes";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // ZBound
            // 
            this.ZBound.AutoSize = true;
            this.ZBound.Enabled = false;
            this.ZBound.Location = new System.Drawing.Point(281, 214);
            this.ZBound.Name = "ZBound";
            this.ZBound.Size = new System.Drawing.Size(115, 17);
            this.ZBound.TabIndex = 64;
            this.ZBound.Text = "Zero-Based Offgrid";
            this.ZBound.UseVisualStyleBackColor = true;
            // 
            // YOffgridValue
            // 
            this.YOffgridValue.Enabled = false;
            this.YOffgridValue.Location = new System.Drawing.Point(386, 173);
            this.YOffgridValue.Name = "YOffgridValue";
            this.YOffgridValue.Size = new System.Drawing.Size(34, 20);
            this.YOffgridValue.TabIndex = 63;
            this.YOffgridValue.Text = "0.5";
            // 
            // XOffgridValue
            // 
            this.XOffgridValue.Enabled = false;
            this.XOffgridValue.Location = new System.Drawing.Point(386, 137);
            this.XOffgridValue.Name = "XOffgridValue";
            this.XOffgridValue.Size = new System.Drawing.Size(34, 20);
            this.XOffgridValue.TabIndex = 62;
            this.XOffgridValue.Text = "0.5";
            // 
            // YOffgrid
            // 
            this.YOffgrid.AutoSize = true;
            this.YOffgrid.Enabled = false;
            this.YOffgrid.Location = new System.Drawing.Point(281, 175);
            this.YOffgrid.Name = "YOffgrid";
            this.YOffgrid.Size = new System.Drawing.Size(89, 17);
            this.YOffgrid.TabIndex = 61;
            this.YOffgrid.Text = "Y-Axis Offgrid";
            this.YOffgrid.UseVisualStyleBackColor = true;
            this.YOffgrid.CheckedChanged += new System.EventHandler(this.YOffgrid_CheckedChanged);
            // 
            // XOffgrid
            // 
            this.XOffgrid.AutoSize = true;
            this.XOffgrid.Enabled = false;
            this.XOffgrid.Location = new System.Drawing.Point(281, 140);
            this.XOffgrid.Name = "XOffgrid";
            this.XOffgrid.Size = new System.Drawing.Size(89, 17);
            this.XOffgrid.TabIndex = 60;
            this.XOffgrid.Text = "X-Axis Offgrid";
            this.XOffgrid.UseVisualStyleBackColor = true;
            this.XOffgrid.CheckedChanged += new System.EventHandler(this.XOffgrid_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(249, 263);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(185, 22);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 59;
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(3, 263);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(133, 22);
            this.Convert.TabIndex = 58;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Output";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Audio ID";
            // 
            // AudioID
            // 
            this.AudioID.Location = new System.Drawing.Point(3, 138);
            this.AudioID.Name = "AudioID";
            this.AudioID.Size = new System.Drawing.Size(109, 20);
            this.AudioID.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Offset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Audio Speed Multiplier";
            // 
            // Offset
            // 
            this.Offset.Location = new System.Drawing.Point(3, 188);
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(109, 20);
            this.Offset.TabIndex = 52;
            this.Offset.Text = "0";
            // 
            // AudioSpeed
            // 
            this.AudioSpeed.Location = new System.Drawing.Point(2, 237);
            this.AudioSpeed.Name = "AudioSpeed";
            this.AudioSpeed.Size = new System.Drawing.Size(110, 20);
            this.AudioSpeed.TabIndex = 51;
            this.AudioSpeed.Text = "1";
            // 
            // SSGuides
            // 
            this.SSGuides.AutoSize = true;
            this.SSGuides.Checked = true;
            this.SSGuides.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SSGuides.Location = new System.Drawing.Point(116, 140);
            this.SSGuides.Name = "SSGuides";
            this.SSGuides.Size = new System.Drawing.Size(155, 17);
            this.SSGuides.TabIndex = 50;
            this.SSGuides.Text = "Sound Space Guides Used";
            this.SSGuides.UseVisualStyleBackColor = true;
            this.SSGuides.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(351, 2);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(114, 36);
            this.Export.TabIndex = 49;
            this.Export.Text = "Export to .txt";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(230, 44);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(235, 75);
            this.Output.TabIndex = 48;
            this.Output.Text = "";
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(230, 2);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(115, 36);
            this.Copy.TabIndex = 47;
            this.Copy.Text = "Copy Data";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(2, 2);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(108, 36);
            this.Open.TabIndex = 46;
            this.Open.Text = "Open Beatmap";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(3, 44);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(221, 75);
            this.Input.TabIndex = 45;
            this.Input.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DownloadAudio
            // 
            this.DownloadAudio.Location = new System.Drawing.Point(37, 162);
            this.DownloadAudio.Name = "DownloadAudio";
            this.DownloadAudio.Size = new System.Drawing.Size(75, 23);
            this.DownloadAudio.TabIndex = 69;
            this.DownloadAudio.Text = "Download";
            this.DownloadAudio.UseVisualStyleBackColor = true;
            this.DownloadAudio.Click += new System.EventHandler(this.DownloadAudio_Click);
            // 
            // OpenDir
            // 
            this.OpenDir.Location = new System.Drawing.Point(142, 263);
            this.OpenDir.Name = "OpenDir";
            this.OpenDir.Size = new System.Drawing.Size(101, 22);
            this.OpenDir.TabIndex = 70;
            this.OpenDir.Text = "Open Directory";
            this.OpenDir.UseVisualStyleBackColor = true;
            this.OpenDir.Click += new System.EventHandler(this.OpenDir_Click);
            // 
            // OSU_SS_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 288);
            this.Controls.Add(this.OpenDir);
            this.Controls.Add(this.DownloadAudio);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.RandomQuantum);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.ZBound);
            this.Controls.Add(this.YOffgridValue);
            this.Controls.Add(this.XOffgridValue);
            this.Controls.Add(this.YOffgrid);
            this.Controls.Add(this.XOffgrid);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AudioID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Offset);
            this.Controls.Add(this.AudioSpeed);
            this.Controls.Add(this.SSGuides);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OSU_SS_Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.CheckBox RandomQuantum;
        private System.Windows.Forms.CheckBox Random;
        private System.Windows.Forms.CheckBox ZBound;
        private System.Windows.Forms.TextBox YOffgridValue;
        private System.Windows.Forms.TextBox XOffgridValue;
        private System.Windows.Forms.CheckBox YOffgrid;
        private System.Windows.Forms.CheckBox XOffgrid;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AudioID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Offset;
        private System.Windows.Forms.TextBox AudioSpeed;
        private System.Windows.Forms.CheckBox SSGuides;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button DownloadAudio;
        private System.Windows.Forms.Button OpenDir;
    }
}