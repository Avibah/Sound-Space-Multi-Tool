namespace SS_Multi_Tool
{
    partial class Highest_BPM_Identifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Highest_BPM_Identifier));
            this.Disclaimer = new System.Windows.Forms.RichTextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SectionStart = new System.Windows.Forms.TextBox();
            this.SectionEnd = new System.Windows.Forms.TextBox();
            this.SetLimits = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Disclaimer
            // 
            this.Disclaimer.Enabled = false;
            this.Disclaimer.Location = new System.Drawing.Point(155, 2);
            this.Disclaimer.Name = "Disclaimer";
            this.Disclaimer.Size = new System.Drawing.Size(124, 243);
            this.Disclaimer.TabIndex = 13;
            this.Disclaimer.Text = "This program may be slightly inaccurate due to timestamps being rounded in map da" +
    "ta\n\n\nAll results assume the map\'s fastest portions are spirals so double the res" +
    "ulting BPM if the map has no spirals";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(3, 130);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(146, 23);
            this.Start.TabIndex = 12;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(79, 2);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(70, 38);
            this.Paste.TabIndex = 11;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(3, 2);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(70, 38);
            this.Open.TabIndex = 10;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(3, 159);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(146, 20);
            this.Output.TabIndex = 9;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(3, 46);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(146, 78);
            this.Input.TabIndex = 8;
            this.Input.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SectionStart
            // 
            this.SectionStart.Enabled = false;
            this.SectionStart.Location = new System.Drawing.Point(3, 209);
            this.SectionStart.Name = "SectionStart";
            this.SectionStart.Size = new System.Drawing.Size(70, 20);
            this.SectionStart.TabIndex = 14;
            // 
            // SectionEnd
            // 
            this.SectionEnd.Enabled = false;
            this.SectionEnd.Location = new System.Drawing.Point(79, 209);
            this.SectionEnd.Name = "SectionEnd";
            this.SectionEnd.Size = new System.Drawing.Size(70, 20);
            this.SectionEnd.TabIndex = 15;
            // 
            // SetLimits
            // 
            this.SetLimits.AutoSize = true;
            this.SetLimits.Location = new System.Drawing.Point(24, 185);
            this.SetLimits.Name = "SetLimits";
            this.SetLimits.Size = new System.Drawing.Size(104, 17);
            this.SetLimits.TabIndex = 16;
            this.SetLimits.Text = "Set section limits";
            this.SetLimits.UseVisualStyleBackColor = true;
            this.SetLimits.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Section Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Section End";
            // 
            // Highest_BPM_Identifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 248);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetLimits);
            this.Controls.Add(this.SectionEnd);
            this.Controls.Add(this.SectionStart);
            this.Controls.Add(this.Disclaimer);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Highest_BPM_Identifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Disclaimer;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox SectionStart;
        private System.Windows.Forms.TextBox SectionEnd;
        private System.Windows.Forms.CheckBox SetLimits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}