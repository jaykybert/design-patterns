using System;

namespace Patterns.Bridge
{
    // Refined Abstraction
    public class TVRemotePause : RemoteButton
    {
        public TVRemotePause(EntertainmentDevice newDevice) : base(newDevice) { }

        public override void ButtonNinePressed()
        {
            Console.WriteLine("TV was paused.");
        }
    }
}
