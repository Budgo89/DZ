using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson_6
{
    
    public class Sotrudnik
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string FIO { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// email
        /// </summary>
        public string Еmail { get; set; }

        /// <summary>
        /// телефон
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// зарплата
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// возраст
        /// </summary>
        public int Age { get; set; }

        public Sotrudnik()
        {

        }

        public Sotrudnik(string fio, string position, string email, string telephone, int salary, int age)
        {
            FIO = fio;
            Position = position;
            Еmail = email;
            Telephone = telephone;
            Salary = salary;
            Age = age;
        }
        public void Print()
        {
            Console.WriteLine($"{FIO}, Должность: {Position}, Email: {Еmail}, Телефон: {Telephone}, Зарплата: {Salary}, Возраст: {Age}");
        }

    }
}
