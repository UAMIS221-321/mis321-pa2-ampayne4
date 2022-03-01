namespace mis321_pa2_ampayne4
{
    public class Player
    {
        public string name {get;set;}
        public Character character {get;set;}
        
        public Player(int playerNum)
        {
            System.Console.WriteLine($"Enter player {playerNum} name: ");
            name = System.Console.ReadLine();
        }
    }
}