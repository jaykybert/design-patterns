
namespace Patterns.Bridge
{
    // Implementor
    public abstract class EntertainmentDevice
    {
        public int deviceState;
        public int maxSetting;
        public int volumeLevel;

        public abstract void ButtonFivePressed();
        public abstract void ButtonSixPressed();
        public void ButtonSevenPressed()
        {
            volumeLevel++;
            System.Console.WriteLine($"Volume at {volumeLevel}.");
        }

        public void ButtonEightPressed()
        {
            volumeLevel--;
            System.Console.WriteLine($"Volume at {volumeLevel}.");
        }

        public void DeviceFeedback()
        {
            if (deviceState > maxSetting || deviceState < 0)
            {
                deviceState = 0;
            }
            System.Console.WriteLine($"On {deviceState}.");
        }
    }
}
