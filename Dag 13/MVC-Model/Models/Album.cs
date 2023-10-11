using System.ComponentModel.DataAnnotations;

namespace MVC_Model.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }

        [CheckValidYear]
        public int ReleaseYear { get; set; }
    }
}