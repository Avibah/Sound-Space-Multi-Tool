namespace SS_Multi_Tool
{
    partial class Beat_Hop_Mirrorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beat_Hop_Mirrorer));
            this.Mirror = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Export = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mirror
            // 
            this.Mirror.Location = new System.Drawing.Point(3, 148);
            this.Mirror.Name = "Mirror";
            this.Mirror.Size = new System.Drawing.Size(258, 23);
            this.Mirror.TabIndex = 13;
            this.Mirror.Text = "Mirror";
            this.Mirror.UseVisualStyleBackColor = true;
            this.Mirror.Click += new System.EventHandler(this.button5_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(135, 46);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(126, 96);
            this.Output.TabIndex = 12;
            this.Output.Text = "";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(3, 46);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(126, 96);
            this.Input.TabIndex = 11;
            this.Input.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(201, 2);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(60, 38);
            this.Export.TabIndex = 17;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(135, 2);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(60, 38);
            this.Copy.TabIndex = 16;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(69, 2);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(60, 38);
            this.Paste.TabIndex = 15;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(3, 2);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(60, 38);
            this.Open.TabIndex = 14;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Beat_Hop_Mirrorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 174);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Mirror);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Beat_Hop_Mirrorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Mirror;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Open;
    }
}