using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMPG
{
    class CalcMPG
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons of gas have you consumed?");
            double gallons = double.Parse(Console.ReadLine());
            Console.WriteLine(Calc(miles, gallons));
        }

        public static double Calc(double miles, double gallons)
        {
            return miles / gallons;
        }
    }
}
