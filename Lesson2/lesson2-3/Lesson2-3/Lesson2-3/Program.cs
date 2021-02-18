using System;

namespace Lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userNumber;
            int number;

            //Зацикливание программы пока пользователь не введёт верные данные
            while (true)
            {
                //Зацикливание программы пока пользователь не введёт цифры
                do
                {
                    //Запрашиваем у пользователя число и сохраняем в переменную userNumber
                    Console.Write("Введите любое число: ");
                    userNumber = Console.ReadLine();

                } while (int.TryParse(userNumber, out number) == false);

                if (number % 2 == 0)
                {
                    Console.WriteLine("Ваше число число чётное!");
                    break;
                } else {
                    Console.WriteLine("Ваше число нечётное!");
                    break;
                }
                
            }


            //Чтобы программа не закрылась сразу после вывода
            Console.ReadLine();
        }
    }
}
