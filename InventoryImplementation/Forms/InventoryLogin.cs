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
    public partial class f_InventoryLogin : Form
    {
        Inventory_System_API x = new Inventory_System_API();
        public string role { get; set; }
        public string username { get; set; }
        public f_InventoryLogin()
        {
            InitializeComponent();
        }

        private void b_TagCapture_Click(object sender, EventArgs e)
        {
            f_CaptureTag F = new f_CaptureTag(ref x);
            F.Show();
        }
        private void b_AdminForm_Click(object sender, EventArgs e)
        {
            f_InvEventAdmin F = new f_InvEventAdmin(ref x);
            F.Show();
        }
        private void b_MOTag_Click(object sender, EventArgs e)
        {
            f_MOTags F = new f_MOTags(ref x);
            F.Show();
        }

        private void b_Access_Click(object sender, EventArgs e)
        {
            if (tb_UserName.Text != "" && tb_UserPassword.Text!="")
            {
                role = x.ReadUser(tb_UserName.Text, tb_UserPassword.Text);
                if (role != "")
                {
                    this.Close();
                }
            }
        }

        private void tb_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                tb_UserPassword.Focus();
            }
        }

        private void tb_UserPAssword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (tb_UserName.Text != "" && tb_UserPassword.Text != "")
                {
                    role = x.ReadUser(tb_UserName.Text, tb_UserPassword.Text);
                    if (role != "")
                    {
                        this.Close();
                    }
                }
                else
                {
                    b_Access.Focus();
                }
            }
        }

        private void f_InventoryLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            username = tb_UserName.Text;
        }
    }
}
