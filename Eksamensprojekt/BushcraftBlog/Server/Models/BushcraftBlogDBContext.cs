using Microsoft.EntityFrameworkCore;
using BushcraftBlog.Shared.Models;

namespace BushcraftBlog.Server.Models
{
    public class BushcraftBlogDBContext : DbContext
    {
        public BushcraftBlogDBContext(DbContextOptions<BushcraftBlogDBContext> options) : base(options){}

        public DbSet<Document> Documents { get; set; }
        
        public DbSet<Topic>? Topic { get; set; }

        public DbSet<Tag>? Tag { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            #region Declaring Dummy Data
            Topic[] topics = new Topic[] {
                new Topic { Name = "Cutting Tools",     Description = "Cutting Tools as a topic in general." },
                new Topic { Name = "Shelters",          Description = "Shelters as a topic." },
                new Topic { Name = "Core Temperature",  Description = "Core Temperature as a topic." },
                new Topic { Name = "Saws",              Description = "Saws as a topic." },
                new Topic { Name = "Axes",              Description = "Axes as a topic." },
            };

            Tag[] tags = new Tag[] {
                new Tag { Name = "5CS",                  Description = "The 5 Cs of Survivability."},
                new Tag { Name = "10CS",                 Description = "The 10 Cs of Survivability."},
                new Tag { Name = "Cutting Tool",         Description = "Cutting Tool for processing material in nature."},
                new Tag { Name = "Combustion Device",    Description = "Combustion Device to start a fire to keep you warm and prepare food."},
                new Tag { Name = "Container",            Description = "Container for cooking food and carrying ressources ie. water."},
                new Tag { Name = "Cordage",              Description = "Cordage for helping in building a shelter."},
                new Tag { Name = "Cover",                Description = "Shelter for protecting you against the elements of nature."},
                new Tag { Name = "Core Temperature",     Description = "Core Temperature is important to keep an eye on."},
            };
            #endregion

            #region Adding Dummy Data
            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicId = 1, Name = topics[0].Name, Description = topics[0].Description },
                new Topic { TopicId = 2, Name = topics[1].Name, Description = topics[1].Description },
                new Topic { TopicId = 3, Name = topics[2].Name, Description = topics[2].Description },
                new Topic { TopicId = 4, Name = topics[3].Name, Description = topics[3].Description },
                new Topic { TopicId = 5, Name = topics[4].Name, Description = topics[4].Description }
            );

            modelBuilder.Entity<Tag>().HasData(
                new Tag { TagId = 1, Name = tags[0].Name, Description = tags[0].Description },
                new Tag { TagId = 2, Name = tags[1].Name, Description = tags[1].Description },
                new Tag { TagId = 3, Name = tags[2].Name, Description = tags[2].Description },
                new Tag { TagId = 4, Name = tags[3].Name, Description = tags[3].Description },
                new Tag { TagId = 5, Name = tags[4].Name, Description = tags[4].Description },
                new Tag { TagId = 6, Name = tags[5].Name, Description = tags[5].Description },
                new Tag { TagId = 7, Name = tags[6].Name, Description = tags[6].Description },
                new Tag { TagId = 8, Name = tags[7].Name, Description = tags[7].Description }
            );

            modelBuilder.Entity<Document>()
                .HasData(
                    new Document {
                        DocumentId = 1,
                        Name = "First Document on Cutting Tools",
                        Heading = "Cutting Tools - be sure to carry one",
                        DocumentImage = "KnifeAxeBowsaw.jpg",
                        Content = "Carry at least one Cutting Tool. Preferably more than one!",
                        TopicStrings = string.Join(',', new string[] { topics[0].Name, topics[3].Name, topics[4].Name }),
                        TagStrings = string.Join(',', new string[] { tags[2].Name }),
                        ExternalSourcesStrings = string.Join(',', new string[] { "https://www.youtube.com/watch?v=5UeIgzd8oto", "https://www.youtube.com/watch?v=uK7l2JsI61c", "https://www.youtube.com/watch?v=eoRODhOMcUk" })
                    },
                    new Document {
                        DocumentId = 2,
                        Name = "First Document on Shelters",
                        Heading = "Shelters - shield yourself against the elements",
                        DocumentImage = "BushcraftShelter.jpg",
                        Content = "A Shelter gives you a place to rest shielded against the elements of nature.",
                        TopicStrings = string.Join(',', new string[] { topics[1].Name, topics[2].Name }),
                        TagStrings = string.Join(',', new string[] { tags[3].Name, tags[6].Name, tags[7].Name }),
                        ExternalSourcesStrings = string.Join(',', new string[] { "https://www.youtube.com/watch?v=-_ve7ExM29Y", "https://www.youtube.com/watch?v=ZV92xni5q8w", "https://www.youtube.com/watch?v=MITdT_we1WE" })
                    },
                    new Document {
                        DocumentId = 3,
                        Name = "First Document on Core Temperature",
                        Heading = "Core Temperature - keep it within comfortable limits",
                        DocumentImage = "bonfire.jpg",
                        Content = "It´s important to keep an eye on Core Temperature when out in nature. If you get too cold in the winter season you risk getting pneumonia and if you get too hot in the summer time you risk getting dehydrated.",
                        TopicStrings = string.Join(',', new string[] { topics[1].Name, topics[2].Name }),
                        TagStrings = string.Join(',', new string[] { tags[6].Name, tags[7].Name }),
                        ExternalSourcesStrings = string.Join (',', new string[] { "https://www.youtube.com/watch?v=7KojHvHCrjE", "https://www.youtube.com/watch?v=ysw6CEbSiak", "https://www.youtube.com/watch?v=B_vqXkCe-r4" })
                    }
                );
            #endregion
        }
    }
}