using System.Data.Entity;

namespace MVC_Model.Models
{
    public class AlbumsDB : DbContext
    {
        public DbSet<Album> Albums { get; set; }
    }
}