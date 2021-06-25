namespace SS_Multi_Tool
{
    partial class DiffCalcChoose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiffCalcChoose));
            this.SearchBox = new System.Windows.Forms.RichTextBox();
            this.Search = new System.Windows.Forms.Button();
            this.MapList = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MapName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Choose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MapList)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.AcceptsTab = true;
            this.SearchBox.Location = new System.Drawing.Point(3, 3);
            this.SearchBox.Multiline = false;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(330, 28);
            this.SearchBox.TabIndex = 4;
            this.SearchBox.Text = "";
            this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyUp);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(340, 3);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(74, 28);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // MapList
            // 
            this.MapList.AllowUserToAddRows = false;
            this.MapList.AllowUserToDeleteRows = false;
            this.MapList.AllowUserToResizeColumns = false;
            this.MapList.AllowUserToResizeRows = false;
            this.MapList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MapList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.MapName,
            this.Stars,
            this.PP});
            this.MapList.Location = new System.Drawing.Point(3, 37);
            this.MapList.MultiSelect = false;
            this.MapList.Name = "MapList";
            this.MapList.ReadOnly = true;
            this.MapList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MapList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MapList.Size = new System.Drawing.Size(411, 486);
            this.MapList.TabIndex = 2;
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Index.HeaderText = "Rank";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 58;
            // 
            // MapName
            // 
            this.MapName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MapName.HeaderText = "Map";
            this.MapName.Name = "MapName";
            this.MapName.ReadOnly = true;
            // 
            // Stars
            // 
            this.Stars.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Stars.HeaderText = "Stars";
            this.Stars.Name = "Stars";
            this.Stars.ReadOnly = true;
            this.Stars.Width = 56;
            // 
            // PP
            // 
            this.PP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PP.HeaderText = "PP";
            this.PP.Name = "PP";
            this.PP.ReadOnly = true;
            this.PP.Width = 46;
            // 
            // Choose
            // 
            this.Choose.Location = new System.Drawing.Point(3, 529);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(411, 28);
            this.Choose.TabIndex = 3;
            this.Choose.Text = "Choose Map";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // DiffCalcChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 559);
            this.Controls.Add(this.Choose);
            this.Controls.Add(this.MapList);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiffCalcChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.MapList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox SearchBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView MapList;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn MapName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stars;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP;
    }
}