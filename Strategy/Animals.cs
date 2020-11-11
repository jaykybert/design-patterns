
namespace Development.Strategy
{
    // Concrete Animal Class 1
    public class Dog : Animal
    {
        public Dog(string name, IFly flyingBehaviour) : base(name, flyingBehaviour) { }
 
        public override string Name { get; set; }

        public override IFly FlyingBehaviour { get; set; }
    }

    // Concrete Animal Class 2
    public class Bird : Animal
    {
        public Bird(string name, IFly flyingBehaviour) : base(name, flyingBehaviour) { }

        public override string Name { get; set; }

        public override IFly FlyingBehaviour { get; set; }
    }

    // ...
}
