int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] arrayTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();
int sumOne = 0;
bool areEqual = true;

for (int i = 0; i < arrayOne.Length; i++)
{
    if (arrayOne[i] != arrayTwo[i])
    {
        areEqual = false;
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        break;
    }
    sumOne += arrayOne[i];
}
if (areEqual)
{
    Console.WriteLine($"Arrays are identical. Sum: {sumOne}");
}


