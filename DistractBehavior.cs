using mis321_pa2_ampayne4.Interfaces;

namespace mis321_pa2_ampayne4
{
    public class DistractBehavior : IAttackBehavior
    {
        public void Attack()
        {
            System.Console.WriteLine("Character used Distract!");
        }
    }
}