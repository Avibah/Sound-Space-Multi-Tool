namespace SS_Multi_Tool
{
    partial class Audio_Downloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Audio_Downloader));
            this.MP3 = new System.Windows.Forms.Button();
            this.audioID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenDir = new System.Windows.Forms.Button();
            this.OGG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MP3
            // 
            this.MP3.Location = new System.Drawing.Point(96, 47);
            this.MP3.Name = "MP3";
            this.MP3.Size = new System.Drawing.Size(110, 23);
            this.MP3.TabIndex = 0;
            this.MP3.Text = "Download as mp3";
            this.MP3.UseVisualStyleBackColor = true;
            this.MP3.Click += new System.EventHandler(this.MP3_Click);
            // 
            // audioID
            // 
            this.audioID.Location = new System.Drawing.Point(3, 21);
            this.audioID.Name = "audioID";
            this.audioID.Size = new System.Drawing.Size(203, 20);
            this.audioID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Audio ID";
            // 
            // OpenDir
            // 
            this.OpenDir.Location = new System.Drawing.Point(3, 47);
            this.OpenDir.Name = "OpenDir";
            this.OpenDir.Size = new System.Drawing.Size(87, 23);
            this.OpenDir.TabIndex = 3;
            this.OpenDir.Text = "Open Directory";
            this.OpenDir.UseVisualStyleBackColor = true;
            this.OpenDir.Click += new System.EventHandler(this.OpenDir_Click);
            // 
            // OGG
            // 
            this.OGG.Location = new System.Drawing.Point(96, 76);
            this.OGG.Name = "OGG";
            this.OGG.Size = new System.Drawing.Size(110, 23);
            this.OGG.TabIndex = 4;
            this.OGG.Text = "Download as ogg";
            this.OGG.UseVisualStyleBackColor = true;
            this.OGG.Click += new System.EventHandler(this.OGG_Click);
            // 
            // Audio_Downloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 103);
            this.Controls.Add(this.OGG);
            this.Controls.Add(this.OpenDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.audioID);
            this.Controls.Add(this.MP3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Audio_Downloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MP3;
        private System.Windows.Forms.TextBox audioID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenDir;
        private System.Windows.Forms.Button OGG;
    }
}