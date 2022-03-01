namespace mis321_pa2_ampayne4
{
    public class WillTurner : Character
    {
        public WillTurner()
        {
            name = "Will Turner";
            maxPower = rnd.Next(1,101);
            health = 100;
            attackStrength = rnd.Next(1,maxPower+1);
            defPower = rnd.Next(1,maxPower+1);
            attackBehavior = new SwordBehavior();
            typeBonus = 1;
        }
    }
}