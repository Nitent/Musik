using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ST = new Student();
            ST.FIO = "Иванов";
            ST.Ocenka1 = 3;
            ST.Ocenka2 = 5;
            ST.show();
            Console.WriteLine($"Среднея оценка студента {ST.SredOcenka()}");
            Console.ReadLine();
        }
    }
}
