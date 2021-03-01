using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Меню";
            Console.WriteLine("Какое задание вы хотите проверить:");
            Console.WriteLine("1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.");
            Console.WriteLine("2. Написать программу, которая при старте дописывает текущее время в файл");
            Console.WriteLine("3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл");
            Console.WriteLine("4. Выход");
            Console.Write("Введите номер задачи: ");
            int tasknam = Convert.ToInt32(Console.ReadLine());
            switch (tasknam)
            {
                #region task 1
                case 1: //Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
                    Console.Clear();
                    Console.Title = "Ввести с клавиатуры произвольный набор данных";
                    Console.Write("Введите произвольный набор данных: ");
                    string text1 = Console.ReadLine();

                    string filename1 = "text.txt";
                    File.WriteAllText(filename1, text1);
                    Console.WriteLine("Данные записаны");
                    Console.ReadLine();

                    break;
                #endregion

                #region task 2
                case 2: // 2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
                    Console.Clear();
                    Console.Title = "Написать программу, которая при старте дописывает текущее время в файл";
                    DateTime localDate = DateTime.Now;
                    string filename2 = "startup.txt";
                    if (!(File.Exists(filename2)))
                    {
                        File.WriteAllText(filename2, Convert.ToString(localDate));
                    }
                    else
                    {
                        File.AppendAllText(filename2, Environment.NewLine);
                        File.AppendAllText(filename2, Convert.ToString(localDate));
                    }

                    Console.WriteLine($"Время старта программы: {localDate} записано в файл «startup.txt»");
                    Console.ReadLine();
                    break;
                #endregion

                #region task 3
                case 3: //3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
                    Console.Clear();
                    Console.Title = "Ввести с клавиатуры произвольный набор чисел";
                    Console.Write("Введите произвольный набор чисел (0...255): ");
                    string text3 = Console.ReadLine();
                    int i = 0;
                    byte[] text3Byte = new byte[text3.Length];
                    foreach (var item in text3)
                    {
                        text3Byte[i] = Convert.ToByte(item);
                        i++;
                    }
                    File.WriteAllBytes("bytes.bin", text3Byte);      
                    break;
                    #endregion
            }

        }
        //static byte[] ConvByte(string text)
        //{
        //    byte[] numbers = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //}
    }
}
