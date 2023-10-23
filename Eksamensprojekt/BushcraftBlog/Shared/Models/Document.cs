using System.ComponentModel.DataAnnotations;

namespace BushcraftBlog.Shared.Models;

public class Document
{
    [Key]
    public int DocumentId { get; set; }

    [Required]
    public string Name { get; set; }

    public string? Heading { get; set; }

    public string? Content { get; set; }

    public string? TopicStrings {  get; set; } 

    //public virtual ICollection<Topic>? Topics { get; set; }

    //public virtual ICollection<Tag>? Tags { get; set; }
}