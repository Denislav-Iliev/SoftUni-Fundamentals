internal class Program
{
    static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());
        int sum = Sum(firstNum, secondNum);
        int subtract = Subtract(firstNum, secondNum, thirdNum);
        Console.WriteLine(subtract);

    }
    static int Sum(int firstNum, int secondNum)
    {
        int sum = firstNum + secondNum;
        return sum;
    }
    static int Subtract(int firstNum, int secondNum, int thirdNum)
    {
        int sum = firstNum + secondNum;
        int subtract = sum - thirdNum;
        return subtract;
    }
}