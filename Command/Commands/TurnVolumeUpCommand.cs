
namespace Patterns.Command.Commands
{
    public class TurnVolumeUp : ICommand
    {
        private readonly IElectronicDevice device;

        public TurnVolumeUp(IElectronicDevice newDevice)
        {
            device = newDevice;
        }

        public void Execute()
        {
            device.VolumeUp();
        }

        public void Undo()
        {
            device.VolumeDown();
        }
    }
}
