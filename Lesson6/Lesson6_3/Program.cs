using System;

namespace Lesson6_3
{
    class Program
    {
        /// <summary>
        /// Метод считает сумму элементов массива с обработкой ошибок
        /// </summary>
        /// <param name="array">массив 4Х4</param>
        /// <returns>возвращает сумму элементов массива</returns>
        static int MyArray(string[,] array)
        {
            int sum = 0;

            if (array.GetLength(0) != 4 || array.GetLength(1) != 4)
            {
                throw new MyArraySizeException();
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    try
                    {
                        sum += Convert.ToInt32(array[i, j]);
                    }
                    catch (Exception e)
                    {
                        throw new MyArrayDataExceptions(i, j);
                    }
                    
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //Наш массив 4Х4
            string[,] UserArray = {
                                 { "1","2","3","4"},
                                 {"5","6","7","8" },
                                 {"9","10","11","12"},
                                 {"13","14","15","16"},
                                 };
            
            try
            {
                try
                {
                    int result = MyArray(UserArray);                         //передаём наш массив в метод MyArray, который посчитает сумму элементов массива
                    Console.WriteLine($"Сумма всех ячеек равна: {result}");
                }
                catch (MyArraySizeException e)
                {
                    Console.WriteLine("Размер массива превышен!");
                }
            }
            catch (MyArrayDataExceptions e)
            {
                Console.WriteLine("Неправильное значение в массиве!");
                Console.WriteLine($"Ошибка в ячейке: {e.i}X{e.j}");
            }                
            
    }
    }
}



