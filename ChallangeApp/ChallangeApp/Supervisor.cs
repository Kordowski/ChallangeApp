
namespace ChallangeApp
{
    internal class Supervisor : IEmployee
    {

        public Supervisor(string name, string surname)
        {
            this.Surname = surname;
            this.Name = name;
        }

        public string Surname { get; private set; }
        public string Name { get; private set; }


        private List<float> grades = new List<float>();


        public void AddGrade(string grade)
        {

            var caloscZOceny = grade.Replace("-", "").Replace("+", "");

            var test = int.TryParse(caloscZOceny, out var oc);
            if (!test || 1 > oc || oc > 6)
                throw new ArgumentException();

            int punkty;

            if (oc == 1)
                punkty = 10;
            else
                punkty = 100 - (6 - oc) * 20;

            if (grade == "-1" || grade == "1-")
                throw new ArgumentException();

            else if (grade == "+6" || grade == "6+")
                 throw new ArgumentException();



            if (grade.Contains("-"))
                punkty -= 5;
            else if (grade.Contains("+"))
                punkty += 5;

            this.grades.Add(punkty);
        }

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }




        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = "A";
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = "B";
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = "C";
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = "D";
                    break;
                default:
                    statistics.AverageLetter = "E";
                    break;
            }
            return statistics;
        }

    }
}
