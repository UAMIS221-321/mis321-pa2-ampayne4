namespace mis321_pa2_ampayne4
{
    public class DavyJones : Character
    {
        public DavyJones()
        {
            name = "Davy Jones";
            maxPower = rnd.Next(1,101);
            health = 100;
            attackStrength = rnd.Next(1,maxPower+1);
            defPower = rnd.Next(1,maxPower+1);
            attackBehavior = new CannonBehavior();
            typeBonus = 1;
        }
        
    }
}