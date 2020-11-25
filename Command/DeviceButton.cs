
namespace Patterns.Command
{
    /*
     * This class represents the Invoker. It doesn't know what device or command is being used.
     */
    public class DeviceButton
    {
        private readonly ICommand deviceCommand;

        public DeviceButton(ICommand newCommand)
        {
            deviceCommand = newCommand;
        }

        public void Press()
        {
            deviceCommand.Execute();
        }

        public void PressUndo()
        {
            deviceCommand.Undo();
        }
    }
}
