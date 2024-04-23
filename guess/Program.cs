using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int wrongGuessCount = 0;

        while (true)
        {
            Console.Write("Guess the number (between 1 and 100): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int guess))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Please enter a number between 1 and 100.");
                continue;
            }

            if (guess < secretNumber)
            {
                Console.WriteLine("The secret number is bigger.");
                wrongGuessCount++;
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("The secret number is smaller.");
                wrongGuessCount++;
            }
            else
            {
                Console.WriteLine("Nice Catch! You guessed the secret number: " + secretNumber);
                Console.WriteLine("Number of wrong guesses: " + wrongGuessCount);
                break;
            }
        }
    }
}
