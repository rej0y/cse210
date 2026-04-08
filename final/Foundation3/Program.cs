using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events =
        [
            new LectureEvent(
                title: "Modern Software Architecture",
                description: "An overview of scalable system design",
                dateTime: new DateTime(2026, 5, 12, 18, 30, 0),
                address: new Address(
                    street: "100 Tech Blvd",
                    city: "Seattle",
                    stateOrProvince: "WA",
                    country: "USA"
                ),
                speaker: "Dr. Emily Chen",
                capacity: 120
            ),

            new ReceptionEvent(
                title: "Alumni Networking Night",
                description: "Connect with graduates and professionals",
                dateTime: new DateTime(2026, 5, 20, 19, 0, 0),
                address: new Address(
                    street: "250 Main St",
                    city: "Salt Lake City",
                    stateOrProvince: "UT",
                    country: "USA"
                ),
                rsvpEmail: "rsvp@alumni.org"
            ),

            new OutdoorGatheringEvent(
                title: "Summer Community Picnic",
                description: "Food, games, and outdoor fun",
                dateTime: new DateTime(2026, 6, 8, 12, 0, 0),
                address: new Address(
                    street: "75 Park Lane",
                    city: "Boise",
                    stateOrProvince: "ID",
                    country: "USA"
                ),
                weather: "Sunny"
            ),
        ];

        foreach (Event e in events)
        {
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine();
        }
    }
}