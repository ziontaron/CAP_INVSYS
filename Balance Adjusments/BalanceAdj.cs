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
        DataTable FSTI_T = new DataTable();

        TOOLS.Dataloger LOGGER;

        enum LogType
        {
            error,
            success,
            info
        };

        public f_BalanceAdj(ref Inventory_System_API IE)
        {
            InitializeComponent();
            x = IE;
            cb_InvEvent.Items.AddRange(_LoadEvents().ToArray());
            l_EventStatus.Text = "";
        }

        #region private Functions
        private void LoadFSTITransactions()
        {
            FSTI_T = x.ReadAllFSTI_Transactions();
        }
        private void DataLogger(ref RichTextBox rtb_Log, LogType _logType, string LogMessage)
        {
            switch (_logType)
            {
                case LogType.error:
                    {
                        rtb_Log.SelectionColor = Color.Red;
                        rtb_Log.AppendText(LogMessage);
                        rtb_Log.AppendText("\n");
                        break;
                    }
                case LogType.success:
                    {
                        rtb_Log.SelectionColor = Color.DarkGreen;
                        rtb_Log.AppendText(LogMessage);
                        rtb_Log.AppendText("\n");
                        break;
                    }
                case LogType.info:
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
        private FSTI_Transactions DGV2Entity(DataRow r)
        {
            FSTI_Transactions _FSTI_Tran = new FSTI_Transactions();

            _FSTI_Tran.FSTI_Transaction_key = (int)r["FSTI_Transaction_key"];
            _FSTI_Tran.TagCountKey= (int)r["TagCountKey"];
            _FSTI_Tran.TransactionStringFields = r["TransactionStringFields"].ToString();
            return _FSTI_Tran;
        }
        private void Update_FSTI_Result(FSTI_Transactions FS_t, bool IsError)
        {
            if (!IsError)
            {
                FS_t.FSError = false;
                FS_t.FSResponse = FSTI.CDFResponse;
            }
            else
            {
                FS_t.FSError = true;
                FS_t.FSResponse = FSTI.Trans_Error_Msg;
            }

            FS_t.TransactionProcessedYN = true;
            FS_t.DateStampOut = DateTime.Now;
            x.Update_FSTI_Transaction(FS_t);
        }
        private void Process_INVAs()
        {
            FSTI_Transactions _FSTI_Tran;
            string fields = "";
            string user = "";
            int QTY_Transactions = 0;
            LOGGER = new TOOLS.Dataloger(x.ActiveEventName, "log", "");
            try
            {
                if (cb_TestTransactions.Checked && dgv_FSTI_T.Rows.Count>0)
                {
                    QTY_Transactions = 100;
                }
                else
                {
                    QTY_Transactions = dgv_FSTI_T.Rows.Count;
                }
                if (FSTI.AmalgammaFSTI_Initialization())
                {
                    if (FSTI.AmalgammaFSTI_Logon())
                    {
                        //for (int j = 0; j < dgv_FSTI_T.Rows.Count; j++)
                        for (int j = 0; j < QTY_Transactions; j++)
                        {
                            fields = dgv_FSTI_T.Rows[j].Cells[7].Value.ToString();
                            user = "Inv Sys";
                            if (!(bool)dgv_FSTI_T.Rows[j].Cells[8].Value)
                            {
                                if (FSTI.AmalgammaFSTI_INVA01(fields, user))
                                {
                                    DataLogger(ref rtb_FSTI_Log, LogType.success, "INVA01 - " + fields + " - Transaction was successfully processed.");
                                    _FSTI_Tran = DGV2Entity(FSTI_T.Rows[j]);
                                    Update_FSTI_Result(_FSTI_Tran, false);
                                    LOGGER.WriteLogLine(TOOLS.Dataloger.Category.Info, "Tag: " + dgv_FSTI_T.Rows[j].Cells["TicketCounter"].Value.ToString() + " - " + _FSTI_Tran.FSResponse);
                                }
                                else
                                {
                                    DataLogger(ref rtb_FSTI_Log, LogType.error, "Transaction Failed Tag - " +
                                        dgv_FSTI_T.Rows[j].Cells["TicketCounter"].Value.ToString() + " - " + FSTI.Trans_Error_Msg);
                                    DataLogger(ref rtb_FSTI_Log, LogType.error, "  -" + dgv_FSTI_T.Rows[j].Cells["TransactionStringFields"].Value.ToString());
                                    if (FSTI.DetailError.Count > 0)
                                    {
                                        DataLogger(ref rtb_FSTI_Log, LogType.error, ">Detail Error");
                                        for (int i = 0; i < FSTI.DetailError.Count; i++)
                                        {
                                            DataLogger(ref rtb_FSTI_Log, LogType.error, "  -" + FSTI.DetailError[i].ToString());
                                        }
                                    }
                                    _FSTI_Tran = DGV2Entity(FSTI_T.Rows[j]);
                                    Update_FSTI_Result(_FSTI_Tran, true);
                                    LOGGER.WriteLogLine(TOOLS.Dataloger.Category.Error, "Tag: " + dgv_FSTI_T.Rows[j].Cells["TicketCounter"].Value.ToString() + " - " + _FSTI_Tran.FSResponse);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DataLogger(ref rtb_FSTI_Log, LogType.error, ex.Message);
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
            DataLogger(ref rtb_Log, LogType.info, "Fourth Shift Client is closed now.");
            DataLogger(ref rtb_FSTI_Log, LogType.info, "Fourth Shift Client is closed now.");
            b_Connec2FS.Text = "Connect to FS";
            b_Connec2FS.Enabled = true;
            b_CloseConnection.Enabled = false;
            gb_FSCredentials.Enabled = true;
        }
        private void b_Connec2FS_Click(object sender, EventArgs e)
        {
            FSTI = new AmalgammaFSTI(tb_FSCFGFile.Text, tb_FSUser.Text, tb_FSPassword.Text);
            DataLogger(ref rtb_Log, LogType.info, "Fourth Shift Client configuration loaded.");
            DataLogger(ref rtb_FSTI_Log, LogType.info, "Fourth Shift Client configuration loaded.");

            if (FSTI.AmalgammaFSTI_Initialization())
            {
                DataLogger(ref rtb_Log, LogType.success, "Fourth Shift Client has been Initialized.");
                DataLogger(ref rtb_FSTI_Log, LogType.success, "Fourth Shift Client has been Initialized.");
                if (FSTI.AmalgammaFSTI_Logon())
                {
                    DataLogger(ref rtb_Log, LogType.success, "Fourth Shift Client loged on sucessfully.");
                    DataLogger(ref rtb_FSTI_Log, LogType.success, "Fourth Shift Client loged on sucessfully.");
                    b_Connec2FS.Enabled = false;
                    b_CloseConnection.Enabled = true;
                    gb_FSCredentials.Enabled = false;
                    b_Connec2FS.Text = "Connected to FS.";
                }
                else
                {
                    DataLogger(ref rtb_Log, LogType.error, "Fourth Shift Client fail to login.");
                    DataLogger(ref rtb_FSTI_Log, LogType.error, "Fourth Shift Client fail to login.");
                }
            }
            else
            {
                DataLogger(ref rtb_Log, LogType.error, "Fourth Shift Client has not been Initialized.\n"
                    + " >Error Mg: " + FSTI.FSTI_ErrorMsg);
                DataLogger(ref rtb_FSTI_Log, LogType.error, "Fourth Shift Client has not been Initialized.\n"
                    + " >Error Mg: " + FSTI.FSTI_ErrorMsg);
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
                gb_TransactionProcess.Enabled = true;
            }
            else
            {
                cb_InvEvent.Enabled = true;
                cb_Lock.Checked = false;
                b_LoadTags.Enabled = false;
                gb_TransactionProcess.Enabled = false;
            }
            if (!cb_Lock.Checked)
            {
                b_LoadTags.Enabled = false;
                gb_TransactionInfo.Enabled = false;
            }

        }
        private void b_LoadTags_Click(object sender, EventArgs e)
        {
            //|| tb_ReasonCode.Text == ""
            if (tb_DocNo.Text == ""  || tb_InvAccount.Text == "")
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
                if (Tags.Rows[i]["ItemNumber"].ToString() != "" 
                    && Tags.Rows[i]["Void"].ToString() != "true" 
                    && Tags.Rows[i]["ActionCode"].ToString() != "=")
                {
                    x.CreateFSTITransaction(Tags.Rows[i]);
                }
            }
            MessageBox.Show("FSTI Transaction creation finished.");
        }
        private void b_LoadTransactions_Click(object sender, EventArgs e)
        {
            dgv_FSTI_T.DataSource = null;
            LoadFSTITransactions();
            tb_FSTITransactionsQty.Text = FSTI_T.Rows.Count.ToString();
            DataLogger(ref rtb_FSTI_Log, LogType.info, tb_FSTITransactionsQty.Text + " Transacctions Loded");
            dgv_FSTI_T.DataSource = FSTI_T;
            b_UploadTransactions.Enabled = true;
        }
        private void b_UploadTransactions_Click(object sender, EventArgs e)
        {
            Process_INVAs();
        }
    }
}
