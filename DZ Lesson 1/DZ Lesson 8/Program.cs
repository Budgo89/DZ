using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_Lesson_8
{
    [Serializable]
    class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Program()
        {

        }
        public Program(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
