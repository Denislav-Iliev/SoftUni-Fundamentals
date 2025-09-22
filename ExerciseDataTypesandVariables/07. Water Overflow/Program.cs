int tank = 255;
int inputs = int.Parse(Console.ReadLine());
int totalLiters = 0;

for (int i = 1; i <= inputs; i++)
{
    int addedLiters = int.Parse(Console.ReadLine());
    if (totalLiters + addedLiters > tank)
    {
        Console.WriteLine("Insufficient capacity!");
    }
    else
    {
        totalLiters += addedLiters;
    }
}
Console.WriteLine(totalLiters);