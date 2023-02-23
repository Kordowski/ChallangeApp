namespace ChallangeApp.Tests
{
    public class EmployeeTests

    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddGradeShouldReturnAGrade()
        {

            var employee = new Employee("Rafal", "Kordowski","Cleaner","Mê¿czyna");

            employee.AddGrade("A");
            employee.AddGrade("a");
            employee.AddGrade("b");
            employee.AddGrade(100);

            var statistics = employee.GetStatistics();

            Assert.AreEqual("A", statistics.AverageLetter);

        }
        [Test]
        public void AddGradeShouldReturnBGrade()
        {

            var employee = new Employee("Rafal", "Kordowski","Boss", "Mê¿czyna");

            employee.AddGrade('b');
            employee.AddGrade("B");
            employee.AddGrade("b");
            employee.AddGrade(60);

            var statistics = employee.GetStatistics();

            Assert.AreEqual("B", statistics.AverageLetter);

        }


    }
}

