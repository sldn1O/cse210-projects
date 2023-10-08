using System;
using System.Collections.Generic;

public class userInput
{

    private static List<string> entryList = new List<string>();

        public static List<string> EntryList
    {
        get { return entryList; }
    }


    public static List<string> Input(string prompt)
    {
        string response = Console.ReadLine();
        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString("MM/dd/yy");
        string entry = $"Date:{formattedDate} Prompt: {prompt} Response: {response}";
        entryList.Add(entry);
        Console.WriteLine();

        return entryList;
        
    }

    public static void Display()
    {
        foreach (var item in entryList)
        {
            Console.WriteLine(item);
        }
    }
}