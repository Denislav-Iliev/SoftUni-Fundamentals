using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    static void Main(string[] args)
    {
        int number = Math.Abs(int.Parse(Console.ReadLine()));
        int result = GetMultipleOfEvensAndOdds(number);
        Console.WriteLine(result);

    }
    static int GetMultipleOfEvensAndOdds(int number)
    {
        return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
    }
    static int GetSumOfEvenDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 0)
            {
                sum += digit;
            }
            number /= 10;
        }
        return sum;
    }
    static int GetSumOfOddDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 != 0)
            {
                sum += digit;
            }
            number /= 10;
        }
        return sum;
    }
}