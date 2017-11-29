namespace CAP_Inventory_System
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MOTagCount")]
    public partial class MOTagCount
    {
        [Key]
        public int MOTagCountKey { get; set; }

        public int MOTagHeaderKey { get; set; }

        public int SeqNum { get; set; }

        [Required]
        [StringLength(50)]
        public string Component_No { get; set; }

        [Required]
        [StringLength(150)]
        public string Component_Desc { get; set; }

        [Required]
        [StringLength(10)]
        public string UM { get; set; }

        public float Qty_Per { get; set; }

        public float Issued_Qty { get; set; }

        public float LooseCountQty { get; set; }

        public float LooseReCountQty { get; set; }

        public virtual MOTagHeader MOTagHeader { get; set; }
    }
}
