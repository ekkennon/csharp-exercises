// prep work day 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumEven
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            for (int i=0; i<10; i++)
            {
                lst.Add(i);
            }
            Console.WriteLine(sumEvenList(lst));
        }

        static int sumEvenList(List<int> lst)
        {
            int sum = 0;
            foreach (int i in lst) {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
