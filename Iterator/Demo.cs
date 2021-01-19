using System;
using System.Collections.Generic;

namespace Patterns.Iterator
{
    /* 
     *  The iterator pattern provides you with a uniform way to access different collections of objects.
     *  It provides a way to access the elements of an aggregate object sequentially,
     *  without exposing its underlying representation (we want to ignore the data structure).
     *
     *
     *  When to use:
     *      * When your collection has a complex data structure undere the hood, and you want to hide
     *        its complexity from clients (either for convenience or security reasons).
     *
     *
     *  Pros / Cons
     *      + Separates the traversal algorithms into their own classes (Single Responsibility).
     *      + Implement new collections and iterators without breaking anything (Open/Closed).
     *      + Each iterator object contains its own iteration state, allowing for parallel iteration.
     *      - Can be overkill with simple collections.
     *      - May be less efficient than going through elements of a specialised collection directly.
     *
     * 
     *  Resources
     *      * https://www.youtube.com/watch?v=uNTNEfwYXhI
     *      * https://www.youtube.com/watch?v=VKIzUuMdmag
     *      * https://www.youtube.com/watch?v=UfT-st9dl8Q
     *      * https://refactoring.guru/design-patterns/iterator
     */
    public static class Demo
    {

        public static void ShowDemo()
        {
            // The Wrong Approach

            // List
            List<Song> bestSongs70s = new SongsOfThe70s().BestSongs();
            Console.WriteLine("The Seventies");

            for (int i = 0; i < bestSongs70s.Count; i++)
            {
                Song song = bestSongs70s[i];
                Console.WriteLine($"\t{song.Name} - {song.Artist} ({song.ReleaseYear})");
            }

            // Array
            Song[] bestSongs80s = new SongsOfThe80s().BestSongs();
            Console.WriteLine("The Eighties");

            foreach (Song song in bestSongs80s)
            {
                Console.WriteLine($"\t{song.Name} - {song.Artist} ({song.ReleaseYear})");
            }

            // Dictionary
            Dictionary<int, Song> bestSongs90s = new SongsOfThe90s().BestSongs();
            Console.WriteLine("The Nineties");

            foreach (KeyValuePair<int, Song> song in bestSongs90s)
            {
                Console.WriteLine($"\t{song.Value.Name} - {song.Value.Artist} ({song.Value.ReleaseYear})");
            }

            
            Console.WriteLine("\n----------\n");


            // Iterator Approach
            SongsOfThe70s seventies = new SongsOfThe70s(); // Data stored as List<Song>.

            Console.WriteLine("The Seventies");
            foreach(Song song in seventies)
            {
                Console.WriteLine($"\t{song.Name} - {song.Artist} ({song.ReleaseYear})");
            }

            SongsOfThe80s eighties = new SongsOfThe80s(); // Data stored as Song[].
            Console.WriteLine("The Eighties");
            foreach(Song song in eighties)
            {
                Console.WriteLine($"\t{song.Name} - {song.Artist} ({song.ReleaseYear})");
            }

            SongsOfThe90s nineties = new SongsOfThe90s(); // Data stored as Dictionary<int, Song>.
            Console.WriteLine("The Nineties");
            foreach(Song song in nineties)
            {
                Console.WriteLine($"\t{song.Name} - {song.Artist} ({song.ReleaseYear})");
            }

        }
    }
}
