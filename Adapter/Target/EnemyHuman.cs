using System;

namespace Patterns.Adapter
{
    public class EnemyHuman : IEnemyHuman
    {
        public void Die()
        {
            Console.WriteLine("Soldier died!");
        }

        public void FireWeapon()
        {
            Console.WriteLine("Soldier fired weapon!");
        }

        public void Move()
        {
            Console.WriteLine("Soldier moved!");
        }
    }
}
