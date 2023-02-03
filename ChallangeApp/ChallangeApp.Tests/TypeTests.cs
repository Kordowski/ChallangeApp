using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            // arrange
            var employee1 = GetEmployee("Tomasz");
            var employee2 = GetEmployee("Rafaell");

            //act


            //assert

            Assert.AreNotEqual(employee1, employee2);

        }



        [Test]
        public void IntegerNumber1ShouldntBeEqualNumber2()
        {
            // arrange
            int number1 = 77;
            int number2 = 77;

            //act


            //assert

            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void StringName1ShouldntBeEqualName2()
        {
            // arrange
            string name1 = "Roman";
            string name2  = "Roman";

            //act


            //assert

            Assert.AreEqual(name1, name2);

        }



        [Test]
        public void DoubleNumber1ShouldBeEqualNumber2()
        {
            // arrange
            double number1 = 1.878;
            double number2 = 1.878;



            //act


            //assert

            Assert.AreEqual(number1, number2);

        }

        private Employee GetEmployee(string FirstName)
        {
            return new Employee(FirstName);
        }
    }
}
