using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            static string GetFullName(string firstName, string lastName, string patronymic)
            {
                return firstName + " " + lastName + " " + patronymic ; 
            }

            string[] peoples = new string[4];
            for (int i = 0; i < peoples.Length; i++)
            {
                Console.WriteLine($"Данные {i+1}-го человека");
                Console.WriteLine("Введите Фамилию: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Введите Имя: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Введите Отчество: ");
                string patronymic = Console.ReadLine();
                Console.WriteLine();

                peoples[i] = GetFullName(firstName, lastName, patronymic);

            }
            Console.WriteLine("Ваша записная книжка: ");
            for (int i = 0; i < peoples.Length; i++)
            {
                Console.WriteLine(peoples[i]);
            }
            
        }
    }
}
