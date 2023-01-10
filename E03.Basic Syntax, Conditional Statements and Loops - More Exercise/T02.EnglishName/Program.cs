using System;

namespace T02.EnglishName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int lastDigit = number % 10;
            string output = string.Empty;

            if (lastDigit == 0)
            {
                output = "zero";
            }
            else if (lastDigit == 1)
            {
                output = "one";
            }
            else if (lastDigit == 2)
            {
                output = "two";
            }
            else if (lastDigit == 3)
            {
                output = "three";
            }
            else if (lastDigit == 4)
            {
                output = "four";
            }
            else if (lastDigit == 5)
            {
                output = "five";
            }
            else if (lastDigit == 6)
            {
                output = "six";
            }
            else if (lastDigit == 7)
            {
                output = "seven";
            }
            else if (lastDigit == 8)
            {
                output = "eight";
            }
            else if (lastDigit == 9)
            {
                output = "nine";
            }

            Console.WriteLine(output);
        }
    }
}
