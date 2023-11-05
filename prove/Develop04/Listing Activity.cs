// ListingActivity class
public class ListingActivity : Activity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you list positive aspects of your life.") { }

    public override void Start()
    {
        Console.WriteLine($"Welcome to {Name} - {Description}");
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready to start in 3 seconds...");
        PauseWithSpinner(3);

        string prompt = listingPrompts[new Random().Next(listingPrompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("Start listing items:");

        DateTime startTime = DateTime.Now;
        int itemsCount = 0;

        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            string item = Console.ReadLine();
            itemsCount++;
        }

        Console.WriteLine($"You listed {itemsCount} items.");
        Console.WriteLine("Great job! You've completed the Listing Activity for {0} seconds.", Duration);
        PauseWithSpinner(3);
    }
}
