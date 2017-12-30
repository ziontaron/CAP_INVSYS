using CAP_Inventory_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryImplementation
{
    public partial class f_MassiveTagVerify : Form
    {
        Inventory_System_API x = new Inventory_System_API();
        TicketTag _tag = new TicketTag();
        int _tagNo = 0;
        bool Loading_data = false;

        List<TicketCount> L;
        DataTable _table=new DataTable();

        public f_MassiveTagVerify(ref Inventory_System_API IE)
        {
            InitializeComponent();
            x = IE;
            SetUpTable();
        }

        #region Private Functions
        private void SetUpTable()
        {
            _table = new DataTable();
            #region Table Setup
            _table.Columns.Add("Tag Counter", typeof(int));
            _table.Columns.Add("Counter Initials", typeof(string));
            _table.Columns.Add("Item Number", typeof(string));
            _table.Columns.Add("Item Description", typeof(string));
            _table.Columns.Add("Class", typeof(string));
            _table.Columns.Add("UM", typeof(string));
            _table.Columns.Add("STK", typeof(string));
            _table.Columns.Add("Bin", typeof(string));
            _table.Columns.Add("IC", typeof(string));
            _table.Columns.Add("LotNumber", typeof(string));
            _table.Columns.Add("Verified", typeof(bool));
            _table.Columns.Add("Void", typeof(bool));
            _table.Columns.Add("Counted Qty", typeof(float));
            _table.Columns.Add("Re-Counted Qty", typeof(float));
            _table.Columns.Add("TicketKey", typeof(int));
            _table.Columns.Add("TicketCountKey", typeof(int));
            #endregion
        }
        private void SetReadOnlyColumns()
        {
            try
            {
                for (int i = 0; i < dgv_FilteredTags.Columns.Count; i++)
                {
                    if (dgv_FilteredTags.Columns[i].Name == "Verified"
                        || dgv_FilteredTags.Columns[i].Name == "Void")
                    {
                        dgv_FilteredTags.Columns[i].ReadOnly = false;
                    }
                    else
                    {
                        dgv_FilteredTags.Columns[i].ReadOnly = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadTags()
        {
            TicketCount T = new TicketCount();
            Ticket t = new Ticket();
            L = new List<TicketCount>();
            SetUpTable();
            t.InventoryEventKey = x.ActiveEventId;
            T.Ticket = t;
            T.Verified = false;
            L = x.LoadTags_List(T);
            List2Table(L);
            dgv_FilteredTags.DataSource = _table;
            SetReadOnlyColumns();
        }
        private void LoadTags(string Range)
        {
            TicketCount T = new TicketCount();
            Ticket t = new Ticket();
            L = new List<TicketCount>();
            SetUpTable();
            t.InventoryEventKey = x.ActiveEventId;
            T.Ticket = t;
            T.Verified = false;
            L = x.LoadTags_List(T,Range);
            List2Table(L);
            dgv_FilteredTags.DataSource = null;
            dgv_FilteredTags.DataSource = _table;
            SetReadOnlyColumns();
        }
        private void List2Table(List<TicketCount> L)
        {
            foreach (TicketCount _t in L)
            {
                _table.Rows.Add(
                    _t.Ticket.TicketCounter
                    , _t.CounterInitials
                    , _t.ItemNumber
                    , _t.ItemDescription
                    , _t.ItemRef
                    , _t.UM
                    , _t.STK
                    , _t.BIN
                    , _t.IC
                    , _t.LotNumber
                    , _t.Verified
                    , _t.VoidTag
                    , _t.CountQty
                    , _t.ReCountQty
                    , _t.TicketKey
                    , _t.TagCountKey
                    );
            }
            //dgv_FilteredTags.DataSource = _table;
            //SetReadOnlyColumns();
        }
        #endregion

        private void b_RefreshList_Click(object sender, EventArgs e)
        {
            if (tb_TagFrom.Text != "" && tb_TagTo.Text != "")
            {
                string range = tb_TagFrom.Text + "," + tb_TagTo.Text;
                LoadTags(range);
                this.Text = "Massive Tag Verify " + L.Count.ToString() + " Tags Loaded";
            }
            else
            {
                MessageBox.Show("FROM or TO must be captured");
            }
        }

        private void dgv_FilteredTags_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int TagIndex = e.RowIndex;
            int tagNo = (int)dgv_FilteredTags.Rows[TagIndex].Cells["Tag Counter"].Value;
           
            L[TagIndex].Verified = (bool)dgv_FilteredTags.Rows[TagIndex].Cells["Verified"].Value;
            L[TagIndex].VoidTag = (bool)dgv_FilteredTags.Rows[TagIndex].Cells["Void"].Value;

            if (dgv_FilteredTags.Rows[TagIndex].Cells["Item Number"].Value.ToString() == ""
                && !(bool)dgv_FilteredTags.Rows[TagIndex].Cells["Void"].Value)
            {
                MessageBox.Show("A blank Tag can not be Verified.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgv_FilteredTags.Rows[TagIndex].Cells["Verified"].Value = false;
            }
            else
            {
                x.UpdateTag(L[TagIndex]);
            }

        }
    }
}
