class Program
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        long firstFactoriel = FirstFactoriel(firstNum);
        long secondFactoriel = SecondFactoriel(secondNum);
        double output = Divide(firstFactoriel, secondFactoriel);
        Console.WriteLine($"{output:F2}");
    }
    static long FirstFactoriel(int firstNum)
    {
        long factoriel = 1;
        for (int i = 1; i <= firstNum; i++)
        {
            factoriel *= i;
        }
        return factoriel;
    }
    static long SecondFactoriel(int secondNum)
    {
        long factoriel = 1;
        for (int i = 1; i <= secondNum; i++)
        {
            factoriel *= i;
        }
        return factoriel;
    }
    static double Divide(long firstFactoriel, long secondFactoriel)
    {
        double output = (double)firstFactoriel / secondFactoriel;
        return output;
    }
}