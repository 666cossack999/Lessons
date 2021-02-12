using System;

namespace Lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userMonth;
            int n;

            //Зацикливание программы пока пользователь не введёт данные от 1 до 12
            do
            {
                //Запрашиваем у пользователя номер месяца и сохраняем в переменную userMonth
                Console.Write("Введите номер месяца: ");
                userMonth = Console.ReadLine();

            } while (int.TryParse(userMonth, out n) == false);

                //Проверка пользовательских данных. Номер месяца должен быть от 1 до 12
                if (0 < n && n <= 12)
                {
                    //Создаём новую дату month с месяцем пользователя
                    DateTime month = new DateTime(2021, n, 1);
                    //Выводим месяц в буквенном формате
                    Console.WriteLine(month.ToString("MMMM"));
                    
                }
                else
                {
                    Console.WriteLine("Введено неверное значение");
                }

            
            
            
            Console.ReadLine();
        }
    }
}
