using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Сапунов Максим";
            DateTime date = new DateTime(2021, 2, 12, 16, 15, 32);
            Console.WriteLine($"Привет, {name}, сегодня Data {date.ToString("dd.MM.yy")}");
            Console.ReadLine();
        }
    }
}
