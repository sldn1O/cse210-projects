public class EternalGoal : Goal
{
    public EternalGoal(string name, int basePoints) : base(name, basePoints) { }

    public override int RecordEvent()
    {
        Console.WriteLine($"Recorded event for eternal goal '{Name}'. Gained {basePoints} points.");
        return basePoints;
    }
}

