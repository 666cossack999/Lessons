using System;

namespace Lesson3_2
{
    class Program
    {
        
        
        static string[,] AddContacs(string[,] Array)
        {
            
            

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                Console.WriteLine("Введите имя: ");
                Array[i,0] = Console.ReadLine();
                Console.WriteLine("Введите номер телефона/email: ");
                Array[i, 1] = Console.ReadLine();                               
            }
            return Array;
        }

        static void PrintContacts(string[,] Array)
        {

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write(Array[i,j] + "  ");
                }
                Console.WriteLine();
            }

            
        }



        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.Write("Привет! Это телефонный справочник. Введи кол-во контактов, сколько ты хочешь заполнить: ");
            } while (!int.TryParse(Console.ReadLine(), out n));


            string[,] contacts = new string[n, 2];
           

            AddContacs(contacts);
            Console.WriteLine();
            Console.WriteLine("Ваш список:");
            PrintContacts(contacts);

        }
    }
}
