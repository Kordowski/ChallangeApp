using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallangeApp
{

    internal class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {


        }

        

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {

                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }

            }
            else
            {
                throw new Exception("Nieprawidłowa wartość");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                switch (grade)
                {
                    case "A":
                    case "a":
                        this.grades.Add(100);
                        break;
                    case "B":
                    case "b":
                        this.grades.Add(80); 
                        break; 
                    case "C":
                    case "c":
                        this.grades.Add(60);
                        break;
                    case "D":
                    case "d":
                        this.grades.Add(40);
                        break;
                    case "E":
                    case "e":
                        this.grades.Add(20);
                        break;
                    default:
                        throw new Exception("Wrong Letter");
                }
            }
        }


        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
           foreach(var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}
