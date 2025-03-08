using System;

class Program
{
    static void Main(string[] args)
    {

        bool playAgain = true;

        while (playAgain)
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int guess = 0;
            bool isGuessed = false;
            int guessCount = 0;

            while (!isGuessed)
            {

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                    isGuessed = true;
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainResponse = Console.ReadLine().ToLower();

            if (playAgainResponse != "yes")
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}