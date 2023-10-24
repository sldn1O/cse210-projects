public class WritingAssign : Assignment
{
    private string _title;

    public WritingAssign(string name, string topic, string title)
        : base (name, topic)
    {
        _title = title;
    }

    public string GetWriting()
    {
        string name = GetName();
        return $"{_title} by {name}";
    }
}