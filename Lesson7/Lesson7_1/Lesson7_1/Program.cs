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

        static char[,] field = new char[SIZE_Y, SIZE_X];

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
            Console.WriteLine("-------");
            for (int i = 0; i < SIZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SIZE_X; j++)
                {
                    Console.Write(field[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------");
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
            do
            {
                x = random.Next(0, SIZE_X);
                y = random.Next(0, SIZE_Y);
            } while (!IsCellValid(y, x));
            SetSym(y, x, AI_DOT);
        }

       
        /// <summary>
        /// Проверяет диагонали на победу
        /// </summary>
        /// <param name="sym">символ игрока</param>
        /// <returns>true/false</returns>
        private static bool CheckDiagonal(char sym,int offsetX, int offsetY)
        {
            bool toRight, toLeft;
            toRight = true;
            toLeft = true;
            for (int i = offsetX; i < WIN_SQUARE; i++)
            {
                

                    toRight &= field[i, i+offsetY] == sym;
                    toLeft &= field[ i+offsetY, WIN_SQUARE - i - 1] == sym;
                
                
                
            }

            return (toRight || toLeft);

            
        }
        /// <summary>
        /// Проверяем горизонтальные и вертикальные линии на победу
        /// </summary>
        /// <param name="sym">символ игрока</param>
        /// <param name="offsetX">смещение по Х</param>
        /// <param name="offsetY">смещение по Y</param>
        /// <returns>true/false</returns>
        private static bool CheckLanes(char sym,int offsetX, int offsetY)
        {
            bool columns, rows;
            for (int col = offsetX; col < WIN_SQUARE+offsetX; col++)
            {
                columns = true;
                rows = true;
                
                for (int row = offsetY; row < WIN_SQUARE+offsetY; row++)
                {
                    columns &= field[col, row] == sym;
                    rows &= field[row, col] == sym;
                }
                //Если столбец или строка true - останавливаем дальнейшее выполнение
                if (columns || rows) return true;
                
            }
            return false;
        }

        /// <summary>
        /// Делит игровое поле на игровые подполя размерностью WIN_SQUARE и делает проверку на победу в каждом подполе.
        /// </summary>
        /// <param name="sym">Символ игрока</param>
        /// <returns>true/false</returns>
        private static bool CheckWin(char sym)
        {
            
            for (int col = 0; col <= (SIZE_X - WIN_SQUARE); col++)
            {
                for (int row = 0; row <= (SIZE_X - WIN_SQUARE); row++)
                {
                    bool diag = CheckDiagonal(sym, col, row);
                    bool lanes = CheckLanes(sym, col, row);
                    if (diag || lanes) return true;
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
