﻿using System;

namespace T11.MultiplicationTable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num2 >= 10)
            {
                Console.WriteLine($"{num1} X {num2} = {num1 * num2}");
            }

            for (int i = num2; i <= 10; i++)
            {
                Console.WriteLine($"{num1} X {i} = {num1 * i}");
            }
        }
    }
}
