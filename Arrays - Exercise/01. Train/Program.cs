int countWagon = int.Parse(Console.ReadLine());
int[] passengers = new int[countWagon];
int totalpassengers = 0;

for (int i = 0; i < countWagon; i++)
{
    passengers[i] += int.Parse(Console.ReadLine());
    totalpassengers += passengers[i];
}
for (int j = 0; j < countWagon; j++)
{
    Console.Write($"{passengers[j]} ");
}
Console.WriteLine();
Console.WriteLine(totalpassengers);