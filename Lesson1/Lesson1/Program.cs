using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запрашиваем у пользователя имя и сохраняем его в переменную name
            Console.Write("Как тебя зовут? ");
            string name = Console.ReadLine();

            //Выводим приветствие с именем пользователя и настоящей датой.
            Console.WriteLine($"Привет,  {name} , сегодня {DateTime.Today.ToLongDateString()}");

            //Что-бы окно не закрылось сразу после воода.
            Console.ReadLine();
        }
    }
}
