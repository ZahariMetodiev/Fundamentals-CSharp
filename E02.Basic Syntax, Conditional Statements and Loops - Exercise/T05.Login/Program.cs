using System;
using System.Linq;

namespace T05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            
            int counter = 0;
            string input = Console.ReadLine();

            while (input != password)
            {
                Console.WriteLine("Incorrect password. Try again.");
                counter++;
                if (counter == 3)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }


                input = Console.ReadLine();
            }
        }
    }
}
