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