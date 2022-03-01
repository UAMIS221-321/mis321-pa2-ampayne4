using System;

namespace mis321_pa2_ampayne4
{
    public class Game
    {
        public static Random rnd = new Random();
        public int turn = rnd.Next(1,3);


        public void DisplayCharacterStats(Character character)
        {
            Console.WriteLine("Name: " + character.name);
            Console.WriteLine("Health: " + character.health);
            Console.WriteLine("Max Power: " + character.maxPower);
            Console.WriteLine("Attack Strength: " + character.attackStrength);
            Console.WriteLine("Defensive Power: " + character.defPower);
            Console.WriteLine();
        }

        public void Fight(ref Player player1, ref Player player2, ref int turn)
        {
            //this sets the type bonus
            if (player1.character.name == "Jack Sparrow" && player2.character.name == "Will Turner")
            {
                player1.character.typeBonus = 1.2;
            }
            else if (player1.character.name == "Will Turner" && player2.character.name == "Davy Jones")
            {
                player1.character.typeBonus = 1.2;
            }
            else if (player1.character.name == "Davy Jones" && player2.character.name == "Jack Sparrow")
            {
                player1.character.typeBonus = 1.2;
            }
            else if (player2.character.name == "Jack Sparrow" && player1.character.name == "Will Turner")
            {
                player2.character.typeBonus = 1.2;
            }
            else if (player2.character.name == "Will Turner" && player1.character.name == "Davy Jones")
            {
                player2.character.typeBonus = 1.2;
            }
            else if (player2.character.name == "Davy Jones" && player1.character.name == "Jack Sparrow")
            {
                player2.character.typeBonus = 1.2;
            }

            if (turn == 1)
            {
                double damage = player1.character.Attack(player1, player2);
                player2.character.health = player2.character.health - damage;
                turn = 2;
                player1.character.attackBehavior.Attack();
                Console.WriteLine($"{player1.character.name} dealt {damage} damage.");
                DisplayCharacterStats(player2.character);
            }
            else if (turn == 2)
            {
                double damage = player2.character.Attack(player2, player1);
                player1.character.health = player1.character.health - damage;
                turn = 1;
                player2.character.attackBehavior.Attack();
                Console.WriteLine($"{player2.character.name} dealt {damage} damage."); 
                DisplayCharacterStats(player1.character);
            }
        }
    }
}