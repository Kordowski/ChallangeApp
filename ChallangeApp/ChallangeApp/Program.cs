using ChallangeApp;

Console.WriteLine("Witaj w programie pomagającym liczyć oceny pracowników");
Console.WriteLine("*******************************************************");
Console.WriteLine();

string name;
string surname;
int index;
string input;




Console.WriteLine("Podaj imię dla pracownika: " );
name = Console.ReadLine();
Console.WriteLine("Podaj nazwisko dla pracownika: ");
surname = Console.ReadLine();

    var employee = new Employee(name, surname);

Console.WriteLine("Aby wyjść z wpisywania ocen wpisz 'q'");

while (true)
{
    Console.Write("Podaj ocenę dla pracownika: ");
    input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    { 
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
};



var statistics = employee.GetStatistics();

Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average {statistics.Average:N2}");
Console.WriteLine($"Average Letter {statistics.AverageLetter}");



