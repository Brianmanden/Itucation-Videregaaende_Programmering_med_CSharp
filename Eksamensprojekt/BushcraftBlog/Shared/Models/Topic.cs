using System.ComponentModel.DataAnnotations;

namespace BushcraftBlog.Shared.Models
{
    public class Topic
    {
        [Key]
        public int TopicId { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        public virtual ICollection<Document>? Documents { get; set; }
    }
}
