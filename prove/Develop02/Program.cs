using System;
using System.Data;
using System.Net.Http.Headers;
using System.Threading.Tasks.Dataflow;

int choice = -1;
while (choice != 5)
{
    Console.WriteLine("Please select one of the following choices");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    Console.Write("What would you like to do? ");
    choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
       journalPrompts.Prompt();
       string prompt = journalPrompts.Prompt();
       Console.WriteLine(prompt);
       userInput.Input(prompt);
    }

    if (choice == 2)
    {
        userInput.Display();
    }

    if (choice == 3)
    {
        Console.Write("Enter the path of the file to load: ");
        string filePath = Console.ReadLine();
        journalFile.loadFromFile(filePath, userInput.EntryList);
    }

    if (choice == 4)
    {
        journalFile.Save(userInput.EntryList);
    }
}
