using System;
class Program
{
    static void Main()
    {
        Address address1 = new Address { Street = "123 Main St", City = "New York", State = "NY", ZipCode = "12345" };
        Address address2 = new Address { Street = "456 Second St", City = "Provo", State = "UT", ZipCode = "67890" };
        Address address3 = new Address { Street = "789 Third St", City = "Idaho", State = "ID", ZipCode = "45678" };
        Address address4 = new Address { Street = "1011 Fourth St", City = "Ohio", State = "OH", ZipCode = ""};

        Event genericEvent = new Event("Family Event", "Come and join us for our family reunion this year!", DateTime.Now, new TimeSpan(3, 30, 0), address1);
        Lecture lectureEvent = new Lecture("Business Lecture", "We have a speaker coming to talk about improving our investments.", DateTime.Now.AddDays(7), new TimeSpan(9, 0, 0), address2, "John Smith", 100);
        Reception receptionEvent = new Reception("Wedding Reception", "Please come and celebrate the newly weds", DateTime.Now.AddDays(14), new TimeSpan(20, 0, 0), address3, "rsvp@gmail.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Scout Camping Trip", "Come and join us for our monthly outdoor camping trip!", DateTime.Now.AddDays(21), new TimeSpan(11, 30, 0), address4, "Bring your sunscreen!");

                Console.WriteLine("Choose an event type:");
        Console.WriteLine("1. Generic Event");
        Console.WriteLine("2. Lecture Event");
        Console.WriteLine("3. Reception Event");
        Console.WriteLine("4. Outdoor Event");

        int eventTypeChoice = int.Parse(Console.ReadLine());

        Event selectedEvent = null;

        switch (eventTypeChoice)
        {
            case 1:
                selectedEvent = genericEvent;
                break;
            case 2:
                selectedEvent = lectureEvent;
                break;
            case 3:
                selectedEvent = receptionEvent;
                break;
            case 4:
                selectedEvent = outdoorEvent;
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting.");
                return;
        }

        Console.WriteLine("Choose details type:");
        Console.WriteLine("1. Standard Details");
        Console.WriteLine("2. Full Details");
        Console.WriteLine("3. Short Description");

        int detailsChoice = int.Parse(Console.ReadLine());

        string detailsOutput = "";

        switch (detailsChoice)
        {
            case 1:
                detailsOutput = selectedEvent.GetStandardDetails();
                break;
            case 2:
                detailsOutput = selectedEvent.GetFullDetails();
                break;
            case 3:
                detailsOutput = selectedEvent.GetShortDescription();
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting.");
                return;
        }

        Console.WriteLine(detailsOutput);
    }
}