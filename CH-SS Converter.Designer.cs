namespace Program_Launcher
{
    partial class CH_SS_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CH_SS_Converter));
            this.DoubleChart = new System.Windows.Forms.CheckBox();
            this.Difficulty = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Convert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AudioID = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoubleChart
            // 
            this.DoubleChart.AutoSize = true;
            this.DoubleChart.Location = new System.Drawing.Point(2, 215);
            this.DoubleChart.Name = "DoubleChart";
            this.DoubleChart.Size = new System.Drawing.Size(119, 17);
            this.DoubleChart.TabIndex = 83;
            this.DoubleChart.Text = "Double Guitar Chart";
            this.DoubleChart.UseVisualStyleBackColor = true;
            // 
            // Difficulty
            // 
            this.Difficulty.FormattingEnabled = true;
            this.Difficulty.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Expert"});
            this.Difficulty.Location = new System.Drawing.Point(2, 153);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(147, 56);
            this.Difficulty.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Track Difficulty";
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(232, 202);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(70, 30);
            this.Convert.TabIndex = 79;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Audio ID";
            // 
            // AudioID
            // 
            this.AudioID.Location = new System.Drawing.Point(155, 150);
            this.AudioID.Name = "AudioID";
            this.AudioID.Size = new System.Drawing.Size(147, 20);
            this.AudioID.TabIndex = 77;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(79, 3);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(70, 38);
            this.Paste.TabIndex = 89;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(155, 3);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(70, 38);
            this.Copy.TabIndex = 88;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(232, 3);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(70, 38);
            this.Export.TabIndex = 87;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(155, 47);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(147, 78);
            this.Output.TabIndex = 86;
            this.Output.Text = "";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(2, 47);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(147, 78);
            this.Input.TabIndex = 85;
            this.Input.Text = "";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(2, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(70, 38);
            this.Open.TabIndex = 84;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // CH_SS_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 236);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.DoubleChart);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AudioID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CH_SS_Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DoubleChart;
        private System.Windows.Forms.ListBox Difficulty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AudioID;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button Open;
    }
}