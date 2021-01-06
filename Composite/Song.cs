
namespace Patterns.Composite
{
    public class Song : SongComponent
    {
        private readonly string _songName;
        private readonly string _artistName;
        private readonly int _releaseYear;

        public Song(string name, string artist, int releaseYear)
        {
            _songName = name;
            _artistName = artist;
            _releaseYear = releaseYear;
        }

        public override string SongName() => _songName;
        public override string ArtistName() => _artistName;
        public override int ReleaseYear() => _releaseYear;

        public override string SongDescription() => $"\t{SongName()} - {ArtistName()} ({ReleaseYear()})\n";
    }
}
