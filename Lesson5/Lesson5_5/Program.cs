using System;
using System.IO;
using System.Text.Json;

namespace Lesson5_5
{
    
    class Program
    {
        
        private static bool JsonFlag;

        /// <summary>
        /// создаёт новый объект класса (новую заметку)
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        static To_Do NewTitle(string title)
        {
            var userTitle = new To_Do();
            userTitle.Title = title;
            userTitle.IsDone = false;

            return userTitle;
        }
        /// <summary>
        /// Дописывает заметку в файл To_Do.json
        /// </summary>
        /// <param name="title"></param>
        static void TitleToJson(To_Do title)
        {
            string tasks = JsonSerializer.Serialize(title);
            if (JsonFlag == true)
            {
                File.AppendAllText("To_Do.json", "|" + tasks);
            }
            else
            {
                File.AppendAllText("To_Do.json", tasks);
                JsonFlag = true;
            }
             


        }
        /// <summary>
        /// Десериализует файл To_Do.json
        /// </summary>
        /// <returns>двумерный массив с данными из To_Do.json</returns>
        static string[,] JsonToTitle()
        {
            int i = 0;                                                  //счётчик для заполнения массива titlesArray
            string json = File.ReadAllText("To_Do.json");               //путь к файлу json
            string[] jsonArray = json.Split('|');                       //разбиваем json на массив
            string[,] titlesArray = new string[jsonArray.Length, 2];    //создаём новый массив где будут храниться сериализованные файлы

            //заполняем массив titlesArray данными из файла To_Do.json
            foreach (var item in jsonArray)
            {                
                To_Do title = JsonSerializer.Deserialize<To_Do>(item);
                if (title.IsDone == true)
                {
                    titlesArray[i, 0] = "[X]";
                } else
                {
                    titlesArray[i, 0] = "[ ]";
                }
                                  
                titlesArray[i, 1 ] = title.Title;

                i++;               

            }

            return titlesArray;
        }

        /// <summary>
        /// Главное меню 
        /// 1.Вывести список задач
        /// 2.Добавить задачу
        /// 3.Выход
        /// </summary>
        static void StartProgramm()
        {
            while (true)
            {

                string[,] titlesArray = JsonToTitle();

                Console.WriteLine("Введите действие: \n1.Вывести список задач \n2.Добавить задачу \n3.Выход \n");


                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        PrintTasks(titlesArray);
                        break;

                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Введите задание которое хотите добавить в список: \n");          //запрашиваем у пользователя 
                        string userTitle = Console.ReadLine();                                              //информацию

                        var title = NewTitle(userTitle);                                                    //создаём новое задание
                        TitleToJson(title);                                                                 //Дописываем задание в файл To_Do.json
                        
                        break;

                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ошибка. Нажмите цифру от 1 до 3\n");
                        break;
                }

            }
        }
        static void PrintTasks(string[,] array)
        {
            Console.Clear();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{i+1}: ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Введите номер задачи которую вы выполнили: ");

        }

        static void Main(string[] args)
        {
            
            if (File.Exists("To_Do.json"))
            {
                JsonFlag = true;
                Console.WriteLine("Найдена база данных!\n");                
                                                            
                
            } else
            {
                JsonFlag = false;
                Console.WriteLine("Базы данных нет\n");
            }
            
            StartProgramm();        

           

        }
    }
}
