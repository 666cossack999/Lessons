using System;

namespace Lesson4_4
{
    class Program
    {
        static void Main(string[] args)
        {    
            ///Рекурсивная функция принимающая значение и возвращающая для него число Фибоначчи
            static int goldenRatio(int number)
            {   //F(number) = F(number-1) + F(number-2) 
                return number < 2 ? number : goldenRatio(number - 1) + goldenRatio(number - 2);
            }  
           
            Console.WriteLine("Введите число для которого хотите вычислить последовательность Фибоначчи: ");
            int userNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Число Фибоначчи для вашего значения = " + goldenRatio(userNumber));

            Console.ReadLine();
        }
    }
}
