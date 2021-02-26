using System;
using System.Linq;

namespace Lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ///Функция принимает строку string userString, создаёт новый массив array, заполняет его цифрами разделёнными любыми символами кроме цифр. Возвращает расчленненый массив с цифрами.
            static  string[] myIntSplit(string userString)
            {   //создаём массив размером с длинну строки
                string[] array = new string[userString.Length];
                //счетчик j для перехода на новый индекс массива, если попался символ - не цифра
                int j = 0;


                for (int i = 0 ; i < userString.Length; i++)
                {
                    //если не цифра переходим в новую строку массива
                    if (userString[i] < '0' || userString[i] > '9')
                    {
                        j++;                        
                        continue;
                    }
                    //вычленяем цифры в строку массива
                    array[j] += userString[i];

                    
                   
                }


                array = array.Where(x => x != null).ToArray();

                //возвращаем 
                return array;
            }
            ///Функция принимающая массив строк из цифр temp и возвращающий их сумму
            static int sumArray (string[] temp)
            {
                

                int sum = 0;

                foreach (string item in temp)
                {
                    if (item == null)
                    {
                        continue;
                    }

                    int num = int.Parse(item);
                    sum += num;

                }
                return sum;
            }

            Console.WriteLine("Введите строку в которой хотите посчитать сумму цифр: ");
            string userString = Console.ReadLine();

            //временный массив с расчлененными строками содержащий только цифры
            string[] temp = myIntSplit(userString);
            //Считаем сумму цифр массива
            int sum = sumArray(temp); 
            

            //выводим сумму на консоль
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
