using System;

internal class Program
{
    static void Main(string[] args)
    {
        string password = Console.ReadLine();

        bool isLengthValid = IsLengthValid(password);
        bool isLettersAndDigits = IsLettersAndDigits(password);
        bool hasTwoDigits = HasAtLeastTwoDigits(password);

        if (isLengthValid && isLettersAndDigits && hasTwoDigits)
        {
            Console.WriteLine("Password is valid");
        }
    }

    static bool IsLengthValid(string password)
    {
        if (password.Length < 6 || password.Length > 10)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
            return false;
        }
        return true;
    }

    static bool IsLettersAndDigits(string password)
    {
        foreach (char ch in password)
        {
            if (!char.IsLetterOrDigit(ch))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }
        }
        return true;
    }

    static bool HasAtLeastTwoDigits(string password)
    {
        int digitCount = 0;
        foreach (char ch in password)
        {
            if (char.IsDigit(ch)) digitCount++;
        }

        if (digitCount < 2)
        {
            Console.WriteLine("Password must have at least 2 digits");
            return false;
        }
        return true;
    }
}
