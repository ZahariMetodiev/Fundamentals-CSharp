using System;

namespace T05.MonthPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] months = new string[]
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            if (n <= 0 || n >= 13)
            {
                Console.WriteLine("Error!");
                return;
            }

            Console.WriteLine(months[n - 1]);
        }
    }
}
