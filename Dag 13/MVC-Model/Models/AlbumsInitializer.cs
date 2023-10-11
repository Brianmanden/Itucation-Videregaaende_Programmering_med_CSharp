using System.Collections.Generic;
using System.Data.Entity;

namespace MVC_Model.Models
{
    public class AlbumsInitializer : CreateDatabaseIfNotExists<AlbumsDB>
    {
        protected override void Seed(AlbumsDB db)
        {
            base.Seed(db);
            var albumsList = new List<Album>
            {
                new Album{ Artist = "Deep Purple", Title = "Made in Japan", ReleaseYear = 1972,},
                new Album{ Artist = "Pink Floyd", Title = "The Great Gig in the Sky", ReleaseYear = 1973,},
                new Album{ Artist = "Metallica", Title = "Garage Days Re-Revisited", ReleaseYear = 1987,},
                new Album{ Artist = "Heilung", Title = "Lifa", ReleaseYear = 2017, },
                new Album{ Artist = "Black Sabbath", Title = "Black Sabbath", ReleaseYear = 1970, },
                new Album{ Artist = "Motörhead", Title = "Ace of Spades", ReleaseYear = 1980, },
            };

            albumsList.ForEach(album => db.Albums.Add(album));
            db.SaveChanges();
        }
    }
}