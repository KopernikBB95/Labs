Console.WriteLine("##### Week 3, Task 3 (3.3) #####");
Console.WriteLine("");

int rowMax;

while (true)
{
   Console.WriteLine("Podaj wysokość choinki. (Liczba od 2-10 pls)");
   bool correctRowMax = int.TryParse(Console.ReadLine(), out rowMax);
if (!correctRowMax)
    {
        Console.WriteLine("Podaj liczbę od 2-10. Nie tekst, nie liczbę z przecinkiem");
        continue;
    }
if (rowMax < 2 || rowMax > 10)
    {
        Console.WriteLine("Podaj liczbe w przedziale 2-10 pls");
        continue;
    }
    break;
}

for (int row = 1; row <= rowMax; row++)
{
    for (int space = 1; space <= rowMax-row; space ++)
    {
         Console.Write(" ");
    }
    for (int col = 1; col <= 2*row-1; col++)
    {
        Console.Write($"*");
    }
    Console.WriteLine();
}
for (int space = 1; space <= rowMax-1; space ++)
{
    Console.Write(" ");
} 
Console.Write("*");
Console.WriteLine();

        Console.WriteLine("     *");                  
        Console.WriteLine("    ***");                
        Console.WriteLine("   *****");               
        Console.WriteLine("  *******");              
        Console.WriteLine(" *********");             
        Console.WriteLine("***********");            
        Console.WriteLine("     *");
