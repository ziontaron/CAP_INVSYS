namespace Balance_Adjusments
{
    partial class f_BalanceAdj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_BalanceAdj));
            this.tc_InvBalanceAdj = new System.Windows.Forms.TabControl();
            this.tp_FSCfg = new System.Windows.Forms.TabPage();
            this.gb_FSCredentials = new System.Windows.Forms.GroupBox();
            this.b_CFGBrowse = new System.Windows.Forms.Button();
            this.tb_FSCFGFile = new System.Windows.Forms.TextBox();
            this.CFG_File = new System.Windows.Forms.Label();
            this.tb_FSPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_FSUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.tc_InvBalanceAdj.SuspendLayout();
            this.tp_FSCfg.SuspendLayout();
            this.gb_FSCredentials.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_InvBalanceAdj
            // 
            this.tc_InvBalanceAdj.Controls.Add(this.tp_FSCfg);
            this.tc_InvBalanceAdj.Controls.Add(this.tabPage2);
            this.tc_InvBalanceAdj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_InvBalanceAdj.Location = new System.Drawing.Point(0, 0);
            this.tc_InvBalanceAdj.Name = "tc_InvBalanceAdj";
            this.tc_InvBalanceAdj.SelectedIndex = 0;
            this.tc_InvBalanceAdj.Size = new System.Drawing.Size(976, 640);
            this.tc_InvBalanceAdj.TabIndex = 0;
            // 
            // tp_FSCfg
            // 
            this.tp_FSCfg.Controls.Add(this.rtb_Log);
            this.tp_FSCfg.Controls.Add(this.button2);
            this.tp_FSCfg.Controls.Add(this.button1);
            this.tp_FSCfg.Controls.Add(this.gb_FSCredentials);
            this.tp_FSCfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_FSCfg.Location = new System.Drawing.Point(4, 25);
            this.tp_FSCfg.Name = "tp_FSCfg";
            this.tp_FSCfg.Padding = new System.Windows.Forms.Padding(3);
            this.tp_FSCfg.Size = new System.Drawing.Size(968, 611);
            this.tp_FSCfg.TabIndex = 0;
            this.tp_FSCfg.Text = "FS Configuration";
            this.tp_FSCfg.UseVisualStyleBackColor = true;
            // 
            // gb_FSCredentials
            // 
            this.gb_FSCredentials.Controls.Add(this.b_CFGBrowse);
            this.gb_FSCredentials.Controls.Add(this.tb_FSCFGFile);
            this.gb_FSCredentials.Controls.Add(this.CFG_File);
            this.gb_FSCredentials.Controls.Add(this.tb_FSPassword);
            this.gb_FSCredentials.Controls.Add(this.label2);
            this.gb_FSCredentials.Controls.Add(this.tb_FSUser);
            this.gb_FSCredentials.Controls.Add(this.label1);
            this.gb_FSCredentials.Location = new System.Drawing.Point(20, 18);
            this.gb_FSCredentials.Name = "gb_FSCredentials";
            this.gb_FSCredentials.Size = new System.Drawing.Size(458, 205);
            this.gb_FSCredentials.TabIndex = 2;
            this.gb_FSCredentials.TabStop = false;
            this.gb_FSCredentials.Text = "FS Credentials";
            // 
            // b_CFGBrowse
            // 
            this.b_CFGBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_CFGBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_CFGBrowse.Location = new System.Drawing.Point(405, 163);
            this.b_CFGBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.b_CFGBrowse.Name = "b_CFGBrowse";
            this.b_CFGBrowse.Size = new System.Drawing.Size(36, 22);
            this.b_CFGBrowse.TabIndex = 21;
            this.b_CFGBrowse.Text = "...";
            this.b_CFGBrowse.UseVisualStyleBackColor = true;
            this.b_CFGBrowse.Click += new System.EventHandler(this.b_CFGBrowse_Click);
            // 
            // tb_FSCFGFile
            // 
            this.tb_FSCFGFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_FSCFGFile.Enabled = false;
            this.tb_FSCFGFile.Location = new System.Drawing.Point(21, 163);
            this.tb_FSCFGFile.Margin = new System.Windows.Forms.Padding(4);
            this.tb_FSCFGFile.Name = "tb_FSCFGFile";
            this.tb_FSCFGFile.Size = new System.Drawing.Size(373, 22);
            this.tb_FSCFGFile.TabIndex = 20;
            this.tb_FSCFGFile.Text = "m:\\mfgsys\\fs.cfg";
            // 
            // CFG_File
            // 
            this.CFG_File.AutoSize = true;
            this.CFG_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CFG_File.Location = new System.Drawing.Point(18, 142);
            this.CFG_File.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CFG_File.Name = "CFG_File";
            this.CFG_File.Size = new System.Drawing.Size(99, 17);
            this.CFG_File.TabIndex = 19;
            this.CFG_File.Text = "FS CFG File:";
            // 
            // tb_FSPassword
            // 
            this.tb_FSPassword.Location = new System.Drawing.Point(21, 99);
            this.tb_FSPassword.Name = "tb_FSPassword";
            this.tb_FSPassword.PasswordChar = '*';
            this.tb_FSPassword.Size = new System.Drawing.Size(165, 22);
            this.tb_FSPassword.TabIndex = 2;
            this.tb_FSPassword.Text = "fstiapp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "FS Password:";
            // 
            // tb_FSUser
            // 
            this.tb_FSUser.Location = new System.Drawing.Point(21, 44);
            this.tb_FSUser.Name = "tb_FSUser";
            this.tb_FSUser.Size = new System.Drawing.Size(165, 22);
            this.tb_FSUser.TabIndex = 0;
            this.tb_FSUser.Text = "IMPT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "FS User:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(968, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Connect to FS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close Connection";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rtb_Log
            // 
            this.rtb_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Log.Location = new System.Drawing.Point(20, 314);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.ReadOnly = true;
            this.rtb_Log.Size = new System.Drawing.Size(926, 274);
            this.rtb_Log.TabIndex = 5;
            this.rtb_Log.Text = "";
            // 
            // f_BalanceAdj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 640);
            this.Controls.Add(this.tc_InvBalanceAdj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_BalanceAdj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance Adjusments";
            this.tc_InvBalanceAdj.ResumeLayout(false);
            this.tp_FSCfg.ResumeLayout(false);
            this.gb_FSCredentials.ResumeLayout(false);
            this.gb_FSCredentials.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_InvBalanceAdj;
        private System.Windows.Forms.TabPage tp_FSCfg;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gb_FSCredentials;
        private System.Windows.Forms.Button b_CFGBrowse;
        private System.Windows.Forms.TextBox tb_FSCFGFile;
        private System.Windows.Forms.Label CFG_File;
        private System.Windows.Forms.TextBox tb_FSPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_FSUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

