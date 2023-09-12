using System;

class Program
{
    static void Main(string[] args)
    {
        // ask user for first name
        Console.WriteLine("What is your first name? ");
        string first = Console.ReadLine();

        //ask user for last name
        Console.WriteLine("What is your last name? ");
        string last = Console.ReadLine();
        
        //print 007 name
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }

}