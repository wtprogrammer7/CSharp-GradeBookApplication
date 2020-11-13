using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        Type = GradeBookType.Standard;
    }
    
}
