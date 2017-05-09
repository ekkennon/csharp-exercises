//prep work day 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFive
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();
            lst.Add("hello");
            lst.Add("world");
            lst.Add("kevin");
            lst.Add("rags");
            PrintFive(lst);
        }

        static void PrintFive(List<string> words)
        {
            foreach (string s in words)
            {
                if (s.Length == 5)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
