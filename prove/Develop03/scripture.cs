class Scripture
{
    private List<Word> words = new List<Word>();

    public Scripture(string line)
    {
        words.AddRange(Word.ParseWords(line));
    }

    public void Display()
    {
        foreach (Word word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    public void ReplaceRandomWord()
    {
        List<Word> visibleWords = words.FindAll(w => !w.IsHidden);
        if (visibleWords.Count == 0)
        {
            Console.WriteLine("All words are hidden. Type 'quit' to exit.");
            return;
        }

        Random random = new Random();
        int index = random.Next(visibleWords.Count);
        visibleWords[index].Hide();
    }

    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden);
    }
}

