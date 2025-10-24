internal class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int smallestNumber = SmallestNumber(num1, num2, num3);
        Console.WriteLine(smallestNumber);
    }

    static int SmallestNumber(int num1, int num2, int num3)
    {
        int smallest = int.MaxValue;
        if (num1 < smallest)
        {
            smallest = num1; 
        }

        if (num2 < smallest)
        {
            smallest = num2;
        }

        if (num3 < smallest)
        {
            smallest = num3;
        }

        return smallest;
    }
}