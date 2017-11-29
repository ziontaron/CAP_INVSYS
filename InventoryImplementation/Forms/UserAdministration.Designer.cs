namespace InventoryImplementation
{
    partial class f_UserAdministration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_UserAdministration));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.tc_UserCrontrolFunctions = new System.Windows.Forms.TabControl();
            this.tp_NewUser = new System.Windows.Forms.TabPage();
            this.tb_PassConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.b_SaveUser = new System.Windows.Forms.Button();
            this.cb_UserRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tp_UserList = new System.Windows.Forms.TabPage();
            this.dgv_UsersList = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pb_NO = new System.Windows.Forms.PictureBox();
            this.pb_OK = new System.Windows.Forms.PictureBox();
            this.tc_UserCrontrolFunctions.SuspendLayout();
            this.tp_NewUser.SuspendLayout();
            this.tp_UserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsersList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_OK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New User Name:";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(196, 37);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(254, 22);
            this.tb_UserName.TabIndex = 1;
            this.tb_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_UserName_KeyDown);
            // 
            // tc_UserCrontrolFunctions
            // 
            this.tc_UserCrontrolFunctions.Controls.Add(this.tp_NewUser);
            this.tc_UserCrontrolFunctions.Controls.Add(this.tp_UserList);
            this.tc_UserCrontrolFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_UserCrontrolFunctions.Location = new System.Drawing.Point(0, 0);
            this.tc_UserCrontrolFunctions.Name = "tc_UserCrontrolFunctions";
            this.tc_UserCrontrolFunctions.SelectedIndex = 0;
            this.tc_UserCrontrolFunctions.Size = new System.Drawing.Size(524, 393);
            this.tc_UserCrontrolFunctions.TabIndex = 3;
            // 
            // tp_NewUser
            // 
            this.tp_NewUser.Controls.Add(this.pb_NO);
            this.tp_NewUser.Controls.Add(this.pb_OK);
            this.tp_NewUser.Controls.Add(this.tb_PassConfirm);
            this.tp_NewUser.Controls.Add(this.label4);
            this.tp_NewUser.Controls.Add(this.b_SaveUser);
            this.tp_NewUser.Controls.Add(this.cb_UserRole);
            this.tp_NewUser.Controls.Add(this.label3);
            this.tp_NewUser.Controls.Add(this.tb_Password);
            this.tp_NewUser.Controls.Add(this.label2);
            this.tp_NewUser.Controls.Add(this.tb_UserName);
            this.tp_NewUser.Controls.Add(this.label1);
            this.tp_NewUser.Location = new System.Drawing.Point(4, 25);
            this.tp_NewUser.Name = "tp_NewUser";
            this.tp_NewUser.Padding = new System.Windows.Forms.Padding(3);
            this.tp_NewUser.Size = new System.Drawing.Size(516, 364);
            this.tp_NewUser.TabIndex = 0;
            this.tp_NewUser.Text = "New User";
            this.tp_NewUser.UseVisualStyleBackColor = true;
            // 
            // tb_PassConfirm
            // 
            this.tb_PassConfirm.Location = new System.Drawing.Point(196, 113);
            this.tb_PassConfirm.Name = "tb_PassConfirm";
            this.tb_PassConfirm.PasswordChar = '*';
            this.tb_PassConfirm.Size = new System.Drawing.Size(254, 22);
            this.tb_PassConfirm.TabIndex = 4;
            this.tb_PassConfirm.TextChanged += new System.EventHandler(this.tb_PassConfirm_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password:";
            // 
            // b_SaveUser
            // 
            this.b_SaveUser.Location = new System.Drawing.Point(346, 209);
            this.b_SaveUser.Name = "b_SaveUser";
            this.b_SaveUser.Size = new System.Drawing.Size(104, 37);
            this.b_SaveUser.TabIndex = 6;
            this.b_SaveUser.Text = "Save User";
            this.b_SaveUser.UseVisualStyleBackColor = true;
            this.b_SaveUser.Click += new System.EventHandler(this.b_SaveUser_Click);
            // 
            // cb_UserRole
            // 
            this.cb_UserRole.FormattingEnabled = true;
            this.cb_UserRole.Location = new System.Drawing.Point(196, 152);
            this.cb_UserRole.Name = "cb_UserRole";
            this.cb_UserRole.Size = new System.Drawing.Size(254, 24);
            this.cb_UserRole.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Role:";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(196, 76);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(254, 22);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Password_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // tp_UserList
            // 
            this.tp_UserList.Controls.Add(this.statusStrip1);
            this.tp_UserList.Controls.Add(this.dgv_UsersList);
            this.tp_UserList.Location = new System.Drawing.Point(4, 25);
            this.tp_UserList.Name = "tp_UserList";
            this.tp_UserList.Padding = new System.Windows.Forms.Padding(3);
            this.tp_UserList.Size = new System.Drawing.Size(516, 364);
            this.tp_UserList.TabIndex = 1;
            this.tp_UserList.Text = "User List";
            this.tp_UserList.UseVisualStyleBackColor = true;
            // 
            // dgv_UsersList
            // 
            this.dgv_UsersList.AllowUserToAddRows = false;
            this.dgv_UsersList.AllowUserToDeleteRows = false;
            this.dgv_UsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UsersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_UsersList.Location = new System.Drawing.Point(3, 3);
            this.dgv_UsersList.MultiSelect = false;
            this.dgv_UsersList.Name = "dgv_UsersList";
            this.dgv_UsersList.ReadOnly = true;
            this.dgv_UsersList.RowTemplate.Height = 24;
            this.dgv_UsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UsersList.Size = new System.Drawing.Size(510, 358);
            this.dgv_UsersList.TabIndex = 0;
            this.dgv_UsersList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_UsersList_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(3, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(510, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(95, 20);
            this.toolStripStatusLabel1.Text = "F5 to Refresh";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(98, 20);
            this.toolStripStatusLabel2.Text = "F12 to Delete";
            // 
            // pb_NO
            // 
            this.pb_NO.Image = global::InventoryImplementation.Properties.Resources.no;
            this.pb_NO.Location = new System.Drawing.Point(456, 113);
            this.pb_NO.Name = "pb_NO";
            this.pb_NO.Size = new System.Drawing.Size(27, 26);
            this.pb_NO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_NO.TabIndex = 9;
            this.pb_NO.TabStop = false;
            this.pb_NO.Visible = false;
            // 
            // pb_OK
            // 
            this.pb_OK.Image = global::InventoryImplementation.Properties.Resources.ok;
            this.pb_OK.Location = new System.Drawing.Point(456, 113);
            this.pb_OK.Name = "pb_OK";
            this.pb_OK.Size = new System.Drawing.Size(27, 26);
            this.pb_OK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_OK.TabIndex = 8;
            this.pb_OK.TabStop = false;
            // 
            // f_UserAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 393);
            this.Controls.Add(this.tc_UserCrontrolFunctions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f_UserAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Administration";
            this.tc_UserCrontrolFunctions.ResumeLayout(false);
            this.tp_NewUser.ResumeLayout(false);
            this.tp_NewUser.PerformLayout();
            this.tp_UserList.ResumeLayout(false);
            this.tp_UserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsersList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_OK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.TabControl tc_UserCrontrolFunctions;
        private System.Windows.Forms.TabPage tp_NewUser;
        private System.Windows.Forms.Button b_SaveUser;
        private System.Windows.Forms.ComboBox cb_UserRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tp_UserList;
        private System.Windows.Forms.TextBox tb_PassConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_UsersList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.PictureBox pb_OK;
        private System.Windows.Forms.PictureBox pb_NO;
    }
}