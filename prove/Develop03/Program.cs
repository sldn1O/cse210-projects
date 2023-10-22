using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Scripture Memorization Program!");

        // Read lines from a text file and add them to a list
        List<string> scriptureLines = ReadScriptureFromFile("scripture.txt");

        // Create a Scripture object
        List<Scripture> scriptures = InitializeScriptures(scriptureLines);

        // Main program loop
        int currentScriptureIndex = 0;
        while (currentScriptureIndex < scriptures.Count)
        {
            Console.Clear();
            scriptures[currentScriptureIndex].Display();
            Console.WriteLine("Press enter to memorize or type 'quit' to quit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                break;

            // Replace a random word after a colon with underscores
            scriptures[currentScriptureIndex].ReplaceRandomWord();

            // If all words are hidden, move to the next scripture
            if (scriptures[currentScriptureIndex].AllWordsHidden())
            {
                currentScriptureIndex++;
            }
        }

        Console.WriteLine("Thank you for using the Scripture Memorization Program!");
    }

    static List<string> ReadScriptureFromFile(string filePath)
    {
        List<string> lines = new List<string>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    lines.Add(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }

        return lines;
    }

    static List<Scripture> InitializeScriptures(List<string> lines)
    {
        List<Scripture> scriptures = new List<Scripture>();

        foreach (string line in lines)
        {
            scriptures.Add(new Scripture(line));
        }

        return scriptures;
    }
}

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
