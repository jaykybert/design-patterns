using System;

namespace Patterns.Bridge
{
    // Concrete Implementor
    public class TVDevice : EntertainmentDevice
    {
        public TVDevice(int newDeviceState, int newMaxSetting)
        {
            deviceState = newDeviceState;
            maxSetting = newMaxSetting;
        }

        public override void ButtonFivePressed()
        {
            Console.WriteLine("Channel Down.");
        }

        public override void ButtonSixPressed()
        {
            Console.WriteLine("Channel Up.");
        }
    }
}
