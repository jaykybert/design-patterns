using System;

namespace Patterns.Adapter
{
    public class EnemyRobot : IEnemyRobot
    {
        public void Explode()
        {
            Console.WriteLine("Robot explodes!");
        }

        public void Fly()
        {
            Console.WriteLine("Robot flies!");
        }

        public void ShootLasers()
        {
            Console.WriteLine("Robot shoots lasers!");
        }
    }
}
