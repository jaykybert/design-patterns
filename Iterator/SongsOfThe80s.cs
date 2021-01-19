using System.Collections;
using System.Collections.Generic;

namespace Patterns.Iterator
{
    class SongsOfThe80s : IEnumerable<Song>
    {
        // Uses an Array to store songs.
        private Song[] bestSongs;
        private int arrayIdx = 0;

        public SongsOfThe80s()
        {
            bestSongs = new Song[3];

            AddSong("Roam", "B52s", 1989);
            AddSong("Cruel Summer", "Bananarama", 1984);
            AddSong("Head Over Heels", "Tears for Fears", 1985);
        }

        public void AddSong(string songName, string artistName, int releaseYear)
        {
            Song song = new Song(songName, artistName, releaseYear);
            bestSongs[arrayIdx++] = song;
        }

        public Song[] BestSongs()
        {
            return bestSongs;
        }

        public IEnumerator<Song> GetEnumerator()
        {
            return new SongsOfThe80sEnumerator(bestSongs);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new SongsOfThe80sEnumerator(bestSongs);
        }

        // Specify how to traverse structure.
        private class SongsOfThe80sEnumerator : IEnumerator<Song>
        {
            private Song[] _songs;
            private int idx = -1;

            public SongsOfThe80sEnumerator(Song[] songCollection)
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

                return idx < _songs.Length;
            }

            public void Reset()
            {
                idx = 0;
            }
        }
    }
}
