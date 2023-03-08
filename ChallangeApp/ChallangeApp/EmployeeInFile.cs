
using System.Diagnostics;
using System.Net.Sockets;

namespace ChallangeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname) : base(name, surname)
        {

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
                        AddGrade(100);
                        break;
                    case "B":
                    case "b":
                        AddGrade(80);
                        break;
                    case "C":
                    case "c":
                        AddGrade(60);
                        break;
                    case "D":
                    case "d":
                        AddGrade(40);
                        break;
                    case "E":
                    case "e":
                        AddGrade(20);
                        break;
                    default:
                        throw new Exception("Wrong Letter");
                }
            }

        }

        public override void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid value");
            }
        }

        public override Statistics GetStatistics()
        {

            var statistics = new Statistics();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        float.TryParse(line, out var value);
                        statistics.AddGrade(value);
                        line = reader.ReadLine();
                    }
                }
            }
            return statistics;
        }
    }
}


      
