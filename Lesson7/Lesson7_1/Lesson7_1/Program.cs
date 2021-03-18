using System;
using System.Collections.Generic;
using System.Text;


namespace Level_1.Lesson_7
{
    class Cross
    {
        static int SIZE_X = 5;
        static int SIZE_Y = 5;
        static int WIN_SQUARE = 4;  //чило последовательности символов для победы

        
        static char[,] field = new char[SIZE_Y, SIZE_X]; //Игровое поле


        static char PLAYER_DOT = 'X';
        static char AI_DOT = 'O';
        static char EMPTY_DOT = '.';

        static Random random = new Random();

        private static void InitField()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    field[i, j] = EMPTY_DOT;
                }
            }
        }

        private static void PrintField()
        {
            Console.Clear();
            Console.WriteLine("--------------");
            for (int i = 0; i < SIZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SIZE_X; j++)
                {
                    Console.Write(field[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------");
        }

        private static void SetSym(int y, int x, char sym)
        {
            field[y, x] = sym;
        }

        private static bool IsCellValid(int y, int x)
        {
            if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
            {
                return false;
            }

            return field[y, x] == EMPTY_DOT;
        }

        private static bool IsFieldFull()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    if (field[i, j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void PlayerStep()
        {
            int x;
            int y;
            do
            {
                Console.WriteLine($"Введите координаты X Y (1-{SIZE_X})");
                x = Int32.Parse(Console.ReadLine()) - 1;
                y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));
            SetSym(y, x, PLAYER_DOT);
        }

        private static void AiStep()
        {


            int x;
            int y;
            //блокировка ходов человека
            for (int v = 0; v < SIZE_Y; v++)
            {
                for (int h = 0; h < SIZE_X; h++)
                {
                    //анализ наличие поля для проверки
                    if (h + WIN_SQUARE <= SIZE_X)
                    {                           //по горизонтале
                        if (CheckLineHorisont(v, h, PLAYER_DOT) == WIN_SQUARE - 1)
                        {
                            if (MoveAiLineHorisont(v, h, AI_DOT)) return;
                        }

                        if (v - WIN_SQUARE > -2)
                        {                            //вверх по диагонале
                            if (CheckDiaUp(v, h, PLAYER_DOT) == WIN_SQUARE - 1)
                            {
                                if (MoveAiDiaUp(v, h, AI_DOT)) return;
                            }
                        }
                        if (v + WIN_SQUARE <= SIZE_Y)
                        {                       //вниз по диагонале
                            if (CheckDiaDown(v, h, PLAYER_DOT) == WIN_SQUARE - 1)
                            {
                                if (MoveAiDiaDown(v, h, AI_DOT)) return;
                            }
                        }
                    }
                    if (v + WIN_SQUARE <= SIZE_Y)
                    {                       //по вертикале
                        if (CheckLineVertical(v, h, PLAYER_DOT) == WIN_SQUARE - 1)
                        {
                            if (MoveAiLineVertical(v, h, AI_DOT)) return;
                        }
                    }
                }
            }

            do
            {
                x = random.Next(0, SIZE_X);
                y = random.Next(0, SIZE_Y);
            } while (!IsCellValid(y, x));
            SetSym(y, x, AI_DOT);
        }

        //ход компьютера по горизонтале
        private static bool MoveAiLineHorisont(int v, int h, char sym)
        {
            for (int j = h; j < WIN_SQUARE; j++)
            {
                if ((field[v, j] == EMPTY_DOT))
                {
                    field[v, j] = sym;
                    return true;
                }
            }
            return false;
        }
       
        //ход компьютера по вертикале
        private static bool MoveAiLineVertical(int v, int h, char sym)
        {
            for (int i = v; i < WIN_SQUARE; i++)
            {
                if ((field[i, h] == EMPTY_DOT))
                {
                    field[i, h] = sym;
                    return true;
                }
            }
            return false;
        }
        
        //проверка заполнения всей линии по диагонале вверх
        private static bool MoveAiDiaUp(int v, int h, char sym)
        {
            for (int i = 0, j = 0; j < WIN_SQUARE; i--, j++)
            {
                if ((field[v + i, h + j] == EMPTY_DOT))
                {
                    field[v + i, h + j] = sym;
                    return true;
                }
            }
            return false;
        }
       
        //проверка заполнения всей линии по диагонале вниз
        private static bool MoveAiDiaDown(int v, int h, char sym)
        {

            for (int i = 0; i < WIN_SQUARE; i++)
            {
                if ((field[i + v, i + h] == EMPTY_DOT))
                {
                    field[i + v, i + h] = sym;
                    return true;
                }
            }
            return false;
        }



        /// <summary>
        /// Проверка заполнения всей линии по горизонтали
        /// </summary>
        /// <param name="v">X</param>
        /// <param name="h">Y</param>
        /// <param name="dot">Символ</param>
        /// <returns>Кол-во символов в строке</returns>
        private static int CheckLineHorisont(int v, int h, char dot)
        {
            int count = 0;
            for (int j = h; j < WIN_SQUARE + h; j++)
            {
                if ((field[v, j] == dot)) count++;
            }
            return count;
        }
        /// <summary>
        /// проверка заполнения всей линии по диагонале вверх
        /// </summary>
        /// <param name="v">X</param>
        /// <param name="h">Y</param>
        /// <param name="dot">Символ</param>
        /// <returns>Кол-во символов в диагонали справа налево</returns>
        private static int CheckDiaUp(int v, int h, char dot)
        {
            int count = 0;
            for (int i = 0, j = 0; j < WIN_SQUARE; i--, j++)
            {
                if ((field[v + i, h + j] == dot)) count++;
            }
            return count;
        }
   
        /// <summary>
        /// проверка заполнения всей линии по диагонале вниз
        /// </summary>
        /// <param name="v">X</param>
        /// <param name="h">Y</param>
        /// <param name="dot">Символ</param>
        /// <returns>Кол-во символов в диагонали слева направо</returns>
        private static int CheckDiaDown(int v, int h, char dot)
        {
            int count = 0;
            for (int i = 0; i < WIN_SQUARE; i++)
            {
                if ((field[i + v, i + h] == dot)) count++;
            }
            return count;
        }
        /// <summary>
        /// Проверка заполнения всей линии по вертикали
        /// </summary>
        /// <param name="v">X</param>
        /// <param name="h">Y</param>
        /// <param name="dot">Символ</param>
        /// <returns>Кол-во символов в столбце</returns>
        private static int CheckLineVertical(int v, int h, char dot)
        {
            int count = 0;
            for (int i = v; i < WIN_SQUARE + v; i++)
            {
                if ((field[i, h] == dot)) count++;
            }
            return count;
        }

        /// <summary>
        /// Делит игровое поле на несколько игровых подполя размерностью WIN_SQUARE и делает проверку на победу в каждом подполе.
        /// </summary>
        /// <param name="sym">Символ игрока</param>
        /// <returns>true/false</returns>
        private static bool CheckWin(char sym)
        {
            for (int v = 0; v < SIZE_Y; v++)
            {
                for (int h = 0; h < SIZE_X; h++)
                {
                    //анализ наличие поля для проверки
                    if (h + WIN_SQUARE <= SIZE_X)
                    {                           //по горизонтале
                        if (CheckLineHorisont(v, h, sym) >= WIN_SQUARE) return true;

                        if (v - WIN_SQUARE > -2)
                        {                            //вверх по диагонале
                            if (CheckDiaUp(v, h, sym) >= WIN_SQUARE) return true;
                        }
                        if (v + WIN_SQUARE <= SIZE_Y)
                        {                       //вниз по диагонале
                            if (CheckDiaDown(v, h, sym) >= WIN_SQUARE) return true;
                        }
                    }
                    if (v + WIN_SQUARE <= SIZE_Y)
                    {                       //по вертикале
                        if (CheckLineVertical(v, h, sym) >= WIN_SQUARE) return true;
                    }
                }
            }
            return false;

        }






        static void Main(string[] args)
        {
            InitField();
            PrintField();

            while (true)
            {
                PlayerStep();
                PrintField();
                if (CheckWin(PLAYER_DOT))
                {
                    Console.WriteLine("Player Win!");
                    break;
                }
                if (IsFieldFull())
                {
                    Console.WriteLine("DRAW");
                    break;
                }
                AiStep();
                PrintField();
                if (CheckWin(AI_DOT))
                {
                    Console.WriteLine("SkyNet Win!");
                    break;
                }
                if (IsFieldFull())
                {
                    Console.WriteLine("DRAW");
                    break;
                }
            }
        }
    }
}
