﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Меню";
            Console.WriteLine("Какое задание вы хотите проверить:");
            Console.WriteLine("1. Написать метод GetFullName.");
            Console.WriteLine("2. Написать программу, принимающую на вход строку — набор чисел ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. ");
            Console.WriteLine("6. Выход");
            Console.Write("Введите номер задачи: ");
            int tasknam = Convert.ToInt32(Console.ReadLine());
            switch (tasknam)
            {
                #region task 1
                case 1: /* 1. Написать метод GetFullName(string firstName, string lastName, string patronymic), 
                         * принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. 
                         * Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.*/
                    Console.Clear();
                    Console.Title = "Меню";
                    Console.WriteLine("1. Написать метод GetFullName.");
                    Console.WriteLine(GetFullName("Сапунов", "Максим","Алексеевич"));
                    Console.WriteLine(GetFullName("Иванов", "Иван", "Иванович"));
                    Console.Write("Введите имя: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Введите фамилию: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Введите отчетво: ");
                    string patronymic = Console.ReadLine();
                    Console.WriteLine(GetFullName(firstName, lastName, patronymic));
                    Console.ReadLine();
                    break;
                #endregion
                #region task 2
                case 2: /* 2. Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, 
                         * и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран.*/
                    Console.Clear();
                    Console.Title = "Меню";
                    Console.WriteLine("2. Написать программу, принимающую на вход строку — набор чисел.");
                    Console.Write("Введете числа разделенные пробелом но не балее 99: ");
                    string sumString = Console.ReadLine();
                    int sum2 = 0;
                    int b2 =0;
                    Char[] a2 = new char [ sumString.Length ];
                    int i = 0;
                    foreach (var item in sumString)
                    {
                        a2[i] = item;
                        i++;
                    }

                    for (int j = 0; j < a2.Length; j++)
                    {
                        if (j + 1 < a2.Length)
                        {
                            if (Char.IsDigit(a2[j + 1]) && Char.IsDigit(a2[j]))
                            {
                                b2 = Convert.ToInt32(Convert.ToString(a2[j]) + Convert.ToString(a2[j + 1]));
                                sum2 += b2;
                                j++;
                            }
                            else if (Char.IsDigit(a2[j])) sum2 += Convert.ToInt32(Convert.ToString(a2[j]));
                        }
                        else sum2 += Convert.ToInt32(Convert.ToString(a2[j]));

                    }
                    Console.WriteLine($"{sum2} ");
                    Console.ReadLine();
                    break;
                #endregion
                #region task 3
                case 3: /* 3. Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
                         * На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. Написать метод, 
                         * принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень). 
                         * Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
                         * Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».*/

                    Console.Write("Введите номер месяца: ");

                    int a3 = Convert.ToInt32(Console.ReadLine());
                    if (a3 > 0 && a3 < 13)
                    {

                    }
                    else Console.WriteLine("Ошибка: введите число от 1 до 12");
                    


                    var b = (Season)i3;
                    Console.WriteLine(b);  // output: Summer

                    var c = (Season)4;



                    Console.ReadLine();
                    break;
                    #endregion

            }
        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return firstName + " " + lastName + " " + patronymic;

        }

        public enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn,

        }

    }
}
