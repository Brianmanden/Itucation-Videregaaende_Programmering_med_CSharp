using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BushcraftBlog.Shared.Models
{
    public class Topic
    {
        [Key]
        public int TopicId { get; set; }

        [ForeignKey("Document")]
        public int DocumentId { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }
    }
}
