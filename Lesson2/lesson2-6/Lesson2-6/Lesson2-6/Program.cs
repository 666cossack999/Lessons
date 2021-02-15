using System;

namespace Lesson2_6
{
    class Program
    {
        //Присваиваем дням недели битовые значения.
        [Flags]
        public enum DAYS : int
        {
            monday    = 0b0000001,
            tuesday   = 0b0000010,
            wednesday = 0b0000100,
            thursday  = 0b0001000,
            friday    = 0b0010000,
            saturday  = 0b0100000,
            sunday    = 0b1000000,
        }
        static void Main(string[] args)
        {

            //Присваиваем график первому офису
            DAYS office1 = (DAYS)0b0011110;
            //Присваиваем график второму офису
            DAYS office2 = (DAYS)0b1111111;

            //Выводим график работы 1го офиса
            Console.WriteLine("Рабочие дни первого офиса: " + office1);
            Console.WriteLine();
            //Выводим график работы 2го офиса
            Console.WriteLine("Рабочие дни второго офиса: " + office2);
            Console.ReadLine();
        }
    }
}
