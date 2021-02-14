using System;

namespace Lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userMonth;
            int n;           
            
            //Зацикливание программы пока пользователь не введёт верные данные
            while (true)
            {
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
                    //Создаём новую дату month с месяцем пользователя
                    DateTime month = new DateTime(2021, n, 1);
                    //Выводим месяц в буквенном формате
                    Console.WriteLine("Ваш месяц: " + month.ToString("MMMM"));
                    break;

                }
                else
                {
                    Console.WriteLine("введите номер месяца от 1 до 12: ");
                   
                }
            }


            //Чтобы программа не закрылась сразу после вывода
            Console.ReadLine();
        }
    }
}
