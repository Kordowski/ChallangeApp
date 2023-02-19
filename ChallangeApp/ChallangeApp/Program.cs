using ChallangeApp;

var employee = new Employee("Rafal", "Kordowski");

employee.AddGrade(5);
employee.AddGrade(611);

var statistics = employee.GetStatistics();

Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average {statistics.Average:N2}");



