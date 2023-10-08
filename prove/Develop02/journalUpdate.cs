using System;
using System.Collections.Generic;
using System.IO;

public class journalFile
{
    public static void Save(List<string> entryList)
    {
        string filePath = "journal.txt";
        File.AppendAllLines(filePath, entryList);
    }

    public static void loadFromFile(string filePath, List<string> entryList)
    {
            entryList.AddRange(File.ReadAllLines(filePath));
    }
}



