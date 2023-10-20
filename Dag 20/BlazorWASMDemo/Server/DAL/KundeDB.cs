using Microsoft.EntityFrameworkCore;
using BlazorWASMDemo.Shared.Models;

namespace BlazorWASMDemo.Server.DAL
{
    public class KundeDB : DbContext
    {
        public KundeDB(DbContextOptions<KundeDB> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
    }
}