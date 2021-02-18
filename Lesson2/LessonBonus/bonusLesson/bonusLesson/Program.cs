using System;

namespace bonusLesson
{
    class Program
    {   
        //функция проверяющая високосный год или нет, выводит результат в консоль.
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
                //Запрашиваем год у пользователя и присваиваем его переменной year.
                Console.WriteLine("Введите год, чтобы узнать високосный он или нет: ");
                int year = int.Parse(Console.ReadLine());

                //Передаём год пользователя в функцию LeapYear
                LeapYear(year);
            }
        }
    }
}
