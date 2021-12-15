namespace SS_Multi_Tool
{
    partial class ADOFAI_Timings_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADOFAI_Timings_Converter));
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Open = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Offset = new System.Windows.Forms.TextBox();
            this.OffsetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(2, 174);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(193, 288);
            this.Output.TabIndex = 91;
            this.Output.Text = "";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(2, 2);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(93, 38);
            this.Open.TabIndex = 90;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(2, 130);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(193, 38);
            this.Convert.TabIndex = 89;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(2, 494);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(193, 38);
            this.Copy.TabIndex = 88;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(102, 2);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(93, 38);
            this.Paste.TabIndex = 87;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(2, 46);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(193, 78);
            this.Input.TabIndex = 86;
            this.Input.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Offset
            // 
            this.Offset.Location = new System.Drawing.Point(53, 468);
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(142, 20);
            this.Offset.TabIndex = 92;
            // 
            // OffsetLabel
            // 
            this.OffsetLabel.AutoSize = true;
            this.OffsetLabel.Location = new System.Drawing.Point(12, 471);
            this.OffsetLabel.Name = "OffsetLabel";
            this.OffsetLabel.Size = new System.Drawing.Size(35, 13);
            this.OffsetLabel.TabIndex = 93;
            this.OffsetLabel.Text = "Offset";
            // 
            // ADOFAI_Timings_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 534);
            this.Controls.Add(this.OffsetLabel);
            this.Controls.Add(this.Offset);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADOFAI_Timings_Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Offset;
        private System.Windows.Forms.Label OffsetLabel;
    }
}