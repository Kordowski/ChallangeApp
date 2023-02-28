
using System.Diagnostics;

namespace ChallangeApp
{
    public class EmployeeInFile : EmployeeBase
    {
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
                using (var writer = File.AppendText(fileName))
                {
                    switch (grade)
                    {
                        case "A":
                        case "a":
                            writer.WriteLine(100);
                            break;
                        case "B":
                        case "b":
                            writer.WriteLine(80);
                            break;
                        case "C":
                        case "c":
                            writer.WriteLine(60);
                            break;
                        case "D":
                        case "d":
                            writer.WriteLine(40);
                            break;
                        case "E":
                        case "e":
                            writer.WriteLine(20);
                            break;
                        default:
                            throw new Exception("Wrong Letter");
                    }
                }
            }

        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)
                {
                    writer.WriteLine(grade);
                }
                else
                {
                    throw new Exception("Invalid value");
                }
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics
            {
                Average = 0,
                Max = float.MinValue,
                Min = float.MaxValue
            };
            var counter = 0;
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        result.Max = Math.Max(result.Max, number);
                        result.Min = Math.Min(result.Min, number);
                        result.Average += number;
                        counter++;
                        line = reader.ReadLine();
                    }
                }
                result.Average /= counter;
                switch (result.Average)
                {
                    case var average when average >= 80:
                        result.AverageLetter = "A";
                        break;
                    case var average when average >= 60:
                        result.AverageLetter = "B";
                        break;
                    case var average when average >= 40:
                        result.AverageLetter = "C";
                        break;
                    case var average when average >= 20:
                        result.AverageLetter = "D";
                        break;
                    default:
                        result.AverageLetter = "E";
                        break;
                }

            }
            return result;
        }
    }
}
