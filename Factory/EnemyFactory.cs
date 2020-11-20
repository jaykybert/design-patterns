
namespace Patterns.Factory
{
    /*
     * The factory could also implement an interface, allowing for different factories for different purpsoses.
     * For instance, this factory uses user input to determine enemy type, but another factory could use RNG, and another
     * could try to balance the number of enemy types it creates.
     */
    public class EnemyFactory
    {
        public Enemy CreateEnemy(string enemyType)
        {
            enemyType = enemyType.ToUpper();

            Enemy enemy;

            if (enemyType == "T")
            {
                enemy = new EnemyTank();
            }
            else if (enemyType == "B")
            {
                enemy = new EnemyTankBoss();
            }
            else
            {
                enemy = new EnemySoldier();
            }
            return enemy;
        }
    }
}