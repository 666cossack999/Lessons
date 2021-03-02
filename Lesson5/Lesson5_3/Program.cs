using System;
using System.IO;

namespace Lesson5_3
{
    class Program
    {
        /// <summary>
        /// Принимает строковый массив из цифр и конвертирует в массив байтов
        /// </summary>
        /// <param name="array"></param>
        /// <returns>массив байтов </returns>
        static byte[] StringToByte (string[] array)
        {
            byte[] numbersByte = new byte[array.Length];

            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    numbersByte[i] = Convert.ToByte(array[i]);
                }
            }
            catch
            {
                Console.WriteLine("Введите цифры от 0 до 255 через пробел!");
            }
            return numbersByte;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите числа от 0 до 255 через пробел");
            string userText = Console.ReadLine();
            //разбиваем строку на строковый 
            string[] numbers = userText.Split(' ');
            byte[] userBytes = StringToByte(numbers);

            File.WriteAllBytes("bytes.bin", userBytes);
                       
            Console.ReadLine();
        }
    }
}
