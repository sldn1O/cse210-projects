using System;

public class journalPrompts
{
    public static string Prompt()
    {
        Random rd = new Random();
        int randNum = rd.Next(1, 6);

        string prompt = "";

        if (randNum == 1)
        {
            prompt = "What was the best thing that happened today?";
        }
        else if (randNum == 2)
        {
            prompt = "What was the most challenging thing I faced today?";
        }
        else if (randNum == 3)
        {
            prompt = "What am I grateful for today?";
        }
        else if (randNum == 4)
        {
            prompt = "What did I do today that I am proud of?";
        }
        else if (randNum == 5)
        {
            prompt = "What did I learn today?";
        }

        return prompt;
    }

}