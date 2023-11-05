using System;
using System.Threading;

// ReflectionActivity class
public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on your past experiences.") { }

    public override void Start()
    {
        Console.WriteLine($"Welcome to {Name} - {Description}");
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready to start in 3 seconds...");
        PauseWithSpinner(3);

        Random rand = new Random();
        for (int i = 0; i < Duration; i += reflectionQuestions.Length)
        {
            string prompt = prompts[rand.Next(prompts.Length)];
            Console.WriteLine(prompt);

            foreach (var question in reflectionQuestions)
            {
                Console.WriteLine(question);
                PauseWithSpinner(3);
            }
        }

        Console.WriteLine("Great job! You've completed the Reflection Activity for {0} seconds.", Duration);
        PauseWithSpinner(3);
    }
}
