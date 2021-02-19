using System;

namespace Lesson3_5
{
    class Program
    {

        static string[] arrayCreate ()
        {
            Console.WriteLine("Введите кол-во элементов в массиве");
            int Counts = int.Parse(Console.ReadLine());
            string[] array = new string[Counts];

            for (int i = 0; i < Counts; i++)
            {
                Console.WriteLine($"Введите элемент массива № {i}: ");
                array[i] = Console.ReadLine();
            }
            return array;
        }

        static void printArray(string[] array)
        {
            Console.WriteLine("\n\nВаш массив: ");
            for (int  i = 0;  i < array.Length;  i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n\n");
        }


        static void Main(string[] args)
        {
           string[] myArray = arrayCreate();

            Console.WriteLine("Введите число от -10 до 10, для смещения элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            printArray(myArray);

        }
    }
}
