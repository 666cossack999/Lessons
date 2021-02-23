using System;

namespace Lesson3_5
{
    class Program
    {
        //функция создания массива
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
        //функция вывода массива на консоль
        static void printArray(string[] array)
        {
            
            for (int  i = 0;  i < array.Length;  i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n\n");
        }
        //Функция смещения элементов массива на n элементов. Возваращает смещённый массив
        static string[] moveArray(string[] array, int n)
        {
            //Если n > 0 - смещаем вправо
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    string first = array[0];
                    string last = array[array.Length - 1];
                    for (int j = array.Length - 1; j > 0; j--)
                    {
                        if (j == 1)
                        {
                            array[j] = array[j - 1];
                            array[1] = first;
                        }
                        else
                        {
                            array[j] = array[j - 1];
                            array[0] = last;
                        }
                    }

                }
            } else {
                //Если n < 0 - смещаем влево
                for (int i = 0; i > n; i--)
                {
                    string first = array[0];
                    string last = array[array.Length - 1];
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        if (j == array.Length - 2)
                        {
                            array[j] = last;
                            
                        }
                        else
                    {
                        array[j] = array[j + 1];
                        array[array.Length - 1] = first;
                    }
                }

                }

            }

            return array;
        }

        static void Main(string[] args)
        {
            //Зацикливаем программу для удобства
            while (true)
            { 
                //создаём массив
                string[] myArray = arrayCreate();

                //Запрашиваем у пользователя число - на какое кол-во элементов сместить массив
                Console.WriteLine("Введите число от -10 до 10, для смещения элементов массива: ");
                int n = int.Parse(Console.ReadLine());

                //Выводим первоначальный массив на консоль
                Console.WriteLine("\n\nВаш массив: ");
                printArray(myArray);
                //смещаем массив
                moveArray(myArray, n);
                //выводим на консоль смещённый массив
                Console.WriteLine("\n\nСмещённый массив: ");
                printArray(myArray);
            }
            
        }
    }
}
