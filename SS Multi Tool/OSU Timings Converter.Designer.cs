namespace SS_Multi_Tool
{
    partial class OSU_Timings_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OSU_Timings_Converter));
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Open = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.OffsetLabel = new System.Windows.Forms.Label();
            this.Offset = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(3, 47);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(193, 78);
            this.Input.TabIndex = 0;
            this.Input.Text = "";
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(103, 3);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(93, 38);
            this.Paste.TabIndex = 2;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(3, 491);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(193, 38);
            this.Copy.TabIndex = 3;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(3, 131);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(193, 38);
            this.Convert.TabIndex = 4;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(3, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(93, 38);
            this.Open.TabIndex = 5;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(3, 175);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(193, 288);
            this.Output.TabIndex = 85;
            this.Output.Text = "";
            // 
            // OffsetLabel
            // 
            this.OffsetLabel.AutoSize = true;
            this.OffsetLabel.Location = new System.Drawing.Point(13, 468);
            this.OffsetLabel.Name = "OffsetLabel";
            this.OffsetLabel.Size = new System.Drawing.Size(35, 13);
            this.OffsetLabel.TabIndex = 95;
            this.OffsetLabel.Text = "Offset";
            // 
            // Offset
            // 
            this.Offset.Location = new System.Drawing.Point(54, 465);
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(142, 20);
            this.Offset.TabIndex = 94;
            // 
            // OSU_Timings_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 532);
            this.Controls.Add(this.OffsetLabel);
            this.Controls.Add(this.Offset);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OSU_Timings_Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Label OffsetLabel;
        private System.Windows.Forms.TextBox Offset;
    }
}