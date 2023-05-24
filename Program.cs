using System;

namespace Car_Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the applicant's age
            Console.WriteLine("What is your age?");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            // Ask if the applicant has ever had a DUI
            Console.WriteLine("Have you ever had a DUI? (true/false)");
            string duiInput = Console.ReadLine();
            bool hasDUI = Convert.ToBoolean(duiInput);

            // Ask number of speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsInput = Console.ReadLine();
            int speedingTickets = Convert.ToInt32(ticketsInput);

            // Check if the applicant qualifies for car insurance
            bool isQualified = age > 15 && !hasDUI && speedingTickets <= 3;

            // Print result
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);

        }
    }
}
