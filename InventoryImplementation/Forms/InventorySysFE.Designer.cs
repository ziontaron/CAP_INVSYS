namespace InventoryImplementation
{
    partial class f_InventorySysFE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_InventorySysFE));
            this.gb_CountFunctions = new System.Windows.Forms.GroupBox();
            this.b_ItemMaster = new System.Windows.Forms.Button();
            this.b_MOTag = new System.Windows.Forms.Button();
            this.b_TagCapture = new System.Windows.Forms.Button();
            this.b_AdminForm = new System.Windows.Forms.Button();
            this.gb_EventAdmin = new System.Windows.Forms.GroupBox();
            this.gb_SysAdmin = new System.Windows.Forms.GroupBox();
            this.b_BalanceAdj = new System.Windows.Forms.Button();
            this.b_UserAdmin = new System.Windows.Forms.Button();
            this.gb_CountFunctions.SuspendLayout();
            this.gb_EventAdmin.SuspendLayout();
            this.gb_SysAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_CountFunctions
            // 
            this.gb_CountFunctions.Controls.Add(this.b_ItemMaster);
            this.gb_CountFunctions.Controls.Add(this.b_MOTag);
            this.gb_CountFunctions.Controls.Add(this.b_TagCapture);
            this.gb_CountFunctions.Enabled = false;
            this.gb_CountFunctions.Location = new System.Drawing.Point(9, 10);
            this.gb_CountFunctions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_CountFunctions.Name = "gb_CountFunctions";
            this.gb_CountFunctions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_CountFunctions.Size = new System.Drawing.Size(154, 209);
            this.gb_CountFunctions.TabIndex = 4;
            this.gb_CountFunctions.TabStop = false;
            this.gb_CountFunctions.Text = "Counter Functions";
            // 
            // b_ItemMaster
            // 
            this.b_ItemMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ItemMaster.Location = new System.Drawing.Point(20, 139);
            this.b_ItemMaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_ItemMaster.Name = "b_ItemMaster";
            this.b_ItemMaster.Size = new System.Drawing.Size(113, 47);
            this.b_ItemMaster.TabIndex = 3;
            this.b_ItemMaster.Text = "Item Master";
            this.b_ItemMaster.UseVisualStyleBackColor = true;
            this.b_ItemMaster.Click += new System.EventHandler(this.b_ItemMaster_Click);
            // 
            // b_MOTag
            // 
            this.b_MOTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_MOTag.Location = new System.Drawing.Point(20, 84);
            this.b_MOTag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_MOTag.Name = "b_MOTag";
            this.b_MOTag.Size = new System.Drawing.Size(113, 47);
            this.b_MOTag.TabIndex = 2;
            this.b_MOTag.Text = "MO Tag Capture";
            this.b_MOTag.UseVisualStyleBackColor = true;
            this.b_MOTag.Click += new System.EventHandler(this.b_MOTag_Click);
            // 
            // b_TagCapture
            // 
            this.b_TagCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_TagCapture.Location = new System.Drawing.Point(20, 30);
            this.b_TagCapture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_TagCapture.Name = "b_TagCapture";
            this.b_TagCapture.Size = new System.Drawing.Size(113, 47);
            this.b_TagCapture.TabIndex = 1;
            this.b_TagCapture.Text = "Tag Capture";
            this.b_TagCapture.UseVisualStyleBackColor = true;
            this.b_TagCapture.Click += new System.EventHandler(this.b_TagCapture_Click);
            // 
            // b_AdminForm
            // 
            this.b_AdminForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_AdminForm.Location = new System.Drawing.Point(17, 30);
            this.b_AdminForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_AdminForm.Name = "b_AdminForm";
            this.b_AdminForm.Size = new System.Drawing.Size(113, 70);
            this.b_AdminForm.TabIndex = 0;
            this.b_AdminForm.Text = "Admin Functions";
            this.b_AdminForm.UseVisualStyleBackColor = true;
            this.b_AdminForm.Click += new System.EventHandler(this.b_AdminForm_Click);
            // 
            // gb_EventAdmin
            // 
            this.gb_EventAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_EventAdmin.Controls.Add(this.b_AdminForm);
            this.gb_EventAdmin.Enabled = false;
            this.gb_EventAdmin.Location = new System.Drawing.Point(179, 10);
            this.gb_EventAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_EventAdmin.Name = "gb_EventAdmin";
            this.gb_EventAdmin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_EventAdmin.Size = new System.Drawing.Size(147, 209);
            this.gb_EventAdmin.TabIndex = 5;
            this.gb_EventAdmin.TabStop = false;
            this.gb_EventAdmin.Text = "Event Administration";
            // 
            // gb_SysAdmin
            // 
            this.gb_SysAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_SysAdmin.Controls.Add(this.b_BalanceAdj);
            this.gb_SysAdmin.Controls.Add(this.b_UserAdmin);
            this.gb_SysAdmin.Enabled = false;
            this.gb_SysAdmin.Location = new System.Drawing.Point(179, 228);
            this.gb_SysAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_SysAdmin.Name = "gb_SysAdmin";
            this.gb_SysAdmin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_SysAdmin.Size = new System.Drawing.Size(147, 209);
            this.gb_SysAdmin.TabIndex = 6;
            this.gb_SysAdmin.TabStop = false;
            this.gb_SysAdmin.Text = "System Administration";
            // 
            // b_BalanceAdj
            // 
            this.b_BalanceAdj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_BalanceAdj.Location = new System.Drawing.Point(17, 113);
            this.b_BalanceAdj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_BalanceAdj.Name = "b_BalanceAdj";
            this.b_BalanceAdj.Size = new System.Drawing.Size(113, 70);
            this.b_BalanceAdj.TabIndex = 1;
            this.b_BalanceAdj.Text = "Balance Adjusment";
            this.b_BalanceAdj.UseVisualStyleBackColor = true;
            this.b_BalanceAdj.Click += new System.EventHandler(this.b_BalanceAdj_Click);
            // 
            // b_UserAdmin
            // 
            this.b_UserAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_UserAdmin.Location = new System.Drawing.Point(17, 30);
            this.b_UserAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_UserAdmin.Name = "b_UserAdmin";
            this.b_UserAdmin.Size = new System.Drawing.Size(113, 70);
            this.b_UserAdmin.TabIndex = 0;
            this.b_UserAdmin.Text = "User Administration";
            this.b_UserAdmin.UseVisualStyleBackColor = true;
            this.b_UserAdmin.Click += new System.EventHandler(this.b_UserAdmin_Click);
            // 
            // f_InventorySysFE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 447);
            this.Controls.Add(this.gb_SysAdmin);
            this.Controls.Add(this.gb_EventAdmin);
            this.Controls.Add(this.gb_CountFunctions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f_InventorySysFE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System Front End Ver 2.7";
            this.gb_CountFunctions.ResumeLayout(false);
            this.gb_EventAdmin.ResumeLayout(false);
            this.gb_SysAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_CountFunctions;
        private System.Windows.Forms.Button b_MOTag;
        private System.Windows.Forms.Button b_AdminForm;
        private System.Windows.Forms.Button b_TagCapture;
        private System.Windows.Forms.GroupBox gb_EventAdmin;
        private System.Windows.Forms.GroupBox gb_SysAdmin;
        private System.Windows.Forms.Button b_UserAdmin;
        private System.Windows.Forms.Button b_BalanceAdj;
        private System.Windows.Forms.Button b_ItemMaster;
    }
}