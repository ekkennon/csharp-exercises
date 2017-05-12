//studio day 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "u";
            Dictionary<char, int> d = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (d.ContainsKey(c))
                {
                    d[c] = d[c] + 1;
                } else
                {
                    d.Add(c, 1);
                }
            }
            foreach (char count in d.Keys)
            {
                Console.WriteLine(count + ": " + d[count]);
            }
            
            Console.ReadLine();
        }
    }
}
