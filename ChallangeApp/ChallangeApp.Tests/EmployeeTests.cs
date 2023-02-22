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

            Assert.AreEqual(4, statistics.Min);

        }
        [Test]
        public void StatisticsMaximumValueTest()
        {
            var employee = new Employee("Rafal", "Kordowski");
            employee.AddGrade(5);
            employee.AddGrade(4);
            employee.AddGrade(6);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(6, statistics.Max);

        }



        [Test]
        public void StatisticsAverageValueTest()
        {
            var employee = new Employee("Rafal", "Kordowski");
            employee.AddGrade(5);
            employee.AddGrade(4);
            employee.AddGrade(6);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(5, statistics.Average);

        }

    }
}
