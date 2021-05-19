namespace SS_Multi_Tool
{
    partial class NPS_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NPS_Calculator));
            this.AvgNPS = new System.Windows.Forms.CheckBox();
            this.Start = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.HighestNPS = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SetLimits = new System.Windows.Forms.CheckBox();
            this.SectionEnd = new System.Windows.Forms.TextBox();
            this.SectionStart = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AvgNPS
            // 
            this.AvgNPS.AutoSize = true;
            this.AvgNPS.Location = new System.Drawing.Point(21, 186);
            this.AvgNPS.Name = "AvgNPS";
            this.AvgNPS.Size = new System.Drawing.Size(113, 17);
            this.AvgNPS.TabIndex = 22;
            this.AvgNPS.Text = "Find average NPS";
            this.AvgNPS.UseVisualStyleBackColor = true;
            this.AvgNPS.CheckedChanged += new System.EventHandler(this.AvgNPS_CheckedChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(3, 131);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(146, 23);
            this.Start.TabIndex = 21;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(79, 3);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(70, 38);
            this.Paste.TabIndex = 20;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(3, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(70, 38);
            this.Open.TabIndex = 19;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(3, 160);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(146, 20);
            this.Output.TabIndex = 18;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(3, 47);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(146, 78);
            this.Input.TabIndex = 17;
            this.Input.Text = "";
            // 
            // HighestNPS
            // 
            this.HighestNPS.AutoSize = true;
            this.HighestNPS.Checked = true;
            this.HighestNPS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HighestNPS.Location = new System.Drawing.Point(21, 209);
            this.HighestNPS.Name = "HighestNPS";
            this.HighestNPS.Size = new System.Drawing.Size(108, 17);
            this.HighestNPS.TabIndex = 23;
            this.HighestNPS.Text = "Find highest NPS";
            this.HighestNPS.UseVisualStyleBackColor = true;
            this.HighestNPS.CheckedChanged += new System.EventHandler(this.HighestNPS_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Section End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Section Start";
            // 
            // SetLimits
            // 
            this.SetLimits.AutoSize = true;
            this.SetLimits.Location = new System.Drawing.Point(21, 232);
            this.SetLimits.Name = "SetLimits";
            this.SetLimits.Size = new System.Drawing.Size(104, 17);
            this.SetLimits.TabIndex = 26;
            this.SetLimits.Text = "Set section limits";
            this.SetLimits.UseVisualStyleBackColor = true;
            this.SetLimits.CheckedChanged += new System.EventHandler(this.SetLimits_CheckedChanged);
            // 
            // SectionEnd
            // 
            this.SectionEnd.Enabled = false;
            this.SectionEnd.Location = new System.Drawing.Point(79, 256);
            this.SectionEnd.Name = "SectionEnd";
            this.SectionEnd.Size = new System.Drawing.Size(70, 20);
            this.SectionEnd.TabIndex = 25;
            // 
            // SectionStart
            // 
            this.SectionStart.Enabled = false;
            this.SectionStart.Location = new System.Drawing.Point(3, 256);
            this.SectionStart.Name = "SectionStart";
            this.SectionStart.Size = new System.Drawing.Size(70, 20);
            this.SectionStart.TabIndex = 24;
            // 
            // NPS_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetLimits);
            this.Controls.Add(this.SectionEnd);
            this.Controls.Add(this.SectionStart);
            this.Controls.Add(this.HighestNPS);
            this.Controls.Add(this.AvgNPS);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NPS_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AvgNPS;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.CheckBox HighestNPS;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SetLimits;
        private System.Windows.Forms.TextBox SectionEnd;
        private System.Windows.Forms.TextBox SectionStart;
    }
}