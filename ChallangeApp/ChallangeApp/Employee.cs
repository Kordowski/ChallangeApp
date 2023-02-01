
using System.Reflection.Metadata;

namespace ChallangeApp
{
    public class Employee
    {
        int grade = 0;
        new List<int> Grades = new List<int>();
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; } = 0;
        public int Score { get; private set; } = 0;

        public void AddGrade()
        {
            for (int i = 0; i < 5; i++)
            {
                {
                    Console.WriteLine("Dodaj " + (i + 1) + " ocenę dla pracownika " + FirstName + " " + LastName);
                    grade = Convert.ToInt32(Console.ReadLine());
                    if (grade > 0 && grade < 11)
                    {
                        this.Grades.Add(grade);
                    }
                    else
                    {
                        Console.WriteLine("Wprowadź ocenę z zakresu od 1 do 10!");
                        i--;
                    }
                }
            }
            Console.Clear();
        }

        public int Result
        {
            get
            {
                return this.Grades.Sum();
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
