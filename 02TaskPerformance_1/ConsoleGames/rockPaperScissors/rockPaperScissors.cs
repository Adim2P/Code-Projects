using System;

class rockPaperScissors
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("Enter your choice (Rock, Paper, or Scissors): ");
            string playerChoice = Console.ReadLine().ToLower();

            //Code logic for generating computer choice randomly
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            string computerChoice = GetComputerChoice(randomNumber);

            //Code block for determining the victor
            string result = GetWinner(playerChoice, computerChoice);

            //Displays the result
            Console.WriteLine($"You chose: {playerChoice}");
            Console.WriteLine($"Computer chose: {computerChoice}");
            Console.WriteLine($"Result: {result}");

            //Code block for determining if player wants to play again
            Console.WriteLine("Do you want to play again? (yes/no)");
            string playAgain = Console.ReadLine().ToLower();
            
            if (playAgain != "yes")
                break;
        }
    }

    static string GetComputerChoice(int randomNumber)
    {
        switch (randomNumber)
        {
            case 1:
                return "rock";
            case 2:
                return "paper";
            case 3:
                return "scissors";
            default:
                return "error";
        }
    }

    static string GetWinner(string playerChoice, string computerChoice)
    {
        if (playerChoice == computerChoice)
            return "It's a tie!";
        else if (playerChoice == "rock" && computerChoice == "scissors" ||
                 playerChoice == "paper" && computerChoice == "rock" ||
                 playerChoice == "scissors" && computerChoice == "paper")
            return "You win!";
        else 
            return "Computer wins!";
    }
}