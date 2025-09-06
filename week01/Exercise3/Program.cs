using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Console.Write("What is the magic number? ");
        // string magic = Console.ReadLine();
        // int magicNumber = int.Parse(magic);

        // string playAngain;
        // playAngain = "yes";

        // while (playAngain == "yes")
        // {
        //     Random randomGenerator = new Random();
        //     int magicNumber = randomGenerator.Next(1, 100);
        //     int guessNuber;
        //     guessNuber = -1;
        //     int tries;
        //     tries = 1;
        //     while (magicNumber != guessNuber)
        //     {
        //         Console.WriteLine("Enter a number.");
        //         string guess = Console.ReadLine();
        //         int guessNumber = int.Parse(guess);

        //         tries = tries + 1;

        //         if (magicNumber > guessNumber)
        //         {
        //             Console.WriteLine("Higher");
        //         }
        //         else if (magicNumber == guessNumber)
        //         {
        //             Console.WriteLine("You guessed it!");
        //         }
        //         else if (magicNumber < guessNumber)
        //         {
        //             Console.WriteLine("Lower");
        //         }
        //     }
        //     Console.WriteLine($"You tried {tries} times.");
        //     Console.WriteLine("Would you like to play again? ");
        //     string playAgain = Console.ReadLine();
        // }


        string playAgain;
        playAgain = "yes";

        while (playAgain == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;

            int tries;
            tries = 1;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                tries = tries + 1;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

            }
            
            Console.WriteLine($"You tried {tries} times.");

            Console.WriteLine("Would you like to play again? ");
            playAgain = Console.ReadLine();
        }


        
    }
}