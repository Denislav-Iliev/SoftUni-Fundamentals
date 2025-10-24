
class Program
{
    static void Main(string[] args)
    {
        int end = int.Parse(Console.ReadLine());

        for (int num = 1; num <= end; num++)
        {
            if (IsTopNumber(num))
            {
                Console.WriteLine(num);
            }
        }
    }

    static bool IsTopNumber(int number)
    {
        return SumOfDigitsDivisibleBy8(number) && HasOddDigit(number);
    }

    static bool SumOfDigitsDivisibleBy8(int number)
    {
        int sum = 0;
        int temp = number;

        while (temp > 0)
        {
            sum += temp % 10;   
            temp /= 10;        
        }

        return sum % 8 == 0;
    }

    static bool HasOddDigit(int number)
    {
        int temp = number;

        while (temp > 0)
        {
            int digit = temp % 10;
            if (digit % 2 != 0) 
            {
                return true;
            }
            temp /= 10;
        }

        return false;
    }
}

