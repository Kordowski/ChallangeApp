using ChallangeApp;
using System.ComponentModel.DataAnnotations;




Console.WriteLine("Witaj w programie pomagającym liczyć oceny pracowników");
Console.WriteLine("*******************************************************");
Console.WriteLine();

string name;
string surname;
string input;

Console.WriteLine("Podaj imię dla pracownika: ");
name = Console.ReadLine();
Console.WriteLine("Podaj nazwisko dla pracownika: ");
surname = Console.ReadLine();
Console.WriteLine("Chcesz zapisać na dysku czy w pamięci?");
Console.WriteLine("Wybierz '1' dla zapisania w pliku, wybierz '2' dla zapisania w pamięci");
var input2 = Console.ReadLine();

IEmployee employee;

switch (input2)
{
    case "1":
        employee = new EmployeeInFile(name, surname);
        employee.GradeAdded += EmployeeGradeAdded;
        break;
    case "2":
        employee = new EmployeeInMemory(name, surname);
        employee.GradeAdded += EmployeeGradeAdded;
        break;
    default:
        throw new Exception();

}


void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}



Console.WriteLine("aby wyjść z wpisywania ocen wpisz 'q'");

while (true)
{
    Console.Write("podaj ocenę dla pracownika: ");
    input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
};


var statistics = employee.GetStatistics();

Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average {statistics.Average:N2}");
Console.WriteLine($"Average Letter {statistics.AverageLetter}");





