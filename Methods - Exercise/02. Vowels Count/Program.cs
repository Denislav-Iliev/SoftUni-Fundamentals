internal class Program
{
    static void Main(string[] args)
    {
        string input = (Console.ReadLine());
        int vowels = Vowels(input);
        Console.WriteLine(vowels);

    }

    static int Vowels(string input)
    {
        input = input.ToLower();
        int vowel = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'a' || input[i] == 'o' || input[i] == 'u' || input[i] == 'e' || input[i] == 'i')
            {
                vowel++;
            }
        }
        return vowel;
    }
}