namespace SS_Multi_Tool
{
    partial class Randomizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randomizer));
            this.KeepOffgrid = new System.Windows.Forms.CheckBox();
            this.OffgridValue = new System.Windows.Forms.TextBox();
            this.Offgrid = new System.Windows.Forms.CheckBox();
            this.Quantum = new System.Windows.Forms.CheckBox();
            this.Randomize = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KeepOffgrid
            // 
            this.KeepOffgrid.AutoSize = true;
            this.KeepOffgrid.Location = new System.Drawing.Point(2, 182);
            this.KeepOffgrid.Name = "KeepOffgrid";
            this.KeepOffgrid.Size = new System.Drawing.Size(121, 17);
            this.KeepOffgrid.TabIndex = 34;
            this.KeepOffgrid.Text = "Lock Current Offgrid";
            this.KeepOffgrid.UseVisualStyleBackColor = true;
            // 
            // OffgridValue
            // 
            this.OffgridValue.Enabled = false;
            this.OffgridValue.Location = new System.Drawing.Point(55, 157);
            this.OffgridValue.Name = "OffgridValue";
            this.OffgridValue.Size = new System.Drawing.Size(47, 20);
            this.OffgridValue.TabIndex = 30;
            this.OffgridValue.Text = "0.25";
            // 
            // Offgrid
            // 
            this.Offgrid.AutoSize = true;
            this.Offgrid.Location = new System.Drawing.Point(2, 159);
            this.Offgrid.Name = "Offgrid";
            this.Offgrid.Size = new System.Drawing.Size(57, 17);
            this.Offgrid.TabIndex = 29;
            this.Offgrid.Text = "Offgrid";
            this.Offgrid.UseVisualStyleBackColor = true;
            this.Offgrid.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Quantum
            // 
            this.Quantum.AutoSize = true;
            this.Quantum.Location = new System.Drawing.Point(2, 136);
            this.Quantum.Name = "Quantum";
            this.Quantum.Size = new System.Drawing.Size(69, 17);
            this.Quantum.TabIndex = 28;
            this.Quantum.Text = "Quantum";
            this.Quantum.UseVisualStyleBackColor = true;
            // 
            // Randomize
            // 
            this.Randomize.Location = new System.Drawing.Point(224, 174);
            this.Randomize.Name = "Randomize";
            this.Randomize.Size = new System.Drawing.Size(79, 31);
            this.Randomize.TabIndex = 25;
            this.Randomize.Text = "Randomize";
            this.Randomize.UseVisualStyleBackColor = true;
            this.Randomize.Click += new System.EventHandler(this.Randomize_Click);
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
            this.Paste.TabIndex = 40;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(156, 3);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(70, 38);
            this.Copy.TabIndex = 39;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(233, 3);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(70, 38);
            this.Export.TabIndex = 38;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(156, 47);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(147, 78);
            this.Output.TabIndex = 37;
            this.Output.Text = "";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(3, 47);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(147, 78);
            this.Input.TabIndex = 36;
            this.Input.Text = "";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(3, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(69, 38);
            this.Open.TabIndex = 35;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Randomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 209);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.KeepOffgrid);
            this.Controls.Add(this.OffgridValue);
            this.Controls.Add(this.Offgrid);
            this.Controls.Add(this.Quantum);
            this.Controls.Add(this.Randomize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Randomizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox KeepOffgrid;
        private System.Windows.Forms.TextBox OffgridValue;
        private System.Windows.Forms.CheckBox Offgrid;
        private System.Windows.Forms.CheckBox Quantum;
        private System.Windows.Forms.Button Randomize;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button Open;
    }
}