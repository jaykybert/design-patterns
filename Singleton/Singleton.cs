
namespace Patterns.Singleton
{
    class Singleton
    {
        private static Singleton instance = null;

        private Singleton() { } // Private constructor.

        public static Singleton GetInstance() // Uses lazy initialisation.
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        // ... (other responsibilites)
        public void SayHello()
        {
            System.Console.WriteLine("The singleton says hello!");
        }
    }
}
