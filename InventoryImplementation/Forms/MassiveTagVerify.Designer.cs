namespace InventoryImplementation
{
    partial class f_MassiveTagVerify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_MassiveTagVerify));
            this.gb_FilterefTags = new System.Windows.Forms.GroupBox();
            this.dgv_FilteredTags = new System.Windows.Forms.DataGridView();
            this.b_RefreshList = new System.Windows.Forms.Button();
            this.gb_FilterefTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FilteredTags)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_FilterefTags
            // 
            this.gb_FilterefTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_FilterefTags.Controls.Add(this.dgv_FilteredTags);
            this.gb_FilterefTags.Location = new System.Drawing.Point(12, 47);
            this.gb_FilterefTags.Name = "gb_FilterefTags";
            this.gb_FilterefTags.Size = new System.Drawing.Size(1057, 533);
            this.gb_FilterefTags.TabIndex = 16;
            this.gb_FilterefTags.TabStop = false;
            this.gb_FilterefTags.Text = "Filtered Tags";
            // 
            // dgv_FilteredTags
            // 
            this.dgv_FilteredTags.AllowUserToAddRows = false;
            this.dgv_FilteredTags.AllowUserToDeleteRows = false;
            this.dgv_FilteredTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FilteredTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_FilteredTags.Location = new System.Drawing.Point(3, 18);
            this.dgv_FilteredTags.Name = "dgv_FilteredTags";
            this.dgv_FilteredTags.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_FilteredTags.RowTemplate.Height = 24;
            this.dgv_FilteredTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FilteredTags.Size = new System.Drawing.Size(1051, 512);
            this.dgv_FilteredTags.TabIndex = 0;
            this.dgv_FilteredTags.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FilteredTags_CellEndEdit);
            // 
            // b_RefreshList
            // 
            this.b_RefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_RefreshList.Location = new System.Drawing.Point(961, 5);
            this.b_RefreshList.Name = "b_RefreshList";
            this.b_RefreshList.Size = new System.Drawing.Size(105, 36);
            this.b_RefreshList.TabIndex = 17;
            this.b_RefreshList.Text = "Refresh List";
            this.b_RefreshList.UseVisualStyleBackColor = true;
            this.b_RefreshList.Click += new System.EventHandler(this.b_RefreshList_Click);
            // 
            // f_MassiveTagVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 592);
            this.Controls.Add(this.b_RefreshList);
            this.Controls.Add(this.gb_FilterefTags);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_MassiveTagVerify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Massive Tag Verify";
            this.gb_FilterefTags.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FilteredTags)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_FilterefTags;
        private System.Windows.Forms.Button b_RefreshList;
        private System.Windows.Forms.DataGridView dgv_FilteredTags;
    }
}