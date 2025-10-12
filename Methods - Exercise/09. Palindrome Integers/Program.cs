class Program
{
    static void Main()
    {
        string command = "";
        while ((command = Console.ReadLine()) != "END")
        {
            Console.WriteLine(IsPalindrome(command));
        }
    }
    static bool IsPalindrome(string symbols)
    {
        string reversedString = Reverse(symbols);
        return reversedString == symbols;
    }
    static string Reverse(string symbols)
    {
        char[] reversedArr = symbols.ToCharArray();
        Array.Reverse(reversedArr);
        return new string(reversedArr);
    }
}