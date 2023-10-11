using System.ComponentModel.DataAnnotations;

namespace MVC_Model.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public string Artist { get; set; }

        [CheckValidYear]
        public int ReleaseYear { get; set; }
    }
}