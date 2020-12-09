using System;

namespace Patterns.Bridge
{
    // Refined Abstraction
    public class TVRemoteMute : RemoteButton
    {
        public TVRemoteMute(EntertainmentDevice newDevice) : base(newDevice) { }

        public override void ButtonNinePressed()
        {
            Console.WriteLine("TV was muted.");
        }
    }
}
