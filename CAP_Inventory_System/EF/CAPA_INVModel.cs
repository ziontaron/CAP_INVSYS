namespace CAP_Inventory_System
{
    using System;
    using System.Data.Entity;
    using System.Configuration;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Data_Base_MNG;
    using System.Data;

    public partial class CAPA_INVContext : DbContext
    {
        public SQL DB_MNG;
        public SQL DB_MNG_FS;
        //public CAPA_INVContext() : base("name=CAPA_INV")
        //public CAPA_INVContext() : base("name=CAPA_INVServer")
        public CAPA_INVContext() : base("name=CAPA_INVLocal")
        //public CAPA_INVContext() : base("name=CAPA_INVSandBox")
        {
            //string ConnStr = "";
            //ConnStr = ConfigurationManager.ConnectionStrings["CAPA_INV"].ConnectionString;
            string ConnStr = Database.Connection.ConnectionString;
            DB_MNG = new SQL(ConnStr);
            DB_MNG_FS = new SQL("FSSERV", "FSDBMR", "AmalAdmin", "Amalgamma16");
            //DB_MNG_FS = new SQL(@"sb-fsserv2\sbfsserv2", "FSDBMR", "AmalAdmin", "Amalgamma16");
        }
        public CAPA_INVContext(string conn) : base(conn)
        {
        }

        public virtual DbSet<cat_TicketType> cat_TicketType { get; set; }
        public virtual DbSet<cat_UserRole> cat_UserRole { get; set; }
        public virtual DbSet<InventoryEvent> InventoryEvents { get; set; }
        public virtual DbSet<MOTagCount> MOTagCounts { get; set; }
        public virtual DbSet<MOTagHeader> MOTagHeaders { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<TicketCount> TicketCounts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<FS_ItemMaster> FS_ItemMaster { get; set; }
        public virtual DbSet<FSTI_Transactions> FSTI_Transactions { get; set; }
        public virtual DbSet<FS_LocationMaster> FS_LocationMaster { get; set; }
        #region Views
        public virtual DbSet<V_FSTI_Transaction> V_FSTI_Transaction { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cat_TicketType>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.cat_TicketType)
                .HasForeignKey(e => e.cat_TicketTypeKey);

            modelBuilder.Entity<MOTagCount>()
                .Property(e => e.UM)
                .IsFixedLength();

            modelBuilder.Entity<Ticket>()
                .HasMany(e => e.MOTagHeaders)
                .WithRequired(e => e.Ticket)
                .WillCascadeOnDelete(true);                       

        }
        
    }
}
