public class MathAssign : Assignment
{
    private string _textbook;
    private string _problems;

    public MathAssign (string name, string topic, string textbook, string problems)
        : base(name, topic)
    {
        _textbook = textbook;
        _problems = problems;
    }

    public string GetHomework()
    {
        return ($"Selection {_textbook} Problems {_problems}");
    }

}