namespace SS_Multi_Tool
{
    partial class Letter_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Letter_Converter));
            this.Cap = new System.Windows.Forms.TextBox();
            this.SetCap = new System.Windows.Forms.CheckBox();
            this.Convert = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Spaces = new System.Windows.Forms.CheckBox();
            this.Capitals = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Paste = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cap
            // 
            this.Cap.Enabled = false;
            this.Cap.Location = new System.Drawing.Point(12, 195);
            this.Cap.Multiline = true;
            this.Cap.Name = "Cap";
            this.Cap.Size = new System.Drawing.Size(138, 23);
            this.Cap.TabIndex = 18;
            // 
            // SetCap
            // 
            this.SetCap.AutoSize = true;
            this.SetCap.Location = new System.Drawing.Point(12, 175);
            this.SetCap.Name = "SetCap";
            this.SetCap.Size = new System.Drawing.Size(71, 17);
            this.SetCap.TabIndex = 17;
            this.SetCap.Text = "Note Cap";
            this.SetCap.UseVisualStyleBackColor = true;
            this.SetCap.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(156, 195);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(146, 23);
            this.Convert.TabIndex = 15;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(156, 47);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(146, 78);
            this.Output.TabIndex = 14;
            this.Output.Text = "";
            // 
            // Spaces
            // 
            this.Spaces.AutoSize = true;
            this.Spaces.Location = new System.Drawing.Point(12, 152);
            this.Spaces.Name = "Spaces";
            this.Spaces.Size = new System.Drawing.Size(62, 17);
            this.Spaces.TabIndex = 12;
            this.Spaces.Text = "Spaces";
            this.Spaces.UseVisualStyleBackColor = true;
            // 
            // Capitals
            // 
            this.Capitals.AutoSize = true;
            this.Capitals.Location = new System.Drawing.Point(12, 129);
            this.Capitals.Name = "Capitals";
            this.Capitals.Size = new System.Drawing.Size(63, 17);
            this.Capitals.TabIndex = 10;
            this.Capitals.Text = "Capitals";
            this.Capitals.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(80, 3);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(70, 38);
            this.Paste.TabIndex = 22;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(3, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(70, 38);
            this.Open.TabIndex = 21;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(3, 47);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(147, 78);
            this.Input.TabIndex = 20;
            this.Input.Text = "";
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(156, 3);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(146, 38);
            this.Copy.TabIndex = 23;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Letter_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 222);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Cap);
            this.Controls.Add(this.SetCap);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Spaces);
            this.Controls.Add(this.Capitals);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Letter_Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Cap;
        private System.Windows.Forms.CheckBox SetCap;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.CheckBox Spaces;
        private System.Windows.Forms.CheckBox Capitals;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button Copy;
    }
}