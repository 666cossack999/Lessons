using System;

namespace Lesson2_5
{
    class Program
    {
        //функция запрашивающая у пользователя минимальную и максимальную температуру за день у пользователя и считающая среднюю температуру.
        static  int averageTemp()
        {
            string minTemp, maxTemp;   //  переменные для минимального 
            int i, a;                  //  и максимального значения температуры

            do
            {
                //Запрашиваем у пользователя минимальную температуру и сохраняем её в переменную minTemp
                Console.WriteLine("Какая была сегодня минимальная температура? ");
                minTemp = Console.ReadLine();
            } while (int.TryParse(minTemp, out i) == false);

            do
            {
                //Запрашиваем у пользователя максимальную температуру и сохраняем её в переменную maxTemp
                Console.WriteLine("Какая была сегодня максимальная температура? ");
                maxTemp = Console.ReadLine();
            } while (int.TryParse(maxTemp, out a) == false);

            //Считаем среднесуточную температуру по формуле (min+max)/2 и выводит результат в консоль.
            int avrTemp = ((i + a) / 2);            
            Console.WriteLine("Среднесуточная температура за сегодня: " + avrTemp);
            
            return avrTemp;
        }


        static void Main(string[] args)
        {         

            //вызываем функцию подсчёта средней температуры averageTemp. Среднюю температуру присваиваем переменной avrTemp.
            int avrTemp = averageTemp();
        }
    }
}
