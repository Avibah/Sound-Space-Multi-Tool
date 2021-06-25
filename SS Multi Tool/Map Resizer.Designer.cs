namespace SS_Multi_Tool
{
    partial class Map_Resizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map_Resizer));
            this.KeepNormal = new System.Windows.Forms.CheckBox();
            this.KeepOffgrid = new System.Windows.Forms.CheckBox();
            this.ConvertNormal = new System.Windows.Forms.CheckBox();
            this.ConvertOffgrid = new System.Windows.Forms.CheckBox();
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.CustomOffgrid = new System.Windows.Forms.TextBox();
            this.CustomButton = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Open = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.OffsetYBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OffsetXBox = new System.Windows.Forms.TextBox();
            this.OffsetYAmount = new System.Windows.Forms.TrackBar();
            this.OffsetXAmount = new System.Windows.Forms.TrackBar();
            this.ApplyMultiplier = new System.Windows.Forms.CheckBox();
            this.OffgridLimit = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetYAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetXAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // KeepNormal
            // 
            this.KeepNormal.AutoSize = true;
            this.KeepNormal.Enabled = false;
            this.KeepNormal.Location = new System.Drawing.Point(84, 173);
            this.KeepNormal.Name = "KeepNormal";
            this.KeepNormal.Size = new System.Drawing.Size(124, 17);
            this.KeepNormal.TabIndex = 34;
            this.KeepNormal.Text = "Keep Current Normal";
            this.KeepNormal.UseVisualStyleBackColor = true;
            // 
            // KeepOffgrid
            // 
            this.KeepOffgrid.AutoSize = true;
            this.KeepOffgrid.Location = new System.Drawing.Point(84, 219);
            this.KeepOffgrid.Name = "KeepOffgrid";
            this.KeepOffgrid.Size = new System.Drawing.Size(122, 17);
            this.KeepOffgrid.TabIndex = 33;
            this.KeepOffgrid.Text = "Keep Current Offgrid";
            this.KeepOffgrid.UseVisualStyleBackColor = true;
            // 
            // ConvertNormal
            // 
            this.ConvertNormal.AutoSize = true;
            this.ConvertNormal.Location = new System.Drawing.Point(84, 150);
            this.ConvertNormal.Name = "ConvertNormal";
            this.ConvertNormal.Size = new System.Drawing.Size(115, 17);
            this.ConvertNormal.TabIndex = 32;
            this.ConvertNormal.Text = "Convert To Normal";
            this.ConvertNormal.UseVisualStyleBackColor = true;
            this.ConvertNormal.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // ConvertOffgrid
            // 
            this.ConvertOffgrid.AutoSize = true;
            this.ConvertOffgrid.Checked = true;
            this.ConvertOffgrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConvertOffgrid.Location = new System.Drawing.Point(84, 196);
            this.ConvertOffgrid.Name = "ConvertOffgrid";
            this.ConvertOffgrid.Size = new System.Drawing.Size(113, 17);
            this.ConvertOffgrid.TabIndex = 31;
            this.ConvertOffgrid.Text = "Convert To Offgrid";
            this.ConvertOffgrid.UseVisualStyleBackColor = true;
            this.ConvertOffgrid.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(79, 3);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(70, 38);
            this.Paste.TabIndex = 30;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(155, 3);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(70, 38);
            this.Copy.TabIndex = 29;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(232, 3);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(70, 38);
            this.Export.TabIndex = 28;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(220, 320);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(82, 38);
            this.Convert.TabIndex = 27;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(155, 47);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(147, 78);
            this.Output.TabIndex = 26;
            this.Output.Text = "";
            // 
            // CustomOffgrid
            // 
            this.CustomOffgrid.Enabled = false;
            this.CustomOffgrid.Location = new System.Drawing.Point(12, 242);
            this.CustomOffgrid.Multiline = true;
            this.CustomOffgrid.Name = "CustomOffgrid";
            this.CustomOffgrid.Size = new System.Drawing.Size(90, 23);
            this.CustomOffgrid.TabIndex = 24;
            this.CustomOffgrid.Text = "0";
            // 
            // CustomButton
            // 
            this.CustomButton.AutoSize = true;
            this.CustomButton.Location = new System.Drawing.Point(12, 219);
            this.CustomButton.Name = "CustomButton";
            this.CustomButton.Size = new System.Drawing.Size(60, 17);
            this.CustomButton.TabIndex = 23;
            this.CustomButton.Text = "Custom";
            this.CustomButton.UseVisualStyleBackColor = true;
            this.CustomButton.CheckedChanged += new System.EventHandler(this.CustomButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 196);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.Text = "0.75";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 173);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(40, 17);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "0.5";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 150);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.Text = "0.25";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(2, 47);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(147, 78);
            this.Input.TabIndex = 19;
            this.Input.Text = "";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(2, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(70, 38);
            this.Open.TabIndex = 18;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "OffsetY";
            // 
            // OffsetYBox
            // 
            this.OffsetYBox.Location = new System.Drawing.Point(78, 278);
            this.OffsetYBox.Name = "OffsetYBox";
            this.OffsetYBox.Size = new System.Drawing.Size(71, 20);
            this.OffsetYBox.TabIndex = 57;
            this.OffsetYBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "OffsetX";
            // 
            // OffsetXBox
            // 
            this.OffsetXBox.Location = new System.Drawing.Point(81, 338);
            this.OffsetXBox.Name = "OffsetXBox";
            this.OffsetXBox.Size = new System.Drawing.Size(68, 20);
            this.OffsetXBox.TabIndex = 55;
            this.OffsetXBox.Text = "0";
            // 
            // OffsetYAmount
            // 
            this.OffsetYAmount.Location = new System.Drawing.Point(2, 265);
            this.OffsetYAmount.Maximum = 4;
            this.OffsetYAmount.Minimum = -4;
            this.OffsetYAmount.Name = "OffsetYAmount";
            this.OffsetYAmount.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.OffsetYAmount.Size = new System.Drawing.Size(45, 101);
            this.OffsetYAmount.TabIndex = 54;
            this.OffsetYAmount.Scroll += new System.EventHandler(this.OffsetYAmount_Scroll);
            // 
            // OffsetXAmount
            // 
            this.OffsetXAmount.Location = new System.Drawing.Point(42, 306);
            this.OffsetXAmount.Maximum = 4;
            this.OffsetXAmount.Minimum = -4;
            this.OffsetXAmount.Name = "OffsetXAmount";
            this.OffsetXAmount.Size = new System.Drawing.Size(107, 45);
            this.OffsetXAmount.TabIndex = 53;
            this.OffsetXAmount.Scroll += new System.EventHandler(this.OffsetXAmount_Scroll);
            // 
            // ApplyMultiplier
            // 
            this.ApplyMultiplier.AutoSize = true;
            this.ApplyMultiplier.Location = new System.Drawing.Point(12, 131);
            this.ApplyMultiplier.Name = "ApplyMultiplier";
            this.ApplyMultiplier.Size = new System.Drawing.Size(110, 17);
            this.ApplyMultiplier.TabIndex = 59;
            this.ApplyMultiplier.Text = "Apply as Multiplier";
            this.ApplyMultiplier.UseVisualStyleBackColor = true;
            this.ApplyMultiplier.CheckedChanged += new System.EventHandler(this.ApplyMultiplier_CheckedChanged);
            // 
            // OffgridLimit
            // 
            this.OffgridLimit.AutoSize = true;
            this.OffgridLimit.Location = new System.Drawing.Point(129, 131);
            this.OffgridLimit.Name = "OffgridLimit";
            this.OffgridLimit.Size = new System.Drawing.Size(144, 17);
            this.OffgridLimit.TabIndex = 60;
            this.OffgridLimit.Text = "Limit notes to 0.85 offgrid";
            this.OffgridLimit.UseVisualStyleBackColor = true;
            // 
            // Map_Resizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 362);
            this.Controls.Add(this.OffgridLimit);
            this.Controls.Add(this.ApplyMultiplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OffsetYBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OffsetXBox);
            this.Controls.Add(this.OffsetYAmount);
            this.Controls.Add(this.OffsetXAmount);
            this.Controls.Add(this.KeepNormal);
            this.Controls.Add(this.KeepOffgrid);
            this.Controls.Add(this.ConvertNormal);
            this.Controls.Add(this.ConvertOffgrid);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.CustomOffgrid);
            this.Controls.Add(this.CustomButton);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Map_Resizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.OffsetYAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetXAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox KeepNormal;
        private System.Windows.Forms.CheckBox KeepOffgrid;
        private System.Windows.Forms.CheckBox ConvertNormal;
        private System.Windows.Forms.CheckBox ConvertOffgrid;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.TextBox CustomOffgrid;
        private System.Windows.Forms.RadioButton CustomButton;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OffsetYBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OffsetXBox;
        private System.Windows.Forms.TrackBar OffsetYAmount;
        private System.Windows.Forms.TrackBar OffsetXAmount;
        private System.Windows.Forms.CheckBox ApplyMultiplier;
        private System.Windows.Forms.CheckBox OffgridLimit;
    }
}