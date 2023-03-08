using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallangeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;

        public EmployeeBase(string name, string surname)
        {
            Name = name;
            Surname = surname;

        }

        public string Name { get; set; }
        public string Surname { get; set; }


        public abstract void AddGrade(string grade);


        public abstract void AddGrade(float grade);

        public abstract Statistics GetStatistics();



    }
}
