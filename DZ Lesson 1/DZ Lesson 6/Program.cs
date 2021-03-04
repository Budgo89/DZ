using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson_6
{
    class Program
    {
        static void PrintDir(DirectoryInfo dir, string indent, bool lastDirectory)
        {
            Console.Write(indent);
            if (lastDirectory)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "│ ";
            }

            Console.WriteLine(dir.Name);

            DirectoryInfo[] subDirs = dir.GetDirectories();

            for (int i = 0; i < subDirs.Length; i++)
            {
                PrintDir(subDirs[i], indent, i == subDirs.Length - 1);
            }

        }
        static void Main(string[] args)
        {
            Console.Title = "Меню";
            Console.WriteLine("Какое задание вы хотите проверить:");
            Console.WriteLine("1. Сохранить дерево каталогов и файлов.");
            Console.WriteLine("2. Написать программу, принимающую на вход строку — набор чисел ");
            Console.WriteLine("3. Написать метод по определению времени года");
            Console.WriteLine("4. Число Фибоначчи");
            Console.WriteLine("5. Выход");
            Console.Write("Введите номер задачи: ");
            int tasknam = Convert.ToInt32(Console.ReadLine());
            switch (tasknam)
            {
                #region task 1
                case 1: // 1. Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.

                    string put = AppDomain.CurrentDomain.BaseDirectory + "DZ Lesson 1.sln";

                    PrintDir(new DirectoryInfo(put), "", true);

                    Console.ReadKey();



                    break;
                    #endregion
            }
        }
    }
}
