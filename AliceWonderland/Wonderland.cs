using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliceWonderland
{
    class Wonderland
    {
        static void Main(string[] args)
        {
            string line = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Enter your search term");
            String searchTerm = Console.ReadLine();
            Console.WriteLine(TextFound(line,searchTerm));
        }
        static bool TextFound(string text, string term)
        {
            int index = text.ToLower().IndexOf(term.ToLower());
            if (index < 0)
            {
                return false;
            }
            return true;
        }
    }
}
