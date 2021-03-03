using System;
using System.IO;

namespace Lesson5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "My.txt"; //имя файла
            Console.WriteLine("Введите сообщение, которое хотите записать в файл: ");
            string filetext = Console.ReadLine(); //считываем текст введённый с клавиатуры
            File.WriteAllText(filename, filetext); //сохраняем текст с клавиатуры в файл


        }
    }
}
