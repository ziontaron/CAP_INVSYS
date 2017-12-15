namespace InventoryImplementation
{
    partial class f_MOTags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_MOTags));
            this.tc_MoTags = new System.Windows.Forms.TabControl();
            this.tp_MOHeaders = new System.Windows.Forms.TabPage();
            this.b_Refresh = new System.Windows.Forms.Button();
            this.l_EventStatus = new System.Windows.Forms.Label();
            this.cb_Lock = new System.Windows.Forms.CheckBox();
            this.cb_InvEvent = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_MOtagHeaderList = new System.Windows.Forms.GroupBox();
            this.dgv_MOTagsHeaders = new System.Windows.Forms.DataGridView();
            this.tp_MOTagCount = new System.Windows.Forms.TabPage();
            this.gb_MOTag_Detail = new System.Windows.Forms.GroupBox();
            this.dgv_MODetail = new System.Windows.Forms.DataGridView();
            this.gb_MOHeader = new System.Windows.Forms.GroupBox();
            this.b_Save = new System.Windows.Forms.Button();
            this.tb_ParentClass = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_ParentDesc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_Parent = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_CountedBy = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_FGinWip = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_QtyReceived = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Order_QTY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_LineType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_MOStatus = new System.Windows.Forms.TextBox();
            this.tb_MOTagCounter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_MOLn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_MO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Planner = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ss_MOTags_Trip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tc_MoTags.SuspendLayout();
            this.tp_MOHeaders.SuspendLayout();
            this.gb_MOtagHeaderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MOTagsHeaders)).BeginInit();
            this.tp_MOTagCount.SuspendLayout();
            this.gb_MOTag_Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MODetail)).BeginInit();
            this.gb_MOHeader.SuspendLayout();
            this.ss_MOTags_Trip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_MoTags
            // 
            this.tc_MoTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_MoTags.Controls.Add(this.tp_MOHeaders);
            this.tc_MoTags.Controls.Add(this.tp_MOTagCount);
            this.tc_MoTags.Location = new System.Drawing.Point(12, 0);
            this.tc_MoTags.Name = "tc_MoTags";
            this.tc_MoTags.SelectedIndex = 0;
            this.tc_MoTags.Size = new System.Drawing.Size(1105, 688);
            this.tc_MoTags.TabIndex = 0;
            // 
            // tp_MOHeaders
            // 
            this.tp_MOHeaders.Controls.Add(this.b_Refresh);
            this.tp_MOHeaders.Controls.Add(this.l_EventStatus);
            this.tp_MOHeaders.Controls.Add(this.cb_Lock);
            this.tp_MOHeaders.Controls.Add(this.cb_InvEvent);
            this.tp_MOHeaders.Controls.Add(this.label6);
            this.tp_MOHeaders.Controls.Add(this.gb_MOtagHeaderList);
            this.tp_MOHeaders.Location = new System.Drawing.Point(4, 25);
            this.tp_MOHeaders.Name = "tp_MOHeaders";
            this.tp_MOHeaders.Padding = new System.Windows.Forms.Padding(3);
            this.tp_MOHeaders.Size = new System.Drawing.Size(1097, 659);
            this.tp_MOHeaders.TabIndex = 0;
            this.tp_MOHeaders.Text = "MO Tag List";
            this.tp_MOHeaders.UseVisualStyleBackColor = true;
            // 
            // b_Refresh
            // 
            this.b_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Refresh.Enabled = false;
            this.b_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Refresh.Location = new System.Drawing.Point(951, 17);
            this.b_Refresh.Name = "b_Refresh";
            this.b_Refresh.Size = new System.Drawing.Size(125, 30);
            this.b_Refresh.TabIndex = 16;
            this.b_Refresh.Text = "Refresh";
            this.b_Refresh.UseVisualStyleBackColor = true;
            this.b_Refresh.Click += new System.EventHandler(this.b_Refresh_Click);
            // 
            // l_EventStatus
            // 
            this.l_EventStatus.AutoSize = true;
            this.l_EventStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_EventStatus.ForeColor = System.Drawing.Color.Green;
            this.l_EventStatus.Location = new System.Drawing.Point(555, 20);
            this.l_EventStatus.Name = "l_EventStatus";
            this.l_EventStatus.Size = new System.Drawing.Size(0, 20);
            this.l_EventStatus.TabIndex = 15;
            // 
            // cb_Lock
            // 
            this.cb_Lock.AutoSize = true;
            this.cb_Lock.Location = new System.Drawing.Point(468, 22);
            this.cb_Lock.Name = "cb_Lock";
            this.cb_Lock.Size = new System.Drawing.Size(60, 21);
            this.cb_Lock.TabIndex = 14;
            this.cb_Lock.Text = "Lock";
            this.cb_Lock.UseVisualStyleBackColor = true;
            this.cb_Lock.CheckedChanged += new System.EventHandler(this.cb_Lock_CheckedChanged);
            // 
            // cb_InvEvent
            // 
            this.cb_InvEvent.FormattingEnabled = true;
            this.cb_InvEvent.Location = new System.Drawing.Point(198, 20);
            this.cb_InvEvent.Name = "cb_InvEvent";
            this.cb_InvEvent.Size = new System.Drawing.Size(246, 24);
            this.cb_InvEvent.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Inventory Event List:";
            // 
            // gb_MOtagHeaderList
            // 
            this.gb_MOtagHeaderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_MOtagHeaderList.Controls.Add(this.dgv_MOTagsHeaders);
            this.gb_MOtagHeaderList.Enabled = false;
            this.gb_MOtagHeaderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_MOtagHeaderList.Location = new System.Drawing.Point(21, 53);
            this.gb_MOtagHeaderList.Name = "gb_MOtagHeaderList";
            this.gb_MOtagHeaderList.Size = new System.Drawing.Size(1058, 600);
            this.gb_MOtagHeaderList.TabIndex = 2;
            this.gb_MOtagHeaderList.TabStop = false;
            this.gb_MOtagHeaderList.Text = "MO Tag Headers";
            // 
            // dgv_MOTagsHeaders
            // 
            this.dgv_MOTagsHeaders.AllowUserToAddRows = false;
            this.dgv_MOTagsHeaders.AllowUserToDeleteRows = false;
            this.dgv_MOTagsHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MOTagsHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_MOTagsHeaders.Location = new System.Drawing.Point(3, 18);
            this.dgv_MOTagsHeaders.MultiSelect = false;
            this.dgv_MOTagsHeaders.Name = "dgv_MOTagsHeaders";
            this.dgv_MOTagsHeaders.ReadOnly = true;
            this.dgv_MOTagsHeaders.RowTemplate.Height = 24;
            this.dgv_MOTagsHeaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MOTagsHeaders.Size = new System.Drawing.Size(1052, 579);
            this.dgv_MOTagsHeaders.TabIndex = 1;
            this.dgv_MOTagsHeaders.Click += new System.EventHandler(this.dgv_MOTagsHeaders_Click);
            this.dgv_MOTagsHeaders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_MOTagsHeaders_KeyDown);
            // 
            // tp_MOTagCount
            // 
            this.tp_MOTagCount.Controls.Add(this.gb_MOTag_Detail);
            this.tp_MOTagCount.Controls.Add(this.gb_MOHeader);
            this.tp_MOTagCount.Location = new System.Drawing.Point(4, 25);
            this.tp_MOTagCount.Name = "tp_MOTagCount";
            this.tp_MOTagCount.Padding = new System.Windows.Forms.Padding(3);
            this.tp_MOTagCount.Size = new System.Drawing.Size(1097, 659);
            this.tp_MOTagCount.TabIndex = 1;
            this.tp_MOTagCount.Text = "MO Tag Counts";
            this.tp_MOTagCount.UseVisualStyleBackColor = true;
            // 
            // gb_MOTag_Detail
            // 
            this.gb_MOTag_Detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_MOTag_Detail.Controls.Add(this.dgv_MODetail);
            this.gb_MOTag_Detail.Enabled = false;
            this.gb_MOTag_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_MOTag_Detail.Location = new System.Drawing.Point(23, 210);
            this.gb_MOTag_Detail.Name = "gb_MOTag_Detail";
            this.gb_MOTag_Detail.Size = new System.Drawing.Size(1055, 432);
            this.gb_MOTag_Detail.TabIndex = 3;
            this.gb_MOTag_Detail.TabStop = false;
            this.gb_MOTag_Detail.Text = "MO Tag Detail Lines";
            // 
            // dgv_MODetail
            // 
            this.dgv_MODetail.AllowUserToAddRows = false;
            this.dgv_MODetail.AllowUserToDeleteRows = false;
            this.dgv_MODetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MODetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_MODetail.Location = new System.Drawing.Point(3, 18);
            this.dgv_MODetail.Name = "dgv_MODetail";
            this.dgv_MODetail.RowTemplate.Height = 24;
            this.dgv_MODetail.Size = new System.Drawing.Size(1049, 411);
            this.dgv_MODetail.TabIndex = 0;
            // 
            // gb_MOHeader
            // 
            this.gb_MOHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_MOHeader.Controls.Add(this.b_Save);
            this.gb_MOHeader.Controls.Add(this.tb_ParentClass);
            this.gb_MOHeader.Controls.Add(this.label15);
            this.gb_MOHeader.Controls.Add(this.tb_ParentDesc);
            this.gb_MOHeader.Controls.Add(this.label14);
            this.gb_MOHeader.Controls.Add(this.tb_Parent);
            this.gb_MOHeader.Controls.Add(this.label13);
            this.gb_MOHeader.Controls.Add(this.tb_Date);
            this.gb_MOHeader.Controls.Add(this.label12);
            this.gb_MOHeader.Controls.Add(this.tb_CountedBy);
            this.gb_MOHeader.Controls.Add(this.label11);
            this.gb_MOHeader.Controls.Add(this.tb_FGinWip);
            this.gb_MOHeader.Controls.Add(this.label10);
            this.gb_MOHeader.Controls.Add(this.tb_QtyReceived);
            this.gb_MOHeader.Controls.Add(this.label9);
            this.gb_MOHeader.Controls.Add(this.tb_Order_QTY);
            this.gb_MOHeader.Controls.Add(this.label8);
            this.gb_MOHeader.Controls.Add(this.tb_LineType);
            this.gb_MOHeader.Controls.Add(this.label7);
            this.gb_MOHeader.Controls.Add(this.tb_MOStatus);
            this.gb_MOHeader.Controls.Add(this.tb_MOTagCounter);
            this.gb_MOHeader.Controls.Add(this.label1);
            this.gb_MOHeader.Controls.Add(this.label5);
            this.gb_MOHeader.Controls.Add(this.tb_MOLn);
            this.gb_MOHeader.Controls.Add(this.label4);
            this.gb_MOHeader.Controls.Add(this.tb_MO);
            this.gb_MOHeader.Controls.Add(this.label3);
            this.gb_MOHeader.Controls.Add(this.tb_Planner);
            this.gb_MOHeader.Controls.Add(this.label2);
            this.gb_MOHeader.Enabled = false;
            this.gb_MOHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_MOHeader.Location = new System.Drawing.Point(23, 22);
            this.gb_MOHeader.Name = "gb_MOHeader";
            this.gb_MOHeader.Size = new System.Drawing.Size(1055, 182);
            this.gb_MOHeader.TabIndex = 2;
            this.gb_MOHeader.TabStop = false;
            this.gb_MOHeader.Text = "MO Status";
            // 
            // b_Save
            // 
            this.b_Save.Location = new System.Drawing.Point(945, 116);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(91, 45);
            this.b_Save.TabIndex = 28;
            this.b_Save.Text = "Save";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // tb_ParentClass
            // 
            this.tb_ParentClass.Enabled = false;
            this.tb_ParentClass.Location = new System.Drawing.Point(857, 139);
            this.tb_ParentClass.Name = "tb_ParentClass";
            this.tb_ParentClass.Size = new System.Drawing.Size(67, 22);
            this.tb_ParentClass.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(799, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "Class:";
            // 
            // tb_ParentDesc
            // 
            this.tb_ParentDesc.Enabled = false;
            this.tb_ParentDesc.Location = new System.Drawing.Point(421, 139);
            this.tb_ParentDesc.Name = "tb_ParentDesc";
            this.tb_ParentDesc.Size = new System.Drawing.Size(370, 22);
            this.tb_ParentDesc.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(313, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "Parent Desc:";
            // 
            // tb_Parent
            // 
            this.tb_Parent.Enabled = false;
            this.tb_Parent.Location = new System.Drawing.Point(92, 139);
            this.tb_Parent.Name = "tb_Parent";
            this.tb_Parent.Size = new System.Drawing.Size(202, 22);
            this.tb_Parent.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Parent:";
            // 
            // tb_Date
            // 
            this.tb_Date.Enabled = false;
            this.tb_Date.Location = new System.Drawing.Point(802, 29);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(122, 22);
            this.tb_Date.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(733, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Date:";
            // 
            // tb_CountedBy
            // 
            this.tb_CountedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_CountedBy.Enabled = false;
            this.tb_CountedBy.Location = new System.Drawing.Point(406, 29);
            this.tb_CountedBy.Name = "tb_CountedBy";
            this.tb_CountedBy.Size = new System.Drawing.Size(122, 22);
            this.tb_CountedBy.TabIndex = 19;
            this.tb_CountedBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_CountedBy_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(304, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Counted By:";
            // 
            // tb_FGinWip
            // 
            this.tb_FGinWip.Enabled = false;
            this.tb_FGinWip.Location = new System.Drawing.Point(741, 101);
            this.tb_FGinWip.Name = "tb_FGinWip";
            this.tb_FGinWip.Size = new System.Drawing.Size(183, 22);
            this.tb_FGinWip.TabIndex = 17;
            this.tb_FGinWip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_FGinWip_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(444, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Count of Assembled Units (still in Wip):";
            // 
            // tb_QtyReceived
            // 
            this.tb_QtyReceived.Enabled = false;
            this.tb_QtyReceived.Location = new System.Drawing.Point(337, 101);
            this.tb_QtyReceived.Name = "tb_QtyReceived";
            this.tb_QtyReceived.Size = new System.Drawing.Size(87, 22);
            this.tb_QtyReceived.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(221, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Qty Received:";
            // 
            // tb_Order_QTY
            // 
            this.tb_Order_QTY.Enabled = false;
            this.tb_Order_QTY.Location = new System.Drawing.Point(115, 101);
            this.tb_Order_QTY.Name = "tb_Order_QTY";
            this.tb_Order_QTY.Size = new System.Drawing.Size(90, 22);
            this.tb_Order_QTY.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Order Qty:";
            // 
            // tb_LineType
            // 
            this.tb_LineType.Enabled = false;
            this.tb_LineType.Location = new System.Drawing.Point(879, 64);
            this.tb_LineType.Name = "tb_LineType";
            this.tb_LineType.Size = new System.Drawing.Size(45, 22);
            this.tb_LineType.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(789, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Line Type:";
            // 
            // tb_MOStatus
            // 
            this.tb_MOStatus.Enabled = false;
            this.tb_MOStatus.Location = new System.Drawing.Point(729, 64);
            this.tb_MOStatus.Name = "tb_MOStatus";
            this.tb_MOStatus.Size = new System.Drawing.Size(45, 22);
            this.tb_MOStatus.TabIndex = 9;
            // 
            // tb_MOTagCounter
            // 
            this.tb_MOTagCounter.Location = new System.Drawing.Point(96, 29);
            this.tb_MOTagCounter.Name = "tb_MOTagCounter";
            this.tb_MOTagCounter.Size = new System.Drawing.Size(183, 22);
            this.tb_MOTagCounter.TabIndex = 1;
            this.tb_MOTagCounter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_MOTagCounter_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MO Tag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(639, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "MO Status:";
            // 
            // tb_MOLn
            // 
            this.tb_MOLn.Enabled = false;
            this.tb_MOLn.Location = new System.Drawing.Point(556, 64);
            this.tb_MOLn.Name = "tb_MOLn";
            this.tb_MOLn.Size = new System.Drawing.Size(62, 22);
            this.tb_MOLn.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "MO Ln#:";
            // 
            // tb_MO
            // 
            this.tb_MO.Enabled = false;
            this.tb_MO.Location = new System.Drawing.Point(224, 64);
            this.tb_MO.Name = "tb_MO";
            this.tb_MO.Size = new System.Drawing.Size(243, 22);
            this.tb_MO.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "MO:";
            // 
            // tb_Planner
            // 
            this.tb_Planner.Enabled = false;
            this.tb_Planner.Location = new System.Drawing.Point(96, 64);
            this.tb_Planner.Name = "tb_Planner";
            this.tb_Planner.Size = new System.Drawing.Size(66, 22);
            this.tb_Planner.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Planner:";
            // 
            // ss_MOTags_Trip
            // 
            this.ss_MOTags_Trip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ss_MOTags_Trip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ss_MOTags_Trip.Location = new System.Drawing.Point(0, 688);
            this.ss_MOTags_Trip.Name = "ss_MOTags_Trip";
            this.ss_MOTags_Trip.Size = new System.Drawing.Size(1129, 25);
            this.ss_MOTags_Trip.TabIndex = 1;
            this.ss_MOTags_Trip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(132, 20);
            this.toolStripStatusLabel1.Text = "Press F5 to Refresh";
            // 
            // f_MOTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 713);
            this.Controls.Add(this.ss_MOTags_Trip);
            this.Controls.Add(this.tc_MoTags);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_MOTags";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MO Tags";
            this.tc_MoTags.ResumeLayout(false);
            this.tp_MOHeaders.ResumeLayout(false);
            this.tp_MOHeaders.PerformLayout();
            this.gb_MOtagHeaderList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MOTagsHeaders)).EndInit();
            this.tp_MOTagCount.ResumeLayout(false);
            this.gb_MOTag_Detail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MODetail)).EndInit();
            this.gb_MOHeader.ResumeLayout(false);
            this.gb_MOHeader.PerformLayout();
            this.ss_MOTags_Trip.ResumeLayout(false);
            this.ss_MOTags_Trip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tc_MoTags;
        private System.Windows.Forms.TabPage tp_MOHeaders;
        private System.Windows.Forms.TabPage tp_MOTagCount;
        private System.Windows.Forms.StatusStrip ss_MOTags_Trip;
        private System.Windows.Forms.DataGridView dgv_MOTagsHeaders;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox gb_MOHeader;
        private System.Windows.Forms.TextBox tb_MO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Planner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_MOTagCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MOStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_MOLn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb_MOtagHeaderList;
        private System.Windows.Forms.Label l_EventStatus;
        private System.Windows.Forms.CheckBox cb_Lock;
        private System.Windows.Forms.ComboBox cb_InvEvent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb_MOTag_Detail;
        private System.Windows.Forms.DataGridView dgv_MODetail;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_CountedBy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_FGinWip;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_QtyReceived;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Order_QTY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_LineType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_ParentClass;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_ParentDesc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_Parent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Button b_Refresh;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}