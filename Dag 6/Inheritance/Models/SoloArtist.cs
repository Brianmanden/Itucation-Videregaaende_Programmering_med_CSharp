namespace Inheritance.Models
{
    internal class SoloArtist : Band
    {
        public override string PlaySong()
        {
            return $"Best song of {Name} is: {BestSong}. {Name} had a great solo career playing {Genre}. ";
        }
    }
}
