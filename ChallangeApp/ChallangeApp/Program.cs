var age = 0;
var isMale = true;
var name = "";
var check = "";


Console.WriteLine("Podaj imie do sprawdzenia: ");
name = Console.ReadLine();
Console.WriteLine("Podaj wiek do sprawdzenia: ");
age = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Jakiej jesteś płci? Mężczyzna czy Kobieta?");
check = Console.ReadLine();

if (check == "Mężczyzna")
{
    isMale = true;
}
else if (check == "Kobieta")
{
    isMale = false;
}
else
{
    Console.Error.WriteLine("Podałeś złą płeć");
    return;
}


if (isMale)
{
    Console.WriteLine("Mężczyzna");
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni");
    }
    else
    {
        Console.WriteLine("Pełnoletni");
    }
}
else
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else
    {
        Console.WriteLine("Inna kobieta powyżej 30 lat");
    }
}










