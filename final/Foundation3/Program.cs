using System;

class Program
{

    private static Event[] events = new Event[3];


    private static void CreateTemplatedEvents()
    {

        Address addr1 = new Address("123 Main St", "Phoenix", "AZ", "85001");
        Address addr2 = new Address("55 Palm Way", "Miami", "FL", "33101");
        Address addr3 = new Address("890 Canyon Rd", "Denver", "CO", "80201");

        Lecture lecture = new Lecture("Space Exploration", "A deep dive into Mars missions", new DateTime(2025, 3, 20), new TimeSpan(18, 0, 0), addr1, "Dr. Hall", 150);
        Reception reception = new Reception("Networking Night", "Meet industry leaders", new DateTime(2025, 4, 5), new TimeSpan(19, 30, 0), addr2, "rsvp@events.com");
        OutdoorGathering outdoor = new OutdoorGathering("Summer BBQ", "Fun outdoor barbecue for families", new DateTime(2025, 6, 18), new TimeSpan(12, 0, 0), addr3, "Sunny, 78°F");

        events = new Event[3] { lecture, reception, outdoor };

    }
    static void Main(string[] args)
    {

        CreateTemplatedEvents();

        foreach (Event e in events)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("--------------------");
            Console.WriteLine();
        }
    }
}
