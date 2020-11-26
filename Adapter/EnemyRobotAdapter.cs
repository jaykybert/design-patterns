
namespace Patterns.Adapter
{
    public class EnemyRobotAdapter : IEnemyHuman
    {
        private readonly IEnemyRobot robot;

        public EnemyRobotAdapter(IEnemyRobot newRobot)
        {
            robot = newRobot;
        }

        public void Die()
        {
            robot.Explode();
        }

        public void FireWeapon()
        {
            robot.ShootLasers();
        }

        public void Move()
        {
            robot.Fly();
        }
    }
}
