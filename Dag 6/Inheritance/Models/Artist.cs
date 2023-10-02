namespace Inheritance.Models
{
    internal class Artist
    {
        public string Name { get; set; }
        public string Genre { get; set; }

        public virtual string PlaySong() {
            return $"{Name} plays {Genre}";
        }
    }
}
