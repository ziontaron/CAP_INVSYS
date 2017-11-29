namespace CAP_Inventory_System
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TicketCount")]
    public partial class TicketCount
    {
        [Key]
        public int TagCountKey { get; set; }

        [StringLength(10)]
        public string CounterInitials { get; set; }

        public DateTime? CountedDate { get; set; }

        [Index]
        public int TicketKey { get; set; }

        [StringLength(50)]
        public string ItemNumber { get; set; }

        [StringLength(100)]
        public string ItemDescription { get; set; }

        [StringLength(10)]
        public string ItemRef { get; set; }

        [StringLength(10)]
        public string UM { get; set; }

        [StringLength(50)]
        public string LotNumber { get; set; }

        public float CountQty { get; set; }

        public float ReCountQty { get; set; }

        public float InventoryQty { get; set; }

        [StringLength(15)]
        public string SKT { get; set; }

        [StringLength(15)]
        public string BIN { get; set; }

        [StringLength(3)]
        public string IC { get; set; }

        public bool Verified { get; set; }

        public bool VoidTag { get; set; }
        
        public int ItemNumber_FSKey { get; set; }

        //[StringLength(10)]
        //public string CountStatus { get; set; }

        public bool BlankTag { get; set; }

        public virtual Ticket Ticket { get; set; }

        //public int? FSTI_Transaction_key { get; set; }
    }
}
