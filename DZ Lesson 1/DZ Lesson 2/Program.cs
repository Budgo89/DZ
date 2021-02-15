using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Меню";
            Console.WriteLine("Какое задание вы хотите проверить:");
            Console.WriteLine("1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. Выход");
            Console.Write("Введите номер задачи: ");
            int tasknam = Convert.ToInt32(Console.ReadLine());
            switch (tasknam)
            { 
                #region task 1
                case 1: /* 1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру. */
                    Console.Clear();
                    Console.Title = "Средняя температура";
                    Console.Write("Введите минимальную температуру за сутки: ");
                    int min = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите максимальную температуру за сутки: ");
                    int max = Convert.ToInt32(Console.ReadLine());
                    int sr = (min + max) / 2;
                    Console.WriteLine($"Cреднесуточная температура {sr} градусов");
                    Console.ReadLine();

                    break;
                #endregion
            }
        }
    }
}
