namespace CAP_Inventory_System
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MOTagHeader")]
    public partial class MOTagHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MOTagHeader()
        {
            MOTagCounts = new HashSet<MOTagCount>();
        }

        [Key]
        public int MOTagHeaderKey { get; set; }

        public int TicketKey { get; set; }
        
        [StringLength(50)]
        public string Planner { get; set; }

        [StringLength(50)]
        public string MO { get; set; }

        [StringLength(10)]
        public string MO_Ln { get; set; }

        [StringLength(3)]
        public string MO_Status { get; set; }

        public int? Order_Qty { get; set; }

        public int? Recv_Qty { get; set; }

        [StringLength(3)]
        public string LineType { get; set; }

        public int? FG_Qty_in_WIP { get; set; }

        [StringLength(50)]
        public string Parent_Item_NO { get; set; }

        [StringLength(100)]
        public string Parent_Item_Desc { get; set; }

        [StringLength(5)]
        public string Parent_ItemRef1 { get; set; }

        [StringLength(10)]
        public string CounterInitials { get; set; }

        //[DefaultValue(typeof(DateTime),"06-03-1987")]
        public DateTime? CountedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOTagCount> MOTagCounts { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
