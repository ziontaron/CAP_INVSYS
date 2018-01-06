namespace InventoryImplementation
{
    partial class f_InvEventAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_InvEventAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_InvEvent = new System.Windows.Forms.ComboBox();
            this.tb_EventAdmin = new System.Windows.Forms.TabControl();
            this.t_AdminEvent = new System.Windows.Forms.TabPage();
            this.b_LoadFSLM = new System.Windows.Forms.Button();
            this.b_LoadFSIM = new System.Windows.Forms.Button();
            this.b_CreateIE = new System.Windows.Forms.Button();
            this.gb_AdminEvent = new System.Windows.Forms.GroupBox();
            this.b_ChangeStatus = new System.Windows.Forms.Button();
            this.b_DeleteEvent = new System.Windows.Forms.Button();
            this.gb_BlankTags = new System.Windows.Forms.GroupBox();
            this.b_10BlankTags = new System.Windows.Forms.Button();
            this.b_100BlankTags = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.b_nBlankTags = new System.Windows.Forms.Button();
            this.tb_NTags = new System.Windows.Forms.TextBox();
            this.gb_LoadTags = new System.Windows.Forms.GroupBox();
            this.rb_EPDC_Tags = new System.Windows.Forms.RadioButton();
            this.rb_JZ_Tags = new System.Windows.Forms.RadioButton();
            this.b_MOtagsFromSQL = new System.Windows.Forms.Button();
            this.b_MOtagsFromCSV = new System.Windows.Forms.Button();
            this.b_tagsFromCSV = new System.Windows.Forms.Button();
            this.b_tagsFromSQL = new System.Windows.Forms.Button();
            this.tb_EventCreationDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.b_Clear = new System.Windows.Forms.Button();
            this.tb_ro_EventStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ro_QTYofTags = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_ro_EventDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_Stadistics = new System.Windows.Forms.TabPage();
            this.gb_IE_Stadistics = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_RefreshRateSecs = new System.Windows.Forms.TextBox();
            this.b_RefreshStats = new System.Windows.Forms.Button();
            this.gb_TicketCountStadistics = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.l_TicketCounted = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.l_MOTagsCounted = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.l_MOTags = new System.Windows.Forms.Label();
            this.l_CountedTags = new System.Windows.Forms.Label();
            this.l_TicketVoid = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l_TicketVerified = new System.Windows.Forms.Label();
            this.gb_CountedTikets = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pb_CountedTickets = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_TicketBlanks = new System.Windows.Forms.Label();
            this.l_TicketCounts = new System.Windows.Forms.Label();
            this.t_RefreshStatsRate = new System.Windows.Forms.Timer(this.components);
            this.tb_EventAdmin.SuspendLayout();
            this.t_AdminEvent.SuspendLayout();
            this.gb_AdminEvent.SuspendLayout();
            this.gb_BlankTags.SuspendLayout();
            this.gb_LoadTags.SuspendLayout();
            this.t_Stadistics.SuspendLayout();
            this.gb_IE_Stadistics.SuspendLayout();
            this.gb_TicketCountStadistics.SuspendLayout();
            this.gb_CountedTikets.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Event List";
            // 
            // cb_InvEvent
            // 
            this.cb_InvEvent.FormattingEnabled = true;
            this.cb_InvEvent.Location = new System.Drawing.Point(25, 49);
            this.cb_InvEvent.Name = "cb_InvEvent";
            this.cb_InvEvent.Size = new System.Drawing.Size(246, 24);
            this.cb_InvEvent.TabIndex = 1;
            this.cb_InvEvent.SelectedIndexChanged += new System.EventHandler(this.cb_InvEvent_SelectedIndexChanged);
            this.cb_InvEvent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_InvEvent_KeyDown);
            // 
            // tb_EventAdmin
            // 
            this.tb_EventAdmin.Controls.Add(this.t_AdminEvent);
            this.tb_EventAdmin.Controls.Add(this.t_Stadistics);
            this.tb_EventAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_EventAdmin.Location = new System.Drawing.Point(0, 0);
            this.tb_EventAdmin.Name = "tb_EventAdmin";
            this.tb_EventAdmin.SelectedIndex = 0;
            this.tb_EventAdmin.Size = new System.Drawing.Size(889, 628);
            this.tb_EventAdmin.TabIndex = 2;
            // 
            // t_AdminEvent
            // 
            this.t_AdminEvent.Controls.Add(this.b_LoadFSLM);
            this.t_AdminEvent.Controls.Add(this.b_LoadFSIM);
            this.t_AdminEvent.Controls.Add(this.b_CreateIE);
            this.t_AdminEvent.Controls.Add(this.gb_AdminEvent);
            this.t_AdminEvent.Controls.Add(this.gb_BlankTags);
            this.t_AdminEvent.Controls.Add(this.gb_LoadTags);
            this.t_AdminEvent.Controls.Add(this.tb_EventCreationDate);
            this.t_AdminEvent.Controls.Add(this.label7);
            this.t_AdminEvent.Controls.Add(this.b_Clear);
            this.t_AdminEvent.Controls.Add(this.tb_ro_EventStatus);
            this.t_AdminEvent.Controls.Add(this.label4);
            this.t_AdminEvent.Controls.Add(this.tb_ro_QTYofTags);
            this.t_AdminEvent.Controls.Add(this.label3);
            this.t_AdminEvent.Controls.Add(this.rtb_ro_EventDescription);
            this.t_AdminEvent.Controls.Add(this.label2);
            this.t_AdminEvent.Controls.Add(this.cb_InvEvent);
            this.t_AdminEvent.Controls.Add(this.label1);
            this.t_AdminEvent.Location = new System.Drawing.Point(4, 25);
            this.t_AdminEvent.Name = "t_AdminEvent";
            this.t_AdminEvent.Padding = new System.Windows.Forms.Padding(3);
            this.t_AdminEvent.Size = new System.Drawing.Size(881, 599);
            this.t_AdminEvent.TabIndex = 0;
            this.t_AdminEvent.Text = "Admin an Event";
            this.t_AdminEvent.UseVisualStyleBackColor = true;
            // 
            // b_LoadFSLM
            // 
            this.b_LoadFSLM.Enabled = false;
            this.b_LoadFSLM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_LoadFSLM.Location = new System.Drawing.Point(710, 476);
            this.b_LoadFSLM.Name = "b_LoadFSLM";
            this.b_LoadFSLM.Size = new System.Drawing.Size(146, 77);
            this.b_LoadFSLM.TabIndex = 24;
            this.b_LoadFSLM.Text = "Load FS Location Master";
            this.b_LoadFSLM.UseVisualStyleBackColor = true;
            this.b_LoadFSLM.Click += new System.EventHandler(this.b_LoadFSLM_Click);
            // 
            // b_LoadFSIM
            // 
            this.b_LoadFSIM.Enabled = false;
            this.b_LoadFSIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_LoadFSIM.Location = new System.Drawing.Point(710, 380);
            this.b_LoadFSIM.Name = "b_LoadFSIM";
            this.b_LoadFSIM.Size = new System.Drawing.Size(146, 77);
            this.b_LoadFSIM.TabIndex = 23;
            this.b_LoadFSIM.Text = "Load FS Item Master";
            this.b_LoadFSIM.UseVisualStyleBackColor = true;
            this.b_LoadFSIM.Click += new System.EventHandler(this.b_LoadFSIM_Click);
            // 
            // b_CreateIE
            // 
            this.b_CreateIE.Enabled = false;
            this.b_CreateIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_CreateIE.Location = new System.Drawing.Point(710, 281);
            this.b_CreateIE.Name = "b_CreateIE";
            this.b_CreateIE.Size = new System.Drawing.Size(146, 77);
            this.b_CreateIE.TabIndex = 22;
            this.b_CreateIE.Text = "Creale";
            this.b_CreateIE.UseVisualStyleBackColor = true;
            this.b_CreateIE.Click += new System.EventHandler(this.b_CreateIE_Click);
            // 
            // gb_AdminEvent
            // 
            this.gb_AdminEvent.Controls.Add(this.b_ChangeStatus);
            this.gb_AdminEvent.Controls.Add(this.b_DeleteEvent);
            this.gb_AdminEvent.Enabled = false;
            this.gb_AdminEvent.Location = new System.Drawing.Point(507, 246);
            this.gb_AdminEvent.Name = "gb_AdminEvent";
            this.gb_AdminEvent.Size = new System.Drawing.Size(187, 335);
            this.gb_AdminEvent.TabIndex = 21;
            this.gb_AdminEvent.TabStop = false;
            this.gb_AdminEvent.Text = "Admin Events";
            // 
            // b_ChangeStatus
            // 
            this.b_ChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ChangeStatus.Location = new System.Drawing.Point(17, 35);
            this.b_ChangeStatus.Name = "b_ChangeStatus";
            this.b_ChangeStatus.Size = new System.Drawing.Size(154, 77);
            this.b_ChangeStatus.TabIndex = 13;
            this.b_ChangeStatus.Text = "Status";
            this.b_ChangeStatus.UseVisualStyleBackColor = true;
            this.b_ChangeStatus.Click += new System.EventHandler(this.b_ChangeStatus_Click);
            // 
            // b_DeleteEvent
            // 
            this.b_DeleteEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_DeleteEvent.Location = new System.Drawing.Point(17, 134);
            this.b_DeleteEvent.Name = "b_DeleteEvent";
            this.b_DeleteEvent.Size = new System.Drawing.Size(154, 77);
            this.b_DeleteEvent.TabIndex = 15;
            this.b_DeleteEvent.Text = "Delete Event";
            this.b_DeleteEvent.UseVisualStyleBackColor = true;
            this.b_DeleteEvent.Click += new System.EventHandler(this.b_DeleteEvent_Click);
            // 
            // gb_BlankTags
            // 
            this.gb_BlankTags.Controls.Add(this.b_10BlankTags);
            this.gb_BlankTags.Controls.Add(this.b_100BlankTags);
            this.gb_BlankTags.Controls.Add(this.label8);
            this.gb_BlankTags.Controls.Add(this.b_nBlankTags);
            this.gb_BlankTags.Controls.Add(this.tb_NTags);
            this.gb_BlankTags.Enabled = false;
            this.gb_BlankTags.Location = new System.Drawing.Point(293, 246);
            this.gb_BlankTags.Name = "gb_BlankTags";
            this.gb_BlankTags.Size = new System.Drawing.Size(197, 335);
            this.gb_BlankTags.TabIndex = 20;
            this.gb_BlankTags.TabStop = false;
            this.gb_BlankTags.Text = "Blank Tags";
            // 
            // b_10BlankTags
            // 
            this.b_10BlankTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_10BlankTags.Location = new System.Drawing.Point(20, 35);
            this.b_10BlankTags.Name = "b_10BlankTags";
            this.b_10BlankTags.Size = new System.Drawing.Size(160, 77);
            this.b_10BlankTags.TabIndex = 8;
            this.b_10BlankTags.Text = "10 Blank Tags";
            this.b_10BlankTags.UseVisualStyleBackColor = true;
            this.b_10BlankTags.Click += new System.EventHandler(this.b_10BlankTags_Click);
            // 
            // b_100BlankTags
            // 
            this.b_100BlankTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_100BlankTags.Location = new System.Drawing.Point(20, 134);
            this.b_100BlankTags.Name = "b_100BlankTags";
            this.b_100BlankTags.Size = new System.Drawing.Size(160, 77);
            this.b_100BlankTags.TabIndex = 10;
            this.b_100BlankTags.Text = "100 Blank Tags";
            this.b_100BlankTags.UseVisualStyleBackColor = true;
            this.b_100BlankTags.Click += new System.EventHandler(this.b_100BlankTags_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Qty";
            // 
            // b_nBlankTags
            // 
            this.b_nBlankTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_nBlankTags.Location = new System.Drawing.Point(20, 274);
            this.b_nBlankTags.Name = "b_nBlankTags";
            this.b_nBlankTags.Size = new System.Drawing.Size(160, 37);
            this.b_nBlankTags.TabIndex = 11;
            this.b_nBlankTags.Text = "n Blank Tags";
            this.b_nBlankTags.UseVisualStyleBackColor = true;
            this.b_nBlankTags.Click += new System.EventHandler(this.b_nBlankTags_Click);
            // 
            // tb_NTags
            // 
            this.tb_NTags.Location = new System.Drawing.Point(56, 242);
            this.tb_NTags.Name = "tb_NTags";
            this.tb_NTags.Size = new System.Drawing.Size(124, 22);
            this.tb_NTags.TabIndex = 12;
            // 
            // gb_LoadTags
            // 
            this.gb_LoadTags.Controls.Add(this.rb_EPDC_Tags);
            this.gb_LoadTags.Controls.Add(this.rb_JZ_Tags);
            this.gb_LoadTags.Controls.Add(this.b_MOtagsFromSQL);
            this.gb_LoadTags.Controls.Add(this.b_MOtagsFromCSV);
            this.gb_LoadTags.Controls.Add(this.b_tagsFromCSV);
            this.gb_LoadTags.Controls.Add(this.b_tagsFromSQL);
            this.gb_LoadTags.Enabled = false;
            this.gb_LoadTags.Location = new System.Drawing.Point(25, 244);
            this.gb_LoadTags.Name = "gb_LoadTags";
            this.gb_LoadTags.Size = new System.Drawing.Size(246, 337);
            this.gb_LoadTags.TabIndex = 19;
            this.gb_LoadTags.TabStop = false;
            this.gb_LoadTags.Text = "Load Tags";
            // 
            // rb_EPDC_Tags
            // 
            this.rb_EPDC_Tags.AutoSize = true;
            this.rb_EPDC_Tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_EPDC_Tags.Location = new System.Drawing.Point(22, 65);
            this.rb_EPDC_Tags.Name = "rb_EPDC_Tags";
            this.rb_EPDC_Tags.Size = new System.Drawing.Size(160, 21);
            this.rb_EPDC_Tags.TabIndex = 15;
            this.rb_EPDC_Tags.TabStop = true;
            this.rb_EPDC_Tags.Text = "Ticket Tags EPDC";
            this.rb_EPDC_Tags.UseVisualStyleBackColor = true;
            this.rb_EPDC_Tags.CheckedChanged += new System.EventHandler(this.rb_EPDC_Tags_CheckedChanged);
            // 
            // rb_JZ_Tags
            // 
            this.rb_JZ_Tags.AutoSize = true;
            this.rb_JZ_Tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_JZ_Tags.Location = new System.Drawing.Point(22, 37);
            this.rb_JZ_Tags.Name = "rb_JZ_Tags";
            this.rb_JZ_Tags.Size = new System.Drawing.Size(137, 21);
            this.rb_JZ_Tags.TabIndex = 14;
            this.rb_JZ_Tags.TabStop = true;
            this.rb_JZ_Tags.Text = "Ticket Tags JZ";
            this.rb_JZ_Tags.UseVisualStyleBackColor = true;
            this.rb_JZ_Tags.CheckedChanged += new System.EventHandler(this.rb_JZ_Tags_CheckedChanged);
            // 
            // b_MOtagsFromSQL
            // 
            this.b_MOtagsFromSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_MOtagsFromSQL.Location = new System.Drawing.Point(22, 153);
            this.b_MOtagsFromSQL.Name = "b_MOtagsFromSQL";
            this.b_MOtagsFromSQL.Size = new System.Drawing.Size(199, 42);
            this.b_MOtagsFromSQL.TabIndex = 13;
            this.b_MOtagsFromSQL.Text = "MO Tags From SQL";
            this.b_MOtagsFromSQL.UseVisualStyleBackColor = true;
            this.b_MOtagsFromSQL.Click += new System.EventHandler(this.b_MOtagsFromSQL_Click);
            // 
            // b_MOtagsFromCSV
            // 
            this.b_MOtagsFromCSV.Enabled = false;
            this.b_MOtagsFromCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_MOtagsFromCSV.Location = new System.Drawing.Point(22, 249);
            this.b_MOtagsFromCSV.Name = "b_MOtagsFromCSV";
            this.b_MOtagsFromCSV.Size = new System.Drawing.Size(199, 42);
            this.b_MOtagsFromCSV.TabIndex = 12;
            this.b_MOtagsFromCSV.Text = "MO Tags From CSV";
            this.b_MOtagsFromCSV.UseVisualStyleBackColor = true;
            this.b_MOtagsFromCSV.Click += new System.EventHandler(this.b_MOtagsFromCSV_Click);
            // 
            // b_tagsFromCSV
            // 
            this.b_tagsFromCSV.Enabled = false;
            this.b_tagsFromCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_tagsFromCSV.Location = new System.Drawing.Point(22, 201);
            this.b_tagsFromCSV.Name = "b_tagsFromCSV";
            this.b_tagsFromCSV.Size = new System.Drawing.Size(199, 42);
            this.b_tagsFromCSV.TabIndex = 9;
            this.b_tagsFromCSV.Text = "Tags From CSV";
            this.b_tagsFromCSV.UseVisualStyleBackColor = true;
            this.b_tagsFromCSV.Click += new System.EventHandler(this.b_tagsFromCSV_Click);
            // 
            // b_tagsFromSQL
            // 
            this.b_tagsFromSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_tagsFromSQL.Location = new System.Drawing.Point(22, 103);
            this.b_tagsFromSQL.Name = "b_tagsFromSQL";
            this.b_tagsFromSQL.Size = new System.Drawing.Size(199, 40);
            this.b_tagsFromSQL.TabIndex = 10;
            this.b_tagsFromSQL.Text = "Tags From SQL";
            this.b_tagsFromSQL.UseVisualStyleBackColor = true;
            this.b_tagsFromSQL.Click += new System.EventHandler(this.b_tagsFromSQL_Click);
            // 
            // tb_EventCreationDate
            // 
            this.tb_EventCreationDate.Enabled = false;
            this.tb_EventCreationDate.Location = new System.Drawing.Point(600, 49);
            this.tb_EventCreationDate.Name = "tb_EventCreationDate";
            this.tb_EventCreationDate.Size = new System.Drawing.Size(128, 22);
            this.tb_EventCreationDate.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(597, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Event Creation";
            // 
            // b_Clear
            // 
            this.b_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Clear.Location = new System.Drawing.Point(772, 41);
            this.b_Clear.Name = "b_Clear";
            this.b_Clear.Size = new System.Drawing.Size(91, 39);
            this.b_Clear.TabIndex = 14;
            this.b_Clear.Text = "Clear";
            this.b_Clear.UseVisualStyleBackColor = true;
            this.b_Clear.Click += new System.EventHandler(this.b_Clear_Click);
            // 
            // tb_ro_EventStatus
            // 
            this.tb_ro_EventStatus.Enabled = false;
            this.tb_ro_EventStatus.Location = new System.Drawing.Point(452, 49);
            this.tb_ro_EventStatus.Name = "tb_ro_EventStatus";
            this.tb_ro_EventStatus.Size = new System.Drawing.Size(128, 22);
            this.tb_ro_EventStatus.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Event Status";
            // 
            // tb_ro_QTYofTags
            // 
            this.tb_ro_QTYofTags.Enabled = false;
            this.tb_ro_QTYofTags.Location = new System.Drawing.Point(293, 49);
            this.tb_ro_QTYofTags.Name = "tb_ro_QTYofTags";
            this.tb_ro_QTYofTags.Size = new System.Drawing.Size(128, 22);
            this.tb_ro_QTYofTags.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Qty of Tags";
            // 
            // rtb_ro_EventDescription
            // 
            this.rtb_ro_EventDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_ro_EventDescription.Enabled = false;
            this.rtb_ro_EventDescription.Location = new System.Drawing.Point(25, 128);
            this.rtb_ro_EventDescription.Name = "rtb_ro_EventDescription";
            this.rtb_ro_EventDescription.Size = new System.Drawing.Size(838, 96);
            this.rtb_ro_EventDescription.TabIndex = 3;
            this.rtb_ro_EventDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inventory Event Description";
            // 
            // t_Stadistics
            // 
            this.t_Stadistics.Controls.Add(this.gb_IE_Stadistics);
            this.t_Stadistics.Location = new System.Drawing.Point(4, 25);
            this.t_Stadistics.Name = "t_Stadistics";
            this.t_Stadistics.Padding = new System.Windows.Forms.Padding(3);
            this.t_Stadistics.Size = new System.Drawing.Size(881, 599);
            this.t_Stadistics.TabIndex = 1;
            this.t_Stadistics.Text = "Stadistics";
            this.t_Stadistics.UseVisualStyleBackColor = true;
            // 
            // gb_IE_Stadistics
            // 
            this.gb_IE_Stadistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_IE_Stadistics.Controls.Add(this.label9);
            this.gb_IE_Stadistics.Controls.Add(this.tb_RefreshRateSecs);
            this.gb_IE_Stadistics.Controls.Add(this.b_RefreshStats);
            this.gb_IE_Stadistics.Controls.Add(this.gb_TicketCountStadistics);
            this.gb_IE_Stadistics.Location = new System.Drawing.Point(8, 6);
            this.gb_IE_Stadistics.Name = "gb_IE_Stadistics";
            this.gb_IE_Stadistics.Size = new System.Drawing.Size(865, 585);
            this.gb_IE_Stadistics.TabIndex = 0;
            this.gb_IE_Stadistics.TabStop = false;
            this.gb_IE_Stadistics.Text = "Inventory Events Stadistics";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(431, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Refresh Rate in Seconds: ";
            // 
            // tb_RefreshRateSecs
            // 
            this.tb_RefreshRateSecs.Location = new System.Drawing.Point(648, 368);
            this.tb_RefreshRateSecs.Name = "tb_RefreshRateSecs";
            this.tb_RefreshRateSecs.Size = new System.Drawing.Size(60, 22);
            this.tb_RefreshRateSecs.TabIndex = 10;
            this.tb_RefreshRateSecs.Text = "10";
            this.tb_RefreshRateSecs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_RefreshRateSecs_KeyDown);
            // 
            // b_RefreshStats
            // 
            this.b_RefreshStats.Location = new System.Drawing.Point(727, 360);
            this.b_RefreshStats.Name = "b_RefreshStats";
            this.b_RefreshStats.Size = new System.Drawing.Size(118, 38);
            this.b_RefreshStats.TabIndex = 9;
            this.b_RefreshStats.Text = "Refresh Stats";
            this.b_RefreshStats.UseVisualStyleBackColor = true;
            this.b_RefreshStats.Click += new System.EventHandler(this.button1_Click);
            // 
            // gb_TicketCountStadistics
            // 
            this.gb_TicketCountStadistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_TicketCountStadistics.Controls.Add(this.label16);
            this.gb_TicketCountStadistics.Controls.Add(this.l_TicketCounted);
            this.gb_TicketCountStadistics.Controls.Add(this.label15);
            this.gb_TicketCountStadistics.Controls.Add(this.l_MOTagsCounted);
            this.gb_TicketCountStadistics.Controls.Add(this.label11);
            this.gb_TicketCountStadistics.Controls.Add(this.l_MOTags);
            this.gb_TicketCountStadistics.Controls.Add(this.l_CountedTags);
            this.gb_TicketCountStadistics.Controls.Add(this.l_TicketVoid);
            this.gb_TicketCountStadistics.Controls.Add(this.label12);
            this.gb_TicketCountStadistics.Controls.Add(this.label5);
            this.gb_TicketCountStadistics.Controls.Add(this.l_TicketVerified);
            this.gb_TicketCountStadistics.Controls.Add(this.gb_CountedTikets);
            this.gb_TicketCountStadistics.Controls.Add(this.label10);
            this.gb_TicketCountStadistics.Controls.Add(this.label6);
            this.gb_TicketCountStadistics.Controls.Add(this.l_TicketBlanks);
            this.gb_TicketCountStadistics.Controls.Add(this.l_TicketCounts);
            this.gb_TicketCountStadistics.Location = new System.Drawing.Point(18, 33);
            this.gb_TicketCountStadistics.Name = "gb_TicketCountStadistics";
            this.gb_TicketCountStadistics.Size = new System.Drawing.Size(827, 321);
            this.gb_TicketCountStadistics.TabIndex = 8;
            this.gb_TicketCountStadistics.TabStop = false;
            this.gb_TicketCountStadistics.Text = "Ticket Tag Counts Stadistics";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(30, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "Ticket Tag Counted: ";
            // 
            // l_TicketCounted
            // 
            this.l_TicketCounted.AutoSize = true;
            this.l_TicketCounted.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TicketCounted.Location = new System.Drawing.Point(194, 87);
            this.l_TicketCounted.Name = "l_TicketCounted";
            this.l_TicketCounted.Size = new System.Drawing.Size(17, 17);
            this.l_TicketCounted.TabIndex = 16;
            this.l_TicketCounted.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(30, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 17);
            this.label15.TabIndex = 13;
            this.label15.Text = "MO Tags Counted: ";
            // 
            // l_MOTagsCounted
            // 
            this.l_MOTagsCounted.AutoSize = true;
            this.l_MOTagsCounted.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_MOTagsCounted.Location = new System.Drawing.Point(194, 205);
            this.l_MOTagsCounted.Name = "l_MOTagsCounted";
            this.l_MOTagsCounted.Size = new System.Drawing.Size(17, 17);
            this.l_MOTagsCounted.TabIndex = 14;
            this.l_MOTagsCounted.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "MO Tag Counts: ";
            // 
            // l_MOTags
            // 
            this.l_MOTags.AutoSize = true;
            this.l_MOTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_MOTags.Location = new System.Drawing.Point(194, 174);
            this.l_MOTags.Name = "l_MOTags";
            this.l_MOTags.Size = new System.Drawing.Size(17, 17);
            this.l_MOTags.TabIndex = 12;
            this.l_MOTags.Text = "0";
            // 
            // l_CountedTags
            // 
            this.l_CountedTags.AutoSize = true;
            this.l_CountedTags.Location = new System.Drawing.Point(747, 35);
            this.l_CountedTags.Name = "l_CountedTags";
            this.l_CountedTags.Size = new System.Drawing.Size(54, 17);
            this.l_CountedTags.TabIndex = 10;
            this.l_CountedTags.Text = "label11";
            this.l_CountedTags.Visible = false;
            // 
            // l_TicketVoid
            // 
            this.l_TicketVoid.AutoSize = true;
            this.l_TicketVoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TicketVoid.Location = new System.Drawing.Point(194, 145);
            this.l_TicketVoid.Name = "l_TicketVoid";
            this.l_TicketVoid.Size = new System.Drawing.Size(17, 17);
            this.l_TicketVoid.TabIndex = 9;
            this.l_TicketVoid.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Ticket Tag Void: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ticket Tag Counts: ";
            // 
            // l_TicketVerified
            // 
            this.l_TicketVerified.AutoSize = true;
            this.l_TicketVerified.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TicketVerified.Location = new System.Drawing.Point(194, 116);
            this.l_TicketVerified.Name = "l_TicketVerified";
            this.l_TicketVerified.Size = new System.Drawing.Size(17, 17);
            this.l_TicketVerified.TabIndex = 7;
            this.l_TicketVerified.Text = "0";
            // 
            // gb_CountedTikets
            // 
            this.gb_CountedTikets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_CountedTikets.Controls.Add(this.label13);
            this.gb_CountedTikets.Controls.Add(this.label14);
            this.gb_CountedTikets.Controls.Add(this.pb_CountedTickets);
            this.gb_CountedTikets.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_CountedTikets.Location = new System.Drawing.Point(33, 239);
            this.gb_CountedTikets.Name = "gb_CountedTikets";
            this.gb_CountedTikets.Size = new System.Drawing.Size(771, 59);
            this.gb_CountedTikets.TabIndex = 1;
            this.gb_CountedTikets.TabStop = false;
            this.gb_CountedTikets.Text = "Iinventory Event Progress";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, -20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "MO Tag Counts: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(156, -20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "0";
            // 
            // pb_CountedTickets
            // 
            this.pb_CountedTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_CountedTickets.Location = new System.Drawing.Point(3, 18);
            this.pb_CountedTickets.Name = "pb_CountedTickets";
            this.pb_CountedTickets.Size = new System.Drawing.Size(765, 38);
            this.pb_CountedTickets.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ticket Tag Verified: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ticket Tag Blank: ";
            // 
            // l_TicketBlanks
            // 
            this.l_TicketBlanks.AutoSize = true;
            this.l_TicketBlanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TicketBlanks.Location = new System.Drawing.Point(194, 61);
            this.l_TicketBlanks.Name = "l_TicketBlanks";
            this.l_TicketBlanks.Size = new System.Drawing.Size(17, 17);
            this.l_TicketBlanks.TabIndex = 5;
            this.l_TicketBlanks.Text = "0";
            // 
            // l_TicketCounts
            // 
            this.l_TicketCounts.AutoSize = true;
            this.l_TicketCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TicketCounts.Location = new System.Drawing.Point(194, 35);
            this.l_TicketCounts.Name = "l_TicketCounts";
            this.l_TicketCounts.Size = new System.Drawing.Size(17, 17);
            this.l_TicketCounts.TabIndex = 4;
            this.l_TicketCounts.Text = "0";
            // 
            // t_RefreshStatsRate
            // 
            this.t_RefreshStatsRate.Enabled = true;
            this.t_RefreshStatsRate.Interval = 10000;
            this.t_RefreshStatsRate.Tick += new System.EventHandler(this.t_RefreshStatsRate_Tick);
            // 
            // f_InvEventAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 628);
            this.Controls.Add(this.tb_EventAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_InvEventAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Event Administration";
            this.tb_EventAdmin.ResumeLayout(false);
            this.t_AdminEvent.ResumeLayout(false);
            this.t_AdminEvent.PerformLayout();
            this.gb_AdminEvent.ResumeLayout(false);
            this.gb_BlankTags.ResumeLayout(false);
            this.gb_BlankTags.PerformLayout();
            this.gb_LoadTags.ResumeLayout(false);
            this.gb_LoadTags.PerformLayout();
            this.t_Stadistics.ResumeLayout(false);
            this.gb_IE_Stadistics.ResumeLayout(false);
            this.gb_IE_Stadistics.PerformLayout();
            this.gb_TicketCountStadistics.ResumeLayout(false);
            this.gb_TicketCountStadistics.PerformLayout();
            this.gb_CountedTikets.ResumeLayout(false);
            this.gb_CountedTikets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_InvEvent;
        private System.Windows.Forms.TabControl tb_EventAdmin;
        private System.Windows.Forms.TabPage t_AdminEvent;
        private System.Windows.Forms.RichTextBox rtb_ro_EventDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ro_QTYofTags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ro_EventStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_100BlankTags;
        private System.Windows.Forms.Button b_10BlankTags;
        private System.Windows.Forms.TextBox tb_NTags;
        private System.Windows.Forms.Button b_nBlankTags;
        private System.Windows.Forms.Button b_ChangeStatus;
        private System.Windows.Forms.Button b_Clear;
        private System.Windows.Forms.Button b_DeleteEvent;
        private System.Windows.Forms.TextBox tb_EventCreationDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gb_LoadTags;
        private System.Windows.Forms.Button b_tagsFromCSV;
        private System.Windows.Forms.Button b_tagsFromSQL;
        private System.Windows.Forms.GroupBox gb_BlankTags;
        private System.Windows.Forms.GroupBox gb_AdminEvent;
        private System.Windows.Forms.Button b_CreateIE;
        private System.Windows.Forms.Button b_MOtagsFromSQL;
        private System.Windows.Forms.Button b_MOtagsFromCSV;
        private System.Windows.Forms.TabPage t_Stadistics;
        private System.Windows.Forms.GroupBox gb_IE_Stadistics;
        private System.Windows.Forms.GroupBox gb_TicketCountStadistics;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label l_TicketVerified;
        private System.Windows.Forms.GroupBox gb_CountedTikets;
        private System.Windows.Forms.ProgressBar pb_CountedTickets;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_TicketBlanks;
        private System.Windows.Forms.Label l_TicketCounts;
        private System.Windows.Forms.Button b_RefreshStats;
        private System.Windows.Forms.Timer t_RefreshStatsRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_RefreshRateSecs;
        private System.Windows.Forms.Button b_LoadFSIM;
        private System.Windows.Forms.Label l_TicketVoid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rb_EPDC_Tags;
        private System.Windows.Forms.RadioButton rb_JZ_Tags;
        private System.Windows.Forms.Label l_CountedTags;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label l_MOTags;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label l_MOTagsCounted;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label l_TicketCounted;
        private System.Windows.Forms.Button b_LoadFSLM;
    }
}

