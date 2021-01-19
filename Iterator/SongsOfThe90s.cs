using System.Collections;
using System.Collections.Generic;

namespace Patterns.Iterator
{
    class SongsOfThe90s : IEnumerable<Song>
    {
        // Uses a Dictionary to store songs.
        private Dictionary<int, Song> bestSongs;
        private int hashKey = 1;

        public SongsOfThe90s()
        { 
            bestSongs = new Dictionary<int, Song>();

            AddSong("Losing My Religion", "REM", 1991);
            AddSong("Walk on the Ocean", "Toad the Wet Sprocket", 1991);
            AddSong("Creep", "Radiohead", 1993);     
        }

        public void AddSong(string songName, string artistName, int releaseYear)
        {
            Song song = new Song(songName, artistName, releaseYear);
            bestSongs.Add(hashKey++, song);
        }

        public Dictionary<int, Song> BestSongs()
        {
            return bestSongs;
        }

        public IEnumerator<Song> GetEnumerator()
        {
            return new SongsOfThe90sEnumerator(bestSongs);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new SongsOfThe90sEnumerator(bestSongs);
        }

        // Specify how to traverse structure.
        private class SongsOfThe90sEnumerator : IEnumerator<Song>
        {
            private Dictionary<int, Song> _songs;
            private int idx = 0;

            public SongsOfThe90sEnumerator(Dictionary<int, Song> songCollection)
            {
                _songs = songCollection;
            }

            public Song Current => _songs[idx];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                // ...
            }

            public bool MoveNext()
            {
                idx++;

                return idx <= _songs.Count;
            }

            public void Reset()
            {
                idx = 0;
            }
        }
    }
}
