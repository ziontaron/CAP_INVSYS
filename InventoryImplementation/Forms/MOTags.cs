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
    public partial class f_MOTags : Form
    {
        Inventory_System_API x = new Inventory_System_API();
        DataTable _MOTags_Header = new DataTable();
        MOTag _t = new MOTag();
        public f_MOTags(ref Inventory_System_API IE)
        {
            InitializeComponent();
            cb_InvEvent.Items.AddRange(_LoadEvents().ToArray());
            x = IE;
        }

        #region Functions
        private void Load_MOTag_Headers()
        {
            dgv_MOTagsHeaders.DataSource = null;
            dgv_MOTagsHeaders.DataSource = x.MOTagHeaders2Table();
            gb_MOHeader.Enabled = true;
            gb_MOTag_Detail.Enabled = true;
            dgv_MODetail.DataSource = null;

            foreach (Control b in this.gb_MOHeader.Controls.OfType<TextBox>())
            {
                b.Text = "";
            }
        }
        private void Load_MOTag_Lines(int MOTagHeaderID)
        {
            dgv_MODetail.DataSource = null;
            dgv_MODetail.DataSource = x.MOTagLines2Table(MOTagHeaderID);
            for (int i = 0; i<dgv_MODetail.ColumnCount; i++)
            {
                if ((dgv_MODetail.Columns[i].Name == "LooseCountQty" || dgv_MODetail.Columns[i].Name == "LooseReCountQty")&& x.ActiveEventStatus)
                {
                    dgv_MODetail.Columns[i].ReadOnly = false;
                }
                else
                {
                    dgv_MODetail.Columns[i].ReadOnly = true;
                }
            }
            if (x.ActiveEventStatus)
            {
                b_Save.Enabled = true;
                tb_CountedBy.Enabled = true;
                tb_FGinWip.Enabled = true;
            }
            else
            {
                b_Save.Enabled = false;
                tb_CountedBy.Enabled = false;
                tb_FGinWip.Enabled = false;
            }

        }
        private void Load_SelectedMOtagHeader(int Counter)
        {
            _t = x.LoadMOHeaderTag(Counter);
            if (_t != null)
            {
                tb_MOTagCounter.Text = Counter.ToString();
                tb_Planner.Text = _t.Planner;
                tb_MO.Text = _t.MO;
                tb_MOLn.Text = _t.MO_Ln;
                tb_MOStatus.Text = _t.MO_Status;
                tb_Order_QTY.Text = _t.Order_Qty.ToString();
                tb_QtyReceived.Text = _t.Recv_Qty.ToString();
                tb_LineType.Text = _t.LineType.ToString();
                tb_FGinWip.Text = _t.FGinWip.ToString();
                tb_Parent.Text = _t.Parent_Item_NO.ToString();
                tb_ParentDesc.Text = _t.Parent_Item_Desc.ToString();
                tb_ParentClass.Text = _t.Parent_ItemRef1;

                tb_CountedBy.Text = _t.CounterInitials;
                tb_FGinWip.Text = _t.FGinWip.ToString();

                tb_CountedBy.Enabled = true;
                tb_FGinWip.Enabled = true;

                Load_MOTag_Lines(_t.MOTagID);
            }

            //tb_CountedBy.Enabled=t

        }
        private List<string> _LoadEvents()
        {
            List<string> L = new List<string>();
            L = x.LoadEvents();
            return L;
        }
        private void Clear()
        {
            cb_InvEvent.Items.Clear();
            cb_InvEvent.Text = "";
            foreach (Control b in this.gb_MOHeader.Controls.OfType<TextBox>())
            {
                b.Text = "";
            }
            gb_MOtagHeaderList.Enabled = false;
            dgv_MOTagsHeaders.DataSource = null;
            gb_MOHeader.Enabled = false;
            gb_MOTag_Detail.Enabled = false;
            dgv_MODetail.DataSource = null;
            l_EventStatus.Text = "";

            b_Refresh.Enabled = false;
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
        private void SaveMOLies()
        {
            MOTagLine _moTagLine = new MOTagLine();
            if (tb_CountedBy.Text != "")
            {
                for (int i = 0; i < dgv_MODetail.RowCount; i++)
                {

                    DataRow r = (dgv_MODetail.Rows[i].DataBoundItem as DataRowView).Row;
                    //DataRow r = (DataRow)(dgv_MODetail.Rows[i].DataBoundItem);
                    _moTagLine = MOTagLineLogic.DataRow2MOTagLine_FromDGV(r);
                    x.UpdateMOMOTagLine(_moTagLine);
                }
            }
            else
            {
                MessageBox.Show("Please update the header first.");
            }

        }
        private void SaveMOHeader()
        {
                _t.CountedDate = DateTime.Now;
                _t.CounterInitials = tb_CountedBy.Text;
                try
                {
                    _t.FGinWip = Convert.ToInt32(tb_FGinWip.Text);
                }
                catch
                {
                    _t.FGinWip = 0;
                }
                x.UpdateMOHeaderTag(_t);

        }
        #endregion

        #region Events
        private void dgv_MOTagsHeaders_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyValue)
            {
                case 116:
                    {
                        Load_MOTag_Headers();
                        break;
                    }
                default:
                    {
                        MessageBox.Show(e.KeyValue.ToString());
                        break;
                    }
            }
        }
        private void dgv_MOTagsHeaders_Click(object sender, EventArgs e)
        {
            if (dgv_MOTagsHeaders.SelectedRows.Count == 1)
            {
                int counter = (int)dgv_MOTagsHeaders.SelectedRows[0].Cells[0].Value;
                Load_SelectedMOtagHeader(counter);
            }
        }
        private void cb_Lock_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_InvEvent.SelectedIndex > -1 && cb_Lock.Checked)
            {
                cb_InvEvent.Enabled = false;
                Load_MOTag_Headers();
                LoadEventInfo();
                cb_InvEvent.Enabled = !cb_Lock.Checked;
                gb_MOtagHeaderList.Enabled = cb_Lock.Checked;

                cb_InvEvent.Enabled = true;
                //tb_TagNo.Focus();
                //b_NextTag.Enabled = true;
                //b_Prev.Enabled = true;
                b_Refresh.Enabled = true;
            }
            else
            {
                cb_InvEvent.Enabled = true;
                cb_Lock.Checked = false;
            }
            if (!cb_Lock.Checked)
            {
                Clear();
                cb_InvEvent.Items.AddRange(_LoadEvents().ToArray());
            }
        }
        private void tb_MOTagCounter_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 13:
                    {
                        tb_CountedBy.Focus();
                        break;
                    }
            }
        }
        private void tb_CountedBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                tb_FGinWip.Focus();
            }
        }
        private void tb_FGinWip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && tb_MOTagCounter.Text != "" && tb_CountedBy.Text != "" && tb_FGinWip.Text != "")
            {
                SaveMOHeader();
            }
        }
        private void b_Save_Click(object sender, EventArgs e)
        {
            SaveMOLies();
        }
        private void b_Refresh_Click(object sender, EventArgs e)
        {
            SaveMOHeader();
            Load_MOTag_Headers();
        }
        #endregion

    }
}
