Console.WriteLine("##### Week 3, Task 4 (3.4) #####");
Console.WriteLine("");

int turnsAmount;

while (true)
{
    Console.WriteLine("Podaj liczbę tur od 1 do 10: ");
    bool correctFormat = int.TryParse(Console.ReadLine(), out turnsAmount);

    if (!correctFormat)
    {
        Console.WriteLine("Wpisz liczbę całkowitą (Nie tekst, nie liczbę z przecinkiem pls)");
        continue;
    }

    if (turnsAmount < 1 || turnsAmount > 10)
    {
        Console.WriteLine("Ziomuś, ale w przedziale od 1 do 10 pls :()");
        continue;
    }
    break;
}
Console.WriteLine($"Wybrales {turnsAmount} tur.");
for (int turn = 1; turn <= turnsAmount; turn++)
{
    Console.WriteLine($"Tura nr: {turn}");
}

