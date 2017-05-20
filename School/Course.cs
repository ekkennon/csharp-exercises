using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDesc { get; set; }
        public string OfferCode { get; set; }
        public int NumCredits { get; set; }
        public List<string> prereqs { get; set; }
        public List<Student> Students { get; set; }

        public Course (string id, string name, string desc, string code, int credits)
        {
            CourseID = id;
            CourseName = name;
            CourseDesc = desc;
            OfferCode = code;
            NumCredits = credits;
        }

        public Course(string id, string code) : this(id, "", "", code, 0)
        {

        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Course c = obj as Course;

            if (CourseID.Equals(c.CourseID))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return CourseID +  " - " + CourseName;
        }
    }
}
