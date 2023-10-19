using Microsoft.EntityFrameworkCore;

namespace AspNetCoreAPIDemo.Models
{
    public class BooksDb : DbContext
    {
        public BooksDb(DbContextOptions<BooksDb> options) : base(options){ }

        public DbSet<Book> Books { get; set; }

    }
}
