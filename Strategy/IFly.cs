
namespace Development.Strategy
{
    // Classes that implement the interface can model lots of different types of flying, without affecting Animal (or any of its subclasses).
    public interface IFly
    {
        public string Fly();
    }
}
