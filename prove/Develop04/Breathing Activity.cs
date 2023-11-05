using System;
using System.Threading;

// BreathingActivity class
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through deep breathing.") { }

    public override void Start()
    {
        Console.WriteLine($"Welcome to {Name} - {Description}");
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready to start in 3 seconds...");
        PauseWithSpinner(3);

        for (int i = 0; i < Duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            PauseWithSpinner(2);

            Console.WriteLine("Breathe out...");
            PauseWithSpinner(2);
        }

        Console.WriteLine("Great job! You've completed the Breathing Activity for {0} seconds.", Duration);
        PauseWithSpinner(3);
    }
}


