namespace CAP_Inventory_System
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("FS_ItemMaster")]
    public partial class FS_ItemMaster
    {
        [Key]
        public int FS_ItemMaster_Key { get; set; }

        [StringLength(50)]
        public string ItemNumber { get; set; }

        [StringLength(100)]
        public string ItemDescription { get; set; }

        [StringLength(10)]
        public string ItemUM { get; set; }

        [StringLength(10)]
        public string ItemRevision { get; set; }

        [StringLength(10)]
        public string MakeBuyCode { get; set; }

        [StringLength(10)]
        public string ItemReference1 { get; set; }

        [StringLength(10)]
        public string CostType { get; set; }

        public float TotalRolledCost { get; set; }

        [Index (IsUnique = true)]
        public int ItemNumber_FSKey { get; set; }
    }
}
