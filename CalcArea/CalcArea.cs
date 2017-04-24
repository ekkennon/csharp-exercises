using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcArea
{
    class CalcArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of side 1 (rounded to a whole number");
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of side 2 (rounded to a whole number");
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Calc(side1, side2));
        }

        public static int Calc(int s1, int s2)
        {
            return s1 * s2;
        }
    }
}
