namespace SS_Multi_Tool
{
    partial class CH_Timings_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CH_Timings_Converter));
            this.ConvertOSU = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ConvertMS = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.OffsetLabel = new System.Windows.Forms.Label();
            this.Offset = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConvertOSU
            // 
            this.ConvertOSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.ConvertOSU.Location = new System.Drawing.Point(3, 130);
            this.ConvertOSU.Name = "ConvertOSU";
            this.ConvertOSU.Size = new System.Drawing.Size(93, 38);
            this.ConvertOSU.TabIndex = 85;
            this.ConvertOSU.Text = "Convert to OSU Timings";
            this.ConvertOSU.UseVisualStyleBackColor = true;
            this.ConvertOSU.Click += new System.EventHandler(this.ConvertOSU_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(3, 494);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(193, 38);
            this.Copy.TabIndex = 83;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ConvertMS
            // 
            this.ConvertMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.ConvertMS.Location = new System.Drawing.Point(103, 130);
            this.ConvertMS.Name = "ConvertMS";
            this.ConvertMS.Size = new System.Drawing.Size(93, 38);
            this.ConvertMS.TabIndex = 87;
            this.ConvertMS.Text = "Convert to MS + BPM";
            this.ConvertMS.UseVisualStyleBackColor = true;
            this.ConvertMS.Click += new System.EventHandler(this.ConvertMS_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(3, 2);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(93, 38);
            this.Open.TabIndex = 90;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(103, 2);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(93, 38);
            this.Paste.TabIndex = 89;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(3, 46);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(193, 78);
            this.Input.TabIndex = 88;
            this.Input.Text = "";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(3, 174);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(193, 288);
            this.Output.TabIndex = 91;
            this.Output.Text = "";
            // 
            // OffsetLabel
            // 
            this.OffsetLabel.AutoSize = true;
            this.OffsetLabel.Location = new System.Drawing.Point(13, 471);
            this.OffsetLabel.Name = "OffsetLabel";
            this.OffsetLabel.Size = new System.Drawing.Size(35, 13);
            this.OffsetLabel.TabIndex = 95;
            this.OffsetLabel.Text = "Offset";
            // 
            // Offset
            // 
            this.Offset.Location = new System.Drawing.Point(54, 468);
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(142, 20);
            this.Offset.TabIndex = 94;
            // 
            // CH_Timings_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 535);
            this.Controls.Add(this.OffsetLabel);
            this.Controls.Add(this.Offset);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.ConvertMS);
            this.Controls.Add(this.ConvertOSU);
            this.Controls.Add(this.Copy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CH_Timings_Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConvertOSU;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ConvertMS;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Label OffsetLabel;
        private System.Windows.Forms.TextBox Offset;
    }
}