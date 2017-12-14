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
    public partial class f_Item_Master : Form
    {
        string _PartNo = "";
        Inventory_System_API x;
        List<FS_Item> L = new List<FS_Item>();

        DataTable T = new DataTable();

       

        public string PartNo
        {
            get
            {
                return _PartNo;
            }
        }

        #region Private Function
        private void SetUp_IM_Table()
        {
            T = new DataTable();
            #region Table Setup
            T.Columns.Add("ItemNo", typeof(string));
            T.Columns.Add("ItemDesc", typeof(string));
            T.Columns.Add("ItemUM", typeof(string));
            T.Columns.Add("ItemRevision", typeof(string));
            T.Columns.Add("ItemReference1", typeof(string));
            T.Columns.Add("Cost", typeof(float));
            T.Columns.Add("ItemNumber_FSKey", typeof(int));
            #endregion            
        }
        private void List2Table(List<FS_Item> L)
        {
            T.Rows.Clear();
            foreach (FS_Item l in L)
            {
                T.Rows.Add(
                     l.ItemNo
                    , l.ItemDesc
                    , l.ItemUM
                    , l.ItemRevision
                    , l.ItemReference1
                    , l.Cost
                    , l.ItemNumber_FSKey
                    );
            }
        }
        private void Load_ItemMaster()
        {
            L = x.LoadItemMaster();
        }
        #endregion

        public f_Item_Master(ref Inventory_System_API IE)
        {
            InitializeComponent();
            x = IE;
            SetUp_IM_Table();
            Load_ItemMaster();
            List2Table(L);
            dgv_ItemMaster.DataSource = T;
        }
        public f_Item_Master(ref Inventory_System_API IE,ref string Partno)
        {
            InitializeComponent();
            x = IE;
            SetUp_IM_Table();
            _PartNo = Partno;
            Load_ItemMaster();
            List<FS_Item> L_filtered = L.Where(l => l.ItemNo.Contains(_PartNo)).ToList();
            List2Table(L_filtered);
            dgv_ItemMaster.DataSource = T;
        }
        private void dgv_ItemMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
            }
        }
        private void tb_PartNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (tb_PartNo.Text != "")
                {
                    _PartNo = tb_PartNo.Text;
                    Load_ItemMaster();
                    List<FS_Item> L_filtered = L.Where(l => l.ItemNo.Contains(_PartNo)).ToList();
                    List2Table(L_filtered);
                    dgv_ItemMaster.DataSource = T;
                }
                else
                {
                    //Load_ItemMaster();
                    List2Table(L);
                    dgv_ItemMaster.DataSource = T;
                }
            }
        }

        private void dgv_ItemMaster_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgv_ItemMaster.SelectedRows.Count > 0)
            {
                _PartNo = T.Rows[dgv_ItemMaster.SelectedRows[0].Index]["ItemNo"].ToString();
            }
        }
    }
}
