﻿namespace SS_Multi_Tool
{
    partial class Map_Stacker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map_Stacker));
            this.StackSize = new System.Windows.Forms.NumericUpDown();
            this.Stack = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Open = new System.Windows.Forms.Button();
            this.Spacing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.StackSize)).BeginInit();
            this.SuspendLayout();
            // 
            // StackSize
            // 
            this.StackSize.Location = new System.Drawing.Point(80, 157);
            this.StackSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StackSize.Name = "StackSize";
            this.StackSize.Size = new System.Drawing.Size(70, 20);
            this.StackSize.TabIndex = 0;
            this.StackSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Stack
            // 
            this.Stack.Location = new System.Drawing.Point(156, 131);
            this.Stack.Name = "Stack";
            this.Stack.Size = new System.Drawing.Size(147, 46);
            this.Stack.TabIndex = 46;
            this.Stack.Text = "Stack";
            this.Stack.UseVisualStyleBackColor = true;
            this.Stack.Click += new System.EventHandler(this.Stack_Click);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(80, 3);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(70, 38);
            this.Paste.TabIndex = 45;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(156, 3);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(70, 38);
            this.Copy.TabIndex = 44;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(233, 3);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(70, 38);
            this.Export.TabIndex = 43;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(156, 47);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(147, 78);
            this.Output.TabIndex = 42;
            this.Output.Text = "";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(3, 47);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(147, 78);
            this.Input.TabIndex = 41;
            this.Input.Text = "";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(3, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(70, 38);
            this.Open.TabIndex = 40;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Spacing
            // 
            this.Spacing.Location = new System.Drawing.Point(80, 131);
            this.Spacing.Name = "Spacing";
            this.Spacing.Size = new System.Drawing.Size(70, 20);
            this.Spacing.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Spacing (ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Stack Size";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Map_Stacker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 181);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Spacing);
            this.Controls.Add(this.Stack);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.StackSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Map_Stacker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.StackSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown StackSize;
        private System.Windows.Forms.Button Stack;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox Spacing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}