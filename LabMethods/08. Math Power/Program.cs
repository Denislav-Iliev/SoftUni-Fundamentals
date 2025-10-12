internal class Program
{
    static void Main(string[] args)
    {
        double baseNumber = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        double result = Power(baseNumber, power);
        Console.WriteLine(result);

    }
    static double Power(double baseNumber, int power)
    {
        double result = 1;
        for (int i = 1; i <= power; i++)
        {
            result *= baseNumber;
        }
        return result;

    }
}