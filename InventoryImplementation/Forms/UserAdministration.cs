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
    public partial class f_UserAdministration : Form
    {
        Inventory_System_API x = new Inventory_System_API();
        Tools _tools = new Tools();
        public f_UserAdministration(ref Inventory_System_API IE)
        {
            List<string> UserRoles = x.ReadAllRoles();
            InitializeComponent();
            x = IE;
            dgv_UsersList.DataSource = x.ReadAllUsers();
            cb_UserRole.Items.AddRange(UserRoles.ToArray());

            pb_OK.Visible = false;
            pb_NO.Visible = false;
        }

        private void b_SaveUser_Click(object sender, EventArgs e)
        {
            if ((tp_NewUser.Text != "" && tb_Password.Text != ""))
            {
                if (tb_PassConfirm.Text == tb_Password.Text)
                {
                    x.CreateUser(tb_UserName.Text, tb_Password.Text, cb_UserRole.Items[cb_UserRole.SelectedIndex].ToString());
                    dgv_UsersList.DataSource = x.ReadAllUsers();
                    tb_UserName.Text = "";
                    tb_Password.Text = "";
                    tb_PassConfirm.Text = "";
                    cb_UserRole.Text = "";
                }
                else
                {
                    MessageBox.Show("The password does not meet.");
                }
            }
            else
            {
                MessageBox.Show("User Name or Password canot be empty.");
            }
        }

        private void dgv_UsersList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {                
                case 116:
                    {
                        dgv_UsersList.DataSource = x.ReadAllUsers();
                        break;
                    }
                case 123:
                    {
                        if (dgv_UsersList.SelectedRows[0].Cells[2].Value.ToString() != "SysAdmin")
                        {
                            DialogResult result = MessageBox.Show( "Do you want DELETE this User: " + dgv_UsersList.SelectedRows[0].Cells[1].Value.ToString(), "User Delete", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                x.DeleteUser(dgv_UsersList.SelectedRows[0].Cells[1].Value.ToString());
                                dgv_UsersList.DataSource = x.ReadAllUsers();
                            }
                        }
                        else
                        {
                            MessageBox.Show("A System Administrator can not be Deleted");
                        }
                        break;
                    }
            }
        }

        private void tb_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (!x.UserExist(tb_UserName.Text))
                {
                    tb_Password.Focus();
                }
                else
                {
                    MessageBox.Show("The User Name: " + tb_UserName.Text + " already Exist.");
                }
            }
        }
        private void tb_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                tb_PassConfirm.Focus();
            }
        }
        private void tb_PassConfirm_TextChanged(object sender, EventArgs e)
        {
            if (tb_Password.Text != "" || tb_PassConfirm.Text != "")
            {
                if (tb_Password.Text == tb_PassConfirm.Text && tb_Password.Text != "")
                {
                    pb_OK.Visible = true;
                    pb_NO.Visible = false;
                }
                else
                {
                    pb_OK.Visible = false;
                    pb_NO.Visible = true;
                }
            }
            else
            {
                pb_OK.Visible = false;
                pb_NO.Visible = false;
            }
        }
    }
}
