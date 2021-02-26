using System;

namespace Lesson4_3
{
    class Program
    {
        public enum Season : int
        {
            Winter = 12,
            Spring = 3,
            Summer = 6,
            Autumn = 9
        }
        static void Main(string[] args)
        {
            string userMonth;
            int n;
            //Зацикливание программы пока пользователь не введёт цифры
            do
            {
                //Запрашиваем у пользователя номер месяца и сохраняем в переменную userMonth
                Console.Write("Введите номер месяца: ");
                userMonth = Console.ReadLine();

            } while (int.TryParse(userMonth, out n) == false);
            //проверка пользовательских данных.номер месяца должен быть от 1 до 12
            if (0 < n && n <= 12)
            {
                //Вывод сезона
                if (n <= 2 || n >= 12)
                {
                    Console.WriteLine(Season.Winter);
                }
                else if (n >= 3 || n <= 5)
                {
                    Console.WriteLine(Season.Spring);
                }
                else if (n >= 6 || n <= 8)
                {
                    Console.WriteLine(Season.Spring);
                }
                
                else if (n >= 9 || n <= 11)
                {
                    Console.WriteLine(Season.Autumn);
                }

            }
            else
            {
                Console.WriteLine("введите номер месяца от 1 до 12: ");

            }
        }
    }
}
