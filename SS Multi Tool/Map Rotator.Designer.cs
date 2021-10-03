namespace SS_Multi_Tool
{
    partial class Map_Rotator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map_Rotator));
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Open = new System.Windows.Forms.Button();
            this.Rotate = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.Degrees = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(80, 3);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(70, 38);
            this.Paste.TabIndex = 36;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(156, 3);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(70, 38);
            this.Copy.TabIndex = 35;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(233, 3);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(70, 38);
            this.Export.TabIndex = 34;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(156, 47);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(147, 78);
            this.Output.TabIndex = 33;
            this.Output.Text = "";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(3, 47);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(147, 78);
            this.Input.TabIndex = 32;
            this.Input.Text = "";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(3, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(70, 38);
            this.Open.TabIndex = 31;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Rotate
            // 
            this.Rotate.Location = new System.Drawing.Point(233, 128);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(70, 36);
            this.Rotate.TabIndex = 39;
            this.Rotate.Text = "Rotate";
            this.Rotate.UseVisualStyleBackColor = true;
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Degrees";
            // 
            // Degrees
            // 
            this.Degrees.Location = new System.Drawing.Point(80, 128);
            this.Degrees.Name = "Degrees";
            this.Degrees.Size = new System.Drawing.Size(70, 20);
            this.Degrees.TabIndex = 41;
            this.Degrees.Text = "0";
            // 
            // Map_Rotator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 167);
            this.Controls.Add(this.Degrees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rotate);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Map_Rotator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Rotate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Degrees;
    }
}