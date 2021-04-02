namespace Program_Launcher
{
    partial class Map_Speed_Adjuster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map_Speed_Adjuster));
            this.label2 = new System.Windows.Forms.Label();
            this.Convert = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Output";
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(152, 151);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(144, 33);
            this.Convert.TabIndex = 18;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(227, 3);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(69, 42);
            this.Export.TabIndex = 17;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(152, 3);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(69, 42);
            this.Copy.TabIndex = 16;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(77, 3);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(69, 42);
            this.Paste.TabIndex = 15;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(2, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(69, 42);
            this.Open.TabIndex = 14;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Speed Multiplier";
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(2, 164);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(143, 20);
            this.Speed.TabIndex = 12;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(152, 51);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(144, 81);
            this.Output.TabIndex = 11;
            this.Output.Text = "";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(3, 51);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(143, 81);
            this.Input.TabIndex = 10;
            this.Input.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Map_Speed_Adjuster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 185);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Map_Speed_Adjuster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Speed;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}