using System;

namespace lesson2_4
{
    class Program
    {

        static void Main(string[] args)
        {
            decimal priceL = 19.50m,       //Цена за литр бензина
                sumL = 70.00m,             //Кол-во литров
                sum = priceL*sumL,         //Сумма к оплате
                userSum = 1500.00m,        //Взяли денег у клиента
                oddMoney = userSum - sum;  //сдача
            string fix = "23:2516";        //какая-то непонятная цифра из чека
            long orgInn = 7700000000,      //ИНН
                ekzl = 3297258661;         //ЭКЗЛ
            int numberAzs = 0035,          //Номер АЗС
                pos = 004,                 //Номер кассы
                posOperator = 0354,        //Оператор
                recipeNumber = 0924,       //Номер чека
                num = 0231,                //какой-то номер
                fiskMode = 82143979,       //Фискальный номер
                recNum = 062988,           //ещё какой-то номер чека
                fns = 00144347;            //какой-то номер





            //Присваиваем каждую строчку ЧЕКа отдельной переменной
            string a = "\t\t\t\t╔═══════════════════════════════════════╗",
                   b = "\t\t\t\t║              НОВЫЙ ЧЕК                ║",
                   c = $"\t\t\t\t║ АЗС {numberAzs}  КАССА {pos} ОПЕРАТОР {posOperator}   \t║",
                   d = $"\t\t\t\t║ ИНН ОРГ. -ПРОДАВЦА  {orgInn}        ║",
                   e = $"\t\t\t\t║ ДТ        N  {fix}         {sum:N2}\t║",
                   f = $"\t\t\t\t║ RBL\t\t{priceL} X {sumL}\t\t║",
                   g = "\t\t\t\t╠═══════════════════════════════════════╣\n " +
                       $"\t\t\t\t║ ИТОГО                        {sum:N2} ║ \n" +
                       "\t\t\t\t╠═══════════════════════════════════════╣",
                   h = $"\t\t\t\t║ Рубль России                 {sum:N2} ║",
                   j = $"\t\t\t\t║ Наличными                     {userSum}\t║",
                   k = $"\t\t\t\t║ СДАЧА                         {oddMoney:N2} \t║",
                   l = $"\t\t\t\t║ ЭКЗЛ  {ekzl}                      ║",
                   m = "\t\t\t\t║\t\tСПАСИБО\t\t\t║ \n  " +
                       "\t\t\t\t║\t\tЗА ПОКУПКУ\t\t║",
                   n = $"\t\t\t\t║ ЧЕК{recipeNumber}{DateTime.Now}\t    {num} ║",
                   o = $"\t\t\t\t║ ФИСКАЛЬНЫЙ РЕЖИМ\t\t{fiskMode}║",
                   p = $"\t\t\t\t║ {fns}  #{recNum}\t\t\t║",
                   q = "\t\t\t\t╚═══════════════════════════════════════╝";

            //Создаём массив строк нашего ЧЕКа
            string[] myRecipe = new string[]
            {
              a, b, c, d, e, f, g, h, j, k, l, m, n, o, p, q
            };
            //Рисуем ЧЕК
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(myRecipe[i]);
            }
  
        }
    }
}
