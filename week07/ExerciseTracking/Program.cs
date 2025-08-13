using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),    // 4.8 km
            new Cycling(new DateTime(2022, 11, 3), 40, 20.0),   // 20 kph
            new Swimming(new DateTime(2022, 11, 3), 25, 20)     // 20 laps
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
