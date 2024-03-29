﻿using System;

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
                              "(5) Composite\n" +
                              "(6) Decorator\n" +
                              "(7) Facade\n" +
                              "(8) Factory Method\n" +
                              "(9) Iterator\n" +
                              "(10) Observer\n" +
                              "(11) Proxy\n" +
                              "(12) Singleton\n" +
                              "(13) State\n" +
                              "(14) Strategy\n" +
                              "(15) Template");

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
                    Composite.Demo.ShowDemo();
                    break;
                case "6":
                    Decorator.Demo.ShowDemo();
                    break;
                case "7":
                    Facade.Demo.ShowDemo();
                    break;
                case "8":
                    Factory.Demo.ShowDemo();
                    break;
                case "9":
                    Iterator.Demo.ShowDemo();
                    break;
                case "10":
                    Observer.Demo.ShowDemo();
                    break;
                case "11":
                    Proxy.Demo.ShowDemo();
                    break;
                case "12":
                    Singleton.Demo.ShowDemo();
                    break;
                case "13":
                    State.Demo.ShowDemo();
                    break;
                case "14":
                    Strategy.Demo.ShowDemo();
                    break;
                case "15":
                    Template.Demo.ShowDemo();
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
        }
    }
}
