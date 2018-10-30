using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13GCC
{
    class Program
    {
        static void Main()
        {
            Player opponent;
            Console.Write("Welcome to the Roshambo App!" +
                "\nPlease enter a name: ");
            Console.ReadLine();
            Console.Write("\nPlease select either the \"Easy\" or \"Hard\" opponent: ");
            opponent = RoshamboApp.Play(Validator.playerChecker(Console.ReadLine()));
            Console.Write("\nThe game begins!\n");
            while (true)
            {
                Console.Write("\nPick a hand to throw (Rock, Paper, or Scissors): ");
                Console.WriteLine("\n" + RoshamboApp.isWinner(Validator.gameChecker(Console.ReadLine()), opponent.generateRoshambo()));
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
            Console.WriteLine("\n" + RoshamboApp.whoWon());
            Console.Write("\nThanks for playing!\n\n" +
                "Press any key to exit . . .");
            Console.ReadKey();
        }
    }
}
