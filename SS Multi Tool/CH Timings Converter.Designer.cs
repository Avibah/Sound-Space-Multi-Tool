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
            this.Paste = new System.Windows.Forms.Button();
            this.ConvertOSU = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.Copy = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ConvertMS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(79, 2);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(70, 38);
            this.Paste.TabIndex = 86;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // ConvertOSU
            // 
            this.ConvertOSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.ConvertOSU.Location = new System.Drawing.Point(3, 130);
            this.ConvertOSU.Name = "ConvertOSU";
            this.ConvertOSU.Size = new System.Drawing.Size(70, 38);
            this.ConvertOSU.TabIndex = 85;
            this.ConvertOSU.Text = "Convert to OSU Timings";
            this.ConvertOSU.UseVisualStyleBackColor = true;
            this.ConvertOSU.Click += new System.EventHandler(this.ConvertOSU_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(3, 174);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(147, 333);
            this.richTextBox3.TabIndex = 84;
            this.richTextBox3.Text = "";
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(3, 513);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(147, 38);
            this.Copy.TabIndex = 83;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(3, 2);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(70, 38);
            this.Open.TabIndex = 82;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(147, 78);
            this.richTextBox1.TabIndex = 81;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ConvertMS
            // 
            this.ConvertMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.ConvertMS.Location = new System.Drawing.Point(79, 130);
            this.ConvertMS.Name = "ConvertMS";
            this.ConvertMS.Size = new System.Drawing.Size(70, 38);
            this.ConvertMS.TabIndex = 87;
            this.ConvertMS.Text = "Convert to MS + BPM";
            this.ConvertMS.UseVisualStyleBackColor = true;
            this.ConvertMS.Click += new System.EventHandler(this.ConvertMS_Click);
            // 
            // CH_Timings_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 554);
            this.Controls.Add(this.ConvertMS);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.ConvertOSU);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CH_Timings_Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button ConvertOSU;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ConvertMS;
    }
}