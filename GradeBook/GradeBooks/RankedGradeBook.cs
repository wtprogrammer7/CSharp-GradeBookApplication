using GradeBook.Enums;
using System;
using System.Linq;

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
            { 
                throw new InvalidOperationException("You must have at least 5 students to do ranked grading.");
            }         
            
            var threshold = (int)Math.Ceiling(Students.Count * 0.2);
            var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();
            
            if(grades[threshold-1] <= averageGrade)
            
                return 'A';
            
            if (grades[threshold*2 - 1] <= averageGrade)
            
                return 'B';
            
            if (grades[threshold * 3 - 1] <= averageGrade)
            
                return 'C';
            
            if (grades[threshold * 4 - 1] <= averageGrade)
            
                return 'D';
            
            return 'F';
            
            //return base.GetLetterGrade(averageGrade);
        }
    }
}
