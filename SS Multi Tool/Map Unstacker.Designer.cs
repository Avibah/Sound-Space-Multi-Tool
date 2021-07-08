namespace SS_Multi_Tool
{
    partial class Map_Unstacker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map_Unstacker));
            this.Unstack = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Open = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Unstack
            // 
            this.Unstack.Location = new System.Drawing.Point(4, 131);
            this.Unstack.Name = "Unstack";
            this.Unstack.Size = new System.Drawing.Size(300, 38);
            this.Unstack.TabIndex = 53;
            this.Unstack.Text = "Unstack";
            this.Unstack.UseVisualStyleBackColor = true;
            this.Unstack.Click += new System.EventHandler(this.Unstack_Click);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(81, 3);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(70, 38);
            this.Paste.TabIndex = 52;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(157, 3);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(70, 38);
            this.Copy.TabIndex = 51;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(234, 3);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(70, 38);
            this.Export.TabIndex = 50;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(157, 47);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(147, 78);
            this.Output.TabIndex = 49;
            this.Output.Text = "";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(4, 47);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(147, 78);
            this.Input.TabIndex = 48;
            this.Input.Text = "";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(4, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(70, 38);
            this.Open.TabIndex = 47;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Map_Unstacker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 173);
            this.Controls.Add(this.Unstack);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Map_Unstacker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Unstack;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}