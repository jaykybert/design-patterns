
namespace Patterns.Bridge
{
    // Abstraction Layer
    public abstract class RemoteButton
    {
        private EntertainmentDevice device;

        public RemoteButton(EntertainmentDevice newDevice)
        {
            device = newDevice;
        }

        public void ButtonFivePressed()
        {
            device.ButtonFivePressed();
        }

        public void ButtonSixPressed()
        {
            device.ButtonSixPressed();
        }

        public void DeviceFeedback()
        {
            device.DeviceFeedback();
        }

        public abstract void ButtonNinePressed();
    }
}
