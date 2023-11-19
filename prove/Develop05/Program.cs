using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public abstract class Goal
{
    protected string name;
    protected int basePoints;

    public Goal(string name, int basePoints)
    {
        this.name = name;
        this.basePoints = basePoints;
    }

    public string Name => name;

    public int BasePoints => basePoints;

    public abstract int RecordEvent();
}

class Program
{
    static List<Goal> goals = new List<Goal>();

    static void Main()
    {
        LoadGoals(); // Load goals from file at the start

        int choice;
        do
        {
            DisplayMenu();
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateNewGoal();
                        break;
                    case 2:
                        ListGoals();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                    case 6:
                        SavePointsToFile(goals.Sum(g => g.RecordEvent()));
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        } while (choice != 6);
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nMENU");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
    }

    static void CreateNewGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter base points for the goal: ");
        if (int.TryParse(Console.ReadLine(), out int basePoints))
        {
            Console.WriteLine("Select goal type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int goalTypeChoice))
            {
                Goal newGoal;

                switch (goalTypeChoice)
                {
                    case 1:
                        newGoal = new SimpleGoal(name, basePoints);
                        break;
                    case 2:
                        newGoal = new EternalGoal(name, basePoints);
                        break;
                    case 3:
                        Console.Write("Enter target count for the checklist goal: ");
                        if (int.TryParse(Console.ReadLine(), out int targetCount))
                        {
                            newGoal = new ChecklistGoal(name, basePoints, targetCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for target count. Creating a Simple Goal instead.");
                            newGoal = new SimpleGoal(name, basePoints);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Creating a Simple Goal instead.");
                        newGoal = new SimpleGoal(name, basePoints);
                        break;
                }

                goals.Add(newGoal);
                Console.WriteLine($"Goal '{name}' created!");
            }
            else
            {
                Console.WriteLine("Invalid input. Creating a Simple Goal instead.");
                goals.Add(new SimpleGoal(name, basePoints));
            }
        }
        else
        {
            Console.WriteLine("Invalid input for base points. Goal creation failed.");
        }
    }

    static void ListGoals()
    {
        Console.WriteLine("\nLIST OF GOALS");
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.Name} [{(goal is ChecklistGoal ? (goal as ChecklistGoal).GetProgress() : "X")}]");
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("Goals.txt"))
        {
            foreach (var goal in goals)
            {
                string line = $"{goal.GetType().Name}|{goal.Name}|{goal.BasePoints}";

                if (goal is ChecklistGoal checklistGoal)
                {
                    line += $"|{checklistGoal.GetProgress()}";
                }

                writer.WriteLine(line);
            }
        }

        Console.WriteLine("Goals saved to 'Goals.txt'.");
    }

    static void LoadGoals()
    {
        goals.Clear(); // Clear existing goals before loading

        if (File.Exists("Goals.txt"))
        {
            using (StreamReader reader = new StreamReader("Goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string type = parts[0];
                    string name = parts[1];
                    int basePoints = int.Parse(parts[2]);

                    switch (type)
                    {
                        case "Simple":
                            goals.Add(new SimpleGoal(name, basePoints));
                            break;
                        case "Eternal":
                            goals.Add(new EternalGoal(name, basePoints));
                            break;
                        case "Checklist":
                            int targetCount = int.Parse(parts[3]);
                            goals.Add(new ChecklistGoal(name, basePoints, targetCount));
                            break;
                    }
                }
            }

            Console.WriteLine("Goals loaded from 'Goals.txt'.");
        }
        else
        {
            Console.WriteLine("No existing goals file found. Starting with an empty list.");
        }
    }

    static void SavePointsToFile(int totalPoints)
    {
        // Save the total points to a file
        using (StreamWriter writer = new StreamWriter("Points.txt"))
        {
            writer.WriteLine(totalPoints);
        }
        Console.WriteLine($"Total points ({totalPoints}) saved to 'Points.txt'.");
    }

    static void RecordEvent()
    {
        Console.Write("Enter the name of the goal you want to record an event for: ");
        string goalName = Console.ReadLine();

        Goal goalToRecord = goals.Find(g => g.Name.Equals(goalName, StringComparison.OrdinalIgnoreCase));

        if (goalToRecord != null)
        {
            int pointsEarned = goalToRecord.RecordEvent();
            Console.WriteLine($"You earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found.");
        }
    }
}
