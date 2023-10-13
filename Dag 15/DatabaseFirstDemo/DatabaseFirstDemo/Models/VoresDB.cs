using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DatabaseFirstDemo.Models
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
