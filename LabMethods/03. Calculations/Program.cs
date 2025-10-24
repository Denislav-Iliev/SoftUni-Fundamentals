internal class Program
{
    static void Main(string[] args)
    {
        string function = Console.ReadLine();
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        if (function == "add")
        {
            Add(firstNumber, secondNumber);
        }
        else if (function == "multiply")
        {
            Multiply(firstNumber, secondNumber);
        }
        else if (function == "subtract")
        {
            Subtract(firstNumber, secondNumber);
        }
        else if (function == "divide")
        {
            Divide(firstNumber, secondNumber);
        }




    }
    static void Add(int firstNumber, int secondNumber)
    {
        Console.WriteLine(firstNumber + secondNumber);
    }
    static void Multiply(int firstNumber, int secondNumber)
    {
        Console.WriteLine(firstNumber * secondNumber);
    }
    static void Subtract(int firstNumber, int secondNumber)
    {
        Console.WriteLine(firstNumber - secondNumber);
    }
    static void Divide(int firstNumber, int secondNumber)
    {
        Console.WriteLine(firstNumber / secondNumber);
    }
}