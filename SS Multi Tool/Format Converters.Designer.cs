namespace SS_Multi_Tool
{
    partial class Format_Converters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Format_Converters));
            this.ConverterList = new System.Windows.Forms.ListBox();
            this.Open = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.AudioID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Offset = new System.Windows.Forms.TextBox();
            this.AudioSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.RichTextBox();
            this.OpenInfo = new System.Windows.Forms.Button();
            this.DownloadAudio = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Button();
            this.SSGuides = new System.Windows.Forms.CheckBox();
            this.YOffgridValue = new System.Windows.Forms.TextBox();
            this.XOffgridValue = new System.Windows.Forms.TextBox();
            this.YOffgrid = new System.Windows.Forms.CheckBox();
            this.XOffgrid = new System.Windows.Forms.CheckBox();
            this.RandomQuantum = new System.Windows.Forms.CheckBox();
            this.Random = new System.Windows.Forms.CheckBox();
            this.Difficulty = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ImageDir = new System.Windows.Forms.TextBox();
            this.SelectImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenDir = new System.Windows.Forms.Button();
            this.BPM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Directions = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ConverterList
            // 
            this.ConverterList.FormattingEnabled = true;
            this.ConverterList.Items.AddRange(new object[] {
            "OSU to SS",
            "SS to OSU",
            "Beat Saber to SS",
            "Clone Hero to SS",
            "SS to Beat Hop",
            "Beat Hop to SS",
            "SS to Beat Saber"});
            this.ConverterList.Location = new System.Drawing.Point(3, 3);
            this.ConverterList.Name = "ConverterList";
            this.ConverterList.Size = new System.Drawing.Size(117, 95);
            this.ConverterList.TabIndex = 0;
            this.ConverterList.SelectedIndexChanged += new System.EventHandler(this.ConverterList_SelectedIndexChanged);
            // 
            // Open
            // 
            this.Open.Enabled = false;
            this.Open.Location = new System.Drawing.Point(126, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(81, 36);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Paste
            // 
            this.Paste.Enabled = false;
            this.Paste.Location = new System.Drawing.Point(213, 3);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(81, 36);
            this.Paste.TabIndex = 2;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Copy
            // 
            this.Copy.Enabled = false;
            this.Copy.Location = new System.Drawing.Point(300, 3);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(81, 36);
            this.Copy.TabIndex = 3;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Export
            // 
            this.Export.Enabled = false;
            this.Export.Location = new System.Drawing.Point(387, 3);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(81, 36);
            this.Export.TabIndex = 4;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Input
            // 
            this.Input.Enabled = false;
            this.Input.Location = new System.Drawing.Point(126, 45);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(168, 96);
            this.Input.TabIndex = 5;
            this.Input.Text = "";
            // 
            // Output
            // 
            this.Output.Enabled = false;
            this.Output.Location = new System.Drawing.Point(300, 45);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(168, 96);
            this.Output.TabIndex = 6;
            this.Output.Text = "";
            // 
            // AudioID
            // 
            this.AudioID.Enabled = false;
            this.AudioID.Location = new System.Drawing.Point(50, 222);
            this.AudioID.Name = "AudioID";
            this.AudioID.Size = new System.Drawing.Size(70, 20);
            this.AudioID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(0, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Audio ID";
            // 
            // Offset
            // 
            this.Offset.Enabled = false;
            this.Offset.Location = new System.Drawing.Point(50, 276);
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(70, 20);
            this.Offset.TabIndex = 9;
            this.Offset.Text = "0";
            // 
            // AudioSpeed
            // 
            this.AudioSpeed.Enabled = false;
            this.AudioSpeed.Location = new System.Drawing.Point(118, 299);
            this.AudioSpeed.Name = "AudioSpeed";
            this.AudioSpeed.Size = new System.Drawing.Size(89, 20);
            this.AudioSpeed.TabIndex = 10;
            this.AudioSpeed.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(0, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Offset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(0, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Audio Speed Multiplier";
            // 
            // Info
            // 
            this.Info.Enabled = false;
            this.Info.Location = new System.Drawing.Point(3, 144);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(117, 72);
            this.Info.TabIndex = 13;
            this.Info.Text = "";
            // 
            // OpenInfo
            // 
            this.OpenInfo.Enabled = false;
            this.OpenInfo.Location = new System.Drawing.Point(3, 102);
            this.OpenInfo.Name = "OpenInfo";
            this.OpenInfo.Size = new System.Drawing.Size(117, 36);
            this.OpenInfo.TabIndex = 14;
            this.OpenInfo.Text = "Open info.dat\r\n(Beat Saber Only)";
            this.OpenInfo.UseVisualStyleBackColor = true;
            this.OpenInfo.Click += new System.EventHandler(this.OpenInfo_Click);
            // 
            // DownloadAudio
            // 
            this.DownloadAudio.Enabled = false;
            this.DownloadAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadAudio.Location = new System.Drawing.Point(3, 248);
            this.DownloadAudio.Name = "DownloadAudio";
            this.DownloadAudio.Size = new System.Drawing.Size(117, 22);
            this.DownloadAudio.TabIndex = 15;
            this.DownloadAudio.Text = "Download Audio";
            this.DownloadAudio.UseVisualStyleBackColor = true;
            this.DownloadAudio.Click += new System.EventHandler(this.DownloadAudio_Click);
            // 
            // Convert
            // 
            this.Convert.Enabled = false;
            this.Convert.Location = new System.Drawing.Point(394, 291);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(74, 28);
            this.Convert.TabIndex = 16;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // SSGuides
            // 
            this.SSGuides.AutoSize = true;
            this.SSGuides.Checked = true;
            this.SSGuides.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SSGuides.Enabled = false;
            this.SSGuides.Location = new System.Drawing.Point(126, 147);
            this.SSGuides.Name = "SSGuides";
            this.SSGuides.Size = new System.Drawing.Size(181, 17);
            this.SSGuides.TabIndex = 17;
            this.SSGuides.Text = "Use Sound Space Guides (OSU)";
            this.SSGuides.UseVisualStyleBackColor = true;
            this.SSGuides.CheckedChanged += new System.EventHandler(this.SSGuides_CheckedChanged);
            // 
            // YOffgridValue
            // 
            this.YOffgridValue.Enabled = false;
            this.YOffgridValue.Location = new System.Drawing.Point(260, 190);
            this.YOffgridValue.Name = "YOffgridValue";
            this.YOffgridValue.Size = new System.Drawing.Size(34, 20);
            this.YOffgridValue.TabIndex = 67;
            this.YOffgridValue.Text = "0.5";
            // 
            // XOffgridValue
            // 
            this.XOffgridValue.Enabled = false;
            this.XOffgridValue.Location = new System.Drawing.Point(260, 167);
            this.XOffgridValue.Name = "XOffgridValue";
            this.XOffgridValue.Size = new System.Drawing.Size(34, 20);
            this.XOffgridValue.TabIndex = 66;
            this.XOffgridValue.Text = "0.5";
            // 
            // YOffgrid
            // 
            this.YOffgrid.AutoSize = true;
            this.YOffgrid.Enabled = false;
            this.YOffgrid.Location = new System.Drawing.Point(126, 193);
            this.YOffgrid.Name = "YOffgrid";
            this.YOffgrid.Size = new System.Drawing.Size(89, 17);
            this.YOffgrid.TabIndex = 65;
            this.YOffgrid.Text = "Y-Axis Offgrid";
            this.YOffgrid.UseVisualStyleBackColor = true;
            this.YOffgrid.CheckedChanged += new System.EventHandler(this.YOffgrid_CheckedChanged);
            // 
            // XOffgrid
            // 
            this.XOffgrid.AutoSize = true;
            this.XOffgrid.Enabled = false;
            this.XOffgrid.Location = new System.Drawing.Point(126, 170);
            this.XOffgrid.Name = "XOffgrid";
            this.XOffgrid.Size = new System.Drawing.Size(89, 17);
            this.XOffgrid.TabIndex = 64;
            this.XOffgrid.Text = "X-Axis Offgrid";
            this.XOffgrid.UseVisualStyleBackColor = true;
            this.XOffgrid.CheckedChanged += new System.EventHandler(this.XOffgrid_CheckedChanged);
            // 
            // RandomQuantum
            // 
            this.RandomQuantum.AutoSize = true;
            this.RandomQuantum.Enabled = false;
            this.RandomQuantum.Location = new System.Drawing.Point(126, 239);
            this.RandomQuantum.Name = "RandomQuantum";
            this.RandomQuantum.Size = new System.Drawing.Size(112, 17);
            this.RandomQuantum.TabIndex = 69;
            this.RandomQuantum.Text = "Random Quantum";
            this.RandomQuantum.UseVisualStyleBackColor = true;
            // 
            // Random
            // 
            this.Random.AutoSize = true;
            this.Random.Enabled = false;
            this.Random.Location = new System.Drawing.Point(126, 216);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(110, 17);
            this.Random.TabIndex = 68;
            this.Random.Text = "Randomize Notes";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.CheckedChanged += new System.EventHandler(this.Random_CheckedChanged);
            // 
            // Difficulty
            // 
            this.Difficulty.Enabled = false;
            this.Difficulty.FormattingEnabled = true;
            this.Difficulty.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Expert"});
            this.Difficulty.Location = new System.Drawing.Point(213, 263);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(77, 56);
            this.Difficulty.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(137, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 26);
            this.label4.TabIndex = 83;
            this.label4.Text = "Track Difficulty\r\n(Clone Hero)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ImageDir
            // 
            this.ImageDir.Enabled = false;
            this.ImageDir.Location = new System.Drawing.Point(300, 267);
            this.ImageDir.Name = "ImageDir";
            this.ImageDir.ReadOnly = true;
            this.ImageDir.Size = new System.Drawing.Size(168, 20);
            this.ImageDir.TabIndex = 100;
            // 
            // SelectImage
            // 
            this.SelectImage.Enabled = false;
            this.SelectImage.Location = new System.Drawing.Point(300, 229);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(168, 35);
            this.SelectImage.TabIndex = 99;
            this.SelectImage.Text = "Select Background Image (Optional)";
            this.SelectImage.UseVisualStyleBackColor = true;
            this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(313, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 104;
            this.label5.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(313, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "Author";
            // 
            // Title
            // 
            this.Title.Enabled = false;
            this.Title.Location = new System.Drawing.Point(300, 203);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(168, 20);
            this.Title.TabIndex = 102;
            // 
            // Author
            // 
            this.Author.Enabled = false;
            this.Author.Location = new System.Drawing.Point(300, 164);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(168, 20);
            this.Author.TabIndex = 101;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenDir
            // 
            this.OpenDir.Location = new System.Drawing.Point(300, 291);
            this.OpenDir.Name = "OpenDir";
            this.OpenDir.Size = new System.Drawing.Size(88, 28);
            this.OpenDir.TabIndex = 105;
            this.OpenDir.Text = "Open Directory";
            this.OpenDir.UseVisualStyleBackColor = true;
            this.OpenDir.Click += new System.EventHandler(this.OpenDir_Click);
            // 
            // BPM
            // 
            this.BPM.Enabled = false;
            this.BPM.Location = new System.Drawing.Point(260, 237);
            this.BPM.Name = "BPM";
            this.BPM.Size = new System.Drawing.Size(34, 20);
            this.BPM.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(264, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 107;
            this.label7.Text = "BPM";
            // 
            // Directions
            // 
            this.Directions.AutoSize = true;
            this.Directions.Enabled = false;
            this.Directions.Location = new System.Drawing.Point(361, 144);
            this.Directions.Name = "Directions";
            this.Directions.Size = new System.Drawing.Size(107, 17);
            this.Directions.TabIndex = 115;
            this.Directions.Text = "Directional Notes";
            this.Directions.UseVisualStyleBackColor = true;
            // 
            // Format_Converters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 322);
            this.Controls.Add(this.Directions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BPM);
            this.Controls.Add(this.OpenDir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.ImageDir);
            this.Controls.Add(this.SelectImage);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RandomQuantum);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.YOffgridValue);
            this.Controls.Add(this.XOffgridValue);
            this.Controls.Add(this.YOffgrid);
            this.Controls.Add(this.XOffgrid);
            this.Controls.Add(this.SSGuides);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.DownloadAudio);
            this.Controls.Add(this.OpenInfo);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AudioSpeed);
            this.Controls.Add(this.Offset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AudioID);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.ConverterList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Format_Converters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ConverterList;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.TextBox AudioID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Offset;
        private System.Windows.Forms.TextBox AudioSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Info;
        private System.Windows.Forms.Button OpenInfo;
        private System.Windows.Forms.Button DownloadAudio;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.CheckBox SSGuides;
        private System.Windows.Forms.TextBox YOffgridValue;
        private System.Windows.Forms.TextBox XOffgridValue;
        private System.Windows.Forms.CheckBox YOffgrid;
        private System.Windows.Forms.CheckBox XOffgrid;
        private System.Windows.Forms.CheckBox RandomQuantum;
        private System.Windows.Forms.CheckBox Random;
        private System.Windows.Forms.ListBox Difficulty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ImageDir;
        private System.Windows.Forms.Button SelectImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenDir;
        private System.Windows.Forms.TextBox BPM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Directions;
    }
}