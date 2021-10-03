namespace SS_Multi_Tool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Open = new System.Windows.Forms.Button();
            this.Changelog = new System.Windows.Forms.RichTextBox();
            this.OpenGit = new System.Windows.Forms.Button();
            this.OpenDir = new System.Windows.Forms.Button();
            this.DarkMode = new System.Windows.Forms.CheckBox();
            this.ProgramList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(390, 243);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(108, 23);
            this.Open.TabIndex = 0;
            this.Open.Text = "Open Tool";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Changelog
            // 
            this.Changelog.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Changelog.Location = new System.Drawing.Point(12, 12);
            this.Changelog.Name = "Changelog";
            this.Changelog.ReadOnly = true;
            this.Changelog.Size = new System.Drawing.Size(240, 283);
            this.Changelog.TabIndex = 3;
            this.Changelog.Text = "SS Multi Tool v1.17.2\n\n-Added degree support for the \'Map Rotator\'\n--Rotations ar" +
    "e clockwise by the given degree";
            // 
            // OpenGit
            // 
            this.OpenGit.Location = new System.Drawing.Point(258, 272);
            this.OpenGit.Name = "OpenGit";
            this.OpenGit.Size = new System.Drawing.Size(108, 23);
            this.OpenGit.TabIndex = 4;
            this.OpenGit.Text = "Open GitHub";
            this.OpenGit.UseVisualStyleBackColor = true;
            this.OpenGit.Click += new System.EventHandler(this.OpenGit_Click);
            // 
            // OpenDir
            // 
            this.OpenDir.Location = new System.Drawing.Point(258, 243);
            this.OpenDir.Name = "OpenDir";
            this.OpenDir.Size = new System.Drawing.Size(108, 23);
            this.OpenDir.TabIndex = 5;
            this.OpenDir.Text = "Open Directory";
            this.OpenDir.UseVisualStyleBackColor = true;
            this.OpenDir.Click += new System.EventHandler(this.OpenDir_Click);
            // 
            // DarkMode
            // 
            this.DarkMode.AutoSize = true;
            this.DarkMode.Location = new System.Drawing.Point(399, 276);
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.Size = new System.Drawing.Size(79, 17);
            this.DarkMode.TabIndex = 6;
            this.DarkMode.Text = "Dark Mode";
            this.DarkMode.UseVisualStyleBackColor = true;
            this.DarkMode.Visible = false;
            this.DarkMode.CheckedChanged += new System.EventHandler(this.DarkMode_CheckedChanged);
            // 
            // ProgramList
            // 
            this.ProgramList.FormattingEnabled = true;
            this.ProgramList.Items.AddRange(new object[] {
            "Map Speed Adjuster",
            "Map Resizer",
            "Map Randomizer",
            "Map Mirrorer",
            "Map Rotator",
            "Map Quantizer",
            "Map Stacker",
            "Map Unstacker",
            "Map Note Counter",
            "Quantum Inserter",
            "Beat Hop Lane Switcher",
            "",
            "Highest BPM Identifier",
            "Map Diagnoser",
            "Copy-Paste Detector",
            "NPS Calculator",
            "Difficulty Calculator",
            "Angle Definer",
            "",
            "Audio Downloader",
            "Map Data Extractor",
            "",
            "CH Timings Converter",
            "OSU Timings Converter",
            "ADOFAI Timings Converter",
            "",
            "Format Converters",
            "OSU-SS Converter",
            "SS-OSU Converter",
            "CH-SS Converter",
            "Beat Saber-SS Converter",
            "SS-Beat Saber Converter",
            "ADOFAI-SS Converter",
            "SS-Beat Hop Converter",
            "Beat Hop-SS Converter",
            "Letter Converter"});
            this.ProgramList.Location = new System.Drawing.Point(258, 12);
            this.ProgramList.Name = "ProgramList";
            this.ProgramList.Size = new System.Drawing.Size(240, 225);
            this.ProgramList.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 306);
            this.Controls.Add(this.ProgramList);
            this.Controls.Add(this.DarkMode);
            this.Controls.Add(this.OpenDir);
            this.Controls.Add(this.OpenGit);
            this.Controls.Add(this.Changelog);
            this.Controls.Add(this.Open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.RichTextBox Changelog;
        private System.Windows.Forms.Button OpenGit;
        private System.Windows.Forms.Button OpenDir;
        private System.Windows.Forms.CheckBox DarkMode;
        private System.Windows.Forms.ListBox ProgramList;
    }
}

