using System;
class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("John Hancock", "Division");
        Console.WriteLine(a1.GetSummary());

        MathAssign a2 = new MathAssign("George Washington", "Fractions", "8.2", "7-20");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomework());

        WritingAssign a3 = new WritingAssign("Ben Franklin", "U.S. History", "The Revolutionary War");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWriting());
    }
}