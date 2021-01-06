using System;

namespace Patterns.Composite
{
    /* 
     * The composite pattern composes objects into tree structures to represent part-whole hierarchies.
     *
     *
     *  When to use:
     *      * You want to represent part-whole hierarchies of objects.
     *      * Want to ignore the difference between compositions of objects and individual objects.
     *      
     *
     *  Pros / Cons
     *      + Easier to work with complex tree structures.
     *      + Open/Closed Principle - can introduce new elements without breaking existing code.
     *      - Might be difficult to provide a common interface for classes whose functionality differs too much,
     * 
     * 
     *  Resources
     *      * https://www.youtube.com/watch?v=EWDmWbJ4wRA&list=LL
     *      * https://www.youtube.com/watch?v=2HUnoKyC9l0
     *      * https://refactoring.guru/design-patterns/composite
     */
    public static class Demo
    {
        public static void ShowDemo()
        {
            // Composites
            SongComponent playlist = new SongGroup("My Playlist", "Buncha stuff");
            SongComponent popMusic = new SongGroup("Pop", "Other noises");
            SongComponent rockMusic = new SongGroup("Rock", "Loud noises");
            SongComponent altRockMusic = new SongGroup("Alt Rock", "Alt noises");

            playlist.Add(popMusic);
            popMusic.Add(new Song("Pop Song 1", "Band Name", 2018));
            popMusic.Add(new Song("Pop Song 2", "Other Band", 2019));

            playlist.Add(rockMusic);
            rockMusic.Add(new Song("Rock Song 1", "Rock Band", 1969));
            rockMusic.Add(new Song("Rock Song 2", "Other Rock Band", 1970));
            // Also add a SongGroup.
            rockMusic.Add(altRockMusic);
            altRockMusic.Add(new Song("Alt Rock Song 1", "Alt Rock Band", 1997));
            altRockMusic.Add(new Song("Alt Rock Song 2", "Alt Other Rock Band", 1999));

            Console.WriteLine(playlist.SongDescription());
        }
    }
}
