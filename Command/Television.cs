using System;

namespace Patterns.Command
{
    // Receiver
    public class Television : IElectronicDevice
    {
        private int volume = 0;


        public void Off()
        {
            Console.WriteLine("TV turned off.");
        }

        public void On()
        {
            Console.WriteLine("TV turned on.");
        }

        public void VolumeDown()
        {
            Console.WriteLine($"Volumne lowered to {--volume}");
        }

        public void VolumeUp()
        {
            Console.WriteLine($"Volumne increased to {++volume}");
        }
    }
}
