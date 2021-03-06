using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson_6
{
    [Serializable]
    public class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public ToDo()
        {
        }


        public void print()
        {
            Console.Write($"{Title}: ");
            Console.WriteLine(IsDone);
        }

    }
}
