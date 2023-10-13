using System.Data.Entity;

namespace Exercise2_MVC_DatabaseFirst.Models
{
    public partial class VoresDB : DbContext
    {
        public VoresDB()
            : base("name=VoresDB")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.cEmail)
                .IsUnicode(false);
        }
    }
}
