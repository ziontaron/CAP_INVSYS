using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CAP_Inventory_System;
using System.Data;
using Data_Base_MNG;

namespace InventoryImplementation
{
    public partial class f_InvEventAdmin : Form
    {
        Inventory_System_API x = new Inventory_System_API();
        Tools _tools = new Tools();
        //SQL INV_SYS = new SQL(".", "CAPA_INV", "inv_sys", "Capsonic2017!");
        //SQL DBMNG = new SQL("FSSERV", "FSDBMR", "AmalAdmin", "Amalgamma16");
        //SQL INV_SYS = new SQL("rsserver", "CAPA_INV", "inv_sys", "Capsonic2017!");

        public f_InvEventAdmin(ref Inventory_System_API IE)
        {
            InitializeComponent();
            x = IE;
            cb_InvEvent.Items.AddRange(LoadEvents().ToArray());
            t_RefreshStatsRate.Interval = Convert.ToInt32( tb_RefreshRateSecs.Text.ToString());
        }

        #region Functions
        private List<string> LoadEvents()
        {
            Clear();
            List<string> L = new List<string>();
            cb_InvEvent.Items.Clear();
            foreach (string t in x.ReadAllInventoryEvents())
            {
                L.Add(t);
            }
            return L;
        }
        private void LoadEventInfo()
        {
            x.ReadInventoryEventByName(cb_InvEvent.SelectedItem.ToString());
            if (x.ActiveEventId > 0)
            {
                rtb_ro_EventDescription.Text = x.ActiveEventDescription;
                tb_ro_QTYofTags.Text = x.ActiveEventQtyofTags.ToString();
                tb_EventCreationDate.Text = x.ActiveEventCreationDate.ToString("MM/dd/yyy");
                if (x.ActiveEventStatus)
                {
                    tb_ro_EventStatus.Text = "Active";
                    b_ChangeStatus.Text = "Close";
                }
                else
                {
                    tb_ro_EventStatus.Text = "Closed";
                    b_ChangeStatus.Text = "Activate";
                }
                foreach (Control b in this.Controls[0].Controls[0].Controls)
                {
                    if (b is Button)
                    {
                        ((Button)b).Enabled = true;
                    }
                }
                tb_NTags.Enabled = true;
                gb_AdminEvent.Enabled = true;
                gb_BlankTags.Enabled = true;
                gb_LoadTags.Enabled = true;
                b_CreateIE.Enabled = false;
                b_tagsFromSQL.Enabled = !x.TicketCountLoaded;
                b_MOtagsFromSQL.Enabled = !x.MOTagsLoaded;
                rtb_ro_EventDescription.Enabled = false;
            }


        }
        private void Clear()
        {
            cb_InvEvent.Items.Clear();
            cb_InvEvent.Text = "";
            foreach (Control b in this.Controls[0].Controls[0].Controls.OfType<Button>())
            {
                b.Enabled = false;
            }
            foreach (Control b in this.Controls[0].Controls[0].Controls.OfType<TextBox>())
            {
                b.Text = "";
                b.Enabled = false;
            }
            rtb_ro_EventDescription.Text = "";

            tb_NTags.Enabled = false;
            gb_AdminEvent.Enabled = false;
            gb_BlankTags.Enabled = false;
            gb_LoadTags.Enabled = false;
            b_CreateIE.Enabled = false;
            rtb_ro_EventDescription.Enabled = false;
        }
        private void LoadStadistics()
        {
            Stadisticts stats = x.LoadStadistics();
            if (l_TicketCounts.Text != stats.TicketCounts.ToString())
            {
                l_TicketCounts.Text = stats.TicketCounts.ToString();
            }
            if (l_TicketBlanks.Text != stats.TicketBlank.ToString())
            {
                l_TicketBlanks.Text = stats.TicketBlank.ToString();
            }
            if (l_TicketVerified.Text != stats.TicketVerified.ToString())
            {
                l_TicketVerified.Text = stats.TicketVerified.ToString();
            }
            if (l_TicketVoid.Text != stats.TicketVoid.ToString())
            {
                l_TicketVoid.Text = stats.TicketVoid.ToString();
            }
            int Porcentage = stats.TicketCountedPorcentage;
            if (pb_CountedTickets.Value != Porcentage)
            {
                pb_CountedTickets.Value = Porcentage;
                gb_CountedTikets.Text = "Counted Tickets " + Porcentage.ToString() + "% : " + stats.TicketCounted.ToString() + "/" + stats.TicketCounts.ToString();
            }
        }
        #endregion

        #region Admin Event Tab
        private void cb_InvEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEventInfo();
        }
        private void cb_InvEvent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                x.ReadInventoryEventByName(cb_InvEvent.Text);
                if (x.ActiveEventId == -1)
                {
                    rtb_ro_EventDescription.Enabled = true;
                    rtb_ro_EventDescription.Focus();
                    gb_AdminEvent.Enabled = false;
                    gb_BlankTags.Enabled = false;
                    gb_LoadTags.Enabled = false;
                    b_CreateIE.Enabled = true;
                }
            }
        }
        private void b_10BlankTags_Click(object sender, EventArgs e)
        {
            if (x.ActiveEventStatus)
            {
                x.CreateBlankBatch(10);
                LoadEventInfo();
            }
            else
            {
                MessageBox.Show("The Inventory Event must be active to proceed.");
            }
        }
        private void b_100BlankTags_Click(object sender, EventArgs e)
        {
            if (x.ActiveEventStatus)
            {
                x.CreateBlankBatch(100);
                LoadEventInfo();
            }
            else
            {
                MessageBox.Show("The Inventory Event must be active to proceed.");
            }
        }
        private void b_nBlankTags_Click(object sender, EventArgs e)
        {
            if (x.ActiveEventStatus)
            {
                int _qty = 0;
                try
                {
                    _qty = Convert.ToInt32(tb_NTags.Text.ToString());
                }
                catch
                {
                    _qty = 0;
                }

                x.CreateBlankBatch(_qty);
                LoadEventInfo();
            }
            else
            {
                MessageBox.Show("The Inventory Event must be active to proceed.");
            }
        }
        private void b_ChangeStatus_Click(object sender, EventArgs e)
        {
            x.UpdateInventoryEvent(x.ActiveEventId, x.ActiveEventName, x.ActiveEventDescription, !x.ActiveEventStatus,x.TicketCountLoaded,x.MOTagsLoaded);
            LoadEventInfo();
        }
        private void b_Clear_Click(object sender, EventArgs e)
        {
            Clear();
            cb_InvEvent.Items.AddRange(LoadEvents().ToArray());
        }
        private void b_DeleteEvent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "The insventory Event [" + x.ActiveEventName + "] will be DELETED WITH ALL ITS RELATED DATA \nAre you sure of deleting this Data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                x.DeleteInventoryEvent(x.ActiveEventId);
                cb_InvEvent.Items.AddRange(LoadEvents().ToArray());
            }
        }
        private void b_CreateIE_Click(object sender, EventArgs e)
        {
            string _newEvent = cb_InvEvent.Text;
            x.CreateInventoryEvent(cb_InvEvent.Text, rtb_ro_EventDescription.Text);
            cb_InvEvent.Items.AddRange(LoadEvents().ToArray());
            cb_InvEvent.SelectedItem = cb_InvEvent.Items[cb_InvEvent.Items.IndexOf(_newEvent)];
            LoadEventInfo();
        }
        private void b_tagsFromCSV_Click(object sender, EventArgs e)
        {
            if (x.ActiveEventStatus)
            {
                OpenFileDialog _OFD = new OpenFileDialog();
                DialogResult _DalogResult = _OFD.ShowDialog();
                try
                {
                    _tools.Load_tags_From_CSV(ref x, _OFD.FileName);
                    LoadEventInfo();
                }
                catch(Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("The Inventory Event must be active to proceed.");
            }
        }
        private void b_tagsFromSQL_Click(object sender, EventArgs e)
        {
            if (x.ActiveEventStatus)
            {
                _tools.Load_Tags_From_SQL(ref x);
                x.UpdateInventoryEvent(x.ActiveEventId, x.ActiveEventName, x.ActiveEventDescription, x.ActiveEventStatus, true, x.MOTagsLoaded);
                LoadEventInfo();
            }
            else
            {
                MessageBox.Show("The Inventory Event must be active to proceed.");
            }
        }
        private void b_tagsFromRandom_Click(object sender, EventArgs e)
        {
            if (x.ActiveEventStatus)
            {
                _tools.Load_Tags_From_Random(ref x, 200);
                LoadEventInfo();
            }
            else
            {
                MessageBox.Show("The Inventory Event must be active to proceed.");
            }
        }


        #endregion

        private void b_MOtagsFromCSV_Click(object sender, EventArgs e)
        {
            if (x.ActiveEventStatus)
            {
                OpenFileDialog _OFD = new OpenFileDialog();
                DialogResult _DalogResult = _OFD.ShowDialog();
                try
                {
                    _tools.Load_MOtags_From_CSV(ref x, _OFD.FileName);
                    LoadEventInfo();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("The Inventory Event must be active to proceed.");
            }
        }

        private void b_MOtagsFromSQL_Click(object sender, EventArgs e)
        {
            if (x.ActiveEventStatus)
            {
                _tools.Load_MOTags_From_SQL(ref x);
                x.UpdateInventoryEvent(x.ActiveEventId, x.ActiveEventName, x.ActiveEventDescription, !x.ActiveEventStatus, x.TicketCountLoaded, true);
                LoadEventInfo();
            }
            else
            {
                MessageBox.Show("The Inventory Event must be active to proceed.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadStadistics();
        }

        private void t_RefreshStatsRate_Tick(object sender, EventArgs e)
        {
            LoadStadistics();
        }

        private void tb_RefreshRateSecs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                try
                {
                    t_RefreshStatsRate.Interval = Convert.ToInt32(tb_RefreshRateSecs.Text.ToString()) * 1000;
                }
                catch
                {
                    t_RefreshStatsRate.Interval = 10000;
                    tb_RefreshRateSecs.Text = "10";
                }
            }
        }

        private void b_LoadFSIM_Click(object sender, EventArgs e)
        {
            string ItemMaster_Q = @"SELECT * FROM _CAP_INV_SYS_ItemMaster";

            CAPA_INVContext context = new CAPA_INVContext();
            SQL DBMNG = context.DB_MNG_FS;

            DataTable Item_Master_T = DBMNG.Execute_Query(ItemMaster_Q);

            for(int i=0;i<Item_Master_T.Rows.Count;i++)
            {
                x.AddItemtoIM(Item_Master_T.Rows[i]);
            }

            context.Dispose();
        }
    }
}
