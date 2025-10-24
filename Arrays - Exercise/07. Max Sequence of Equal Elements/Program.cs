
class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        if (arr.Length == 0) return;

        int bestLen = 1;
        int bestValue = arr[0];

        int currLen = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currLen++;
            }
            else
            {
                currLen = 1;
            }

            
            if (currLen > bestLen)
            {
                bestLen = currLen;
                bestValue = arr[i];
            }
        }

        
        Console.WriteLine(string.Join(' ', Enumerable.Repeat(bestValue, bestLen)));
    }
}
