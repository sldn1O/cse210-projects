public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, int basePoints, int targetCount) : base(name, basePoints)
    {
        this.targetCount = targetCount;
        this.currentCount = 0;
    }

    public void MarkCompleted()
    {
        // Mark the goal as completed by changing [ ] to [X]
        name = $"[X] {name.Substring(3)}";
    }

    public override int RecordEvent()
    {
        currentCount++;
        Console.WriteLine($"Recorded event for checklist goal '{Name}'. Gained {basePoints} points.");

        if (currentCount == targetCount)
        {
            Console.WriteLine($"Congratulations! Checklist goal '{Name}' completed! Gained additional {basePoints * 2} bonus points.");
            MarkCompleted(); // Mark the goal as completed
            return basePoints * 2;
        }

        return basePoints;
    }

    public string GetProgress()
    {
        return $"Completed {currentCount}/{targetCount} times";
    }
}