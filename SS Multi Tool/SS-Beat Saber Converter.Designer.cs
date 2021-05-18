namespace SS_Multi_Tool
{
    partial class SS_Beat_Saber_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SS_Beat_Saber_Converter));
            this.OpenDir = new System.Windows.Forms.Button();
            this.ApplyOffset = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.Paste = new System.Windows.Forms.Button();
            this.Offset = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BPM = new System.Windows.Forms.TextBox();
            this.Directions = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // OpenDir
            // 
            this.OpenDir.Location = new System.Drawing.Point(343, 149);
            this.OpenDir.Name = "OpenDir";
            this.OpenDir.Size = new System.Drawing.Size(63, 44);
            this.OpenDir.TabIndex = 111;
            this.OpenDir.Text = "Open Directory";
            this.OpenDir.UseVisualStyleBackColor = true;
            this.OpenDir.Click += new System.EventHandler(this.OpenDir_Click);
            // 
            // ApplyOffset
            // 
            this.ApplyOffset.AutoSize = true;
            this.ApplyOffset.Location = new System.Drawing.Point(230, 7);
            this.ApplyOffset.Name = "ApplyOffset";
            this.ApplyOffset.Size = new System.Drawing.Size(83, 17);
            this.ApplyOffset.TabIndex = 110;
            this.ApplyOffset.Text = "Apply Offset";
            this.ApplyOffset.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Author";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(230, 108);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(176, 20);
            this.Title.TabIndex = 107;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(230, 69);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(176, 20);
            this.Author.TabIndex = 106;
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(116, 2);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(108, 36);
            this.Paste.TabIndex = 105;
            this.Paste.Text = "Paste Data";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Offset
            // 
            this.Offset.Enabled = false;
            this.Offset.Location = new System.Drawing.Point(230, 30);
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(176, 20);
            this.Offset.TabIndex = 104;
            this.Offset.Text = "-28";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(2, 2);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(108, 36);
            this.Open.TabIndex = 102;
            this.Open.Text = "Open Map";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(2, 44);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(222, 99);
            this.Input.TabIndex = 101;
            this.Input.Text = "";
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(2, 149);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(222, 44);
            this.Convert.TabIndex = 100;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "BPM";
            // 
            // BPM
            // 
            this.BPM.Location = new System.Drawing.Point(230, 149);
            this.BPM.Name = "BPM";
            this.BPM.Size = new System.Drawing.Size(107, 20);
            this.BPM.TabIndex = 112;
            // 
            // Directions
            // 
            this.Directions.AutoSize = true;
            this.Directions.Location = new System.Drawing.Point(230, 176);
            this.Directions.Name = "Directions";
            this.Directions.Size = new System.Drawing.Size(107, 17);
            this.Directions.TabIndex = 114;
            this.Directions.Text = "Directional Notes";
            this.Directions.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(413, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(134, 191);
            this.richTextBox1.TabIndex = 115;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // SS_Beat_Saber_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 196);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Directions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BPM);
            this.Controls.Add(this.OpenDir);
            this.Controls.Add(this.ApplyOffset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Offset);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Convert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SS_Beat_Saber_Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenDir;
        private System.Windows.Forms.CheckBox ApplyOffset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.TextBox Offset;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BPM;
        private System.Windows.Forms.CheckBox Directions;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}