using System;

namespace bonusLesson
{
    class Program
    {   
        static void LeapYear(int year)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine("Год високосный!");
            }
            else if (year % 100 != 0 && year % 4 == 0 )
            {
                Console.WriteLine("Год високосный!");
            }
            else
            {
                Console.WriteLine("Год не високосный.");
            }
            
            
        }

        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Введите год, чтобы узнать високосный он или нет: ");
                int year = int.Parse(Console.ReadLine());

                LeapYear(year);
            }
        }
    }
}
