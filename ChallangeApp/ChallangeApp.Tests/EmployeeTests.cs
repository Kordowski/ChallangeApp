using System.Reflection.Metadata;

namespace ChallangeApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenEmployeeCollectNegativeAndPositiveGrades()
        {
            // arrange

            var employee = new Employee("Rafal","Kordowski",24);
            employee.AddGrade(5);
            employee.AddGrade(4);
            employee.AddNegativeGrade(-9);



            //act
            var result = employee.Result;


            //assert

            Assert.AreEqual(0,result);

           
        }

        [Test]
        public void WhenEmployeeCollect2NegativeGrades()
        {
            // arrange

            var employee = new Employee("Rafal", "Kordowski", 24);
            employee.AddGrade(-4);
            employee.AddGrade(-5);
            



            //act
            var result = employee.Result;


            //assert

            Assert.AreEqual(-9, result);


        }
    }
}