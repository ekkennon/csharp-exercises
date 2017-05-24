namespace School
{
    class GraduateStudent : Student
    {
        public GraduateStudent(string name) : base(name)
        {
        }

        public override string GetGradeLevel()
        {
            if (NumCredits < 150)
            {
                return "Master's";
            }
            else
            {
                return "PhD";
            }
        }
    }
}
