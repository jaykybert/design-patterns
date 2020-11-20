
namespace Patterns.Factory
{
    public class EnemyTankBoss : EnemyTank // Subclass of EnemyTank. 
    {
        public EnemyTankBoss()
        {
            Name = "Tank Boss";
            Speed = "Slow";
            Damage = 100.0;
        }

    }
}
