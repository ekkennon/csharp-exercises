using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        //todo create constructor

        public int NumCredits { get; set; }
        public double GPA { get; set; }
        private int studentID;
        private string name;

        public int StudentID
        {
            get { return studentID; }
            private set { studentID = value; }// this should only be set from the constructor
        }

        public string MyProperty
        {
            get { return name; }
            set { name = value; }
        }
    }
}
