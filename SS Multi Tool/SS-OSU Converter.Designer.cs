namespace Program_Launcher
{
    partial class SS_OSU_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SS_OSU_Converter));
            this.Convert = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Offset = new System.Windows.Forms.TextBox();
            this.SSGuides = new System.Windows.Forms.CheckBox();
            this.Open = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ApplyOffset = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SelectImage = new System.Windows.Forms.Button();
            this.ImageDir = new System.Windows.Forms.TextBox();
            this.OpenDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(2, 149);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(222, 36);
            this.Convert.TabIndex = 0;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(116, 2);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(108, 36);
            this.Paste.TabIndex = 91;
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
            this.Offset.TabIndex = 76;
            this.Offset.Text = "-28";
            // 
            // SSGuides
            // 
            this.SSGuides.AutoSize = true;
            this.SSGuides.Checked = true;
            this.SSGuides.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SSGuides.Location = new System.Drawing.Point(230, 134);
            this.SSGuides.Name = "SSGuides";
            this.SSGuides.Size = new System.Drawing.Size(171, 17);
            this.SSGuides.TabIndex = 74;
            this.SSGuides.Text = "Snap To Sound Space Guides";
            this.SSGuides.UseVisualStyleBackColor = true;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(2, 2);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(108, 36);
            this.Open.TabIndex = 70;
            this.Open.Text = "Open Map";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(2, 44);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(222, 99);
            this.Input.TabIndex = 69;
            this.Input.Text = "";
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(230, 69);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(176, 20);
            this.Author.TabIndex = 92;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(230, 108);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(176, 20);
            this.Title.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Title";
            // 
            // ApplyOffset
            // 
            this.ApplyOffset.AutoSize = true;
            this.ApplyOffset.Location = new System.Drawing.Point(230, 7);
            this.ApplyOffset.Name = "ApplyOffset";
            this.ApplyOffset.Size = new System.Drawing.Size(83, 17);
            this.ApplyOffset.TabIndex = 96;
            this.ApplyOffset.Text = "Apply Offset";
            this.ApplyOffset.UseVisualStyleBackColor = true;
            this.ApplyOffset.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SelectImage
            // 
            this.SelectImage.Location = new System.Drawing.Point(2, 191);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(222, 21);
            this.SelectImage.TabIndex = 97;
            this.SelectImage.Text = "Select Background Image (Optional)";
            this.SelectImage.UseVisualStyleBackColor = true;
            this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
            // 
            // ImageDir
            // 
            this.ImageDir.Location = new System.Drawing.Point(230, 191);
            this.ImageDir.Name = "ImageDir";
            this.ImageDir.ReadOnly = true;
            this.ImageDir.Size = new System.Drawing.Size(176, 20);
            this.ImageDir.TabIndex = 98;
            // 
            // OpenDir
            // 
            this.OpenDir.Location = new System.Drawing.Point(320, 162);
            this.OpenDir.Name = "OpenDir";
            this.OpenDir.Size = new System.Drawing.Size(86, 23);
            this.OpenDir.TabIndex = 99;
            this.OpenDir.Text = "Open Directory";
            this.OpenDir.UseVisualStyleBackColor = true;
            this.OpenDir.Click += new System.EventHandler(this.OpenDir_Click);
            // 
            // SS_OSU_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 214);
            this.Controls.Add(this.OpenDir);
            this.Controls.Add(this.ImageDir);
            this.Controls.Add(this.SelectImage);
            this.Controls.Add(this.ApplyOffset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Offset);
            this.Controls.Add(this.SSGuides);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Convert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SS_OSU_Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.TextBox Offset;
        private System.Windows.Forms.CheckBox SSGuides;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ApplyOffset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SelectImage;
        private System.Windows.Forms.TextBox ImageDir;
        private System.Windows.Forms.Button OpenDir;
    }
}