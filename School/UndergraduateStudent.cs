namespace School
{
    class UndergraduateStudent : Student
    {

        public UndergraduateStudent(string name) : base(name)
        {
        }

        public override string GetGradeLevel()
        {
            if (NumCredits < 30)
            {
                return "Freshman";
            }
            else if (NumCredits < 60)
            {
                return "Sophomore";
            }
            else if (NumCredits < 90)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }
    }
}
