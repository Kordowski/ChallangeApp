string userNumberInString;
int counter0=0,counter1=0, counter2=0, counter3 = 0, counter4 = 0, counter5 = 0, counter6 = 0, counter7 = 0, counter8 = 0, counter9 = 0;

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
        { counter0++; }
        else if (letter == '1')
        { counter1++; }
        else if (letter == '2')
        { counter2++; }
        else if (letter == '3')
        { counter3++; }
        else if (letter == '4')
        { counter4++; }
        else if (letter == '5')
        { counter5++; }
        else if (letter == '6')
        { counter6++; }
        else if (letter == '7')
        { counter7++; }
        else if (letter == '8')
        { counter8++; }
        else
        { counter9++; }
    }
    Console.WriteLine("Liczba po przeliczeniu ma następującą ilość cyfr:");
    Console.WriteLine("0 ==> " + counter0 + "razy");
    Console.WriteLine("1 ==> " + counter1 + "razy");
    Console.WriteLine("2 ==> " + counter2 + "razy");
    Console.WriteLine("3 ==> " + counter3 + "razy");
    Console.WriteLine("4 ==> " + counter4 + "razy");
    Console.WriteLine("5 ==> " + counter5 + "razy");
    Console.WriteLine("6 ==> " + counter6 + "razy");
    Console.WriteLine("7 ==> " + counter7 + "razy");
    Console.WriteLine("8 ==> " + counter8 + "razy");
    Console.WriteLine("9 ==> " + counter9 + "razy");
    

}








