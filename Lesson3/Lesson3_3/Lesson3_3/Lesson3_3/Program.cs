using System;

namespace Lesson3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любую строку: ");
            string userString = Console.ReadLine();

            for (int i = userString.Length - 1  ; i >= 0; i--)
            {
                Console.Write(userString[i]);
            }

            Console.ReadLine();
        }
    }
}
