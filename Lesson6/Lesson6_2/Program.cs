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
        /// <param name="title">Принимает строку для содания объекта класса</param>
        /// <returns></returns>
        static To_Do NewTitle(string title)
        {
            var userTitle = new To_Do();
            userTitle.Title = title;
            userTitle.IsDone = false;

            return userTitle;
        }
        /// <summary>
        /// Функция изменяет объект класса
        /// </summary>
        /// <param name="title"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        static To_Do TitleEdit(string title, bool flag)
        {
            var userTitle = new To_Do();
            userTitle.Title = title.Split(" ")[1];
            userTitle.IsDone = flag;

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
                File.WriteAllText("To_Do.json", tasks);
                JsonFlag = true;
            }
             


        }
        /// <summary>
        /// Десериализует файл To_Do.json
        /// </summary>
        /// <returns>массив с данными из To_Do.json</returns>
        static string[] JsonToTitle()
        {
                                                             //счётчик для заполнения массива titlesArray
            try
            {
                int i = 0;
                string json = File.ReadAllText("To_Do.json");               //путь к файлу json
                string[] tempArray = json.Split('|');                       //разбиваем json на массив
                string[] jsonArray = new string[tempArray.Length];
                foreach (var item in tempArray)
                {
                    To_Do task = JsonSerializer.Deserialize<To_Do>(item);

                    jsonArray[i] = task.IsDone + " " + task.Title;
                    i++;
                }

                return jsonArray;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;                
            }
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
                //Console.Clear();
                Console.WriteLine("Введите действие: \n1.Вывести список задач \n2.Добавить задачу \n3.Удалить выполненые задачи \n4.Выход \n");

                
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        string[] titlesArray = JsonToTitle();
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
                        TasksRemove();
                        Console.WriteLine("Выполненые задания удалены.\n");
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ошибка. Нажмите цифру от 1 до 3\n");
                        break;
                }

            }
        }
        /// <summary>
        /// Печатает текущий массив
        /// </summary>
        /// <param name="array">массив строк</param>
        static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                if (array[i].Split(" ")[0] == "True")
                {
                    Console.Write((array[i].Split(" ")[0] = "[X]\t") + (array[i].Split(" ")[1]));
                }
                else
                {
                    Console.Write((array[i].Split(" ")[1] = "[ ]\t") + (array[i].Split(" ")[1]));
                }


                Console.WriteLine();

            }
        }
        /// <summary>
        /// Изменение состояния задачи, ставим [X] если выполнили задачу
        /// </summary>
        /// <param name="array"></param>
        static void TasksEdit(string[] array)
        {
            string userTasks;
            int n, i = 1;

            do
            {
                Console.WriteLine("Введите номер задачи которую вы выполнили\nили любую другую цифру для выхода в меню: ");

                userTasks = Console.ReadLine();
                JsonFlag = false;
            } while (int.TryParse(userTasks, out n) == false);
            

            



            foreach (var item in array)
            {
                if (n == i || item.Split(" ")[0] == "True")
                {
                    var title = TitleEdit(item, true);
                    TitleToJson(title);
                }
                else
                {
                    var title = TitleEdit(item, false);
                    TitleToJson(title);
                }
                i++;
            }
            array = JsonToTitle();
            PrintArray(array);
        }
        /// <summary>
        /// Выводит на консоль текущее состояние задач.
        /// </summary>
        /// <param name="array"></param>
        static void PrintTasks(string[] array)
        {
            
            if (array != null)
            {
                PrintArray(array);
                TasksEdit(array);
            } 
            else
            {
                Console.Clear();
                Console.WriteLine("База пуста");                
            }
            Console.WriteLine("\n");
            


        }
        
        /// <summary>
        /// Удаляет выполненые задачи
        /// </summary>
        static void TasksRemove()
        {
            
            string[] array = JsonToTitle();
            File.WriteAllText("To_Do.json", " ");
            JsonFlag = false;
            

            foreach (var item in array)
            {
                if (item.Split(" ")[0] == "False")
                {
                    var userTitle = new To_Do();
                    userTitle.Title = item.Split(" ")[1];
                    userTitle.IsDone = Convert.ToBoolean(item.Split(" ")[0]);
                    TitleToJson(userTitle);
                }
                else
                {
                    continue;
                }
                
            }
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
