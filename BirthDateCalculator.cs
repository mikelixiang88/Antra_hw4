using System;

namespace BirthDateCalculator
{
    class BirthDateCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birth date (yyyy-mm-dd): ");
            string input = Console.ReadLine();
            DateTime birthDate;

            if (DateTime.TryParse(input, out birthDate))
            {
                DateTime currentDate = DateTime.Now;
                TimeSpan ageSpan = currentDate - birthDate;
                int daysOld = (int)ageSpan.TotalDays;

                Console.WriteLine($"You are {daysOld} days old.");

                int daysToNextAnniversary = 10000 - (daysOld % 10000);
                DateTime nextAnniversaryDate = currentDate.AddDays(daysToNextAnniversary);

                Console.WriteLine($"Your next 10,000-day anniversary will be on {nextAnniversaryDate:yyyy-MM-dd}.");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter the date in yyyy-mm-dd format.");
            }
        }
    }
}