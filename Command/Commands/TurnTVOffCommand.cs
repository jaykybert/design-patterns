
namespace Patterns.Command.Commands
{
    public class TurnTVOffCommand : ICommand
    {
        private readonly IElectronicDevice device;

        public TurnTVOffCommand(IElectronicDevice newDevice)
        {
            device = newDevice;
        }

        public void Execute()
        {
            device.Off();
        }

        public void Undo()
        {
            device.On();
        }
    }
}
