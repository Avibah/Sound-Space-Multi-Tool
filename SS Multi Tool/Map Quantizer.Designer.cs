namespace SS_Multi_Tool
{
    partial class Map_Quantizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map_Quantizer));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Open = new System.Windows.Forms.Button();
            this.BPM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DivisorLabel = new System.Windows.Forms.Label();
            this.Divisor = new System.Windows.Forms.TrackBar();
            this.Quantize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Divisor)).BeginInit();
            this.SuspendLayout();
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
            this.Paste.TabIndex = 36;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(155, 3);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(70, 38);
            this.Copy.TabIndex = 35;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(232, 3);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(70, 38);
            this.Export.TabIndex = 34;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(155, 47);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(147, 78);
            this.Output.TabIndex = 33;
            this.Output.Text = "";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(2, 47);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(147, 78);
            this.Input.TabIndex = 32;
            this.Input.Text = "";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(2, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(70, 38);
            this.Open.TabIndex = 31;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click_1);
            // 
            // BPM
            // 
            this.BPM.Location = new System.Drawing.Point(2, 145);
            this.BPM.Name = "BPM";
            this.BPM.Size = new System.Drawing.Size(70, 20);
            this.BPM.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "BPM";
            // 
            // DivisorLabel
            // 
            this.DivisorLabel.AutoSize = true;
            this.DivisorLabel.Location = new System.Drawing.Point(91, 148);
            this.DivisorLabel.Name = "DivisorLabel";
            this.DivisorLabel.Size = new System.Drawing.Size(54, 13);
            this.DivisorLabel.TabIndex = 40;
            this.DivisorLabel.Text = "Divisor - 8";
            // 
            // Divisor
            // 
            this.Divisor.LargeChange = 1;
            this.Divisor.Location = new System.Drawing.Point(155, 131);
            this.Divisor.Maximum = 16;
            this.Divisor.Minimum = 1;
            this.Divisor.Name = "Divisor";
            this.Divisor.Size = new System.Drawing.Size(147, 45);
            this.Divisor.TabIndex = 41;
            this.Divisor.Value = 8;
            this.Divisor.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Quantize
            // 
            this.Quantize.Location = new System.Drawing.Point(155, 171);
            this.Quantize.Name = "Quantize";
            this.Quantize.Size = new System.Drawing.Size(147, 38);
            this.Quantize.TabIndex = 42;
            this.Quantize.Text = "Quantize";
            this.Quantize.UseVisualStyleBackColor = true;
            this.Quantize.Click += new System.EventHandler(this.Quantize_Click);
            // 
            // Map_Quantizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 212);
            this.Controls.Add(this.Quantize);
            this.Controls.Add(this.Divisor);
            this.Controls.Add(this.DivisorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BPM);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Map_Quantizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Divisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox BPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DivisorLabel;
        private System.Windows.Forms.TrackBar Divisor;
        private System.Windows.Forms.Button Quantize;
    }
}