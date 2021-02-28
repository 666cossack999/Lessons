using System;

namespace Lesson4_3
{
    class Program
    {
        public enum Season //Времена года
        {
            None, Winter, Spring, Summer, Autum
        }
        static void Main(string[] args)
        {
            Season mySeason = Season.None;
            //Запрашиваем у пользователя номер месяца. 
            Console.WriteLine("Введите номер месяца: ");
            int seasonNumber = int.Parse(Console.ReadLine());

            switch (seasonNumber)
            {
                case 1:
                case 2:
                case 12:
                    mySeason = Season.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    mySeason = Season.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    mySeason = Season.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    mySeason = Season.Autum;
                    break;
                default:
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                    break;
            }
            //Выводим Время года соответствующее номеру месяца пользователя
            Console.WriteLine(mySeason);
        }
    }
}
