using GradeBook.Enums;
using System;

namespace GradeBook.GradeBooks //Part2 Step5- Create RankedGradeBook Class: Create a new class RankedGradeBook that inherits the BaseGradeBook class.
{
    public class RankedGradeBook : BaseGradeBook 
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked; //Part2 Step 6- Update RankedGradeBook's Type: Create a constructor for RankedGradeBook that sets the Type property to GradeBookType.Ranked
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException("Ranked - grading requires a minimum of 5 students to work");

            var threshold = (int)Math.Ceiling(Students.Count * 0.2);

            return base.GetLetterGrade(averageGrade);

        }
    }
}
