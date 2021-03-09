using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6_4
{
    class employee
    {
        public string FirstName;
        public string LastName;
        public string MiddleName;
        public string Position;
        public string Email;
        public string Phone;
        public int Wage;
        public int Age;

        public employee()
        {
        }

        public employee(string lastName, string firstName, string middleName, string position, string email, string phone, int wage, int age)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Position = position;
            Email = email;
            Phone = phone;
            Wage = wage;
            Age = age;
        }



        public string GetFullName()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
        public void PrintInfo()
        {
            Console.WriteLine("Информация о сотруднике:");
            Console.WriteLine($"Фамилия: {LastName}");
            Console.WriteLine($"Имя: {FirstName}");
            Console.WriteLine($"Отчество: {MiddleName}");
            Console.WriteLine($"Должность: {Position}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Телефон: {Phone}");
            Console.WriteLine($"Зарплата: {Wage}");
            Console.WriteLine($"Возраст: {Age}");
        }
    }
}
