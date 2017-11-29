namespace InventoryImplementation
{
    partial class f_InventoryLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_InventoryLogin));
            this.gb_UserAccess = new System.Windows.Forms.GroupBox();
            this.b_Access = new System.Windows.Forms.Button();
            this.tb_UserPAssword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_UserAccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_UserAccess
            // 
            this.gb_UserAccess.Controls.Add(this.b_Access);
            this.gb_UserAccess.Controls.Add(this.tb_UserPAssword);
            this.gb_UserAccess.Controls.Add(this.label2);
            this.gb_UserAccess.Controls.Add(this.tb_UserName);
            this.gb_UserAccess.Controls.Add(this.label1);
            this.gb_UserAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_UserAccess.Location = new System.Drawing.Point(0, 0);
            this.gb_UserAccess.Name = "gb_UserAccess";
            this.gb_UserAccess.Size = new System.Drawing.Size(276, 200);
            this.gb_UserAccess.TabIndex = 2;
            this.gb_UserAccess.TabStop = false;
            this.gb_UserAccess.Text = "User Access";
            // 
            // b_Access
            // 
            this.b_Access.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Access.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Access.Location = new System.Drawing.Point(113, 145);
            this.b_Access.Name = "b_Access";
            this.b_Access.Size = new System.Drawing.Size(151, 43);
            this.b_Access.TabIndex = 3;
            this.b_Access.Text = "Access";
            this.b_Access.UseVisualStyleBackColor = true;
            this.b_Access.Click += new System.EventHandler(this.b_Access_Click);
            // 
            // tb_UserPAssword
            // 
            this.tb_UserPAssword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_UserPAssword.Location = new System.Drawing.Point(12, 101);
            this.tb_UserPAssword.Name = "tb_UserPAssword";
            this.tb_UserPAssword.PasswordChar = '*';
            this.tb_UserPAssword.Size = new System.Drawing.Size(258, 22);
            this.tb_UserPAssword.TabIndex = 2;
            this.tb_UserPAssword.Text = "capsonic";
            this.tb_UserPAssword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_UserPAssword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Password";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_UserName.Location = new System.Drawing.Point(12, 44);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(258, 22);
            this.tb_UserName.TabIndex = 1;
            this.tb_UserName.Text = "Admin";
            this.tb_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_UserName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // f_InventoryLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 200);
            this.Controls.Add(this.gb_UserAccess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_InventoryLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System Login";
            this.gb_UserAccess.ResumeLayout(false);
            this.gb_UserAccess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_UserAccess;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_Access;
        private System.Windows.Forms.TextBox tb_UserPAssword;
        private System.Windows.Forms.Label label2;
    }
}