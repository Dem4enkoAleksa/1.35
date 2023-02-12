using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Введите первый катет ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй катет ");
            double b = double.Parse(Console.ReadLine());
            double c;
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Гипотенуза равна {0}", c);
            double S = (a * b / 2);
            Console.WriteLine("Площадь равна {0}", S);
            Console.ReadKey();

        }
    }
}
