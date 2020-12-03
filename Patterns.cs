using System;

namespace Patterns
{
    class Patterns
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) Abstract Factory\n" +
                              "(2) Adapter\n" +
                              "(3) Command\n" +
                              "(4) Decorator\n" +
                              "(5) Facade\n" +
                              "(6) Factory Method\n" +
                              "(7) Observer\n" +
                              "(8) Singleton\n" +
                              "(9) Strategy");

            ConsoleKeyInfo keyPress = Console.ReadKey();

            switch(keyPress.KeyChar)
            {
                case '1':
                    Abstract_Factory.Demo.ShowDemo();
                    break;
                case '2':
                    Adapter.Demo.ShowDemo();
                    break;
                case '3':
                    Command.Demo.ShowDemo();
                    break;
                case '4':
                    Decorator.Demo.ShowDemo();
                    break;
                case '5':
                    Facade.Demo.ShowDemo();
                    break;
                case '6':
                    Factory.Demo.ShowDemo();
                    break;
                case '7':
                    Observer.Demo.ShowDemo();
                    break;
                case '8':
                    Singleton.Demo.ShowDemo();
                    break;
                case '9':
                    Strategy.Demo.ShowDemo();
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
        }
    }
}
