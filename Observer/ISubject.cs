
namespace Patterns.Observer
{
    public interface ISubject
    {
        public void Register(IObserver o);
        public void Unregister(IObserver o);
        public void Notify();
    }
}
