internal class Program
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        string operatorr = Console.ReadLine();
        int secondNumber = int.Parse(Console.ReadLine());
        double result = Calculations(firstNumber, operatorr, secondNumber);
        Console.WriteLine(result);




    }
    static double Calculations(int firstNumber,string operatorr, int secondNumber)
    {
        double result = 0;
        switch (operatorr)
        {
                case "+":
                result = firstNumber + secondNumber;
                break;
                case "-":
                result = firstNumber - secondNumber;
                break;
                case "*":
                result = firstNumber * secondNumber;
                break;
                case "/":
                result = (double)firstNumber / secondNumber;
                break;
        }
        return result;
    }

}

