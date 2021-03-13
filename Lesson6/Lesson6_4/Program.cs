using System;

namespace Lesson6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            employee[] persArray = new employee[5];
            persArray[0] = new employee("Ivanov", "Ivan", "Ivanovich", "Engineer", "ivivan@mailbox.com", "892312312", 30000, 30);
            persArray[1] = new employee("Соболев", "Илья", "Андреевич", "Ведущий инженер", "salya@mailbox.com", "892654651", 40000, 35);
            persArray[2] = new employee("Толпышев", "Святослав", "Игоревич", "Системный администратор", "sitolpishev@mailbox.com", "893168466", 120000, 40);
            persArray[3] = new employee("Малахов", "Иван", "Андреевич", "ИБ", "iamalahov@mailbox.com", "8-942-542-89-63", 130000, 45);
            persArray[4] = new employee("Слепенков", "Олег", "", "Программист 1С", "oslepenkov@mailbox.com", "8-942-542-84-63", 130000, 50);

            Console.WriteLine("Сотрудники старше 40 лет: ");
            for (int i = 0; i < persArray.Length; i++)
            {
                
                if (persArray[i].Age >= 40)
                {
                    persArray[i].PrintInfo();
                    Console.WriteLine();
                }
            }
            
        }
    }
}
