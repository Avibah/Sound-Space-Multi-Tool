namespace SS_Multi_Tool
{
    partial class Center_Note_Counter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Center_Note_Counter));
            this.Open = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.RatioLabel = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.TextBox();
            this.Ratio = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(3, 4);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(93, 38);
            this.Open.TabIndex = 93;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(103, 4);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(93, 38);
            this.Paste.TabIndex = 92;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(3, 48);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(193, 78);
            this.Input.TabIndex = 91;
            this.Input.Text = "";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(12, 179);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(35, 13);
            this.CountLabel.TabIndex = 94;
            this.CountLabel.Text = "Count";
            // 
            // RatioLabel
            // 
            this.RatioLabel.AutoSize = true;
            this.RatioLabel.Location = new System.Drawing.Point(12, 205);
            this.RatioLabel.Name = "RatioLabel";
            this.RatioLabel.Size = new System.Drawing.Size(32, 13);
            this.RatioLabel.TabIndex = 95;
            this.RatioLabel.Text = "Ratio";
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(53, 176);
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Size = new System.Drawing.Size(143, 20);
            this.Count.TabIndex = 96;
            // 
            // Ratio
            // 
            this.Ratio.Location = new System.Drawing.Point(53, 202);
            this.Ratio.Name = "Ratio";
            this.Ratio.ReadOnly = true;
            this.Ratio.Size = new System.Drawing.Size(143, 20);
            this.Ratio.TabIndex = 97;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CountButton
            // 
            this.CountButton.Location = new System.Drawing.Point(3, 132);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(193, 38);
            this.CountButton.TabIndex = 98;
            this.CountButton.Text = "Count";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // Center_Note_Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 227);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.Ratio);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.RatioLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Center_Note_Counter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label RatioLabel;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.TextBox Ratio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button CountButton;
    }
}