namespace Program_Launcher
{
    partial class Map_Mirrorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map_Mirrorer));
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Open = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Mirror = new System.Windows.Forms.Button();
            this.MirrorH = new System.Windows.Forms.CheckBox();
            this.MirrorV = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(79, 3);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(70, 38);
            this.Paste.TabIndex = 36;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(155, 3);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(70, 38);
            this.Copy.TabIndex = 35;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(232, 3);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(70, 38);
            this.Export.TabIndex = 34;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(155, 47);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(147, 78);
            this.Output.TabIndex = 33;
            this.Output.Text = "";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(2, 47);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(147, 78);
            this.Input.TabIndex = 32;
            this.Input.Text = "";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(2, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(70, 38);
            this.Open.TabIndex = 31;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Mirror
            // 
            this.Mirror.Location = new System.Drawing.Point(155, 131);
            this.Mirror.Name = "Mirror";
            this.Mirror.Size = new System.Drawing.Size(147, 38);
            this.Mirror.TabIndex = 37;
            this.Mirror.Text = "Mirror";
            this.Mirror.UseVisualStyleBackColor = true;
            this.Mirror.Click += new System.EventHandler(this.Mirror_Click);
            // 
            // MirrorH
            // 
            this.MirrorH.AutoSize = true;
            this.MirrorH.Checked = true;
            this.MirrorH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MirrorH.Location = new System.Drawing.Point(13, 132);
            this.MirrorH.Name = "MirrorH";
            this.MirrorH.Size = new System.Drawing.Size(109, 17);
            this.MirrorH.TabIndex = 38;
            this.MirrorH.Text = "Mirror Horizontally";
            this.MirrorH.UseVisualStyleBackColor = true;
            // 
            // MirrorV
            // 
            this.MirrorV.AutoSize = true;
            this.MirrorV.Checked = true;
            this.MirrorV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MirrorV.Location = new System.Drawing.Point(13, 152);
            this.MirrorV.Name = "MirrorV";
            this.MirrorV.Size = new System.Drawing.Size(97, 17);
            this.MirrorV.TabIndex = 39;
            this.MirrorV.Text = "Mirror Vertically";
            this.MirrorV.UseVisualStyleBackColor = true;
            // 
            // Map_Mirrorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 173);
            this.Controls.Add(this.MirrorV);
            this.Controls.Add(this.MirrorH);
            this.Controls.Add(this.Mirror);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Map_Mirrorer";
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Mirror;
        private System.Windows.Forms.CheckBox MirrorH;
        private System.Windows.Forms.CheckBox MirrorV;
    }
}