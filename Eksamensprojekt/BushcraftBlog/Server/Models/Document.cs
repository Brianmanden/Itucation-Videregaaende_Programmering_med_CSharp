using System.ComponentModel.DataAnnotations;

namespace BushcraftBlog.Server.Models;

public class Document
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Heading { get; set; }

    public string Content { get; set; }
}