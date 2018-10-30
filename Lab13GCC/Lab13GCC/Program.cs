using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13GCC
{
    class Program
    {
        public static int player;
        public static Player1 easy = new Player1();
        public static Player2 hard = new Player2();
        public static Player3 brutal = new Player3();
        
        static void Main()
        {
            Console.Write("Welcome to the Roshambo App!" +
                "\nPlease enter a name: ");
            Console.ReadLine();
            Console.Write("\nPlease select either the \"Easy\", \"Hard\" or \"Brutal\" opponent: ");
            player = RoshamboApp.Play(Validator.playerChecker(Console.ReadLine()));
            Console.Write("\nThe game begins!\n");
            while (true)
            {
                Console.Write("\nPick a hand to throw (Rock, Paper, or Scissors): ");
                if (player == 3)
                {
                    Roshambo choice = Validator.gameChecker(Console.ReadLine());
                    Console.WriteLine("\n" + RoshamboApp.isWinner(choice, brutal.generateRoshambo(choice)));
                }
                else if (player == 1)
                {
                    Console.WriteLine("\n" + RoshamboApp.isWinner(Validator.gameChecker(Console.ReadLine()), easy.generateRoshambo()));
                }
                else
                {
                    Console.WriteLine("\n" + RoshamboApp.isWinner(Validator.gameChecker(Console.ReadLine()), hard.generateRoshambo()));
                }
                Console.Write("\nPlay another hand? (y/n): ");
                if (Validator.yesNoChecker(Console.ReadLine()) == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }            
            Console.WriteLine("\n\nYEET\n\n" + RoshamboApp.YEET);
            Console.WriteLine("\n" + RoshamboApp.whoWon());
            Console.Write("\nThanks for playing!\n\n" +
                "Press any key to exit . . .");
            Console.ReadKey();
        }
    }
}
