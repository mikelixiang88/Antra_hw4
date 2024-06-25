using System;

namespace GreetingApp
{
    class GreetingApp
    {
        static void Main(string[] args)
        {
            // You can test with a specific time by uncommenting the following line
            // DateTime currentTime = new DateTime(2024, 6, 24, 14, 30, 0); // Example: 2:30 PM
            DateTime currentTime = DateTime.Now; // Use current time for actual use
            int currentHour = currentTime.Hour;

            if (currentHour >= 5 && currentHour < 12)
            {
                Console.WriteLine("Good Morning");
            }

            if (currentHour >= 12 && currentHour < 17)
            {
                Console.WriteLine("Good Afternoon");
            }

            if (currentHour >= 17 && currentHour < 21)
            {
                Console.WriteLine("Good Evening");
            }

            if ((currentHour >= 21 && currentHour <= 23) || (currentHour >= 0 && currentHour < 5))
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}