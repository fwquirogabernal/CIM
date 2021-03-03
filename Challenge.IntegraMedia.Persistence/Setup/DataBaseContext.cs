using Challenge.IntegraMedia.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Challenge.IntegraMedia.Persistence.Setup
{
    public class DataBaseContext : DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<CreditCard> CreaditCards { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Provider> Providers { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<SaleLine> SaleLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(e => e.HasIndex(e => e.Identification).IsUnique());
            modelBuilder.Entity<Employee>(e => e.HasIndex(e => e.FirstName));
            modelBuilder.Entity<Employee>(e => e.HasIndex(e => e.LastName));

            modelBuilder.Entity<Customer>(c => c.HasIndex(e => e.FirstName));
            modelBuilder.Entity<Customer>(c => c.HasIndex(e => e.LastName));
        }
    }
}
