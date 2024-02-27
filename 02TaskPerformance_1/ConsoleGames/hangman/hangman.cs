using System;

class Hangman
{
    static void Main(string[] args)
    {
        // Word list
        string[] words = { "apple", "banana", "orange", "grape", "pineapple" };

        // Select a random word
        Random random = new Random();
        string word = words[random.Next(words.Length)];

        // Convert word to char array for checking
        char[] wordArray = word.ToCharArray();

        // Create an array to store guessed letters
        bool[] guessed = new bool[word.Length];

        int attempts = 6; // Maximum number of attempts

        // Main game loop
        while (true)
        {
            Console.Clear();

            // Display the current state of the word
            for (int i = 0; i < word.Length; i++)
            {
                if (guessed[i])
                {
                    Console.Write(wordArray[i] + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine();

            // Display attempts left
            Console.WriteLine($"Attempts left: {attempts}");

            // Ask the player to guess a letter
            Console.Write("Guess a letter: ");
            char guess = Console.ReadLine()[0];

            // Check if the guessed letter is in the word
            bool correctGuess = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (wordArray[i] == guess)
                {
                    guessed[i] = true;
                    correctGuess = true;
                }
            }

            // If the guessed letter is incorrect, decrement attempts
            if (!correctGuess)
            {
                attempts--;
            }

            // Check if the player has won
            bool hasWon = true;
            foreach (bool letterGuessed in guessed)
            {
                if (!letterGuessed)
                {
                    hasWon = false;
                    break;
                }
            }

            // Check if the player has lost
            if (attempts == 0)
            {
                Console.Clear();
                Console.WriteLine("You lost!");
                Console.WriteLine($"The word was: {word}");
                break;
            }

            // Check if the player has won
            if (hasWon)
            {
                Console.Clear();
                Console.WriteLine("Congratulations! You won!");
                Console.WriteLine($"The word was: {word}");
                break;
            }
        }
    }
}