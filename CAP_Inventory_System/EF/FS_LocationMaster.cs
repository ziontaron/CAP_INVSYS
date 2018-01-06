using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP_Inventory_System
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("FS_LocationMaster")]
    public partial class FS_LocationMaster
    {
        [Key]
        public int FS_LocationMaster_Key { get; set; }

        public string STK { get; set; }
        public string BIN { get; set; }
    }
}
