namespace InventoryImplementation
{
    partial class f_CaptureTag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_CaptureTag));
            this.cb_InvEvent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_TagInfo = new System.Windows.Forms.GroupBox();
            this.chb_Blank = new System.Windows.Forms.CheckBox();
            this.chb_Verified = new System.Windows.Forms.CheckBox();
            this.dtp_CountedDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.chb_Void = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_ReCountQty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_CountQty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_BIN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_STK = new System.Windows.Forms.TextBox();
            this.gb_IC = new System.Windows.Forms.GroupBox();
            this.chb_Shipping = new System.Windows.Forms.CheckBox();
            this.chb_Hold = new System.Windows.Forms.CheckBox();
            this.chb_Inspection = new System.Windows.Forms.CheckBox();
            this.chb_OnHand = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ItemRef = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_UM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Lot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ItemDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ItemNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_CounterInitials = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_TagNo = new System.Windows.Forms.TextBox();
            this.cb_Lock = new System.Windows.Forms.CheckBox();
            this.b_NextTag = new System.Windows.Forms.Button();
            this.b_Prev = new System.Windows.Forms.Button();
            this.l_EventStatus = new System.Windows.Forms.Label();
            this.b_MassiveVer = new System.Windows.Forms.Button();
            this.gb_TagInfo.SuspendLayout();
            this.gb_IC.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_InvEvent
            // 
            this.cb_InvEvent.FormattingEnabled = true;
            this.cb_InvEvent.Location = new System.Drawing.Point(192, 18);
            this.cb_InvEvent.Name = "cb_InvEvent";
            this.cb_InvEvent.Size = new System.Drawing.Size(246, 24);
            this.cb_InvEvent.TabIndex = 1;
            this.cb_InvEvent.SelectedIndexChanged += new System.EventHandler(this.cb_InvEvent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Event List:";
            // 
            // gb_TagInfo
            // 
            this.gb_TagInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_TagInfo.Controls.Add(this.b_MassiveVer);
            this.gb_TagInfo.Controls.Add(this.chb_Blank);
            this.gb_TagInfo.Controls.Add(this.chb_Verified);
            this.gb_TagInfo.Controls.Add(this.dtp_CountedDate);
            this.gb_TagInfo.Controls.Add(this.label13);
            this.gb_TagInfo.Controls.Add(this.chb_Void);
            this.gb_TagInfo.Controls.Add(this.label11);
            this.gb_TagInfo.Controls.Add(this.tb_ReCountQty);
            this.gb_TagInfo.Controls.Add(this.label12);
            this.gb_TagInfo.Controls.Add(this.tb_CountQty);
            this.gb_TagInfo.Controls.Add(this.label10);
            this.gb_TagInfo.Controls.Add(this.tb_BIN);
            this.gb_TagInfo.Controls.Add(this.label9);
            this.gb_TagInfo.Controls.Add(this.tb_STK);
            this.gb_TagInfo.Controls.Add(this.gb_IC);
            this.gb_TagInfo.Controls.Add(this.label8);
            this.gb_TagInfo.Controls.Add(this.tb_ItemRef);
            this.gb_TagInfo.Controls.Add(this.label7);
            this.gb_TagInfo.Controls.Add(this.tb_UM);
            this.gb_TagInfo.Controls.Add(this.label6);
            this.gb_TagInfo.Controls.Add(this.tb_Lot);
            this.gb_TagInfo.Controls.Add(this.label5);
            this.gb_TagInfo.Controls.Add(this.tb_ItemDesc);
            this.gb_TagInfo.Controls.Add(this.label4);
            this.gb_TagInfo.Controls.Add(this.tb_ItemNo);
            this.gb_TagInfo.Controls.Add(this.label2);
            this.gb_TagInfo.Controls.Add(this.tb_CounterInitials);
            this.gb_TagInfo.Controls.Add(this.label3);
            this.gb_TagInfo.Controls.Add(this.tb_TagNo);
            this.gb_TagInfo.Enabled = false;
            this.gb_TagInfo.Location = new System.Drawing.Point(12, 64);
            this.gb_TagInfo.Name = "gb_TagInfo";
            this.gb_TagInfo.Size = new System.Drawing.Size(824, 337);
            this.gb_TagInfo.TabIndex = 4;
            this.gb_TagInfo.TabStop = false;
            this.gb_TagInfo.Text = "Tag No";
            // 
            // chb_Blank
            // 
            this.chb_Blank.AutoSize = true;
            this.chb_Blank.Enabled = false;
            this.chb_Blank.Location = new System.Drawing.Point(451, 254);
            this.chb_Blank.Name = "chb_Blank";
            this.chb_Blank.Size = new System.Drawing.Size(65, 21);
            this.chb_Blank.TabIndex = 32;
            this.chb_Blank.Text = "Blank";
            this.chb_Blank.UseVisualStyleBackColor = true;
            this.chb_Blank.Visible = false;
            // 
            // chb_Verified
            // 
            this.chb_Verified.AutoSize = true;
            this.chb_Verified.Enabled = false;
            this.chb_Verified.Location = new System.Drawing.Point(650, 54);
            this.chb_Verified.Name = "chb_Verified";
            this.chb_Verified.Size = new System.Drawing.Size(78, 21);
            this.chb_Verified.TabIndex = 6;
            this.chb_Verified.Text = "Verified";
            this.chb_Verified.UseVisualStyleBackColor = true;
            this.chb_Verified.CheckedChanged += new System.EventHandler(this.chb_Verified_CheckedChanged);
            // 
            // dtp_CountedDate
            // 
            this.dtp_CountedDate.Enabled = false;
            this.dtp_CountedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_CountedDate.Location = new System.Drawing.Point(357, 52);
            this.dtp_CountedDate.Name = "dtp_CountedDate";
            this.dtp_CountedDate.Size = new System.Drawing.Size(200, 22);
            this.dtp_CountedDate.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(354, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Counted Date:";
            // 
            // chb_Void
            // 
            this.chb_Void.AutoSize = true;
            this.chb_Void.Enabled = false;
            this.chb_Void.Location = new System.Drawing.Point(573, 54);
            this.chb_Void.Name = "chb_Void";
            this.chb_Void.Size = new System.Drawing.Size(58, 21);
            this.chb_Void.TabIndex = 5;
            this.chb_Void.Text = "Void";
            this.chb_Void.UseVisualStyleBackColor = true;
            this.chb_Void.CheckedChanged += new System.EventHandler(this.chb_Void_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(217, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Re-Count Qty:";
            // 
            // tb_ReCountQty
            // 
            this.tb_ReCountQty.Enabled = false;
            this.tb_ReCountQty.Location = new System.Drawing.Point(220, 295);
            this.tb_ReCountQty.Name = "tb_ReCountQty";
            this.tb_ReCountQty.Size = new System.Drawing.Size(140, 22);
            this.tb_ReCountQty.TabIndex = 19;
            this.tb_ReCountQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ReCountQty_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Count Qty:";
            // 
            // tb_CountQty
            // 
            this.tb_CountQty.Enabled = false;
            this.tb_CountQty.Location = new System.Drawing.Point(24, 295);
            this.tb_CountQty.Name = "tb_CountQty";
            this.tb_CountQty.Size = new System.Drawing.Size(140, 22);
            this.tb_CountQty.TabIndex = 18;
            this.tb_CountQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_CountQty_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(217, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Bin:";
            // 
            // tb_BIN
            // 
            this.tb_BIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_BIN.Enabled = false;
            this.tb_BIN.Location = new System.Drawing.Point(220, 226);
            this.tb_BIN.Name = "tb_BIN";
            this.tb_BIN.Size = new System.Drawing.Size(140, 22);
            this.tb_BIN.TabIndex = 17;
            this.tb_BIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_BIN_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Stk:";
            // 
            // tb_STK
            // 
            this.tb_STK.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_STK.Enabled = false;
            this.tb_STK.Location = new System.Drawing.Point(24, 226);
            this.tb_STK.Name = "tb_STK";
            this.tb_STK.Size = new System.Drawing.Size(140, 22);
            this.tb_STK.TabIndex = 16;
            this.tb_STK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_STK_KeyDown);
            // 
            // gb_IC
            // 
            this.gb_IC.Controls.Add(this.chb_Shipping);
            this.gb_IC.Controls.Add(this.chb_Hold);
            this.gb_IC.Controls.Add(this.chb_Inspection);
            this.gb_IC.Controls.Add(this.chb_OnHand);
            this.gb_IC.Enabled = false;
            this.gb_IC.Location = new System.Drawing.Point(451, 152);
            this.gb_IC.Name = "gb_IC";
            this.gb_IC.Size = new System.Drawing.Size(219, 96);
            this.gb_IC.TabIndex = 20;
            this.gb_IC.TabStop = false;
            this.gb_IC.Text = "Inv. Code";
            // 
            // chb_Shipping
            // 
            this.chb_Shipping.AutoSize = true;
            this.chb_Shipping.Location = new System.Drawing.Point(121, 59);
            this.chb_Shipping.Name = "chb_Shipping";
            this.chb_Shipping.Size = new System.Drawing.Size(85, 21);
            this.chb_Shipping.TabIndex = 15;
            this.chb_Shipping.Text = "Shipping";
            this.chb_Shipping.UseVisualStyleBackColor = true;
            this.chb_Shipping.CheckedChanged += new System.EventHandler(this.chb_Shipping_CheckedChanged);
            // 
            // chb_Hold
            // 
            this.chb_Hold.AutoSize = true;
            this.chb_Hold.Location = new System.Drawing.Point(121, 32);
            this.chb_Hold.Name = "chb_Hold";
            this.chb_Hold.Size = new System.Drawing.Size(59, 21);
            this.chb_Hold.TabIndex = 13;
            this.chb_Hold.Text = "Hold";
            this.chb_Hold.UseVisualStyleBackColor = true;
            this.chb_Hold.CheckedChanged += new System.EventHandler(this.chb_Hold_CheckedChanged);
            // 
            // chb_Inspection
            // 
            this.chb_Inspection.AutoSize = true;
            this.chb_Inspection.Location = new System.Drawing.Point(19, 59);
            this.chb_Inspection.Name = "chb_Inspection";
            this.chb_Inspection.Size = new System.Drawing.Size(94, 21);
            this.chb_Inspection.TabIndex = 14;
            this.chb_Inspection.Text = "Inspection";
            this.chb_Inspection.UseVisualStyleBackColor = true;
            this.chb_Inspection.CheckedChanged += new System.EventHandler(this.chb_Inspection_CheckedChanged);
            // 
            // chb_OnHand
            // 
            this.chb_OnHand.AutoSize = true;
            this.chb_OnHand.Location = new System.Drawing.Point(19, 32);
            this.chb_OnHand.Name = "chb_OnHand";
            this.chb_OnHand.Size = new System.Drawing.Size(87, 21);
            this.chb_OnHand.TabIndex = 12;
            this.chb_OnHand.Text = "On Hand";
            this.chb_OnHand.UseVisualStyleBackColor = true;
            this.chb_OnHand.CheckedChanged += new System.EventHandler(this.chb_OnHand_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(562, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Item Ref1:";
            // 
            // tb_ItemRef
            // 
            this.tb_ItemRef.Enabled = false;
            this.tb_ItemRef.Location = new System.Drawing.Point(565, 108);
            this.tb_ItemRef.Name = "tb_ItemRef";
            this.tb_ItemRef.Size = new System.Drawing.Size(105, 22);
            this.tb_ItemRef.TabIndex = 9;
            this.tb_ItemRef.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ItemRef_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(366, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "UM:";
            // 
            // tb_UM
            // 
            this.tb_UM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_UM.Enabled = false;
            this.tb_UM.Location = new System.Drawing.Point(369, 162);
            this.tb_UM.Name = "tb_UM";
            this.tb_UM.Size = new System.Drawing.Size(67, 22);
            this.tb_UM.TabIndex = 11;
            this.tb_UM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_UM_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lot:";
            // 
            // tb_Lot
            // 
            this.tb_Lot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Lot.Enabled = false;
            this.tb_Lot.Location = new System.Drawing.Point(24, 162);
            this.tb_Lot.Name = "tb_Lot";
            this.tb_Lot.Size = new System.Drawing.Size(323, 22);
            this.tb_Lot.TabIndex = 10;
            this.tb_Lot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Lot_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Item Description:";
            // 
            // tb_ItemDesc
            // 
            this.tb_ItemDesc.Enabled = false;
            this.tb_ItemDesc.Location = new System.Drawing.Point(220, 108);
            this.tb_ItemDesc.Name = "tb_ItemDesc";
            this.tb_ItemDesc.Size = new System.Drawing.Size(330, 22);
            this.tb_ItemDesc.TabIndex = 8;
            this.tb_ItemDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ItemDesc_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Item No:";
            // 
            // tb_ItemNo
            // 
            this.tb_ItemNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ItemNo.Enabled = false;
            this.tb_ItemNo.Location = new System.Drawing.Point(24, 108);
            this.tb_ItemNo.Name = "tb_ItemNo";
            this.tb_ItemNo.Size = new System.Drawing.Size(168, 22);
            this.tb_ItemNo.TabIndex = 7;
            this.tb_ItemNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ItemNo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Counter Initials:";
            // 
            // tb_CounterInitials
            // 
            this.tb_CounterInitials.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_CounterInitials.Enabled = false;
            this.tb_CounterInitials.Location = new System.Drawing.Point(220, 52);
            this.tb_CounterInitials.Name = "tb_CounterInitials";
            this.tb_CounterInitials.Size = new System.Drawing.Size(111, 22);
            this.tb_CounterInitials.TabIndex = 4;
            this.tb_CounterInitials.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_CounterInitials_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tag No:";
            // 
            // tb_TagNo
            // 
            this.tb_TagNo.Location = new System.Drawing.Point(24, 52);
            this.tb_TagNo.Name = "tb_TagNo";
            this.tb_TagNo.Size = new System.Drawing.Size(168, 22);
            this.tb_TagNo.TabIndex = 3;
            this.tb_TagNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_TagNo_KeyDown);
            // 
            // cb_Lock
            // 
            this.cb_Lock.AutoSize = true;
            this.cb_Lock.Location = new System.Drawing.Point(462, 20);
            this.cb_Lock.Name = "cb_Lock";
            this.cb_Lock.Size = new System.Drawing.Size(60, 21);
            this.cb_Lock.TabIndex = 2;
            this.cb_Lock.Text = "Lock";
            this.cb_Lock.UseVisualStyleBackColor = true;
            this.cb_Lock.CheckedChanged += new System.EventHandler(this.cb_Lock_CheckedChanged);
            // 
            // b_NextTag
            // 
            this.b_NextTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_NextTag.Enabled = false;
            this.b_NextTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_NextTag.Location = new System.Drawing.Point(790, 43);
            this.b_NextTag.Name = "b_NextTag";
            this.b_NextTag.Size = new System.Drawing.Size(46, 27);
            this.b_NextTag.TabIndex = 101;
            this.b_NextTag.Text = ">>";
            this.b_NextTag.UseVisualStyleBackColor = true;
            this.b_NextTag.Click += new System.EventHandler(this.b_NextTag_Click);
            // 
            // b_Prev
            // 
            this.b_Prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Prev.Enabled = false;
            this.b_Prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Prev.Location = new System.Drawing.Point(739, 43);
            this.b_Prev.Name = "b_Prev";
            this.b_Prev.Size = new System.Drawing.Size(45, 27);
            this.b_Prev.TabIndex = 100;
            this.b_Prev.Text = "<<";
            this.b_Prev.UseVisualStyleBackColor = true;
            this.b_Prev.Click += new System.EventHandler(this.b_Prev_Click);
            // 
            // l_EventStatus
            // 
            this.l_EventStatus.AutoSize = true;
            this.l_EventStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_EventStatus.ForeColor = System.Drawing.Color.Green;
            this.l_EventStatus.Location = new System.Drawing.Point(549, 18);
            this.l_EventStatus.Name = "l_EventStatus";
            this.l_EventStatus.Size = new System.Drawing.Size(61, 20);
            this.l_EventStatus.TabIndex = 11;
            this.l_EventStatus.Text = "status";
            // 
            // b_MassiveVer
            // 
            this.b_MassiveVer.Location = new System.Drawing.Point(645, 295);
            this.b_MassiveVer.Name = "b_MassiveVer";
            this.b_MassiveVer.Size = new System.Drawing.Size(173, 36);
            this.b_MassiveVer.TabIndex = 33;
            this.b_MassiveVer.Text = "Massive Verification";
            this.b_MassiveVer.UseVisualStyleBackColor = true;
            this.b_MassiveVer.Click += new System.EventHandler(this.b_MassiveVer_Click);
            // 
            // f_CaptureTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 413);
            this.Controls.Add(this.l_EventStatus);
            this.Controls.Add(this.b_Prev);
            this.Controls.Add(this.b_NextTag);
            this.Controls.Add(this.cb_Lock);
            this.Controls.Add(this.gb_TagInfo);
            this.Controls.Add(this.cb_InvEvent);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_CaptureTag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture Tag";
            this.gb_TagInfo.ResumeLayout(false);
            this.gb_TagInfo.PerformLayout();
            this.gb_IC.ResumeLayout(false);
            this.gb_IC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_InvEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_TagInfo;
        private System.Windows.Forms.TextBox tb_TagNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_Lock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_CounterInitials;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Lot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ItemDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ItemNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_ItemRef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_UM;
        private System.Windows.Forms.GroupBox gb_IC;
        private System.Windows.Forms.CheckBox chb_Shipping;
        private System.Windows.Forms.CheckBox chb_Hold;
        private System.Windows.Forms.CheckBox chb_Inspection;
        private System.Windows.Forms.CheckBox chb_OnHand;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_BIN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_STK;
        private System.Windows.Forms.CheckBox chb_Void;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_ReCountQty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_CountQty;
        private System.Windows.Forms.DateTimePicker dtp_CountedDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button b_NextTag;
        private System.Windows.Forms.Button b_Prev;
        private System.Windows.Forms.CheckBox chb_Verified;
        private System.Windows.Forms.CheckBox chb_Blank;
        private System.Windows.Forms.Label l_EventStatus;
        private System.Windows.Forms.Button b_MassiveVer;
    }
}