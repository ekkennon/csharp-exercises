// prep work day 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst = { 1, 1, 2, 3, 5, 8 };
            PrintValues(lst);
        }

        static void PrintValues(int[] lst)
        {
            foreach (int i in lst)
            {
                Console.WriteLine(i);
            }
        }
    }
}
