public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int basePoints) : base(name, basePoints) { }

    public override int RecordEvent()
    {
        Console.WriteLine($"Goal '{Name}' completed! Gained {basePoints} points.");
        return basePoints;
    }
}