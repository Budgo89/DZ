using Newtonsoft.Json;
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
        static void PrintDir(DirectoryInfo dir, string indent, bool lastDirectory, string fail)
        {
            string text;
            Console.Write(indent);
            File.AppendAllText(fail, indent);
            if (lastDirectory)
            {
                Console.Write("└─");
                text = "└─";
                File.AppendAllText(fail, text);
                indent += "  ";
                                
            }
            else
            {
                Console.Write("├─");
                text = "├─";
                File.AppendAllText(fail, text);
                indent += "│ ";                              
            }

            Console.WriteLine(dir.Name);
            File.AppendAllText(fail, dir.Name);
            File.AppendAllText(fail, Environment.NewLine);

            DirectoryInfo[] subDirs = dir.GetDirectories();

            for (int i = 0; i < subDirs.Length; i++)
            {
                PrintDir(subDirs[i], indent, i == subDirs.Length - 1, fail);
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Меню";
            Console.WriteLine("Какое задание вы хотите проверить:");
            Console.WriteLine("1. Сохранить дерево каталогов и файлов.");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. Выход");
            Console.Write("Введите номер задачи: ");
            int tasknam = Convert.ToInt32(Console.ReadLine());
            switch (tasknam)
            {
                #region task 1
                case 1: // 1. Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
                    Console.Clear();
                    Console.Title = "Сохранить дерево каталогов и файлов";
                    string put = @"E:\Battle.net";
                    string filename1 = "strukturDir.txt";
                    DateTime localDate = DateTime.Now;
                    File.WriteAllText(filename1, Convert.ToString(localDate));
                    File.AppendAllText(filename1, Environment.NewLine);
                    PrintDir(new DirectoryInfo(put), "", true, filename1);
                    Console.ReadKey();

                    filename1 = "strukturDir1.txt";
                    File.WriteAllText(filename1, Convert.ToString(localDate));
                    File.AppendAllText(filename1, Environment.NewLine);

                    string[] entries = Directory.GetFileSystemEntries(put, "*", SearchOption.AllDirectories);

                    for (int i = 0; i < entries.Length; i++)
                    {
                        Console.WriteLine(entries[i]);
                    }
                    File.AppendAllLines(filename1, entries);                    
                    Console.ReadKey();
                    break;
                #endregion

                #region task 2
                case 2:
                   /* 2.Список задач(ToDo - list):
                    написать приложение для ввода списка задач;
                    задачу описать классом ToDo с полями Title и IsDone;
                    на старте, если есть файл tasks.json / xml / bin(выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
                    если задача выполнена, вывести перед её названием строку «[x]»;
                    вывести порядковый номер для каждой задачи;
                    при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
                    записать актуальный массив задач в файл tasks.json / xml / bin.*/

                    ToDo ToDoList = new ToDo();

                    ToDoList.Title = "Задание 1 ";
                    ToDoList.IsDone = true;
                    string json = JsonSerializer.Serialize(ToDoList);
                    File.WriteAllText("ToDoList.json", json);

                    break;
                    #endregion

            }
        }
    }
}
