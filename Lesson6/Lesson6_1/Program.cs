using System;
using System.IO;

namespace Lesson5_4
{
    class Program
    {
        /// <summary>
        /// Принимает путь к директории, и путь к файлу файл Directories.txt в который
        /// сохраняет дерево каталогов и файлов
        /// </summary>
        /// <param name="workDir"></param>
        static void DirToFile (string workDir, string notesPath)
        {
            //Перечень всех файлов и папок, вложенных в workDir
            string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories); 

            File.WriteAllText(notesPath, $"Файлы содержащиеся в директории: {workDir} \n\n");

            //Записываем в файл Directories.txt данные из массива entries
            File.AppendAllLines(notesPath, entries);
        }

        /// <summary>
        ///  Принимает путь к директории, и путь к файлу файл Directories.txt в который
        ///  сохраняет дерево каталогов и файлов РЕКУРСИВНО
        /// </summary>
        /// <param name="path"></param>
        /// <param name="notesPath"></param>
        static void DirToFileRecursive(string path,string notesPath)
        {

            

            string[] array = Directory.GetFileSystemEntries(path, "*", SearchOption.TopDirectoryOnly);
            //Получаем список директорий по пути Path
            string[] target = Directory.GetDirectories(path);

            //Вызываем рекурсивную функцию для каждого пути target
            foreach (var item in target)
            {
                DirToFileRecursive(item,notesPath);
            }

            //Записываем в файл Directories.txt данные из массива array
            File.AppendAllLines(notesPath, array);

        }
        static void Main(string[] args)
        {
            
            //Запрашиваем у пользователя путь
            Console.WriteLine("Введите директорию, дерево каталогов и файлов которой хотите получить: ");
            //string workDir = Console.ReadLine();
            string workDir = @"C:\tmp";

            string notesDir = Path.Combine(workDir, "Directory"); //присваиваем переменной путь workDir\Directory
            Directory.CreateDirectory(notesDir);                  //создаём вложенную директорию            

            string notesPath = Path.Combine(notesDir, "Directories2.txt"); //присваиваем переменной путь к файлу

            //передаём путь в функцию, нужную функцию раскомментировать
            DirToFile(workDir, notesPath);              //Без рекурсии
            //DirToFileRecursive(workDir,notesPath);      //С рекурсией
            
            Console.WriteLine("Готово");
            Console.ReadLine();
        }
    }
}
