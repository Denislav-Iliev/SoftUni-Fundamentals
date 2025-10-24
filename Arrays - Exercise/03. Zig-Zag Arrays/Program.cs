int input = int.Parse(Console.ReadLine());
int[] firstArray = new int[input];
int[] secondArray = new int[input];
for (int i = 0; i < input; i++)
{
    string[] numbers = Console.ReadLine().Split();
    int firstNum = int.Parse(numbers[0]);
    int secondNum = int.Parse(numbers[1]);
    if (i % 2 == 0)
    {
        firstArray[i] = firstNum;
        secondArray[i] = secondNum;
    }
    else
    {
        firstArray[i] = secondNum;
        secondArray[i] = firstNum;
    }
}
Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));