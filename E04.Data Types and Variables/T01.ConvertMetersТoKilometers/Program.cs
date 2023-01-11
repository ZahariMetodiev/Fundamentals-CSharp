using System;

namespace Т01.ConvertMetersТoKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double kilometers = meters / 1000;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
