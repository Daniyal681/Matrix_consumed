using Matrix.Core.Domain.Entities;
using Matrix.Infastructure.Persistence.Seeding;
using Microsoft.EntityFrameworkCore;


namespace Matrix.Infastructure.Persistence
{
    public class MatrixContext : DbContext
    {
        public MatrixContext() { }
        public MatrixContext(DbContextOptions<MatrixContext> options)
        : base(options)
        { 

        }

        //public DbSet<tblOrganizations> Organizations { get; set; }
        public DbSet<tblAreas> Areas { get; set; }
        public DbSet<tblWareHouse> WareHouses { get; set; }
        public DbSet<tblWareHouseInHoldProducts> WareHouseInHoldProducts { get; set; }
        public DbSet<tblSuppliers> Suppliers { get; set; }
        public DbSet<tblModels> Models { get; set; }
        public DbSet<tblLocalPurchase> LocalPurchase { get; set; }
        public DbSet<tblLocalPurchaseDetails> LocalPurchaseDetails { get; set; }
        public DbSet<tblSalesInvoice> SalesInvoice { get; set; }
        public DbSet<tblBank> Banks { get; set; }
        public DbSet<tblCustomer> Customers { get; set; }
        public DbSet<tblUser> Users { get; set; }
        public DbSet<tblTradeWarranty> TradeWarranty { get; set; }
        public DbSet<tblMenuList> MenuList { get; set; }
        public DbSet<tblBrands> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-URSATJE;Database=Matrix;Trusted_Connection=True; TrustServerCertificate = True");
            }
        }

    }
}