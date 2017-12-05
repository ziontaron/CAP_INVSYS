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
        

        private void b_CloseConnection_Click(object sender, EventArgs e)
        {
            FSTI.AmalgammaFSTI_Stop();
        }

        private void b_Connec2FS_Click(object sender, EventArgs e)
        {
            rtb_Log.AppendText("test");
            rtb_Log.AppendText("test");
            rtb_Log.AppendText("test");
            rtb_Log.AppendText("test");
            rtb_Log.AppendText("test");
            rtb_Log.AppendText("test");
            rtb_Log.AppendText("test");
            rtb_Log.AppendText("test");
        }
    }
}
