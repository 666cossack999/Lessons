using System;
using System.IO;


namespace Lesson5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "sturtup.txt"; //имя файла
            File.WriteAllText(filename, DateTime.Now.ToString()); //сохраняем дату в файл.
        }
    }
}
