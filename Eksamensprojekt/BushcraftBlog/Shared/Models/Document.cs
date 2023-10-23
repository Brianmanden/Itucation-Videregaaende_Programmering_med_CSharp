using System.ComponentModel.DataAnnotations;

namespace BushcraftBlog.Shared.Models;

public class Document
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public List<Topic>? Topics { get; set; }

    public List<Tag>? Tags { get; set; }

    public string Heading { get; set; }

    public string Content { get; set; }
}