using System;

namespace Patterns
{
    class Patterns
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) Strategy\n(2) Observer\n(3) Decorator\n(4) Factory Method");
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
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }
    }
}
