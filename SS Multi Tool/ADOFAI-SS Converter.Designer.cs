namespace SS_Multi_Tool
{
    partial class ADOFAI_SS_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADOFAI_SS_Converter));
            this.DownloadAudio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AudioID = new System.Windows.Forms.TextBox();
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Open = new System.Windows.Forms.Button();
            this.YOffgridValue = new System.Windows.Forms.TextBox();
            this.XOffgridValue = new System.Windows.Forms.TextBox();
            this.YOffgrid = new System.Windows.Forms.CheckBox();
            this.XOffgrid = new System.Windows.Forms.CheckBox();
            this.RandomQuantum = new System.Windows.Forms.CheckBox();
            this.Random = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AudioSpeed = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // DownloadAudio
            // 
            this.DownloadAudio.Location = new System.Drawing.Point(64, 130);
            this.DownloadAudio.Name = "DownloadAudio";
            this.DownloadAudio.Size = new System.Drawing.Size(85, 23);
            this.DownloadAudio.TabIndex = 72;
            this.DownloadAudio.Text = "Download";
            this.DownloadAudio.UseVisualStyleBackColor = true;
            this.DownloadAudio.Click += new System.EventHandler(this.DownloadAudio_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Audio ID";
            // 
            // AudioID
            // 
            this.AudioID.Location = new System.Drawing.Point(2, 159);
            this.AudioID.Name = "AudioID";
            this.AudioID.Size = new System.Drawing.Size(147, 20);
            this.AudioID.TabIndex = 70;
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(79, 2);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(70, 38);
            this.Paste.TabIndex = 78;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(155, 2);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(70, 38);
            this.Copy.TabIndex = 77;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(232, 2);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(70, 38);
            this.Export.TabIndex = 76;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(155, 46);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(147, 78);
            this.Output.TabIndex = 75;
            this.Output.Text = "";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(2, 46);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(147, 78);
            this.Input.TabIndex = 74;
            this.Input.Text = "";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(2, 2);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(70, 38);
            this.Open.TabIndex = 73;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // YOffgridValue
            // 
            this.YOffgridValue.Enabled = false;
            this.YOffgridValue.Location = new System.Drawing.Point(268, 156);
            this.YOffgridValue.Name = "YOffgridValue";
            this.YOffgridValue.Size = new System.Drawing.Size(34, 20);
            this.YOffgridValue.TabIndex = 82;
            this.YOffgridValue.Text = "0.5";
            // 
            // XOffgridValue
            // 
            this.XOffgridValue.Enabled = false;
            this.XOffgridValue.Location = new System.Drawing.Point(268, 130);
            this.XOffgridValue.Name = "XOffgridValue";
            this.XOffgridValue.Size = new System.Drawing.Size(34, 20);
            this.XOffgridValue.TabIndex = 81;
            this.XOffgridValue.Text = "0.5";
            // 
            // YOffgrid
            // 
            this.YOffgrid.AutoSize = true;
            this.YOffgrid.Location = new System.Drawing.Point(163, 158);
            this.YOffgrid.Name = "YOffgrid";
            this.YOffgrid.Size = new System.Drawing.Size(89, 17);
            this.YOffgrid.TabIndex = 80;
            this.YOffgrid.Text = "Y-Axis Offgrid";
            this.YOffgrid.UseVisualStyleBackColor = true;
            this.YOffgrid.CheckedChanged += new System.EventHandler(this.YOffgrid_CheckedChanged);
            // 
            // XOffgrid
            // 
            this.XOffgrid.AutoSize = true;
            this.XOffgrid.Location = new System.Drawing.Point(163, 133);
            this.XOffgrid.Name = "XOffgrid";
            this.XOffgrid.Size = new System.Drawing.Size(89, 17);
            this.XOffgrid.TabIndex = 79;
            this.XOffgrid.Text = "X-Axis Offgrid";
            this.XOffgrid.UseVisualStyleBackColor = true;
            this.XOffgrid.CheckedChanged += new System.EventHandler(this.XOffgrid_CheckedChanged);
            // 
            // RandomQuantum
            // 
            this.RandomQuantum.AutoSize = true;
            this.RandomQuantum.Enabled = false;
            this.RandomQuantum.Location = new System.Drawing.Point(163, 204);
            this.RandomQuantum.Name = "RandomQuantum";
            this.RandomQuantum.Size = new System.Drawing.Size(112, 17);
            this.RandomQuantum.TabIndex = 84;
            this.RandomQuantum.Text = "Random Quantum";
            this.RandomQuantum.UseVisualStyleBackColor = true;
            // 
            // Random
            // 
            this.Random.AutoSize = true;
            this.Random.Location = new System.Drawing.Point(163, 181);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(110, 17);
            this.Random.TabIndex = 83;
            this.Random.Text = "Randomize Notes";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.CheckedChanged += new System.EventHandler(this.Random_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Audio Speed Multiplier";
            // 
            // AudioSpeed
            // 
            this.AudioSpeed.Location = new System.Drawing.Point(2, 202);
            this.AudioSpeed.Name = "AudioSpeed";
            this.AudioSpeed.Size = new System.Drawing.Size(147, 20);
            this.AudioSpeed.TabIndex = 85;
            this.AudioSpeed.Text = "1";
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(2, 228);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(300, 38);
            this.Convert.TabIndex = 87;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ADOFAI_SS_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 268);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AudioSpeed);
            this.Controls.Add(this.RandomQuantum);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.YOffgridValue);
            this.Controls.Add(this.XOffgridValue);
            this.Controls.Add(this.YOffgrid);
            this.Controls.Add(this.XOffgrid);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.DownloadAudio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AudioID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADOFAI_SS_Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DownloadAudio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AudioID;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox YOffgridValue;
        private System.Windows.Forms.TextBox XOffgridValue;
        private System.Windows.Forms.CheckBox YOffgrid;
        private System.Windows.Forms.CheckBox XOffgrid;
        private System.Windows.Forms.CheckBox RandomQuantum;
        private System.Windows.Forms.CheckBox Random;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AudioSpeed;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}