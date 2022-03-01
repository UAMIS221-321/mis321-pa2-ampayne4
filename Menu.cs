using System;

namespace mis321_pa2_ampayne4
{
    public class Menu
    {
        public int MainMenu()
        {
            int choice = 0; 
            while (choice < 1 || choice > 3)
            {
                Console.WriteLine("Please select from the following options: ");
                Console.WriteLine("1. Play Game");
                Console.WriteLine("2. Display Character Stats");
                Console.WriteLine("3. Exit");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (choice < 1 || choice > 3)
                {
                    Console.WriteLine("Please enter an integer 1-3");
                }
            }
            return choice; 
        }

        public Character CharacterMenu(Player player)
        {
            int choice = 0; 
            while (choice < 1 || choice > 4)
            {
                Console.WriteLine($"{player.name}, please select your charater: ");
                Console.WriteLine("1. Jack Sparrow");
                Console.WriteLine("2. Will Turner");
                Console.WriteLine("3. Davy Jones");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (choice < 1 || choice > 3)
                {
                    Console.WriteLine("Please enter an integer 1-3");
                }
            }

            if (choice == 1)
            {
                return new JackSparrow();
            }
            else if (choice == 2)
            {
                return new WillTurner();
            }
            else if (choice == 3)
            {
                return new DavyJones();
            }
            else 
            {
                return null;
            }
        }

        public int GameMenu(ref int turn, Player player1, Player player2)
        {
            int choice = 0; 
            while (choice < 1 || choice > 2)
            {
                if (turn == 1)
                {
                    Console.WriteLine($"{player1.name}'s turn.");
                }
                else if (turn == 2)
                {
                    Console.WriteLine($"{player2.name}'s turn.");
                }
                Console.WriteLine("Please select from the following options: ");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Display Character Stats");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (choice < 1 || choice > 2)
                {
                    Console.WriteLine("Please enter an integer 1-2");
                }
            }
            return choice; 
        }



    }
}