using System;

namespace Lesson4_3
{
    class Program
    {
        public enum Season //Времена года
        {
            None, Winter, Spring, Summer, Autum
        }

       
        /// <summary>
        /// Принимает цифру от 1 до 12. Возвращает время года на английском языке
        /// </summary>
        /// <param name="seasonNumber"></param>
        /// <returns></returns>
        static string userSeason (int seasonNumber)
        {

            Season mySeason = Season.None;

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
            
            
            return mySeason.ToString();
           
        }
        /// <summary>
        /// Переводит английское время года в русское
        /// </summary>
        /// <param name="uSeason"></param>
        /// <returns></returns>
        static  string ruSeason (string uSeason)
        {
            string rusSeason = null;
            switch (uSeason)
            {
              case "Winter":
                    rusSeason = "Зима";
                    break;
                case "Spring":
                    rusSeason = "Весна";
                    break;
                case "Summer":
                    rusSeason = "Лето";
                    break;
                case "Autum":
                    rusSeason = "Осень";
                    break;
            }

            return rusSeason;
        }

        static void Main(string[] args)
        {
            //Запрашиваем у пользователя номер месяца. 
            Console.WriteLine("Введите номер месяца: ");
            int seasonNumber = int.Parse(Console.ReadLine());
            //передаём число пользователя в функцию которая определит время года
            string uSeason = userSeason(seasonNumber);
            //передаём время года в функцию которая переведёт его на русский язык
            string rusSeason = ruSeason(uSeason);

            //Выводим Время года соответствующее номеру месяца пользователя
            Console.WriteLine("Ваш сезон: " + rusSeason);
        }
    }
}
