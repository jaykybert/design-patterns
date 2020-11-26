using System;

namespace Patterns
{
    class Patterns
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) Strategy\n(2) Observer\n(3) Decorator\n(4) Factory Method\n(5) Abstract Factory\n(6) Singleton\n(7) Command\n(8) Adapter");
            ConsoleKeyInfo keyPress = Console.ReadKey();
            Console.WriteLine("");
            if(keyPress.KeyChar == '1')
            {
                Strategy.Demo.ShowDemo();
            }
            else if(keyPress.KeyChar == '2')
            {
                Observer.Demo.ShowDemo();
            }
            else if(keyPress.KeyChar == '3')
            {
                Decorator.Demo.ShowDemo();
            }
            else if(keyPress.KeyChar == '4')
            {
                Factory.Demo.ShowDemo();
            }
            else if(keyPress.KeyChar == '5')
            {
                Abstract_Factory.Demo.ShowDemo();
            }
            else if(keyPress.KeyChar == '6')
            {
                Singleton.Demo.ShowDemo();
            }
            else if(keyPress.KeyChar == '7')
            {
                Command.Demo.ShowDemo();
            }
            else if(keyPress.KeyChar == '8')
            {
                Adapter.Demo.ShowDemo();
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }
    }
}
