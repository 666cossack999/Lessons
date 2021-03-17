using System;

namespace HelloLibrary
{
    public class HelloClass
    {
        public static void SayHello()
        {
            var name = Environment.UserName;
            Console.WriteLine($"Привет {name}! Как дела? ");
        }
    }
}
