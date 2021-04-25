namespace SS_Multi_Tool
{
    partial class Copy_Paste_Detector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Copy_Paste_Detector));
            this.Examine = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Paste = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Examine
            // 
            this.Examine.Location = new System.Drawing.Point(2, 149);
            this.Examine.Name = "Examine";
            this.Examine.Size = new System.Drawing.Size(126, 23);
            this.Examine.TabIndex = 13;
            this.Examine.Text = "Examine";
            this.Examine.UseVisualStyleBackColor = true;
            this.Examine.Click += new System.EventHandler(this.Examine_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(2, 47);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(126, 96);
            this.Input.TabIndex = 11;
            this.Input.Text = "";
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(68, 3);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(60, 38);
            this.Paste.TabIndex = 8;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(2, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(60, 38);
            this.Open.TabIndex = 7;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(2, 179);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(126, 89);
            this.Output.TabIndex = 14;
            this.Output.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(2, 230);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(126, 38);
            this.richTextBox3.TabIndex = 15;
            this.richTextBox3.Text = "THIS PROGRAM IS WORK-IN-PROGRESS";
            // 
            // Copy_Paste_Detector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(131, 270);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Examine);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Copy_Paste_Detector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Examine;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}