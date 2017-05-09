// prep work day 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGradeBookDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent = " ";

            Console.WriteLine("Enter the id followed by the name with a space between.");
            while (newStudent != "")
            {
                
                newStudent = Console.ReadLine();
                int id = 0;
                string name = "";
                if (newStudent != "")
                {
                    id = int.Parse(newStudent.Substring(newStudent.IndexOf(" ")));
                    name = newStudent.Substring(newStudent.IndexOf(" "),newStudent.Length);
                    students.Add(id, name);
                }
                Console.WriteLine("Enter next student (or ENTER to finish)");
            }

            // Print class roster
            StringBuilder studentList = new StringBuilder();
            studentList.Append("\nClass roster:\n");
            foreach (KeyValuePair<int, string> student in students)
            {
                studentList.Append(student.Key + " - " + student.Value + "\n");
            }

            Console.ReadLine();
        }
    }
}
