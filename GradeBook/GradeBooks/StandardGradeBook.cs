using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook //Part2 Step 3- Create StandardGradeBook class: Create a StandardGradeBook class that inherits the BaseGradeBook class
    {
        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Standard; //Part2 Step 4- Update StandardGradeBook Type: Using the StandardGradeBook class's constructor set the Type property to GradeBookType.Standard
            IsWeighted = isWeighted;
        }
        
    }
    
}
