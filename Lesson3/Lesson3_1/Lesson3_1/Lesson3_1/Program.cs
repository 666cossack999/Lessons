using System;

namespace Lesson3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаём двумерный массив 6,6
            int[,] myMass = new int [6,6];
            //Внешний цикл заполнения столбцов и перехода на новую строку
            for (int i = 0; i < myMass.GetLength(0) ; i++)
            {
                //внутренний цикл заполнения строк
                for (int j = 0; j < myMass.GetLength(1); j++)
                {
                    //условие для заполнения только диаганали
                    if (i==j)
                    {
                        Console.Write(myMass[i, j] + " ");
                    } else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
            
        }
    }
}
