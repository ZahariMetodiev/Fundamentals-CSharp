using System;

namespace T03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;

            switch (groupType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.8;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.5;
                            break;
                    }
                    break;
            }
            double totalPrice = price * peopleCount;

            if (groupType == "Students" && peopleCount >= 30)
            {
                totalPrice *= 0.85;
            }
            else if (groupType == "Business" && peopleCount >= 100)
            {
                totalPrice -= price * 10;
            }
            else if (groupType == "Regular" && (peopleCount >= 10 && peopleCount <= 20))
            {
                totalPrice *= 90;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
