using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13GCC
{
    class RoshamboApp
    {
        public static int score1 = 0;
        public static int score2 = 0;

        public static string paper = @"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
";
        public static string rock = @"    
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)";
        public static string scissor = @"    
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)";



        public static Player Play(string choice)
        {
            if (choice == "Easy")
            {
                return new Player1();
            }
            else
            {
                return new Player2();
            }   
        }

        public static string isWinner(Roshambo one, Roshambo two)
        {
            if(one == Roshambo.Paper && two == Roshambo.Rock)
            {
                score1++;
                return Icon(one) + "\n" + Icon(two) +
                    $"\n\nPlayer 1 chose {one} and Player 2 chose {two}" +
                    $"\nPlayer 1 Wins!";
            }
            else if(one == Roshambo.Paper && two == Roshambo.Paper)
            {
                return Icon(one) + "\n" + Icon(two) +
                    $"\n\nPlayer 1 chose {one} and Player 2 chose {two}" + 
                    $"\nPlayers Tie!";
            }
            else if (one == Roshambo.Paper && two == Roshambo.Scissors)
            {
                score2++;
                return Icon(one) + "\n" + Icon(two) +
                    $"\n\nPlayer 1 chose {one} and Player 2 chose {two}" +
                    $"\nPlayer 1 Loses!";
            }
            else if (one == Roshambo.Rock && two == Roshambo.Scissors)
            {
                score1++;
                return Icon(one) + "\n" + Icon(two) +
                    $"\n\nPlayer 1 chose {one} and Player 2 chose {two}" +
                    $"\nPlayer 1 Wins!";
            }
            else if (one == Roshambo.Rock && two == Roshambo.Rock)
            {
                return Icon(one) + "\n" + Icon(two) +
                    $"\n\nPlayer 1 chose {one} and Player 2 chose {two}" +
                    $"\nPlayers Tie!";
            }
            else if (one == Roshambo.Rock && two == Roshambo.Paper)
            {
                score2++;
                return Icon(one) + "\n" + Icon(two) +
                    $"\n\nPlayer 1 chose {one} and Player 2 chose {two}" +
                    $"\nPlayer 1 Loses!";
            }
            else if (one == Roshambo.Scissors && two == Roshambo.Paper)
            {
                score1++;
                return Icon(one) + "\n" + Icon(two) +
                    $"\n\nPlayer 1 chose {one} and Player 2 chose {two}" +
                    $"\nPlayer 1 Wins!";
            }
            else if (one == Roshambo.Scissors && two == Roshambo.Scissors)
            {
                return Icon(one) + "\n" + Icon(two) +
                    $"\n\nPlayer 1 chose {one} and Player 2 chose {two}" +
                    $"\nPlayers Tie!";
            }
            else if (one == Roshambo.Scissors && two == Roshambo.Rock)
            {
                score2++;
                return Icon(one) + "\n" + Icon(two) +
                    $"\n\nPlayer 1 chose {one} and Player 2 chose {two}" +
                    $"\nPlayer 1 Loses!";
            }
            return "Idk what happened";
        }
        public static string whoWon()
        {
            if (score1 > score2)
            {
                return $"Player 1 wins, {score1} to {score2}!";
            }
            else if (score1 < score2)
            {
                return $"Player 1 loses, {score1} to {score2}!";
            }
            else
            {
                return $"Players tie, {score1} to {score2}!";
            }
        }

        public static string Icon(Roshambo rosh)
        {
            if (rosh == Roshambo.Paper)
            {
                return paper;
            }
            else if (rosh == Roshambo.Rock)
            {
                return rock;
            }
            else
            {
                return scissor;
            }
        }
    }
}
