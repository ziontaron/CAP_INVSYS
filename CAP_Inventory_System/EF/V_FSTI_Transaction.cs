namespace CAP_Inventory_System
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_FSTI_Transaction
    {
        public string InventoryEventName { get; set; }
        
        public int TicketCounter { get; set; }

        [Key]
        public int FSTI_Transaction_key { get; set; }
        
        public string TransactionType { get; set; }
        
        public string TransactionStringFields { get; set; }
        
        public bool TransactionProcessedYN { get; set; }

        public string FSResponse { get; set; }

        public bool? FSError { get; set; }
        
        public DateTime DateStampIn { get; set; }

        public DateTime? DateStampOut { get; set; }
        
        public string FS_PartNo { get; set; }
        
        public int TagCountKey { get; set; }
    }
}
