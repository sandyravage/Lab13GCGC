using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13GCC
{
    class Validator
    {
        public static string yesNoChecker(string choice) 
        {
            while (choice != "y" && choice != "n")
            {
                Console.WriteLine("\nInvalid choice. Please enter \"y\" for yes or \"n\" for no.");
                choice = Console.ReadLine();
            }
            return choice;
        }
        public static string playerChecker(string choice)
        {
            while (choice != "Easy" && choice != "Hard")
            {
                Console.Write("\nInvalid choice. Please enter \"Easy\" for an easy opponent or \"Hard\" for a difficult one: ");
                choice = Console.ReadLine();
            }
            return choice;
        }
        public static Roshambo gameChecker(string choice)
        {
            Roshambo roch;
            while (!Enum.TryParse<Roshambo>(choice, out roch))
            {
                Console.Write("\nInvalid choice. Please enter either \"Rock\", \"Paper\", or \"Scissors\": ");
                choice = Console.ReadLine();
            }
            return roch;
        }
    }
}
