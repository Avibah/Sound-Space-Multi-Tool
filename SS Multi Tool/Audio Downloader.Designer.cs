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
            this.label2 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.CatalogName = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // MP3
            // 
            this.MP3.Location = new System.Drawing.Point(96, 78);
            this.MP3.Name = "MP3";
            this.MP3.Size = new System.Drawing.Size(110, 23);
            this.MP3.TabIndex = 0;
            this.MP3.Text = "Download as mp3";
            this.MP3.UseVisualStyleBackColor = true;
            this.MP3.Click += new System.EventHandler(this.MP3_Click);
            // 
            // audioID
            // 
            this.audioID.Location = new System.Drawing.Point(96, 3);
            this.audioID.Name = "audioID";
            this.audioID.Size = new System.Drawing.Size(110, 20);
            this.audioID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Audio ID";
            // 
            // OpenDir
            // 
            this.OpenDir.Location = new System.Drawing.Point(3, 78);
            this.OpenDir.Name = "OpenDir";
            this.OpenDir.Size = new System.Drawing.Size(87, 23);
            this.OpenDir.TabIndex = 3;
            this.OpenDir.Text = "Open Directory";
            this.OpenDir.UseVisualStyleBackColor = true;
            this.OpenDir.Click += new System.EventHandler(this.OpenDir_Click);
            // 
            // OGG
            // 
            this.OGG.Location = new System.Drawing.Point(96, 107);
            this.OGG.Name = "OGG";
            this.OGG.Size = new System.Drawing.Size(110, 23);
            this.OGG.TabIndex = 4;
            this.OGG.Text = "Download as ogg";
            this.OGG.UseVisualStyleBackColor = true;
            this.OGG.Click += new System.EventHandler(this.OGG_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name (Optional)";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(96, 29);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(110, 20);
            this.FileName.TabIndex = 5;
            // 
            // CatalogName
            // 
            this.CatalogName.AutoSize = true;
            this.CatalogName.Location = new System.Drawing.Point(10, 55);
            this.CatalogName.Name = "CatalogName";
            this.CatalogName.Size = new System.Drawing.Size(115, 17);
            this.CatalogName.TabIndex = 7;
            this.CatalogName.Text = "Use Catalog Name";
            this.CatalogName.UseVisualStyleBackColor = true;
            // 
            // Audio_Downloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 135);
            this.Controls.Add(this.CatalogName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FileName);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.CheckBox CatalogName;
    }
}