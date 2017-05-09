//studio day 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius");
            Console.WriteLine(CalcArea(double.Parse(Console.ReadLine())));
        }

        static double CalcArea(double r)
        {
            return r * r * Math.PI;
        }
    }
}
