using CAP_Inventory_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryImplementation
{
    public partial class f_CaptureTag : Form
    {
        Inventory_System_API x = new Inventory_System_API();
        TicketTag _tag = new TicketTag();
        int _tagNo = 0;
        bool Loading_data = false;

        public f_CaptureTag(ref Inventory_System_API IE)
        {
            InitializeComponent();
            x = IE;
            cb_InvEvent.Items.AddRange(_LoadEvents().ToArray());
            l_EventStatus.Text = "";
        }
        #region Functions
        private List<string> _LoadEvents()
        {
            Clear();
            List<string> L = new List<string>();
            L = x.LoadEvents();
            return L;
        }
        private void LoadEventInfo()
        {
            x.ReadInventoryEventByName(cb_InvEvent.SelectedItem.ToString());
            if (x.ActiveEventStatus)
            {
                //active
                l_EventStatus.Text = "ACTIVE";
                l_EventStatus.ForeColor = Color.Green;
            }
            else
            {
                //closed
                l_EventStatus.Text = "CLOSED";
                l_EventStatus.ForeColor = Color.Red;
            }
        }
        private void Clear()
        {
            cb_InvEvent.Items.Clear();
            cb_InvEvent.Text = "";
            foreach (Control b in this.gb_TagInfo.Controls.OfType<TextBox>())
            {
                if (b.Name.ToString() != "tb_TagNo")
                {
                    b.Text = "";
                }
                
                //b.Enabled = false;
            }
        }
        private void LoadTagInfo(TicketTag T)
        {
            Loading_data = true;
            if (T != null)
            {
                _tag = T;
                tb_CounterInitials.Text = T.CounterInitials;
                try
                {
                    dtp_CountedDate.Value = (DateTime)T.CountedDate;
                }
                catch
                {
                    dtp_CountedDate.Value = DateTime.Now;
                }
                chb_Void.Checked = T.VoidTag;
                chb_Verified.Checked = T.Verified;
                tb_ItemNo.Text = T.ItemNumber;
                tb_ItemDesc.Text = T.ItemDescription;
                tb_ItemRef.Text = T.ItemReference1;
                tb_Lot.Text = T.LotNumber;
                tb_UM.Text = T.ItemUM;
                tb_STK.Text = T.Stockroom;
                tb_BIN.Text = T.Bin;
                tb_CountQty.Text = T.CountQTY.ToString();
                tb_ReCountQty.Text = T.ReCountQTY.ToString();
                chb_Blank.Checked = T.BlankTag;
                #region IC
                switch (T.InventoryCategory)
                {
                    case "O":
                        {
                            chb_OnHand.Checked = true;
                            chb_Hold.Checked = false;
                            chb_Inspection.Checked = false;
                            chb_Shipping.Checked = false;
                            break;
                        }
                    case "H":
                        {
                            chb_OnHand.Checked = false;
                            chb_Hold.Checked = true;
                            chb_Inspection.Checked = false;
                            chb_Shipping.Checked = false;
                            break;
                        }
                    case "I":
                        {
                            chb_OnHand.Checked = false;
                            chb_Hold.Checked = false;
                            chb_Inspection.Checked = true;
                            chb_Shipping.Checked = false;
                            break;
                        }
                    case "S":
                        {
                            chb_OnHand.Checked = false;
                            chb_Hold.Checked = false;
                            chb_Inspection.Checked = false;
                            chb_Shipping.Checked = true;
                            break;
                        }
                }
                #endregion

                if (x.ActiveEventStatus)
                {
                    #region enable fields
                    if (!T.VoidTag)
                    {
                        chb_Void.Enabled = true;
                        chb_Verified.Enabled = true;
                        tb_CounterInitials.Enabled = true;
                        tb_CounterInitials.Enabled = true;

                        if (T.BlankTag)
                        {
                            tb_ItemNo.Enabled = true;
                            tb_ItemNo.Enabled = true;
                            tb_ItemDesc.Enabled = true;
                            tb_ItemRef.Enabled = true;
                            tb_Lot.Enabled = true;
                            tb_UM.Enabled = true;
                            gb_IC.Enabled = true;
                            tb_STK.Enabled = true;
                            tb_BIN.Enabled = true;

                            chb_OnHand.Checked = true;
                            chb_Hold.Checked = false;
                            chb_Inspection.Checked = false;
                            chb_Shipping.Checked = false;

                        }
                        else
                        {
                            tb_ItemNo.Enabled = false;
                            tb_ItemNo.Enabled = false;
                            tb_ItemDesc.Enabled = false;
                            tb_ItemRef.Enabled = false;
                            tb_Lot.Enabled = false;
                            tb_UM.Enabled = false;
                            gb_IC.Enabled = false;
                            tb_STK.Enabled = false;
                            tb_BIN.Enabled = false;
                        }
                        if (tb_CountQty.Text == "0")
                        {
                            tb_CountQty.Enabled = true;
                            tb_ReCountQty.Enabled = false;
                        }
                        else
                        {
                            tb_CountQty.Enabled = false;
                            tb_ReCountQty.Enabled = true;
                        }
                    }
                    else
                    {
                        tb_CounterInitials.Enabled = false;
                        tb_ItemNo.Enabled = false;
                        tb_ItemNo.Enabled = false;
                        tb_ItemDesc.Enabled = false;
                        tb_ItemRef.Enabled = false;
                        tb_Lot.Enabled = false;
                        tb_UM.Enabled = false;
                        gb_IC.Enabled = false;
                        tb_STK.Enabled = false;
                        tb_BIN.Enabled = false;
                        tb_CountQty.Enabled = false;
                        tb_ReCountQty.Enabled = false;

                    }
                    #endregion
                }
            }
            else
            {
                foreach (Control b in this.gb_TagInfo.Controls.OfType<TextBox>())
                {
                    if (b.Name.ToString() != "tb_TagNo")
                    {
                        b.Text = "";
                        b.Enabled = false;
                    }
                }
                gb_IC.Enabled = false;

                chb_OnHand.Checked = false;
                chb_Hold.Checked = false;
                chb_Inspection.Checked = false;
                chb_Shipping.Checked = false;
                
                chb_Void.Enabled = false;
                chb_Void.Checked = false;

                chb_Verified.Enabled = false;
                chb_Verified.Checked = false;
            }

            Loading_data = false;

        }
        private void NextTag()
        {
            Loading_data = true;
            _tagNo++;
            if (_tagNo <= x.GetLastCounter())
            {
                tb_TagNo.Text = _tagNo.ToString();
                LoadTagInfo(x.LoadTag(_tagNo));
            }
            else
            {
                tb_TagNo.Text = x.GetLastCounter().ToString();
                _tagNo = x.GetLastCounter();
                LoadTagInfo(x.LoadTag(x.GetLastCounter()));
            }
            Loading_data = false;
        }
        private void PrevTag()
        {
            Loading_data = true;
            _tagNo--;
            if (_tagNo <= 0)
            {
                _tagNo = 1;
            }
            if (_tagNo > 0)
            {
                if (_tagNo <= x.GetLastCounter())
                {
                    tb_TagNo.Text = _tagNo.ToString();
                    LoadTagInfo(x.LoadTag(_tagNo));
                }
                else
                {
                    tb_TagNo.Text = x.GetLastCounter().ToString();
                    _tagNo = x.GetLastCounter();
                    LoadTagInfo(x.LoadTag(x.GetLastCounter()));
                }
            }
            else
            {
                tb_TagNo.Text = _tagNo.ToString();
                LoadTagInfo(x.LoadTag(0));
            }
            Loading_data = false;
        }
        private string IC_Parse()
        {
            if (chb_OnHand.Checked)
            {
                return "O";
            }
            if (chb_Hold.Checked)
            {
                return "H";
            }
            if (chb_Inspection.Checked)
            {
                return "I";
            }
            if (chb_Shipping.Checked)
            {
                return "S";
            }
            else
            {
                return "O";
            }
        }
        private void BeforeToSave()
        {
            _tag.VoidTag = chb_Void.Checked;
            _tag.Verified = chb_Verified.Checked;
            if (_tag.BlankTag)
            {
                _tag.CounterInitials = tb_CounterInitials.Text;
                try
                {
                    _tag.CountQTY = Convert.ToInt32(tb_CountQty.Text);
                }
                catch
                {
                    _tag.CountQTY = 0;
                }
                try
                {
                    _tag.ReCountQTY = Convert.ToInt32(tb_ReCountQty.Text);
                }
                catch
                {
                    _tag.ReCountQTY = 0;
                }
                _tag.InventoryCategory = IC_Parse();
                _tag.CountedDate = dtp_CountedDate.Value;
                _tag.ItemNumber = tb_ItemNo.Text;
                _tag.ItemDescription = tb_ItemDesc.Text;
                _tag.ItemReference1 = tb_ItemRef.Text;
                _tag.LotNumber = tb_Lot.Text;
                _tag.ItemUM = tb_UM.Text;
                _tag.Stockroom = tb_STK.Text;
                _tag.Bin = tb_BIN.Text;
                
            }
            else
            {
                _tag.CountedDate = dtp_CountedDate.Value;
                _tag.CounterInitials = tb_CounterInitials.Text;
                try
                {
                    _tag.CountQTY = Convert.ToInt32(tb_CountQty.Text);
                }
                catch
                {
                    _tag.CountQTY = 0;
                }
                try
                {
                    _tag.ReCountQTY = Convert.ToInt32(tb_ReCountQty.Text);
                }
                catch
                {
                    _tag.ReCountQTY = 0;
                }
            }
        }
        private void UpdateTag()
        {
            BeforeToSave();
            x.UpdateTag(_tag);
            if (x.ErrorOccour)
            {
                MessageBox.Show(x.ErrorMessage);
            }
            LoadTagInfo(_tag);
        }
        private void LoadFSItemInfo(string PN)
        {
            FS_Item item = x.LoadItemNo(PN);
            if (item.ItemNo != null)
            {
                _tag.ItemNumber = item.ItemNo;
                _tag.ItemDescription = item.ItemDesc;
                _tag.ItemUM = item.ItemUM;
                _tag.ItemReference1 = item.ItemReference1;
                _tag.ItemNumber_FSKey = item.ItemNumber_FSKey;
                LoadTagInfo(_tag);
            }
            else
            {
                _tag.ItemNumber = "";
                MessageBox.Show("Part No was not foud in the Item Master","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        private void cb_Lock_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_InvEvent.SelectedIndex > -1)
            {
                LoadEventInfo();
                cb_InvEvent.Enabled = !cb_Lock.Checked;
                gb_TagInfo.Enabled = cb_Lock.Checked;
                tb_TagNo.Focus();
                b_NextTag.Enabled = true;
                b_Prev.Enabled = true;
            }
            else
            {
                cb_InvEvent.Enabled = true;
                gb_TagInfo.Enabled = false;
                cb_Lock.Checked = false;
            }
        }
        private void tb_TagNo_KeyDown(object sender, KeyEventArgs e)
        {
            //39-> 37<-
            switch (e.KeyValue)
            {
                case 13:
                    {
                        if (tb_TagNo.Text.Trim() != "")
                        {
                            _tagNo = Convert.ToInt32(tb_TagNo.Text);
                            _tag = x.LoadTag(_tagNo);
                            if (_tag != null)
                            {
                                LoadTagInfo(_tag);
                                tb_CounterInitials.Focus();
                            }
                            else
                            {
                                MessageBox.Show("The Tag was not found.");
                            }
                        }
                        break;
                    }
                case 39:
                    {
                        NextTag();
                        break;
                    }
                case 37:
                    {
                        PrevTag();
                        break;
                    }
            }

        }
        private void cb_InvEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadEventInfo();
        }
        private void b_NextTag_Click(object sender, EventArgs e)
        {
            NextTag();
        }
        private void b_Prev_Click(object sender, EventArgs e)
        {
            PrevTag();
        }

        #region IC group
        private void chb_OnHand_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_OnHand.Checked)
            {
                chb_OnHand.Checked = true;
                chb_Inspection.Checked = false;
                chb_Hold.Checked = false;
                chb_Shipping.Checked = false;
            }
        }
        private void chb_Hold_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Hold.Checked)
            {
                chb_OnHand.Checked = false;
                chb_Inspection.Checked = false;
                chb_Hold.Checked = true;
                chb_Shipping.Checked = false;
            }
        }
        private void chb_Inspection_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Inspection.Checked)
            {
                chb_OnHand.Checked = false;
                chb_Inspection.Checked = true;
                chb_Hold.Checked = false;
                chb_Shipping.Checked = false;
            }
        }
        private void chb_Shipping_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Shipping.Checked)
            {
                chb_OnHand.Checked = false;
                chb_Inspection.Checked = false;
                chb_Hold.Checked = false;
                chb_Shipping.Checked = true;
            }
        }
        #endregion

        private void tb_CounterInitials_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (chb_Blank.Checked)
                {
                    tb_ItemNo.Focus();
                }
                else
                {
                    if (tb_CountQty.Enabled)
                    {
                        tb_CountQty.Focus();
                    }
                    else
                    {
                        tb_ReCountQty.Focus();
                    }
                }
                _tag.CounterInitials = tb_CounterInitials.Text;
            }
        }
        private void tb_CountQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                tb_TagNo.Focus();
                tb_TagNo.SelectAll();
                try
                {
                    _tag.CountQTY = Convert.ToInt32(tb_CountQty.Text);
                }
                catch
                {
                    _tag.CountQTY = 0;
                }
                UpdateTag();
            }
        }        
        private void tb_ItemNo_KeyDown(object sender, KeyEventArgs e)
        {
            f_Item_Master f_IM; 
            if (e.KeyValue == 13)
            {
                LoadFSItemInfo(tb_ItemNo.Text);
                if (tb_ItemDesc.Text == "")
                {
                    f_IM = new f_Item_Master(ref x,tb_ItemNo.Text);
                    f_IM.ShowDialog();
                    tb_ItemNo.Focus();
                    tb_ItemNo.Text = f_IM.PartNo;
                    LoadFSItemInfo(tb_ItemNo.Text);
                }
                else
                {
                    tb_ItemDesc.Focus();
                }
            }
            if (e.KeyValue == 115)
            {
                f_IM = new f_Item_Master(ref x, tb_ItemNo.Text);
                f_IM.ShowDialog();
                tb_ItemNo.Text = f_IM.PartNo;
                LoadFSItemInfo(tb_ItemNo.Text);
            }
        }
        private void tb_ItemDesc_KeyDown(object sender, KeyEventArgs e)
        {
            f_Item_Master f_IM;
            if (e.KeyValue == 13)
            {
                tb_ItemRef.Focus();
                _tag.ItemDescription = tb_ItemDesc.Text;
            }
            if (e.KeyValue == 115)
            {
                f_IM = new f_Item_Master(ref x, tb_ItemNo.Text);
                f_IM.ShowDialog();
                tb_ItemNo.Text = f_IM.PartNo;
                LoadFSItemInfo(tb_ItemNo.Text);
            }
        }
        private void tb_ItemRef_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                tb_Lot.Focus();
                _tag.ItemReference1 = tb_ItemRef.Text;
            }
        }
        private void tb_Lot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                tb_UM.Focus();
                _tag.LotNumber = tb_Lot.Text;
            }
        }
        private void tb_UM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                tb_STK.Focus();
                _tag.ItemUM = tb_UM.Text;
            }
        }
        private void tb_STK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                tb_BIN.Focus();
                _tag.Stockroom = tb_STK.Text;
            }
        }
        private void tb_BIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (tb_CountQty.Enabled)
                {
                    tb_CountQty.Focus();
                }
                else
                {
                    tb_ReCountQty.Focus();
                }
                _tag.Bin = tb_BIN.Text;
            }
        }
        private void tb_ReCountQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                UpdateTag();
                tb_TagNo.Focus();
                tb_TagNo.SelectAll();

            }
        }
        private void chb_Void_CheckedChanged(object sender, EventArgs e)
        {
            if (!Loading_data)
            {
                UpdateTag();
            }
        }
        private void chb_Verified_CheckedChanged(object sender, EventArgs e)
        {
            if (!Loading_data)
            {
                if (chb_Blank.Checked && (tb_ItemNo.Text == "" || tb_CountQty.Text == "0"))
                {
                    MessageBox.Show("A blank Tag can not be Verified.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    UpdateTag();
                }
            }
        }

        private void b_MassiveVer_Click(object sender, EventArgs e)
        {
            f_MassiveTagVerify z = new InventoryImplementation.f_MassiveTagVerify(ref x);
            z.ShowDialog();
        }
    }
}
