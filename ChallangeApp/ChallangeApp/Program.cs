using ChallangeApp;

Employee employee1 = new("Rafał", "Kordowski", 24);
Employee employee2 = new("Weronika", "Adamiak", 30);
Employee employee3 = new("Agata", "Falęcka", 40);


employee1.AddGrade();
employee2.AddGrade();
employee3.AddGrade();

int maxResult = -1;
Employee employeeWithMaxResult = null;

List<Employee> employees = new()
        {
            employee1,employee2,employee3
        };

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}


Console.WriteLine("Pracownikiem z największą ilością punktów jest " + employeeWithMaxResult.FirstName + " " + employeeWithMaxResult.LastName + " z łączną ilością: " + maxResult + " punktów");