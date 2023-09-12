using System;
using System.ComponentModel.Design.Serialization;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Ask for percentage
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = "";

        // Check if A
        if (percent >= 90)
        {
            letter = "A";
        }

        // Check if B
        else if (percent < 90 && percent >= 80)
        {
            letter = "B";
        }

        // Check if C
        else if (percent < 80 && percent >= 70)
        {
            letter = "C";
        }

        // Check if D
        else if (percent < 70 && percent >= 60)
        {
            letter = "D";
        }
        
        // else is F
        else
        {
            letter = "F";
        }

        // Display Letter Grade
        Console.WriteLine($"Your grade is: {letter}");

        // Check if percentage is above 70
        if (percent >= 70)
        { 
            Console.WriteLine("You Passed the Class!");
        }
        
        else
        {
            Console.WriteLine("Better Luck Next Time!");
        }
    }
}