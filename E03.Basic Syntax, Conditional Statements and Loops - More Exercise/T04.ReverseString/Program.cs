using System;

namespace T04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] charArray = text.ToCharArray();
            string reverse = string.Empty;

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverse += charArray[i];
            }

            Console.WriteLine(reverse);
        }
    }
}
