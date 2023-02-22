using ChallangeApp;

var employee = new Employee("Rafal", "Kordowski");

employee.AddGrade(5);
employee.AddGrade(2);
employee.AddGrade(3);


var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithFor();
var statistics2 = employee.GetStatisticsWithWhile();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithForEach();
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Average {statistics3.Average:N2}");



