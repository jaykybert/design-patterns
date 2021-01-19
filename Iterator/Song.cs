
namespace Patterns.Iterator
{
    class Song
    {
        public Song(string songName, string artist, int releaseYear)
        {
            Name = songName;
            Artist = artist;
            ReleaseYear = releaseYear;
        }

        public string Name { get; }
        public string Artist { get; }
        public int ReleaseYear { get; }
    }
}
