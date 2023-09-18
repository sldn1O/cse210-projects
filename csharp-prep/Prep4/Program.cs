using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list for numbers.
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");        
        int userNumber = -1;
        while (userNumber != 0)
        {
            // Add numbers to list.
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        // Find the sum of the numbers.
        int sum = 0;
        foreach (int number in numbers)
         {
            sum += number;
         }
        Console.WriteLine($"The sum is: {sum}");
        // Find the average of the numbers.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        // Find the largest number.
        int largest = numbers [0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The max is: {largest}");
        
    }
}