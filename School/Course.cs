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

    }
}
