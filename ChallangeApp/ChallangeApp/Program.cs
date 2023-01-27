string userNumberInString;
int zero=0,jeden=0, dwa=0, trzy=0, cztery = 0, piec = 0, szesc = 0, siedem = 0, osiem = 0, dziewiec = 0;

Console.WriteLine("Podaj liczbę do policzenia: ");
userNumberInString = Console.ReadLine();
DigitCounter(userNumberInString);

void DigitCounter (string NumberInString)
{
    char[] letters = NumberInString.ToArray();
    foreach (char letter in letters)
    {
        Console.WriteLine(letter);
        if(letter == '0')
        { zero++; }
        else if (letter == '1')
        { jeden++; }
        else if (letter == '2')
        { dwa++; }
        else if (letter == '3')
        { trzy++; }
        else if (letter == '4')
        { cztery++; }
        else if (letter == '5')
        { piec++; }
        else if (letter == '6')
        { szesc++; }
        else if (letter == '7')
        { siedem++; }
        else if (letter == '8')
        { osiem++; }
        else
        { dziewiec++; }
    }
    Console.WriteLine("Liczba po przeliczeniu ma następującą ilość cyfr:");
    Console.WriteLine("0 ==> " + zero + "razy");
    Console.WriteLine("1 ==> " + jeden + "razy");
    Console.WriteLine("2 ==> " + dwa + "razy");
    Console.WriteLine("3 ==> " + trzy + "razy");
    Console.WriteLine("4 ==> " + cztery + "razy");
    Console.WriteLine("5 ==> " + piec + "razy");
    Console.WriteLine("6 ==> " + szesc + "razy");
    Console.WriteLine("7 ==> " + siedem + "razy");
    Console.WriteLine("8 ==> " + osiem + "razy");
    Console.WriteLine("9 ==> " + dziewiec + "razy");
    

}








