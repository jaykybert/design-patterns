using System;

namespace Patterns.Factory
{
    public abstract class Enemy
    {
        public string Name { get; set; }
        public string Speed { get; set; }
        public double Damage { get; set; }

        public void Attack()
        {
            Console.WriteLine($"Attacking for {Damage} damage!");
        }

        public void Move()
        {
            Console.WriteLine($"Enemy {Name} is moving {Speed}...");
        }
    }
}
