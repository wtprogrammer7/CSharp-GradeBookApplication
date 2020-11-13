﻿using GradeBook.Enums;

namespace GradeBook.GradeBooks //Part2 Step5- Create RankedGradeBook Class: Create a new class RankedGradeBook that inherits the BaseGradeBook class.
{
    public class RankedGradeBook : BaseGradeBook 
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

    }
}
