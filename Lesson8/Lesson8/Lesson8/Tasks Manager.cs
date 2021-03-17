using System;
using System.Diagnostics;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                Console.Write($"{i}. ");
                Console.WriteLine(processes[i].ProcessName);
            }
            Console.WriteLine("\nВведите номер процесса который хотите завершить: ");
            int userID = int.Parse(Console.ReadLine());
            processes[userID].Kill();
        }   
    }
}
