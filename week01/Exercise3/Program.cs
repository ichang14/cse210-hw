using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string response;

        do
        {
            int magic = randomGenerator.Next(1, 101);
            int attempts = 1;
            int guess_number;

            Console.Write("What is your guess? ");
            guess_number = int.Parse(Console.ReadLine());
            attempts++;

            while (guess_number != magic)
            {
                if (guess_number < magic)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }

                Console.Write("What is your guess? ");
                guess_number = int.Parse(Console.ReadLine());
                attempts++;
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You guessed it in {attempts} tries!");

            Console.Write("Do you want to play again? (yes/no): ");
            response = Console.ReadLine();

        } while (response.ToLower() == "yes");
        }
}