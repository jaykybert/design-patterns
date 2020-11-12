using System;

namespace Patterns
{
    class Patterns
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) Strategy\n(2) Observer");
            ConsoleKeyInfo keyPress = Console.ReadKey();
            if(keyPress.KeyChar == '1')
            {
                Strategy.Demo.ShowDemo();
            }
            else if(keyPress.KeyChar == '2')
            {
                Observer.Demo.ShowDemo();
            }

            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }
    }
}
