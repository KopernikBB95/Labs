Console.WriteLine("##### Week 3, Task 2 #####");
Console.WriteLine("");

Console.WriteLine("Podaj ilość dni wyprawy (1-7 pls)");
int adventureDays = int.Parse(Console.ReadLine()!);
int goodDays = 0;
int totalGold = 0;

for (int days = 1; days <= adventureDays; days++)
{
    Console.WriteLine($"Podaj ilość złota zdobytego dnia nr {days}:");
    int gold = int.Parse(Console.ReadLine()!);
    totalGold += gold;
    if (gold > 10)
    {
        goodDays ++;
    }
}
Console.WriteLine($"Łączna ilość złota: {totalGold}");
Console.WriteLine($"Dni w których zdobyte złoto > 10: {goodDays}");