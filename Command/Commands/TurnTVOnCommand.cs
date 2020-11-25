
namespace Patterns.Command.Commands
{
    public class TurnTVOnCommand : ICommand
    {
        private readonly IElectronicDevice device;
        
        public TurnTVOnCommand(IElectronicDevice newDevice)
        {
            device = newDevice;
        }

        public void Execute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }
}
