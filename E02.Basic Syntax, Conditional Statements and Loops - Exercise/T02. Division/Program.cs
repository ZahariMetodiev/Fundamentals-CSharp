using System;

namespace T02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string division = string.Empty;

            if (number % 10 == 0)
            {
                division = "10";
            }
            else if (number % 7 == 0)
            {
                division = "7";
            }
            else if (number % 6 == 0)
            {
                division = "6";
            }
            else if (number % 3 == 0)
            {
                division = "3";
            }
            else if (number % 2 == 0)
            {
                division = "2";
            }
            else
            {
                Console.WriteLine("Not divisible");
                return;
            }

            Console.WriteLine($"The number is divisible by {division}");
        }
    }
}
