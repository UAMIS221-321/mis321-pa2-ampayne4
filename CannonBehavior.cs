using mis321_pa2_ampayne4.Interfaces;

namespace mis321_pa2_ampayne4
{
    public class CannonBehavior : IAttackBehavior
    {
        public void Attack()
        {
            System.Console.WriteLine("Character used Cannon!");
        }
    }
}