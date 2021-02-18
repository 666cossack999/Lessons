using System;

namespace Lesson2_5
{
    class Program
    {
        //функция запрашивающая у пользователя минимальную и максимальную температуру за день у пользователя и считающая среднюю температуру.
        static  float averageTemp()
        {
            string minTemp, maxTemp;   //  переменные для минимального 
            float i, a;                  //  и максимального значения температуры

            do
            {
                //Запрашиваем у пользователя минимальную температуру и сохраняем её в переменную minTemp
                Console.WriteLine("Какая была сегодня минимальная температура? ");
                minTemp = Console.ReadLine();
            } while (float.TryParse(minTemp, out i) == false);

            do
            {
                //Запрашиваем у пользователя максимальную температуру и сохраняем её в переменную maxTemp
                Console.WriteLine("Какая была сегодня максимальная температура? ");
                maxTemp = Console.ReadLine();
            } while (float.TryParse(maxTemp, out a) == false);

            //Считаем среднесуточную температуру по формуле (min+max)/2 и выводит результат в консоль.
            float avrTemp = ((i + a) / 2);            
            Console.WriteLine("Среднесуточная температура за сегодня: " + avrTemp);
            Console.WriteLine();
            
            return avrTemp;
        }

        //Функция запрашивающая у пользователя номер месяца, выводящая месяц в буквенном формате и возвращающая номер месяца
        static string userDate()
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
            Console.WriteLine();
            return userMonth;
        }

        //Функция проверки зимнего периода и температуры. Если месяц Декабрь, Январь или Февраль и температура > 0, выведется сообщение Дождливая зима.
        static void checkDate(int month, float temp)
        {
            if ((month == 1 || month == 2 || month == 12) && temp > 0 )
            {
                Console.WriteLine("Дождливая зима.");
            }
           
        }

        static void Main(string[] args)
        {
            //Вызываем функцию запроса номера месяца у пользователя userDate. Присваиваем месяц переменной uDate и выводим месяц в буквенном формате.
            int uDate = int.Parse(userDate());

            //вызываем функцию подсчёта средней температуры averageTemp. Среднюю температуру присваиваем переменной avrTemp.
            float avrTemp = averageTemp();

            //вызываем функцию проверки зимнего периода и температуры
            checkDate(uDate, avrTemp);

            //Чтобы программа не закрывалась после вывода информации.
            Console.ReadLine();

        }
    }
}
