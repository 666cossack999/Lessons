using System;

namespace Lesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запрашиваем у пользователя минимальную температуру и сохраняем её в переменную minTemp
            Console.WriteLine("Какая была сегодня минимальная температура? ");
            int minTemp = int.Parse(Console.ReadLine());
            //Запрашиваем у пользователя максимальную температуру и сохраняем её в переменную maxTemp
            Console.WriteLine("Какая была сегодня максимальная температура? ");
            int maxTemp = int.Parse(Console.ReadLine());
            //Считаем среднесуточную температуру по формуле (min+max)/2 и выводит результат в консоль.
            Console.WriteLine("Среднесуточная температура за сегодня: " + ((minTemp+maxTemp)/2));
            //Чтобы программа не закрывалась сразу после вывода информации
            Console.ReadLine();
        }
    }
}
