using System;

namespace Patterns.Adapter
{
    /* 
     *  The adapter pattern converts the interface of a class into another interface
     *  the clients expect. Adapter lets classes work together that couldn't otherwise
     *  because of incompatible interfaces.
     *  
     *  The adapter class allows the use of the available interface and the target interface.
     *
     *
     *  When to use:
     *      * Used when the client expects a (target) interface.
     *
     * 
     *  Pros / Cons
     *      * You can separate the adapter code from the business logic.
     *      * You can introduce new adapters without breaking the existing client code.
     *      - Code complexity increases.
     *
     *
     *  Resources
     *      * https://www.youtube.com/watch?v=2PKQtcJjYvc
     *      * https://www.youtube.com/watch?v=qG286LQM6BU
     */
    public static class Demo
    {
        public static void ShowDemo()
        {
            // Human Methods
            Console.WriteLine("Enemy Human Methods");
            EnemyHuman soldier = new EnemyHuman();
            soldier.Move();
            soldier.FireWeapon();
            soldier.Die();

            // Robot Methods
            EnemyRobot robot = new EnemyRobot();
            Console.WriteLine("\nEnemy Robot Methods");
            robot.Fly();
            robot.ShootLasers();
            robot.Explode();

            // Call human methods that call the robot methods inside the adapter.
            Console.WriteLine("\nThe Adapted Robot");
            IEnemyHuman robotInDisguise = new EnemyRobotAdapter(robot);
            robotInDisguise.Move();
            robotInDisguise.FireWeapon();
            robotInDisguise.Die();
        }
    }
}
