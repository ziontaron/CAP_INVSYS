namespace CAP_Inventory_System
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ticket()
        {
            MOTagHeaders = new HashSet<MOTagHeader>();
            TicketCounts = new HashSet<TicketCount>();
        }

        [Key]
        public int TicketKey { get; set; }
        
        public int TicketCounter { get; set; }

        public int cat_TicketTypeKey { get; set; }

        public int InventoryEventKey { get; set; }

        public virtual cat_TicketType cat_TicketType { get; set; }

        public virtual InventoryEvent InventoryEvent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOTagHeader> MOTagHeaders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketCount> TicketCounts { get; set; }
    }
}
