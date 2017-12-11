using FS4Amalgamma;
using System;
using System.Drawing;
using System.Windows.Forms;
using FS4Amalgamma;
using CAP_Inventory_System;
using System.Collections.Generic;
using System.Data;

namespace Balance_Adjusments
{
    public partial class f_BalanceAdj : Form
    {
        AmalgammaFSTI FSTI;
        Inventory_System_API x = new Inventory_System_API();
        TicketTag _tag = new TicketTag();
        DataTable Tags = new DataTable();
        public f_BalanceAdj(ref Inventory_System_API IE)
        {
            InitializeComponent();
            x = IE;
            cb_InvEvent.Items.AddRange(_LoadEvents().ToArray());
            l_EventStatus.Text = "";
        }

        #region private Functions
        //private void FS_ConfLog(string LogType, string LogMessage)
        //{
        //    switch (LogType)
        //    {
        //        case "error":
        //            {
        //                rtb_Log.SelectionColor = Color.Red;
        //                rtb_Log.AppendText(LogMessage);
        //                rtb_Log.AppendText("\n");
        //                break;
        //            }
        //        case "success":
        //            {
        //                rtb_Log.SelectionColor = Color.DarkGreen;
        //                rtb_Log.AppendText(LogMessage);
        //                rtb_Log.AppendText("\n");
        //                break;
        //            }
        //        case "info":
        //            {
        //                rtb_Log.SelectionColor = Color.Black;
        //                rtb_Log.AppendText(LogMessage);
        //                rtb_Log.AppendText("\n");
        //                break;
        //            }
        //        default:
        //            {
        //                break;
        //            }
        //    }
        //}
        private void FS_ConfLog(ref RichTextBox rtb_Log,  string LogType, string LogMessage)
        {
            switch (LogType)
            {
                case "error":
                    {
                        rtb_Log.SelectionColor = Color.Red;
                        rtb_Log.AppendText(LogMessage);
                        rtb_Log.AppendText("\n");
                        break;
                    }
                case "success":
                    {
                        rtb_Log.SelectionColor = Color.DarkGreen;
                        rtb_Log.AppendText(LogMessage);
                        rtb_Log.AppendText("\n");
                        break;
                    }
                case "info":
                    {
                        rtb_Log.SelectionColor = Color.Black;
                        rtb_Log.AppendText(LogMessage);
                        rtb_Log.AppendText("\n");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        private List<string> _LoadEvents()
        {
            //Clear();
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
        #endregion

        private void b_CFGBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog CFGDialog = new OpenFileDialog();
            DialogResult result = CFGDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                tb_FSCFGFile.Text = CFGDialog.FileName;
            }
        }
        private void b_CloseConnection_Click(object sender, EventArgs e)
        {
            FSTI.AmalgammaFSTI_Stop();
            FS_ConfLog(ref rtb_Log, "info", "Fourth Shift Client is closed now.");
            b_Connec2FS.Text = "Connect to FS";
            b_Connec2FS.Enabled = true;
            b_CloseConnection.Enabled = false;
            gb_FSCredentials.Enabled = true;
        }
        private void b_Connec2FS_Click(object sender, EventArgs e)
        {
            FSTI = new AmalgammaFSTI(tb_FSCFGFile.Text, tb_FSUser.Text, tb_FSPassword.Text);
            FS_ConfLog(ref rtb_Log, "info", "Fourth Shift Client configuration loaded.");

            if (FSTI.AmalgammaFSTI_Initialization())
            {
                FS_ConfLog(ref rtb_Log, "success", "Fourth Shift Client has been Initialized.");
                if (FSTI.AmalgammaFSTI_Logon())
                {
                    FS_ConfLog(ref rtb_Log, "success", "Fourth Shift Client loged on sucessfully.");
                    b_Connec2FS.Enabled = false;
                    b_CloseConnection.Enabled = true;
                    gb_FSCredentials.Enabled = false;
                    b_Connec2FS.Text = "Connected to FS.";
                }
                else
                {
                    FS_ConfLog(ref rtb_Log, "error", "Fourth Shift Client fail to login.");
                }
            }
            else
            {
                FS_ConfLog(ref rtb_Log, "error", "Fourth Shift Client has not been Initialized.\n"
                    +" >Error Mg: "+FSTI.FSTI_ErrorMsg);
            }
        }
        private void f_BalanceAdj_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FSTI != null)
            {
                FSTI.AmalgammaFSTI_Stop();
            }
        }
        private void cb_Lock_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_InvEvent.SelectedIndex > -1)
            {
                LoadEventInfo();
                cb_InvEvent.Enabled = !cb_Lock.Checked;
                b_LoadTags.Enabled = true;
                gb_TransactionInfo.Enabled = true;
            }
            else
            {
                cb_InvEvent.Enabled = true;
                cb_Lock.Checked = false;
                b_LoadTags.Enabled = false;
            }
            if (!cb_Lock.Checked)
            {
                b_LoadTags.Enabled = false;
                gb_TransactionInfo.Enabled = false;
            }
        }
        private void b_LoadTags_Click(object sender, EventArgs e)
        {
            if (tb_DocNo.Text == "" || tb_ReasonCode.Text == "" || tb_InvAccount.Text == "")
            {
                MessageBox.Show("The Transaction Info Fields can not be empty.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Tags=x.TicketTagCount(tb_DocNo.Text, tb_ReasonCode.Text, tb_InvAccount.Text);
                dgv_BalanceTags.DataSource = Tags;
                if (Tags.Rows.Count > 0)
                {
                    b_CreateFSTI.Enabled = true;
                }
            }
        }
        private void b_CreateFSTI_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Tags.Rows.Count; i++)
            {
                if (Tags.Rows[i]["ItemNumber"].ToString() != "" && Tags.Rows[i]["Void"].ToString() != "true")
                {
                    x.CreateFSTITransaction(Tags.Rows[i]);
                }
            }
            MessageBox.Show("FSTI Transaction creation finished.");
        }
        
    }
}
