using System;

internal class Program
{
    static void Main(string[] args)
    {
        char first = char.Parse(Console.ReadLine());
        char second = char.Parse(Console.ReadLine());

        PrintCharactersInRange(first, second);
    }

    static void PrintCharactersInRange(char start, char end)
    {
        if (start > end)
        {
            char temp = start;
            start = end;
            end = temp;
        }

        for (int i = start + 1; i < end; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}
