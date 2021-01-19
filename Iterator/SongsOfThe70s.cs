using System.Collections;
using System.Collections.Generic;

namespace Patterns.Iterator
{
    class SongsOfThe70s : IEnumerable<Song>
    {
        // Uses a List to store songs.
        private List<Song> bestSongs;
        public SongsOfThe70s()
        {
            bestSongs = new List<Song>();

            AddSong("Imagine", "John Lennon", 1971);
            AddSong("American Pie", "Don McLean", 1971);
            AddSong("I Will Survive", "Gloria Gaynor", 1979);
        }

        public void AddSong(string songName, string artistName, int releaseYear)
        {
            Song song = new Song(songName, artistName, releaseYear);
            bestSongs.Add(song);
        }

        public List<Song> BestSongs() // Not a good approach. We shouldn't have to worry about the data type.
        {
            return bestSongs;
        }

        // Create Enumerator instance, pass the data structure.
        public IEnumerator GetEnumerator()
        {
            return new SongsOfThe70sEnumerator(bestSongs);
        }

        IEnumerator<Song> IEnumerable<Song>.GetEnumerator()
        {
            return new SongsOfThe70sEnumerator(bestSongs);
        }

        // Specify how to traverse structure.
        private class SongsOfThe70sEnumerator : IEnumerator<Song>
        {
            private List<Song> _songs;
            private int idx = -1;

            public SongsOfThe70sEnumerator(List<Song> songCollection)
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

                return idx < _songs.Count;
            }

            public void Reset()
            {
                idx = 0;
            }
        }
    }
}
