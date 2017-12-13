﻿namespace Balance_Adjusments
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
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.b_CloseConnection = new System.Windows.Forms.Button();
            this.b_Connec2FS = new System.Windows.Forms.Button();
            this.gb_FSCredentials = new System.Windows.Forms.GroupBox();
            this.b_CFGBrowse = new System.Windows.Forms.Button();
            this.tb_FSCFGFile = new System.Windows.Forms.TextBox();
            this.CFG_File = new System.Windows.Forms.Label();
            this.tb_FSPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_FSUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_TransactionAdmin = new System.Windows.Forms.TabPage();
            this.gb_TransactionInfo = new System.Windows.Forms.GroupBox();
            this.b_CreateFSTI = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.b_LoadTags = new System.Windows.Forms.Button();
            this.tb_InvAccount = new System.Windows.Forms.TextBox();
            this.tb_DocNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ReasonCode = new System.Windows.Forms.TextBox();
            this.dgv_BalanceTags = new System.Windows.Forms.DataGridView();
            this.l_EventStatus = new System.Windows.Forms.Label();
            this.cb_Lock = new System.Windows.Forms.CheckBox();
            this.cb_InvEvent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tp_TransactionProcess = new System.Windows.Forms.TabPage();
            this.gb_TransactionProcess = new System.Windows.Forms.GroupBox();
            this.b_UploadTransactions = new System.Windows.Forms.Button();
            this.dgv_FSTI_T = new System.Windows.Forms.DataGridView();
            this.b_LoadTransactions = new System.Windows.Forms.Button();
            this.tb_FSTITransactionsQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tp_Log = new System.Windows.Forms.TabPage();
            this.rtb_FSTI_Log = new System.Windows.Forms.RichTextBox();
            this.tc_InvBalanceAdj.SuspendLayout();
            this.tp_FSCfg.SuspendLayout();
            this.gb_FSCredentials.SuspendLayout();
            this.tp_TransactionAdmin.SuspendLayout();
            this.gb_TransactionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BalanceTags)).BeginInit();
            this.tp_TransactionProcess.SuspendLayout();
            this.gb_TransactionProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FSTI_T)).BeginInit();
            this.tp_Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_InvBalanceAdj
            // 
            this.tc_InvBalanceAdj.Controls.Add(this.tp_FSCfg);
            this.tc_InvBalanceAdj.Controls.Add(this.tp_TransactionAdmin);
            this.tc_InvBalanceAdj.Controls.Add(this.tp_TransactionProcess);
            this.tc_InvBalanceAdj.Controls.Add(this.tp_Log);
            this.tc_InvBalanceAdj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_InvBalanceAdj.Location = new System.Drawing.Point(0, 0);
            this.tc_InvBalanceAdj.Margin = new System.Windows.Forms.Padding(2);
            this.tc_InvBalanceAdj.Name = "tc_InvBalanceAdj";
            this.tc_InvBalanceAdj.SelectedIndex = 0;
            this.tc_InvBalanceAdj.Size = new System.Drawing.Size(732, 572);
            this.tc_InvBalanceAdj.TabIndex = 0;
            // 
            // tp_FSCfg
            // 
            this.tp_FSCfg.Controls.Add(this.rtb_Log);
            this.tp_FSCfg.Controls.Add(this.b_CloseConnection);
            this.tp_FSCfg.Controls.Add(this.b_Connec2FS);
            this.tp_FSCfg.Controls.Add(this.gb_FSCredentials);
            this.tp_FSCfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_FSCfg.Location = new System.Drawing.Point(4, 22);
            this.tp_FSCfg.Margin = new System.Windows.Forms.Padding(2);
            this.tp_FSCfg.Name = "tp_FSCfg";
            this.tp_FSCfg.Padding = new System.Windows.Forms.Padding(2);
            this.tp_FSCfg.Size = new System.Drawing.Size(724, 546);
            this.tp_FSCfg.TabIndex = 0;
            this.tp_FSCfg.Text = "FS Configuration";
            this.tp_FSCfg.UseVisualStyleBackColor = true;
            // 
            // rtb_Log
            // 
            this.rtb_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Log.BackColor = System.Drawing.Color.White;
            this.rtb_Log.Location = new System.Drawing.Point(15, 255);
            this.rtb_Log.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.ReadOnly = true;
            this.rtb_Log.Size = new System.Drawing.Size(696, 280);
            this.rtb_Log.TabIndex = 5;
            this.rtb_Log.Text = "";
            // 
            // b_CloseConnection
            // 
            this.b_CloseConnection.Enabled = false;
            this.b_CloseConnection.Location = new System.Drawing.Point(193, 203);
            this.b_CloseConnection.Margin = new System.Windows.Forms.Padding(2);
            this.b_CloseConnection.Name = "b_CloseConnection";
            this.b_CloseConnection.Size = new System.Drawing.Size(146, 29);
            this.b_CloseConnection.TabIndex = 4;
            this.b_CloseConnection.Text = "Close Connection";
            this.b_CloseConnection.UseVisualStyleBackColor = true;
            this.b_CloseConnection.Click += new System.EventHandler(this.b_CloseConnection_Click);
            // 
            // b_Connec2FS
            // 
            this.b_Connec2FS.Location = new System.Drawing.Point(31, 203);
            this.b_Connec2FS.Margin = new System.Windows.Forms.Padding(2);
            this.b_Connec2FS.Name = "b_Connec2FS";
            this.b_Connec2FS.Size = new System.Drawing.Size(146, 29);
            this.b_Connec2FS.TabIndex = 3;
            this.b_Connec2FS.Text = "Connect to FS";
            this.b_Connec2FS.UseVisualStyleBackColor = true;
            this.b_Connec2FS.Click += new System.EventHandler(this.b_Connec2FS_Click);
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
            this.gb_FSCredentials.Location = new System.Drawing.Point(15, 15);
            this.gb_FSCredentials.Margin = new System.Windows.Forms.Padding(2);
            this.gb_FSCredentials.Name = "gb_FSCredentials";
            this.gb_FSCredentials.Padding = new System.Windows.Forms.Padding(2);
            this.gb_FSCredentials.Size = new System.Drawing.Size(344, 167);
            this.gb_FSCredentials.TabIndex = 2;
            this.gb_FSCredentials.TabStop = false;
            this.gb_FSCredentials.Text = "FS Credentials";
            // 
            // b_CFGBrowse
            // 
            this.b_CFGBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_CFGBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_CFGBrowse.Location = new System.Drawing.Point(304, 132);
            this.b_CFGBrowse.Name = "b_CFGBrowse";
            this.b_CFGBrowse.Size = new System.Drawing.Size(27, 18);
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
            this.tb_FSCFGFile.Location = new System.Drawing.Point(16, 132);
            this.tb_FSCFGFile.Name = "tb_FSCFGFile";
            this.tb_FSCFGFile.Size = new System.Drawing.Size(281, 19);
            this.tb_FSCFGFile.TabIndex = 20;
            this.tb_FSCFGFile.Text = "m:\\mfgsys\\fs.cfg";
            // 
            // CFG_File
            // 
            this.CFG_File.AutoSize = true;
            this.CFG_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CFG_File.Location = new System.Drawing.Point(14, 115);
            this.CFG_File.Name = "CFG_File";
            this.CFG_File.Size = new System.Drawing.Size(78, 13);
            this.CFG_File.TabIndex = 19;
            this.CFG_File.Text = "FS CFG File:";
            // 
            // tb_FSPassword
            // 
            this.tb_FSPassword.Location = new System.Drawing.Point(16, 80);
            this.tb_FSPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tb_FSPassword.Name = "tb_FSPassword";
            this.tb_FSPassword.PasswordChar = '*';
            this.tb_FSPassword.Size = new System.Drawing.Size(125, 19);
            this.tb_FSPassword.TabIndex = 2;
            this.tb_FSPassword.Text = "fstiapp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FS Password:";
            // 
            // tb_FSUser
            // 
            this.tb_FSUser.Location = new System.Drawing.Point(16, 36);
            this.tb_FSUser.Margin = new System.Windows.Forms.Padding(2);
            this.tb_FSUser.Name = "tb_FSUser";
            this.tb_FSUser.Size = new System.Drawing.Size(125, 19);
            this.tb_FSUser.TabIndex = 0;
            this.tb_FSUser.Text = "IMPT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FS User:";
            // 
            // tp_TransactionAdmin
            // 
            this.tp_TransactionAdmin.Controls.Add(this.gb_TransactionInfo);
            this.tp_TransactionAdmin.Controls.Add(this.dgv_BalanceTags);
            this.tp_TransactionAdmin.Controls.Add(this.l_EventStatus);
            this.tp_TransactionAdmin.Controls.Add(this.cb_Lock);
            this.tp_TransactionAdmin.Controls.Add(this.cb_InvEvent);
            this.tp_TransactionAdmin.Controls.Add(this.label3);
            this.tp_TransactionAdmin.Location = new System.Drawing.Point(4, 22);
            this.tp_TransactionAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.tp_TransactionAdmin.Name = "tp_TransactionAdmin";
            this.tp_TransactionAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.tp_TransactionAdmin.Size = new System.Drawing.Size(724, 546);
            this.tp_TransactionAdmin.TabIndex = 1;
            this.tp_TransactionAdmin.Text = "Transaction Administration";
            this.tp_TransactionAdmin.UseVisualStyleBackColor = true;
            // 
            // gb_TransactionInfo
            // 
            this.gb_TransactionInfo.Controls.Add(this.b_CreateFSTI);
            this.gb_TransactionInfo.Controls.Add(this.label6);
            this.gb_TransactionInfo.Controls.Add(this.b_LoadTags);
            this.gb_TransactionInfo.Controls.Add(this.tb_InvAccount);
            this.gb_TransactionInfo.Controls.Add(this.tb_DocNo);
            this.gb_TransactionInfo.Controls.Add(this.label5);
            this.gb_TransactionInfo.Controls.Add(this.label4);
            this.gb_TransactionInfo.Controls.Add(this.tb_ReasonCode);
            this.gb_TransactionInfo.Enabled = false;
            this.gb_TransactionInfo.Location = new System.Drawing.Point(22, 50);
            this.gb_TransactionInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gb_TransactionInfo.Name = "gb_TransactionInfo";
            this.gb_TransactionInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gb_TransactionInfo.Size = new System.Drawing.Size(682, 98);
            this.gb_TransactionInfo.TabIndex = 22;
            this.gb_TransactionInfo.TabStop = false;
            this.gb_TransactionInfo.Text = "Transaction Information";
            // 
            // b_CreateFSTI
            // 
            this.b_CreateFSTI.Enabled = false;
            this.b_CreateFSTI.Location = new System.Drawing.Point(559, 62);
            this.b_CreateFSTI.Margin = new System.Windows.Forms.Padding(2);
            this.b_CreateFSTI.Name = "b_CreateFSTI";
            this.b_CreateFSTI.Size = new System.Drawing.Size(110, 23);
            this.b_CreateFSTI.TabIndex = 24;
            this.b_CreateFSTI.Text = "Create Transaction";
            this.b_CreateFSTI.UseVisualStyleBackColor = true;
            this.b_CreateFSTI.Click += new System.EventHandler(this.b_CreateFSTI_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Inv Account:";
            // 
            // b_LoadTags
            // 
            this.b_LoadTags.Enabled = false;
            this.b_LoadTags.Location = new System.Drawing.Point(443, 62);
            this.b_LoadTags.Margin = new System.Windows.Forms.Padding(2);
            this.b_LoadTags.Name = "b_LoadTags";
            this.b_LoadTags.Size = new System.Drawing.Size(110, 23);
            this.b_LoadTags.TabIndex = 17;
            this.b_LoadTags.Text = "Load Tags";
            this.b_LoadTags.UseVisualStyleBackColor = true;
            this.b_LoadTags.Click += new System.EventHandler(this.b_LoadTags_Click);
            // 
            // tb_InvAccount
            // 
            this.tb_InvAccount.Location = new System.Drawing.Point(559, 24);
            this.tb_InvAccount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_InvAccount.Name = "tb_InvAccount";
            this.tb_InvAccount.Size = new System.Drawing.Size(110, 20);
            this.tb_InvAccount.TabIndex = 22;
            // 
            // tb_DocNo
            // 
            this.tb_DocNo.Location = new System.Drawing.Point(105, 24);
            this.tb_DocNo.Margin = new System.Windows.Forms.Padding(2);
            this.tb_DocNo.Name = "tb_DocNo";
            this.tb_DocNo.Size = new System.Drawing.Size(110, 20);
            this.tb_DocNo.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Reason Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Document No:";
            // 
            // tb_ReasonCode
            // 
            this.tb_ReasonCode.Location = new System.Drawing.Point(332, 24);
            this.tb_ReasonCode.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ReasonCode.Name = "tb_ReasonCode";
            this.tb_ReasonCode.Size = new System.Drawing.Size(110, 20);
            this.tb_ReasonCode.TabIndex = 20;
            // 
            // dgv_BalanceTags
            // 
            this.dgv_BalanceTags.AllowUserToAddRows = false;
            this.dgv_BalanceTags.AllowUserToDeleteRows = false;
            this.dgv_BalanceTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BalanceTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BalanceTags.Location = new System.Drawing.Point(22, 152);
            this.dgv_BalanceTags.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_BalanceTags.Name = "dgv_BalanceTags";
            this.dgv_BalanceTags.ReadOnly = true;
            this.dgv_BalanceTags.RowTemplate.Height = 24;
            this.dgv_BalanceTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BalanceTags.Size = new System.Drawing.Size(682, 376);
            this.dgv_BalanceTags.TabIndex = 16;
            // 
            // l_EventStatus
            // 
            this.l_EventStatus.AutoSize = true;
            this.l_EventStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_EventStatus.ForeColor = System.Drawing.Color.Green;
            this.l_EventStatus.Location = new System.Drawing.Point(418, 16);
            this.l_EventStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_EventStatus.Name = "l_EventStatus";
            this.l_EventStatus.Size = new System.Drawing.Size(52, 17);
            this.l_EventStatus.TabIndex = 15;
            this.l_EventStatus.Text = "status";
            // 
            // cb_Lock
            // 
            this.cb_Lock.AutoSize = true;
            this.cb_Lock.Location = new System.Drawing.Point(352, 17);
            this.cb_Lock.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Lock.Name = "cb_Lock";
            this.cb_Lock.Size = new System.Drawing.Size(50, 17);
            this.cb_Lock.TabIndex = 14;
            this.cb_Lock.Text = "Lock";
            this.cb_Lock.UseVisualStyleBackColor = true;
            this.cb_Lock.CheckedChanged += new System.EventHandler(this.cb_Lock_CheckedChanged);
            // 
            // cb_InvEvent
            // 
            this.cb_InvEvent.FormattingEnabled = true;
            this.cb_InvEvent.Location = new System.Drawing.Point(149, 15);
            this.cb_InvEvent.Margin = new System.Windows.Forms.Padding(2);
            this.cb_InvEvent.Name = "cb_InvEvent";
            this.cb_InvEvent.Size = new System.Drawing.Size(186, 21);
            this.cb_InvEvent.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Inventory Event List:";
            // 
            // tp_TransactionProcess
            // 
            this.tp_TransactionProcess.Controls.Add(this.gb_TransactionProcess);
            this.tp_TransactionProcess.Location = new System.Drawing.Point(4, 22);
            this.tp_TransactionProcess.Margin = new System.Windows.Forms.Padding(2);
            this.tp_TransactionProcess.Name = "tp_TransactionProcess";
            this.tp_TransactionProcess.Padding = new System.Windows.Forms.Padding(2);
            this.tp_TransactionProcess.Size = new System.Drawing.Size(724, 546);
            this.tp_TransactionProcess.TabIndex = 2;
            this.tp_TransactionProcess.Text = "Transaction Process";
            this.tp_TransactionProcess.UseVisualStyleBackColor = true;
            // 
            // gb_TransactionProcess
            // 
            this.gb_TransactionProcess.Controls.Add(this.b_UploadTransactions);
            this.gb_TransactionProcess.Controls.Add(this.dgv_FSTI_T);
            this.gb_TransactionProcess.Controls.Add(this.b_LoadTransactions);
            this.gb_TransactionProcess.Controls.Add(this.tb_FSTITransactionsQty);
            this.gb_TransactionProcess.Controls.Add(this.label7);
            this.gb_TransactionProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_TransactionProcess.Enabled = false;
            this.gb_TransactionProcess.Location = new System.Drawing.Point(2, 2);
            this.gb_TransactionProcess.Margin = new System.Windows.Forms.Padding(2);
            this.gb_TransactionProcess.Name = "gb_TransactionProcess";
            this.gb_TransactionProcess.Padding = new System.Windows.Forms.Padding(2);
            this.gb_TransactionProcess.Size = new System.Drawing.Size(720, 542);
            this.gb_TransactionProcess.TabIndex = 0;
            this.gb_TransactionProcess.TabStop = false;
            this.gb_TransactionProcess.Text = "Forth Shift Data Upload";
            // 
            // b_UploadTransactions
            // 
            this.b_UploadTransactions.Location = new System.Drawing.Point(486, 80);
            this.b_UploadTransactions.Name = "b_UploadTransactions";
            this.b_UploadTransactions.Size = new System.Drawing.Size(224, 33);
            this.b_UploadTransactions.TabIndex = 5;
            this.b_UploadTransactions.Text = "Upload Transactions";
            this.b_UploadTransactions.UseVisualStyleBackColor = true;
            this.b_UploadTransactions.Click += new System.EventHandler(this.b_UploadTransactions_Click);
            // 
            // dgv_FSTI_T
            // 
            this.dgv_FSTI_T.AllowUserToAddRows = false;
            this.dgv_FSTI_T.AllowUserToDeleteRows = false;
            this.dgv_FSTI_T.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_FSTI_T.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FSTI_T.Location = new System.Drawing.Point(4, 141);
            this.dgv_FSTI_T.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_FSTI_T.Name = "dgv_FSTI_T";
            this.dgv_FSTI_T.ReadOnly = true;
            this.dgv_FSTI_T.RowTemplate.Height = 24;
            this.dgv_FSTI_T.Size = new System.Drawing.Size(711, 396);
            this.dgv_FSTI_T.TabIndex = 4;
            // 
            // b_LoadTransactions
            // 
            this.b_LoadTransactions.Location = new System.Drawing.Point(486, 20);
            this.b_LoadTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.b_LoadTransactions.Name = "b_LoadTransactions";
            this.b_LoadTransactions.Size = new System.Drawing.Size(224, 31);
            this.b_LoadTransactions.TabIndex = 3;
            this.b_LoadTransactions.Text = "Load FSTI Transactions";
            this.b_LoadTransactions.UseVisualStyleBackColor = true;
            this.b_LoadTransactions.Click += new System.EventHandler(this.b_LoadTransactions_Click);
            // 
            // tb_FSTITransactionsQty
            // 
            this.tb_FSTITransactionsQty.Enabled = false;
            this.tb_FSTITransactionsQty.Location = new System.Drawing.Point(155, 27);
            this.tb_FSTITransactionsQty.Margin = new System.Windows.Forms.Padding(2);
            this.tb_FSTITransactionsQty.Name = "tb_FSTITransactionsQty";
            this.tb_FSTITransactionsQty.Size = new System.Drawing.Size(104, 20);
            this.tb_FSTITransactionsQty.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "# of FSTI Transactions";
            // 
            // tp_Log
            // 
            this.tp_Log.Controls.Add(this.rtb_FSTI_Log);
            this.tp_Log.Location = new System.Drawing.Point(4, 22);
            this.tp_Log.Margin = new System.Windows.Forms.Padding(2);
            this.tp_Log.Name = "tp_Log";
            this.tp_Log.Padding = new System.Windows.Forms.Padding(2);
            this.tp_Log.Size = new System.Drawing.Size(724, 546);
            this.tp_Log.TabIndex = 3;
            this.tp_Log.Text = "Log Info";
            this.tp_Log.UseVisualStyleBackColor = true;
            // 
            // rtb_FSTI_Log
            // 
            this.rtb_FSTI_Log.BackColor = System.Drawing.Color.White;
            this.rtb_FSTI_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_FSTI_Log.Location = new System.Drawing.Point(2, 2);
            this.rtb_FSTI_Log.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_FSTI_Log.Name = "rtb_FSTI_Log";
            this.rtb_FSTI_Log.ReadOnly = true;
            this.rtb_FSTI_Log.Size = new System.Drawing.Size(720, 542);
            this.rtb_FSTI_Log.TabIndex = 2;
            this.rtb_FSTI_Log.Text = "";
            // 
            // f_BalanceAdj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 572);
            this.Controls.Add(this.tc_InvBalanceAdj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "f_BalanceAdj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance Adjusments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_BalanceAdj_FormClosing);
            this.tc_InvBalanceAdj.ResumeLayout(false);
            this.tp_FSCfg.ResumeLayout(false);
            this.gb_FSCredentials.ResumeLayout(false);
            this.gb_FSCredentials.PerformLayout();
            this.tp_TransactionAdmin.ResumeLayout(false);
            this.tp_TransactionAdmin.PerformLayout();
            this.gb_TransactionInfo.ResumeLayout(false);
            this.gb_TransactionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BalanceTags)).EndInit();
            this.tp_TransactionProcess.ResumeLayout(false);
            this.gb_TransactionProcess.ResumeLayout(false);
            this.gb_TransactionProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FSTI_T)).EndInit();
            this.tp_Log.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_InvBalanceAdj;
        private System.Windows.Forms.TabPage tp_FSCfg;
        private System.Windows.Forms.TabPage tp_TransactionAdmin;
        private System.Windows.Forms.GroupBox gb_FSCredentials;
        private System.Windows.Forms.Button b_CFGBrowse;
        private System.Windows.Forms.TextBox tb_FSCFGFile;
        private System.Windows.Forms.Label CFG_File;
        private System.Windows.Forms.TextBox tb_FSPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_FSUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.Button b_CloseConnection;
        private System.Windows.Forms.Button b_Connec2FS;
        private System.Windows.Forms.Label l_EventStatus;
        private System.Windows.Forms.CheckBox cb_Lock;
        private System.Windows.Forms.ComboBox cb_InvEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_BalanceTags;
        private System.Windows.Forms.Button b_LoadTags;
        private System.Windows.Forms.TabPage tp_TransactionProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_DocNo;
        private System.Windows.Forms.GroupBox gb_TransactionInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_InvAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ReasonCode;
        private System.Windows.Forms.Button b_CreateFSTI;
        private System.Windows.Forms.GroupBox gb_TransactionProcess;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button b_LoadTransactions;
        private System.Windows.Forms.TextBox tb_FSTITransactionsQty;
        private System.Windows.Forms.TabPage tp_Log;
        private System.Windows.Forms.RichTextBox rtb_FSTI_Log;
        private System.Windows.Forms.DataGridView dgv_FSTI_T;
        private System.Windows.Forms.Button b_UploadTransactions;
    }
}

