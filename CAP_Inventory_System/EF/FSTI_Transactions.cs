namespace CAP_Inventory_System
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FSTI_Transactions
    {
        [Key]
        public int FSTI_Transaction_key { get; set; }

        public int TagCountKey { get; set; }

        [Required]
        [StringLength(50)]
        public string TransactionType { get; set; }

        [Required]
        public string FS_PartNo { get; set; }

        [Required]
        public string TransactionStringFields { get; set; }

        public bool TransactionProcessedYN { get; set; }

        public string FSResponse { get; set; }

        public bool? FSError { get; set; }

        public DateTime DateStampIn { get; set; }

        public DateTime? DateStampOut { get; set; }
    }
}
