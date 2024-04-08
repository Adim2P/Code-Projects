using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_on_Activity_2
{
    public class Game
    {
        public string PlayerChoice { get; set; }
        public string ComputerChoice { get; set; }
        public string Result { get; set; }

        public Game(string playerChoice)
        {
            PlayerChoice = playerChoice;
            ComputerChoice = new RandomChoiceGenerator().GetChoice();
            Result = DetermineWinner();
        }

        private string DetermineWinner()
        {
            if (PlayerChoice == null)
            {
                return "It's a tie!";
            }
            else if ((PlayerChoice == "rock" && ComputerChoice == "scissors") ||
                     (PlayerChoice == "paper" && ComputerChoice == "rock") ||
                     (PlayerChoice == "scissors" && ComputerChoice == "paper"))
            {
                return "You Win!";
            }
            else if ((PlayerChoice == ComputerChoice))
            {
                return "Draw!";
            }
            else
            {
                return "You Lose!";
            }
        }
    }
}
