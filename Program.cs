Console.WriteLine("##### TASK 1 WEEK 4 #####");
Console.WriteLine("");

int number = 1;
Console.Write("1st way: WHILE loop: ");
while (number < 11)
{
    Console.Write($"{number} ");
    number++;
}

number = 1;

Console.WriteLine("");
Console.Write("2nd way: DO - WHILE loop: ");

do
{
    Console.Write($"{number} ");
    number++;
}
while (number < 11);

Console.WriteLine("");
Console.Write("3rd way: FOR loop: ");

for (number = 1; number < 11; number++)
    Console.Write($"{number} ");

Console.WriteLine("");
Console.Write("Rosnąco: ");
for (number = 1; number < 11; number++)
    Console.Write($"{number} ");

Console.WriteLine("");
Console.Write("Malejąco: ");
for (number = 10; number > 0; number--)
    Console.Write($"{number} ");

Console.WriteLine("");
Console.Write("Parzyste: ");
for (number = 2; number < 21; number = number + 2)
    Console.Write($"{number} ");

Console.WriteLine("");
Console.WriteLine("Start!");