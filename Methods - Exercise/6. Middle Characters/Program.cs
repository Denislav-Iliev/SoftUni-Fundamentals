class Program
{
    static void Main()
    {
        string output = Console.ReadLine();
        PrintMiddleChars(output);
    }
    static void PrintMiddleChars(string text)
    {
        int middleIndex = text.Length / 2;
        string result = $"{text[middleIndex]}";
        if (text.Length % 2 == 0)
        {
            result = $"{text[middleIndex - 1]}" + result;
        }
        Console.WriteLine(result);
    }
}