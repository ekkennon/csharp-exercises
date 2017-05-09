//walkthrough day 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst = new int [10];

            for (int i=0; i<10; i++)
            {
                lst[i] = i;
            }

            Console.WriteLine(FindMax(lst));
        }

        static int FindMax(int[] lst)
        {
            int max = lst[0];

            foreach (int i in lst)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            return max;
        }
    }
}
