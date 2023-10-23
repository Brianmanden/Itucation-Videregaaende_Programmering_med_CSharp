using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BushcraftBlog.Shared.Models
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }

        [ForeignKey("Document")]
        public int DocumentId { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }
    }
}
