
namespace Development.Strategy
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract IFly FlyingBehaviour { get; set; }

        public Animal(string name, IFly flyingBehaviour)
        {
            Name = name;
            FlyingBehaviour = flyingBehaviour;
        }

        // Using an interface type as a property/member - not inheriting from it. This is composition.
        // This allows you to change the capability of objects are runtime - behaviour isn't tied to the superclass or subclasses.
        public string Fly()
        {
            return FlyingBehaviour.Fly();
        }
    }
}
