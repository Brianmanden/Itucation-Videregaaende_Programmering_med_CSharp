namespace Inheritance.Models
{
    internal class Band : Artist
    {
        public string BestSong { get; set; }

        public override string PlaySong()
        {
            return $"The best song of {Name} is clearly {BestSong} of the genre: {Genre}";
        }
    }
}
