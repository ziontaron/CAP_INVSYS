using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FS4Amalgamma;

namespace Balance_Adjusments
{
    public partial class f_BalanceAdj : Form
    {
        AmalgammaFSTI FSTI;
        public f_BalanceAdj()
        {
            InitializeComponent();
        }

        private void b_CFGBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog CFGDialog = new OpenFileDialog();
            DialogResult result = CFGDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                tb_FSCFGFile.Text = CFGDialog.FileName;
            }
        }

        private void FS_ConfLog(string LogType, string LogMessage)
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

        private void b_CloseConnection_Click(object sender, EventArgs e)
        {
            FSTI.AmalgammaFSTI_Stop();
            FS_ConfLog("info", "Fourth Shift Client is closed now.");
        }

        private void b_Connec2FS_Click(object sender, EventArgs e)
        {
            FSTI = new AmalgammaFSTI(tb_FSCFGFile.Text, tb_FSUser.Text, tb_FSPassword.Text);
            FS_ConfLog("info", "Fourth Shift Client configuration loaded.");

            if (FSTI.AmalgammaFSTI_Initialization())
            {
                FS_ConfLog("success", "Fourth Shift Client has been Initialized.");
                if (FSTI.AmalgammaFSTI_Logon())
                {
                    FS_ConfLog("success", "Fourth Shift Client loged on sucessfully.");
                }
                else
                {
                    FS_ConfLog("error", "Fourth Shift Client fail to login.");
                }
            }
            else
            {
                FS_ConfLog("error", "Fourth Shift Client has not been Initialized.\n"
                    +FSTI.FSTI_ErrorMsg);
            }
        }
    }
}
