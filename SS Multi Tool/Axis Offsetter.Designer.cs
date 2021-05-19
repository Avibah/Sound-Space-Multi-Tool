namespace SS_Multi_Tool
{
    partial class Axis_Offsetter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Axis_Offsetter));
            this.Offset = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Open = new System.Windows.Forms.Button();
            this.OffsetXAmount = new System.Windows.Forms.TrackBar();
            this.OffsetYAmount = new System.Windows.Forms.TrackBar();
            this.OffsetXBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OffsetYBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetXAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetYAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // Offset
            // 
            this.Offset.Location = new System.Drawing.Point(155, 190);
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(147, 38);
            this.Offset.TabIndex = 46;
            this.Offset.Text = "Offset";
            this.Offset.UseVisualStyleBackColor = true;
            this.Offset.Click += new System.EventHandler(this.Offset_Click);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(79, 2);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(70, 38);
            this.Paste.TabIndex = 45;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(155, 2);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(70, 38);
            this.Copy.TabIndex = 44;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(232, 2);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(70, 38);
            this.Export.TabIndex = 43;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(155, 46);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(147, 78);
            this.Output.TabIndex = 42;
            this.Output.Text = "";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(2, 46);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(147, 78);
            this.Input.TabIndex = 41;
            this.Input.Text = "";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(2, 2);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(70, 38);
            this.Open.TabIndex = 40;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // OffsetXAmount
            // 
            this.OffsetXAmount.Location = new System.Drawing.Point(195, 130);
            this.OffsetXAmount.Maximum = 4;
            this.OffsetXAmount.Minimum = -4;
            this.OffsetXAmount.Name = "OffsetXAmount";
            this.OffsetXAmount.Size = new System.Drawing.Size(107, 45);
            this.OffsetXAmount.TabIndex = 47;
            this.OffsetXAmount.Scroll += new System.EventHandler(this.OffsetXAmount_Scroll);
            // 
            // OffsetYAmount
            // 
            this.OffsetYAmount.Location = new System.Drawing.Point(2, 127);
            this.OffsetYAmount.Maximum = 4;
            this.OffsetYAmount.Minimum = -4;
            this.OffsetYAmount.Name = "OffsetYAmount";
            this.OffsetYAmount.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.OffsetYAmount.Size = new System.Drawing.Size(45, 101);
            this.OffsetYAmount.TabIndex = 48;
            this.OffsetYAmount.Scroll += new System.EventHandler(this.OffsetYAmount_Scroll);
            // 
            // OffsetXBox
            // 
            this.OffsetXBox.Location = new System.Drawing.Point(200, 164);
            this.OffsetXBox.Name = "OffsetXBox";
            this.OffsetXBox.Size = new System.Drawing.Size(68, 20);
            this.OffsetXBox.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "OffsetX";
            // 
            // OffsetYBox
            // 
            this.OffsetYBox.Location = new System.Drawing.Point(78, 127);
            this.OffsetYBox.Name = "OffsetYBox";
            this.OffsetYBox.Size = new System.Drawing.Size(71, 20);
            this.OffsetYBox.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "OffsetY";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Axis_Offsetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 229);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OffsetYBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OffsetXBox);
            this.Controls.Add(this.OffsetYAmount);
            this.Controls.Add(this.OffsetXAmount);
            this.Controls.Add(this.Offset);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Axis_Offsetter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.OffsetXAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetYAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Offset;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TrackBar OffsetXAmount;
        private System.Windows.Forms.TrackBar OffsetYAmount;
        private System.Windows.Forms.TextBox OffsetXBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OffsetYBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}