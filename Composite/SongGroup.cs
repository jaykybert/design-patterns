using System.Collections.Generic;

namespace Patterns.Composite
{
    public class SongGroup : SongComponent
    {
        // Holds SongComponents - can be Song or SongGroup objects - allows for hierarchies.
        private readonly List<SongComponent> songComponents = new List<SongComponent>();

        private readonly string _songGroupName;
        private readonly string _songGroupDesc;

        public SongGroup(string groupName, string groupDesc)
        {
            _songGroupName = groupName;
            _songGroupDesc = groupDesc;
        }

        public string SongGroupName() => _songGroupName;
        public string SongGroupDesc() => _songGroupDesc;

        public override void Add(SongComponent newSongComponent) // Can be Song or SongGroup.
        {
            songComponents.Add(newSongComponent);
        }

        public override void Remove(SongComponent songComponent)
        {
            songComponents.Remove(songComponent);
        }

        public override SongComponent Get(int componentIndex) => songComponents[componentIndex];

        public override string SongDescription()
        {
            string groupDesc = $"{SongGroupName()}: {SongGroupDesc()}\n";

            foreach(SongComponent component in songComponents)
            {
                groupDesc += component.SongDescription();
            }
            return groupDesc;
        }
    }
}
