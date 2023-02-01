namespace ChallangeApp
{
    public class Employee
    {
        int grade = 0;
        List<int> grades = new();
        List<int> negativeGrades = new();
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; } = 0;
        public int Score { get; private set; } = 0;

        public void AddGrade(int grade)
        {
            
          this.grades.Add(grade);
                
        }

        public void AddNegativeGrade(int negativeGrade)
        {
            this.negativeGrades.Add(negativeGrade);
        }


        public int Result
        {
            get
            {
                return (grades.Sum() + negativeGrades.Sum());
            }
        }

        public Employee(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
