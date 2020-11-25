using System;
using System.Threading;
using Patterns.Command.Commands;

namespace Patterns.Command
{
    /* 
     *  The command pattern encapsulates a request as an object thereby letting you parameterise
     *  other objects with different requests, queue, or log requests, and support un-doable operations.
     *  
     *  It is a behavioural design pattern in which an object is used to represent and encapsulate all the information
     *  needed to call a method at a later time. This information includes the method name, the object that owns the method,
     *  and values for the method parameters.
     *
     *  Pros / Cons
     *      + Allows you to set aside a list of commands for later use.
     *      + A class is a great place to store procedures you want to be executed.
     *      + You can store multiple commands in a class to use over and over.
     *      + You can implement undo procedures for past commands.
     *      - You create many small classes that store lists of commands.
     *
     *          
     *  Resources
     *      * https://www.youtube.com/watch?v=9qA5kw8dcSU&list=LL&index=18
     *      * https://www.youtube.com/watch?v=7Pj5kAhVBlg
     */
    public static class Demo
    {
        public static void ShowDemo()
        {
            IElectronicDevice device = new Television();

            // Turn the TV on.
            TurnTVOnCommand onCommand = new TurnTVOnCommand(device);
            DeviceButton buttonPress = new DeviceButton(onCommand);
            buttonPress.Press();

            // Turn the TV off.
            TurnTVOffCommand offCommand = new TurnTVOffCommand(device);
            buttonPress = new DeviceButton(offCommand);
            buttonPress.Press();

            // Turn the volume up.
            TurnVolumeUp upCommand = new TurnVolumeUp(device);
            buttonPress = new DeviceButton(upCommand);
            for(int i=0; i < 3; i++)
            {
                buttonPress.Press();
                Thread.Sleep(500);
            }

            // Undoing works by doing the reverse operation - there is no list of previous actions to iterate through.
            Console.WriteLine("Undoing operations...");
            for(int i=0; i < 3; i++)
            {
                buttonPress.PressUndo(); // ButtonPress currently holds a TurnVolumeUp reference, so this will decrease the volume.
                Thread.Sleep(500);
            }
        }
    }
}
