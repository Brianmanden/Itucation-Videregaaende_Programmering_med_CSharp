using System.ComponentModel.DataAnnotations;

namespace BushcraftBlog.Shared.Models
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }
    }
}
