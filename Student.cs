using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musik
{
    internal class Student
    {
        public string FIO { get; set; }
        public int Ocenka1 { get; set; }
        public int Ocenka2 { get; set; }
        public Student()
        {
            FIO = "";
            Ocenka1 = 0;
            Ocenka2 = 0;
        }
        public void show()
        {
            Console.WriteLine($"Студента зовут: {FIO}, Имеет оценку {Ocenka1} и оценку {Ocenka2}");
        }
        public float SredOcenka ()
        {

            float SO = (Ocenka1 + Ocenka2) / 2;
            return SO;
        }
    }
}
