using mis321_pa2_ampayne4.Interfaces;

namespace mis321_pa2_ampayne4
{
    public class SwordBehavior : IAttackBehavior
    {
        public void Attack()
        {
            System.Console.WriteLine("Character used Sword!");
        }
    }
}