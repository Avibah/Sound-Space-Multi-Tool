namespace SS_Multi_Tool
{
    partial class BS_SS_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BS_SS_Converter));
            this.AdjustValue = new System.Windows.Forms.TextBox();
            this.Adjust = new System.Windows.Forms.CheckBox();
            this.RandomQuantum = new System.Windows.Forms.CheckBox();
            this.Random = new System.Windows.Forms.CheckBox();
            this.ZBound = new System.Windows.Forms.CheckBox();
            this.YOffgridValue = new System.Windows.Forms.TextBox();
            this.XOffgridValue = new System.Windows.Forms.TextBox();
            this.Copy = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.InfoFile = new System.Windows.Forms.RichTextBox();
            this.OpenInfo = new System.Windows.Forms.Button();
            this.Beatmap = new System.Windows.Forms.RichTextBox();
            this.OpenBeatmap = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.AudioID = new System.Windows.Forms.TextBox();
            this.Info = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Offset = new System.Windows.Forms.TextBox();
            this.AudioSpeed = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.Playable = new System.Windows.Forms.CheckBox();
            this.YOffgrid = new System.Windows.Forms.CheckBox();
            this.XOffgrid = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // AdjustValue
            // 
            this.AdjustValue.Enabled = false;
            this.AdjustValue.Location = new System.Drawing.Point(357, 178);
            this.AdjustValue.Name = "AdjustValue";
            this.AdjustValue.Size = new System.Drawing.Size(90, 20);
            this.AdjustValue.TabIndex = 60;
            this.AdjustValue.Text = "50";
            // 
            // Adjust
            // 
            this.Adjust.AutoSize = true;
            this.Adjust.Enabled = false;
            this.Adjust.Location = new System.Drawing.Point(357, 158);
            this.Adjust.Name = "Adjust";
            this.Adjust.Size = new System.Drawing.Size(86, 17);
            this.Adjust.TabIndex = 59;
            this.Adjust.Text = "Adjust Notes";
            this.Adjust.UseVisualStyleBackColor = true;
            this.Adjust.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // RandomQuantum
            // 
            this.RandomQuantum.AutoSize = true;
            this.RandomQuantum.Enabled = false;
            this.RandomQuantum.Location = new System.Drawing.Point(241, 158);
            this.RandomQuantum.Name = "RandomQuantum";
            this.RandomQuantum.Size = new System.Drawing.Size(112, 17);
            this.RandomQuantum.TabIndex = 58;
            this.RandomQuantum.Text = "Random Quantum";
            this.RandomQuantum.UseVisualStyleBackColor = true;
            // 
            // Random
            // 
            this.Random.AutoSize = true;
            this.Random.Location = new System.Drawing.Point(241, 139);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(110, 17);
            this.Random.TabIndex = 57;
            this.Random.Text = "Randomize Notes";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // ZBound
            // 
            this.ZBound.AutoSize = true;
            this.ZBound.Enabled = false;
            this.ZBound.Location = new System.Drawing.Point(120, 174);
            this.ZBound.Name = "ZBound";
            this.ZBound.Size = new System.Drawing.Size(115, 17);
            this.ZBound.TabIndex = 56;
            this.ZBound.Text = "Zero-Based Offgrid";
            this.ZBound.UseVisualStyleBackColor = true;
            // 
            // YOffgridValue
            // 
            this.YOffgridValue.Enabled = false;
            this.YOffgridValue.Location = new System.Drawing.Point(205, 149);
            this.YOffgridValue.Name = "YOffgridValue";
            this.YOffgridValue.Size = new System.Drawing.Size(34, 20);
            this.YOffgridValue.TabIndex = 55;
            this.YOffgridValue.Text = "0.5";
            // 
            // XOffgridValue
            // 
            this.XOffgridValue.Enabled = false;
            this.XOffgridValue.Location = new System.Drawing.Point(205, 123);
            this.XOffgridValue.Name = "XOffgridValue";
            this.XOffgridValue.Size = new System.Drawing.Size(34, 20);
            this.XOffgridValue.TabIndex = 54;
            this.XOffgridValue.Text = "0.5";
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(237, 3);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(104, 36);
            this.Copy.TabIndex = 53;
            this.Copy.Text = "Copy Data";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(343, 3);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(104, 36);
            this.Export.TabIndex = 52;
            this.Export.Text = "Export to .txt";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Output";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(237, 45);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(210, 75);
            this.Output.TabIndex = 50;
            this.Output.Text = "";
            // 
            // InfoFile
            // 
            this.InfoFile.Location = new System.Drawing.Point(120, 45);
            this.InfoFile.Name = "InfoFile";
            this.InfoFile.Size = new System.Drawing.Size(111, 75);
            this.InfoFile.TabIndex = 49;
            this.InfoFile.Text = "";
            // 
            // OpenInfo
            // 
            this.OpenInfo.Location = new System.Drawing.Point(120, 3);
            this.OpenInfo.Name = "OpenInfo";
            this.OpenInfo.Size = new System.Drawing.Size(111, 36);
            this.OpenInfo.TabIndex = 48;
            this.OpenInfo.Text = "Open Info";
            this.OpenInfo.UseVisualStyleBackColor = true;
            this.OpenInfo.Click += new System.EventHandler(this.OpenInfo_Click);
            // 
            // Beatmap
            // 
            this.Beatmap.Location = new System.Drawing.Point(3, 45);
            this.Beatmap.Name = "Beatmap";
            this.Beatmap.Size = new System.Drawing.Size(111, 75);
            this.Beatmap.TabIndex = 47;
            this.Beatmap.Text = "";
            // 
            // OpenBeatmap
            // 
            this.OpenBeatmap.Location = new System.Drawing.Point(2, 3);
            this.OpenBeatmap.Name = "OpenBeatmap";
            this.OpenBeatmap.Size = new System.Drawing.Size(112, 36);
            this.OpenBeatmap.TabIndex = 46;
            this.OpenBeatmap.Text = "Open Beatmap";
            this.OpenBeatmap.UseVisualStyleBackColor = true;
            this.OpenBeatmap.Click += new System.EventHandler(this.OpenBeatmap_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(245, 215);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(202, 22);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Audio ID";
            // 
            // AudioID
            // 
            this.AudioID.Location = new System.Drawing.Point(5, 139);
            this.AudioID.Name = "AudioID";
            this.AudioID.Size = new System.Drawing.Size(109, 20);
            this.AudioID.TabIndex = 43;
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(120, 214);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(23, 23);
            this.Info.TabIndex = 42;
            this.Info.Text = "?";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Offset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Audio Speed Multiplier";
            // 
            // Offset
            // 
            this.Offset.Location = new System.Drawing.Point(5, 178);
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(108, 20);
            this.Offset.TabIndex = 39;
            this.Offset.Text = "0";
            // 
            // AudioSpeed
            // 
            this.AudioSpeed.Location = new System.Drawing.Point(5, 217);
            this.AudioSpeed.Name = "AudioSpeed";
            this.AudioSpeed.Size = new System.Drawing.Size(108, 20);
            this.AudioSpeed.TabIndex = 38;
            this.AudioSpeed.Text = "1";
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(149, 215);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(90, 23);
            this.Convert.TabIndex = 37;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Playable
            // 
            this.Playable.AutoSize = true;
            this.Playable.Location = new System.Drawing.Point(357, 139);
            this.Playable.Name = "Playable";
            this.Playable.Size = new System.Drawing.Size(90, 17);
            this.Playable.TabIndex = 36;
            this.Playable.Text = "Fully Playable";
            this.Playable.UseVisualStyleBackColor = true;
            this.Playable.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // YOffgrid
            // 
            this.YOffgrid.AutoSize = true;
            this.YOffgrid.Location = new System.Drawing.Point(120, 151);
            this.YOffgrid.Name = "YOffgrid";
            this.YOffgrid.Size = new System.Drawing.Size(89, 17);
            this.YOffgrid.TabIndex = 35;
            this.YOffgrid.Text = "Y-Axis Offgrid";
            this.YOffgrid.UseVisualStyleBackColor = true;
            this.YOffgrid.CheckedChanged += new System.EventHandler(this.YOffgrid_CheckedChanged);
            // 
            // XOffgrid
            // 
            this.XOffgrid.AutoSize = true;
            this.XOffgrid.Location = new System.Drawing.Point(120, 126);
            this.XOffgrid.Name = "XOffgrid";
            this.XOffgrid.Size = new System.Drawing.Size(89, 17);
            this.XOffgrid.TabIndex = 34;
            this.XOffgrid.Text = "X-Axis Offgrid";
            this.XOffgrid.UseVisualStyleBackColor = true;
            this.XOffgrid.CheckedChanged += new System.EventHandler(this.XOffgrid_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BS_SS_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 240);
            this.Controls.Add(this.AdjustValue);
            this.Controls.Add(this.Adjust);
            this.Controls.Add(this.RandomQuantum);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.ZBound);
            this.Controls.Add(this.YOffgridValue);
            this.Controls.Add(this.XOffgridValue);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.InfoFile);
            this.Controls.Add(this.OpenInfo);
            this.Controls.Add(this.Beatmap);
            this.Controls.Add(this.OpenBeatmap);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AudioID);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Offset);
            this.Controls.Add(this.AudioSpeed);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Playable);
            this.Controls.Add(this.YOffgrid);
            this.Controls.Add(this.XOffgrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BS_SS_Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdjustValue;
        private System.Windows.Forms.CheckBox Adjust;
        private System.Windows.Forms.CheckBox RandomQuantum;
        private System.Windows.Forms.CheckBox Random;
        private System.Windows.Forms.CheckBox ZBound;
        private System.Windows.Forms.TextBox YOffgridValue;
        private System.Windows.Forms.TextBox XOffgridValue;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.RichTextBox InfoFile;
        private System.Windows.Forms.Button OpenInfo;
        private System.Windows.Forms.RichTextBox Beatmap;
        private System.Windows.Forms.Button OpenBeatmap;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AudioID;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Offset;
        private System.Windows.Forms.TextBox AudioSpeed;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.CheckBox Playable;
        private System.Windows.Forms.CheckBox YOffgrid;
        private System.Windows.Forms.CheckBox XOffgrid;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}