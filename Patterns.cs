using System;

namespace Patterns
{
    class Patterns
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) Abstract Factory\n" +
                              "(2) Adapter\n" +
                              "(3) Bridge\n" +
                              "(4) Command\n" +
                              "(5) Decorator\n" +
                              "(6) Facade\n" +
                              "(7) Factory Method\n" +
                              "(8) Observer\n" +
                              "(9) Proxy\n" +
                              "(10) Singleton\n" +
                              "(11) Strategy");

            string keyPress = Console.ReadLine();

            switch(keyPress)
            {
                case "1":
                    Abstract_Factory.Demo.ShowDemo();
                    break;
                case "2":
                    Adapter.Demo.ShowDemo();
                    break;
                case "3":
                    Bridge.Demo.ShowDemo();
                    break;
                case "4":
                    Command.Demo.ShowDemo();
                    break;
                case "5":
                    Decorator.Demo.ShowDemo();
                    break;
                case "6":
                    Facade.Demo.ShowDemo();
                    break;
                case "7":
                    Factory.Demo.ShowDemo();
                    break;
                case "8":
                    Observer.Demo.ShowDemo();
                    break;
                case "9":
                    Proxy.Demo.ShowDemo();
                    break;
                case "10":
                    Singleton.Demo.ShowDemo();
                    break;
                case "11":
                    Strategy.Demo.ShowDemo();
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
        }
    }
}
