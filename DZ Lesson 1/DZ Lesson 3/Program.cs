using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Меню";
            Console.WriteLine("Какое задание вы хотите проверить:");
            Console.WriteLine("1. Написать программу, выводящую элементы двумерного массива по диагонали.");
            Console.WriteLine("2. Телефонный справочник");
            Console.WriteLine("3. Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello)");
            Console.WriteLine("4. Морской бой");
            Console.WriteLine("5. Доп. ДЗ");
            Console.WriteLine("6. Выход");
            Console.Write("Введите номер задачи: ");
            int tasknam = Convert.ToInt32(Console.ReadLine());
            switch (tasknam)
            {
                #region task 1
                case 1: //1. Написать программу, выводящую элементы двумерного массива по диагонали.
                    Console.Clear();
                    Console.Title = "Двумерный массив по диагонали";
                    Console.Write("Написать программу, выводящую элементы двумерного массива по диагонали");
                    int[,] a = { { 1, 2, 3}, {3, 4, 5}, { 5, 6, 7 } };
                    string[] b = { "", " ", "  " }; 

                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        Console.Write($"{b[i]}");
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            Console.Write($"{a[i, j]}");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                    break;
                #endregion

                #region task 2
                case 2: /*Написать программу «Телефонный справочник»: создать двумерный массив 5х2, 
                    хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/email. */
                    Console.Clear();
                    Console.Title = "Телефонный справочник";
                    Console.Write("Телефонный справочник");
                    string[,] tel = {
                                        {"Иван", "8 - 938 - 80" },
                                        {"Владимир", "8 - 389 - 12" },
                                        {"Колян", "Kolyn@xz.com" },
                                        {"Ольга", "2 - 159 - 50" },
                                        {"Ира", "0 - 563 - 71" }
                                    };
               // Исполнение для ввода данных с консоли.
                    //string[,] tel = new string[5,2];
                    //for (int i = 0; i < tel.GetLength(0); i++)
                    //{
                    //    for (int j = 0; j < tel.GetLength(1); j++)
                    //    {                           
                    //            if (j == 0)
                    //            {
                    //                Console.Write($"{i+1} Введите имя: ");
                    //                tel[i, j] = Console.ReadLine();
                    //            }
                    //            else 
                    //            {
                    //                Console.Write($"{i+1} Введите номер телефона или почту: ");
                    //                tel[i, j] = Console.ReadLine();
                    //            }                            
                    //    }
                    //}
                    for (int i = 0; i < tel.GetLength(0); i++)
                    {
                             for (int j = 0; j < tel.GetLength(1); j++)
                        {
                            if (j == 0)
                            {
                                Console.Write($"{tel[i, j]}");
                                Console.Write($". Тел: ");
                            }
                            else Console.Write($"{tel[i, j]}");

                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();

                    break;
                #endregion

                #region task 3
                case 3: // 3. Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello).

                    Console.Clear();
                    Console.Title = "olleH вместо Hello";
                    Console.WriteLine("Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello)");
                    Console.Write("Введете слово: ");
                    string a3 = Console.ReadLine();
                    char[] b3 = a3.ToCharArray();
                    char c3;

                    for (int i = 0, j = b3.Length - 1; j > i; i++, j--)
                    {
                        c3 = b3[i];
                        b3[i] = b3[j];
                        b3[j] = c3;
                    }
                    foreach (char s3 in b3) 
                    {
                        Console.Write(s3);
                    } 
                    Console.ReadLine();

                    break;
                #endregion

                #region task 4
                case 4: //«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.

                    Console.Clear();
                    Console.Title = "Морской бой";
                    Console.WriteLine("Морской бой");

                    int[,] a4 = new int[10,10];

                    for (int i = 0; i < a4.GetLength(0); i++)
                    {
                        for (int j = 0; j < a4.GetLength(1); j++)
                        {
                            if ((i == 1 && j==1) || (i == 0 && j == 9) || (i == 1 && j == 6) || (i == 1 && j == 7) || (i == 1 && j == 9) || (i == 2 && j == 9) || (i == 3 && j == 5) || (i == 3 && j == 7) || (i == 3 && j == 9) || (i == 4 && j == 2) || (i == 4 && j == 7) || (i == 5 && j == 5) || (i == 5 && j == 9) || (i == 6 && j == 5) || (i == 6 && j == 7) || (i == 6 && j == 9) || (i == 7 && j == 0) || (i == 7 && j == 7) || (i == 7 && j == 9) || (i == 9 && j == 6) || (i == 9 && j == 7) || (i == 9 && j == 8))
                            {
                                Console.Write($"x ");
                            }
                            else Console.Write($"0 ");

                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                    break;
                #endregion

                #region task 5
                case 5: /*4. доп. ДЗ Написать программу, которой на вход подается одномерный массив и число n 
                        (может быть положительным, или отрицательным), при этом программа должена сместить все 
                        элементы массива на n позиций. Для усложнения задачи нельзя пользоваться вспомогательными массивами. */

                    Console.Clear();
                    Console.Title = "Доп. ДЗ";
                    Console.WriteLine("Доп. ДЗ");

                    int[] a5 = { 1, 2, 3, 4, 5 };
                    for(int i = 0; i < a5.Length; i++)
                    {
                        Console.Write($" {a5[i]}");
                    }
                    Console.WriteLine();
                    int b5;
                    do
                    {
                        Console.Write("Введите значение n но не менее -4: ");
                        b5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                    }
                    while (b5 < -4);
                    int[] c5 = new int[a5.Length + b5];
                    if (b5 > 0)
                    {                        
                        for(int i = 0; i < b5; i++)
                        {
                            c5[i] = 0;
                        }
                        for(int i = b5, j = 0; i < c5.Length; i++, j++)
                        {
                            c5[i] = a5[j];
                        }
                    }
                    else
                    {
                        for (int i = 0; i < c5.Length; i++)
                        {
                            c5[i] = a5[i];                            
                        }
                    }
                    for (int i = 0; i < c5.Length; i++)
                    {
                        Console.Write($" {c5[i]}");
                    }
                    Console.ReadLine();
                    break;
                    #endregion
            }
        }
    }
}
