using System;

namespace Patterns.Bridge
{
    /* 
     *  The intent of the bridge pattern is to decouple an abstraction
     *  from its implementation so that the two can vary independently.
     *  
     *  Progressively adding functionality while separating out major
     *  differences using abstract classes.
     *  
     *  
     *  When to use:
     *      * When you want to be able to change both the abstractions and concrete classes independently.
     *      * When you want the first abstract class to define rules.
     *      
     *      
     *  Pros / Cons
     *      + Enables separation of implementation from interface.
     *      + Improves extensibility.
     *      - Increased complexity.
     *      - Multiple indirection (multiple method calls).
     *
     *
     *  Resources
     *      * https://www.youtube.com/watch?v=F1YQ7YRjttI
     *      * https://www.youtube.com/watch?v=9jIgSsIfh_8
     */
    public static class Demo
    {
        public static void ShowDemo()
        {
            RemoteButton TV = new TVRemoteMute(new TVDevice(1, 2000));
            Console.WriteLine("Testing the TV with the Mute Remote:");
            TV.ButtonFivePressed();
            TV.ButtonSixPressed();
            TV.ButtonNinePressed();

            RemoteButton otherTV = new TVRemotePause(new TVDevice(2, 1000));
            Console.WriteLine("Testing the TV with the Pause Remote:");
            otherTV.ButtonFivePressed();
            otherTV.ButtonSixPressed();
            otherTV.ButtonNinePressed();
        }
    }
}
