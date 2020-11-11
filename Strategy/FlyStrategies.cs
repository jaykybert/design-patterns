
namespace Development.Strategy
{
    // Fly Strategy 1
    class FlyStrategy : IFly
    {
        public string Fly()
        {
            return "Flying!";
        }
    }

    // Fly Strategy 2
    class NoFlyStrategy : IFly
    {
        public string Fly()
        {
            return "I can't fly.";
        }
    }

    // ...
}
