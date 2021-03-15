using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson_7
{
    class Program
    {

        static int SIZE_X = 5;
        static int SIZE_Y = 5;
        static int SIZE = 4;
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
            Console.WriteLine("-----------");
            for (int i = 0; i < SIZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SIZE_X; j++)
                {
                    Console.Write(field[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------");
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
                Console.WriteLine("Координата по горизонтале");
                x = Int32.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Координат по вертикали ");
                y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));
            SetSym(y, x, PLAYER_DOT);
        }
        //Ход ИИ
        private static void AiStep()
        {
            int x;
            int y;
            for (int i = 0; i < SIZE_Y; i++) //v
            {
                for (int j = 0; j < SIZE_X; j++)  //h
                {
                    //анализ наличие поля для проверки
                    //по горизонтале
                    if (h + SIZE <= SIZE_X)
                    {
                        if (CheckLineHorisont(i, j, PLAYER_DOT) == SIZE - 1)
                        {
                            if (MoveAiLineHorisont(i, j, AI_DOT)) return;
                        }
                        //вверх по диагонале
                        if (i - SIZE > -2)
                        {
                            if (CheckDiaUp(i, j, PLAYER_DOT) == SIZE - 1)
                            {
                                if (MoveAiDiaUp(i, j, AI_DOT)) return;
                            }
                        }
                        //вниз по диагонале
                        if (i + SIZE <= SIZE_Y)
                        {
                            if (CheckDiaDown(i, j, PLAYER_DOT) == SIZE - 1)
                            {
                                if (MoveAiDiaDown(i, j, AI_DOT)) return;
                            }
                        }
                    }
                    //по вертикале
                    if (i + SIZE <= SIZE_Y)
                    {
                        if (CheckLineVertical(i, j, PLAYER_DOT) == SIZE - 1)
                        {
                            if (MoveAiLineVertical(i, j, AI_DOT)) return;
                        }
                    }
                }
            }
                //игра на победу
                for (int i = 0; i < SIZE_Y; i++)
                {
                    for (int j = 0; j < SIZE_X; j++)
                    {
                        //анализ наличие поля для проверки
                        //по горизонтале
                        if (j + SIZE <= SIZE_X)
                        {
                            if (CheckLineHorisont(i, j, AI_DOT) == SIZE - 1)
                            {
                                if (MoveAiLineHorisont(i, j, AI_DOT)) return;
                            }
                            //вверх по диагонале
                            if (i - SIZE > -2)
                            {
                                if (CheckDiaUp(i, j, AI_DOT) == SIZE - 1)
                                {
                                    if (MoveAiDiaUp(i, j, AI_DOT)) return;
                                }
                            }
                            //вниз по диагонале
                            if (i + SIZE <= SIZE_Y)
                            {
                                if (CheckDiaDown(i, j, AI_DOT) == SIZE - 1)
                                {
                                    if (MoveAiDiaDown(i, j, AI_DOT)) return;
                                }
                            }

                        }
                        //по вертикале
                        if (i + SIZE <= SIZE_Y)
                        {
                            if (CheckLineVertical(i, j, AI_DOT) == SIZE - 1)
                            {
                                if (MoveAiLineVertical(i, j, AI_DOT)) return;
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
        private static bool MoveAiLineHorisont(int v, int h, char dot)
        {
            for (int j = h; j < SIZE; j++)
            {
                if ((field[v, j] == EMPTY_DOT))
                {
                    field[v, j] = dot;
                    return true;
                }
            }
            return false;
        }
        //ход компьютера по вертикале
        private static bool MoveAiLineVertical(int v, int h, char dot)
        {
            for (int i = v; i < SIZE; i++)
            {
                if ((field[i, h] == EMPTY_DOT))
                {
                    field[i, h] = dot;
                    return true;
                }
            }
            return false;
        }
        //проверка заполнения всей линии по диагонале вверх

        private static bool MoveAiDiaUp(int v, int h, char dot)
        {
            for (int i = 0, j = 0; j < SIZE; i--, j++)
            {
                if ((field[v + i, h + j] == EMPTY_DOT))
                {
                    field[v + i, h + j] = dot;
                    return true;
                }
            }
            return false;
        }
        //проверка заполнения всей линии по диагонале вниз

        private static bool MoveAiDiaDown(int v, int h, char dot)
        {

            for (int i = 0; i < SIZE; i++)
            {
                if ((field[i + v, i + h] == EMPTY_DOT))
                {
                    field[i + v, i + h] = dot;
                    return true;
                }
            }
            return false;
        }
        //проверка победы
        private static bool CheckWin(char dot)
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    //анализ наличие поля для проверки
                    //по горизонтале
                    if (j + SIZE <= SIZE_X)
                    {                           
                        if (CheckLineHorisont(i, j, dot) >= SIZE) return true;
                        //вверх по диагонале
                        if (i - SIZE > -2)                                                    
                            if (CheckDiaUp(i, j, dot) >= SIZE) return true;
                        
                        //вниз по диагонале
                        if (i + SIZE <= SIZE_Y)
                            if (CheckDiaDown(i, j, dot) >= SIZE) return true; 
                    }
                    //по вертикале
                    if (i + SIZE <= SIZE_Y)
                        if (CheckLineVertical(i, j, dot) >= SIZE) return true;
                }
            }
            return false;
        }
        //проверка заполнения всей линии по диагонале вверх

        private static int CheckDiaUp(int v, int h, char dot)
        {
            int count = 0;
            for (int i = 0, j = 0; j < SIZE; i--, j++)
            {
                if ((field[v + i, h + j] == dot)) count++;
            }
            return count;
        }
        //проверка заполнения всей линии по диагонале вниз

        private static int CheckDiaDown(int v, int h, char dot)
        {
            int count = 0;
            for (int i = 0; i < SIZE; i++)
            {
                if ((field[i + v, i + h] == dot)) count++;
            }
            return count;
        }

        private static int CheckLineHorisont(int v, int h, char dot)
        {
            int count = 0;
            for (int j = h; j < SIZE + h; j++)
            {
                if ((field[v, j] == dot)) count++;
            }
            return count;
        }
        //проверка заполнения всей линии по вертикале
        private static int CheckLineVertical(int v, int h, char dot)
        {
            int count = 0;
            for (int i = v; i < SIZE + v; i++)
            {
                if ((field[i, h] == dot)) count++;
            }
            return count;
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
            Console.ReadLine();
        }
    }
}

