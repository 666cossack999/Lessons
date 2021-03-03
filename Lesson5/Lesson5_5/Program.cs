using System;
using System.IO;
using System.Text.Json;

namespace Lesson5_5
{
    class Program
    {
        static To_Do NewTitle()
        {
            var title = new To_Do();
            title.Title = "Посмотреть вебинар";

            return title;
        }

        static void Main(string[] args)
        {
            var title1 = NewTitle();
            var title2 = NewTitle();

            string tasks = JsonSerializer.Serialize(title1);            
            tasks += JsonSerializer.Serialize(title2);
            File.WriteAllText("To_Do.json", tasks);

            Console.ReadLine();

        }
    }
}
