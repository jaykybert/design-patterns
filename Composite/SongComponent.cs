using System;

namespace Patterns.Composite
{
    public abstract class SongComponent
    {
        // Methods Used By SongGroup
        public virtual void Add(SongComponent newSongComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual void Remove(SongComponent songComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual SongComponent Get(int componentIdx)
        {
            throw new InvalidOperationException();
        }


        // Methods Used by Song
        public virtual string SongName()
        {
            throw new InvalidOperationException();
        }

        public virtual string ArtistName()
        {
            throw new InvalidOperationException();
        }

        public virtual int ReleaseYear()
        {
            throw new InvalidOperationException();
        }


        // Methods used by both SongGroup and Song
        public virtual string SongDescription()
        {
            throw new InvalidOperationException();
        }
    }
}
