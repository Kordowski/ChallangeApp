using ChallangeApp;

var employee = new Employee("Rafal", "Kordowski");

employee.AddGrade(5);
employee.AddGrade(611);
employee.AddGrade("Rafal");
employee.AddGrade("5");
employee.AddGrade(5); 
employee.AddGrade(9999999999999999999999.888888888888888888888888888888888888888888888888888888888);
employee.AddGrade('6');
employee.AddGrade('B');


var statistics = employee.GetStatistics();

Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average {statistics.Average:N2}");



