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
using Balance_Adjusments;

namespace InventoryImplementation
{
    public partial class f_InventorySysFE : Form
    {
        f_Item_Master f_IM;
        Inventory_System_API x = new Inventory_System_API();
        f_InventoryLogin login = new f_InventoryLogin();
        public f_InventorySysFE()
        {
            InitializeComponent();
            login.ShowDialog();
            x.UserProfile = login.role;
            x.User_Name = login.username;
            this.Text = "Inventory System Front End Ver 3.0";
            switch (login.role)
            {
                case "SysAdmin":
                    {
                        foreach (Control b in this.Controls.OfType<GroupBox>())
                        {
                            b.Enabled = true;
                        }
                        break;
                    }
                case "EventAdmin":
                    {
                        gb_EventAdmin.Enabled = true;
                        gb_CountFunctions.Enabled = true;
                        break;
                    }
                case "StdUser":
                    {
                        gb_CountFunctions.Enabled = true;
                        break;
                    }
            }
        }

        #region Counter Function
        private void b_TagCapture_Click(object sender, EventArgs e)
        {
            f_CaptureTag F = new f_CaptureTag(ref x);
            F.Show();
        }
        private void b_MOTag_Click(object sender, EventArgs e)
        {
            f_MOTags F = new f_MOTags(ref x);
            F.Show();
        }
        #endregion

        #region Admin Function
        private void b_AdminForm_Click(object sender, EventArgs e)
        {
            f_InvEventAdmin F = new f_InvEventAdmin(ref x);
            F.Show();
        }
        private void b_UserAdmin_Click(object sender, EventArgs e)
        {
            f_UserAdministration F = new f_UserAdministration(ref x);
            F.Show();
        }
        private void b_BalanceAdj_Click(object sender, EventArgs e)
        {
            f_BalanceAdj F = new f_BalanceAdj(ref x);
            F.Show();
        }
        #endregion

        private void b_ItemMaster_Click(object sender, EventArgs e)
        {
            f_IM = new f_Item_Master(ref x);
            f_IM.Show();
            //MessageBox.Show("Selected Part: " + f_IM.PartNo);
        }
    }
}
