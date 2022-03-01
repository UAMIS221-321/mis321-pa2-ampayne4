using System.Net.Mime;
using System;

namespace mis321_pa2_ampayne4
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1);
            Player player2 = new Player(2);

            Menu menu = new Menu();

            player1.character = menu.CharacterMenu(player1);
            player2.character = menu.CharacterMenu(player2);

            int choice = menu.MainMenu();

            Game game = new Game();

            while (choice != 3)
            {
                if (choice == 1)
                {         
                    //Plays game until one character runs out of health
                    Console.WriteLine("GAME BEGINS: ");
                    while (player1.character.health > 0 && player2.character.health > 0)
                    {
                        int gameMenuChoice = menu.GameMenu(ref game.turn, player1, player2); //displays game menu: attack or view stats
                        if (gameMenuChoice == 1) //plays one round of game
                        {
                            game.Fight(ref player1, ref player2, ref game.turn); 
                            // Console.WriteLine($"Player 1 typeBonus = {player1.character.typeBonus}");
                            // Console.WriteLine($"Player 2 typeBonus = {player2.character.typeBonus}");
                        }
                        else if (gameMenuChoice == 2) //displays characters' stats
                        {
                            game.DisplayCharacterStats(player1.character);
                            game.DisplayCharacterStats(player2.character);
                        }
                    }
                    
                    if (player1.character.health <= 0) //if player 1 loses
                    {
                        Console.WriteLine($"{player1.name} lost.");
                    }
                    else if (player2.character.health <= 0) //if player 2 loses
                    {
                        Console.WriteLine($"{player2.name} lost.");
                    }
                }

                else if (choice == 2) //displays stats
                {
                    game.DisplayCharacterStats(player1.character);
                    game.DisplayCharacterStats(player2.character);
                }
                choice = menu.MainMenu();
            }
        }
    }
}
