namespace ChallangeApp.Tests
{
    public class EmployeeTests

    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StatisticsMinimumValueTest()
        {

            var employee = new Employee("Rafal", "Kordowski");
            employee.AddGrade(5);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Min, 4);

        }
        [Test]
        public void StatisticsMaximumValueTest()
        {
            var employee = new Employee("Rafal", "Kordowski");
            employee.AddGrade(5);
            employee.AddGrade(4);
            employee.AddGrade(6);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Max, 6);

        }



        [Test]
        public void StatisticsAverageValueTest()
        {
            var employee = new Employee("Rafal", "Kordowski");
            employee.AddGrade(5);
            employee.AddGrade(4);
            employee.AddGrade(6);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Average, 5);

        }

    }
}
