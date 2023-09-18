using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Part 1 and part 2, asking user to put number.
        // Console.Write("what is the magic number? ");
        // string magic_number = Console.ReadLine();
        // int number = int.Parse(magic_number);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;
        while (guess != number)
        {
            Console.Write("what is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}