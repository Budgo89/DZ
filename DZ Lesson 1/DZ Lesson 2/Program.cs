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
            Console.WriteLine("1. Метод работы с комплексными числами.");
            Console.WriteLine("2. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
            Console.WriteLine("3. Метод работы с дробями");
            Console.WriteLine("4. Выход");
            Console.Write("Введите номер задачи: ");
            int tasknam = Convert.ToInt32(Console.ReadLine());
            switch (tasknam)
            { 
                #region task 1
                case 1: /* 1. а) Дописать структуру Complex, добавив метод вычитания 
                             комплексных чисел. Продемонстрировать работу структуры;
                            б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса; */
                Console.Clear();
                Console.Title = "Метод вычитания комплексных чисел";

                break;
                #endregion
            }
        }
    }
}
