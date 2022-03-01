using System;

namespace mis321_pa2_ampayne4
{
    public class JackSparrow : Character
    {
        public JackSparrow()
        {
            name = "Jack Sparrow";
            maxPower = rnd.Next(1,101);
            health = 100;
            attackStrength = rnd.Next(1,maxPower+1);
            defPower = rnd.Next(1,maxPower+1);
            attackBehavior = new DistractBehavior();
            typeBonus = 1;
        }
    }
}