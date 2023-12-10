using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        Console.WriteLine("Choose an exercise to track:");
        Console.WriteLine("1. Running");
        Console.WriteLine("2. Stationary Bicycles");
        Console.WriteLine("3. Swimming");

        int exerciseChoice = int.Parse(Console.ReadLine());

        DateTime currentDate = DateTime.Now;

        Console.Write("Enter the duration in minutes: ");
        int activityMinutes = int.Parse(Console.ReadLine());

        switch (exerciseChoice)
        {
            case 1:
                Console.Write("Enter distance for running (miles): ");
                double runningDistance = double.Parse(Console.ReadLine());
                activities.Add(new Running(currentDate, activityMinutes, runningDistance));
                break;
            case 2:
                Console.Write("Enter speed for stationary bicycling (mph): ");
                double bicyclingSpeed = double.Parse(Console.ReadLine());
                activities.Add(new StationaryBicycles(currentDate, activityMinutes, bicyclingSpeed));
                break;
            case 3:
                Console.Write("Enter number of laps for swimming: ");
                int swimmingLaps = int.Parse(Console.ReadLine());
                activities.Add(new Swimming(currentDate, activityMinutes, swimmingLaps));
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting.");
                return;
        }

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
