namespace School
{
    abstract class Student { 

        private static int nextStudentId = 1;
        public int NumCredits { get; set; }
        public double GPA { get; set; }
        public string Name { get; set; }
        private int studentID;
        private double qualityScore;

        public Student(string name, int studentId, int numCredits, double gpa, double qs)
        {
            NumCredits = numCredits;
            GPA = gpa;
            Name = name;
            StudentID = studentId;
            QualityScore = qs;
        }

        public Student(string name, int studentId) : this(name, studentId, 0, 0, 0)
        {
        }

        public Student(string name) : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public int StudentID
        {
            get { return studentID; }
            private set { studentID = value; }
        }

        public double QualityScore
        {
            get { return qualityScore; }
            private set { qualityScore = value; }
        }

        public abstract string GetGradeLevel();

        public void AddGrade(int courseCredits, double grade)
        {
            NumCredits += courseCredits;

            double qs = 0;
            if (grade > 89.4)
            {
                qs = 4;
            } else if (grade > 79.4)
            {
                qs = 3;
            } else if (grade > 69.4)
            {
                qs = 2;
            } else if (grade > 59.4)
            {
                qs = 1;
            } else
            {
                qs = 0;
            }
            QualityScore += (qs * courseCredits);

            GPA = QualityScore / NumCredits;
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Student s = obj as Student;

            if (StudentID.Equals(s.StudentID))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return StudentID + " " + Name + " - " + GPA;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
