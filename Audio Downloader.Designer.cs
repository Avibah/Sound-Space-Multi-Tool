namespace Program_Launcher
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
            this.mp3 = new System.Windows.Forms.Button();
            this.audioID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenDir = new System.Windows.Forms.Button();
            this.ogg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mp3
            // 
            this.mp3.Location = new System.Drawing.Point(96, 47);
            this.mp3.Name = "mp3";
            this.mp3.Size = new System.Drawing.Size(110, 23);
            this.mp3.TabIndex = 0;
            this.mp3.Text = "Download as mp3";
            this.mp3.UseVisualStyleBackColor = true;
            this.mp3.Click += new System.EventHandler(this.mp3_Click);
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
            // ogg
            // 
            this.ogg.Location = new System.Drawing.Point(96, 76);
            this.ogg.Name = "ogg";
            this.ogg.Size = new System.Drawing.Size(110, 23);
            this.ogg.TabIndex = 4;
            this.ogg.Text = "Download as ogg";
            this.ogg.UseVisualStyleBackColor = true;
            this.ogg.Click += new System.EventHandler(this.ogg_Click);
            // 
            // Audio_Downloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 103);
            this.Controls.Add(this.ogg);
            this.Controls.Add(this.OpenDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.audioID);
            this.Controls.Add(this.mp3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Audio_Downloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mp3;
        private System.Windows.Forms.TextBox audioID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenDir;
        private System.Windows.Forms.Button ogg;
    }
}