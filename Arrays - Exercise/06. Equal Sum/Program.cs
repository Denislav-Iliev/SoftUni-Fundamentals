int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
bool found = false;

for (int i = 0; i < numbers.Length; i++)
{
    int leftsum = 0;
    int rightsum = 0;
    for (int left = 0; left < i; left++)
    {
        leftsum +=  numbers[left];
    }
    for (int right = i + 1; right < numbers.Length; right++)
    {
        rightsum += numbers[right];
    }
    if (leftsum == rightsum)
    {
        Console.WriteLine(i);
        found = true;
        break;
    }

}
if (!found)
{
    Console.WriteLine("no");
}