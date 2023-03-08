
using static ChallangeApp.EmployeeBase;

namespace ChallangeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        public void AddGrade(string grade);
        public void AddGrade(float grade);

        event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();

        
        


    }
}
