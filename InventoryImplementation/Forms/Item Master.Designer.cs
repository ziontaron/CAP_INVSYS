namespace InventoryImplementation
{
    partial class f_Item_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Item_Master));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_PartNo = new System.Windows.Forms.TextBox();
            this.dgv_ItemMaster = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Part No:";
            // 
            // tb_PartNo
            // 
            this.tb_PartNo.Location = new System.Drawing.Point(104, 15);
            this.tb_PartNo.Name = "tb_PartNo";
            this.tb_PartNo.Size = new System.Drawing.Size(208, 22);
            this.tb_PartNo.TabIndex = 1;
            this.tb_PartNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_PartNo_KeyDown);
            // 
            // dgv_ItemMaster
            // 
            this.dgv_ItemMaster.AllowUserToAddRows = false;
            this.dgv_ItemMaster.AllowUserToDeleteRows = false;
            this.dgv_ItemMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ItemMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ItemMaster.Location = new System.Drawing.Point(12, 53);
            this.dgv_ItemMaster.Name = "dgv_ItemMaster";
            this.dgv_ItemMaster.ReadOnly = true;
            this.dgv_ItemMaster.RowTemplate.Height = 24;
            this.dgv_ItemMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ItemMaster.Size = new System.Drawing.Size(1011, 638);
            this.dgv_ItemMaster.TabIndex = 2;
            this.dgv_ItemMaster.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_ItemMaster_KeyDown);
            this.dgv_ItemMaster.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_ItemMaster_MouseDoubleClick);
            // 
            // f_Item_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 703);
            this.Controls.Add(this.dgv_ItemMaster);
            this.Controls.Add(this.tb_PartNo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_Item_Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item_Master";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_PartNo;
        private System.Windows.Forms.DataGridView dgv_ItemMaster;
    }
}