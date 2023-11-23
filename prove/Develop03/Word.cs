class Word
{
    private string _text;
    private bool _isHidden;

    public string Text => _isHidden ? new string('_', _text.Length) : _text;
    public bool IsHidden => _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public override string ToString()
    {
        return Text;
    }

    public static List<Word> ParseWords(string line)
    {
        List<Word> words = new List<Word>();
        string[] parts = line.Split(' ');

        foreach (string part in parts)
        {
            words.Add(new Word(part));
        }

        return words;
    }
}
