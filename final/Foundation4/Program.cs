using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =
        [
            new RunningActivity(
                date: new DateTime(2026, 5, 10),
                lengthMinutes: 30,
                distance: 3.5
            ),
            
            new CyclingActivity(
                date: new DateTime(2026, 5, 11),
                lengthMinutes: 45,
                speed: 18.0
            ),

            new SwimmingActivity(
                date: new DateTime(2026, 5, 12),
                lengthMinutes: 40,
                laps: 30
            )
        ];

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
            Console.WriteLine();
        }
    }
}